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
    public partial class LOGIN_HISTORI : Form
    {
        public LOGIN_HISTORI()
        {
            InitializeComponent();
        }
        SqlDataAdapter ad;
        private void LOGIN_HISTORI_Load(object sender, EventArgs e)
        {
            string q = "select * from [dbo].[AKUN_H] ORDER BY NO DESC";
            if (global.ds.Tables["data"] != null) global.ds.Tables["data"].Clear();
            ad = new SqlDataAdapter(q, global.con);
            ad.Fill(global.ds, "data");

            DGV.DataSource = global.ds.Tables["data"];

            DGV.Columns[0].HeaderText = "No";
            DGV.Columns[1].HeaderText = "Username";
            DGV.Columns[2].HeaderText = "Login";
            DGV.Columns[3].HeaderText = "Logout";

            DGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DGV.Columns[2].DefaultCellStyle.Format = "dd-MMM-yyyy  HH:mm:ss";
            DGV.Columns[3].DefaultCellStyle.Format = "dd-MMM-yyyy  HH:mm:ss";
        }
    }
}
