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
    public partial class anasayfa : Form
    {
        private string adminAd;

        public anasayfa(string adminAd)
        {
            InitializeComponent();
            this.adminAd = adminAd;
            label1.Text = $"Hoş Geldin {adminAd}";
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            ListeyiGuncelle();
        }

        private void ListeyiGuncelle()
        {
            listBox1.Items.Clear();
            int toplamStok = 0;

            foreach (var urun in veri.urunListesi)
            {
                listBox1.Items.Add(urun);

                // Ürün Sayısı kısmını ayıkla ve topla
                string[] parcalar = urun.Split('-');
                if (parcalar.Length >= 3)
                {
                    string sayiStr = parcalar[2].Replace("Ürün Sayısı :", "").Trim();
                    if (int.TryParse(sayiStr, out int sayi))
                    {
                        toplamStok += sayi;
                    }
                }
            }

            // label2: Toplam ürün adedi
            label2.Text = $"Toplam Ürün Sayısı: {listBox1.Items.Count}";

            // label3: Toplam stok miktarı
            label3.Text = $"Toplam Stok Adedi: {toplamStok}";
        }

        private void pnl_ekle_Click(object sender, EventArgs e)
        {
            urunekle ekleForm = new urunekle();
            ekleForm.adminAd = this.adminAd;
            ekleForm.FormClosed += (s, args) => { this.Show(); ListeyiGuncelle(); };
            ekleForm.Show();
            this.Hide();
        }

        private void pnl_sil_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen silinecek bir ürün seçin.");
                return;
            }

            string secilen = listBox1.SelectedItem.ToString();
            veri.urunListesi.Remove(secilen);
            listBox1.Items.Remove(secilen);
            MessageBox.Show("Ürün başarıyla silindi.");
            ListeyiGuncelle();
        }

        private void pnl_guncelle_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen güncellenecek bir ürün seçin.");
                return;
            }

            string secilen = listBox1.SelectedItem.ToString();
            int secilenIndex = listBox1.SelectedIndex;

            string[] parcalar = secilen.Split('-');
            string urunAd = parcalar[1].Replace("Ürün Adı :", "").Trim();
            string urunSayi = parcalar[2].Replace("Ürün Sayısı :", "").Trim();

            urunguncelle frm = new urunguncelle(secilenIndex, urunAd, urunSayi);
            frm.adminAd = this.adminAd;
            frm.FormClosed += (s, args) => { this.Show(); ListeyiGuncelle(); };
            frm.Show();
            this.Hide();
        }

        private void pnl_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
