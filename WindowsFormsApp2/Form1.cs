using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmSapLogin : MetroFramework.Forms.MetroForm
    {
        public frmSapLogin()
        {
            InitializeComponent();
        }

        private void frmSapLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Home myHome = new Home();
            this.Hide();
            myHome.ShowDialog();
        }
    }
}
