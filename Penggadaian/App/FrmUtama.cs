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

namespace App
{
    public partial class FrmUtama : Form
    {
        public FrmUtama()
        {
            InitializeComponent();
            //global.frmutama = new FrmUtama();
        }
        string  no;
        DateTime dt1;
        CultureInfo culture = new CultureInfo("id-ID");
        bool open;

        private void h_login()
        {
            string qq = "SELECT * FROM [dbo].[AKUN_H] WHERE UNAME=@PARAM0 ORDER BY NO DESC";
            global.val = new System.Collections.ArrayList();
            global.val.Add(global.login);
            global.query(qq, global.val, true);
            if (global.rdr.Read())
            {
                no = global.rdr[0].ToString();
            }
            global.rdr.Close();

            global.sqltrans = global.con.BeginTransaction();
            try
            {
                string q = "UPDATE [dbo].[AKUN_H] SET LOGOF_DATE = @PARAM0 WHERE UNAME=@PARAM1 AND NO=@PARAM2";
                global.val = new System.Collections.ArrayList();
                global.val.Add(DateTime.Now);
                global.val.Add(global.login);
                global.val.Add(no);
                global.query(q, global.val, false);
                global.sqltrans.Commit();
            }
            catch (Exception ex)
            {
                global.sqltrans.Rollback();
                MessageBox.Show(ex.Message);
            }
        }

