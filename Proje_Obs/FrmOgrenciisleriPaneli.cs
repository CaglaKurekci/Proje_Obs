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
    public partial class FrmOgrenciisleriPaneli : Form
    {
        public FrmOgrenciisleriPaneli()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=CAGLA\SQLEXPRESS;Initial Catalog=Proje_Obs;Integrated Security=True");
        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        string c = "";
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            ds.Ogrenciguncelleme(Txtograd.Text,txtogrsoyad.Text,byte.Parse(cmbkulup.SelectedValue.ToString()),c,int.Parse(txtOGRİD.Text));
            MessageBox.Show("Güncelleme yapılmıştır.");
        }

        private void FrmOgrenciisleriPaneli_Load(object sender, EventArgs e)
        {
           dataGridView1.DataSource= ds.Ogrencilistesi();
            baglanti.Open();
            SqlCommand kom = new SqlCommand("select *from tbl_Kulupler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(kom);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbkulup.DisplayMember = "KulupAd";
            cmbkulup.ValueMember = "Kulupid";
            cmbkulup.DataSource = dt;
            baglanti.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtKulupad_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Ogrencilistesi();
        }
        
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            ds.Ogrenciekle(Txtograd.Text,txtogrsoyad.Text,byte.Parse(cmbkulup.SelectedValue.ToString()),c);
            MessageBox.Show("Ekleme işlemi yapılmıştır.");

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                c = "Kız";

            }
            if (radioButton2.Checked == true)
            {
                c = "Erkek";
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                c = "Kız";

            }
            if (radioButton2.Checked == true)
            {
                c = "Erkek";
            }
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOGRİD.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Txtograd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtogrsoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbkulup.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            c = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (c == "Kız")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;   
                    }
            if (c == "Erkek")
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            ds.Ogrencisil(int.Parse(txtOGRİD.Text));
            MessageBox.Show("Öğrenci silinmiştir.");
        }

        private void Btnara_Click(object sender, EventArgs e)
        {
          dataGridView1.DataSource=  ds.Aramaislemi(txtara.Text);
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Aramaislemi(txtara.Text);
        }
    }
}
