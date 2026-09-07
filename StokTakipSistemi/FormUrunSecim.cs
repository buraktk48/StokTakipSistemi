using Microsoft.EntityFrameworkCore;
using StokTakipSistemi.Data;
using StokTakipSistemi.Helpers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StokTakipSistemi
{
    public partial class FormUrunSecim : Form
    {
        public FormUrunSecim()
        {
            InitializeComponent();
            ApplyCustomStyles();

            AramaZamanlayici.AramaSinirlayici(txtAra, (aranan) =>
            {
                suanki_sayfa = 1;
                UrunleriListele(aranan);

            });


        }

        private int sayfa_boyutu = 10;
        private int suanki_sayfa = 1;
        private int toplam_sayfa_sayisi = 1;




        public async void UrunleriListele(string aranan)
        {
            using (var context = new AppDbContext())
            {
                //Buralarda await yazılmamasının sebebi ortada sorgu hazırlanıyor sql ile ilgili bir şey yok

                var sorgu = context.Urunler
                        .AsNoTracking()
                        .Where(r => r.urun_adi.Contains(aranan) || r.urun_kodu.Contains(aranan));

                int toplam_kayit = await sorgu.CountAsync();

                toplam_sayfa_sayisi = (int)Math.Ceiling(toplam_kayit / (double)sayfa_boyutu);

                if (toplam_sayfa_sayisi == 0) toplam_sayfa_sayisi = 1;

                if (suanki_sayfa > toplam_sayfa_sayisi)
                    suanki_sayfa = 1;

                dgvUrunler.DataSource = await sorgu
                    .OrderByDescending(r => r.id)
                    .Skip((suanki_sayfa - 1) * sayfa_boyutu)
                    .Take(sayfa_boyutu)
                    .Select(r => new
                    {
                        id = r.id,
                        Urun_Kodu = r.urun_kodu,
                        Urun_Adi = r.urun_adi,
                        Birim = r.birim,
                        KDV = r.kdv,

                    })
                    .ToListAsync();


                lblSayfa.Text = $"Sayfa {suanki_sayfa} / {toplam_sayfa_sayisi} (Toplam Kayıt: {toplam_kayit})";

                btnOnceki.Enabled = suanki_sayfa > 1;
                btnSonraki.Enabled = suanki_sayfa < toplam_sayfa_sayisi;


                if (dgvUrunler.Columns["id"] != null)
                {
                    dgvUrunler.Columns["id"].Visible = false;
                }

                dgvUrunler.Columns["Urun_Kodu"].HeaderText = "Ürün Kodu";
                dgvUrunler.Columns["Urun_Adi"].HeaderText = "Ürün Adı";
                dgvUrunler.Columns["Birim"].HeaderText = "Birim";
                dgvUrunler.Columns["KDV"].HeaderText = "KDV (%)";


            }




        }

        public int SecilenUrunId { get; private set; }
        public string SecilenUrunKodu { get; private set; } = string.Empty;
        public string SecilenUrunAdi { get; private set; } = string.Empty;
        public string SecilenBirim { get; private set; } = string.Empty;
        public decimal SecilenKdv { get; private set; }





        private void ApplyCustomStyles()
        {

            UIHelper.ModernizeDataGridView(dgvUrunler);

            UIHelper.SetRoundedRegion(btnSec, 8);
            UIHelper.SetRoundedRegion(btnIptal, 8);
            UIHelper.SetRoundedRegion(btnIlkSayfa, 6);
            UIHelper.SetRoundedRegion(btnOnceki, 6);
            UIHelper.SetRoundedRegion(btnSonraki, 6);
            UIHelper.SetRoundedRegion(btnSonSayfa, 6);


            this.AcceptButton = btnSec;
            this.CancelButton = btnIptal;

            this.ActiveControl = txtAra;

            // İptal butonu formu kapatsın
            btnIptal.Click += (s, e) =>
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };

            // Tabloda bir satıra çift tıklandığında doğrudan seçme işlemini tetikle
            dgvUrunler.CellDoubleClick += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    btnSec.PerformClick();
                }
            };
        }

        private void FormUrunSecimModal_Load(object sender, EventArgs e)
        {

        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            SecilenUrunId = Convert.ToInt32(dgvUrunler.CurrentRow.Cells["id"].Value?.ToString() ?? "0");
            SecilenUrunKodu = dgvUrunler.CurrentRow.Cells["Urun_Kodu"].Value?.ToString() ?? "0";
            SecilenUrunAdi = dgvUrunler.CurrentRow.Cells["urun_adi"].Value?.ToString()?? "0";
            SecilenBirim = dgvUrunler.CurrentRow.Cells["Birim"].Value?.ToString() ?? "0";
            SecilenKdv = Convert.ToDecimal( dgvUrunler.CurrentRow.Cells["KDV"].Value?.ToString()?? "0");

            DialogResult = DialogResult.OK;
            this.Close();





        }
    }
}

