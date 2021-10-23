using System;
using System.Net;
using System.Windows.Forms;
using Microsoft.Win32;
using HtmlAgilityPack;
using System.Threading.Tasks;
using System.Net.Http;
using System.Management.Automation;
using System.Text.RegularExpressions;

namespace Windows11Upgrade {
    public partial class win11_downloadSelection : Form {

        public win11_downloadSelection() 
        {
            InitializeComponent();
        }

        public string slabel3, slabel6, slabel7, slabelk, textboxi, downloadedfile;
        public int ava = 0, nextclick = 0;


        // ===========================================================================================================================================
        // Check Current Version and New Version
        // Show Language option if there is newer version available
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // Load Current Version
            string builver = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CurrentBuild", "").ToString();
            string builver2 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "UBR", "").ToString();

            slabel3 = "Build " + builver + "." + builver2;


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
            slabel6 = "Build " + wver11;


            // KB Check
            HtmlNode htmlNode2 = doc.DocumentNode.SelectSingleNode("//table[@id='historyTable_0']");
            htmlNode2 = htmlNode2.SelectSingleNode("(.//tr)[2]");
            string kba = htmlNode2.InnerText;
            int nhhk = kba.IndexOf('K');
            kba = kba.Substring(nhhk, 9);
            slabelk = kba;


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
                slabel7 = "Chỉ dùng cho Windows 11";
            }
            // Currently in older Major (ie. 22000 vs 22001) or Same Major and older Minor (ie. 22000.0 vs 22000.1)
            else if ((curmaj < w11maj) || ((curmaj == w11maj) && (curmin < w11min)))
                ava = 1;
            else
            {
                ava = 0;
                slabel7 = "Không có bản cập nhật mới";
            }  
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            labelcheck();
        }
        private void labelcheck()
        {
            label8.Visible = false;
            label9.Visible = false;
            pictureBox3.Visible = false;
            button1.Visible = false;

            label3.Text = slabel3;
            label6.Text = slabel6;
            label7.Text = slabel7;
            labelk.Text = slabelk;

            label1.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            labelk.Visible = true;

            
            if (ava == 1)
                buttonu.Visible = true;
            else
                label7.Visible = true;
        }


        // ===========================================================================================================================================
        // Kiem tra cap nhat clicked
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Vui lòng chờ";
            button1.Enabled = false;
            pictureBox3.Visible = true;

            backgroundWorker1.RunWorkerAsync();
        }


        // ===========================================================================================================================================
        // Tai ban cap nhat clicked (Kiem tra cap nhat)
        private void buttonu_Click(object sender, EventArgs e)
        {
            textboxi = "";
            nextclick += 1;

            string checkforkb = "Get-KbUpdate -Name " + slabelk + " -Architecture x64 -Simple";
            backgroundWorker2.RunWorkerAsync(argument: checkforkb);

            label1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            labelk.Visible = false;
            pictureBox2.Visible = false;
            buttonu.Visible = false;

            textBox1.Visible = true;
            pictureBoxshell.Visible = true;
        }


        // ===========================================================================================================================================
        // Confirm Download (Xac nhan tai xuong clicked)
        private void buttonshell_Click(object sender, EventArgs e)
        {
            textboxi = "";
            nextclick += 1;
        
            string sdownload = "Save-KbUpdate -Name " + slabelk + " -Architecture x64";
            backgroundWorker2.RunWorkerAsync(argument: sdownload);

            buttonshell.Visible = false;
            pictureBoxshell.Visible = true;
        }


        // ===========================================================================================================================================
        // Powershell Runner
        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string kbv = (string)e.Argument;
            PowerShell psinstance = PowerShell.Create();
            psinstance.AddScript(kbv);
            var results = psinstance.Invoke();

            foreach (PSObject psObject in results)
                textboxi += psObject.ToString();

            psinstance.Stop();
        }
        private void backgroundWorker2_RunWorkerCompleted_1(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            showtextbox();
        }
        private void showtextbox()
        {
            if (nextclick == 1)
            {
                int nhh = textboxi.IndexOf(":");
                int nhh2 = textboxi.IndexOf("Size");
                string name = textboxi.Substring((nhh + 2), (nhh2 - nhh - 3));
                nhh2 = nhh2 + 8;
                string name2 = textboxi.Substring(nhh2);
                textBox1.Text = name + "\n \n" + name2;

                buttonshell.Visible = true;
            }
            else if (nextclick == 2)
            {
                int nhh = textboxi.IndexOf(":");
                int nhh2 = textboxi.IndexOf("Size (MB)");
                int nhh3 = textboxi.IndexOf("FullName");
                string name = textboxi.Substring((nhh + 2), (nhh2 - nhh - 3));
                string name2 = textboxi.Substring((nhh2 + 12), (nhh3 - nhh2 - 14));
                string name3 = textboxi.Substring((nhh3 + 12));
                name3 = Regex.Replace(name3, " {2,}", "");
                name3 = Regex.Replace(name3, @"\t|\n|\r", "");
                textBox1.Text = name + "\n \n" + name2 + " MB \n \n" + name3;

                // Get file name for wusa.exe
                downloadedfile = name3;

                buttonshell2.Visible = true;

            }
            pictureBoxshell.Visible = false;
        }


        // ===========================================================================================================================================
        // Install Clicked
        private void buttonshell2_Click(object sender, EventArgs e)
        {
            textboxi = "";

            string sinstall = "wusa.exe " + downloadedfile;
            backgroundWorker3.RunWorkerAsync(argument: sinstall);
        }


        // ===========================================================================================================================================
        // wusa.exe Update Runner
        private void backgroundWorker3_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string kbv = (string)e.Argument;
            PowerShell psinstance = PowerShell.Create();
            psinstance.AddScript(kbv);
            psinstance.Invoke();
            psinstance.Stop();
        }
        private void backgroundWorker3_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            buttonshell2.Visible = false;
            pictureBoxshell.Visible = true;
            textboxi = "Vui lòng chờ quá trình cài đặt hoàn tất. Máy có thể sẽ khởi động lại.";
        }


        // ===========================================================================================================================================
        // Exit
        private void exit(object sender, FormClosingEventArgs e) 
        {
            Environment.Exit(0);
        }
    }
}