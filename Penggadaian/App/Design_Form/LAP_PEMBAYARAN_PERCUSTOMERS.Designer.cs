namespace App.Design_Form
{
    partial class LAP_PEMBAYARAN_PERCUSTOMERS
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CARI = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Count = new System.Windows.Forms.Label();
            this.TRANS = new System.Windows.Forms.TextBox();
            this.PREV = new System.Windows.Forms.Button();
            this.BROWSE = new System.Windows.Forms.Button();
            this.NEXT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NAMA = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(412, 135);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CARI);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.Count);
            this.groupBox2.Controls.Add(this.TRANS);
            this.groupBox2.Controls.Add(this.PREV);
            this.groupBox2.Controls.Add(this.BROWSE);
            this.groupBox2.Controls.Add(this.NEXT);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.NAMA);
            this.groupBox2.Location = new System.Drawing.Point(8, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 117);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lap. Pembayaran Percustomer";
            // 
            // CARI
            // 
            this.CARI.AutoSize = true;
            this.CARI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CARI.Location = new System.Drawing.Point(266, 75);
            this.CARI.Name = "CARI";
            this.CARI.Size = new System.Drawing.Size(57, 28);
            this.CARI.TabIndex = 12;
            this.CARI.Text = "Cari";
            this.CARI.UseVisualStyleBackColor = true;
            this.CARI.Click += new System.EventHandler(this.CARI_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(329, 75);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 28);
            this.button5.TabIndex = 7;
            this.button5.Text = "Cetak";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Count
            // 
            this.Count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Count.Location = new System.Drawing.Point(130, 75);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(44, 20);
            this.Count.TabIndex = 11;
            this.Count.Text = "1 - 1";
            this.Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TRANS
            // 
            this.TRANS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TRANS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TRANS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TRANS.Location = new System.Drawing.Point(90, 23);
            this.TRANS.Name = "TRANS";
            this.TRANS.Size = new System.Drawing.Size(233, 20);
            this.TRANS.TabIndex = 2;
            this.TRANS.Validated += new System.EventHandler(this.TRANS_Validated);
            // 
            // PREV
            // 
            this.PREV.Location = new System.Drawing.Point(90, 75);
            this.PREV.Name = "PREV";
            this.PREV.Size = new System.Drawing.Size(34, 20);
            this.PREV.TabIndex = 10;
            this.PREV.Text = "<";
            this.PREV.UseVisualStyleBackColor = true;
            this.PREV.Click += new System.EventHandler(this.PREV_Click);
            // 
            // BROWSE
            // 
            this.BROWSE.Location = new System.Drawing.Point(329, 23);
            this.BROWSE.Name = "BROWSE";
            this.BROWSE.Size = new System.Drawing.Size(25, 20);
            this.BROWSE.TabIndex = 3;
            this.BROWSE.Text = "...";
            this.BROWSE.UseVisualStyleBackColor = true;
            this.BROWSE.Click += new System.EventHandler(this.BROWSE_Click);
            // 
            // NEXT
            // 
            this.NEXT.Location = new System.Drawing.Point(180, 75);
            this.NEXT.Name = "NEXT";
            this.NEXT.Size = new System.Drawing.Size(34, 20);
            this.NEXT.TabIndex = 9;
            this.NEXT.Text = ">";
            this.NEXT.UseVisualStyleBackColor = true;
            this.NEXT.Click += new System.EventHandler(this.NEXT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "No. Transaksi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nama";
            // 
            // NAMA
            // 
            this.NAMA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NAMA.Location = new System.Drawing.Point(90, 49);
            this.NAMA.Name = "NAMA";
            this.NAMA.Size = new System.Drawing.Size(233, 20);
            this.NAMA.TabIndex = 7;
            // 
            // LAP_PEMBAYARAN_PERCUSTOMERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 155);
            this.Controls.Add(this.panel1);
            this.Name = "LAP_PEMBAYARAN_PERCUSTOMERS";
            this.Text = "LAPORAN";
            this.Load += new System.EventHandler(this.LAP_PEMBAYARAN_PERCUSTOMERS_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.TextBox TRANS;
        private System.Windows.Forms.Button PREV;
        private System.Windows.Forms.Button BROWSE;
        private System.Windows.Forms.Button NEXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NAMA;
        private System.Windows.Forms.Button CARI;
    }
}