function Get-KbUpdate {
    [CmdletBinding()]
    param(
        [Parameter(Mandatory)]
        [Alias("Name", "HotfixId", "KBUpdate", "Id")]
        [string[]]$Pattern,
        [string[]]$Architecture,
        [string[]]$OperatingSystem,
        [PSFComputer[]]$ComputerName,
        [pscredential]$Credential,
        [string[]]$Product,
        [string[]]$Language,
        [switch]$Simple,
        [switch]$Latest,
        [switch]$Force,
        [switch]$NoMultithreading,
        [ValidateSet("Wsus", "Web", "Database")]
        [string[]]$Source = @("Web", "Database"),
        [switch]$EnableException
    )
    begin {
        $script:allresults = @()
        function Get-GuidsFromWeb ($kb) {
            Write-PSFMessage -Level Verbose -Message "$kb"
            Write-Progress -Activity "Searching catalog for $kb" -Id 1 -Status "Contacting catalog.update.microsoft.com"
            if (-not $kbids) {
                $url = "https://www.catalog.update.microsoft.com/Search.aspx?q=$kb"
                $boundparams.OperatingSystem = $OperatingSystem
                Write-PSFMessage -Level Verbose -Message "Failing back to $url"
                $results = Invoke-TlsWebRequest -Uri $url
                $kbids = $results.InputFields |
                Where-Object { $_.type -eq 'Button' -and $_.Value -eq 'Download' } |
                Select-Object -ExpandProperty  ID
            }
            Write-Progress -Activity "Searching catalog for $kb" -Id 1 -Completed

            if (-not $kbids) {
                try {
                    $null = Invoke-TlsWebRequest -Uri "https://support.microsoft.com/app/content/api/content/help/en-us/$kb"
                    Stop-PSFFunction -EnableException:$EnableException -Message "Matches were found for $kb, but the results no longer exist in the catalog"
                    return
                } catch {
                    Write-PSFMessage -Level Verbose -Message "No results found for $kb at microsoft.com"
                    return
                }
            }

            Write-PSFMessage -Level Verbose -Message "$kbids"

            $resultlinks = $results.Links |
            Where-Object ID -match '_link' |
            Where-Object { $_.OuterHTML -match ( "(?=.*" + ( $Filter -join ")(?=.*" ) + ")" ) }

            $guids = @()
            foreach ($resultlink in $resultlinks) {
                $itemguid = $resultlink.id.replace('_link', '')
                $itemtitle = ($resultlink.outerHTML -replace '<[^>]+>', '').Trim()
                if ($itemguid -in $kbids) {
                    $guids += [pscustomobject]@{
                        Guid  = $itemguid
                        Title = $itemtitle
                    }
                }
            }
            $guids | Where-Object Guid -notin $script:allresults
        }

        function Get-KbItemFromWeb ($kb) {
            function Get-Info ($Text, $Pattern) {
                if ($Pattern -match "labelTitle") {
                    [regex]::Match($Text, $Pattern + '[\s\S]*?\s*(.*?)\s*<\/div>').Groups[1].Value
                } elseif ($Pattern -match "span ") {
                    [regex]::Match($Text, $Pattern + '(.*?)<\/span>').Groups[1].Value
                } else {
                    [regex]::Match($Text, $Pattern + "\s?'?(.*?)'?;").Groups[1].Value
                }
            }

            function Get-SuperInfo ($Text, $Pattern) {
                $span = [regex]::match($Text, $pattern + '[\s\S]*?<div id')

                switch -Wildcard ($span.Value) {
                    "*div style*" { $regex = '">\s*(.*?)\s*<\/div>' }
                    "*a href*" { $regex = "<div[\s\S]*?'>(.*?)<\/a" }
                    default { $regex = '"\s?>\s*(\S+?)\s*<\/div>' }
                }

                $spanMatches = [regex]::Matches($span, $regex).ForEach( { $_.Groups[1].Value })
                if ($spanMatches -eq 'n/a') { $spanMatches = $null }

                if ($spanMatches) {
                    foreach ($superMatch in $spanMatches) {
                        $detailedMatches = [regex]::Matches($superMatch, '\b[kK][bB]([0-9]{6,})\b')
                        if ($null -ne $detailedMatches.Groups) {
                            [PSCustomObject] @{
                                'KB'          = $detailedMatches.Groups[1].Value
                                'Description' = $superMatch
                            } | Add-Member -MemberType ScriptMethod -Name ToString -Value { $this.Description } -PassThru -Force
                        }
                    }
                }
            }

            try {
                $guids = Get-GuidsFromWeb -kb $kb

                foreach ($item in $guids) {
                    $guid = $item.Guid
                    $itemtitle = $item.Title
                    $hashkey = "$guid-$Simple"
                    if ($script:kbcollection.ContainsKey($hashkey)) {
                        $guids = $guids | Where-Object Guid -notin $guid
                        $script:kbcollection[$hashkey]
                        continue
                    }
                }

                $scriptblock = {
                    $guid = $psitem.Guid
                    $itemtitle = $psitem.Title
                    Write-Verbose -Message "Downloading information for $itemtitle"
                    $post = @{ size = 0; updateID = $guid; uidInfo = $guid } | ConvertTo-Json -Compress
                    $body = @{ updateIDs = "[$post]" }
                    Invoke-TlsWebRequest -Uri 'https://www.catalog.update.microsoft.com/DownloadDialog.aspx' -Method Post -Body $body | Select-Object -ExpandProperty Content
                }

                if ($guids.Count -gt 2 -and -not $NoMultithreading) {
                    $downloaddialogs = $guids | Invoke-Parallel -ImportVariables -ImportFunctions -ScriptBlock $scriptblock -ErrorAction Stop -RunspaceTimeout 60
                } else {
                    $downloaddialogs = $guids | ForEach-Object -Process $scriptblock
                }

                foreach ($downloaddialog in $downloaddialogs) {
                    $title = Get-Info -Text $downloaddialog -Pattern 'enTitle ='
                    $arch = Get-Info -Text $downloaddialog -Pattern 'architectures ='
                    $updateid = Get-Info -Text $downloaddialog -Pattern 'updateID ='
                    $detaildialog = Invoke-TlsWebRequest -Uri "https://www.catalog.update.microsoft.com/ScopedViewInline.aspx?updateid=$updateid"
                    $description = Get-Info -Text $detaildialog -Pattern '<span id="ScopedViewHandler_desc">'
                    $size = Get-Info -Text $detaildialog -Pattern '<span id="ScopedViewHandler_size">'
                    $hashkey = "$updateid-$Simple"
                  
                    if ($arch -eq "") {
                        continue
                    }
                    if ($arch -eq "AMD64") {
                        $arch = "x64"
                    }
                    if ($title -match '64-Bit' -and $title -notmatch '32-Bit' -and -not $arch) {
                        $arch = "x64"
                    }
                    if ($title -notmatch '64-Bit' -and $title -match '32-Bit' -and -not $arch) {
                        continue
                    }

                    $downloaddialog = $downloaddialog.Replace('www.download.windowsupdate', 'download.windowsupdate')
                    $links = $downloaddialog | Select-String -AllMatches -Pattern "(http[s]?\://download\.windowsupdate\.com\/[^\'\""]*)" | Select-Object -Unique

                    foreach ($link in $links) {
                        if ($kbnumbers -eq "n/a") {
                            $kbnumbers = $null
                        }
                        $properties = $baseproperties

                        if ($Simple) {
                            $properties = $properties | Where-Object { $PSItem -notin "Architecture", "Link",  "Id" }
                        }

                        $null = $script:kbcollection.Add($hashkey, (
                                [pscustomobject]@{
                                    Title             = $title
                                    Id                = $kbnumbers
                                    Architecture      = $arch
                                    Size              = $size
                                    Link              = $link.matches.value
                                    InputObject       = $kb
                                }))
                        $script:kbcollection[$hashkey]
                    }
                }
            } catch {
                Stop-PSFFunction -EnableException:$EnableException -Message "Failure" -ErrorRecord $_ -Continue
            }
        }

        $properties = "Title",
        "Id",
        "Architecture",
        "Size",
        "Link"

        if ($Simple) {
            $properties = $properties | Where-Object { $PSItem -notin "Architecture", "Link", "Id" }
        }
        # if latest is used, needs a collection
        $allkbs = @()

    }
    process {
        $boundparams = @{
            Architecture    = $Architecture
            Product         = $PSBoundParameters.Product
            Language        = $PSBoundParameters.Language
            Source          = $Source
        }

        foreach ($kb in $Pattern) {
            $results = @()
            if ($Source -contains "Web") {
                $results += Get-KbItemFromWeb $kb
            }
            $allkbs += $results
        }
    }
    end {
        $allkbs | Search-Kb @boundparams | Format-List -Property $properties | out-string
    }
}