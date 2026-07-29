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
    public partial class FormUrunPanel : Form
    {
        private Kullanici _aktifKullanici;
        public FormUrunPanel(Kullanici _kullanici)
        {
            _aktifKullanici = _kullanici;
            InitializeComponent();
        }

        private void UrunListele()
        {
            using (var context = new AppDbContext())
            {
                dgvUrunler.DataSource = context.Urunler
                    .Select(u => new
                    {
                        ID = u.id,
                        Ürün_Kodu = u.urun_kodu,
                        Ürün_Adı = u.urun_adi,
                        Birim = u.birim,
                        KDV = u.kdv,
                        Tarih = u.olusturulma_zamani,
                        Ekleyen_Kullanıcı = u.ekleyen_kullanici != null
                            ? u.ekleyen_kullanici.ad + " " + u.ekleyen_kullanici.soyad
                            : "-"
                    })
                    .ToList();
            }
        }

        private void FormUrunListe_Load(object sender, EventArgs e)
        {
            UrunListele();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                string aranan = txtAra.Text.Trim();

                var sonuc = context.Urunler.Where(r => r.urun_adi.Contains(aranan) || r.urun_kodu.Contains(aranan)).ToList();

                dgvUrunler.DataSource = sonuc;

            }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            FormManuelUrunGiris formManuelUrunGiris = new FormManuelUrunGiris(_aktifKullanici);
            formManuelUrunGiris.ShowDialog();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            txtAra.Clear();
            UrunListele();
        }
    }
}
