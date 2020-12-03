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

namespace Proje_Obs
{
    public partial class FrmDersislemleripaneli : Form
    {
        public FrmDersislemleripaneli()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=CAGLA\SQLEXPRESS;Initial Catalog=Proje_Obs;Integrated Security=True");

        private void FrmDersislemleripaneli_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select Dersid,DersAd from Tbl_Dersler where Durum=1", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select Dersid,DersAd from Tbl_Dersler where Durum=1", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        string durum = "1";
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komu1 = new SqlCommand("insert into Tbl_Dersler(DersAd,Durum) values(@k1,@k2)", baglanti);
            komu1.Parameters.AddWithValue("@k1", TxtDersad.Text);
            komu1.Parameters.AddWithValue("@k2", durum);
            komu1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme işlemi yapılmıştır.");

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("update Tbl_Dersler set DersAd=@f1 where Dersid=@f2", baglanti);
            komut3.Parameters.AddWithValue("@f1", TxtDersad.Text);
            komut3.Parameters.AddWithValue("@f2", txtdersid.Text);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi yapılmıştır.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtdersid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtDersad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("update Tbl_Dersler set Durum=0 where Dersid=@p1", baglanti);
            komut4.Parameters.AddWithValue("@p1", txtdersid.Text);
            komut4.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi yapılmıştır.");
        }
    }
}
