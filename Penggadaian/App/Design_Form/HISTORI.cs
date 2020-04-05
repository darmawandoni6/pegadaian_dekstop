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

namespace App.Design_Form
{
    public partial class HISTORI : Form
    {
        public HISTORI()
        {
            InitializeComponent();
        }
        SqlDataAdapter ad_perpanjangan, adpembayaran;
        string param_cetak,q;
        private void list()
        {
            if (global.ds.Tables["ad_perpanjangan"] != null) global.ds.Tables["ad_perpanjangan"].Clear();
            q = "SELECT NoUrut,KODE_TRANS,JatuhTempoLama,JatuhTempoBaru,Alasan FROM Perpanjangan";
            ad_perpanjangan = new SqlDataAdapter(q, global.con);
            ad_perpanjangan.Fill(global.ds, "ad_perpanjangan");

            if (global.ds.Tables["adpembayaran"] != null) global.ds.Tables["adpembayaran"].Clear();
            q = "SELECT ID_PEMBAYARAN,ID_PEMINJAMAN,TIPE_PEMBAYARAN,TGL_PEMBAYARAN,JLH_PEMBAYARAN from PEMBAYARAN_D";
            adpembayaran = new SqlDataAdapter(q, global.con);
            adpembayaran.Fill(global.ds, "adpembayaran");
        }

        private void properties()
        {
            if (cboJENIS.SelectedIndex == 0)
            {
                DGV.Columns[0].HeaderText = "No. Perpanjangan";
                DGV.Columns[1].HeaderText = "No. Transaksi";
                DGV.Columns[2].HeaderText = "Jatuh Tempo Lama";
                DGV.Columns[3].HeaderText = "Jatuh Tempo Baru";
                DGV.Columns[4].HeaderText = "Alasan";

                DGV.Columns[0].Width = 120;
                DGV.Columns[1].Width = 120;
                DGV.Columns[2].Width = 125;
                DGV.Columns[3].Width = 120;
                DGV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                DGV.Columns[2].DefaultCellStyle.Format = "dd-MMM-yyyy";
                DGV.Columns[3].DefaultCellStyle.Format = "dd-MMM-yyyy";
            }
            else if (cboJENIS.SelectedIndex == 1)
            {
                DGV.Columns[0].HeaderText = "No. Pembayaran";
                DGV.Columns[1].HeaderText = "No. Transaksi";
                DGV.Columns[2].HeaderText = "Tipe";
                DGV.Columns[3].HeaderText = "Tanggal";
                DGV.Columns[4].HeaderText = "Jumlah";

                DGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                DGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                DGV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                DGV.Columns[3].DefaultCellStyle.Format = "dd-MMM-yyyy";
                DGV.Columns[4].DefaultCellStyle.Format = "N0";
                DGV.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //DGV.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }
        private void HISTORI_Load(object sender, EventArgs e)
        {
            DGV.Rows.Clear();
            list();
        }

        private void cboJENIS_SelectedIndexChanged(object sender, EventArgs e)
        {
            //perpanjangan
            if (cboJENIS.SelectedIndex == 0)
            {
                DGV.DataSource = global.ds.Tables["ad_perpanjangan"];
            }
            else if (cboJENIS.SelectedIndex == 1)
            {
                DGV.DataSource = global.ds.Tables["adpembayaran"];
            }
            properties();
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= DGV.Rows.Count - 2)
            {
                if (param_cetak != "")
                {
                    param_cetak = DGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
            }
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            if (param_cetak != "")
            {
                if (cboJENIS.SelectedIndex == 0)
                {
                    Laporan.Kwitansi_perpanjangan cr = new Laporan.Kwitansi_perpanjangan();
                    cr.RecordSelectionFormula = "{Perpanjangan.NoUrut} ='" + param_cetak+ "'";

                    Laporan.CETAK frm = new Laporan.CETAK();
                    frm.crystalReportViewer1.ReportSource = cr;
                    frm.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
                    frm.crystalReportViewer1.RefreshReport();
                    frm.Show();
                }
                if (cboJENIS.SelectedIndex == 1)
                {
                    Laporan.Kwitansi_pembayaran cr = new Laporan.Kwitansi_pembayaran();
                    cr.RecordSelectionFormula = "{PEMBAYARAN_D.ID_PEMBAYARAN} ='" + param_cetak + "'";

                    Laporan.CETAK frm = new Laporan.CETAK();
                    frm.crystalReportViewer1.ReportSource = cr;
                    frm.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
                    frm.crystalReportViewer1.RefreshReport();
                    frm.Show();
                }
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (cboJENIS.SelectedIndex != -1)
            {
                if (textBox1.Text != "")
                {
                    if (cboJENIS.SelectedIndex == 0)
                        global.ds.Tables["ad_perpanjangan"].DefaultView.RowFilter = "NoUrut LIKE '%" + textBox1.Text + "%' OR KODE_TRANS LIKE '%" + textBox1.Text + "%'";
                    else if (cboJENIS.SelectedIndex == 1)
                        global.ds.Tables["adpembayaran"].DefaultView.RowFilter = "ID_PEMBAYARAN LIKE '%" + textBox1.Text + "%' OR ID_PEMINJAMAN LIKE '%" + textBox1.Text + "%' OR TIPE_PEMBAYARAN LIKE '%" + textBox1.Text + "%'";
                }
                else
                {
                    if (cboJENIS.SelectedIndex == 0)
                        global.ds.Tables["ad_perpanjangan"].DefaultView.RowFilter = "NoUrut LIKE '%'";
                    else if (cboJENIS.SelectedIndex == 1)
                        global.ds.Tables["adpembayaran"].DefaultView.RowFilter = "ID_PEMBAYARAN LIKE '%'";
                }
            }
        }
    }
}
