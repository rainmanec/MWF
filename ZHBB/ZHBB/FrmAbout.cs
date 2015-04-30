using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZHBB
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            FrmMain fm = new FrmMain();
            lb_softname.Text = string.Format(lb_softname.Text, AppData.Company);
            lb_version.Text = string.Format(lb_version.Text, AppData.VERSION.ToString("F1"));
            fm.Dispose();
        }
    }
}
