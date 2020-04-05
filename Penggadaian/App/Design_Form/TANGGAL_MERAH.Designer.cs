namespace App.Design_Form
{
    partial class TANGGAL_MERAH
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSIMPAN = new System.Windows.Forms.Button();
            this.btnUBAH = new System.Windows.Forms.Button();
            this.btnHAPUS = new System.Windows.Forms.Button();
            this.btnRST = new System.Windows.Forms.Button();
            this.txtKET = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHEADER = new System.Windows.Forms.Label();
            this.dtpTgl = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnSIMPAN);
            this.panel1.Controls.Add(this.btnUBAH);
            this.panel1.Controls.Add(this.btnHAPUS);
            this.panel1.Controls.Add(this.btnRST);
            this.panel1.Controls.Add(this.txtKET);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtHEADER);
            this.panel1.Controls.Add(this.dtpTgl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(465, 341);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Keterangan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 181);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(442, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnSIMPAN
            // 
            this.btnSIMPAN.AutoSize = true;
            this.btnSIMPAN.Location = new System.Drawing.Point(403, 153);
            this.btnSIMPAN.Margin = new System.Windows.Forms.Padding(2);
            this.btnSIMPAN.Name = "btnSIMPAN";
            this.btnSIMPAN.Size = new System.Drawing.Size(52, 23);
            this.btnSIMPAN.TabIndex = 12;
            this.btnSIMPAN.Text = "Simpan";
            this.btnSIMPAN.UseVisualStyleBackColor = true;
            this.btnSIMPAN.Click += new System.EventHandler(this.btnSIMPAN_Click);
            // 
            // btnUBAH
            // 
            this.btnUBAH.AutoSize = true;
            this.btnUBAH.Location = new System.Drawing.Point(356, 153);
            this.btnUBAH.Margin = new System.Windows.Forms.Padding(2);
            this.btnUBAH.Name = "btnUBAH";
            this.btnUBAH.Size = new System.Drawing.Size(43, 23);
            this.btnUBAH.TabIndex = 11;
            this.btnUBAH.Text = "Ubah";
            this.btnUBAH.UseVisualStyleBackColor = true;
            this.btnUBAH.Click += new System.EventHandler(this.btnUBAH_Click);
            // 
            // btnHAPUS
            // 
            this.btnHAPUS.AutoSize = true;
            this.btnHAPUS.Location = new System.Drawing.Point(304, 153);
            this.btnHAPUS.Margin = new System.Windows.Forms.Padding(2);
            this.btnHAPUS.Name = "btnHAPUS";
            this.btnHAPUS.Size = new System.Drawing.Size(48, 23);
            this.btnHAPUS.TabIndex = 10;
            this.btnHAPUS.Text = "Hapus";
            this.btnHAPUS.UseVisualStyleBackColor = true;
            this.btnHAPUS.Click += new System.EventHandler(this.btnHAPUS_Click);
            // 
            // btnRST
            // 
            this.btnRST.AutoSize = true;
            this.btnRST.Location = new System.Drawing.Point(255, 153);
            this.btnRST.Margin = new System.Windows.Forms.Padding(2);
            this.btnRST.Name = "btnRST";
            this.btnRST.Size = new System.Drawing.Size(45, 23);
            this.btnRST.TabIndex = 9;
            this.btnRST.Text = "Reset";
            this.btnRST.UseVisualStyleBackColor = true;
            this.btnRST.Click += new System.EventHandler(this.btnRST_Click);
            // 
            // txtKET
            // 
            this.txtKET.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKET.Location = new System.Drawing.Point(78, 77);
            this.txtKET.Multiline = true;
            this.txtKET.Name = "txtKET";
            this.txtKET.Size = new System.Drawing.Size(377, 67);
            this.txtKET.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tanggal";
            // 
            // txtHEADER
            // 
            this.txtHEADER.AutoSize = true;
            this.txtHEADER.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHEADER.Location = new System.Drawing.Point(8, 5);
            this.txtHEADER.Name = "txtHEADER";
            this.txtHEADER.Size = new System.Drawing.Size(118, 25);
            this.txtHEADER.TabIndex = 1;
            this.txtHEADER.Text = "TANGGAL ";
            // 
            // dtpTgl
            // 
            this.dtpTgl.CustomFormat = "dddd, dd MMMM yyyy";
            this.dtpTgl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTgl.Location = new System.Drawing.Point(78, 51);
            this.dtpTgl.Name = "dtpTgl";
            this.dtpTgl.Size = new System.Drawing.Size(198, 20);
            this.dtpTgl.TabIndex = 0;
            // 
            // TANGGAL_MERAH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 365);
            this.Controls.Add(this.panel1);
            this.Name = "TANGGAL_MERAH";
            this.Text = "TANGGAL_MERAH";
            this.Load += new System.EventHandler(this.TANGGAL_MERAH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtKET;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtHEADER;
        private System.Windows.Forms.DateTimePicker dtpTgl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSIMPAN;
        private System.Windows.Forms.Button btnUBAH;
        private System.Windows.Forms.Button btnHAPUS;
        private System.Windows.Forms.Button btnRST;
        private System.Windows.Forms.Label label2;
    }
}