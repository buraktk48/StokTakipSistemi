using Microsoft.EntityFrameworkCore;
using StokTakipSistemi.Data;
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
    public partial class FormDepoPanel : Form
    {
        public FormDepoPanel()
        {

            InitializeComponent();

            AramaZamanlayici.AramaSinirlayici(txtDepoAra, (aranan) =>
            {
                suanki_sayfa = 1;
                DepoListele(aranan);

            });






        }

        private int sayfa_boyutu = 10;
        private int suanki_sayfa = 1;
        private int toplam_sayfa_sayisi = 1;


        public async void DepoListele(string aranan)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    //Buralarda await yazılmamasının sebebi ortada sorgu hazırlanıyor sql ile ilgili bir şey yok

                    var sorgu = context.Depolar
                        .AsNoTracking()
                        .Where(r => r.ad.Contains(aranan));

                    int toplam_kayit = await sorgu.CountAsync();

                    toplam_sayfa_sayisi = (int)Math.Ceiling(toplam_kayit / (double)sayfa_boyutu);

                    if (toplam_sayfa_sayisi == 0) toplam_sayfa_sayisi = 1;


                    if (suanki_sayfa > toplam_sayfa_sayisi) suanki_sayfa = 1;



                    dgvDepolar.DataSource = await sorgu
                    .OrderByDescending(u => u.id)
                    .Skip((suanki_sayfa - 1) * sayfa_boyutu)
                    .Take(sayfa_boyutu)
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

                    if (dgvDepolar.Columns["Depo_id"]!=null)
                    {
                        dgvDepolar.Columns["Depo_id"].Visible = false;
                    }

                    dgvDepolar.Columns["Depo_Adi"].HeaderText = "Depo Adı";
                    dgvDepolar.Columns["Ekleyen_Kullanici"].HeaderText = "Ekleyen Kullanıcı";
                    dgvDepolar.Columns["Olusturulma_Zamani"].HeaderText = "Oluşturulma Zamanı";


                    lblSayfa.Text = $"Sayfa {suanki_sayfa} / {toplam_sayfa_sayisi} (Toplam Kayıt: {toplam_kayit})";

                    btnOnceki.Enabled = suanki_sayfa > 1;
                    btnSonraki.Enabled = suanki_sayfa < toplam_sayfa_sayisi;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void FormDepoPanel_Load(object sender, EventArgs e)
        {
            UIHelper.ModernizeDataGridView(dgvDepolar);
            DepoListele("");
        }

        private void btnDepoEkle_Click(object sender, EventArgs e)
        {
            FormDepoEkle formDepoEkle = new FormDepoEkle();
            formDepoEkle.ShowDialog();

            DepoListele(txtDepoAra.Text.Trim());

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

            DepoListele(txtDepoAra.Text.Trim());
        }

        private void btnDepoSil_Click(object sender, EventArgs e)
        {
            if (dgvDepolar.CurrentRow ==null)
            {
                MessageBox.Show("Lütfen silmek istediğiniz depoyu tablodan seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int depoId = Convert.ToInt32(dgvDepolar.CurrentRow.Cells["Depo_id"].Value?.ToString() ?? "0");

            DialogResult sonuc = MessageBox.Show("Bu depoyu silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.No)
                return;

            var depoService = new DepoService();

            bool basariliMi = depoService.DepoSil(depoId, out string gelenMesaj);

            if (basariliMi)
            {
                MessageBox.Show(gelenMesaj, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show(gelenMesaj, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DepoListele(txtDepoAra.Text.Trim());

        }

        

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            if (suanki_sayfa < toplam_sayfa_sayisi)
            {
                suanki_sayfa++;
                DepoListele(txtDepoAra.Text.Trim());
            }

        }

        private void btnOnceki_Click(object sender, EventArgs e)
        {
            if (suanki_sayfa > 1)
            {
                suanki_sayfa--;
                DepoListele(txtDepoAra.Text.Trim());
            }

        }

        private void btnSonSayfa_Click(object sender, EventArgs e)
        {
            suanki_sayfa = toplam_sayfa_sayisi;

            DepoListele(txtDepoAra.Text.Trim());

        }

        private void btnIlkSayfa_Click(object sender, EventArgs e)
        {
            suanki_sayfa = 1;
            DepoListele(txtDepoAra.Text.Trim());
        }
    }
}
