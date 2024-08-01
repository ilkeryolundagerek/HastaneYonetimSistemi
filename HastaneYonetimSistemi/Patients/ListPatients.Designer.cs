namespace HastaneYonetimSistemi.Patients
{
    partial class ListPatients
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
            this.patientListStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_lbl_patient_count = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgv_patientList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BloodType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.District = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientList_options = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu_edit_patient = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_delete_patient = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_refresh_patientList = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_add_appointment = new System.Windows.Forms.ToolStripMenuItem();
            this.patientListStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patientList)).BeginInit();
            this.patientList_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientListStatusStrip
            // 
            this.patientListStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.status_lbl_patient_count});
            this.patientListStatusStrip.Location = new System.Drawing.Point(0, 428);
            this.patientListStatusStrip.Name = "patientListStatusStrip";
            this.patientListStatusStrip.Size = new System.Drawing.Size(800, 22);
            this.patientListStatusStrip.TabIndex = 0;
            this.patientListStatusStrip.Text = "patientListStatusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(107, 17);
            this.toolStripStatusLabel1.Text = "Kayıtlı Hasta Sayısı:";
            // 
            // status_lbl_patient_count
            // 
            this.status_lbl_patient_count.Name = "status_lbl_patient_count";
            this.status_lbl_patient_count.Size = new System.Drawing.Size(13, 17);
            this.status_lbl_patient_count.Text = "0";
            // 
            // dgv_patientList
            // 
            this.dgv_patientList.AllowUserToAddRows = false;
            this.dgv_patientList.AllowUserToDeleteRows = false;
            this.dgv_patientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_patientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NationalId,
            this.Firstname,
            this.Lastname,
            this.DateOfBirth,
            this.Gender,
            this.BloodType,
            this.PhoneNumber,
            this.City,
            this.District});
            this.dgv_patientList.ContextMenuStrip = this.patientList_options;
            this.dgv_patientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_patientList.Location = new System.Drawing.Point(0, 0);
            this.dgv_patientList.MultiSelect = false;
            this.dgv_patientList.Name = "dgv_patientList";
            this.dgv_patientList.ReadOnly = true;
            this.dgv_patientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_patientList.Size = new System.Drawing.Size(800, 428);
            this.dgv_patientList.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // NationalId
            // 
            this.NationalId.DataPropertyName = "NationalId";
            this.NationalId.HeaderText = "T.C. Kimlik No";
            this.NationalId.Name = "NationalId";
            this.NationalId.ReadOnly = true;
            // 
            // Firstname
            // 
            this.Firstname.DataPropertyName = "Firstname";
            this.Firstname.HeaderText = "Ad";
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            // 
            // Lastname
            // 
            this.Lastname.DataPropertyName = "Lastname";
            this.Lastname.HeaderText = "Soyad";
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.HeaderText = "Doğum Tarihi";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Cinsiyet";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // BloodType
            // 
            this.BloodType.DataPropertyName = "BloodType";
            this.BloodType.HeaderText = "Kan Grubu";
            this.BloodType.Name = "BloodType";
            this.BloodType.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Telefon";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "Şehir";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // District
            // 
            this.District.DataPropertyName = "District";
            this.District.HeaderText = "İlçe";
            this.District.Name = "District";
            this.District.ReadOnly = true;
            // 
            // patientList_options
            // 
            this.patientList_options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_edit_patient,
            this.menu_delete_patient,
            this.menu_refresh_patientList,
            this.menu_add_appointment});
            this.patientList_options.Name = "patientList_options";
            this.patientList_options.Size = new System.Drawing.Size(181, 114);
            // 
            // menu_edit_patient
            // 
            this.menu_edit_patient.Name = "menu_edit_patient";
            this.menu_edit_patient.Size = new System.Drawing.Size(180, 22);
            this.menu_edit_patient.Text = "Düzenle";
            this.menu_edit_patient.Click += new System.EventHandler(this.menu_edit_patient_Click);
            // 
            // menu_delete_patient
            // 
            this.menu_delete_patient.Name = "menu_delete_patient";
            this.menu_delete_patient.Size = new System.Drawing.Size(180, 22);
            this.menu_delete_patient.Text = "Sil";
            this.menu_delete_patient.Click += new System.EventHandler(this.menu_delete_patient_Click);
            // 
            // menu_refresh_patientList
            // 
            this.menu_refresh_patientList.Name = "menu_refresh_patientList";
            this.menu_refresh_patientList.Size = new System.Drawing.Size(180, 22);
            this.menu_refresh_patientList.Text = "Yenile";
            // 
            // menu_add_appointment
            // 
            this.menu_add_appointment.Name = "menu_add_appointment";
            this.menu_add_appointment.Size = new System.Drawing.Size(180, 22);
            this.menu_add_appointment.Text = "Randevu Ekle";
            // 
            // ListPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_patientList);
            this.Controls.Add(this.patientListStatusStrip);
            this.Name = "ListPatients";
            this.Text = "Hasta Bilgilerini Görüntüle/Güncelle";
            this.Load += new System.EventHandler(this.ListPatients_Load);
            this.patientListStatusStrip.ResumeLayout(false);
            this.patientListStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patientList)).EndInit();
            this.patientList_options.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip patientListStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel status_lbl_patient_count;
        private System.Windows.Forms.DataGridView dgv_patientList;
        private System.Windows.Forms.ContextMenuStrip patientList_options;
        private System.Windows.Forms.ToolStripMenuItem menu_edit_patient;
        private System.Windows.Forms.ToolStripMenuItem menu_delete_patient;
        private System.Windows.Forms.ToolStripMenuItem menu_refresh_patientList;
        private System.Windows.Forms.ToolStripMenuItem menu_add_appointment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn BloodType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn District;
    }
}