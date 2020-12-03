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
    public partial class FrmKulüpPaneli : Form
    {
        public FrmKulüpPaneli()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=CAGLA\SQLEXPRESS;Initial Catalog=Proje_Obs;Integrated Security=True");

        private void FrmKulüpPaneli_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select Kulupid,KulupAd from Tbl_Kulupler where durum=1", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void TxtKulupad_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select Kulupid,KulupAd from Tbl_Kulupler where Durum=1", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        string durum = "1";
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("insert into Tbl_Kulupler(KulupAd,durum)values(@s1,@s2)", baglanti);
            komut1.Parameters.AddWithValue("@s1", TxtKulupad.Text);
            komut1.Parameters.AddWithValue("@s2", durum);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kulüp eklenmiştir");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("update Tbl_Kulupler set KulupAd=@d1 where Kulupid=@d2", baglanti);
            komut2.Parameters.AddWithValue("@d1", TxtKulupad.Text);
            komut2.Parameters.AddWithValue("@d2", txtkulupid.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi yapılmıştır.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtkulupid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtKulupad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("update Tbl_Kulupler set Durum=0 where Kulupid=@k1", baglanti);
            komut3.Parameters.AddWithValue("@k1", txtkulupid.Text);
            komut3.ExecuteNonQuery();
            baglanti.Close();
        
           
            MessageBox.Show("Silme işlemi yapılmıştır.");
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
        }
    }
}
