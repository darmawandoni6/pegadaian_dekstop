using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace App
{
    public partial class PENCARIAN : Form
    {
        public PENCARIAN()
        {
            InitializeComponent();
        }

        byte no;
        string query;
        SqlDataAdapter ad;
        DataSet ds;
        private void format()
        {
            if (no == 2)
            {
                dataGridView1.Columns[1].DefaultCellStyle.Format = "dd-MM-yyyy";
                dataGridView1.Columns[6].DefaultCellStyle.Format = "dd-MM-yyyy";
                dataGridView1.Columns[5].DefaultCellStyle.Format = "N0";
            }
            else
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void PENCARIAN_Load(object sender, EventArgs e)
        {
            no = 0;
            if (global.VDATA_NASABAH == true)
            {
                query = "SELECT ID,KTP,NAMA,ALAMAT,TELP,JENIS_ID FROM NASABAH";
                global.VDATA_NASABAH = false;
                no = 1;
            }
            else if (global.DATA_PEMBAYARAN == true)
            {
                query = "select * from tbl_Data_Peminjaman";
                global.DATA_PEMBAYARAN = false;
                no = 2;
            }
            else if (global.LAP_PEMBAYARAN == true)
            {
                query = "SELECT dbo.Peminjaman.ID_TRANS AS [ID PEMINJAMAN], dbo.Peminjaman.TGL_PINJAM AS TANGGAL, dbo.NASABAH.KTP, dbo.NASABAH.NAMA AS [NAMA CUSTOMERS], dbo.NASABAH.ALAMAT, " +
                        "dbo.Peminjaman.TOTAL AS PINJAMAN, dbo.Peminjaman.JATUH_TEMPO AS [JATUH TEMPO] " +
                        "FROM dbo.NASABAH INNER JOIN dbo.Peminjaman ON dbo.NASABAH.ID = dbo.Peminjaman.ID_NASABAH";
                global.LAP_PEMBAYARAN = false;
                no = 3;
            }
            else if (global.Data_perpanjangan == true)
            {
                global.Data_perpanjangan = false;
                query = "SELECT p.ID_TRANS, n.KTP,n.NAMA,p.TGL_PINJAM,p.JATUH_TEMPO, p.TOTAL "+
                        "FROM Peminjaman as p inner join NASABAH as n "+
                        "on p.ID_NASABAH = n.ID "+
                        "where DATEDIFF(day, getdate(), ISNULL(JATUH_TEMPO, getdate())) < 0 "+
                        "and p.STATUS = 'AKTIF'";
                no = 4;
            }
            ds = new DataSet();
            if (ds.Tables["Data"] != null) ds.Tables["Data"].Clear();
            ad = new SqlDataAdapter(query, global.con);
            ad.Fill(ds, "Data");
            dataGridView1.DataSource = ds.Tables["Data"];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filter1 = "", filter2 = "";
            if (no == 1)
            {
                filter1 = "KTP like '%" + textBox1.Text + "%' or Nama like '%" + textBox1.Text + "%'";
                filter2 = "KTP like '%'";
            }
            else if (no == 2)
            {
                filter1 = "[ID PEMINJAMAN] like '%" + textBox1.Text + "%' or [NAMA CUSTOMERS] like '%" + textBox1.Text + "%' or KTP like '%" + textBox1.Text + "%'";
                filter2 = "[ID PEMINJAMAN] like '%'";
            }
            else if (no == 3)
            {
                filter1 = "[ID PEMINJAMAN] like '%" + textBox1.Text + "%' or [NAMA CUSTOMERS] like '%" + textBox1.Text + "%' or KTP like '%" + textBox1.Text + "%'";
                filter2 = "[ID PEMINJAMAN] like '%'";
            }

            if (textBox1.Text != "")
                ds.Tables["Data"].DefaultView.RowFilter = filter1;
            else
                ds.Tables["Data"].DefaultView.RowFilter = filter2;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dataGridView1.Rows.Count - 2)
            {
                if (no == 1)
                    global.data = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                else
                    global.data = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.Close();
            }
        }
    }
}
