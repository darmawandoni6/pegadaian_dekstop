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
    public partial class GANTI_PASSWORD : Form
    {
        public GANTI_PASSWORD()
        {
            InitializeComponent();
        }

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

        private void GANTI_PASSWORD_Load(object sender, EventArgs e)
        {
            if (global.add_akun_ganti_pass == false)
                txtID.Text = global.login;
        }

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            if (global.add_akun_ganti_pass == false)
            {
                bool konfir = false;
                if (txtID.Text == global.login)
                {
                    string pas1 = enkripsi(txtPASlama.Text), pas2 = enkripsi(txtPASbaru.Text);
                    global.val = new System.Collections.ArrayList();
                    global.val.Add(global.login);
                    global.val.Add(pas1);

                    string q = "SELECT * FROM AKUN WHERE UNAME=@PARAM0 AND PASS=@PARAM1";
                    global.query(q, global.val, true);
                    if (global.rdr.Read())
                        konfir = true;
                    global.rdr.Close();
                    if (konfir == true)
                    {
                        global.sqltrans = global.con.BeginTransaction();
                        try
                        {
                            q = "UPDATE AKUN SET PASS=@PARAM0,INPUT_DT=@PARAM1 WHERE UNAME=@PARAM2 ";
                            global.val = new System.Collections.ArrayList();
                            global.val.Add(global.login);
                            global.val.Add(DateTime.Now);
                            global.val.Add(pas2);

                            global.query(q, global.val, false);
                            global.sqltrans.Commit();
                        }
                        catch (Exception ex)
                        {
                            global.sqltrans.Rollback();
                            MessageBox.Show(ex.Message);
                        }

                        konfir = false;
                    }
                }
                else
                    MessageBox.Show("ID tersebut tidak login");
            }
            else
            {
                global.data = txtPASbaru.Text;
                this.Close();
            }
        }
    }
}
