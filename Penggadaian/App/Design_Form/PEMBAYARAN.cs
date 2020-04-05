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
    public partial class PEMBAYARAN : Form
    {
        public PEMBAYARAN()
        {
            InitializeComponent();
        }
      
        ArrayList array_kode, array_nama, array_ktp, array_total, array_gudang;
        int total, urut ,sisa;
        string sn,query;
        byte tipe;
        bool save = true, cetak = false, validasi;
        string vgudang;
        //--------------------------------------------------------------------------------------------
        // procedure -------------------------------------------------------------------------------------------
        private void list_peminjaman()
        {
            array_kode = new ArrayList();
            array_nama = new ArrayList();
            array_ktp = new ArrayList();
            array_total = new ArrayList();
            array_gudang = new ArrayList();
            query = "select * from tbl_Data_Peminjaman";
            global.cmd = new System.Data.SqlClient.SqlCommand(query, global.con);
            global.rdr = global.cmd.ExecuteReader();
            while (global.rdr.Read())
            {
                array_kode.Add(global.rdr[0]);
                array_ktp.Add(global.rdr[2]);
                array_total.Add(global.rdr[5]);
                array_nama.Add(global.rdr[3]);
            }
            global.rdr.Close();
        }

        private void save_pembayaran()
        {
            string idpinjaman = "", vtipe = "", rekening = "", atas_nama = "", jlh = "";
            DateTime tgl = DateTime.Now;
            if (tipe == 1)
            {
                //header
                sn = global.serial_number("TUNAI");
                //DETAIL
            idpinjaman = cboKODE_TUNAI.SelectedItem.ToString();
                vtipe = "TUNAI";
                rekening = "";
                atas_nama = "";
                jlh = nudJLAH_TUNAI.Value.ToString();
                tgl = DateTime.Now;
            }
            else if (tipe == 2)
            {
                //header
                sn = global.serial_number("TRANSFER");
                //DETAIL
                idpinjaman = cboKODE_TRANS.SelectedItem.ToString();
                vtipe = "TRANSFER";
                rekening = txtREK_TRANS.Text;
                atas_nama = txtATAS_NAMA_TRANS.Text;
                jlh = nudJLH_TRANS.Value.ToString();
                tgl = dtpTGL_TRANS.Value;
            }
            bool save_header = false;
            global.val = new ArrayList();
            global.val.Add(idpinjaman);
            query = "SELECT COUNT(*) FROM [dbo].[PEMBAYARAN_H] WHERE ID_PEMINJAMAN = @PARAM0";
            global.query(query, global.val, true);
            if (global.rdr.Read())
            {
                if (Convert.ToByte(global.rdr[0]) == 0)
                    save_header = true;
            }
            global.rdr.Close();

            try
            {
                if (Convert.ToInt32(jlh) > 0)
                {
                    global.sqltrans = global.con.BeginTransaction();
                    try
                    {
                        if (save_header == true)
                        {
                            global.val = new ArrayList();
                            global.val.Add(idpinjaman);
                            global.val.Add(total);
                            query = "INSERT INTO [dbo].[PEMBAYARAN_H] VALUES(@PARAM0,@PARAM1)";
                            global.query(query, global.val, false);
                        }
                        global.val = new ArrayList();
                        global.val.Add(sn);
                        global.val.Add(idpinjaman);
                        global.val.Add(vtipe);
                        global.val.Add(tgl);
                        global.val.Add(rekening);
                        global.val.Add(atas_nama);
                        global.val.Add(jlh);
                        global.val.Add(global.login);
                        global.val.Add(DateTime.Now);

                        query = "INSERT INTO [dbo].[PEMBAYARAN_d] VALUES(@PARAM0,@PARAM1,@PARAM2,@PARAM3,@PARAM4,@PARAM5,@PARAM6,@PARAM7,@PARAM8)";
                        global.query(query, global.val, false);

                        if (tipe == 1)
                            global.update_sn(global.no, "TUNAI");
                        else if (tipe == 2)
                            global.update_sn(global.no, "TRANSFER");
                        global.sqltrans.Commit();
                        lblSN.Text = sn;
                        MessageBox.Show("Pembayaran " + cboTIPE.Text + " dengan kode " + sn + " Berhasil ...");
                        save = false;
                        cetak = true;
                    }
                    catch (Exception ex)
                    {
                        global.sqltrans.Rollback();
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Jumlah pembayaran tidak boleh Rp. 0");
            }
            catch
            {
                MessageBox.Show("Input jumlah dengan benar");
            }
        }

        private void UPDATE_STATUS()
        {
            sisi_pinjaman();
            if (sisa == 0 )
            {
                global.sqltrans = global.con.BeginTransaction();
                try
                {
                    global.val = new ArrayList();
                    global.val.Add(vgudang);
                    query = "UPDATE GUDANG SET STATUS = 'DITEBUS' WHERE ID_TRANS = @PARAM0";
                    global.query(query, global.val, false);

                    global.val = new ArrayList();
                    if (tipe == 1)
                        global.val.Add(cboKODE_TUNAI.SelectedItem);
                    else if (tipe == 2)
                        global.val.Add(cboKODE_TRANS.SelectedItem);
                    query = "UPDATE Peminjaman SET STATUS = 'NON AKTIF', JATUH_TEMPO = NULL WHERE ID_TRANS =@PARAM0";
                    global.query(query, global.val, false);
                    global.sqltrans.Commit();
                }
                catch (Exception ex)
                {
                    global.sqltrans.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void validasi_txt()
        {
            //tunai
            if (cboTIPE.SelectedIndex == 0)
            {
                if (cboKODE_TUNAI.SelectedIndex > -1 && nudJLAH_TUNAI.Value > 0)
                    validasi = true;
                else
                    validasi = false;
            }
            //transfre
            else
            {
                if (cboKODE_TRANS.SelectedIndex > -1 && txtATAS_NAMA_TRANS.Text !="" && txtREK_TRANS.Text != "" && nudJLH_TRANS.Value > 0)
                    validasi = true;
                else
                    validasi = false;
            }
        }

        private void cboKODE_TUNAI_Validated(object sender, EventArgs e)
        {
            //if (cboKODE_TUNAI.SelectedIndex != -1)
            //{
            //    val_pembayarang();
            //    cboKODE_TUNAI.Focus();
            //    nudJLAH_TUNAI.Focus();
            //}
        }

        private void cboKODE_TRANS_Validated(object sender, EventArgs e)
        {
            //if (cboKODE_TRANS.SelectedIndex != -1)
            //{
            //    val_pembayarang();
            //    cboKODE_TRANS.Focus();
            //    nudJLH_TRANS.Focus();
            //}
        }

        private void sisi_pinjaman()
        {
            global.val = new ArrayList();
            if (tipe == 1)
                global.val.Add(cboKODE_TUNAI.SelectedItem);
            else if (tipe == 2)
                global.val.Add(cboKODE_TRANS.SelectedItem);
            query = "SELECT ISNULL(SUM([JLH_PEMBAYARAN]),0) FROM [dbo].[PEMBAYARAN_D]  WHERE [ID_PEMINJAMAN] = @PARAM0";
            global.query(query, global.val, true);

            if (global.rdr.Read())
                sisa = total - Convert.ToInt32(global.rdr[0]);
            else
                sisa = total;
            global.rdr.Close();
            if (sisa < 0)
                sisa = 0;
        }
        //--------------------------------------------------------------------
        private void PEMBAYARAN_Load(object sender, EventArgs e)
        { 
            cboTIPE.SelectedIndex = 0;
            dtpTGL_TRANS.MaxDate = DateTime.Today;
            txtTGL_TUNAI.Text = DateTime.Today.ToString("dd-MM-yyyy");
            cboKODE_TRANS.Items.Clear();
            cboKODE_TUNAI.Items.Clear();
            list_peminjaman();
            for (int i = 0; i <= array_kode.Count - 1; i++)
            {
                cboKODE_TRANS.Items.Add(array_kode[i]);
                cboKODE_TUNAI.Items.Add(array_kode[i]);
            }
            
        }

        private void cboTIPE_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel2.Size = new Size(100,100);
            if (cboTIPE.SelectedIndex == 0)
            {
                tipe = 1; //tunai
                TRANSFER.Visible = false;
                TUNAI.Visible = true;
                TUNAI.Location = new Point(10, 30);
            }
            else
            {
                tipe = 2; //transfer
                TRANSFER.Visible = true;
                TUNAI.Visible = false;
                TRANSFER.Location = new Point(10, 30);
            }
        }

        private void Val_data(object sender, EventArgs e)
        {
            if (cboTIPE.SelectedIndex == 0)
            {
                if (cboKODE_TUNAI.SelectedIndex != -1)
                {
                    total = Convert.ToInt32(array_total[cboKODE_TUNAI.SelectedIndex]);
                    txtKTP_TUNAI.Text = array_ktp[cboKODE_TUNAI.SelectedIndex].ToString() + " - " + array_nama[cboKODE_TUNAI.SelectedIndex].ToString();
                    sisi_pinjaman();
                    txtTUNAIKET.Text = "Sisa pembayaran Rp. " + string.Format("{0:n0}", sisa);
                    vgudang = cboKODE_TUNAI.SelectedItem.ToString();
                }
            }
            else
            {
                if (cboKODE_TRANS.SelectedIndex != -1)
                {
                    total = Convert.ToInt32(array_total[cboKODE_TRANS.SelectedIndex]);
                    txtKTP_TRANS.Text = array_ktp[cboKODE_TRANS.SelectedIndex].ToString() + " - " + array_nama[cboKODE_TRANS.SelectedIndex].ToString();
                    sisi_pinjaman();
                    txtTRANSKET.Text = "Sisa pembayaran Rp. " + string.Format("{0:n0}", sisa);
                    vgudang = cboKODE_TRANS.SelectedItem.ToString();
                }
            }
            val_pembayarang();
        }


        private void val_pembayarang()
        {
            if (tipe == 1)
            {
                nudJLAH_TUNAI.Minimum = 0;
                nudJLAH_TUNAI.Maximum = sisa;
            }
            else
            {
                nudJLH_TRANS.Minimum = 0;
                nudJLH_TRANS.Maximum = sisa;
            }
        }

        private void Simpan_data(object sender, EventArgs e)
        {
            validasi_txt();
            if (validasi == true)
            {
                validasi = false;
                if (save == true)
                {
                    save_pembayaran();
                    UPDATE_STATUS();
                    if (cetak == true)
                    {
                        if (MessageBox.Show("Cetak bukti Pembayaran", "PRINT", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            if (tipe == 1)
                            {
                                Laporan.Kwitansi_pembayaran cr = new Laporan.Kwitansi_pembayaran();
                                cr.RecordSelectionFormula = "{PEMBAYARAN_D.ID_PEMBAYARAN} ='" + sn + "'";

                                Laporan.CETAK frm = new Laporan.CETAK();
                                frm.crystalReportViewer1.ReportSource = cr;
                                frm.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
                                frm.crystalReportViewer1.RefreshReport();
                                frm.Show();
                            }
                            else
                            {
                                Laporan.kWITANSI_PEMBAYARAN_TRANS cr = new Laporan.kWITANSI_PEMBAYARAN_TRANS();
                                cr.RecordSelectionFormula = "{PEMBAYARAN_D.ID_PEMBAYARAN} ='" + sn + "'";

                                Laporan.CETAK frm = new Laporan.CETAK();
                                frm.crystalReportViewer1.ReportSource = cr;
                                frm.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
                                frm.crystalReportViewer1.RefreshReport();
                                frm.Show();
                            }
                        }
                    }
                }
            }
            else
                MessageBox.Show("Data harus dilengkapis");
        }

        private void Reset(object sender, EventArgs e)
        {
            int x = cboTIPE.SelectedIndex;
            save = true;
            cetak = false;
            lblSN.Text = "";
            PEMBAYARAN_Load(null, null);
            cboTIPE.SelectedIndex = x; 
            if (cboTIPE.SelectedIndex == 0)
            {
                cboKODE_TUNAI.Text = "";
                txtTUNAIKET.Text = "";
                txtKTP_TUNAI.Text = "";
                nudJLAH_TUNAI.Minimum = 0;
                nudJLAH_TUNAI.Value = 0;
            }
            else
            {
                cboKODE_TRANS.Text = "";
                foreach (Control reset in TRANSFER.Controls)
                {
                    if (reset is TextBox) reset.Text = "";
                }
                dtpTGL_TRANS.Value = DateTime.Today;
                nudJLH_TRANS.Minimum = 0;
                nudJLH_TRANS.Value = 0;
            }
        }

        private void Browse(object sender, EventArgs e)
        {
            global.DATA_PEMBAYARAN = true;
            PENCARIAN frm = new PENCARIAN();
            frm.ShowDialog();
            if (cboTIPE.SelectedIndex == 0)
            {
                cboKODE_TUNAI.SelectedItem = global.Ambil;
                cboKODE_TUNAI.Focus();
                nudJLAH_TUNAI.Focus();
            }
            else
            {
                cboKODE_TRANS.SelectedItem = global.Ambil;
                cboKODE_TRANS.Focus();
                nudJLH_TRANS.Focus();
            }
        }

    }
}
