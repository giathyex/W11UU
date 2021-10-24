using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows11Upgrade
{
    public partial class w11uu_manual : Form
    {
        public w11uu_manual()
        {
            InitializeComponent();
        }

        private void exit(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
