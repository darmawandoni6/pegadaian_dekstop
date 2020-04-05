namespace App.Design_Form
{
    partial class GANTI_PASSWORD
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKonfirmasi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPASbaru = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPASlama = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKonfirmasi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPASbaru);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPASlama);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GANTI PASSWORD";
            // 
            // btnKonfirmasi
            // 
            this.btnKonfirmasi.Location = new System.Drawing.Point(257, 114);
            this.btnKonfirmasi.Name = "btnKonfirmasi";
            this.btnKonfirmasi.Size = new System.Drawing.Size(75, 23);
            this.btnKonfirmasi.TabIndex = 6;
            this.btnKonfirmasi.Text = "Konfirmasi";
            this.btnKonfirmasi.UseVisualStyleBackColor = true;
            this.btnKonfirmasi.Click += new System.EventHandler(this.btnKonfirmasi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password Baru";
            // 
            // txtPASbaru
            // 
            this.txtPASbaru.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPASbaru.Location = new System.Drawing.Point(102, 88);
            this.txtPASbaru.Name = "txtPASbaru";
            this.txtPASbaru.PasswordChar = '●';
            this.txtPASbaru.Size = new System.Drawing.Size(230, 20);
            this.txtPASbaru.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password Lama";
            // 
            // txtPASlama
            // 
            this.txtPASlama.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPASlama.Location = new System.Drawing.Point(102, 62);
            this.txtPASlama.Name = "txtPASlama";
            this.txtPASlama.PasswordChar = '●';
            this.txtPASlama.Size = new System.Drawing.Size(230, 20);
            this.txtPASlama.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.Location = new System.Drawing.Point(102, 36);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(230, 20);
            this.txtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(371, 176);
            this.panel1.TabIndex = 1;
            // 
            // GANTI_PASSWORD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 197);
            this.Controls.Add(this.panel1);
            this.Name = "GANTI_PASSWORD";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "GANTI_PASSWORD";
            this.Load += new System.EventHandler(this.GANTI_PASSWORD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPASlama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPASbaru;
        private System.Windows.Forms.Button btnKonfirmasi;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtID;
    }
}