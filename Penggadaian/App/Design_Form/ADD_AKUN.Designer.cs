namespace App.Design_Form
{
    partial class ADD_AKUN
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
            this.DGV = new System.Windows.Forms.DataGridView();
            this.btnSIMPAN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radMASTER = new System.Windows.Forms.RadioButton();
            this.radADMIN = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPASS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNAMA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUNAME = new System.Windows.Forms.TextBox();
            this.btnGANTIPASS = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnGANTIPASS);
            this.panel1.Controls.Add(this.DGV);
            this.panel1.Controls.Add(this.btnSIMPAN);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.radMASTER);
            this.panel1.Controls.Add(this.radADMIN);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPASS);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNAMA);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtUNAME);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 381);
            this.panel1.TabIndex = 0;
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(8, 141);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(679, 235);
            this.DGV.TabIndex = 11;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // btnSIMPAN
            // 
            this.btnSIMPAN.Location = new System.Drawing.Point(64, 112);
            this.btnSIMPAN.Name = "btnSIMPAN";
            this.btnSIMPAN.Size = new System.Drawing.Size(75, 23);
            this.btnSIMPAN.TabIndex = 10;
            this.btnSIMPAN.Text = "Simpan";
            this.btnSIMPAN.UseVisualStyleBackColor = true;
            this.btnSIMPAN.Click += new System.EventHandler(this.btnSIMPAN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Status";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "OPEN",
            "LOCKED"});
            this.comboBox1.Location = new System.Drawing.Point(64, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // radMASTER
            // 
            this.radMASTER.AutoSize = true;
            this.radMASTER.Location = new System.Drawing.Point(255, 88);
            this.radMASTER.Name = "radMASTER";
            this.radMASTER.Size = new System.Drawing.Size(57, 17);
            this.radMASTER.TabIndex = 7;
            this.radMASTER.TabStop = true;
            this.radMASTER.Text = "Master";
            this.radMASTER.UseVisualStyleBackColor = true;
            this.radMASTER.CheckedChanged += new System.EventHandler(this.radMASTER_CheckedChanged);
            // 
            // radADMIN
            // 
            this.radADMIN.AutoSize = true;
            this.radADMIN.Location = new System.Drawing.Point(191, 88);
            this.radADMIN.Name = "radADMIN";
            this.radADMIN.Size = new System.Drawing.Size(54, 17);
            this.radADMIN.TabIndex = 6;
            this.radADMIN.TabStop = true;
            this.radADMIN.Text = "Admin";
            this.radADMIN.UseVisualStyleBackColor = true;
            this.radADMIN.CheckedChanged += new System.EventHandler(this.radADMIN_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // txtPASS
            // 
            this.txtPASS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPASS.Location = new System.Drawing.Point(64, 59);
            this.txtPASS.Name = "txtPASS";
            this.txtPASS.PasswordChar = '●';
            this.txtPASS.Size = new System.Drawing.Size(159, 20);
            this.txtPASS.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama ";
            // 
            // txtNAMA
            // 
            this.txtNAMA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNAMA.Location = new System.Drawing.Point(64, 33);
            this.txtNAMA.Name = "txtNAMA";
            this.txtNAMA.Size = new System.Drawing.Size(159, 20);
            this.txtNAMA.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // txtUNAME
            // 
            this.txtUNAME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUNAME.Location = new System.Drawing.Point(64, 7);
            this.txtUNAME.Name = "txtUNAME";
            this.txtUNAME.Size = new System.Drawing.Size(159, 20);
            this.txtUNAME.TabIndex = 0;
            // 
            // btnGANTIPASS
            // 
            this.btnGANTIPASS.Location = new System.Drawing.Point(229, 59);
            this.btnGANTIPASS.Name = "btnGANTIPASS";
            this.btnGANTIPASS.Size = new System.Drawing.Size(108, 20);
            this.btnGANTIPASS.TabIndex = 12;
            this.btnGANTIPASS.Text = "Ganti Password";
            this.btnGANTIPASS.UseVisualStyleBackColor = true;
            this.btnGANTIPASS.Click += new System.EventHandler(this.btnGANTIPASS_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(145, 112);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ADD_AKUN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 405);
            this.Controls.Add(this.panel1);
            this.Name = "ADD_AKUN";
            this.Text = "+ AKUN";
            this.Load += new System.EventHandler(this.ADD_AKUN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radMASTER;
        private System.Windows.Forms.RadioButton radADMIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPASS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNAMA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUNAME;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button btnSIMPAN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGANTIPASS;
        private System.Windows.Forms.Button btnReset;
    }
}