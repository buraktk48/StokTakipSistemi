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
            UIHelper.SetRoundedRegion(btnDepoGiris, 10);
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
