namespace App.Design_Form
{
    partial class DATA_NASABAH
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCARI = new System.Windows.Forms.TextBox();
            this.dgvTAMPIL = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTGL = new System.Windows.Forms.TextBox();
            this.btnUBAH = new System.Windows.Forms.Button();
            this.btnHAPUS = new System.Windows.Forms.Button();
            this.btnRST = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTELPON = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtALAMAT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNASABAH = new System.Windows.Forms.TextBox();
            this.txtKTP = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTAMPIL)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgvTAMPIL);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTGL);
            this.panel1.Controls.Add(this.btnUBAH);
            this.panel1.Controls.Add(this.btnHAPUS);
            this.panel1.Controls.Add(this.btnRST);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTELPON);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtALAMAT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNASABAH);
            this.panel1.Controls.Add(this.txtKTP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(742, 463);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCARI);
            this.groupBox1.Location = new System.Drawing.Point(11, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 49);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari Data";
            // 
            // txtCARI
            // 
            this.txtCARI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCARI.Location = new System.Drawing.Point(6, 19);
            this.txtCARI.Margin = new System.Windows.Forms.Padding(2);
            this.txtCARI.Name = "txtCARI";
            this.txtCARI.Size = new System.Drawing.Size(705, 21);
            this.txtCARI.TabIndex = 33;
            this.txtCARI.TextChanged += new System.EventHandler(this.txtCARI_TextChanged);
            // 
            // dgvTAMPIL
            // 
            this.dgvTAMPIL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTAMPIL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTAMPIL.Location = new System.Drawing.Point(10, 251);
            this.dgvTAMPIL.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTAMPIL.MultiSelect = false;
            this.dgvTAMPIL.Name = "dgvTAMPIL";
            this.dgvTAMPIL.ReadOnly = true;
            this.dgvTAMPIL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTAMPIL.Size = new System.Drawing.Size(717, 198);
            this.dgvTAMPIL.TabIndex = 34;
            this.dgvTAMPIL.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTAMPIL_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(100, 19);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(105, 21);
            this.txtID.TabIndex = 9;
            this.txtID.Validated += new System.EventHandler(this.VALIDASI);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Jatuh Tempo";
            // 
            // txtTGL
            // 
            this.txtTGL.Location = new System.Drawing.Point(100, 144);
            this.txtTGL.Margin = new System.Windows.Forms.Padding(2);
            this.txtTGL.Name = "txtTGL";
            this.txtTGL.ReadOnly = true;
            this.txtTGL.Size = new System.Drawing.Size(454, 21);
            this.txtTGL.TabIndex = 4;
            // 
            // btnUBAH
            // 
            this.btnUBAH.AutoSize = true;
            this.btnUBAH.Location = new System.Drawing.Point(505, 169);
            this.btnUBAH.Margin = new System.Windows.Forms.Padding(2);
            this.btnUBAH.Name = "btnUBAH";
            this.btnUBAH.Size = new System.Drawing.Size(49, 23);
            this.btnUBAH.TabIndex = 7;
            this.btnUBAH.Text = "Ubah";
            this.btnUBAH.UseVisualStyleBackColor = true;
            this.btnUBAH.Click += new System.EventHandler(this.btnUBAH_Click);
            // 
            // btnHAPUS
            // 
            this.btnHAPUS.AutoSize = true;
            this.btnHAPUS.Location = new System.Drawing.Point(452, 169);
            this.btnHAPUS.Margin = new System.Windows.Forms.Padding(2);
            this.btnHAPUS.Name = "btnHAPUS";
            this.btnHAPUS.Size = new System.Drawing.Size(49, 23);
            this.btnHAPUS.TabIndex = 6;
            this.btnHAPUS.Text = "Hapus";
            this.btnHAPUS.UseVisualStyleBackColor = true;
            this.btnHAPUS.Click += new System.EventHandler(this.btnHAPUS_Click);
            // 
            // btnRST
            // 
            this.btnRST.AutoSize = true;
            this.btnRST.Location = new System.Drawing.Point(399, 169);
            this.btnRST.Margin = new System.Windows.Forms.Padding(2);
            this.btnRST.Name = "btnRST";
            this.btnRST.Size = new System.Drawing.Size(49, 23);
            this.btnRST.TabIndex = 5;
            this.btnRST.Text = "Reset";
            this.btnRST.UseVisualStyleBackColor = true;
            this.btnRST.Click += new System.EventHandler(this.btnRST_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "No. Telp";
            // 
            // txtTELPON
            // 
            this.txtTELPON.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTELPON.Location = new System.Drawing.Point(100, 119);
            this.txtTELPON.Margin = new System.Windows.Forms.Padding(2);
            this.txtTELPON.MaxLength = 50;
            this.txtTELPON.Name = "txtTELPON";
            this.txtTELPON.Size = new System.Drawing.Size(454, 21);
            this.txtTELPON.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Alamat";
            // 
            // txtALAMAT
            // 
            this.txtALAMAT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtALAMAT.Location = new System.Drawing.Point(100, 94);
            this.txtALAMAT.Margin = new System.Windows.Forms.Padding(2);
            this.txtALAMAT.MaxLength = 100;
            this.txtALAMAT.Name = "txtALAMAT";
            this.txtALAMAT.Size = new System.Drawing.Size(454, 21);
            this.txtALAMAT.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nama Nasabah";
            // 
            // txtNASABAH
            // 
            this.txtNASABAH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNASABAH.Location = new System.Drawing.Point(100, 69);
            this.txtNASABAH.Margin = new System.Windows.Forms.Padding(2);
            this.txtNASABAH.MaxLength = 50;
            this.txtNASABAH.Name = "txtNASABAH";
            this.txtNASABAH.Size = new System.Drawing.Size(454, 21);
            this.txtNASABAH.TabIndex = 1;
            // 
            // txtKTP
            // 
            this.txtKTP.Location = new System.Drawing.Point(100, 44);
            this.txtKTP.Margin = new System.Windows.Forms.Padding(2);
            this.txtKTP.Mask = "0000000000000000";
            this.txtKTP.Name = "txtKTP";
            this.txtKTP.Size = new System.Drawing.Size(105, 21);
            this.txtKTP.TabIndex = 0;
            this.txtKTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKTP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtKTP_MouseClick);
            this.txtKTP.TextChanged += new System.EventHandler(this.txtKTP_TextChanged);
            this.txtKTP.Validated += new System.EventHandler(this.VALIDASI);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "No. KTP";
            // 
            // DATA_NASABAH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(764, 485);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DATA_NASABAH";
            this.Text = "DATA_NASABAH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DATA_NASABAH_FormClosing);
            this.Load += new System.EventHandler(this.DATA_NASABAH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTAMPIL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTELPON;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtALAMAT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNASABAH;
        private System.Windows.Forms.MaskedTextBox txtKTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUBAH;
        private System.Windows.Forms.Button btnHAPUS;
        private System.Windows.Forms.Button btnRST;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTGL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dgvTAMPIL;
        private System.Windows.Forms.TextBox txtCARI;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}