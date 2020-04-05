using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace App.Design_Form
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        string query;
        
        bool open;
        MD5 md = MD5.Create();
        string enkripsi(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bytes = md5.ComputeHash(new UTF8Encoding().GetBytes(input));
            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
        private void LOGIN_Load(object sender, EventArgs e)
        {
            global.buatkoneksi();
            //txtPASS.PasswordChar = "●";
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string pas = enkripsi(txtPASS.Text);
            query = "SELECT * FROM AKUN WHERE UNAME=@PARAM0 AND PASS=@PARAM1";
            global.val = new System.Collections.ArrayList();
            global.val.Add(txtID.Text);
            global.val.Add(pas);

            global.query(query, global.val, true);

            if (global.rdr.Read())
            {
                if (global.rdr[3].ToString() == "O")
                {
                    if (global.rdr[4].ToString() == "M")
                        global.master = true;
                    else
                        global.master = false;
                    global.login = global.rdr[0].ToString();
                    open = true;
                }
                else
                    MessageBox.Show("Akun ini sudah di kunci.");
            }
            else
            {
                MessageBox.Show("ID dan password salah... ");
                txtPASS.Clear();
                txtPASS.Focus();
            }
            global.rdr.Close();
            if (open == true)
            {
                open = false;
                global.sqltrans = global.con.BeginTransaction();
                try
                {
                    global.val = new System.Collections.ArrayList();
                    global.val.Add(txtID.Text);
                    global.val.Add(DateTime.Now);

                    query = "INSERT INTO [dbo].[AKUN_H]([UNAME],[LOGIN_DATE]) VALUES (@PARAM0,@PARAM1) ";
                    global.query(query, global.val, false);

                    global.sqltrans.Commit();
                    FrmUtama frm = new FrmUtama();
                    frm.Show();
                }
                catch (Exception ex)
                {
                    global.sqltrans.Rollback();
                    MessageBox.Show(ex.Message + " -----FORM LOGIN-----");
                }
                this.Hide();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtID.Clear();
            txtPASS.Clear();
            txtID.Focus();
        }

        private void LOGIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
