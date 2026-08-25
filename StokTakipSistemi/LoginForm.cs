using StokTakipSistemi.Entities;
using StokTakipSistemi.Services;
using System;
using System.Drawing;
using StokTakipSistemi.Helpers;
using System.Windows.Forms;

namespace StokTakipSistemi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ApplyCustomStyles();
        }

        private void ApplyCustomStyles()
        {
            pnlLoginCard.Paint += (s, e) => UIHelper.DrawCardBorder(s, e, 14);
            this.Resize += (s, e) => AutoLayoutControls();
            AutoLayoutControls();
        }

        private void AutoLayoutControls()
        {
            UIHelper.CenterControl(this, pnlLoginCard, 15);
            UIHelper.SetRoundedRegion(pnlLoginCard, 14);
            UIHelper.SetRoundedRegion(BtnGiris, 8);
            UIHelper.SetRoundedRegion(BtnKayitOl, 8);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lblFooter.Text = $"© {DateTime.Now.Year} Dalaman Belediyesi";
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

                Session.AktifKullanici = giris_yapan_kullanici;
                this.Hide();

                AnaForm anaForm = new AnaForm();
                anaForm.ShowDialog();

                this.Show();

                txtGirisKulAd.Clear();
                txtGirisSifre.Clear();




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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
