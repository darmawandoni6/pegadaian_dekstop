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
    public partial class List_Peminjaman : Form
    {
        public List_Peminjaman()
        {
            InitializeComponent();
        }

        SqlDataAdapter ad;
        string param = "";

        private void List_Peminjaman_Load(object sender, EventArgs e)
        {
            if (global.ds.Tables["LIST"] != null) global.ds.Tables["LIST"].Clear();
            ad = new SqlDataAdapter("SELECT * FROM tbl_Data_Peminjaman", global.con);
            ad.Fill(global.ds, "LIST");

            dataGridView1.DataSource = global.ds.Tables["LIST"];

            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].DefaultCellStyle.Format = "dd-MM-yyyy";
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].DefaultCellStyle.Format = "dd-MM-yyyy";
            dataGridView1.Columns[6].Width = 120;

            
        }

        private void btnCARI_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                global.ds.Tables["LIST"].DefaultView.RowFilter = "[ID PEMINJAMAN] like '%'";
            else
                global.ds.Tables["LIST"].DefaultView.RowFilter = "[ID PEMINJAMAN] like '%" + textBox1.Text + "%' OR KTP LIKE '%" + textBox1.Text + "%' OR [NAMA CUSTOMERS] LIKE '%" + textBox1.Text + "%'" ;
        }

        private void btnCETAK_Click(object sender, EventArgs e)
        {
            if (param == "")
                MessageBox.Show("Pilih data yang ingin di cetak ...");
            else
            {
                Laporan.kontrak cr = new Laporan.kontrak();
                cr.RecordSelectionFormula = "{Peminjaman.ID_TRANS}='" + param + "'";

                Laporan.CETAK frm = new Laporan.CETAK();
                frm.crystalReportViewer1.ReportSource = cr;
                frm.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
                frm.crystalReportViewer1.RefreshReport();
                frm.ShowDialog();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dataGridView1.Rows.Count - 2)
            {
                param = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
    }
}