        bool IsFormSudahDibuka(string vform)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FrmUtama")
                    continue;
                else if (f.Name == "LOGIN")
                    continue;
                else if (f.Name == "LAP_TGL")
                {
                    if (vform == global.lap_name)
                        return false;   
                }
                else if (f.Name == vform)
                {
                    f.Focus();
                    return false;
                }
            }
            return true;
        }

        private void notifikasi()
        {
            TimeSpan ts = new TimeSpan();
            global.notifikasi();
            string query = "";

            //dateline
            string jt = "";
            query = "select * from tbl_Data_Peminjaman_perpanjangan";
            global.cmd = new System.Data.SqlClient.SqlCommand(query, global.con);
            global.rdr = global.cmd.ExecuteReader();
            while (global.rdr.Read())
            {
                if (global.rdr[4].ToString() == "")
                {
                    dt1 = Convert.ToDateTime(global.rdr[3]);
                    ts = dt1.Subtract(DateTime.Now);
                    if (ts.Days > 0 && ts.Days <= 3)
                        jt = " DEADLINE "+ts.Days.ToString() + " Hari";
                    else if( ts.Days <= -20 )
                        jt = " DEADLINE SUDAH LEWAT " +(ts.Days * -1 ).ToString() + " HARI DAN HARUS DIUPDATE DENGAN STATUS LELANG";
                    else if(ts.Days > -20 && ts.Days <= 0)
                        jt = " DEADLINE SUDAH LEWAT " + (ts.Days * -1).ToString() + " HARI.";
                }
                else
                {
                    dt1 = Convert.ToDateTime(global.rdr[4]);
                    ts = dt1.Subtract(DateTime.Now);
                    if (ts.Days > 0 && ts.Days <= 3)
                        jt = ts.Days.ToString() + " Hari";
                    else if (ts.Days <= -20)
                        jt = " DATELINE SUDAH LEWAT " + (ts.Days * -1).ToString() + " HARI DAN BARANG SUDAH DI UPDATE DENGAN STATUS LELANG";
                    else if (ts.Days > -20 && ts.Days <= 0)
                        jt = " DEADLINE SUDAH LEWAT " + (ts.Days * -1).ToString() + " HARI.";

                }
                if (jt != "")
                {
                    global.notif_record = global.notif_tbl.NewRow();
                    global.notif_record[0] = "PEMBAYARAN";
                    global.notif_record[1] = "NO. TRANSAKSI " + global.rdr[0].ToString() + " DENGAN NAMA CUSTOMER " + global.rdr[1].ToString() + jt;
                    global.notif_tbl.Rows.Add(global.notif_record);
                }
                jt = "";
            }
            global.rdr.Close();

            //update status lelang
            //if (ts.Days < 0) update_status_barang();

        }

        public void FrmUtama_Load(object sender, EventArgs e)
        {
            //addAkunToolStripMenuItem
            
            try
            {
                global.buatkoneksi();
                if (global.master == true)
                {
                    addAkunToolStripMenuItem.Visible = true;
                    historiLoginToolStripMenuItem.Visible = true;
                }
                else
                {
                    addAkunToolStripMenuItem.Visible = false;
                    historiLoginToolStripMenuItem.Visible = false;
                }
                status_login.Text = global.login;
                notifikasi();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " -----FORM UTAMA-----");
            }
            lblNotif.Text = global.notif_tbl.Rows.Count.ToString();
           
        }

        private void dataCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormSudahDibuka("DATA_NASABAH") == true)
            {
                open = true;
                Design_Form.DATA_NASABAH frm = new Design_Form.DATA_NASABAH();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void dataGudangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormSudahDibuka("DATA_GUDANG") == true)
            {
                Design_Form.DATA_GUDANG frm = new Design_Form.DATA_GUDANG();
                frm.MdiParent = this;
                frm.Show();
            }
        }


        private void pembayaranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormSudahDibuka("PEMBAYARAN") == true)
            {
                Design_Form.PEMBAYARAN frm = new Design_Form.PEMBAYARAN();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void perpanjanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormSudahDibuka("DATA_PERPANJANGAN") == true)
            {
                Design_Form.DATA_PERPANJANGAN frm = new Design_Form.DATA_PERPANJANGAN();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void gantiPaswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormSudahDibuka("GANTI_PASSWORD") == true)
            {

                Design_Form.GANTI_PASSWORD frm = new Design_Form.GANTI_PASSWORD();
                frm.MdiParent = this;
                frm.Show();
            }         
        }

        private void dataAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormSudahDibuka("DATA_PERUSAHAAN") == true)
            {
                Design_Form.DATA_PERUSAHAAN frm = new Design_Form.DATA_PERUSAHAAN();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void bungaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormSudahDibuka("Bunga") == true)
            {

                Design_Form.Bunga frm = new Design_Form.Bunga();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void kontrakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormSudahDibuka("DATA_PINJAMAN") == true)
            {
                Design_Form.DATA_PINJAMAN frm = new Design_Form.DATA_PINJAMAN();
                frm.MdiParent = this;
                frm.Show();
            }            
        }

        private void listPeminjamanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormSudahDibuka("List_Peminjaman") == true)
            {
                Design_Form.List_Peminjaman frm = new Design_Form.List_Peminjaman();
                frm.MdiParent = this;
                frm.Show();
            }            
        }

        private void addAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormSudahDibuka("ADD_AKUN") == true)
            {
                Design_Form.ADD_AKUN frm = new Design_Form.ADD_AKUN();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer_status.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss", culture);
        }

        private void calenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormSudahDibuka("TANGGAL_MERAH") == true)
            {
                Design_Form.TANGGAL_MERAH frm = new Design_Form.TANGGAL_MERAH();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void lapNasabahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormSudahDibuka("C") == true)
            {
                global.lap_name = "C";
                Design_Form.LAP_TGL frm = new Design_Form.LAP_TGL();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void perNasabahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormSudahDibuka("LAP_PEMBAYARAN_PERCUSTOMERS") == true)
            {
                Design_Form.LAP_PEMBAYARAN_PERCUSTOMERS frm = new Design_Form.LAP_PEMBAYARAN_PERCUSTOMERS();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void perPeriodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormSudahDibuka("P") == true)
            {
                global.lap_name = "P";
                Design_Form.LAP_TGL frm = new Design_Form.LAP_TGL();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void peminjamanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (IsFormSudahDibuka("PM") == true)
            {
                global.lap_name = "PM";
                Design_Form.LAP_TGL frm = new Design_Form.LAP_TGL();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void perpanjanganToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (IsFormSudahDibuka("PP") == true)
            {
                global.lap_name = "PP";
                Design_Form.LAP_TGL frm = new Design_Form.LAP_TGL();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void notifikasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormSudahDibuka("NOTIF") == true)
            {
                Design_Form.NOTIF frm = new Design_Form.NOTIF();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormSudahDibuka("HISTORI") == true)
            {
                Design_Form.HISTORI frm = new Design_Form.HISTORI();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menuStrip1_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void historiLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormSudahDibuka("LOGIN_HISTORI") == true)
            {
                Design_Form.LOGIN_HISTORI frm = new Design_Form.LOGIN_HISTORI();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void FrmUtama_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Keluar dari aplikasi ?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.No)
                e.Cancel = true;
            else
            {
                h_login();
                Environment.Exit(0);
            }
        }

        private void xxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kontrakToolStripMenuItem_Click(null, null);
        }

        private void perpanjanganToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            perpanjanganToolStripMenuItem_Click(null, null);
        }

        private void pembayranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pembayaranToolStripMenuItem_Click(null, null);
        }

        private void notifikasiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            notifikasiToolStripMenuItem_Click(null, null);
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cetak Laporan Denda", "Cetak", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                Laporan.Lap_Denda cr = new Laporan.Lap_Denda();
                cr.RecordSelectionFormula = "{@LEWAT} > 0";

                Laporan.CETAK frm = new Laporan.CETAK();
                frm.crystalReportViewer1.ReportSource = cr;
                frm.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
                frm.crystalReportViewer1.RefreshReport();
                frm.Show();
            }
        }

    }
}
