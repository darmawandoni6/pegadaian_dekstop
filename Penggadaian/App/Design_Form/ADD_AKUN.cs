using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace App.Design_Form
{
    public partial class ADD_AKUN : Form
    {
        public ADD_AKUN()
        {
            InitializeComponent();
        }
        MD5 md = MD5.Create();
        ArrayList uname = new ArrayList();
        string status, hak,q;
        bool simpan = true;
        string pass;        

        SqlDataAdapter ad;
        private void data()
        {
            if (global.ds.Tables["LIST"] != null) global.ds.Tables["LIST"].Clear();
            ad = new SqlDataAdapter("SELECT * FROM AKUN",global.con);
            ad.Fill(global.ds,"LIST");

            foreach (DataRow dr in global.ds.Tables["LIST"].Rows)
            {
                uname.Add(dr[0]);
            }

            DGV.DataSource = global.ds.Tables["LIST"];

            DGV.Columns[0].HeaderText = "USERNAME";
            DGV.Columns[1].HeaderText = "NAMA USER";
            DGV.Columns[2].HeaderText = "PASSWORD";
            DGV.Columns[3].HeaderText = "STATUS";
            DGV.Columns[4].HeaderText = "AKSES";
            DGV.Columns[5].HeaderText = "INPUT";
            DGV.Columns[6].HeaderText = "TGL_INPUT";

            DGV.Columns[6].DefaultCellStyle.Format = "dd-MM-yyyy";

            DGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DGV.Columns[1].Width = 200;
            DGV.Columns[2].Width = 150;
            DGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DGV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DGV.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DGV.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

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

        bool validasi_string()
        {
            if (txtUNAME.Text == "")
            {
                MessageBox.Show("Username harus diisi");
                txtNAMA.Focus();
                return false;
            }
            else
            {
                for (int i = 0; i <= DGV.Rows.Count - 2; i++)
                {
                    if (txtUNAME.Text == DGV.Rows[i].Cells[0].Value.ToString())
                    {
                        MessageBox.Show("Username sudah digunakan");
                        txtNAMA.Focus();
                        return false;
                    }
                }
            }

            if (txtNAMA.Text == "")
            {
                MessageBox.Show("Nama harus diisi");
                txtNAMA.Focus();
                return false;
            }
            if (txtPASS.Text == "")
            {
                MessageBox.Show("Password harus di isi dan harus lebih besar dari 6 karakter");
                txtPASS.Focus();
                return false;
            }
            else
            {
                if (txtPASS.Text.Trim().Length < 6)
                {
                    MessageBox.Show("Password harus lebih besar dari 6 karakter");
                    txtPASS.Focus();
                    return false;
                }
            }
            return true;
        }

        private void save_akun()
        {
            global.sqltrans = global.con.BeginTransaction();
            try
            {
                q = "INSERT INTO [dbo].[AKUN] VALUES (@PARAM0,@PARAM1,@PARAM2,@PARAM3,@PARAM4,@PARAM5,@PARAM6)";
                global.val = new ArrayList();
                global.val.Add(txtUNAME.Text.Trim());
                global.val.Add(txtNAMA.Text);
                global.val.Add(pass);
                global.val.Add(status);
                global.val.Add(hak);
                global.val.Add(global.login);
                global.val.Add(DateTime.Now);

                global.query(q, global.val, false);
                global.sqltrans.Commit();
            }
            catch (Exception ex)
            {
                global.sqltrans.Rollback();
                MessageBox.Show(ex.Message + " ------ FORM AKUN ------");
            }
        }
        private void update_akun()
        {
            global.sqltrans = global.con.BeginTransaction();
            try
            {
                q = "UPDATE [dbo].[AKUN] SET PASS =@PARAM0 WHERE UNAME=@PARAM1";
                global.val = new ArrayList();
                global.val.Add(pass);
                global.val.Add(txtUNAME.Text.Trim());
                global.query(q, global.val, false);
                global.sqltrans.Commit();
            }
            catch (Exception ex)
            {
                global.sqltrans.Rollback();
                MessageBox.Show(ex.Message + " ------ FORM AKUN ------");
            }
        }

        private void ADD_AKUN_Load(object sender, EventArgs e)
        {
            hak = "";
            status = "";
            data();
            comboBox1.SelectedIndex = 0;
            radADMIN.Checked = true;
        }

        private void btnSIMPAN_Click(object sender, EventArgs e)
        {
            if (validasi_string() == true)
            {
                pass = enkripsi(txtPASS.Text.Trim());
                if (simpan == true)
                {
                    save_akun();
                    simpan = false;
                }
                global.ds.Tables["LIST"].Clear();
                ad.Fill(global.ds, "LIST");
                MessageBox.Show("Akun berhasil ditambah");
                btnReset_Click(null, null);
            }
            else
            {
                if (simpan == false)
                {
                    update_akun();
                    global.ds.Tables["LIST"].Clear();
                    ad.Fill(global.ds, "LIST");

                    MessageBox.Show("Password berhasil di ubah");
                    btnReset_Click(null, null);
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) status = "O";
            else if (comboBox1.SelectedIndex == 1) status = "L";
        }

        private void radADMIN_CheckedChanged(object sender, EventArgs e)
        {
            if (radADMIN.Checked) hak = "A";
            else
                hak = "M";
        }

        private void radMASTER_CheckedChanged(object sender, EventArgs e)
        {
            if (radMASTER.Checked) hak = "M";
            else
                hak = "A";
        }

        private void btnGANTIPASS_Click(object sender, EventArgs e)
        {
            GANTI_PASSWORD frm = new GANTI_PASSWORD();
            frm.txtID.ReadOnly = true;
            frm.txtID.Text = txtUNAME.Text;
            global.add_akun_ganti_pass = true;
            frm.ShowDialog();
            pass = enkripsi(global.Ambil);
            txtPASS.Text = pass;
            simpan = false;

        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= DGV.Rows.Count - 2)
            {
                txtUNAME.Text = DGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNAMA.Text = DGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPASS.Text = DGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (DGV.Rows[e.RowIndex].Cells[3].Value.ToString() == "O")
                    comboBox1.SelectedIndex = 0;
                else
                    comboBox1.SelectedIndex = 1;
                if (DGV.Rows[e.RowIndex].Cells[4].Value.ToString() == "A")
                    radADMIN.Checked = true;
                else
                    radMASTER.Checked = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            simpan = true;
            txtNAMA.Clear();
            txtUNAME.Clear();
            txtPASS.Clear();
            txtUNAME.Focus();
        }
    }
}
