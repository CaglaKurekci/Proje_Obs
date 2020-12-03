using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Obs
{
    public partial class FrmOgretmenPaneli : Form
    {
        public FrmOgretmenPaneli()
        {
            InitializeComponent();
        }

        private void FrmOgretmenPaneli_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKulüpPaneli f1 = new FrmKulüpPaneli();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDersislemleripaneli f = new FrmDersislemleripaneli();
            f.Show();
        }

        private void BtnSinavnotlari_Click(object sender, EventArgs e)
        {
            FrmSinavnotlar f2 = new FrmSinavnotlar();
            f2.Show();
        }

        private void BtnOgrenciislemleri_Click(object sender, EventArgs e)
        {
            FrmOgrenciisleriPaneli f3 = new FrmOgrenciisleriPaneli();
            f3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
