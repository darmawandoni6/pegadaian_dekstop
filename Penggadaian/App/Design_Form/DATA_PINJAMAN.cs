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
    public partial class DATA_PINJAMAN : Form
    {
        public DATA_PINJAMAN()
        {
            InitializeComponent();
        }
        // Variable -----------------------------------------------------------------------------
        string msg, kode_gudang, kode_pinjaman,kode_nasabah,query;
        string charger, tas, kotak, bon;
        bool simpan = true, cetak,perbarui;
        int no_barang,no_cus,no_trans,no_gudang;
        decimal bunga, gt;
        DateTime jatuh_tempo;
        //---------------------------------------------------------------------------------------
        // Procedure ----------------------------------------------------------------------------
        private void reset()
        {
            kode_pinjaman = "";
            foreach (Control rst1 in groupBox1.Controls)
            {
                if (rst1 is TextBox) rst1.Text = "";
            }
            foreach (Control rst1 in groupBox2.Controls)
            {
                if (rst1 is TextBox) rst1.Text = "";
                else if (rst1 is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)rst1;
                    nud.Value = nud.Minimum;
                }
                else if (rst1 is ComboBox)
                {
                    ComboBox cmb = (ComboBox)rst1;
                    cmb.SelectedIndex = 0;
                }
            }
            foreach (Control rst1 in groupBox3.Controls)
            {
                if (rst1 is TextBox) rst1.Text = "";
                else if (rst1 is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)rst1;
                    nud.Value = nud.Minimum;
                }
            }
            cboBARANG.SelectedIndex = 0;
            chkKTP.Checked = false;

            foreach (Control rst1 in panel4.Controls)
            {
                if (rst1 is CheckBox)
                {
                    CheckBox chk = (CheckBox)rst1;
                    chk.Checked = false;
                }
            }
        }

        private void proses_peminjaman()
        {
            if (simpan == true)
            {
                kode_nasabah = global.serial_number("NASABAH");
                no_cus = global.no;
            }
            global.sqltrans = global.con.BeginTransaction();
            try
            {
                if (cetak == true)
                {
                    if (simpan == true)
                    {
                        ArrayList value = new ArrayList();

                        value.Add(kode_nasabah);
                        value.Add(txtKTP.Text);
                        value.Add(txtNAMA.Text);
                        value.Add(txtALAMAT.Text);
                        value.Add(txtTELP.Text);
                        value.Add("KTP");
                        value.Add(global.login);
                        value.Add(DateTime.Now);

                        query = "INSERT INTO [dbo].[NASABAH] VALUES (@PARAM0,@PARAM1,@PARAM2,@PARAM3,@PARAM4,@PARAM5,@PARAM6,@PARAM7,NULL,NULL)";
                        global.query(query, value, false); ;
                        simpan = false;
                    }
                    
                    //peminjaman
                    ArrayList peminjaman = new ArrayList();
                    peminjaman.Add(kode_pinjaman);
                    peminjaman.Add(kode_nasabah);
                    peminjaman.Add("KTP");
                    peminjaman.Add(nudMAX.Value);
                    peminjaman.Add(nudMIN.Value);
                    peminjaman.Add(nudPINJAMAN.Value);
                    peminjaman.Add(bunga);
                    peminjaman.Add(DateTime.Now);
                    peminjaman.Add(jatuh_tempo);
                    peminjaman.Add(gt);
                    peminjaman.Add("AKTIF");
                    peminjaman.Add(global.login);
                    peminjaman.Add(DateTime.Now);

                    query = "INSERT INTO Peminjaman VALUES(@PARAM0,@PARAM1,@PARAM2,@PARAM3,@PARAM4,@PARAM5,@PARAM6,@PARAM7,@PARAM8,@PARAM9,@PARAM10,@PARAM11,@PARAM12)";
                    global.query(query, peminjaman, false);

                    //gudang
                    ArrayList barang = new ArrayList();
                    barang.Add(kode_gudang);
                    barang.Add(kode_pinjaman);
                    barang.Add(cboBARANG.SelectedItem);
                    barang.Add(DateTime.Now);
                    barang.Add(txtMERK.Text);
                    barang.Add(txtTIPE.Text);
                    barang.Add(txtPROCESSOR.Text);
                    barang.Add(nudHDD.Value + " " + comboBox1.SelectedItem);
                    barang.Add(nudRAM.Value + " " + comboBox3.SelectedItem);
                    barang.Add(nudVGA.Value + " " + comboBox4.SelectedItem);
                    barang.Add(txtKONDISI.Text);
                    barang.Add("GADAI");
                    barang.Add(txtWarna.Text);

                    query = "INSERT INTO GUDANG VALUES(@PARAM0,@PARAM1,@PARAM2,@PARAM3,@PARAM4,@PARAM5,@PARAM6,@PARAM7,@PARAM8,@PARAM9,@PARAM10,@PARAM11,@PARAM12)";
                    global.query(query, barang, false);

                    //kelengkapan
                    ArrayList kelengkpan = new ArrayList();
                    kelengkpan.Add(kode_gudang);
                    kelengkpan.Add(charger);
                    kelengkpan.Add(tas);
                    kelengkpan.Add(kotak);
                    kelengkpan.Add(bon);

                    query = "INSERT INTO KELENGKAPAN VALUES(@PARAM0,@PARAM1,@PARAM2,@PARAM3,@PARAM4)";
                    global.query(query, kelengkpan, false);
                    //update sn
                    if (cboBARANG.SelectedIndex == 0) global.update_sn(no_barang, "PC");
                    else global.update_sn(no_barang, "HP");
                    global.update_sn(no_trans, "TRANS");
                    global.update_sn(no_cus, "NASABAH");
                    global.sqltrans.Commit();

                    MessageBox.Show("Data berhasil disimpan");
                    txtNO_TRANS.Text = kode_pinjaman;
                    cetak = true;
                }
            }
            catch (Exception ex)
            {
                cetak = false;
                global.sqltrans.Rollback();
                MessageBox.Show(ex.Message + " ----- DATA_PEMINJAMAN ----- PROSES_PEMINJAMAN");
            }
        }

        private void list_tgl_merah()
        {
            try
            {
                if (global.ds.Tables["list_tgl_merah"] != null) global.ds.Tables["list_tgl_merah"].Clear();
                System.Data.SqlClient.SqlDataAdapter ad = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM TANGGAL_MERAH", global.con);
                ad.Fill(global.ds, "list_tgl_merah");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " --------------" + this.Name + "/tgl_merah --------------");
            }
        }
       
        //---------------------------------------------------------------------------------------
        // Function -----------------------------------------------------------------------------
        bool lengkap()
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "" && c.Name.ToString() != "txtNO_TRANS")
                    {
                        c.Focus();
                        return false;
                    }
                }
            }
            if (cboBARANG.SelectedIndex == -1)
            {
                cboBARANG.Focus();
                return false;
            }
            if (chkKTP.Checked == false)
            {
                chkKTP.Focus();
                return false;
            }
            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox && c.Text == "")
                {
                    c.Focus();
                    return false;
                }
            }
            foreach (Control c in groupBox3.Controls)
            {
                if (c is NumericUpDown )
                {
                    NumericUpDown nud = (NumericUpDown)c;
                    if (nud.Value == 0)
                    {
                        nud.Focus();
                        return false;
                    }
                }
            }
            return true;
        }
        //---------------------------------------------------------------------------------------

        private void DATA_PINJAMAN_Load(object sender, EventArgs e)
        {
            list_tgl_merah();
            simpan = true;
            global.cmd = new System.Data.SqlClient.SqlCommand("SELECT * FROM Bunga", global.con);
            global.rdr = global.cmd.ExecuteReader();
            global.rdr.Read();
            if (global.rdr.HasRows)
            {
                bunga = Convert.ToDecimal(global.rdr[1]);
            }
            global.rdr.Close();
            lblBUNGAN.Text = "Hari, Jasa " + bunga + "%";
            comboBox1.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            cboBARANG.SelectedIndex = 0;
            cetak = true;
        }

        private void btnRESET_Click(object sender, EventArgs e)
        {
            reset();
            simpan = true;
            cetak = true;
            bntPerbarui.Enabled = false;
            txtKTP.Clear();
            txtKTP.Focus();
        }

        private void btnCETAK_Click(object sender, EventArgs e)
        {
            if (lengkap() == true && txtKTP.MaskCompleted)
            {
                if (bntPerbarui.Enabled == false)
                {
                    if (cetak == true)
                    {
                        if (cboBARANG.SelectedIndex == 0) kode_gudang = global.serial_number("PC");
                        else kode_gudang = global.serial_number("HP");
                        no_barang = global.no;
                        kode_pinjaman = global.serial_number("TRANS");
                        no_trans = global.no;
                    }
                    proses_peminjaman();
                }
                else
                    bntPerbarui_Click(null, null);
                if (cetak == true)
                {
                    if (MessageBox.Show("Silahkan cetak kontrak peminjaman ... ", "Cetak", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Laporan.kontrak cr = new Laporan.kontrak();
                        if (bntPerbarui.Enabled == false)
                            cr.RecordSelectionFormula = "{Peminjaman.ID_TRANS}='" + kode_pinjaman + "'";
                        else
                            cr.RecordSelectionFormula = "{Peminjaman.ID_TRANS}='" + txtNO_TRANS.Text+ "'";

                        Laporan.CETAK frm = new Laporan.CETAK();
                        frm.crystalReportViewer1.ReportSource = cr;
                        frm.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
                        frm.crystalReportViewer1.RefreshReport();
                        frm.ShowDialog();   
                    }
                }
            }
            else
            {
                if (msg != "")
                {
                    MessageBox.Show(msg);
                    msg = "";
                }
                else
                {
                    MessageBox.Show("Data harus lengkap");
                }
            }
        }
        
        private void btnCARI_Click(object sender, EventArgs e)
        {
            global.VDATA_NASABAH = true;
            PENCARIAN frm = new PENCARIAN();
            frm.ShowDialog();
            txtKTP.Text = global.Ambil;
            txtKTP.Focus();
            txtNAMA.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            global.DATA_PEMBAYARAN = true;
            PENCARIAN frm = new PENCARIAN();
            frm.ShowDialog();
            txtNO_TRANS.Text = global.Ambil;
            txtNO_TRANS.Focus();
            txtNAMA.Focus();
        }

        private void nudPINJAMAN_ValueChanged(object sender, EventArgs e)
        {
            decimal total = nudPINJAMAN.Value * (Convert.ToDecimal(bunga / 100));
            txtNILAI_BUNGA.Text ="Rp "+ string.Format("{0:n2}",Math.Round(total,0));
            gt = nudPINJAMAN.Value - Math.Round(total, 0);
            txtTOTAL_PEMBAYARAN.Text = "Rp " + string.Format("{0:n2}", Math.Round(gt, 0));
        }

        private void nudMAX_ValueChanged(object sender, EventArgs e)
        {
            nudMIN.Value = 0;
            nudPINJAMAN.Value = 0;
            nudPINJAMAN.Maximum = nudMAX.Value;

        }

        private void nudMIN_ValueChanged(object sender, EventArgs e)
        {
            nudPINJAMAN.Minimum = nudMIN.Value;
            if (nudMIN.Value > nudMAX.Value)
            {
                MessageBox.Show("Nilai minimun harus lebih kecil dari nilai maximum");
                nudMIN.Value = nudMAX.Value;
                nudPINJAMAN.Minimum = nudMIN.Value;
                nudPINJAMAN.Value = nudPINJAMAN.Minimum;
                nudPINJAMAN.Maximum = nudMAX.Value;
            }
        }

        private void cboBARANG_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CHECK(object sender, EventArgs e)
        {
            if (chkCHARGER.Checked) charger = "Y"; else charger = "T";
            if (chkTAS.Checked) tas = "Y"; else tas = "T";
            if (chkKOTAK.Checked) kotak = "Y"; else kotak = "T";
            if (chkBON.Checked) bon = "Y"; else bon = "T";
        }

        private void nudLAMA_PINJAM_ValueChanged(object sender, EventArgs e)
        {
            
        }
        
        private void txtKTP_MouseClick(object sender, MouseEventArgs e)
        {
            string x = txtKTP.Text;
            if (x.Trim().Length == 0)
                txtKTP.Select(0, 0);
        }

        bool cek_status()
        {
            bool r = false;
            query = "select KTP,STATUS from tbl_Data_nasabah where KTP=@PARAM0";
            global.val = new ArrayList();
            global.val.Add(txtKTP.Text);

            global.query(query, global.val, true);
            while (global.rdr.Read())
            {
                if (global.rdr[1].ToString() == "AKTIF")
                {
                    MessageBox.Show("No. KTP ini sedang melakukan peminjaman");
                    r = false;
                    break;
                }
                else
                    r = true;
            }
            global.rdr.Close();
            return r;
        }

        private void txtKTP_Validated(object sender, EventArgs e)
        {
            if (txtKTP.MaskCompleted)
            {
                cek_status();

                query = "select KTP,NAMA,ALAMAT,TELP from NASABAH where KTP=@PARAM0";
                global.val = new ArrayList();
                global.val.Add(txtKTP.Text);
                global.query(query, global.val, true);
                if (global.rdr.Read())
                {
                    //txtKTP.Text = global.rdr[0].ToString();
                    txtNAMA.Text = global.rdr[1].ToString();
                    txtALAMAT.Text = global.rdr[2].ToString();
                    txtTELP.Text = global.rdr[3].ToString();
                }
                else
                {
                    txtNAMA.Clear();
                    txtALAMAT.Clear();
                    txtTELP.Clear();
                }
                global.rdr.Close();

            }
        }

        private void DATA_PINJAMAN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Form close ... ?", "Closed", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.No)
                e.Cancel = true;
        }

        private void txtNAMA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Hanya bisa diisi dengan huruf...");
                e.Handled = true;
            }
        }

        private void txtTELP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Hanya bisa diisi dengan angka...");
                e.Handled = true;
            }
        }

        private void nudLAMA_PINJAM_Validated(object sender, EventArgs e)
        {
            DateTime sekarang = DateTime.Today;
            jatuh_tempo = sekarang.AddDays(Convert.ToByte(nudLAMA_PINJAM.Value));
            DataRow[] arr;
            arr = global.ds.Tables["list_tgl_merah"].Select("TAHUN='" + jatuh_tempo.ToString("yyyy") + "'");
            if (arr.Length != 0)
            {
                ArrayList tgl = new ArrayList();
                for(byte i = 0; i<= arr.Length -1; i++)
                {
                    tgl.Add(arr[i][1]);
                }
                
                byte y = 0;
                while (Convert.ToDateTime(tgl[y]).ToString("dd-MM-yy") == jatuh_tempo.ToString("dd-MM-yy")) 
                {
                    jatuh_tempo = jatuh_tempo.AddDays(1);
                } 
            }
            
            txtTGL_PENGEMBALIAN.Text = jatuh_tempo.ToString("dddd, dd MMMM yyyy");


        }


        private void cari_id(string id)
        {
            perbarui = true;
            query = "SELECT dbo.Peminjaman.ID_TRANS, dbo.NASABAH.ID, dbo.GUDANG.KODE "+
                    "FROM            dbo.NASABAH INNER JOIN dbo.Peminjaman "+
                    "ON dbo.NASABAH.ID = dbo.Peminjaman.ID_NASABAH INNER JOIN dbo.GUDANG "+
                    "ON dbo.Peminjaman.ID_TRANS = dbo.GUDANG.ID_TRANS WHERE dbo.Peminjaman.ID_TRANS = @PARAM0";
            global.val = new ArrayList();
            global.val.Add(id);

            global.query(query, global.val, true);
            if (global.rdr.Read())
            {
                kode_nasabah = global.rdr[1].ToString();
                kode_gudang = global.rdr[2].ToString();
                kode_pinjaman = global.rdr[0].ToString();
            }
            global.rdr.Close();

            query = "SELECT KTP FROM NASABAH WHERE ID=@PARAM0";
            global.val = new ArrayList();
            global.val.Add(kode_nasabah);

            global.query(query, global.val, true);
            if (global.rdr.Read())
            {
                txtKTP.Text = global.rdr[0].ToString();
            }
            global.rdr.Close();
            txtKTP_Validated(null, null);

            query = "select JENIS, MERK,TYPE,PROCESSOR,HDD,RAM,VGA,KONDISI,WARNA from GUDANG WHERE KODE=@PARAM0";
            global.val = new ArrayList();
            global.val.Add(kode_gudang);

            global.query(query, global.val, true);
            if (global.rdr.Read())
            {
                cboBARANG.SelectedItem = global.rdr[0];
                txtMERK.Text = global.rdr[1].ToString();
                txtTIPE.Text = global.rdr[2].ToString();
                txtPROCESSOR.Text = global.rdr[3].ToString();
                nudHDD.Value = cari_angka(global.rdr[4].ToString());
                comboBox1.SelectedIndex = kapasitas(global.rdr[4].ToString());
                nudRAM.Value = cari_angka(global.rdr[5].ToString());
                comboBox3.SelectedIndex = kapasitas(global.rdr[5].ToString());
                nudVGA.Value = cari_angka(global.rdr[6].ToString());
                comboBox4.SelectedIndex = kapasitas(global.rdr[6].ToString());
                txtKONDISI.Text = global.rdr[7].ToString();
                txtWarna.Text = global.rdr[8].ToString();
            }
            global.rdr.Close();

            query = "SELECT CHARGER,TAS,KOTAK,BON_PEMBELIAN FROM KELENGKAPAN where KODE_BARANG=@PARAM0";
            global.val = new ArrayList();
            global.val.Add(kode_gudang);
            global.query(query, global.val, true);
            if (global.rdr.Read())
            {
                if (global.rdr[0].ToString() == "Y")
                    chkCHARGER.Checked = true;
                else
                    chkCHARGER.Checked = false;
                if (global.rdr[1].ToString() == "Y")
                    chkTAS.Checked = true;
                else
                    chkTAS.Checked = false;
                if (global.rdr[2].ToString() == "Y")
                    chkKOTAK.Checked = true;
                else
                    chkKOTAK.Checked = false;
                if (global.rdr[3].ToString() == "Y")
                    chkBON.Checked = true;
                else
                    chkBON.Checked = false;
            }
            global.rdr.Close();

            DateTime tgl = DateTime.Now, jt = DateTime.Now;
            query = "SELECT JAMINAN,NILAI_MAKS,NILAI_MIN,NOMINAL,TGL_PINJAM,JATUH_TEMPO,TOTAL FROM Peminjaman where ID_TRANS =@PARAM0";
            global.val = new ArrayList();
            global.val.Add(kode_pinjaman);
            global.query(query, global.val, true);
            if (global.rdr.Read())
            {
                chkKTP.Checked = true;
                nudMAX.Value = Convert.ToDecimal(global.rdr[1]);
                nudMIN.Value = Convert.ToDecimal(global.rdr[2]);
                nudPINJAMAN.Value = Convert.ToDecimal(global.rdr[3]);
                tgl = Convert.ToDateTime(global.rdr[4]);
                jt = Convert.ToDateTime(global.rdr[5]);
                txtTOTAL_PEMBAYARAN.Text = "Rp. " + string.Format("{0:n0}", Convert.ToInt32(global.rdr[6]));
            }
            global.rdr.Close();

            TimeSpan ts = new TimeSpan();
            ts = jt.Subtract(tgl);
            nudLAMA_PINJAM.Value = Convert.ToDecimal(ts.Days);

            nudLAMA_PINJAM_Validated(null,null);
        }

        byte kapasitas(string kar)
        { 
            string x = kar.Substring(kar.Length -2,2 );
            if(x == "TB")
                return 1;
            return 0;
        }

        decimal cari_angka(string kar)
        {
            string angka = "";
            foreach (char k in kar.ToCharArray())
            {
                if (char.IsNumber(k))
                    angka += k.ToString();
                else
                    break;
            }
            return int.Parse(angka);
        }

        private void bntPerbarui_Click(object sender, EventArgs e)
        {
            global.sqltrans = global.con.BeginTransaction();
            try
            {
                ArrayList value = new ArrayList();
                value.Add(txtNAMA.Text);
                value.Add(txtALAMAT.Text);
                value.Add(txtTELP.Text);
                value.Add(kode_nasabah);
                query = "UPDATE NASABAH SET NAMA=@PARAM0,ALAMAT=@PARAM1,TELP=@PARAM2 WHERE ID=@PARAM3";
                global.query(query, value, false);

                //gudang
                ArrayList barang = new ArrayList();
                barang.Add(cboBARANG.SelectedItem);
                barang.Add(txtMERK.Text);
                barang.Add(txtTIPE.Text);
                barang.Add(txtPROCESSOR.Text);
                barang.Add(nudHDD.Value + " " + comboBox1.SelectedItem);
                barang.Add(nudRAM.Value + " " + comboBox3.SelectedItem);
                barang.Add(nudVGA.Value + " " + comboBox4.SelectedItem);
                barang.Add(txtKONDISI.Text);
                barang.Add(kode_gudang);
                barang.Add(kode_pinjaman);
                barang.Add(txtWarna.Text);

                query = "UPDATE GUDANG SET JENIS=@PARAM0, MERK=@PARAM1,TYPE=@PARAM2,PROCESSOR=@PARAM3,HDD=@PARAM4,RAM=@PARAM5,VGA=@PARAM6,KONDISI=@PARAM7,KODE=@PARAM8,WARNA=@PARAM10) WHERE ID_TRANS=@PARAM9";
                global.query(query, barang, false);

                //kelengkapan
                ArrayList kelengkpan = new ArrayList();
                kelengkpan.Add(charger);
                kelengkpan.Add(tas);
                kelengkpan.Add(kotak);
                kelengkpan.Add(bon);
                kelengkpan.Add(kode_gudang);

                query = "UPDATE KELENGKAPAN SET CHARGER=@PARAM0,TAS=@PARAM1,KOTAK=@PARAM2,BON_PEMBELIAN=@PARAM3 WHERE KODE_BARANG=@PARAM4";
                global.query(query, kelengkpan, false);

                //peminjaman
                ArrayList peminjaman = new ArrayList();
                peminjaman.Add(nudMAX.Value);
                peminjaman.Add(nudMIN.Value);
                peminjaman.Add(nudPINJAMAN.Value);
                peminjaman.Add(bunga);
                peminjaman.Add(DateTime.Now);
                peminjaman.Add(jatuh_tempo);
                peminjaman.Add(gt);
                peminjaman.Add(kode_pinjaman);

                query = "UPDATE Peminjaman SET NILAI_MAKS=@PARAM0,NILAI_MIN=@PARAM1,NOMINAL=@PARAM2,PERSEN_BUNGA=@PARAM3,TGL_PINJAM=@PARAM4,JATUH_TEMPO=@PARAM5,TOTAL=@PARAM6 WHERE ID_TRANS=@PARAM7";
                global.query(query, peminjaman, false);
                global.sqltrans.Commit();

                MessageBox.Show("Berhasil di perbarui");
            }
            catch (Exception ex)
            {
                global.sqltrans.Rollback();
                MessageBox.Show(ex.Message + "---------------" + this.Name + " PERBARUI---------------");
            }   
        }

        private void txtKTP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtNO_TRANS_Validated(object sender, EventArgs e)
        {
            if (txtNO_TRANS.Text != "")
            {
                cari_id(txtNO_TRANS.Text);
                bntPerbarui.Enabled = true;
            }
        }

        

    }
}
