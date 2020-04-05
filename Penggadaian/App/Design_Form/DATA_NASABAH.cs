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

namespace App.Design_Form
{
    public partial class DATA_NASABAH : Form
    {
        
        string kode_nasabah,query;
        bool simpan = true;
        System.Data.SqlClient.SqlDataAdapter view_Nasabah;
        
        private void reset()
        {
            foreach (Control kap in panel1.Controls)
            {
                if (kap is TextBox)
                {
                    TextBox txt = (TextBox)kap;
                    txt.Text.ToUpper();
                    txt.Clear();
                }
            }
            txtKTP.Focus();
        }
        private void btn(bool stat)
        {
            btnRST.Enabled = stat;
            btnHAPUS.Enabled = !stat;
            btnUBAH.Enabled = !stat;
        }

        private void tpl_pencarian()
        {
            ArrayList value = new ArrayList();
            value.Add(kode_nasabah);
            value.Add(txtKTP.Text);
            query = "SELECT * FROM tbl_Data_nasabah WHERE ID =@PARAM0 or KTP =@PARAM1";
            global.query(query, value, true);
            while (global.rdr.Read())
            {
                txtID.Text = global.rdr[0].ToString();
                txtKTP.Text = global.rdr[1].ToString();
                txtNASABAH.Text = global.rdr[2].ToString();
                txtALAMAT.Text = global.rdr[3].ToString();
                txtTELPON.Text = global.rdr[4].ToString();
                txtTGL.Text = global.rdr[5].ToString();
                if (global.rdr[6].ToString() != "")
                {
                    DateTime tgl = DateTime.Now;
                    if (global.rdr[5].ToString() != "")
                    {
                        tgl = Convert.ToDateTime(global.rdr[5]);
                        txtTGL.Text = tgl.ToString("dd-MMM-yyyy");
                    } 
                }
                txtKTP.ReadOnly = true;
                btn(false);
                btnRST.Enabled = true;
            }
            global.rdr.Close();
        }
        //----------------------------------------------------------------------------------
        //Function--------------------------------------------------------------------------
        bool lengkap()
        {
            foreach (Control txt in panel1.Controls)
            {
                if (txt is TextBox )
                {
                    if (txt.Text == "")
                    {
                        if (txt.Name != "txtID" )
                        {
                            if (txt.Name != "txtTGL")
                            {
                                txt.Focus();
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }
        //----------------------------------------------------------------------------------
        public DATA_NASABAH()
        {
            InitializeComponent();
        }

        private void DATA_NASABAH_FormClosing(object sender, FormClosingEventArgs e)
        {
            global.DATA_NASABAH = false;
        }

        private void DATA_NASABAH_Load(object sender, EventArgs e)
        {
            btn(true);
            reset();

            if (global.ds.Tables["view_Nasabah"] != null) global.ds.Tables["view_Nasabah"].Clear();
            view_Nasabah = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tbl_Data_nasabah", global.con);
            view_Nasabah.Fill(global.ds, "view_Nasabah");

            dgvTAMPIL.DataSource = global.ds.Tables["view_Nasabah"];
        }

        private void btnRST_Click(object sender, EventArgs e)
        {
            reset();
            txtKTP.Clear();
            btn(true);
            txtKTP.ReadOnly = false;
        }

        private void txtKTP_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnUBAH_Click(object sender, EventArgs e)
        {
            if (lengkap() == true && txtKTP.MaskCompleted)
            {
                global.sqltrans = global.con.BeginTransaction();
                try
                {
                    ArrayList val = new ArrayList();
                    val.Add(txtNASABAH.Text);
                    val.Add(txtALAMAT.Text);
                    val.Add(txtTELPON.Text);
                    val.Add(global.login);
                    val.Add(DateTime.Now);
                    val.Add(txtID.Text);

                    query = "UPDATE [dbo].[NASABAH] SET NAMA=@PARAM0,ALAMAT=@PARAM1,TELP=@PARAM2,UPDATE_DATA=@PARAM3,DATE_UPDATE=@PARAM4 WHERE ID=@PARAM5";
                    global.query(query, val, false);
                    global.sqltrans.Commit();

                    global.ds.Tables["view_Nasabah"].Clear();
                    view_Nasabah.Fill(global.ds, "view_Nasabah");

                    MessageBox.Show("Data nasabah berhasil diubah.");
                    txtID.Clear();
                    txtKTP.Clear();
                    txtKTP.ReadOnly = false;
                    btn(true);
                    btnRST_Click(null, null);
                }
                catch (Exception ex)
                {
                    global.sqltrans.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Data wajib diisi semua.");
        }

        private void txtCARI_TextChanged(object sender, EventArgs e)
        {
            if (txtCARI.Text != "")
                global.ds.Tables["view_Nasabah"].DefaultView.RowFilter = "KTP like '%" + txtCARI.Text + "%' or Nama like '%" + txtCARI.Text + "%'";
            else
                global.ds.Tables["view_Nasabah"].DefaultView.RowFilter = "KTP like '%'";
        }

        private void btnHAPUS_Click(object sender, EventArgs e)
        {
            if (txtKTP.Text != "")
            {
                global.sqltrans = global.con.BeginTransaction();
                try
                {
                    if (MessageBox.Show("Delete No. KTP " + txtKTP.Text + " ?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ArrayList value = new ArrayList();
                        value.Add(txtKTP.Text);
                        query = "DELETE NASABAH WHERE KTP=@PARAM0";
                        global.query(query, value, false);

                        global.sqltrans.Commit();

                        global.ds.Tables["view_Nasabah"].Clear();
                        view_Nasabah.Fill(global.ds, "view_Nasabah");

                        txtKTP.ReadOnly = false;
                        btn(true);
                        btnRST_Click(null, null);
                        MessageBox.Show("Data nasabah berhasil dihapus.");
                    }
                }
                catch
                {
                    global.sqltrans.Rollback();
                    MessageBox.Show("Data gagal dihapus");
                }
            }
        }

        private void dgvTAMPIL_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dgvTAMPIL.Rows.Count - 2)
            {
                txtID.Text = dgvTAMPIL.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtKTP.Text = dgvTAMPIL.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtKTP.Focus();
                txtNASABAH.Focus();
            }
        }

        private void txtKTP_MouseClick(object sender, MouseEventArgs e)
        {
            string x = txtKTP.Text;
            if (x.Trim().Length == 0)
                txtKTP.Select(0, 0);
        }

        private void VALIDASI(object sender, EventArgs e)
        {
            if (txtKTP.MaskCompleted || txtID.Text != "") tpl_pencarian();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

    }
}
