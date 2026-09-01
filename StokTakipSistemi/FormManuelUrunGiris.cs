using StokTakipSistemi.Entities;
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
    public partial class FormManuelUrunGiris : Form
    {
        
        public FormManuelUrunGiris()
        {
            
            InitializeComponent();
            ApplyCustomStyles();
        }

        private void ApplyCustomStyles()
        {
            pnlCard.Paint += (s, e) => UIHelper.DrawCardBorder(s, e, 14);
            this.Resize += (s, e) => AutoLayoutControls();
            AutoLayoutControls();
            this.AcceptButton = btnUrunGiris;
        }

        private void AutoLayoutControls()
        {
            UIHelper.CenterControl(this, pnlCard, 15);
            UIHelper.SetRoundedRegion(pnlCard, 14);
            UIHelper.SetRoundedRegion(btnUrunGiris, 10);
        }

        private void FormTemizle()
        {
            txtKdv.Clear();
            TxtUrunAdi.Clear();
            TxtUrunKodu.Clear();
            TxtBirim.Clear();
        }

        private void btnUrunGiris_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TxtUrunKodu.Text) || string.IsNullOrWhiteSpace(TxtUrunAdi.Text) ||
                string.IsNullOrWhiteSpace(TxtBirim.Text) || string.IsNullOrWhiteSpace(txtKdv.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var urunService = new UrunService();

            if (!decimal.TryParse(txtKdv.Text.Trim(), out decimal kdv_decimal))
            {
                MessageBox.Show("Lütfen KDV'yi sadece sayılardan oluşacak şekilde girin!", "Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            bool basariliMi = urunService.ManuelUrunGiris(
                TxtUrunKodu.Text.Trim(),
                TxtUrunAdi.Text.Trim(),
                TxtBirim.Text.Trim(),
                Session.AktifKullanici.id,
                kdv_decimal,

                out string gelenMesaj);

            if (basariliMi)
            {
                MessageBox.Show(gelenMesaj, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormTemizle();
                


            }
            else
            {
                MessageBox.Show(gelenMesaj, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormManuelUrunGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
