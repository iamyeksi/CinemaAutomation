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
    public partial class YoneticiPaneli : Form
    {
        public YoneticiPaneli()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Anasayfa gecis = new Anasayfa();
            gecis.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pContainer3.Controls.Clear();
            SalonEkle gecis = new SalonEkle();
            gecis.TopLevel = false;
            gecis.Dock = DockStyle.Fill;
            this.pContainer3.Controls.Add(gecis);
            gecis.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pContainer3.Controls.Clear();
            FilmEklemeSayfasi gecis = new FilmEklemeSayfasi();
            gecis.TopLevel = false;
            gecis.Dock = DockStyle.Fill;
            this.pContainer3.Controls.Add(gecis);
            gecis.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pContainer3.Controls.Clear();
            SeansEkleme gecis = new SeansEkleme();
            gecis.TopLevel = false;
            gecis.Dock = DockStyle.Fill;
            this.pContainer3.Controls.Add(gecis);
            gecis.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pContainer3.Controls.Clear();
            SeansListele gecis = new SeansListele();
            gecis.TopLevel = false;
            this.pContainer3.Controls.Add(gecis);
            gecis.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pContainer3.Controls.Clear();
            SatisListesi gecis = new SatisListesi();
            gecis.TopLevel = false;
            this.pContainer3.Controls.Add(gecis);
            gecis.Show();
        }

        private void YoneticiPaneli_Load(object sender, EventArgs e)
        {

        }
    }
}
