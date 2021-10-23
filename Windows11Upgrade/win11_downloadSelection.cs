using System;
using System.Net;
using System.Windows.Forms;
using Microsoft.Win32;
using HtmlAgilityPack;
using System.Threading.Tasks;
using System.Net.Http;
using System.Management.Automation;
using System.Text.RegularExpressions;

namespace Windows11Upgrade
{
    public partial class win11_downloadSelection : Form
    {

        public win11_downloadSelection()
        {
            InitializeComponent();
        }

        public string scurver_build, snewver_build, supdatestat, snewver_kb, spsoutput, downloadedfile;
        public int ava = 0, nextclick = 0;


        // ===========================================================================================================================================
        // ===========================================================================================================================================
        // BackgroundWorker1
        // Check Current Version and New Version
        private void parseHTML_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                // Load Current Version
                string builver = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CurrentBuild", "").ToString();
                string builver2 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "UBR", "").ToString();

                scurver_build = "Build " + builver + "." + builver2;

                // Load Newest Windows 11 Version
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                string HTML;
                HttpClient client = new HttpClient();
                using (HttpResponseMessage response = client.GetAsync("https://docs.microsoft.com/en-us/windows/release-health/windows11-release-information").Result)
                {
                    using (HttpContent content = response.Content)
                        HTML = content.ReadAsStringAsync().Result;
                }
                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(HTML);

                HtmlNode htmlNode = doc.DocumentNode.SelectSingleNode("//tr[@class='highlight']");
                string wver11 = htmlNode.InnerText;
                int nhh = wver11.IndexOf('.');
                wver11 = wver11.Substring((nhh - 5), 9);
                snewver_build = "Build " + wver11;

                // KB Check
                HtmlNode htmlNode2 = doc.DocumentNode.SelectSingleNode("//table[@id='historyTable_0']");
                htmlNode2 = htmlNode2.SelectSingleNode("(.//tr)[2]");
                string kba = htmlNode2.InnerText;
                int nhhk = kba.IndexOf('K');
                kba = kba.Substring(nhhk, 9);
                snewver_kb = kba;

