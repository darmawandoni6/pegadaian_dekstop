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
    public partial class Bunga : Form
    {
        public Bunga()
        {
            InitializeComponent();
        }
        decimal x;

        private void Bunga_Load(object sender, EventArgs e)
        {
            global.cmd = new System.Data.SqlClient.SqlCommand("SELECT * FROM Bunga",global.con);
            global.rdr = global.cmd.ExecuteReader();
            if (global.rdr.Read())
            {
                textBox1.Text = global.rdr[0].ToString();
                numericUpDown1.Value = Convert.ToDecimal(global.rdr[1]);
            }
            global.rdr.Close();
            x = numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (x != numericUpDown1.Value)
            {
                global.cmd = new System.Data.SqlClient.SqlCommand("UPDATE [dbo].[Bunga] SET [Bunga] =@bunga WHERE NoUrut = 1", global.con);
                global.cmd.Parameters.AddWithValue("bunga",numericUpDown1.Value);
                global.cmd.ExecuteNonQuery();
                MessageBox.Show("Bunga berhasil diupdate");
                x = numericUpDown1.Value;
            }
        }
    }
}
