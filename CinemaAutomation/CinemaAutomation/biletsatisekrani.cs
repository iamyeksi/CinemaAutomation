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
    public partial class biletsatisekrani : Form
    {
        public biletsatisekrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=Sinema_Bileti;Integrated Security=True");//sql bağlantısını kurduk.


        int sayac = 0;
        private void FilmVeSalonGetir(ComboBox  combo,string sql1,string sql2)//salon ve film adını comboboxlara yönlendirdik.
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sql1,baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read[sql2].ToString());
            }
            baglanti.Close();


        }

        private void Combo_Dolu_Koltuklar()//dolu koltukları kırmızı renge çevirdik.
        {
            comboKoltukNoIptal.Items.Clear();
            comboKoltukNoIptal.Text = "";
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    if (item.BackColor == Color.Red)
                    {
                        comboKoltukNoIptal.Items.Add(item.Text);
                    }
                }
            }
        }

        private void YenidenRenklendir()
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.White;
                }
            }
        }
        private void VeriTabani_Dolu_Koltuklar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from satis_bilgileri where filmadi='" + comboFilmAdi.SelectedItem + "'and salonadi='" + comboSalonAdi.Text + "'and tarih='" + comboFilmTarihi.SelectedItem + "'and saat='" + comboFilmSeansi.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                foreach (Control item in panel1.Controls)
                {
                    if (item is Button)
                    {
                        if (read["koltukno"].ToString() == item.Text)//veritabanında'ki koltuk butonlara eşit ise işlemi yapsın.
                        {
                            item.BackColor = Color.Red;
                        }
                    }
                }
            }
            baglanti.Close();
        }

        private void Veritabani_Dolu_Koltuklar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from satis_bilgileri where filmadi='"+comboFilmAdi.SelectedItem+"'and salonadi='"+comboSalonAdi.Text+"'and tarih='"+comboFilmTarihi.SelectedItem+"'and saat='"+comboFilmSeansi.SelectedItem+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader(); 
            while (read.Read())
            {
                foreach (Control item in panel1.Controls)
                {
                    if (item is Button)
                    {
                        if (read["koltukno"].ToString()==item.Text)
                        {
                            item.BackColor = Color.Red;

                        }
                    }
                }
            }
            baglanti.Close();
        }

        private void biletsatisekrani_Load(object sender, EventArgs e)
        {
            Boş_Koltuklar();
            FilmVeSalonGetir(comboFilmAdi, "select *from film_bilgileri", "filmadi");
            FilmVeSalonGetir(comboSalonAdi, "select *from salon_bilgileri", "salonadi");
        }

        private void Boş_Koltuklar()//koltuklar ayarları
        {
            sayac = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button btn = new Button();//dinamik button kullanıyoruz.Dinamik button form classında tanımlanan butonlara denir.
                    btn.BackColor = Color.White;
                    btn.Size = new Size(90, 50);
                    btn.Location = new Point(j * 100 + 60, i * 50 + 20);
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    sayac++;
                    this.panel1.Controls.Add(btn);//panele koltukları ekliyoruz.
                    btn.Click += Btn_Click;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)//koltukları tıklayarak seçiyoruz.
        {
            Button b = (Button)sender;
            if (b.BackColor == Color.White)
            {
                txtKoltukNo.Text = b.Text;
            }
        }
        Sinema_BiletiDataSetTableAdapters.Satis_BilgileriTableAdapter satis = new Sinema_BiletiDataSetTableAdapters.Satis_BilgileriTableAdapter();
        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            if (txtKoltukNo.Text!="")
            {
                try
                {
                    satis.Satış_Yap(txtKoltukNo.Text, comboSalonAdi.Text, comboFilmAdi.Text, comboFilmTarihi.Text, comboFilmSeansi.Text, txtAd.Text, txtSoyad.Text, comboUcret.Text, DateTime.Now.ToString());
                    foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                    YenidenRenklendir();
                    VeriTabani_Dolu_Koltuklar();
                    Combo_Dolu_Koltuklar();
                }
                catch (Exception hata)
                {

                    MessageBox.Show("Hata Oluştu!!"+hata.Message, "Uyarı");
                } 
            }
            else
            {
                MessageBox.Show("Koltuk Seçimi Yapmadınız!", "Uyarı");

            }
        }

        private void comboFilmAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboFilmSeansi.Items.Clear();
            comboFilmTarihi.Items.Clear();
            comboSalonAdi.Text = "";
            comboFilmSeansi.Text = "";
            comboSalonAdi.Text = "";
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            YenidenRenklendir();
            Combo_Dolu_Koltuklar();
        }

        private void Film_Tarihi_Getir()
        {
            comboFilmTarihi.Text = "";
            comboFilmSeansi.Text = "";
            comboFilmTarihi.Items.Clear();
            comboFilmSeansi.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from seans_bilgileri where filmadi='"+comboFilmAdi.SelectedItem+"'and salonadi='"+comboSalonAdi.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (DateTime.Parse(read["tarih"].ToString()) >= DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (!comboFilmTarihi.Items.Contains(read["tarih"].ToString()))
                    {
                        comboFilmTarihi.Items.Add(read["tarih"].ToString());

                    }

                }
            }
            baglanti.Close();
        }

        private void comboSalonAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film_Tarihi_Getir();
        }

        private void Film_Seansi_Getir()
        {
            comboFilmSeansi.Text = "";
            comboFilmSeansi.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from seans_bilgileri where filmadi='" + comboFilmAdi.SelectedItem + "'and salonadi='" + comboSalonAdi.SelectedItem + "'and tarih='"+comboFilmTarihi.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (DateTime.Parse(read["tarih"].ToString()) == DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (DateTime.Parse(read["seans"].ToString())>DateTime.Parse(DateTime.Now.ToShortTimeString()))
                    {
                        comboFilmSeansi.Items.Add(read["seans"].ToString());

                    }

                }
               else if (DateTime.Parse(read["tarih"].ToString()) > DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                  comboFilmSeansi.Items.Add(read["seans"].ToString());

                }
            }
            baglanti.Close();

        }

        private void comboFilmTarihi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film_Seansi_Getir();
        }

        private void comboFilmSeansi_SelectedIndexChanged(object sender, EventArgs e)
        {
            YenidenRenklendir();
            VeriTabani_Dolu_Koltuklar();
            Combo_Dolu_Koltuklar();
        }

        private void btnBiletIptal_Click(object sender, EventArgs e)
        {
            if (comboKoltukNoIptal.Text!="")
            {
                try
                {
                    satis.Satış_İptal(comboFilmAdi.Text, comboSalonAdi.Text, comboFilmTarihi.Text, comboFilmSeansi.Text, comboKoltukNoIptal.Text);
                    YenidenRenklendir();
                    Veritabani_Dolu_Koltuklar();
                    Combo_Dolu_Koltuklar();
                }
                catch (Exception hata)
                {

                    MessageBox.Show("Hata Oluştu!!"+hata.Message, "Uyarı");
                }

            }
            else
            {
                MessageBox.Show("Koltuk Seçimi Yapmadınız!!", "Uyarı");

            }
        }
    }
}