                // Check Update Available
                int curmaj = Int32.Parse(builver);
                int curmin = Int32.Parse(builver2);
                string wver11ma = wver11.Substring(0, 5);
                string wver11mi = wver11.Substring(6, 3);
                int w11maj = Int32.Parse(wver11ma);
                int w11min = Int32.Parse(wver11mi);
                // Currently in Windows 10 or older Windows
                if (curmaj < 22000)
                {
                    ava = 0;
                    supdatestat = "Chỉ dùng cho Windows 11";
                }
                // Currently in older Major (ie. 22000 vs 22001) or Same Major and older Minor (ie. 22000.0 vs 22000.1)
                else if ((curmaj < w11maj) || ((curmaj == w11maj) && (curmin < w11min)))
                    ava = 1;
                else
                {
                    ava = 0;
                    supdatestat = "Không có bản cập nhật mới";
                }
            }
            catch (Exception ex)
            {
                DialogResult dialog = MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dialog == DialogResult.OK)
                    Environment.Exit(0);
            }
        }
        private void parseHTML_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            labelcheck();
        }
        private void labelcheck()
        {
            beginlabel.Visible = false;
            beginsublabel.Visible = false;
            loadingbar1.Visible = false;
            checkupbutton.Visible = false;

            curver_build.Text = scurver_build;
            newver_build.Text = snewver_build;
            updatestat.Text = supdatestat;
            newver_kb.Text = snewver_kb;

            curver.Visible = true;
            curver_build.Visible = true;
            newver.Visible = true;
            newver_build.Visible = true;
            newver_kb.Visible = true;

            if (ava == 1)
                downbutton.Visible = true;
            else
                updatestat.Visible = true;
        }

        // ===========================================================================================================================================
        // Kiem tra cap nhat clicked
        private void checkupbutton_Click(object sender, EventArgs e)
        {
            checkupbutton.Text = "Vui lòng chờ";
            checkupbutton.Enabled = false;
            loadingbar1.Visible = true;

            parseHTML.RunWorkerAsync();
        }


        // ===========================================================================================================================================
        // ===========================================================================================================================================
        // BackgroundWorker2
        // Run potatoqualitee Powershell script for kbupdate
        private void shellKBrunner_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                string kbv = (string)e.Argument;
                PowerShell psinstance = PowerShell.Create();
                psinstance.AddScript(kbv);
                var results = psinstance.Invoke();

                foreach (PSObject psObject in results)
                    spsoutput += psObject.ToString();

                psinstance.Stop();
            }
            catch (Exception ex)
            {
                DialogResult dialog = MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dialog == DialogResult.OK)
                    Environment.Exit(0);
            }
        }
        private void shellKBrunner_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            showtextbox();
        }
        private void showtextbox()
        {
            if (nextclick == 1)
            {
                int nhh = spsoutput.IndexOf(":");
                int nhh2 = spsoutput.IndexOf("Size");
                string name = spsoutput.Substring((nhh + 2), (nhh2 - nhh - 3));
                nhh2 = nhh2 + 8;
                string name2 = spsoutput.Substring(nhh2);
                powershelloutput.Text = name + "\n \n" + name2;

                shellbuttonkb.Visible = true;
            }
            else if (nextclick == 2)
            {
                int nhh = spsoutput.IndexOf(":");
                int nhh2 = spsoutput.IndexOf("Size (MB)");
                int nhh3 = spsoutput.IndexOf("FullName");
                string name = spsoutput.Substring((nhh + 2), (nhh2 - nhh - 3));
                string name2 = spsoutput.Substring((nhh2 + 12), (nhh3 - nhh2 - 14));
                string name3 = spsoutput.Substring((nhh3 + 12));
                name3 = Regex.Replace(name3, " {2,}", "");
                name3 = Regex.Replace(name3, @"\t|\n|\r", "");
                powershelloutput.Text = name + "\n \n" + name2 + " MB \n \n" + name3;

                // Get file name for wusa.exe
                downloadedfile = name3;

                wusabutton.Visible = true;

            }
            loadingbar2.Visible = false;
        }

        // ===========================================================================================================================================
        // Tai ban cap nhat clicked (Kiem tra cap nhat)
        private void downbutton_Click(object sender, EventArgs e)
        {
            spsoutput = "";
            nextclick += 1;

            string checkforkb = "Get-KbUpdate -Name " + snewver_kb + " -Architecture x64 -Simple";
            shellKBrunner.RunWorkerAsync(argument: checkforkb);

            curver.Visible = false;
            curver_build.Visible = false;
            newver.Visible = false;
            newver_build.Visible = false;
            newver_kb.Visible = false;
            logo.Visible = false;
            downbutton.Visible = false;

            powershelloutput.Visible = true;
            loadingbar2.Visible = true;
        }


        // ===========================================================================================================================================
        // Confirm Download (Xac nhan tai xuong clicked)
        private void shellbuttonkb_Click(object sender, EventArgs e)
        {
            spsoutput = "";
            nextclick += 1;

            string sdownload = "Save-KbUpdate -Name " + snewver_kb + " -Architecture x64";
            shellKBrunner.RunWorkerAsync(argument: sdownload);

            shellbuttonkb.Visible = false;
            loadingbar2.Visible = true;
        }


        // ===========================================================================================================================================
        // ===========================================================================================================================================
        // wusa.exe Update Runner
        // Run Powershell script to call wusa.exe with downloaded update
        private void wusacallshell_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                string kbv = (string)e.Argument;
                PowerShell psinstance = PowerShell.Create();
                psinstance.AddScript(kbv);
                psinstance.Invoke();
                psinstance.Stop();
            }
            catch (Exception ex)
            {
                DialogResult dialog = MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dialog == DialogResult.OK)
                    Environment.Exit(0);
            }   
        }
        private void wusacallshell_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            wusarunning();
        }
        private void wusarunning()
        {
            wusabutton.Visible = false;
            powershelloutput.Text = "Quá trình cài đặt đã bắt đầu, máy có thể sẽ yêu cầu khởi động lại. Bạn có thể đóng cửa sổ này sau khi cài đặt thành công";
        }

        // ===========================================================================================================================================
        // Install Clicked
        private void wusabutton_Click(object sender, EventArgs e)
        {
            string sinstall = "wusa.exe " + downloadedfile;
            wusacallshell.RunWorkerAsync(argument: sinstall);
        }


        // ===========================================================================================================================================
        // ===========================================================================================================================================
        // Exit
        private void exit(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}