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
    public partial class FilmEklemeSayfasi : Form
    {
        public FilmEklemeSayfasi()
        {
            InitializeComponent();
        }
        Sinema_BiletiDataSetTableAdapters.Film_BilgileriTableAdapter film = new Sinema_BiletiDataSetTableAdapters.Film_BilgileriTableAdapter();

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            try
            {
                film.FilmEkleme(txtFilmAdi.Text, txtYonetmen.Text, comboFilmTuru.Text, txtSure.Text, dateTimePicker1.Text, txtYapimYili.Text);
                MessageBox.Show("Film Bilgileri Eklendi", "Kayıt");
            }
            catch (Exception)
            {

                MessageBox.Show("Bu film daha önce eklendi!!", "Uyarı");
            }
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            comboFilmTuru.Text = "";
        }

        private void FilmEklemeSayfasi_Load(object sender, EventArgs e)
        {

        }
    }
}
