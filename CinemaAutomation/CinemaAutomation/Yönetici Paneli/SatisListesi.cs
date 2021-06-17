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
    public partial class SatisListesi : Form
    {
        public SatisListesi()
        {
            InitializeComponent();
        }
        Sinema_BiletiDataSetTableAdapters.Satis_BilgileriTableAdapter satislistesi = new Sinema_BiletiDataSetTableAdapters.Satis_BilgileriTableAdapter();

        private void SatisListesi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = satislistesi.TariheGoreListele2(dateTimePicker1.Text);
            ToplamUcretHesapla();
        }

        private void ToplamUcretHesapla()
        {
            int ucrettoplami = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                ucrettoplami += Convert.ToInt32(dataGridView1.Rows[i].Cells["ucret"].Value);

            }
            tarihegorelabel.Text = "Toplam Satış= " + ucrettoplami + "TL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = satislistesi.SatışListesi2();
            ToplamUcretHesapla();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = satislistesi.TariheGoreListele2(dateTimePicker1.Text);
            ToplamUcretHesapla();
        }
    }
}
