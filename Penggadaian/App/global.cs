using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
namespace App
{
    class global
    {
        public static bool  DATA_NASABAH, DATA_PEMINJAMAN, DATA_PEMBAYARAN ,LAP_PEMBAYARAN, add_akun_ganti_pass ,Data_perpanjangan, VDATA_NASABAH;
        public static int no;
        public static string login,lap_name;
        public static ArrayList val;

        public static bool master;

        public static SqlTransaction sqltrans;
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader rdr;
        public static DataSet ds;
        //public static SqlDataAdapter view_Nasabah;
        public static SqlDataAdapter notif;
        public static DataTable notif_tbl;
        public static DataRow notif_record;

        public static void buatkoneksi()
        {
            //ASUSA456U
            con = new SqlConnection("data source=localhost ; initial catalog = PENGGADAIAN; integrated security=true");
            con.Open();
            global.ds = new DataSet();
        }

        public static string data;
        public static string Ambil
        {
            get { return data; }
            set { data = value; }
        }

        public static bool menu;
        public static bool visible
        {
            get { return menu; }
            set { menu = value; }
        }

        public static string serial_number(string vkode)
        {
            string sn = "";
            string nol = "00000";
            int kar;
            string gabung;
            cmd = new SqlCommand("SELECT * FROM SERIAL_NUMBER WHERE JENIS=@JENIS", con);
            cmd.Parameters.AddWithValue("@JENIS", vkode);
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                if (rdr[4].ToString() == DateTime.Today.ToString("yyyy"))
                    no = int.Parse(rdr[2].ToString()) + 1;
                else
                    no = 1;
                kar = no.ToString().Length;
                gabung = nol.Substring(0, nol.Length - kar) + no;
                sn = rdr[3].ToString() + gabung+ DateTime.Today.ToString("ddMMyy");
            }
            rdr.Close();
            return sn;
        }
        public static void update_sn(int no, string vkode)
        {
            string thn = DateTime.Now.ToString("yyyy");
            cmd = new SqlCommand("UPDATE [dbo].[SERIAL_NUMBER] SET [NO_URUT] =@no, TAHUN=@THN WHERE JENIS =@JENIS  ", con);
            cmd.Transaction = sqltrans;
            cmd.Parameters.AddWithValue("@no", no);
            cmd.Parameters.AddWithValue("@JENIS", vkode);
            cmd.Parameters.AddWithValue("@THN", thn);
            
            cmd.ExecuteNonQuery();
        }
        public static void query(string q, ArrayList value, bool select)
        {
            cmd = new SqlCommand(q, con);
            for (byte i = 0; i <= value.Count - 1; i++)
            {
                if (value[i] == null)
                    cmd.Parameters.AddWithValue("@PARAM" + i.ToString(), "X");
                else
                    cmd.Parameters.AddWithValue("@PARAM" + i.ToString(), value[i]);
            }
            if (select == true)
                rdr = cmd.ExecuteReader();
            else
            {
                cmd.Transaction = sqltrans;
                cmd.ExecuteNonQuery();
            }
        }

        public static void notifikasi()
        {
            global.notif_tbl = new DataTable();
            global.notif_tbl.Clear();
            notif_tbl.Columns.Add("FORM");
            notif_tbl.Columns.Add("KETERANGAN");
           
        }
    }
}
