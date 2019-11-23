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
    public partial class detail : Form
    {
        SqlConnection koneksi = new SqlConnection(Properties.Settings.Default.ConnectionString);
        private string no_Plat;
        private string jenis;
        private string merk;
        private string harga;
        private string tahun_buat;
        private string lain_lain;

        public static Form1 form;

   


        public void detail_detail()
        {
            //Debug.WriteLine("detail form");
            InitializeComponent();
        }

        public detail(string no_Plat, string jenis, string merk, string harga, string tahun_buat, string lain_lain)
        {
            InitializeComponent();
            this.no_Plat = no_Plat;
            this.jenis = jenis;
            this.merk = merk;
            this.harga = harga;
            this.tahun_buat = tahun_buat;
            this.lain_lain = lain_lain;
        }

        private void detail_Load(object sender, EventArgs e)
        {
            this.plat_box.Text = no_Plat;
            this.jenis_box.Text = jenis;
            this.merk_box.Text = merk;
            this.harga_box.Text = harga;
            this.tahun_box.Text = tahun_buat;
            this.lain_box.Text = lain_lain;

        }

        private void tutup_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("detail form");
            this.Close();
        }

        private void plat_txt_Click(object sender, EventArgs e)
        {

        }

        private void btn_editdetail_Click(object sender, EventArgs e)
        {
                SqlCommand edit = new SqlCommand();
                edit.Connection = koneksi;
                koneksi.Open();
                edit.CommandType = CommandType.Text;
                edit.CommandText = "Update mobil set no_plat=@no_plat, jenis_mobil=@jenis_mobil, merk_mobil=@merk_mobil, tahun_buat=@tahun_buat, harga_sewa=@harga_sewa, lain_lain=@lain_lain where no_plat='" + no_Plat + "'";
                edit.Parameters.AddWithValue("@no_plat", SqlDbType.VarChar).Value = plat_box.Text;
                edit.Parameters.AddWithValue("@jenis_mobil", SqlDbType.VarChar).Value = jenis_box.Text;
                edit.Parameters.AddWithValue("@merk_mobil", SqlDbType.VarChar).Value = merk_box.Text;
                edit.Parameters.AddWithValue("@tahun_buat", SqlDbType.VarChar).Value = tahun_box.Text;
                edit.Parameters.AddWithValue("@harga_sewa", SqlDbType.VarChar).Value = harga_box.Text;
                edit.Parameters.AddWithValue("@lain_lain", SqlDbType.VarChar).Value = lain_box.Text;
                edit.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diubah");
            koneksi.Close();

            this.Close();
            Form1 f1 = new Form1();
            f1.Visible = true;
        }

        private void btn_hapusdetail_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda Yakin?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                SqlCommand hapus = new SqlCommand();
                hapus.Connection = koneksi;
                koneksi.Open();
                hapus.CommandType = CommandType.Text;
                hapus.CommandText = "Delete from mobil where no_plat = '" + no_Plat + "'";
                hapus.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus");

                koneksi.Close();

                Debug.WriteLine("Form1 form");
                this.Close();
                Form1 f1 = new Form1();
                f1.Visible = true;
            }
            else
            {
            }
        }
    }
    
}
