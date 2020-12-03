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
    public partial class FrmOgrenciPaneli : Form
    {
        public FrmOgrenciPaneli()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=CAGLA\SQLEXPRESS;Initial Catalog=Proje_Obs;Integrated Security=True");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public string numara;
        private void FrmOgrenciPaneli_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select DersAd,Sınav1,Sınav2,Sınav3,Proje,Ortalama,Durum from Tbl_Notlar inner join Tbl_Dersler on Tbl_Notlar.Dersid=Tbl_Dersler.Dersid where Ogrid=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            // this.Text = numara.ToString();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            
        }
    }
}
