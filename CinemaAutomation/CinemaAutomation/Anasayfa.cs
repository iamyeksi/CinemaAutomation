using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaAutomation
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pContainer.Controls.Clear();//Anaekran içinde ki paneli temizler.
            Filmler gecis = new Filmler();//Filmler butonuna tıklayınca filmler sayfasını açar. 
            gecis.TopLevel = false;
            gecis.Dock = DockStyle.Fill;
            this.pContainer.Controls.Add(gecis);//panel içinde formu açmaya yarar.
            gecis.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pContainer.Controls.Clear();
            YakindaVizyon gecis = new YakindaVizyon();
            gecis.TopLevel = false;
            gecis.Dock = DockStyle.Fill;
            this.pContainer.Controls.Add(gecis);
            gecis.Show();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            pContainer.Controls.Clear();
            YakindaVizyon gecis = new YakindaVizyon();
            gecis.TopLevel = false;
            gecis.Dock = DockStyle.Fill;
            this.pContainer.Controls.Add(gecis);
            gecis.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YoneticiGirisEkrani gecis = new YoneticiGirisEkrani();
            gecis.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pContainer.Controls.Clear();
            biletsatisekrani gecis = new biletsatisekrani();
            gecis.TopLevel = false;
            gecis.Dock = DockStyle.Fill;
            this.pContainer.Controls.Add(gecis);
            gecis.Show();
        }
    }
}
