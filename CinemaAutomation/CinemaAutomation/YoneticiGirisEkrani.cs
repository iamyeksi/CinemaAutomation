using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CinemaAutomation
{
    public partial class YoneticiGirisEkrani : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        public YoneticiGirisEkrani()
        {
            InitializeComponent();
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            Anasayfa gecis = new Anasayfa();
            gecis.Show();
            this.Hide();
        }

        private void txtkullaniciadi_Click(object sender, EventArgs e)
        {
            txtkullaniciadi.Text = "";
        }

        private void txtparola_Click(object sender, EventArgs e)
        {
            txtparola.Text = "";
        }

        private void btnkullanicigiris_Click(object sender, EventArgs e)
        {
            string user = txtkullaniciadi.Text;
            string password = txtparola.Text;
            con = new SqlConnection("Data Source=localhost;Initial Catalog=Sinema_Bileti;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select *From Kullanici_Bilgi where kullanici_adi='" + txtkullaniciadi.Text + "'And sifre='"+txtparola.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı");
                YoneticiPaneli gecis = new YoneticiPaneli();
                gecis.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre");
            }
            con.Close();
        }

        private void YoneticiGirisEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
