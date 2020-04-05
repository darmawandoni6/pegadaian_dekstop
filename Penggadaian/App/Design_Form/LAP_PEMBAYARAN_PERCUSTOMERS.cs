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
    public partial class LAP_PEMBAYARAN_PERCUSTOMERS : Form
    {
        public LAP_PEMBAYARAN_PERCUSTOMERS()
        {
            InitializeComponent();
        }
        string q;
        System.Data.SqlClient.SqlDataAdapter ad;
        DataRow[] arr;
        AutoCompleteStringCollection col;
        ArrayList vtrans = new ArrayList();
        int row = 0, urut = 0;
        private void list()
        {
            q = "select A.ID_TRANS ,B.NAMA " +
                "from Peminjaman AS A INNER JOIN NASABAH B " +
                "ON A.ID_NASABAH=B.ID ";
            if (global.ds.Tables["LIST"] != null) global.ds.Tables["LIST"].Clear();
            ad = new System.Data.SqlClient.SqlDataAdapter(q, global.con);
            ad.Fill(global.ds, "LIST");
                        
            foreach (DataRow dr in global.ds.Tables["LIST"].Rows)
            {
                vtrans.Add(dr[0]);
            }
        }

        string pencarian(string cari)
        {
            arr = global.ds.Tables["LIST"].Select("ID_TRANS ='"+cari+"'");
            if (arr.Length != 0)
            {
                return arr[0][1].ToString();
            }
            return null;
        }

        private void LAP_PEMBAYARAN_PERCUSTOMERS_Load(object sender, EventArgs e)
        {
            list();

            col = new AutoCompleteStringCollection();
            for (int i = 0; i <= vtrans.Count - 1; i++)
            {
                col.Add(vtrans[i].ToString());
            }
            TRANS.AutoCompleteCustomSource = col;
            Count.Text = "0 - 0";
        }

        private void BROWSE_Click(object sender, EventArgs e)
        {
            global.LAP_PEMBAYARAN = true;
            PENCARIAN frm = new PENCARIAN();
            frm.ShowDialog();
            TRANS.Text = global.Ambil;
            TRANS.Focus();
            NAMA.Focus();
            row = 0;
            urut = 0;
            Count.Text = "1 - 1";
        }

        private void TRANS_Validated(object sender, EventArgs e)
        {
            if (TRANS.Text != "")
            {
                NAMA.Text = pencarian(TRANS.Text);
                TRANS.Focus();
                button5.Focus();
            }
        }

        private void CARI_Click(object sender, EventArgs e)
        {
                if (NAMA.Text == "")
                    global.ds.Tables["LIST"].DefaultView.RowFilter = "NAMA like '%'";
                else
                    global.ds.Tables["LIST"].DefaultView.RowFilter = "NAMA like '%" + NAMA.Text + "%'";
            row = global.ds.Tables["LIST"].DefaultView.Count;
            if (row > 0)
            {
                TRANS.Text = global.ds.Tables["LIST"].DefaultView[0][0].ToString();
                TRANS.Focus();
                NAMA.Focus();
                Count.Text = "1 - " + row.ToString();
            }
            else
                MessageBox.Show("Data tidak ditemukan");
        }
        //////string next_prev(string kode)
        //////{
        //////    for (int i = 0; i <= row - 1; i++)
        //////    {
        //////        TRANS.Text = global.ds.Tables["LIST"].DefaultView[i][0].ToString();
        //////    }
        //////    TRANS.Focus();
        //////    NAMA.Focus();
        //////}
        private void NEXT_Click(object sender, EventArgs e)
        {
            if (urut < row-1)
            {
                urut++;
                TRANS.Text = global.ds.Tables["LIST"].DefaultView[urut][0].ToString();
                TRANS.Focus();
                NAMA.Focus();
                Count.Text = (urut+1).ToString() + " - " + row.ToString();
            }
        }

        private void PREV_Click(object sender, EventArgs e)
        {
            if (urut > 0)
            {
                urut--;
                TRANS.Text = global.ds.Tables["LIST"].DefaultView[urut][0].ToString();
                TRANS.Focus();
                NAMA.Focus();
                Count.Text = (urut + 1).ToString() + " - " + row.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (TRANS.Text != "")
            {
                string q = "SELECT COUNT(*) FROM PEMBAYARAN_H WHERE ID_PEMINJAMAN =@PARAM0";
                global.val = new ArrayList();
                global.val.Add(TRANS.Text);
                global.query(q, global.val, true);
                if (global.rdr.Read())
                {
                    if (Convert.ToByte(global.rdr[0]) > 0)
                    {
                        Laporan.Lap_Pembayaran_C cr = new Laporan.Lap_Pembayaran_C();
                        cr.RecordSelectionFormula = "{Peminjaman.ID_TRANS} ='" + TRANS.Text + "'";
                        Laporan.CETAK frm = new Laporan.CETAK();
                        frm.crystalReportViewer1.ReportSource = cr;
                        frm.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
                        frm.crystalReportViewer1.RefreshReport();
                        frm.Show();
                    }
                    else
                        MessageBox.Show("Customer dengan nomor transaksi " + TRANS.Text + "\n Belum pernah melakukan pembayaran");
                }
                global.rdr.Close();
            }
        }
    }
}
