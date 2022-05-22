using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRS
{
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }

      

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var frmDisplayPatients = new FrmDisplayPatients();
            frmDisplayPatients.Show();
            this.Hide();
        }

        private void FrmWelcome_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Fixed3D;
            //WindowState = FormWindowState.Normal;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmDisplayPatients frmDisplayPatients = new FrmDisplayPatients();
            frmDisplayPatients.Show();
            this.Hide();
        }
    }
}
