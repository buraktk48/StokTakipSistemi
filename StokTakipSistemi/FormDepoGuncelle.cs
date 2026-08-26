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
    public partial class FormDepoGuncelle : Form
    {
        private int _guncellenecekUrunId;
        public FormDepoGuncelle()
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
            UIHelper.SetRoundedRegion(btnDepoGuncelle, 10);
        }


        public FormDepoGuncelle(int depoid, string ad, string lokasyon) : this()
        {
            _guncellenecekUrunId = depoid;
            txtGDepoAd.Text = ad;
            txtGDepoLok.Text = lokasyon;

        }

        private void btnDepoGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGDepoAd.Text) || string.IsNullOrEmpty(txtGDepoLok.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var depoService = new DepoService();

            bool basariliMi = depoService.DepoGuncelle(
                _guncellenecekUrunId,
                txtGDepoAd.Text.Trim(),
                txtGDepoLok.Text.Trim(), out string gelenMesaj);


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

        private void FormDepoGuncelle_Load(object sender, EventArgs e)
        {

        }
    }
}
