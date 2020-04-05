using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Design_Form
{
    public partial class NOTIF : Form
    {
        public NOTIF()
        {
            InitializeComponent();
        }
        string form, ket;
        private void NOTIF_Load(object sender, EventArgs e)
        {
            DGV.DataSource = global.notif_tbl;
            DGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (form != "" && ket != "")
            {
                NOTIF_DETAIL frm = new NOTIF_DETAIL();

                frm.txtFORM.Text = form;
                frm.txtKET.Text = ket;
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Pilih notif yg ingin dilihat detail nya");
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= DGV.Rows.Count - 2)
            {
                form = DGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                ket = DGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
    }
}
