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
    public partial class Filmler : Form
    {
        public Filmler()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pContainer2.Controls.Clear();
            tenet gecis = new tenet();
            gecis.TopLevel = false;
            gecis.Dock = DockStyle.Fill;
            this.pContainer2.Controls.Add(gecis);
            gecis.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pContainer2.Controls.Clear();
            justice gecis = new justice();
            gecis.TopLevel = false;
            gecis.Dock = DockStyle.Fill;
            this.pContainer2.Controls.Add(gecis);
            gecis.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pContainer2.Controls.Clear();
            wonder gecis = new wonder();
            gecis.TopLevel = false;
            gecis.Dock = DockStyle.Fill;
            this.pContainer2.Controls.Add(gecis);
            gecis.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pContainer2.Controls.Clear();
            nomad gecis = new nomad();
            gecis.TopLevel = false;
            gecis.Dock = DockStyle.Fill;
            this.pContainer2.Controls.Add(gecis);
            gecis.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pContainer2.Controls.Clear();
            father gecis = new father();
            gecis.TopLevel = false;
            gecis.Dock = DockStyle.Fill;
            this.pContainer2.Controls.Add(gecis);
            gecis.Show();
        }
    }
}
