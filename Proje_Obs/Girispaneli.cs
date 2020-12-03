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
    public partial class Girispaneli : Form
    {
        public Girispaneli()
        {
            InitializeComponent();
        }
      

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmOgretmenPaneli f = new FrmOgretmenPaneli();
            f.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmOgrenciPaneli f = new FrmOgrenciPaneli();
            f.numara = textBox1.Text;
            f.Show();
            this.Hide();
        }

        private void Girispaneli_Load(object sender, EventArgs e)
        {
          
            
        }
    }
}
