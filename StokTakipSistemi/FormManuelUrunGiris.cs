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
                MessageBox.Show("Lütfen ürün kodunu sadece sayılardan oluşacak şekilde girin!", "Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            bool basariliMi = urunService.ManuelUrunGiris(
                TxtUrunKodu.Text.Trim(),
                TxtUrunAdi.Text.Trim(),
                TxtBirim.Text.Trim(),
                kdv_decimal,
                out string gelenmesaj);

            if (basariliMi)
            { 
            
            
            
            }

        }
    }
}
