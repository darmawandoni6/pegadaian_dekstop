namespace App.Design_Form
{
    partial class DATA_GUDANG
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSTATUS = new System.Windows.Forms.ComboBox();
            this.btnRESET = new System.Windows.Forms.Button();
            this.txtSPEK = new System.Windows.Forms.TextBox();
            this.txtBARANG = new System.Windows.Forms.TextBox();
            this.txtNASABAH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKODE = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(814, 421);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboSTATUS);
            this.groupBox1.Controls.Add(this.btnRESET);
            this.groupBox1.Controls.Add(this.txtSPEK);
            this.groupBox1.Controls.Add(this.txtBARANG);
            this.groupBox1.Controls.Add(this.txtNASABAH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKODE);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 185);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spesifikasi";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(479, 18);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Status";
            // 
            // cboSTATUS
            // 
            this.cboSTATUS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSTATUS.FormattingEnabled = true;
            this.cboSTATUS.Items.AddRange(new object[] {
            "DITEBUS",
            "GADAI",
            "LELANG"});
            this.cboSTATUS.Location = new System.Drawing.Point(352, 20);
            this.cboSTATUS.Name = "cboSTATUS";
            this.cboSTATUS.Size = new System.Drawing.Size(121, 21);
            this.cboSTATUS.TabIndex = 21;
            // 
            // btnRESET
            // 
            this.btnRESET.Location = new System.Drawing.Point(420, 151);
            this.btnRESET.Name = "btnRESET";
            this.btnRESET.Size = new System.Drawing.Size(75, 23);
            this.btnRESET.TabIndex = 20;
            this.btnRESET.Text = "Reset";
            this.btnRESET.UseVisualStyleBackColor = true;
            this.btnRESET.Click += new System.EventHandler(this.btnRESET_Click);
            // 
            // txtSPEK
            // 
            this.txtSPEK.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSPEK.Location = new System.Drawing.Point(100, 101);
            this.txtSPEK.Multiline = true;
            this.txtSPEK.Name = "txtSPEK";
            this.txtSPEK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSPEK.Size = new System.Drawing.Size(314, 73);
            this.txtSPEK.TabIndex = 19;
            // 
            // txtBARANG
            // 
            this.txtBARANG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBARANG.Location = new System.Drawing.Point(100, 74);
            this.txtBARANG.Name = "txtBARANG";
            this.txtBARANG.Size = new System.Drawing.Size(202, 21);
            this.txtBARANG.TabIndex = 18;
            // 
            // txtNASABAH
            // 
            this.txtNASABAH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNASABAH.Location = new System.Drawing.Point(100, 47);
            this.txtNASABAH.Name = "txtNASABAH";
            this.txtNASABAH.Size = new System.Drawing.Size(202, 21);
            this.txtNASABAH.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nasabah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Spesifikasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nama Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID Barang";
            // 
            // txtKODE
            // 
            this.txtKODE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKODE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKODE.Location = new System.Drawing.Point(100, 20);
            this.txtKODE.Name = "txtKODE";
            this.txtKODE.Size = new System.Drawing.Size(202, 21);
            this.txtKODE.TabIndex = 12;
            this.txtKODE.TextChanged += new System.EventHandler(this.txtKODE_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 204);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(786, 202);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // DATA_GUDANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 443);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DATA_GUDANG";
            this.Text = "DATA_GUDANG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DATA_GUDANG_FormClosing);
            this.Load += new System.EventHandler(this.DATA_GUDANG_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRESET;
        private System.Windows.Forms.TextBox txtSPEK;
        private System.Windows.Forms.TextBox txtBARANG;
        private System.Windows.Forms.TextBox txtNASABAH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKODE;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSTATUS;

    }
}