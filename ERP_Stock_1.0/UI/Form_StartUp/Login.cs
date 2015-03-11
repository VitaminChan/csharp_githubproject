using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace UI.Form_StartUp
{
    public partial class frmLogin : DevComponents.DotNetBar.OfficeForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Form_Main.frmMain frmMain = new Form_Main.frmMain();
            frmMain.Show();
        }
    }
}