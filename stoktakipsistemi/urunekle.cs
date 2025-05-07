using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stoktakipsistemi
{
    public partial class urunekle : Form
    {
        public string adminAd;
        public urunekle()
        {
            InitializeComponent();
        }

        private void urunekle_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            string ad = txt_ad.Text.Trim();
            string sayi = txt_sayi.Text.Trim();

            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(sayi))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            if (!int.TryParse(sayi, out int adet) || adet <= 0)
            {
                MessageBox.Show("Geçerli bir ürün sayısı girin.");
                return;
            }

            string urun = $"No : {veri.urunNo.ToString("D2")} - Ürün Adı : {ad} - Ürün Sayısı : {adet}";
            veri.urunListesi.Add(urun);
            veri.urunNo++;

            MessageBox.Show("Ürün başarıyla eklendi.");
            this.Close();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa(adminAd);
            anasayfa.Show();
            this.Hide();
        }
    }
}
