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
    public partial class FrmNotification : Form
    {
        public FrmNotification()
        {
            InitializeComponent();
        }
        public void DisplayMessage(string message, string title ,bool isError = false)
        {
           if(isError.Equals(false))
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
           else
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
