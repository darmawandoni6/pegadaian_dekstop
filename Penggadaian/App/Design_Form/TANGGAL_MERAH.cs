using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace App.Design_Form
{
    public partial class TANGGAL_MERAH : Form
    {
        public TANGGAL_MERAH()
        {
            InitializeComponent();
        }
        //variabel
        string header, tahun, query;
        CultureInfo culture = new CultureInfo("id-ID");
        bool save = true;
        System.Data.SqlClient.SqlDataAdapter ad;
        //---------------------------------------------------------

        private void tampil(string x)
        {
            query = "SELECT TANGGAL,KETERANGAN FROM TANGGAL_MERAH WHERE TAHUN ='" + x + "'";
            if (global.ds.Tables["LIST"] != null) global.ds.Tables["LIST"].Clear();
           ad = new System.Data.SqlClient.SqlDataAdapter(query, global.con);
            ad.Fill(global.ds, "LIST");
            dataGridView1.DataSource = global.ds.Tables["LIST"];
        }

        private void btn(bool status)
        {
            btnRST.Enabled = status;
            btnHAPUS.Enabled = status;
            btnUBAH.Enabled = status;
            btnSIMPAN.Enabled = !status;
        }
        private void proses()
        {
            global.sqltrans = global.con.BeginTransaction();
            try
            {
                global.val = new System.Collections.ArrayList();
                global.val.Add(tahun);
                global.val.Add(dtpTgl.Value);
                global.val.Add(txtKET.Text);

                query = "INSERT INTO TANGGAL_MERAH VALUES(@PARAM0,@PARAM1,@PARAM2)";
                global.query(query, global.val, false);
                global.sqltrans.Commit();

                global.ds.Tables["LIST"].Clear();
                ad.Fill(global.ds, "LIST");

                txtKET.Clear();
                save = true;
            }
            catch (Exception ex)
            {
                global.sqltrans.Rollback();
                MessageBox.Show(ex.Message);
            }
        }
        private void cek_tgl()
        {
            global.val = new System.Collections.ArrayList();
            global.val.Add(dtpTgl.Value.ToString("yyyy-MM-dd"));

            query = "SELECT COUNT(*) FROM TANGGAL_MERAH WHERE TANGGAL=@PARAM0";
            global.query(query, global.val, true);
            while (global.rdr.Read())
            {
                if (Convert.ToByte(global.rdr[0]) > 0)
                {
                    MessageBox.Show("Tanggal merah sudah diinput...");
                    save = false;
                }
            }
            global.rdr.Close();
        }

        private void TANGGAL_MERAH_Load(object sender, EventArgs e)
        {
            tahun = DateTime.Now.ToString("yyyy");
            header = "TANGGAL MERAH UNTUK TAHUN " + tahun;
            tampil(tahun);
            btn(false);
            btnRST.Enabled = true;
            dataGridView1.Columns[0].DefaultCellStyle.Format= "dd-MMM-yyyy";
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnRST_Click(object sender, EventArgs e)
        {
            btn(false);
            btnRST.Enabled = true;
            save = true;
            dtpTgl.Enabled = true;
            txtKET.Clear();
        }

        private void btnSIMPAN_Click(object sender, EventArgs e)
        {
            if (txtKET.Text != "")
            {
                cek_tgl();
                if (save == true)
                    proses();
            }
            else
            {
                MessageBox.Show("Keterangan tidak boleh kosong");
                txtKET.Focus();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dataGridView1.Rows.Count - 2)
            {
                dtpTgl.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                txtKET.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                btn(true);
                dtpTgl.Enabled = false;
            }
        }

        private void btnUBAH_Click(object sender, EventArgs e)
        {
            if (txtKET.Text != "")
            {
                global.sqltrans = global.con.BeginTransaction();
                try
                {
                    global.val = new System.Collections.ArrayList();
                    global.val.Add(txtKET.Text);
                    global.val.Add(dtpTgl.Value);
                    query = "UPDATE TANGGAL_MERAH SET KETERANGAN=@PARAM0 WHERE TANGGAL=@PARAM1";
                    global.query(query, global.val, false);

                    global.sqltrans.Commit();

                    global.ds.Tables["LIST"].Clear();
                    ad.Fill(global.ds, "LIST");
                    btnRST_Click(null, null);
                    MessageBox.Show("Tanggal berhasil di update...");
                    dtpTgl.Enabled = true;
                }
                catch (Exception ex)
                {
                    global.sqltrans.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Keterangan tidak boleh kosong");
                txtKET.Focus();
            }
        }

        private void btnHAPUS_Click(object sender, EventArgs e)
        {
            global.sqltrans = global.con.BeginTransaction();
            try
            {
                global.val = new System.Collections.ArrayList();
                global.val.Add(dtpTgl.Value);
                query = "DELETE TANGGAL_MERAH WHERE TANGGAL=@PARAM0";
                global.query(query, global.val, false);

                global.sqltrans.Commit();

                global.ds.Tables["LIST"].Clear();
                ad.Fill(global.ds, "LIST");
                btnRST_Click(null, null);
                dtpTgl.Enabled = true;
                MessageBox.Show("Tanggal berhasil dihapus...");
            }
            catch (Exception ex)
            {
                global.sqltrans.Rollback();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
