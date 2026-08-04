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
    public partial class FormDepoEkle : Form
    {
        private void FormTemizle()
        {
            txtDepoAd.Clear();
            txtDepoLok.Clear();
        }
        public FormDepoEkle()
        {
            
            InitializeComponent();
        }

        private void FormDepoEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnDepoGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDepoAd.Text) || string.IsNullOrWhiteSpace(txtDepoLok.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var depoService = new DepoService();

            bool gelen = depoService.DepoEkle(txtDepoAd.Text.Trim(), txtDepoLok.Text.Trim(),Session.AktifKullanici.id,out string gelenMesaj);

            if (gelen)
            {
                MessageBox.Show(gelenMesaj, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormDepoPanel form = Application.OpenForms["FormDepoPanel"] as FormDepoPanel;

                if (form != null) { form.DepoListele(""); }
                FormTemizle();

            }
            else
            {
                MessageBox.Show(gelenMesaj, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
