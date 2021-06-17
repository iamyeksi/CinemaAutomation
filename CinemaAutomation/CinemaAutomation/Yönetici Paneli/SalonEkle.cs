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
    public partial class SalonEkle : Form
    {
        public SalonEkle()
        {
            InitializeComponent();
        }
        Sinema_BiletiDataSetTableAdapters.Salon_BilgileriTableAdapter salon = new Sinema_BiletiDataSetTableAdapters.Salon_BilgileriTableAdapter();


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                salon.SalonEkleme(txtSalonAdi.Text);
                MessageBox.Show("Salon Eklendi", "Kayıt");
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Aynı Salonu Daha Önce Eklediniz!!", "Uyarı");
            }
            txtSalonAdi.Text = "";

        }

        private void SalonEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
