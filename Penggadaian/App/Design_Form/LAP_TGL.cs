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
    public partial class LAP_TGL : Form
    {
        public LAP_TGL()
        {
            InitializeComponent();
        }
        private void LAP_TGL_Load(object sender, EventArgs e)
        {
            dtpTGL1.MaxDate = DateTime.Now;
            if (global.lap_name == "C")
            {
                groupBox1.Text = "Lap. Customers";
            }
            else if (global.lap_name == "P")
            {
                groupBox1.Text = "Lap. Pembayaran Perperiode";
            }
            else if (global.lap_name == "PM")
            {
                groupBox1.Text = "Lap. Peminjaman";
            }
            else if (global.lap_name == "PP")
            {
                groupBox1.Text = "Lap. Perpanjangan";
            }
        }
        private void CETAK_Click(object sender, EventArgs e)
        {
            if (global.lap_name == "C")
            {
                Laporan.Lap_Nasabah cr = new Laporan.Lap_Nasabah();
                cr.RecordSelectionFormula = "{Peminjaman.TGL_PINJAM} >=#" + dtpTGL1.Value.ToString("MM/dd/yyy") + "# and {Peminjaman.TGL_PINJAM} <=#" + dtpTGL2.Value.ToString("MM/dd/yyy") + "#";

                cr.DataDefinition.FormulaFields["tgl"].Text = "'Dari tanggal " + dtpTGL1.Value.ToString("dd-MMM-yyyy") + " Sampai tanggal " + dtpTGL2.Value.ToString("dd-MMM-yyyy") + "'";
                Laporan.CETAK frm = new Laporan.CETAK();
                frm.crystalReportViewer1.ReportSource = cr;
                frm.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
                frm.crystalReportViewer1.RefreshReport();
                frm.Show();
            }
            else if (global.lap_name == "P")
            {
                Laporan.Lap_Pembayaran_P cr = new Laporan.Lap_Pembayaran_P();
                cr.RecordSelectionFormula = "{PEMBAYARAN_D.TGL_PEMBAYARAN} >=#" + dtpTGL1.Value.ToString("MM/dd/yyy") + "# and {PEMBAYARAN_D.TGL_PEMBAYARAN} <=#" + dtpTGL2.Value.ToString("MM/dd/yyy") + "#";

                cr.DataDefinition.FormulaFields["tgl"].Text = "'Dari tanggal " + dtpTGL1.Value.ToString("dd-MMM-yyyy") + " Sampai tanggal " + dtpTGL2.Value.ToString("dd-MMM-yyyy") + "'";
                Laporan.CETAK frm = new Laporan.CETAK();
                frm.crystalReportViewer1.ReportSource = cr;
                frm.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
                frm.crystalReportViewer1.RefreshReport();
                frm.Show();
            }
            else if (global.lap_name == "PM")
            {
                Laporan.Lap_Peminjaman cr = new Laporan.Lap_Peminjaman();
                cr.RecordSelectionFormula = "{Peminjaman.TGL_PINJAM} >=#" + dtpTGL1.Value.ToString("MM/dd/yyy") + "# and {Peminjaman.TGL_PINJAM} <=#" + dtpTGL2.Value.ToString("MM/dd/yyy") + "#";

                cr.DataDefinition.FormulaFields["tgl"].Text = "'Dari tanggal " + dtpTGL1.Value.ToString("dd-MMM-yyyy") + " Sampai tanggal " + dtpTGL2.Value.ToString("dd-MMM-yyyy") + "'";
                Laporan.CETAK frm = new Laporan.CETAK();
                frm.crystalReportViewer1.ReportSource = cr;
                frm.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
                frm.crystalReportViewer1.RefreshReport();
                frm.Show();
            }
            else if (global.lap_name == "PP")
            {
                Laporan.Lap_Perpanjangan cr = new Laporan.Lap_Perpanjangan();
                cr.RecordSelectionFormula = "{Perpanjangan.JatuhTempoBaru} >=#" + dtpTGL1.Value.ToString("MM/dd/yyy") + "# and {Perpanjangan.JatuhTempoBaru} <=#" + dtpTGL2.Value.ToString("MM/dd/yyy") + "#";

                cr.DataDefinition.FormulaFields["tgl"].Text = "'Dari tanggal " + dtpTGL1.Value.ToString("dd-MMM-yyyy") + " Sampai tanggal " + dtpTGL2.Value.ToString("dd-MMM-yyyy") + "'";
                Laporan.CETAK frm = new Laporan.CETAK();
                frm.crystalReportViewer1.ReportSource = cr;
                frm.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
                frm.crystalReportViewer1.RefreshReport();
                frm.Show();
            }
            
        }

        private void dtpTGL2_ValueChanged(object sender, EventArgs e)
        {
            dtpTGL1.MaxDate = dtpTGL2.Value;
            
        }
    }
}
