using StokTakipSistemi.Helpers;
using StokTakipSistemi.Services;
using System;
using System.Windows.Forms;

namespace StokTakipSistemi
{
    public partial class FormUrunGuncelle : Form
    {
        private int _guncellenecekUrunId;

        public FormUrunGuncelle()
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
            UIHelper.SetRoundedRegion(btnUrunGuncelleme, 10);
        }

        private void FormUrunGuncelle_Load(object sender, EventArgs e)
        {
        }

        public FormUrunGuncelle(int urunId, string urunKodu, string urunAdi, string birim, decimal kdv) : this()
        {
            _guncellenecekUrunId = urunId;
            txtGUrunKodu.Text = urunKodu;
            txtGUrunAdi.Text = urunAdi;
            txtGBirim.Text = birim;
            txtGKdv.Text = kdv.ToString();
        }

        private void btnUrunGuncelleme_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGUrunKodu.Text) ||
                string.IsNullOrWhiteSpace(txtGUrunAdi.Text) ||
                string.IsNullOrWhiteSpace(txtGBirim.Text) ||
                string.IsNullOrWhiteSpace(txtGKdv.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtGKdv.Text.Trim(), out decimal kdv_decimal))
            {
                MessageBox.Show("Lütfen KDV oranını geçerli bir sayı girin!", "Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var urunService = new UrunService();
            bool basariliMi = urunService.UrunGuncelle(
                _guncellenecekUrunId,
                txtGUrunKodu.Text.Trim(),
                txtGUrunAdi.Text.Trim(),
                txtGBirim.Text.Trim(),
                kdv_decimal,
                out string gelenMesaj);

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
    }
}
