namespace HastaneYonetimSistemi
{
    partial class MainForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_saat = new System.Windows.Forms.ToolStripStatusLabel();
            this.zamanlayici = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hastalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_newPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_listPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevularıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniDoktorEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorBilgileriniGörüntüleGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevularıListeleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniPersonelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelBilgileriniGörüntüleGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratuvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniTestEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testSonuçlarınıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muhasebeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniFaturaOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturalarıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniÖdemeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniİlaçEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçStoklarınıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemYedeklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_saat});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1082, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_saat
            // 
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(118, 17);
            this.lbl_saat.Text = "toolStripStatusLabel1";
            // 
            // zamanlayici
            // 
            this.zamanlayici.Enabled = true;
            this.zamanlayici.Interval = 1000;
            this.zamanlayici.Tick += new System.EventHandler(this.zamanlayici_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastalarToolStripMenuItem,
            this.doktorlarToolStripMenuItem,
            this.personelToolStripMenuItem,
            this.laboratuvarToolStripMenuItem,
            this.muhasebeToolStripMenuItem,
            this.ilaçlarToolStripMenuItem,
            this.raporlarToolStripMenuItem,
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hastalarToolStripMenuItem
            // 
            this.hastalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item_newPatient,
            this.menu_item_listPatient,
            this.randevuYönetimiToolStripMenuItem});
            this.hastalarToolStripMenuItem.Name = "hastalarToolStripMenuItem";
            this.hastalarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.hastalarToolStripMenuItem.Text = "Hastalar";
            // 
            // menu_item_newPatient
            // 
            this.menu_item_newPatient.Name = "menu_item_newPatient";
            this.menu_item_newPatient.Size = new System.Drawing.Size(263, 22);
            this.menu_item_newPatient.Text = "Yeni Hasta Ekle";
            this.menu_item_newPatient.Click += new System.EventHandler(this.menu_item_newPatient_Click);
            // 
            // menu_item_listPatient
            // 
            this.menu_item_listPatient.Name = "menu_item_listPatient";
            this.menu_item_listPatient.Size = new System.Drawing.Size(263, 22);
            this.menu_item_listPatient.Text = "Hasta Bilgilerini Görüntüle/Güncelle";
            this.menu_item_listPatient.Click += new System.EventHandler(this.menu_item_listPatient_Click);
            // 
            // randevuYönetimiToolStripMenuItem
            // 
            this.randevuYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevuEkleToolStripMenuItem,
            this.randevularıListeleToolStripMenuItem});
            this.randevuYönetimiToolStripMenuItem.Name = "randevuYönetimiToolStripMenuItem";
            this.randevuYönetimiToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.randevuYönetimiToolStripMenuItem.Text = "Randevu Yönetimi";
            // 
            // randevuEkleToolStripMenuItem
            // 
            this.randevuEkleToolStripMenuItem.Name = "randevuEkleToolStripMenuItem";
            this.randevuEkleToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.randevuEkleToolStripMenuItem.Text = "Randevu Ekle";
            // 
            // randevularıListeleToolStripMenuItem
            // 
            this.randevularıListeleToolStripMenuItem.Name = "randevularıListeleToolStripMenuItem";
            this.randevularıListeleToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.randevularıListeleToolStripMenuItem.Text = "Randevuları Listele";
            // 
            // doktorlarToolStripMenuItem
            // 
            this.doktorlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniDoktorEkleToolStripMenuItem,
            this.doktorBilgileriniGörüntüleGüncelleToolStripMenuItem,
            this.randevularıListeleToolStripMenuItem1});
            this.doktorlarToolStripMenuItem.Name = "doktorlarToolStripMenuItem";
            this.doktorlarToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.doktorlarToolStripMenuItem.Text = "Doktorlar";
            // 
            // yeniDoktorEkleToolStripMenuItem
            // 
            this.yeniDoktorEkleToolStripMenuItem.Name = "yeniDoktorEkleToolStripMenuItem";
            this.yeniDoktorEkleToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.yeniDoktorEkleToolStripMenuItem.Text = "Yeni Doktor Ekle";
            // 
            // doktorBilgileriniGörüntüleGüncelleToolStripMenuItem
            // 
            this.doktorBilgileriniGörüntüleGüncelleToolStripMenuItem.Name = "doktorBilgileriniGörüntüleGüncelleToolStripMenuItem";
            this.doktorBilgileriniGörüntüleGüncelleToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.doktorBilgileriniGörüntüleGüncelleToolStripMenuItem.Text = "Doktor Bilgilerini Görüntüle/Güncelle";
            // 
            // randevularıListeleToolStripMenuItem1
            // 
            this.randevularıListeleToolStripMenuItem1.Name = "randevularıListeleToolStripMenuItem1";
            this.randevularıListeleToolStripMenuItem1.Size = new System.Drawing.Size(269, 22);
            this.randevularıListeleToolStripMenuItem1.Text = "Randevuları Listele";
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniPersonelEkleToolStripMenuItem,
            this.personelBilgileriniGörüntüleGüncelleToolStripMenuItem});
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.personelToolStripMenuItem.Text = "Personel";
            // 
            // yeniPersonelEkleToolStripMenuItem
            // 
            this.yeniPersonelEkleToolStripMenuItem.Name = "yeniPersonelEkleToolStripMenuItem";
            this.yeniPersonelEkleToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.yeniPersonelEkleToolStripMenuItem.Text = "Yeni Personel Ekle";
            // 
            // personelBilgileriniGörüntüleGüncelleToolStripMenuItem
            // 
            this.personelBilgileriniGörüntüleGüncelleToolStripMenuItem.Name = "personelBilgileriniGörüntüleGüncelleToolStripMenuItem";
            this.personelBilgileriniGörüntüleGüncelleToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.personelBilgileriniGörüntüleGüncelleToolStripMenuItem.Text = "Personel Bilgilerini Görüntüle/Güncelle";
            // 
            // laboratuvarToolStripMenuItem
            // 
            this.laboratuvarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniTestEkleToolStripMenuItem,
            this.testSonuçlarınıGörüntüleToolStripMenuItem});
            this.laboratuvarToolStripMenuItem.Name = "laboratuvarToolStripMenuItem";
            this.laboratuvarToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.laboratuvarToolStripMenuItem.Text = "Laboratuvar";
            // 
            // yeniTestEkleToolStripMenuItem
            // 
            this.yeniTestEkleToolStripMenuItem.Name = "yeniTestEkleToolStripMenuItem";
            this.yeniTestEkleToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.yeniTestEkleToolStripMenuItem.Text = "Yeni Test Ekle";
            // 
            // testSonuçlarınıGörüntüleToolStripMenuItem
            // 
            this.testSonuçlarınıGörüntüleToolStripMenuItem.Name = "testSonuçlarınıGörüntüleToolStripMenuItem";
            this.testSonuçlarınıGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.testSonuçlarınıGörüntüleToolStripMenuItem.Text = "Test Sonuçlarını Görüntüle";
            // 
            // muhasebeToolStripMenuItem
            // 
            this.muhasebeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniFaturaOluşturToolStripMenuItem,
            this.faturalarıGörüntüleToolStripMenuItem,
            this.yeniÖdemeEkleToolStripMenuItem});
            this.muhasebeToolStripMenuItem.Name = "muhasebeToolStripMenuItem";
            this.muhasebeToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.muhasebeToolStripMenuItem.Text = "Muhasebe";
            // 
            // yeniFaturaOluşturToolStripMenuItem
            // 
            this.yeniFaturaOluşturToolStripMenuItem.Name = "yeniFaturaOluşturToolStripMenuItem";
            this.yeniFaturaOluşturToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.yeniFaturaOluşturToolStripMenuItem.Text = "Yeni Fatura Oluştur";
            // 
            // faturalarıGörüntüleToolStripMenuItem
            // 
            this.faturalarıGörüntüleToolStripMenuItem.Name = "faturalarıGörüntüleToolStripMenuItem";
            this.faturalarıGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.faturalarıGörüntüleToolStripMenuItem.Text = "Faturaları Görüntüle";
            // 
            // yeniÖdemeEkleToolStripMenuItem
            // 
            this.yeniÖdemeEkleToolStripMenuItem.Name = "yeniÖdemeEkleToolStripMenuItem";
            this.yeniÖdemeEkleToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.yeniÖdemeEkleToolStripMenuItem.Text = "Yeni Ödeme Ekle";
            // 
            // ilaçlarToolStripMenuItem
            // 
            this.ilaçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniİlaçEkleToolStripMenuItem,
            this.ilaçStoklarınıGörüntüleToolStripMenuItem});
            this.ilaçlarToolStripMenuItem.Name = "ilaçlarToolStripMenuItem";
            this.ilaçlarToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ilaçlarToolStripMenuItem.Text = "İlaçlar";
            // 
            // yeniİlaçEkleToolStripMenuItem
            // 
            this.yeniİlaçEkleToolStripMenuItem.Name = "yeniİlaçEkleToolStripMenuItem";
            this.yeniİlaçEkleToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.yeniİlaçEkleToolStripMenuItem.Text = "Yeni İlaç Ekle";
            // 
            // ilaçStoklarınıGörüntüleToolStripMenuItem
            // 
            this.ilaçStoklarınıGörüntüleToolStripMenuItem.Name = "ilaçStoklarınıGörüntüleToolStripMenuItem";
            this.ilaçStoklarınıGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.ilaçStoklarınıGörüntüleToolStripMenuItem.Text = "İlaç Stoklarını Görüntüle";
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raporlarıGörüntüleToolStripMenuItem});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // raporlarıGörüntüleToolStripMenuItem
            // 
            this.raporlarıGörüntüleToolStripMenuItem.Name = "raporlarıGörüntüleToolStripMenuItem";
            this.raporlarıGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.raporlarıGörüntüleToolStripMenuItem.Text = "Raporları Görüntüle";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıYönetimiToolStripMenuItem,
            this.sistemYedeklemeToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // kullanıcıYönetimiToolStripMenuItem
            // 
            this.kullanıcıYönetimiToolStripMenuItem.Name = "kullanıcıYönetimiToolStripMenuItem";
            this.kullanıcıYönetimiToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.kullanıcıYönetimiToolStripMenuItem.Text = "Kullanıcı Yönetimi";
            // 
            // sistemYedeklemeToolStripMenuItem
            // 
            this.sistemYedeklemeToolStripMenuItem.Name = "sistemYedeklemeToolStripMenuItem";
            this.sistemYedeklemeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.sistemYedeklemeToolStripMenuItem.Text = "Sistem Yedekleme";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1082, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Hastane Yönetim Sistemi v1.0.0";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_saat;
        private System.Windows.Forms.Timer zamanlayici;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hastalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_item_newPatient;
        private System.Windows.Forms.ToolStripMenuItem menu_item_listPatient;
        private System.Windows.Forms.ToolStripMenuItem randevuYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevularıListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniDoktorEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorBilgileriniGörüntüleGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevularıListeleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniPersonelEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelBilgileriniGörüntüleGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratuvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniTestEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testSonuçlarınıGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muhasebeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniFaturaOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturalarıGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniÖdemeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniİlaçEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçStoklarınıGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarıGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemYedeklemeToolStripMenuItem;
    }
}

