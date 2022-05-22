using Entities.Models;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRS.Resources
{
    public partial class FrmPatientInformation : Form
    {
        private Patient patient = null;
        FrmNotification notification;

        public FrmPatientInformation(Patient p)
        {
            InitializeComponent();
        }

        public FrmPatientInformation(int Id)
        {
            InitializeComponent();
            patient = new Patient();
            patient.Id = Id;
        }

        private void FrmPatientInformation_Load(object sender, EventArgs e)
        {
            try
            {
                using (var dbService = new DbService())
                {
                    patient = dbService.GetPatients(patient.Id).FirstOrDefault();
                    if (patient != null)
                    {
                        lblIDNoText.Text = patient.IDNo;
                        lblFirstnameText.Text = patient.Firstname;
                        lblLastnameText.Text = patient.Lastname;
                        lblGenderText.Text = patient.Gender.GenderName;
                        lblBirthDateText.Text = patient.BirthDate.ToString("dd,MM,yyyy");
                        lblEmailText.Text = patient.Email;
                        lblContactNoText.Text = patient.ContactNo;
                        lblDoctorText.Text = patient.Doctor;
                        lblAdmitDateText.Text = patient.AdmitDate.ToString("dd,MM,yyyy");
                        lblWardNoText.Text = patient.WardNo;
                        lblStatusText.Text = Regex.Replace(patient.Status, @"(?s).{0,95}",
                                m => m.Value.EndsWith("\n") ? m.Value + "\t" : m.Value + "\n\t");
                    }
                    else
                    {
                        throw new Exception("Patient with an Id provided does not exist");
                    }
                }
            }
            catch (Exception )
            {
                notification = new FrmNotification();
                notification.DisplayMessage("An Error occured while getting patient details", "Error", true);
            }            
        }

        private void grpBxPatientInformation_Enter(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmDisplayPatients displayPatients = new FrmDisplayPatients();
            displayPatients.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmNotification notification = new FrmNotification();
            notification.DisplayMessage("To be redirected to an Edit Form", "Dummy Edit Button");
        }
    }
}
