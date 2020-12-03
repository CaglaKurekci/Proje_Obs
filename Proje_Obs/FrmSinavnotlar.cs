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
    public partial class FrmSinavnotlar : Form
    {
        public FrmSinavnotlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=CAGLA\SQLEXPRESS;Initial Catalog=Proje_Obs;Integrated Security=True");
        DataSet1TableAdapters.Tbl_NotlarTableAdapter ds = new DataSet1TableAdapters.Tbl_NotlarTableAdapter();
        private void Txtograd_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmSinavnotlar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kom = new SqlCommand("select *from tbl_Dersler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(kom);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbders.DisplayMember = "DersAd";
            cmbders.ValueMember = "Dersid";
            cmbders.DataSource = dt;
            baglanti.Close();
        }

        private void BtnARA_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListesi(int.Parse(txtOGRİD.Text));
        }
        int notid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notid = int.Parse( dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtOGRİD.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtsinav1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtsinav2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtsinav3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtproje.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtort.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtdurum.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void BtnHESAPLA_Click(object sender, EventArgs e)
        {
            int sınav1, sınav2, sınav3, proje;
            double ortalama;
           // string Durum;
            sınav1 = Convert.ToInt16(txtsinav1.Text);
            sınav2 = Convert.ToInt16(txtsinav2.Text);
            sınav3 = Convert.ToInt16(txtsinav3.Text);
            proje = Convert.ToInt16(txtproje.Text);
            ortalama = (sınav1 + sınav2 + sınav3 + proje) / 4;
            txtort.Text = ortalama.ToString();
            if (ortalama >= 50)
            {
                txtdurum.Text = "Geçti";
            }
            else
            {
                txtdurum.Text = "Kaldı";


            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            ds.NotGuncelle(byte.Parse(cmbders.SelectedValue.ToString()),byte.Parse(txtsinav1.Text), byte.Parse(txtsinav2.Text), byte.Parse(txtsinav3.Text), byte.Parse(txtproje.Text),decimal.Parse(txtort.Text),bool.Parse(txtdurum.Text),int.Parse(txtOGRİD.Text));
            MessageBox.Show("Güncelleme işlemi yapılmıştır.");
        }

        private void BtnTEMİZLE_Click(object sender, EventArgs e)
        {
            txtOGRİD.Text = "";
            txtsinav1.Text = "";
            txtsinav2.Text = "";
            txtsinav3.Text = "";
            txtproje.Text = "";
            txtort.Text = "";
            txtdurum.Text = "";

        }
    }
}
