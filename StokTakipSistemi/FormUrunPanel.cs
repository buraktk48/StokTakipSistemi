using ClosedXML.Excel;
using StokTakipSistemi.Data;
using StokTakipSistemi.Entities;
using StokTakipSistemi.Migrations;
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
    public partial class FormUrunPanel : Form
    {
        private Kullanici _aktifKullanici;
        public FormUrunPanel(Kullanici _kullanici)
        {
            _aktifKullanici = _kullanici;
            InitializeComponent();
        }

        private void UrunListele(string aranan)
        {
            using (var context = new AppDbContext())
            {

                dgvUrunler.DataSource = context.Urunler
                    .Where(r => r.urun_adi.Contains(aranan) || r.urun_kodu.Contains(aranan))
                    .Select(u => new
                    {
                        id = u.id,
                        Urun_Kodu = u.urun_kodu,
                        Urun_Adi = u.urun_adi,
                        Birim = u.birim,
                        KDV = u.kdv,
                        Tarih = u.olusturulma_zamani,
                        Ekleyen_Kullanici = u.ekleyen_kullanici != null
                            ? u.ekleyen_kullanici.ad + " " + u.ekleyen_kullanici.soyad
                            : "-"
                    })
                    .ToList();
            }
        }

        private void FormUrunListe_Load(object sender, EventArgs e)
        {
            UrunListele("");
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            UrunListele(txtAra.Text.Trim());
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            FormManuelUrunGiris formManuelUrunGiris = new FormManuelUrunGiris(_aktifKullanici);
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
            FormExcelUrunEkle formExcelUrunEkle = new FormExcelUrunEkle(_aktifKullanici);
            formExcelUrunEkle.ShowDialog();


            

            


        }
    }
}
