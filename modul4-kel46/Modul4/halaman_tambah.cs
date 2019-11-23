using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul4
{
    public partial class halaman_tambah : Form
    {
        SqlConnection koneksi = new SqlConnection(Properties.Settings.Default.ConnectionString);
        public halaman_tambah()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void tutup_Click(object sender, EventArgs e)
        {

        }

        private void lain_txt_Click(object sender, EventArgs e)
        {

        }

        private void harga_txt_Click(object sender, EventArgs e)
        {

        }

        private void thnbuat_txt_Click(object sender, EventArgs e)
        {

        }

        private void merk_txt_Click(object sender, EventArgs e)
        {

        }

        private void jenis_txt_Click(object sender, EventArgs e)
        {

        }

        private void plat_txt_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_hapusdetail_Click(object sender, EventArgs e)
        {

        }

        private void btn_simpantambah_Click(object sender, EventArgs e)
        {
            int harga = int.Parse(harga_box.Text);
            SqlCommand tambah = new SqlCommand();
            tambah.Connection = koneksi;
            koneksi.Open();
            tambah.CommandType = CommandType.Text;
            tambah.CommandText = "insert into mobil values (@no_plat, @jenis_mobil, @merk_mobil, @tahun_mobil, '" + harga + "', @lain_lain, 'masih')";
            tambah.Parameters.AddWithValue("@no_plat", SqlDbType.VarChar).Value = noplat_box.Text;
            tambah.Parameters.AddWithValue("@jenis_mobil", SqlDbType.VarChar).Value = jenis_box.Text;
            tambah.Parameters.AddWithValue("@merk_mobil", SqlDbType.VarChar).Value = merk_box.Text;
            tambah.Parameters.AddWithValue("@tahun_mobil", SqlDbType.VarChar).Value = tahun_box.Text;
            tambah.Parameters.AddWithValue("@lain_lain", SqlDbType.VarChar).Value = lain_box.Text;
            tambah.ExecuteNonQuery();
            MessageBox.Show("Data berhasil ditambahkan");
            koneksi.Close();
            noplat_box.Text = null;
            jenis_box.Text = null;
            merk_box.Text = null;
            tahun_box.Text = null;
            harga_box.Text = null;
            lain_box.Text = null;

        }

        private void btn_bataltambah_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("halaman_tambah form");
            this.Close();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
