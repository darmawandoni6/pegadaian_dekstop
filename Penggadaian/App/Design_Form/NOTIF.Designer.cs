namespace App.Design_Form
{
    partial class NOTIF
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
            this.NOTIFIKASI = new System.Windows.Forms.GroupBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.NOTIFIKASI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.NOTIFIKASI);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(664, 246);
            this.panel1.TabIndex = 0;
            // 
            // NOTIFIKASI
            // 
            this.NOTIFIKASI.Controls.Add(this.button1);
            this.NOTIFIKASI.Controls.Add(this.DGV);
            this.NOTIFIKASI.Location = new System.Drawing.Point(8, 8);
            this.NOTIFIKASI.Name = "NOTIFIKASI";
            this.NOTIFIKASI.Padding = new System.Windows.Forms.Padding(5);
            this.NOTIFIKASI.Size = new System.Drawing.Size(646, 228);
            this.NOTIFIKASI.TabIndex = 0;
            this.NOTIFIKASI.TabStop = false;
            this.NOTIFIKASI.Text = "NOTIFIKASI";
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(5, 50);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.Size = new System.Drawing.Size(636, 173);
            this.DGV.TabIndex = 0;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(566, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tampilkan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NOTIF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 270);
            this.Controls.Add(this.panel1);
            this.Name = "NOTIF";
            this.Text = "NOTIF";
            this.Load += new System.EventHandler(this.NOTIF_Load);
            this.panel1.ResumeLayout(false);
            this.NOTIFIKASI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox NOTIFIKASI;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button button1;
    }
}