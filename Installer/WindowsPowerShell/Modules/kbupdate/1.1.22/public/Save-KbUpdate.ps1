function Save-KbUpdate {
    [CmdletBinding()]
    param(
        [Alias("Name", "HotfixId", "KBUpdate", "Id")]
        [string[]]$Pattern,
        [string]$Path = ".",
        [string]$FilePath,
        [string[]]$Architecture,
        [string[]]$OperatingSystem,
        [string[]]$Product,
        [string[]]$Language,
        [parameter(ValueFromPipeline)]
        [pscustomobject[]]$InputObject,
        [switch]$Latest,
        [switch]$AllowClobber,
        [ValidateSet("Wsus", "Web", "Database")]
        [string[]]$Source = @("Web", "Database"),
        [switch]$Strict,
        [switch]$EnableException
    )
    begin {
        $files = @()
    }
    process {
        foreach ($kb in $Pattern) {
            $params = @{
                Pattern         = $kb
                Architecture    = $Architecture
                Simple          = $Simple
            }
            $InputObject += GetDown-KbUpdate @params
        }

        foreach ($object in $InputObject) {
            if ($Architecture) {
                $templinks = @()
                foreach ($arch in $Architecture) {
                    $templinks += $object.Link | Where-Object { $PSItem -match "$($arch)_" }

                    if ("x64" -eq $arch) {
                        $templinks += $object.Link | Where-Object { $PSItem -match "64_" }
                        $templinks = $templinks | Where-Object { $PSItem -notmatch "-rt-" }
                    }
                    if (-not $templinks) {
                        $templinks += $object | Where-Object Architecture -eq $arch | Select-Object -ExpandProperty Link
                    }
                }

                if ($templinks) {
                    $object.Link = ($templinks | Sort-Object -Unique)
                } else {
                    Stop-PSFFunction -EnableException:$EnableException -Message "Could not find architecture match, downloading all"
                }
            }

            foreach ($link in $object.Link) {
                $Strict = $true

                if (-not $PSBoundParameters.FilePath) {
                    $FilePath = Split-Path -Path $link -Leaf
                } else {
                    $Path = Split-Path -Path $FilePath
                }

                $file = "$Path$([IO.Path]::DirectorySeparatorChar)$FilePath"

                if ((Test-Path -Path $file) -and -not $AllowClobber) {
                    Get-ChildItem -Path $file | Select Name, @{Name="Size (MB)";Expression={ "{0:N0}" -f ($_.Length / 1MB) }}, FullName | Format-List | out-string
                    $files += $file
                    continue
                }

                if ($file -in $files) { continue }

                if ((Get-Command Start-BitsTransfer -ErrorAction Ignore)) {
                    try {
                        Start-BitsTransfer -Source $link -Destination $file -ErrorAction Stop
                    } catch {
                        Write-Progress -Activity "Downloading $FilePath" -Id 1
                        Invoke-TlsWebRequest -OutFile $file -Uri $link
                        Write-Progress -Activity "Downloading $FilePath" -Id 1 -Completed
                    }
                } else {
                    try {
                        Write-Progress -Activity "Downloading $FilePath" -Id 1
                        Invoke-TlsWebRequest -OutFile $file -Uri $link
                        Write-Progress -Activity "Downloading $FilePath" -Id 1 -Completed
                    } catch {
                        Stop-PSFFunction -EnableException:$EnableException -Message "Failure" -ErrorRecord $_ -Continue
                    }
                }
                if (Test-Path -Path $file) {
                    Get-ChildItem -Path $file | Select Name, @{Name="Size (MB)";Expression={ "{0:N0}" -f ($_.Length / 1MB) }}, FullName | Format-List | out-string
                    $files += $file
                }
            }
        }
    }
}