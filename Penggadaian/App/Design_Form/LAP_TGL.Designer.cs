namespace App.Design_Form
{
    partial class LAP_TGL
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
            this.dtpTGL2 = new System.Windows.Forms.DateTimePicker();
            this.CETAK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTGL1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(242, 93);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpTGL2);
            this.groupBox1.Controls.Add(this.CETAK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpTGL1);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lap. Customer";
            // 
            // dtpTGL2
            // 
            this.dtpTGL2.CustomFormat = "dd-MM-yyyy";
            this.dtpTGL2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTGL2.Location = new System.Drawing.Point(62, 45);
            this.dtpTGL2.Name = "dtpTGL2";
            this.dtpTGL2.Size = new System.Drawing.Size(92, 20);
            this.dtpTGL2.TabIndex = 5;
            this.dtpTGL2.ValueChanged += new System.EventHandler(this.dtpTGL2_ValueChanged);
            // 
            // CETAK
            // 
            this.CETAK.AutoSize = true;
            this.CETAK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CETAK.Location = new System.Drawing.Point(160, 37);
            this.CETAK.Name = "CETAK";
            this.CETAK.Size = new System.Drawing.Size(57, 28);
            this.CETAK.TabIndex = 4;
            this.CETAK.Text = "Cetak";
            this.CETAK.UseVisualStyleBackColor = true;
            this.CETAK.Click += new System.EventHandler(this.CETAK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sampai :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dari :";
            // 
            // dtpTGL1
            // 
            this.dtpTGL1.CustomFormat = "dd-MM-yyyy";
            this.dtpTGL1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTGL1.Location = new System.Drawing.Point(62, 19);
            this.dtpTGL1.Name = "dtpTGL1";
            this.dtpTGL1.Size = new System.Drawing.Size(92, 20);
            this.dtpTGL1.TabIndex = 0;
            // 
            // LAP_TGL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 116);
            this.Controls.Add(this.panel1);
            this.Name = "LAP_TGL";
            this.Text = "LAPORAN";
            this.Load += new System.EventHandler(this.LAP_TGL_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpTGL2;
        private System.Windows.Forms.Button CETAK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTGL1;
    }
}