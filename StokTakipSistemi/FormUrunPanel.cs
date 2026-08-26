using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using StokTakipSistemi.Data;
using StokTakipSistemi.Entities;
using StokTakipSistemi.Helpers;
using StokTakipSistemi.Services;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace StokTakipSistemi
{
    public partial class FormUrunPanel : Form
    {
        public FormUrunPanel()
        {
            InitializeComponent();
            ApplyCustomStyles();

            AramaZamanlayici.AramaSinirlayici(txtAra, (aranan) =>
            {
                suanki_sayfa = 1;
                UrunListele(aranan);
            });
        }

        private void ApplyCustomStyles()
        {
            this.Resize += (s, e) => AutoLayoutControls();
            AutoLayoutControls();
        }

        private void AutoLayoutControls()
        {
            if (this.ClientSize.Width <= 0) return;

            // Sayfalama grubunu ortalama
            groupBox3.Left = (this.ClientSize.Width - groupBox3.Width) / 2;

            // Alt aksiyon butonlarının ovalleştirilmesi
            UIHelper.SetRoundedRegion(btnUrunEkle, 8);
            UIHelper.SetRoundedRegion(btnExcelEkle, 8);
            UIHelper.SetRoundedRegion(btnUrunGuncelle, 8);
            UIHelper.SetRoundedRegion(btnUrunSil, 8);
            UIHelper.SetRoundedRegion(btnUrunYenile, 8);

            UIHelper.SetRoundedRegion(btnIlkSayfa, 6);
            UIHelper.SetRoundedRegion(btnOnceki, 6);
            UIHelper.SetRoundedRegion(btnSonraki, 6);
            UIHelper.SetRoundedRegion(btnSonSayfa, 6);
        }

        private int sayfa_boyutu = 10;
        private int suanki_sayfa = 1;
        private int toplam_sayfa_sayisi = 1;

        public async void UrunListele(string aranan)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var sorgu = context.Urunler
                    .AsNoTracking()
                    .Where(r => r.urun_adi.Contains(aranan) || r.urun_kodu.Contains(aranan));

                    int toplam_kayit = await sorgu.CountAsync();

                    toplam_sayfa_sayisi = (int)Math.Ceiling(toplam_kayit / (double)sayfa_boyutu);

                    if (toplam_sayfa_sayisi == 0) toplam_sayfa_sayisi = 1;


                    if (suanki_sayfa > toplam_sayfa_sayisi)
                        suanki_sayfa = 1;


                    dgvUrunler.DataSource = await sorgu
                        .OrderByDescending(u => u.id)
                        .Skip((suanki_sayfa - 1) * sayfa_boyutu)
                        .Take(sayfa_boyutu)
                        .Select(u => new
                        {
                            id = u.id,
                            Urun_Kodu = u.urun_kodu,
                            Urun_Adi = u.urun_adi,
                            Birim = u.birim,
                            KDV = u.kdv,
                            Ekleyen_Kullanici = u.ekleyen_kullanici != null
                                ? u.ekleyen_kullanici.ad + " " + u.ekleyen_kullanici.soyad
                                : "-",
                            Olusturulma_Zamani = u.olusturulma_zamani
                        })
                        .ToListAsync();

                    lblSayfa.Text = $"Sayfa {suanki_sayfa} / {toplam_sayfa_sayisi} (Toplam Kayıt: {toplam_kayit})";

                    btnOnceki.Enabled = suanki_sayfa > 1;
                    btnSonraki.Enabled = suanki_sayfa < toplam_sayfa_sayisi;
                }

                if (dgvUrunler.Columns["id"] != null)
                {
                    dgvUrunler.Columns["id"].Visible = false;
                }

                dgvUrunler.Columns["Urun_Kodu"].HeaderText = "Ürün Kodu";
                dgvUrunler.Columns["Urun_Adi"].HeaderText = "Ürün Adı";
                dgvUrunler.Columns["Birim"].HeaderText = "Birim";
                dgvUrunler.Columns["KDV"].HeaderText = "KDV (%)";
                dgvUrunler.Columns["Ekleyen_Kullanici"].HeaderText = "Ekleyen Kullanıcı";
                dgvUrunler.Columns["Olusturulma_Zamani"].HeaderText = "Oluşturulma Zamanı";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormUrunListe_Load(object sender, EventArgs e)
        {
            UIHelper.ModernizeDataGridView(dgvUrunler);
            lblFooter.Text = $"© {DateTime.Now.Year} Dalaman Belediyesi";
            UrunListele("");
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            FormManuelUrunGiris formManuelUrunGiris = new FormManuelUrunGiris();
            formManuelUrunGiris.ShowDialog();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            txtAra.Clear();
            UrunListele("");
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz ürünü tablodan seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int urunId = Convert.ToInt32(dgvUrunler.CurrentRow.Cells["id"].Value?.ToString() ?? "0");
            string urunKodu = dgvUrunler.CurrentRow.Cells["Urun_Kodu"].Value?.ToString() ?? "";
            string urunAdi = dgvUrunler.CurrentRow.Cells["Urun_Adi"].Value?.ToString() ?? "";
            string birim = dgvUrunler.CurrentRow.Cells["Birim"].Value?.ToString() ?? "";
            decimal kdv = Convert.ToDecimal(dgvUrunler.CurrentRow.Cells["KDV"].Value?.ToString() ?? "0");

            FormUrunGuncelle formGuncelle = new FormUrunGuncelle(urunId, urunKodu, urunAdi, birim, kdv);
            formGuncelle.ShowDialog();


        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            int urunId = Convert.ToInt32(dgvUrunler.CurrentRow.Cells["ID"].Value?.ToString() ?? "0");

            DialogResult sonuc = MessageBox.Show("Bu ürünü silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.No)
                return;

            var urunservice = new UrunService();

            bool gelen = urunservice.UrunSilme(urunId, out string gelenMesaj);


            if (gelen)
            {
                MessageBox.Show(gelenMesaj, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show(gelenMesaj, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnExcelEkle_Click(object sender, EventArgs e)
        {
            FormExcelUrunEkle formExcelUrunEkle = new FormExcelUrunEkle();
            formExcelUrunEkle.ShowDialog();







        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            if (suanki_sayfa < toplam_sayfa_sayisi)
            {
                suanki_sayfa++;
                UrunListele(txtAra.Text.Trim());
            }
        }

        private void btnOnceki_Click(object sender, EventArgs e)
        {
            if (suanki_sayfa > 1)
            {
                suanki_sayfa--;
                UrunListele(txtAra.Text.Trim());
            }
        }

        private void btnSonSayfa_Click(object sender, EventArgs e)
        {
            suanki_sayfa = toplam_sayfa_sayisi;
            UrunListele(txtAra.Text.Trim());


        }

        private void btnIlkSayfa_Click(object sender, EventArgs e)
        {
            suanki_sayfa = 1;
            UrunListele(txtAra.Text.Trim());

        }
    }
}
