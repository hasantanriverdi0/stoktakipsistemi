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
    public partial class giriss : Form
    {
        Dictionary<string, string> adminler = new Dictionary<string, string>()
        {
            { "admin", "1234" },
            { "yönetici", "admin123" }
        };
        public giriss()
        {
            InitializeComponent();
        }

        private void pnl_giris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_ad.Text.Trim();
            string sifre = txt_sifre.Text.Trim();

            if (adminler.ContainsKey(kullaniciAdi) && adminler[kullaniciAdi] == sifre)
            {
                anasayfa frm = new anasayfa(kullaniciAdi);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
            }
        }

        private void chc_CheckedChanged(object sender, EventArgs e)
        {
            txt_sifre.PasswordChar = chc.Checked ? '\0' : '*';
        }

        private void giriss_Load(object sender, EventArgs e)
        {
            txt_sifre.PasswordChar = '*';
        }
    }
}
