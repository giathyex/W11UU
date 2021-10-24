using System;
using System.Windows.Forms;

namespace Windows11Upgrade {
    public partial class w11uu_start : Form {
        public w11uu_start() {
            InitializeComponent();
        }

        private void autodownload_Click(object sender, EventArgs e)
        {
            Hide();
            var autodownload = new w11uu_auto();
            autodownload.Show();
        }

        private void manualdownload_Click(object sender, EventArgs e)
        {
            Hide();
            var manualdownload = new w11uu_manual();
            manualdownload.Show();
        }

        private void exit(object sender, FormClosingEventArgs e) {
            Environment.Exit(0);
        }
    }
}