using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaAutomation
{
    public partial class SeansEkleme : Form
    {
        public SeansEkleme()
        {
            InitializeComponent();
        }
        Sinema_BiletiDataSetTableAdapters.Seans_BilgileriTableAdapter filmseansi = new Sinema_BiletiDataSetTableAdapters.Seans_BilgileriTableAdapter();
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=Sinema_Bileti;Integrated Security=True");

        private void FilmVeSalonGoster(ComboBox combo, string sql, string sql2)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sql, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read()==true)
            {
                combo.Items.Add(read[sql2].ToString());
            }
            baglanti.Close();
        }
        
        string seans = "";
        private void RadioButtonSeçiliyse()
        {
            if (seans1.Checked == true) seans = seans1.Text;
            else if (seans2.Checked == true) seans = seans2.Text;
            else if (seans3.Checked == true) seans = seans3.Text;
            else if (seans4.Checked == true) seans = seans4.Text;
            else if (seans5.Checked == true) seans = seans5.Text;
            else if (seans6.Checked == true) seans = seans6.Text;
            else if (seans7.Checked == true) seans = seans7.Text;
            else if (seans8.Checked == true) seans = seans8.Text;
            else if (seans9.Checked == true) seans = seans9.Text;
            else if (seans10.Checked == true) seans = seans10.Text;
            else if (seans11.Checked == true) seans = seans11.Text;
            else if (seans12.Checked == true) seans = seans12.Text;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            RadioButtonSeçiliyse();
            if (seans!="")
            {
                filmseansi.SeansEkleme(comboFilm.Text,comboSalon.Text,dateTimePicker1.Text,seans);
                MessageBox.Show("Seans Ekleme işlemi yapıldı!", "Kayıt");
            }
            else if (seans=="")
            {
                MessageBox.Show("Seans Seçimi Yapmadınız!!", "Uyarı");
            }
            comboSalon.Text = "";
            comboFilm.Text = "";
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
        }

        private void SeansEkleme_Load(object sender, EventArgs e)
        {
            FilmVeSalonGoster(comboFilm, "select *from  film_bilgileri", "filmadi");
            FilmVeSalonGoster(comboSalon, "select *from  salon_bilgileri", "salonadi");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            foreach (Control item3 in groupBox1.Controls)
            {
                item3.Enabled = true;
            }
            
            
            DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime yeni = DateTime.Parse(dateTimePicker1.Text);
            if (yeni == bugün)
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (DateTime.Parse(DateTime.Now.ToShortTimeString()) > DateTime.Parse(item.Text))
                    {
                        item.Enabled = false;
                    }
                }
                Tarihi_Karşılaştır();
            }
            else if (yeni>bugün)
            {
                Tarihi_Karşılaştır();
            }
            else if (yeni<bugün)
            {
                MessageBox.Show("Geriye dönük işlem yapılamaz!", "Uyarı");
                dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void Tarihi_Karşılaştır()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from seans_bilgileri where salonadi='" + comboSalon.Text + "'and tarih='" + dateTimePicker1.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read() == true)
            {
                foreach (Control item2 in groupBox1.Controls)
                {
                    if (read["seans"].ToString() == item2.Text)
                    {
                        item2.Enabled = false;
                    }
                }
            }
            baglanti.Close();
        }

        private void comboSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
        }
    }
}
