namespace App
{
    partial class FrmUtama
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGudangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bungaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transkasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peminjamanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listPeminjamanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perpanjanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pembayaranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lapNasabahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peminjamanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pembayaranToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.perNasabahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perPeriodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perpanjanganToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notifikasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengaturanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gantiPaswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAkunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_login = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.xxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perpanjanganToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pembayranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifikasiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNotif = new System.Windows.Forms.Label();
            this.dendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.transkasiToolStripMenuItem,
            this.laporanToolStripMenuItem,
            this.notifikasiToolStripMenuItem,
            this.pengaturanToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.VisibleChanged += new System.EventHandler(this.menuStrip1_VisibleChanged);
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataCustomerToolStripMenuItem,
            this.dataGudangToolStripMenuItem,
            this.bungaToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // dataCustomerToolStripMenuItem
            // 
            this.dataCustomerToolStripMenuItem.Name = "dataCustomerToolStripMenuItem";
            this.dataCustomerToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.dataCustomerToolStripMenuItem.Text = "Data Nasabah";
            this.dataCustomerToolStripMenuItem.Click += new System.EventHandler(this.dataCustomerToolStripMenuItem_Click);
            // 
            // dataGudangToolStripMenuItem
            // 
            this.dataGudangToolStripMenuItem.Name = "dataGudangToolStripMenuItem";
            this.dataGudangToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.dataGudangToolStripMenuItem.Text = "Data Gudang";
            this.dataGudangToolStripMenuItem.Click += new System.EventHandler(this.dataGudangToolStripMenuItem_Click);
            // 
            // bungaToolStripMenuItem
            // 
            this.bungaToolStripMenuItem.Name = "bungaToolStripMenuItem";
            this.bungaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.bungaToolStripMenuItem.Text = "Bunga";
            this.bungaToolStripMenuItem.Click += new System.EventHandler(this.bungaToolStripMenuItem_Click);
            // 
            // transkasiToolStripMenuItem
            // 
            this.transkasiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peminjamanToolStripMenuItem,
            this.perpanjanganToolStripMenuItem,
            this.pembayaranToolStripMenuItem});
            this.transkasiToolStripMenuItem.Name = "transkasiToolStripMenuItem";
            this.transkasiToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.transkasiToolStripMenuItem.Text = "Transkasi";
            // 
            // peminjamanToolStripMenuItem
            // 
            this.peminjamanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kontrakToolStripMenuItem,
            this.listPeminjamanToolStripMenuItem});
            this.peminjamanToolStripMenuItem.Name = "peminjamanToolStripMenuItem";
            this.peminjamanToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.peminjamanToolStripMenuItem.Text = "Peminjaman";
            // 
            // kontrakToolStripMenuItem
            // 
            this.kontrakToolStripMenuItem.Name = "kontrakToolStripMenuItem";
            this.kontrakToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.kontrakToolStripMenuItem.Text = "+ Kontrak";
            this.kontrakToolStripMenuItem.Click += new System.EventHandler(this.kontrakToolStripMenuItem_Click);
            // 
            // listPeminjamanToolStripMenuItem
            // 
            this.listPeminjamanToolStripMenuItem.Name = "listPeminjamanToolStripMenuItem";
            this.listPeminjamanToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.listPeminjamanToolStripMenuItem.Text = "List Peminjaman";
            this.listPeminjamanToolStripMenuItem.Click += new System.EventHandler(this.listPeminjamanToolStripMenuItem_Click);
            // 
            // perpanjanganToolStripMenuItem
            // 
            this.perpanjanganToolStripMenuItem.Name = "perpanjanganToolStripMenuItem";
            this.perpanjanganToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.perpanjanganToolStripMenuItem.Text = "Perpanjangan";
            this.perpanjanganToolStripMenuItem.Click += new System.EventHandler(this.perpanjanganToolStripMenuItem_Click);
            // 
            // pembayaranToolStripMenuItem
            // 
            this.pembayaranToolStripMenuItem.Name = "pembayaranToolStripMenuItem";
            this.pembayaranToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.pembayaranToolStripMenuItem.Text = "Pembayaran";
            this.pembayaranToolStripMenuItem.Click += new System.EventHandler(this.pembayaranToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lapNasabahToolStripMenuItem,
            this.peminjamanToolStripMenuItem1,
            this.pembayaranToolStripMenuItem1,
            this.perpanjanganToolStripMenuItem1,
            this.dendaToolStripMenuItem});
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.laporanToolStripMenuItem.Text = "Laporan";
            // 
            // lapNasabahToolStripMenuItem
            // 
            this.lapNasabahToolStripMenuItem.Name = "lapNasabahToolStripMenuItem";
            this.lapNasabahToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lapNasabahToolStripMenuItem.Text = "Nasabah";
            this.lapNasabahToolStripMenuItem.Click += new System.EventHandler(this.lapNasabahToolStripMenuItem_Click);
            // 
            // peminjamanToolStripMenuItem1
            // 
            this.peminjamanToolStripMenuItem1.Name = "peminjamanToolStripMenuItem1";
            this.peminjamanToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.peminjamanToolStripMenuItem1.Text = "Peminjaman";
            this.peminjamanToolStripMenuItem1.Click += new System.EventHandler(this.peminjamanToolStripMenuItem1_Click);
            // 
            // pembayaranToolStripMenuItem1
            // 
            this.pembayaranToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perNasabahToolStripMenuItem,
            this.perPeriodeToolStripMenuItem});
            this.pembayaranToolStripMenuItem1.Name = "pembayaranToolStripMenuItem1";
            this.pembayaranToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.pembayaranToolStripMenuItem1.Text = "Pembayaran";
            // 
            // perNasabahToolStripMenuItem
            // 
            this.perNasabahToolStripMenuItem.Name = "perNasabahToolStripMenuItem";
            this.perNasabahToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.perNasabahToolStripMenuItem.Text = "PerCustomer";
            this.perNasabahToolStripMenuItem.Click += new System.EventHandler(this.perNasabahToolStripMenuItem_Click);
            // 
            // perPeriodeToolStripMenuItem
            // 
            this.perPeriodeToolStripMenuItem.Name = "perPeriodeToolStripMenuItem";
            this.perPeriodeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.perPeriodeToolStripMenuItem.Text = "PerPeriode";
            this.perPeriodeToolStripMenuItem.Click += new System.EventHandler(this.perPeriodeToolStripMenuItem_Click);
            // 
            // perpanjanganToolStripMenuItem1
            // 
            this.perpanjanganToolStripMenuItem1.Name = "perpanjanganToolStripMenuItem1";
            this.perpanjanganToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.perpanjanganToolStripMenuItem1.Text = "Perpanjangan";
            this.perpanjanganToolStripMenuItem1.Click += new System.EventHandler(this.perpanjanganToolStripMenuItem1_Click);
            // 
            // notifikasiToolStripMenuItem
            // 
            this.notifikasiToolStripMenuItem.Name = "notifikasiToolStripMenuItem";
            this.notifikasiToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.notifikasiToolStripMenuItem.Text = "Notifikasi";
            this.notifikasiToolStripMenuItem.Click += new System.EventHandler(this.notifikasiToolStripMenuItem_Click);
            // 
            // pengaturanToolStripMenuItem
            // 
            this.pengaturanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historiLoginToolStripMenuItem,
            this.gantiPaswordToolStripMenuItem,
            this.addAkunToolStripMenuItem,
            this.calenderToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.pengaturanToolStripMenuItem.Name = "pengaturanToolStripMenuItem";
            this.pengaturanToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.pengaturanToolStripMenuItem.Text = "Pengaturan";
            // 
            // historiLoginToolStripMenuItem
            // 
            this.historiLoginToolStripMenuItem.Name = "historiLoginToolStripMenuItem";
            this.historiLoginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.historiLoginToolStripMenuItem.Text = "Histori Login";
            this.historiLoginToolStripMenuItem.Click += new System.EventHandler(this.historiLoginToolStripMenuItem_Click);
            // 
            // gantiPaswordToolStripMenuItem
            // 
            this.gantiPaswordToolStripMenuItem.Name = "gantiPaswordToolStripMenuItem";
            this.gantiPaswordToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gantiPaswordToolStripMenuItem.Text = "Ganti Pasword";
            this.gantiPaswordToolStripMenuItem.Click += new System.EventHandler(this.gantiPaswordToolStripMenuItem_Click);
            // 
            // addAkunToolStripMenuItem
            // 
            this.addAkunToolStripMenuItem.Name = "addAkunToolStripMenuItem";
            this.addAkunToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addAkunToolStripMenuItem.Text = "Add Akun";
            this.addAkunToolStripMenuItem.Click += new System.EventHandler(this.addAkunToolStripMenuItem_Click);
            // 
            // calenderToolStripMenuItem
            // 
            this.calenderToolStripMenuItem.Name = "calenderToolStripMenuItem";
            this.calenderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.calenderToolStripMenuItem.Text = "Calender";
            this.calenderToolStripMenuItem.Click += new System.EventHandler(this.calenderToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.status_login,
            this.toolStripStatusLabel2,
            this.timer_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // status_login
            // 
            this.status_login.Name = "status_login";
            this.status_login.Size = new System.Drawing.Size(34, 17);
            this.status_login.Text = "login";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabel2.Text = "==>";
            // 
            // timer_status
            // 
            this.timer_status.Name = "timer_status";
            this.timer_status.Size = new System.Drawing.Size(35, 17);
            this.timer_status.Text = "timer";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xxToolStripMenuItem,
            this.perpanjanganToolStripMenuItem2,
            this.pembayranToolStripMenuItem,
            this.notifikasiToolStripMenuItem1,
            this.logOutToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1184, 72);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // xxToolStripMenuItem
            // 
            this.xxToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.xxToolStripMenuItem.Image = global::App.Properties.Resources.icons8_add_file_64;
            this.xxToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.xxToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.xxToolStripMenuItem.Name = "xxToolStripMenuItem";
            this.xxToolStripMenuItem.Size = new System.Drawing.Size(76, 68);
            this.xxToolStripMenuItem.Text = "Peminjaman";
            this.xxToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.xxToolStripMenuItem.Click += new System.EventHandler(this.xxToolStripMenuItem_Click);
            // 
            // perpanjanganToolStripMenuItem2
            // 
            this.perpanjanganToolStripMenuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.perpanjanganToolStripMenuItem2.Image = global::App.Properties.Resources.icons8_ai_64;
            this.perpanjanganToolStripMenuItem2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.perpanjanganToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.perpanjanganToolStripMenuItem2.Name = "perpanjanganToolStripMenuItem2";
            this.perpanjanganToolStripMenuItem2.Size = new System.Drawing.Size(76, 68);
            this.perpanjanganToolStripMenuItem2.Text = "Perpanjangan";
            this.perpanjanganToolStripMenuItem2.Click += new System.EventHandler(this.perpanjanganToolStripMenuItem2_Click);
            // 
            // pembayranToolStripMenuItem
            // 
            this.pembayranToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pembayranToolStripMenuItem.Image = global::App.Properties.Resources.icons8_money_64;
            this.pembayranToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pembayranToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pembayranToolStripMenuItem.Name = "pembayranToolStripMenuItem";
            this.pembayranToolStripMenuItem.Size = new System.Drawing.Size(76, 68);
            this.pembayranToolStripMenuItem.Text = "Pembayran";
            this.pembayranToolStripMenuItem.Click += new System.EventHandler(this.pembayranToolStripMenuItem_Click);
            // 
            // notifikasiToolStripMenuItem1
            // 
            this.notifikasiToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.notifikasiToolStripMenuItem1.Image = global::App.Properties.Resources.icons8_notification_64;
            this.notifikasiToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.notifikasiToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.notifikasiToolStripMenuItem1.Name = "notifikasiToolStripMenuItem1";
            this.notifikasiToolStripMenuItem1.Size = new System.Drawing.Size(76, 68);
            this.notifikasiToolStripMenuItem1.Text = "Notifikasi";
            this.notifikasiToolStripMenuItem1.Click += new System.EventHandler(this.notifikasiToolStripMenuItem1_Click);
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.logOutToolStripMenuItem1.Image = global::App.Properties.Resources.icons8_shutdown_64;
            this.logOutToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logOutToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(76, 68);
            this.logOutToolStripMenuItem1.Text = "Log Out";
            this.logOutToolStripMenuItem1.Click += new System.EventHandler(this.logOutToolStripMenuItem1_Click);
            // 
            // lblNotif
            // 
            this.lblNotif.AutoSize = true;
            this.lblNotif.BackColor = System.Drawing.Color.Red;
            this.lblNotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotif.ForeColor = System.Drawing.Color.White;
            this.lblNotif.Location = new System.Drawing.Point(282, 34);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.Size = new System.Drawing.Size(17, 18);
            this.lblNotif.TabIndex = 6;
            this.lblNotif.Text = "0";
            // 
            // dendaToolStripMenuItem
            // 
            this.dendaToolStripMenuItem.Name = "dendaToolStripMenuItem";
            this.dendaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dendaToolStripMenuItem.Text = "Denda";
            this.dendaToolStripMenuItem.Click += new System.EventHandler(this.dendaToolStripMenuItem_Click);
            // 
            // FrmUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.lblNotif);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM UTAMA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUtama_FormClosing);
            this.Load += new System.EventHandler(this.FrmUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataGudangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transkasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peminjamanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perpanjanganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pembayaranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengaturanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gantiPaswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lapNasabahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peminjamanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pembayaranToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem perNasabahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perPeriodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perpanjanganToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem notifikasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bungaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontrakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listPeminjamanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAkunToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel status_login;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel timer_status;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem calenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem xxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perpanjanganToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pembayranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notifikasiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
        private System.Windows.Forms.Label lblNotif;
        private System.Windows.Forms.ToolStripMenuItem dendaToolStripMenuItem;
    }
}

