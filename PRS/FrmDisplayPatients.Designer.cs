
using Entities.Models;

namespace PRS
{
    partial class FrmDisplayPatients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpBxPatients = new System.Windows.Forms.GroupBox();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBackwards = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admitDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wardNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnViewGrid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDeleteGrid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pRSContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpBxPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSContextBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBxPatients
            // 
            this.grpBxPatients.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpBxPatients.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBxPatients.BackColor = System.Drawing.SystemColors.Control;
            this.grpBxPatients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpBxPatients.Controls.Add(this.btnForward);
            this.grpBxPatients.Controls.Add(this.btnBackwards);
            this.grpBxPatients.Controls.Add(this.btnAddPatient);
            this.grpBxPatients.Controls.Add(this.btnReset);
            this.grpBxPatients.Controls.Add(this.btnSearch);
            this.grpBxPatients.Controls.Add(this.dgvPatients);
            this.grpBxPatients.Controls.Add(this.txtSearch);
            this.grpBxPatients.Controls.Add(this.lblSearch);
            this.grpBxPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxPatients.Location = new System.Drawing.Point(12, 29);
            this.grpBxPatients.Name = "grpBxPatients";
            this.grpBxPatients.Size = new System.Drawing.Size(1737, 601);
            this.grpBxPatients.TabIndex = 0;
            this.grpBxPatients.TabStop = false;
            this.grpBxPatients.Text = "Patients";
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(1554, 536);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(143, 37);
            this.btnForward.TabIndex = 12;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBackwards
            // 
            this.btnBackwards.Location = new System.Drawing.Point(1335, 536);
            this.btnBackwards.Name = "btnBackwards";
            this.btnBackwards.Size = new System.Drawing.Size(127, 37);
            this.btnBackwards.TabIndex = 11;
            this.btnBackwards.Text = "Previous";
            this.btnBackwards.UseVisualStyleBackColor = true;
            this.btnBackwards.Click += new System.EventHandler(this.btnBackwards_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddPatient.ForeColor = System.Drawing.Color.White;
            this.btnAddPatient.Location = new System.Drawing.Point(33, 73);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(141, 41);
            this.btnAddPatient.TabIndex = 10;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = false;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(1542, 108);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 37);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Red;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1635, 108);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 37);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvPatients
            // 
            this.dgvPatients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatients.AutoGenerateColumns = false;
            this.dgvPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.iDNoDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.doctorDataGridViewTextBoxColumn,
            this.admitDateDataGridViewTextBoxColumn,
            this.wardNoDataGridViewTextBoxColumn,
            this.btnViewGrid,
            this.btnDeleteGrid});
            this.dgvPatients.DataSource = this.patientBindingSource;
            this.dgvPatients.Location = new System.Drawing.Point(20, 178);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.RowHeadersWidth = 51;
            this.dgvPatients.RowTemplate.Height = 24;
            this.dgvPatients.Size = new System.Drawing.Size(1696, 328);
            this.dgvPatients.TabIndex = 2;
            this.dgvPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatients_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDNoDataGridViewTextBoxColumn
            // 
            this.iDNoDataGridViewTextBoxColumn.DataPropertyName = "IDNo";
            this.iDNoDataGridViewTextBoxColumn.HeaderText = "ID No";
            this.iDNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDNoDataGridViewTextBoxColumn.Name = "iDNoDataGridViewTextBoxColumn";
            this.iDNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.birthDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            this.contactNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorDataGridViewTextBoxColumn
            // 
            this.doctorDataGridViewTextBoxColumn.DataPropertyName = "Doctor";
            this.doctorDataGridViewTextBoxColumn.HeaderText = "Doctor";
            this.doctorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorDataGridViewTextBoxColumn.Name = "doctorDataGridViewTextBoxColumn";
            this.doctorDataGridViewTextBoxColumn.Width = 125;
            // 
            // admitDateDataGridViewTextBoxColumn
            // 
            this.admitDateDataGridViewTextBoxColumn.DataPropertyName = "AdmitDate";
            this.admitDateDataGridViewTextBoxColumn.HeaderText = "Admit Date";
            this.admitDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.admitDateDataGridViewTextBoxColumn.Name = "admitDateDataGridViewTextBoxColumn";
            this.admitDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // wardNoDataGridViewTextBoxColumn
            // 
            this.wardNoDataGridViewTextBoxColumn.DataPropertyName = "WardNo";
            this.wardNoDataGridViewTextBoxColumn.HeaderText = "WardNo";
            this.wardNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.wardNoDataGridViewTextBoxColumn.Name = "wardNoDataGridViewTextBoxColumn";
            this.wardNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnViewGrid
            // 
            this.btnViewGrid.DataPropertyName = "Id";
            this.btnViewGrid.HeaderText = "";
            this.btnViewGrid.MinimumWidth = 6;
            this.btnViewGrid.Name = "btnViewGrid";
            this.btnViewGrid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnViewGrid.Text = "View";
            this.btnViewGrid.UseColumnTextForButtonValue = true;
            this.btnViewGrid.Width = 125;
            // 
            // btnDeleteGrid
            // 
            this.btnDeleteGrid.DataPropertyName = "Id";
            this.btnDeleteGrid.HeaderText = "";
            this.btnDeleteGrid.MinimumWidth = 6;
            this.btnDeleteGrid.Name = "btnDeleteGrid";
            this.btnDeleteGrid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnDeleteGrid.Text = "Delete";
            this.btnDeleteGrid.UseColumnTextForButtonValue = true;
            this.btnDeleteGrid.Width = 125;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(Entities.Models.Patient);
            this.patientBindingSource.CurrentChanged += new System.EventHandler(this.patientBindingSource_CurrentChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1405, 75);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(317, 27);
            this.txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(1281, 79);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(118, 18);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search By ID No";
            // 
            // pRSContextBindingSource
            // 
            this.pRSContextBindingSource.DataSource = typeof(Entities.Models.PRSContext);
            // 
            // FrmDisplayPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1786, 675);
            this.Controls.Add(this.grpBxPatients);
            this.Name = "FrmDisplayPatients";
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.FrmDisplayPatients_Load);
            this.grpBxPatients.ResumeLayout(false);
            this.grpBxPatients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSContextBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxPatients;
        private System.Windows.Forms.DataGridView dgvPatients;
        //private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBackwards;
        private System.Windows.Forms.BindingSource pRSContextBindingSource;
        private System.Windows.Forms.DataGridViewButtonColumn btnViewDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNoDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn genderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn admitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wardNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnViewGrid;
        private System.Windows.Forms.DataGridViewButtonColumn btnDeleteGrid;
        //private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}
