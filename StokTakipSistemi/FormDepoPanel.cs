using StokTakipSistemi.Data;
using StokTakipSistemi.Entities;
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
    public partial class FormDepoPanel : Form
    {
        private Kullanici _aktifKullanici;
        public FormDepoPanel(Kullanici _kullanici)
        {
            _aktifKullanici = _kullanici;
            InitializeComponent();
        }

        private void DepoListele(string aranan)
        {
            using (var context = new AppDbContext())
            {
                dgvDepolar.DataSource = context.Depolar.
                    Where(r => r.ad.Contains(aranan))
                    .Select(u => new
                    {
                        Depo_id = u.id,
                        Depo_Adi = u.ad,
                        Lokasyonu = u.lokasyon,
                        Olusturulma_Zamani = u.olusturulma_zamani,
                        Ekleyen_Kullanici = u.olusturan_kullanici != null
                            ? u.olusturan_kullanici.ad + " " + u.olusturan_kullanici.soyad
                            : "-"




                    }
                    ).ToList();
            }


        }

        private void FormDepoPanel_Load(object sender, EventArgs e)
        {
            DepoListele("");

        }

        private void btnDepoEkle_Click(object sender, EventArgs e)
        {
            FormDepoEkle formDepoEkle = new FormDepoEkle(_aktifKullanici);
            formDepoEkle.ShowDialog();

        }

        private void btnDepoYenile_Click(object sender, EventArgs e)
        {
            DepoListele("");
        }
    }
}
