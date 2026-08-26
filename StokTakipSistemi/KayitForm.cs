using StokTakipSistemi.Helpers;
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
    public partial class KayitForm : Form
    {
        public KayitForm()
        {
            InitializeComponent();
            ApplyCustomStyles();
        }

        private void ApplyCustomStyles()
        {
            pnlCard.Paint += (s, e) => UIHelper.DrawCardBorder(s, e, 14);
            this.Resize += (s, e) => AutoLayoutControls();
            AutoLayoutControls();
        }

        private void AutoLayoutControls()
        {
            UIHelper.CenterControl(this, pnlCard, 15);
            UIHelper.SetRoundedRegion(pnlCard, 14);
            UIHelper.SetRoundedRegion(BtnKayitOnayla, 10);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnKayitOnayla_Click(object sender, EventArgs e)
        {
            //IsNullOrWhiteSpace "    " gibi boşluklu ifadeleri de yakalar.
            if (string.IsNullOrWhiteSpace(AdTxtBox.Text) || string.IsNullOrWhiteSpace(KulAdTxtBox.Text) ||
                string.IsNullOrWhiteSpace(SifTxtBox.Text) || string.IsNullOrWhiteSpace(SoyadTxtBox.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var kullaniciService = new KullaniciService();

            // İşi servise devrediyoruz
            bool basariliMi = kullaniciService.KayitOl(
                KulAdTxtBox.Text.Trim(),
                SifTxtBox.Text.Trim(),
                AdTxtBox.Text.Trim(),
                SoyadTxtBox.Text.Trim(),
                out string gelenMesaj
            );

            if (basariliMi)
            {
                MessageBox.Show(gelenMesaj, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(gelenMesaj, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            SifTxtBox.UseSystemPasswordChar = !chkSifreGoster.Checked;
        }

        private void KayitForm_Load(object sender, EventArgs e)
        {

        }

        private void AdTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
