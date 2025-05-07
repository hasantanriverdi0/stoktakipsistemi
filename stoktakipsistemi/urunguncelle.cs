using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stoktakipsistemi
{
   
    public partial class urunguncelle : Form
    {
        private int guncellenecekIndex;
        public string adminAd;
        public urunguncelle(int index, string ad, string sayi)
        {
            InitializeComponent();
            guncellenecekIndex = index;
            textBox1.Text = ad;
            textBox2.Text = sayi;
        }

        private void urunguncelle_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            string yeniAd = textBox1.Text.Trim();
            string yeniSayi = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(yeniAd) || string.IsNullOrEmpty(yeniSayi))
            {
                MessageBox.Show("Tüm alanları doldurun.");
                return;
            }

            if (!int.TryParse(yeniSayi, out int sayiInt) || sayiInt <= 0)
            {
                MessageBox.Show("Geçerli bir ürün sayısı girin.");
                return;
            }

            // Ürün numarasını eski veriden çek
            string eskiVeri = veri.urunListesi[guncellenecekIndex];
            string noKismi = eskiVeri.Split('-')[0].Trim(); // "No : 01"

            // Yeni veri oluştur
            string yeniVeri = $"{noKismi} - Ürün Adı : {yeniAd} - Ürün Sayısı : {sayiInt}";

            // Listeyi güncelle
            veri.urunListesi[guncellenecekIndex] = yeniVeri;

            MessageBox.Show("Ürün başarıyla güncellendi.");
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
