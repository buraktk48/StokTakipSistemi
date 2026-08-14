using Microsoft.EntityFrameworkCore;
using StokTakipSistemi.Data;
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
    public partial class FormDepoPanel : Form
    {
        public FormDepoPanel()
        {
            
            InitializeComponent();
        }

        public async void DepoListele(string aranan)
        {
            try
            {
            using (var context = new AppDbContext())
            {
                dgvDepolar.DataSource = await context.Depolar
                    .AsNoTracking()
                    .Where(r => r.ad.Contains(aranan))
                    .Select(u => new
                    {
                        Depo_id = u.id,
                        Depo_Adi = u.ad,
                        Lokasyonu = u.lokasyon,
                        Ekleyen_Kullanici = u.olusturan_kullanici != null
                            ? u.olusturan_kullanici.ad + " " + u.olusturan_kullanici.soyad
                            : "-",
                        Olusturulma_Zamani = u.olusturulma_zamani,



                    }
                    ).ToListAsync();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void FormDepoPanel_Load(object sender, EventArgs e)
        {
            DepoListele("");

        }

        private void btnDepoEkle_Click(object sender, EventArgs e)
        {
            FormDepoEkle formDepoEkle = new FormDepoEkle();
            formDepoEkle.ShowDialog();

        }

        private void btnDepoYenile_Click(object sender, EventArgs e)
        {
            DepoListele("");
        }

        private void btnDepoGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvDepolar.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz depoyu tablodan seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int depoId = Convert.ToInt32(dgvDepolar.CurrentRow.Cells["Depo_id"].Value?.ToString() ?? "0");
            string depoad = dgvDepolar.CurrentRow.Cells["Depo_Adi"].Value?.ToString() ?? "";
            string lokasyon = dgvDepolar.CurrentRow.Cells["Lokasyonu"].Value?.ToString() ?? "";

            FormDepoGuncelle formDepoGuncelle = new FormDepoGuncelle(depoId, depoad, lokasyon);
            formDepoGuncelle.ShowDialog();
        }

        private void btnDepoSil_Click(object sender, EventArgs e)
        {
            int urunId = Convert.ToInt32(dgvDepolar.CurrentRow.Cells["Depo_id"].Value?.ToString() ?? "0");

            DialogResult sonuc = MessageBox.Show("Bu depoyu silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.No)
                return;

            var depoService = new DepoService();

            bool basariliMi = depoService.DepoSil(urunId, out string gelenMesaj);

            if (basariliMi)
            {
                MessageBox.Show(gelenMesaj, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show(gelenMesaj, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtDepoAra_TextChanged(object sender, EventArgs e)
        {
            DepoListele(txtDepoAra.Text.Trim());
        }
    }
}
