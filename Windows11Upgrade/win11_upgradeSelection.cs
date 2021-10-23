using System;
using System.Windows.Forms;

namespace Windows11Upgrade {
    public partial class win11_upgradeSelection : Form {
        public win11_upgradeSelection() {
            InitializeComponent();
        }

        private void exit(object sender, FormClosingEventArgs e) {
            Environment.Exit(0);
        }

        private void btn_downloadIso_Click_1(object sender, EventArgs e)
        {
            Hide();
            var downloadSelection = new win11_downloadSelection();
            downloadSelection.Show();
        }
    }
}