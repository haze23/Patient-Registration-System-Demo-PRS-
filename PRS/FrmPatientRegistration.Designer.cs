using Entities.Models;

namespace PRS
{
    partial class FrmPatientRegistration
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
            this.grpBxPatientRegistration = new System.Windows.Forms.GroupBox();
            this.lblValStatus = new System.Windows.Forms.Label();
            this.lblValWardNo = new System.Windows.Forms.Label();
            this.lblValDoctor = new System.Windows.Forms.Label();
            this.lblValContactNo = new System.Windows.Forms.Label();
            this.lblValEmail = new System.Windows.Forms.Label();
            this.lblValFirstname = new System.Windows.Forms.Label();
            this.lblValLastname = new System.Windows.Forms.Label();
            this.lblValIdNo = new System.Windows.Forms.Label();
            this.rtbStatus = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtWardNo = new System.Windows.Forms.TextBox();
            this.txtDoctor = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtIDNo = new System.Windows.Forms.TextBox();
            this.dtpAdmitDate = new System.Windows.Forms.DateTimePicker();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.lblWardNo = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblIDNo = new System.Windows.Forms.Label();
            this.lblAdmitDate = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpBxPatientRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBxPatientRegistration
            // 
            this.grpBxPatientRegistration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpBxPatientRegistration.Controls.Add(this.btnBack);
            this.grpBxPatientRegistration.Controls.Add(this.lblValStatus);
            this.grpBxPatientRegistration.Controls.Add(this.lblValWardNo);
            this.grpBxPatientRegistration.Controls.Add(this.lblValDoctor);
            this.grpBxPatientRegistration.Controls.Add(this.lblValContactNo);
            this.grpBxPatientRegistration.Controls.Add(this.lblValEmail);
            this.grpBxPatientRegistration.Controls.Add(this.lblValFirstname);
            this.grpBxPatientRegistration.Controls.Add(this.lblValLastname);
            this.grpBxPatientRegistration.Controls.Add(this.lblValIdNo);
            this.grpBxPatientRegistration.Controls.Add(this.rtbStatus);
            this.grpBxPatientRegistration.Controls.Add(this.btnCancel);
            this.grpBxPatientRegistration.Controls.Add(this.btnSave);
            this.grpBxPatientRegistration.Controls.Add(this.lblStatus);
            this.grpBxPatientRegistration.Controls.Add(this.txtWardNo);
            this.grpBxPatientRegistration.Controls.Add(this.txtDoctor);
            this.grpBxPatientRegistration.Controls.Add(this.txtContactNo);
            this.grpBxPatientRegistration.Controls.Add(this.txtEmail);
            this.grpBxPatientRegistration.Controls.Add(this.dtpBirthDate);
            this.grpBxPatientRegistration.Controls.Add(this.cbxGender);
            this.grpBxPatientRegistration.Controls.Add(this.txtIDNo);
            this.grpBxPatientRegistration.Controls.Add(this.dtpAdmitDate);
            this.grpBxPatientRegistration.Controls.Add(this.txtLastname);
            this.grpBxPatientRegistration.Controls.Add(this.txtFirstname);
            this.grpBxPatientRegistration.Controls.Add(this.lblWardNo);
            this.grpBxPatientRegistration.Controls.Add(this.lblDoctorName);
            this.grpBxPatientRegistration.Controls.Add(this.lblContactNo);
            this.grpBxPatientRegistration.Controls.Add(this.lblEmail);
            this.grpBxPatientRegistration.Controls.Add(this.lblDob);
            this.grpBxPatientRegistration.Controls.Add(this.lblGender);
            this.grpBxPatientRegistration.Controls.Add(this.lblIDNo);
            this.grpBxPatientRegistration.Controls.Add(this.lblAdmitDate);
            this.grpBxPatientRegistration.Controls.Add(this.lblLastname);
            this.grpBxPatientRegistration.Controls.Add(this.lblFirstname);
            this.grpBxPatientRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxPatientRegistration.Location = new System.Drawing.Point(127, 38);
            this.grpBxPatientRegistration.Name = "grpBxPatientRegistration";
            this.grpBxPatientRegistration.Size = new System.Drawing.Size(926, 733);
            this.grpBxPatientRegistration.TabIndex = 0;
            this.grpBxPatientRegistration.TabStop = false;
            this.grpBxPatientRegistration.Text = "Patient Registration";
            // 
            // lblValStatus
            // 
            this.lblValStatus.AutoSize = true;
            this.lblValStatus.ForeColor = System.Drawing.Color.Red;
            this.lblValStatus.Location = new System.Drawing.Point(124, 462);
            this.lblValStatus.Name = "lblValStatus";
            this.lblValStatus.Size = new System.Drawing.Size(15, 18);
            this.lblValStatus.TabIndex = 31;
            this.lblValStatus.Text = "*";
            // 
            // lblValWardNo
            // 
            this.lblValWardNo.AutoSize = true;
            this.lblValWardNo.ForeColor = System.Drawing.Color.Red;
            this.lblValWardNo.Location = new System.Drawing.Point(583, 310);
            this.lblValWardNo.Name = "lblValWardNo";
            this.lblValWardNo.Size = new System.Drawing.Size(15, 18);
            this.lblValWardNo.TabIndex = 30;
            this.lblValWardNo.Text = "*";
            // 
            // lblValDoctor
            // 
            this.lblValDoctor.AutoSize = true;
            this.lblValDoctor.ForeColor = System.Drawing.Color.Red;
            this.lblValDoctor.Location = new System.Drawing.Point(156, 314);
            this.lblValDoctor.Name = "lblValDoctor";
            this.lblValDoctor.Size = new System.Drawing.Size(15, 18);
            this.lblValDoctor.TabIndex = 29;
            this.lblValDoctor.Text = "*";
            // 
            // lblValContactNo
            // 
            this.lblValContactNo.AutoSize = true;
            this.lblValContactNo.ForeColor = System.Drawing.Color.Red;
            this.lblValContactNo.Location = new System.Drawing.Point(583, 251);
            this.lblValContactNo.Name = "lblValContactNo";
            this.lblValContactNo.Size = new System.Drawing.Size(15, 18);
            this.lblValContactNo.TabIndex = 28;
            this.lblValContactNo.Text = "*";
            // 
            // lblValEmail
            // 
            this.lblValEmail.AutoSize = true;
            this.lblValEmail.ForeColor = System.Drawing.Color.Red;
            this.lblValEmail.Location = new System.Drawing.Point(156, 257);
            this.lblValEmail.Name = "lblValEmail";
            this.lblValEmail.Size = new System.Drawing.Size(15, 18);
            this.lblValEmail.TabIndex = 27;
            this.lblValEmail.Text = "*";
            // 
            // lblValFirstname
            // 
            this.lblValFirstname.AutoSize = true;
            this.lblValFirstname.ForeColor = System.Drawing.Color.Red;
            this.lblValFirstname.Location = new System.Drawing.Point(156, 114);
            this.lblValFirstname.Name = "lblValFirstname";
            this.lblValFirstname.Size = new System.Drawing.Size(15, 18);
            this.lblValFirstname.TabIndex = 26;
            this.lblValFirstname.Text = "*";
            // 
            // lblValLastname
            // 
            this.lblValLastname.AutoSize = true;
            this.lblValLastname.ForeColor = System.Drawing.Color.Red;
            this.lblValLastname.Location = new System.Drawing.Point(583, 114);
            this.lblValLastname.Name = "lblValLastname";
            this.lblValLastname.Size = new System.Drawing.Size(15, 18);
            this.lblValLastname.TabIndex = 25;
            this.lblValLastname.Text = "*";
            // 
            // lblValIdNo
            // 
            this.lblValIdNo.AutoSize = true;
            this.lblValIdNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValIdNo.ForeColor = System.Drawing.Color.Red;
            this.lblValIdNo.Location = new System.Drawing.Point(153, 47);
            this.lblValIdNo.Name = "lblValIdNo";
            this.lblValIdNo.Size = new System.Drawing.Size(14, 18);
            this.lblValIdNo.TabIndex = 24;
            this.lblValIdNo.Text = "*";
            // 
            // rtbStatus
            // 
            this.rtbStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbStatus.Location = new System.Drawing.Point(138, 517);
            this.rtbStatus.Name = "rtbStatus";
            this.rtbStatus.Size = new System.Drawing.Size(727, 96);
            this.rtbStatus.TabIndex = 23;
            this.rtbStatus.Text = "";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(263, 646);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 34);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Red;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(138, 646);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 34);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(38, 482);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(133, 18);
            this.lblStatus.TabIndex = 20;
            this.lblStatus.Text = "Condition/Status";
            // 
            // txtWardNo
            // 
            this.txtWardNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWardNo.Location = new System.Drawing.Point(583, 333);
            this.txtWardNo.Name = "txtWardNo";
            this.txtWardNo.Size = new System.Drawing.Size(297, 24);
            this.txtWardNo.TabIndex = 19;
            this.txtWardNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWardNo_KeyPress);
            // 
            // txtDoctor
            // 
            this.txtDoctor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctor.Location = new System.Drawing.Point(156, 337);
            this.txtDoctor.Name = "txtDoctor";
            this.txtDoctor.Size = new System.Drawing.Size(297, 24);
            this.txtDoctor.TabIndex = 18;
            this.txtDoctor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoctor_KeyPress);
            // 
            // txtContactNo
            // 
            this.txtContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactNo.Location = new System.Drawing.Point(583, 274);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(297, 24);
            this.txtContactNo.TabIndex = 17;
            this.txtContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactNo_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(156, 280);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(297, 24);
            this.txtEmail.TabIndex = 16;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(583, 204);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(297, 24);
            this.dtpBirthDate.TabIndex = 15;
            // 
            // cbxGender
            // 
            this.cbxGender.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.genderBindingSource, "GenderId", true));
            this.cbxGender.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.genderBindingSource, "GenderName", true));
            this.cbxGender.DataSource = this.genderBindingSource1;
            this.cbxGender.DisplayMember = "GenderName";
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Location = new System.Drawing.Point(156, 210);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(238, 26);
            this.cbxGender.TabIndex = 14;
            this.cbxGender.Tag = "";
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataSource = typeof(Entities.Models.Gender);
            // 
            // genderBindingSource1
            // 
            this.genderBindingSource1.DataSource = typeof(Entities.Models.Gender);
            // 
            // txtIDNo
            // 
            this.txtIDNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDNo.Location = new System.Drawing.Point(156, 68);
            this.txtIDNo.MinimumSize = new System.Drawing.Size(50, 4);
            this.txtIDNo.Name = "txtIDNo";
            this.txtIDNo.Size = new System.Drawing.Size(297, 24);
            this.txtIDNo.TabIndex = 13;
            this.txtIDNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDNo_KeyPress);
            // 
            // dtpAdmitDate
            // 
            this.dtpAdmitDate.Location = new System.Drawing.Point(156, 412);
            this.dtpAdmitDate.Name = "dtpAdmitDate";
            this.dtpAdmitDate.Size = new System.Drawing.Size(297, 24);
            this.dtpAdmitDate.TabIndex = 12;
            // 
            // txtLastname
            // 
            this.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastname.Location = new System.Drawing.Point(583, 137);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(301, 24);
            this.txtLastname.TabIndex = 11;
            this.txtLastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastname_KeyPress);
            // 
            // txtFirstname
            // 
            this.txtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstname.Location = new System.Drawing.Point(156, 141);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(297, 24);
            this.txtFirstname.TabIndex = 10;
            this.txtFirstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstname_KeyPress);
            // 
            // lblWardNo
            // 
            this.lblWardNo.AutoSize = true;
            this.lblWardNo.Location = new System.Drawing.Point(480, 339);
            this.lblWardNo.Name = "lblWardNo";
            this.lblWardNo.Size = new System.Drawing.Size(80, 18);
            this.lblWardNo.TabIndex = 9;
            this.lblWardNo.Text = "Ward No.";
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Location = new System.Drawing.Point(42, 343);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(60, 18);
            this.lblDoctorName.TabIndex = 8;
            this.lblDoctorName.Text = "Doctor";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Location = new System.Drawing.Point(480, 274);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(94, 18);
            this.lblContactNo.TabIndex = 7;
            this.lblContactNo.Text = "Contact No";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(42, 280);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 18);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(480, 213);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(83, 18);
            this.lblDob.TabIndex = 5;
            this.lblDob.Text = "Birth Date";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(42, 213);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 18);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender";
            // 
            // lblIDNo
            // 
            this.lblIDNo.AutoSize = true;
            this.lblIDNo.Location = new System.Drawing.Point(49, 70);
            this.lblIDNo.Name = "lblIDNo";
            this.lblIDNo.Size = new System.Drawing.Size(56, 18);
            this.lblIDNo.TabIndex = 3;
            this.lblIDNo.Text = "ID No.";
            // 
            // lblAdmitDate
            // 
            this.lblAdmitDate.AutoSize = true;
            this.lblAdmitDate.Location = new System.Drawing.Point(38, 412);
            this.lblAdmitDate.Name = "lblAdmitDate";
            this.lblAdmitDate.Size = new System.Drawing.Size(90, 18);
            this.lblAdmitDate.TabIndex = 2;
            this.lblAdmitDate.Text = "Admit Date";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(480, 139);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(81, 18);
            this.lblLastname.TabIndex = 1;
            this.lblLastname.Text = "Lastname";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(45, 143);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(83, 18);
            this.lblFirstname.TabIndex = 0;
            this.lblFirstname.Text = "Firstname";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LimeGreen;
            this.btnBack.Location = new System.Drawing.Point(742, 646);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 36);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "Back to List";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmPatientRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 798);
            this.Controls.Add(this.grpBxPatientRegistration);
            this.Name = "FrmPatientRegistration";
            this.Text = "FrmPatientRegistration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPatientRegistration_Load);
            this.grpBxPatientRegistration.ResumeLayout(false);
            this.grpBxPatientRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxPatientRegistration;
        private System.Windows.Forms.Label lblAdmitDate;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblWardNo;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblIDNo;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.DateTimePicker dtpAdmitDate;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtWardNo;
        private System.Windows.Forms.TextBox txtDoctor;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.TextBox txtIDNo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox rtbStatus;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private System.Windows.Forms.BindingSource genderBindingSource1;
        private System.Windows.Forms.Label lblValStatus;
        private System.Windows.Forms.Label lblValWardNo;
        private System.Windows.Forms.Label lblValDoctor;
        private System.Windows.Forms.Label lblValContactNo;
        private System.Windows.Forms.Label lblValEmail;
        private System.Windows.Forms.Label lblValFirstname;
        private System.Windows.Forms.Label lblValLastname;
        private System.Windows.Forms.Label lblValIdNo;
        private System.Windows.Forms.Button btnBack;
    }
}