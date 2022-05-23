using Entities.Models;
using PRS.Resources;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRS
{
    public partial class FrmDisplayPatients : Form
    {
        private List<Patient> LstPatients = null;
        private List<Patient> LstTemp = null;
        FrmNotification notification;
        string IdNo = string.Empty;
        string Message = string.Empty;
        bool IsUpdateGrid = false;

        int PagesCount = 1;
        int PageSize = 10;
        int TempPage = 0;

        public FrmDisplayPatients()
        {
            InitializeComponent();
            if (IsUpdateGrid.Equals(false))
            {
                LstPatients = PopulateGrid().ToList();
            }
            else
            {
                this.RefreshGrid();
            }
        }
        public FrmDisplayPatients(bool isUpdated)
        {
            if (isUpdated.Equals(true))
            {
                IsUpdateGrid = isUpdated;
            }      
        }
        private void FrmDisplayPatients_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            this.RebindGridForPageChange();
            dgvPatients.DataSource = LstTemp;      
        }

        // * get all patients records
        public List<Patient> PopulateGrid(string IdNo = "")
        {
            try
            {
                dgvPatients.DataSource = "";
                using (var dbService = new DbService())
                {
                    LstPatients = dbService.GetPatients().ToList();
                }
            }
            catch (Exception)
            {
                notification = new FrmNotification();
                notification.DisplayMessage("An Error occured while getting patient(s)","Error",true );              
            }
                     
            return LstPatients;
        }

        // *get patient by id number
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dbService = new DbService())
                {
                    // *validate if id not zero and query list by patient id number
                    if (this.txtSearch.Text.Length != 0)
                    {
                        IdNo = this.txtSearch.Text;
                        dgvPatients.DataSource = LstPatients.Where(x => x.IDNo == IdNo).ToList();
                    }
                    else
                    {
                        Message = "Please enter Patient ID Number before you click search\n";
                    }
                }
            }
            catch (Exception ex)
            {
                notification = new FrmNotification();
                notification.DisplayMessage("An Error occured while getting patient details", "Error", true);
            }
            
        }
        // * reset or refresh grid
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.RefreshGrid();
        }

        public void RefreshGrid()
        {
            LstPatients = new List<Patient>();
            LstPatients = this.PopulateGrid().ToList();
            dgvPatients.DataSource = "";
            dgvPatients.DataSource = LstPatients;
            dgvPatients.Refresh();

        }
        private void patientBindingSource_CurrentChanged(object sender, EventArgs e)
        {}

        // * pagination back button event
        private void btnBackwards_Click(object sender, EventArgs e)
        {
            TempPage = PageSize;
            dgvPatients.DataSource = this.RebindGridForPageChange(PageSize, false);
        }

        // * pagination forward button event
        private void btnForward_Click(object sender, EventArgs e)
        {
            TempPage =  PageSize;
            dgvPatients.DataSource = this.RebindGridForPageChange(10,true);
        }
        public List<Patient> RebindGridForPageChange(int PageSize = 10, bool Forward = false)
        {
            // *if TempList is null, first query take or page 1
            if (LstTemp == null)
            {
                LstTemp = new List<Patient>();
                TempPage = PageSize;
                LstTemp = LstPatients.Take(TempPage).ToList();
            }
            else
            {
                PagesCount = LstTemp.OrderByDescending(x => x.Id).Select(x => x.Id).FirstOrDefault();  
                if(Forward.Equals(true))
                    LstTemp = LstPatients.Skip(PagesCount).Take(PageSize).ToList();
                else
                    LstTemp = LstPatients.OrderByDescending(x => x.Id).Skip(PagesCount - PageSize).Take(PageSize).ToList();
            };

            return LstTemp.OrderBy(x => x.Id).ToList();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            FrmPatientRegistration frmPatientRegistration = new FrmPatientRegistration();
            frmPatientRegistration.Show();
            this.Hide();
        }

        // *get selected patient from the gird to display full patient information !
        private void dgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgvPatients.CellContentClick += dgvPatients_CellContentClick;
            var grid = (DataGridView)sender;

            // *if header column clicked, do nothing
            if (e.RowIndex < 0)
                return;

            if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                var clickHandler = (Action<Patient>)grid.Columns[e.ColumnIndex].Tag;
                var person = (Patient)grid.Rows[e.RowIndex].DataBoundItem;
                this.ClickHandler(person, e.ColumnIndex);
            }
        }
        public void ClickHandler(Patient p, int index)
        {
            // *if index is true to the value get full patient details else delete
            FrmNotification notification = new FrmNotification();
            if (index.Equals(10))
            {
                var Id = LstPatients.Where(x => x.Id == p.Id).Select(x => x.Id).FirstOrDefault();
                FrmPatientInformation patientInformation = new FrmPatientInformation(Id);
                patientInformation.Show();             
            }
            else
            {
                using (var dbService = new DbService())
                {
                    dbService.DeletePatient(p.Id);
                }
                notification.DisplayMessage("Patient successfully deleted !", "");
                LstTemp = null;
            }
        }
    }
}
