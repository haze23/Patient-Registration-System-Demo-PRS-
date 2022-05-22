using Entities.Models;
using Services;
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
    public partial class FrmPatientRegistration : Form
    {
        private List<Gender> lstGender;
        StringBuilder sb;
        public FrmPatientRegistration()
        {
            InitializeComponent();
            lstGender = new List<Gender>();
            sb = new StringBuilder();

            this.GetLookups();
        }    
        private void btnSave_Click(object sender, EventArgs e)
        {
            var model = new Patient();
            FrmNotification notification = new FrmNotification();
            FrmDisplayPatients frmDisplayPatients = new FrmDisplayPatients();

            this.ValidateForm();
            if (sb.Length == 0)
            {
                model.Firstname = txtFirstname.Text;
                model.Lastname = txtLastname.Text;
                model.IDNo = txtIDNo.Text;
                model.GenderId = Convert.ToInt32(cbxGender.SelectedValue);
                model.BirthDate = Convert.ToDateTime(dtpBirthDate.Text);
                model.Email = txtEmail.Text;
                model.ContactNo = txtContactNo.Text;
                model.Doctor = txtDoctor.Text;
                model.Status = rtbStatus.Text;
                model.AdmitDate = Convert.ToDateTime(dtpAdmitDate.Text);
                model.WardNo = txtWardNo.Text;

                using (var _dbService = new DbService())
                {
                    var entity = _dbService.SavePatient(model);
                    if (entity != null)
                    {
                        notification.DisplayMessage(message:"Patient successfully saved !", title:"Patient");
                        frmDisplayPatients.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                notification.DisplayMessage(message:sb.ToString(),title:"Patient" ,isError:true);
                sb = new StringBuilder();
            }
        }
        private void FrmPatientRegistration_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Fixed3D;
            WindowState = FormWindowState.Minimized;
        }

        public void GetLookups()
        {
            cbxGender.ValueMember = "GenderId";
            cbxGender.DisplayMember = "GenderName";
            cbxGender.DataSource = this.GetGender();
        }
        public List<Gender> GetGender()
        {
            using (var lookupService = new LookupService())
            {
                lstGender = lookupService.GetGender();
            }
            return lstGender;
        }

        #region validation
        private void txtIDNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.lblValIdNo.Text = this.CheckForNonCharacterString(e);
        }
        private void txtFirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.lblValFirstname.Text = this.CheckForNonCharacterString(e);
        }
        private void txtLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.lblValLastname.Text = this.CheckForNonCharacterString(e);
        }
        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.lblValContactNo.Text = this.CheckForNonCharacterString(e);
        }
        private void txtDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtWardNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.lblValWardNo.Text = this.CheckForNonCharacterString(e);
        }
        private void txtStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.lblValStatus.Text = this.CheckForNonCharacterString(e);
        }

        // * all patient form validation before submission
        public void ValidateForm()
        {
            if (this.txtIDNo.Text.Length == 0)
            {
                sb.Append("Please provide value for ID No.\n");
            }
            if (this.txtFirstname.Text.Length == 0)
            {
                sb.Append("Please enter patient Firstname before you proceed\n");
            }
            if (this.txtLastname.Text.Length == 0)
            {
                sb.Append("Please enter patient Lastname before you proceed\n");
            }
            if (this.cbxGender.Text.Length == 0)
            {
                sb.Append("Please select patient Gender before you proceed\n");
            }
            if (this.dtpBirthDate.Text.Length == 0)
            {
                sb.Append("Please select patient Birth Date before you proceed\n");
            }
            if (this.txtEmail.Text.Length == 0)
            {
                sb.Append("Please select patient Gender before you proceed\n");
            }
            if (this.txtContactNo.Text.Length == 0)
            {
                sb.Append("Please enter Patient Contact No before you proceed\n");
            }
            if (this.txtDoctor.Text.Length == 0)
            {
                sb.Append("Please select Doctor assign to patient before you proceed\n");
            }
            if (this.rtbStatus.Text.Length == 0)
            {
                sb.Append("Please select Doctor assign to patient before you proceed\n");
            }
        }
        #endregion


        private string CheckForNonCharacterString(KeyPressEventArgs e)
        {
            string response = string.Empty;
            if (Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == '\b')                 // Allowing BackSpace character
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                response = "Non character read, please enter alphabet characters and numbers only !";
            }
            return response;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            FrmDisplayPatients displayPatients = new FrmDisplayPatients();
            displayPatients.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }
        private void ClearForm()
        {
            txtIDNo.Text = "";
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtEmail.Text = "";
            txtContactNo.Text = "";
            txtDoctor.Text = "";
            txtWardNo.Text = "";
        }
    }
}
