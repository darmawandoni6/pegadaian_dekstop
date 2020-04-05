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
    public partial class DATA_PERPANJANGAN : Form
    {
        public DATA_PERPANJANGAN()
        {
            InitializeComponent();
        }
        // variabel ----------------------------------------------------------------------------------------------------------
        string serial_number;
        byte jlh_hari;
        int denda;
        DateTime awal, akhir, tgl;
        bool save = true, cetak = false, perpanjangan;
        System.Data.SqlClient.SqlDataAdapter ad;
        //--------------------------------------------------------------------------------------------------------------------
        // Procedure ----------------------------------------------------------------------------------------------------------

        private void list_peminjaman()
        {
            string query = "SELECT p.ID_TRANS, n.KTP,n.NAMA,p.TGL_PINJAM,p.JATUH_TEMPO, p.TOTAL " +
                       "FROM Peminjaman as p inner join NASABAH as n " +
                       "on p.ID_NASABAH = n.ID " +
                       "where DATEDIFF(day, getdate(), ISNULL(JATUH_TEMPO, getdate())) < 0 " +
                       "and p.STATUS = 'AKTIF'";
            if (global.ds.Tables["data_perpanjangan"] != null) global.ds.Tables["data_perpanjangan"].Clear();
            ad = new System.Data.SqlClient.SqlDataAdapter(query, global.con);
            ad.Fill(global.ds, "data_perpanjangan");

            cboTRANS.Items.Clear();

            ArrayList idtrans = new ArrayList();
            DataRow[] arr = global.ds.Tables["data_perpanjangan"].Select();
            if (arr.Length != 0)
            {
                foreach (DataRow dr in arr)
                {
                    idtrans.Add(dr[0]);
                }
            }

            query = "select KODE_TRANS from Perpanjangan where KODE_TRANS =@PARAM0";
            foreach (string list in idtrans)
            {
                global.val = new ArrayList();
                global.val.Add(list);

                global.query(query, global.val, true);
                if (!global.rdr.Read())
                {
                    cboTRANS.Items.Add(list);
                }
                global.rdr.Close();
            }
        }

        bool cek_status(string vkode_trans)
        {
            bool x = true;
            try
            {
                string q = "SELECT COUNT(*) FROM Perpanjangan WHERE KODE_TRANS=@X";
                global.cmd = new System.Data.SqlClient.SqlCommand(q, global.con);
                global.cmd.Parameters.AddWithValue("@X", vkode_trans);
                global.rdr = global.cmd.ExecuteReader();
                if (global.rdr.Read())
                {
                    if (Convert.ToByte(global.rdr[0]) > 0)
                        x = false;
                }
                global.rdr.Close();
            }
            catch
            {
                x = false;
            }
            return x;
        }

        private void proses()
        {
            if (cek_status(cboTRANS.SelectedItem.ToString()) == true)
            {
                if (jlh_hari < 30)
                    denda = 10000 * jlh_hari;
                else
                    denda = 100000;
                serial_number = global.serial_number("PERPANJANGAN");
                global.sqltrans = global.con.BeginTransaction();
                try
                {
                    System.Collections.ArrayList value = new ArrayList();
                    value.Add(serial_number);
                    value.Add(cboTRANS.SelectedItem);
                    value.Add(akhir);
                    value.Add(tgl);
                    value.Add(txtALASAN.Text);
                    value.Add(global.login);
                    value.Add(DateTime.Now);

                    string q = "INSERT INTO [dbo].[Perpanjangan] VALUES(@PARAM0,@PARAM1,@PARAM2,@PARAM3,@PARAM4,@PARAM5,@PARAM6)";
                    global.query(q, value, false);

                    global.update_sn(global.no, "PERPANJANGAN");

                    q = "update Peminjaman set TOTAL = @PARAM0 where ID_TRANS = @PARAM1";
                    global.val = new ArrayList();
                    global.val.Add(denda);
                    global.val.Add(cboTRANS.SelectedIndex);

                    global.query(q, global.val, false);

                    global.sqltrans.Commit();

                    MessageBox.Show("Pinjaman nasabah " + txtNASABAH.Text + " Berhasil di perpanjang");
                    save = false;
                    cetak = true;
                    txtPERPANJANGAN.Text = serial_number;
                }
                catch (Exception ex)
                {
                    global.sqltrans.Rollback();
                    MessageBox.Show(ex.Message + " -------- " + this.Name + " -------- ");
                }
            }
            else
                MessageBox.Show("No. transaksi ini sudah pernah melakukan perpanjangan");
            
        }
        // ----------------------------------------------------------------------------------------------------------

        private void DATA_PERPANJANGAN_Load(object sender, EventArgs e)
        {
            list_peminjaman();
            foreach (Control u in panel1.Controls)
            {
                if (u is TextBox)
                {
                    TextBox txt = (TextBox)u;
                    txt.CharacterCasing = CharacterCasing.Upper;
                }
            }
         
        }

        private void cboTRANS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTRANS.SelectedIndex != -1)
            {
                DataRow[] arr = global.ds.Tables["data_perpanjangan"].Select("ID_TRANS ='" + cboTRANS.SelectedItem + "'");
                if (arr.Length != 0)
                {
                    txtNASABAH.Text = arr[0][1].ToString() +" - " + arr[0][2].ToString();
                    txtTGL_AWAL.Text = Convert.ToDateTime(arr[0][3]).ToString("dd-MM-yyyy");
                    txtTGL_AKHIR.Text = Convert.ToDateTime(arr[0][4]).ToString("dd-MM-yyyy");
                    awal = Convert.ToDateTime(arr[0][3]);
                    akhir = Convert.ToDateTime(arr[0][4]);
                    //    DateTime vtgl;
                    //    if (arr.Length == 1)
                    //    {
                    //        awal = Convert.ToDateTime(arr[0][4]);
                    //        txtNASABAH.Text = arr[0][2].ToString() + " - " + arr[0][3].ToString();
                    //        txtTGL_AWAL.Text = awal.ToString("dd-MM-yyyy");
                    //        if (arr[0][0].ToString() == "")
                    //            akhir = Convert.ToDateTime(arr[0][5]);
                    //        else
                    //            akhir = Convert.ToDateTime(arr[0][6]);
                    //        txtTGL_AKHIR.Text = akhir.ToString("dd-MM-yyyy");
                    //    }
                    //    else if (arr.Length > 1)
                    //    {
                    //        vtgl = Convert.ToDateTime(arr[0][6]);
                    //        for (byte i = 0; i <= arr.Length - 1; i++)
                    //        {
                    //            if (vtgl < Convert.ToDateTime(arr[i + 1][6]))
                    //                vtgl = Convert.ToDateTime(arr[i + 1][6]);

                    //            if (i == arr.Length - 2)
                    //                break;
                    //        }
                    //        akhir = vtgl;
                    //        awal = Convert.ToDateTime(arr[0][4]);
                    //        txtNASABAH.Text = arr[0][2].ToString() + " - " + arr[0][3].ToString();
                    //        txtTGL_AWAL.Text = awal.ToString("dd-MM-yyyy");
                    //        txtTGL_AKHIR.Text = akhir.ToString("dd-MM-yyyy");
                    //    }
                }
            }
        }

        private void cboHARI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHARI.SelectedIndex == 0) jlh_hari = 10;
            else if (cboHARI.SelectedIndex == 1) jlh_hari = 20;
            else if (cboHARI.SelectedIndex == 2) jlh_hari = 30;
            else jlh_hari = 0;
            if (cboHARI.SelectedIndex != -1)
            {
                 tgl = akhir.AddDays(jlh_hari);
                txtTGL.Text = tgl.ToString("dd-MM-yyyy");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control r in panel1.Controls)
            {
                if (r is TextBox) r.Text = "";
                else if (r is ComboBox)
                {
                    ComboBox cmb = (ComboBox)r;
                    cmb.SelectedIndex = -1;
                }
            }
            perpanjangan = false;
            save = true;
            cetak = false;
            DATA_PERPANJANGAN_Load(null,null);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cboTRANS.SelectedIndex != -1 && cboHARI.SelectedIndex != -1 && txtALASAN.Text != "" && save != false)
            {
                proses();
                if (cetak == true)
                {
                    if (MessageBox.Show("Cetak bukti Perpanjangan", "PRINT", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Laporan.Kwitansi_perpanjangan cr = new Laporan.Kwitansi_perpanjangan();
                        cr.RecordSelectionFormula = "{Perpanjangan.NoUrut} ='" + serial_number + "'";

                        Laporan.CETAK frm = new Laporan.CETAK();
                        frm.crystalReportViewer1.ReportSource = cr;
                        frm.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
                        frm.crystalReportViewer1.RefreshReport();
                        frm.Show();
                    }
                }
            }
        }

        private void btnBROWSE_Click(object sender, EventArgs e)
        {
            global.Data_perpanjangan = true;
            PENCARIAN frm = new PENCARIAN();
            frm.ShowDialog();
            cboTRANS.Text = global.Ambil;
        }

        private void txtALASAN_Validating(object sender, CancelEventArgs e)
        {
            txtALASAN.Text.ToUpper();
        }

        private void txtALASAN_Validated(object sender, EventArgs e)
        {
            txtALASAN.Text.ToUpper();
        }

        private void cboTRANS_Validated(object sender, EventArgs e)
        {
           
        }
    }
}
