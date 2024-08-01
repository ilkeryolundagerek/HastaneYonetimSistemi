namespace HastaneYonetimSistemi.Doctors
{
    partial class NewDoctor
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
            this.btn_doctor_cancel = new System.Windows.Forms.Button();
            this.btn_doctor_save = new System.Windows.Forms.Button();
            this.cb_doctor_bloodType = new System.Windows.Forms.ComboBox();
            this.mtb_doctor_phone = new System.Windows.Forms.MaskedTextBox();
            this.mtb_doctor_tckn = new System.Windows.Forms.MaskedTextBox();
            this.tb_doctor_surname = new System.Windows.Forms.TextBox();
            this.tb_doctor_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_doctor_departments = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_doctor_specializations = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_doctor_email = new System.Windows.Forms.TextBox();
            this.rb_doctor_other = new System.Windows.Forms.RadioButton();
            this.rb_doctor_female = new System.Windows.Forms.RadioButton();
            this.rb_doctor_male = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_doctor_dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_doctor_cancel
            // 
            this.btn_doctor_cancel.Location = new System.Drawing.Point(28, 412);
            this.btn_doctor_cancel.Name = "btn_doctor_cancel";
            this.btn_doctor_cancel.Size = new System.Drawing.Size(105, 38);
            this.btn_doctor_cancel.TabIndex = 35;
            this.btn_doctor_cancel.Text = "Vazgeç";
            this.btn_doctor_cancel.UseVisualStyleBackColor = true;
            this.btn_doctor_cancel.Click += new System.EventHandler(this.btn_doctor_cancel_Click);
            // 
            // btn_doctor_save
            // 
            this.btn_doctor_save.Location = new System.Drawing.Point(213, 412);
            this.btn_doctor_save.Name = "btn_doctor_save";
            this.btn_doctor_save.Size = new System.Drawing.Size(138, 38);
            this.btn_doctor_save.TabIndex = 34;
            this.btn_doctor_save.Text = "Yeni Doktor Ekle";
            this.btn_doctor_save.UseVisualStyleBackColor = true;
            this.btn_doctor_save.Click += new System.EventHandler(this.btn_doctor_save_Click);
            // 
            // cb_doctor_bloodType
            // 
            this.cb_doctor_bloodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_doctor_bloodType.FormattingEnabled = true;
            this.cb_doctor_bloodType.Items.AddRange(new object[] {
            "Seçiniz...",
            "A Rh+",
            "A Rh-",
            "B Rh+",
            "B Rh-",
            "AB Rh+",
            "AB Rh-",
            "0 Rh+",
            "0 Rh-"});
            this.cb_doctor_bloodType.Location = new System.Drawing.Point(139, 178);
            this.cb_doctor_bloodType.Name = "cb_doctor_bloodType";
            this.cb_doctor_bloodType.Size = new System.Drawing.Size(212, 28);
            this.cb_doctor_bloodType.TabIndex = 33;
            // 
            // mtb_doctor_phone
            // 
            this.mtb_doctor_phone.Location = new System.Drawing.Point(139, 114);
            this.mtb_doctor_phone.Mask = "0000000000";
            this.mtb_doctor_phone.Name = "mtb_doctor_phone";
            this.mtb_doctor_phone.Size = new System.Drawing.Size(212, 26);
            this.mtb_doctor_phone.TabIndex = 32;
            // 
            // mtb_doctor_tckn
            // 
            this.mtb_doctor_tckn.Location = new System.Drawing.Point(139, 82);
            this.mtb_doctor_tckn.Mask = "00000000000";
            this.mtb_doctor_tckn.Name = "mtb_doctor_tckn";
            this.mtb_doctor_tckn.Size = new System.Drawing.Size(212, 26);
            this.mtb_doctor_tckn.TabIndex = 31;
            // 
            // tb_doctor_surname
            // 
            this.tb_doctor_surname.Location = new System.Drawing.Point(139, 50);
            this.tb_doctor_surname.Name = "tb_doctor_surname";
            this.tb_doctor_surname.Size = new System.Drawing.Size(212, 26);
            this.tb_doctor_surname.TabIndex = 30;
            // 
            // tb_doctor_name
            // 
            this.tb_doctor_name.Location = new System.Drawing.Point(139, 18);
            this.tb_doctor_name.Name = "tb_doctor_name";
            this.tb_doctor_name.Size = new System.Drawing.Size(212, 26);
            this.tb_doctor_name.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Kan Grubu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "T.C. Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Soyisim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "İsim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "E-Posta:";
            // 
            // cb_doctor_departments
            // 
            this.cb_doctor_departments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_doctor_departments.FormattingEnabled = true;
            this.cb_doctor_departments.Location = new System.Drawing.Point(139, 212);
            this.cb_doctor_departments.Name = "cb_doctor_departments";
            this.cb_doctor_departments.Size = new System.Drawing.Size(212, 28);
            this.cb_doctor_departments.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Bölüm:";
            // 
            // cb_doctor_specializations
            // 
            this.cb_doctor_specializations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_doctor_specializations.FormattingEnabled = true;
            this.cb_doctor_specializations.Location = new System.Drawing.Point(139, 246);
            this.cb_doctor_specializations.Name = "cb_doctor_specializations";
            this.cb_doctor_specializations.Size = new System.Drawing.Size(212, 28);
            this.cb_doctor_specializations.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Uzmanlık:";
            // 
            // tb_doctor_email
            // 
            this.tb_doctor_email.Location = new System.Drawing.Point(139, 146);
            this.tb_doctor_email.Name = "tb_doctor_email";
            this.tb_doctor_email.Size = new System.Drawing.Size(212, 26);
            this.tb_doctor_email.TabIndex = 42;
            // 
            // rb_doctor_other
            // 
            this.rb_doctor_other.AutoSize = true;
            this.rb_doctor_other.Location = new System.Drawing.Point(286, 280);
            this.rb_doctor_other.Name = "rb_doctor_other";
            this.rb_doctor_other.Size = new System.Drawing.Size(65, 24);
            this.rb_doctor_other.TabIndex = 46;
            this.rb_doctor_other.TabStop = true;
            this.rb_doctor_other.Text = "Diğer";
            this.rb_doctor_other.UseVisualStyleBackColor = true;
            // 
            // rb_doctor_female
            // 
            this.rb_doctor_female.AutoSize = true;
            this.rb_doctor_female.Location = new System.Drawing.Point(213, 280);
            this.rb_doctor_female.Name = "rb_doctor_female";
            this.rb_doctor_female.Size = new System.Drawing.Size(67, 24);
            this.rb_doctor_female.TabIndex = 45;
            this.rb_doctor_female.TabStop = true;
            this.rb_doctor_female.Text = "Kadın";
            this.rb_doctor_female.UseVisualStyleBackColor = true;
            // 
            // rb_doctor_male
            // 
            this.rb_doctor_male.AutoSize = true;
            this.rb_doctor_male.Location = new System.Drawing.Point(139, 280);
            this.rb_doctor_male.Name = "rb_doctor_male";
            this.rb_doctor_male.Size = new System.Drawing.Size(68, 24);
            this.rb_doctor_male.TabIndex = 44;
            this.rb_doctor_male.TabStop = true;
            this.rb_doctor_male.Text = "Erkek";
            this.rb_doctor_male.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "Cinsiyet:";
            // 
            // dtp_doctor_dateOfBirth
            // 
            this.dtp_doctor_dateOfBirth.Location = new System.Drawing.Point(139, 310);
            this.dtp_doctor_dateOfBirth.Name = "dtp_doctor_dateOfBirth";
            this.dtp_doctor_dateOfBirth.Size = new System.Drawing.Size(212, 26);
            this.dtp_doctor_dateOfBirth.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 47;
            this.label9.Text = "Doğum Tarihi:";
            // 
            // NewDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 462);
            this.Controls.Add(this.dtp_doctor_dateOfBirth);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rb_doctor_other);
            this.Controls.Add(this.rb_doctor_female);
            this.Controls.Add(this.rb_doctor_male);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_doctor_email);
            this.Controls.Add(this.cb_doctor_specializations);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_doctor_departments);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_doctor_cancel);
            this.Controls.Add(this.btn_doctor_save);
            this.Controls.Add(this.cb_doctor_bloodType);
            this.Controls.Add(this.mtb_doctor_phone);
            this.Controls.Add(this.mtb_doctor_tckn);
            this.Controls.Add(this.tb_doctor_surname);
            this.Controls.Add(this.tb_doctor_name);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewDoctor";
            this.Text = "Yeni Doktor Ekle";
            this.Load += new System.EventHandler(this.NewDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_doctor_cancel;
        private System.Windows.Forms.Button btn_doctor_save;
        private System.Windows.Forms.ComboBox cb_doctor_bloodType;
        private System.Windows.Forms.MaskedTextBox mtb_doctor_phone;
        private System.Windows.Forms.MaskedTextBox mtb_doctor_tckn;
        private System.Windows.Forms.TextBox tb_doctor_surname;
        private System.Windows.Forms.TextBox tb_doctor_name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_doctor_departments;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_doctor_specializations;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_doctor_email;
        private System.Windows.Forms.RadioButton rb_doctor_other;
        private System.Windows.Forms.RadioButton rb_doctor_female;
        private System.Windows.Forms.RadioButton rb_doctor_male;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_doctor_dateOfBirth;
        private System.Windows.Forms.Label label9;
    }
}