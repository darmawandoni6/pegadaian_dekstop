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
    public partial class DATA_GUDANG : Form
    {
        public DATA_GUDANG()
        {
            InitializeComponent();
        }
        // variavel 
        ArrayList vkode, vnama;
        string q;
        System.Data.SqlClient.SqlDataAdapter ad1,ad2;
        DataRow[] arr;
        //-----------------------------------------------------------------------------------

        private void dgv()
        {
            q = "SELECT dbo.Peminjaman.ID_TRANS AS [NO PEMINJAMAN], dbo.Peminjaman.TGL_PINJAM AS TANGGAL, dbo.NASABAH.NAMA AS [NAMA CUSTOMERS], dbo.GUDANG.JENIS, dbo.GUDANG.KODE AS [ID BARANG], dbo.GUDANG.MERK, dbo.GUDANG.TYPE, dbo.GUDANG.STATUS " +
                "FROM dbo.Peminjaman INNER JOIN dbo.NASABAH " +
                "ON dbo.Peminjaman.ID_NASABAH = dbo.NASABAH.ID INNER JOIN dbo.GUDANG " +
                "ON dbo.Peminjaman.ID_TRANS=dbo.GUDANG.ID_TRANS";
            if (global.ds.Tables["data1"] != null) global.ds.Tables["data1"].Clear();
            ad1 = new System.Data.SqlClient.SqlDataAdapter(q,global.con);
            ad1.Fill(global.ds, "data1");

            dataGridView1.DataSource = global.ds.Tables["data1"];
            
            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].DefaultCellStyle.Format = "dd-MM-yyyy";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            vkode = new ArrayList();
            vnama = new ArrayList();
            foreach (DataRow dr in global.ds.Tables["data1"].Rows)
            {
                vkode.Add(dr[4]);
                vnama.Add(dr[2]);
            }
            
        }

        private void spesifikasi()
        {
            q = "SELECT MERK,TYPE,PROCESSOR, HDD, RAM, VGA,KONDISI,KODE,WARNA FROM GUDANG";
            if (global.ds.Tables["data2"] != null) global.ds.Tables["data2"].Clear();
            ad2 = new System.Data.SqlClient.SqlDataAdapter(q, global.con);
            ad2.Fill(global.ds, "data2");
        }

        string validasi(string kode)
        {
            string spek = "";
            arr = global.ds.Tables["data2"].Select("KODE = '" + kode + "'");
            if (arr.Length != 0)
            {
                spek = "Jenis Laptop/Handphone  " + Environment.NewLine +
                        "Merk \t \t : " + arr[0][0].ToString() + Environment.NewLine +
                        "Tipe \t \t : " + arr[0][1].ToString() + Environment.NewLine +
                        "Processor \t : " + arr[0][2].ToString() + Environment.NewLine +
                        "HDD \t \t : " + arr[0][3].ToString() + Environment.NewLine +
                        "RAM \t \t : " + arr[0][4].ToString() + Environment.NewLine +
                        "VGA \t \t : " + arr[0][5].ToString() + Environment.NewLine +
                        "WARNA \t : " + arr[0][8].ToString() + Environment.NewLine +
                "KONDISI \t : " + Environment.NewLine + "   " + arr[0][6].ToString()+".";                
            }
            return spek;
        }
        private void DATA_GUDANG_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void DATA_GUDANG_Load(object sender, EventArgs e)
        {
            dgv();
            spesifikasi();
            AutoCompleteStringCollection col1 = new AutoCompleteStringCollection();
            AutoCompleteStringCollection col2 = new AutoCompleteStringCollection();
            for (int i = 0; i <= vkode.Count - 1; i++)
            {
                col1.Add(vkode[i].ToString());
                col2.Add(vnama[i].ToString());
            }
            txtKODE.AutoCompleteCustomSource = col1;
            txtKODE.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtNASABAH.AutoCompleteCustomSource = col2;
            txtNASABAH.AutoCompleteMode = AutoCompleteMode.Suggest;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dataGridView1.Rows.Count - 2)
            {
                txtKODE.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }


        private void txtKODE_TextChanged(object sender, EventArgs e)
        {
            if (txtKODE.Text != "")
            {
                arr = global.ds.Tables["data1"].Select("[ID BARANG] = '" + txtKODE.Text + "'");
                if (arr.Length != 0)
                {
                    txtNASABAH.Text = arr[0][2].ToString();
                    string nama_barang = arr[0][3].ToString();
                    string merk = arr[0][4].ToString();
                    txtBARANG.Text = nama_barang + " " + merk;
                    if (arr[0][7].ToString() == "DITEBUS")
                        cboSTATUS.SelectedIndex = 0;
                    else if (arr[0][7].ToString() == "GADAI")
                        cboSTATUS.SelectedIndex = 1;
                    else if (arr[0][7].ToString() == "LELANG")
                        cboSTATUS.SelectedIndex = 2;
                    txtSPEK.Text = validasi(txtKODE.Text);
                    
                }
                else
                {
                    txtBARANG.Clear();
                    txtNASABAH.Clear();
                    txtSPEK.Clear();
                    cboSTATUS.SelectedIndex = -1;
                }
            }
        }

        private void btnRESET_Click(object sender, EventArgs e)
        {
            txtKODE.Clear();
            txtBARANG.Clear();
            txtNASABAH.Clear();
            txtSPEK.Clear();
            txtKODE.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            global.sqltrans = global.con.BeginTransaction();
            try
            {
                global.val = new System.Collections.ArrayList();
                global.val.Add(txtKODE.Text);
                global.val.Add(cboSTATUS.SelectedItem);
                string q = "UPDATE GUDANG SET STATUS =@PARAM1 WHERE KODE=@PARAM0";
                global.query(q, global.val, false);
                global.sqltrans.Commit();
            }
            catch (Exception ex)
            {
                global.sqltrans.Rollback();
                MessageBox.Show(ex.Message + " ----FORM BARANG ----");
            }
            global.ds.Tables["data1"].Clear();
            ad1.Fill(global.ds, "data1");
        }
    }
}
