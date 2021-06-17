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
    public partial class YakindaVizyon : Form
    {
        public YakindaVizyon()
        {
            InitializeComponent();
        }
        private int ImageNumber = 1;

        private void LoadNextImage()
        {
            timer1.Start();
            ImageNumber++;
            if (ImageNumber > 3)
            {
                ImageNumber = 1;
            }
            pictureBox8.ImageLocation = string.Format(@"C:\Users\adimn\source\repos\CinemaAutomation\CinemaAutomation\Images\" + ImageNumber + ".jpg");
        }
        private void LoadPreviousImage()
        {
            timer1.Start();
            ImageNumber++;
            if (ImageNumber < 1)
            {
                ImageNumber = 3;
            }
            pictureBox8.ImageLocation = string.Format(@"C:\Users\admin\source\repos\CinemaAutomation\CinemaAutomation\Images\" + ImageNumber + ".jpeg");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();

        }

        private void boxGeri_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            LoadNextImage();
        }

        private void boxIleri_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            LoadNextImage();
        }
        private void YakindaVizyon_Load(object sender, EventArgs e)
        {
            pictureBox8.ImageLocation = string.Format(@"C:\Users\admin\source\repos\CinemaAutomation\CinemaAutomation\Images\" + ImageNumber + ".jpg");
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=O3qAEZ-BstU");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=4OYOTfHMJG0");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=uhs8g_hYvwY");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=SI_6CR-xcVI");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=ZQ_8TX9fyjQ");
        }

  
    }
}
