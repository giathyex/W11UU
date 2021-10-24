using System;
using System.Net;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Text.RegularExpressions;

namespace Windows11Upgrade
{
    public partial class w11uu_manual : Form
    {
        public w11uu_manual()
        {
            InitializeComponent();
        }

        public string spsoutput, kbver, downloadedfile;
        public int ava = 0, nextclick = 0;

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
            try
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
            catch (Exception ex)
            {
                DialogResult dialog = MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dialog == DialogResult.OK)
                    Environment.Exit(0);
            }

        }

        // ===========================================================================================================================================
        // Tai ban cap nhat clicked (Get-KbUpdate)
        private void downbutton_Click(object sender, EventArgs e)
        {
            spsoutput = "";
            nextclick += 1;

            kbver = inputb.Text;
            string checkforkb = "Get-KbUpdate -Name " + kbver + " -Architecture x64 -Simple";
            shellKBrunner.RunWorkerAsync(argument: checkforkb);

            inputb.Visible = false;
            inputbg.Visible = false;
            exam.Visible = false;
            beginlabel.Visible = false;
            beginsublabel.Visible = false;
            logo.Visible = false;
            downbutton.Visible = false;

            powershelloutput.Visible = true;
            loadingbar2.Visible = true;
        }


        // ===========================================================================================================================================
        // Xac nhan tai xuong clicked (Save-KbUpdate)
        private void shellbuttonkb_Click(object sender, EventArgs e)
        {
            spsoutput = "";
            nextclick += 1;

            string sdownload = "Save-KbUpdate -Name " + kbver + " -Architecture x64";
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

        private void exit(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
