using StokTakipSistemi.Entities;
using StokTakipSistemi.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipSistemi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {



        }

        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            KayitForm kayitForm = new KayitForm();
            kayitForm.ShowDialog();

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGirisKulAd.Text) || string.IsNullOrWhiteSpace(txtGirisSifre.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var kullaniciService = new KullaniciService();


            bool basariliMi = kullaniciService.GirisYap(
                txtGirisKulAd.Text.Trim(),
                txtGirisSifre.Text.Trim(),
                out string gelenMesaj,
                out Kullanici giris_yapan_kullanici
            );


            if (basariliMi)
            {
                MessageBox.Show(gelenMesaj, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AnaForm anaForm = new AnaForm(giris_yapan_kullanici);
                anaForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show(gelenMesaj, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtGirisSifre.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
