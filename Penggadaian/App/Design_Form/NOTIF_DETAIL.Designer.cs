namespace App.Design_Form
{
    partial class NOTIF_DETAIL
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFORM = new System.Windows.Forms.TextBox();
            this.txtKET = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtKET);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtFORM);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(309, 287);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM";
            // 
            // txtFORM
            // 
            this.txtFORM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFORM.Location = new System.Drawing.Point(8, 25);
            this.txtFORM.Name = "txtFORM";
            this.txtFORM.Size = new System.Drawing.Size(291, 20);
            this.txtFORM.TabIndex = 1;
            // 
            // txtKET
            // 
            this.txtKET.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKET.Location = new System.Drawing.Point(8, 66);
            this.txtKET.Multiline = true;
            this.txtKET.Name = "txtKET";
            this.txtKET.Size = new System.Drawing.Size(291, 208);
            this.txtKET.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "KETERANGAN";
            // 
            // NOTIF_DETAIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 309);
            this.Controls.Add(this.panel1);
            this.Name = "NOTIF_DETAIL";
            this.Text = "NOTIF_DETAIL";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtKET;
        public System.Windows.Forms.TextBox txtFORM;
    }
}