namespace App.Design_Form
{
    partial class DATA_PERPANJANGAN
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTRANSAKSI = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBROWSE = new System.Windows.Forms.Button();
            this.cboTRANS = new System.Windows.Forms.ComboBox();
            this.txtALASAN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTGL = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPERPANJANGAN = new System.Windows.Forms.TextBox();
            this.cboHARI = new System.Windows.Forms.ComboBox();
            this.txtTGL_AWAL = new System.Windows.Forms.TextBox();
            this.txtTGL_AKHIR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNASABAH = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTRANSAKSI);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnBROWSE);
            this.panel1.Controls.Add(this.cboTRANS);
            this.panel1.Controls.Add(this.txtALASAN);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtTGL);
            this.panel1.Controls.Add(this.btnSimpan);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtPERPANJANGAN);
            this.panel1.Controls.Add(this.cboHARI);
            this.panel1.Controls.Add(this.txtTGL_AWAL);
            this.panel1.Controls.Add(this.txtTGL_AKHIR);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNASABAH);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(791, 283);
            this.panel1.TabIndex = 1;
            // 
            // lblTRANSAKSI
            // 
            this.lblTRANSAKSI.AutoSize = true;
            this.lblTRANSAKSI.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTRANSAKSI.Location = new System.Drawing.Point(47, 43);
            this.lblTRANSAKSI.Name = "lblTRANSAKSI";
            this.lblTRANSAKSI.Size = new System.Drawing.Size(72, 13);
            this.lblTRANSAKSI.TabIndex = 30;
            this.lblTRANSAKSI.Text = "No. Transaksi";
            this.lblTRANSAKSI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(620, 246);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Baru";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBROWSE
            // 
            this.btnBROWSE.Location = new System.Drawing.Point(337, 40);
            this.btnBROWSE.Name = "btnBROWSE";
            this.btnBROWSE.Size = new System.Drawing.Size(26, 21);
            this.btnBROWSE.TabIndex = 19;
            this.btnBROWSE.Text = "...";
            this.btnBROWSE.UseVisualStyleBackColor = true;
            this.btnBROWSE.Click += new System.EventHandler(this.btnBROWSE_Click);
            // 
            // cboTRANS
            // 
            this.cboTRANS.FormattingEnabled = true;
            this.cboTRANS.Location = new System.Drawing.Point(125, 40);
            this.cboTRANS.Name = "cboTRANS";
            this.cboTRANS.Size = new System.Drawing.Size(206, 21);
            this.cboTRANS.TabIndex = 18;
            this.cboTRANS.SelectedIndexChanged += new System.EventHandler(this.cboTRANS_SelectedIndexChanged);
            this.cboTRANS.Validated += new System.EventHandler(this.cboTRANS_Validated);
            // 
            // txtALASAN
            // 
            this.txtALASAN.Location = new System.Drawing.Point(125, 170);
            this.txtALASAN.Multiline = true;
            this.txtALASAN.Name = "txtALASAN";
            this.txtALASAN.Size = new System.Drawing.Size(651, 70);
            this.txtALASAN.TabIndex = 17;
            this.txtALASAN.Validating += new System.ComponentModel.CancelEventHandler(this.txtALASAN_Validating);
            this.txtALASAN.Validated += new System.EventHandler(this.txtALASAN_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Alasan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tanggal";
            // 
            // txtTGL
            // 
            this.txtTGL.Location = new System.Drawing.Point(304, 144);
            this.txtTGL.Name = "txtTGL";
            this.txtTGL.ReadOnly = true;
            this.txtTGL.Size = new System.Drawing.Size(262, 20);
            this.txtTGL.TabIndex = 14;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(701, 246);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 13;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "No";
            // 
            // txtPERPANJANGAN
            // 
            this.txtPERPANJANGAN.Location = new System.Drawing.Point(125, 13);
            this.txtPERPANJANGAN.Name = "txtPERPANJANGAN";
            this.txtPERPANJANGAN.ReadOnly = true;
            this.txtPERPANJANGAN.Size = new System.Drawing.Size(206, 20);
            this.txtPERPANJANGAN.TabIndex = 11;
            // 
            // cboHARI
            // 
            this.cboHARI.FormattingEnabled = true;
            this.cboHARI.Items.AddRange(new object[] {
            "10 Hari",
            "20 Hari",
            "30 Hari"});
            this.cboHARI.Location = new System.Drawing.Point(125, 143);
            this.cboHARI.Name = "cboHARI";
            this.cboHARI.Size = new System.Drawing.Size(121, 21);
            this.cboHARI.TabIndex = 10;
            this.cboHARI.SelectedIndexChanged += new System.EventHandler(this.cboHARI_SelectedIndexChanged);
            // 
            // txtTGL_AWAL
            // 
            this.txtTGL_AWAL.Location = new System.Drawing.Point(125, 91);
            this.txtTGL_AWAL.Name = "txtTGL_AWAL";
            this.txtTGL_AWAL.ReadOnly = true;
            this.txtTGL_AWAL.Size = new System.Drawing.Size(651, 20);
            this.txtTGL_AWAL.TabIndex = 9;
            // 
            // txtTGL_AKHIR
            // 
            this.txtTGL_AKHIR.Location = new System.Drawing.Point(125, 117);
            this.txtTGL_AKHIR.Name = "txtTGL_AKHIR";
            this.txtTGL_AKHIR.ReadOnly = true;
            this.txtTGL_AKHIR.Size = new System.Drawing.Size(651, 20);
            this.txtTGL_AKHIR.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Penambahan Hari";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tgl Awal Peminjaman";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tgl Akhir Peminjaman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nasabah";
            // 
            // txtNASABAH
            // 
            this.txtNASABAH.Location = new System.Drawing.Point(125, 65);
            this.txtNASABAH.Name = "txtNASABAH";
            this.txtNASABAH.ReadOnly = true;
            this.txtNASABAH.Size = new System.Drawing.Size(651, 20);
            this.txtNASABAH.TabIndex = 2;
            // 
            // DATA_PERPANJANGAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 311);
            this.Controls.Add(this.panel1);
            this.Name = "DATA_PERPANJANGAN";
            this.Text = "PERPANJANGAN";
            this.Load += new System.EventHandler(this.DATA_PERPANJANGAN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboTRANS;
        private System.Windows.Forms.TextBox txtALASAN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTGL;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPERPANJANGAN;
        private System.Windows.Forms.ComboBox cboHARI;
        private System.Windows.Forms.TextBox txtTGL_AWAL;
        private System.Windows.Forms.TextBox txtTGL_AKHIR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNASABAH;
        private System.Windows.Forms.Button btnBROWSE;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTRANSAKSI;

    }
}