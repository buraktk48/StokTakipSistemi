using ClosedXML.Excel;
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
    public partial class FormExcelUrunEkle : Form
    {


        public FormExcelUrunEkle()
        {

            InitializeComponent();
        }

        private int sayfa_boyutu = 10;
        private int suanki_sayfa = 1;
        private int toplam_sayfa_sayisi = 1;
        private DataTable? tumExcelVerileri;

        private void ExcelSayfala()
        {
            if (tumExcelVerileri == null || tumExcelVerileri.Rows.Count == 0)
            {
                dgvExcel.DataSource = null;
                toplam_sayfa_sayisi = 1;
                suanki_sayfa = 1;
                lblSayfa.Text = "Sayfa 1 / 1 (Toplam Kayıt: 0)";
                btnOnceki.Enabled = false;
                btnSonraki.Enabled = false;
                btnIlkSayfa.Enabled = false;
                btnSonSayfa.Enabled = false;
                return;
            }

            int toplam_kayit = tumExcelVerileri.Rows.Count;
            toplam_sayfa_sayisi = (int)Math.Ceiling(toplam_kayit / (double)sayfa_boyutu);
            if (toplam_sayfa_sayisi == 0) toplam_sayfa_sayisi = 1;

            if (suanki_sayfa > toplam_sayfa_sayisi) suanki_sayfa = toplam_sayfa_sayisi;
            if (suanki_sayfa < 1) suanki_sayfa = 1;

            DataTable sayfaDt = tumExcelVerileri.Clone();
            int baslangic = (suanki_sayfa - 1) * sayfa_boyutu;
            int bitis = Math.Min(baslangic + sayfa_boyutu, toplam_kayit);

            for (int i = baslangic; i < bitis; i++)
            {
                sayfaDt.ImportRow(tumExcelVerileri.Rows[i]);
            }

            dgvExcel.DataSource = sayfaDt;

            lblSayfa.Text = $"Sayfa {suanki_sayfa} / {toplam_sayfa_sayisi} (Toplam Kayıt: {toplam_kayit})";

            btnOnceki.Enabled = suanki_sayfa > 1;
            btnSonraki.Enabled = suanki_sayfa < toplam_sayfa_sayisi;
            btnIlkSayfa.Enabled = suanki_sayfa > 1;
            btnSonSayfa.Enabled = suanki_sayfa < toplam_sayfa_sayisi;
        }

        private void ExcelVerileriniGrideYukle(string dosyaYolu)
        {
            try
            {
                using (var workbook = new XLWorkbook(dosyaYolu))
                {
                    var worksheet = workbook.Worksheet(1); // 1. Excel Sayfası
                    DataTable dt = new DataTable();

                    // Veri girişinin olduğu ilk Satırı (Başlıkları) Okuma
                    var firstRow = worksheet.FirstRowUsed();
                    foreach (var cell in firstRow.CellsUsed())
                    {
                        dt.Columns.Add(cell.Value.ToString().Trim());
                    }

                    // 2. Satırdan itibaren Verileri Okuma
                    var rows = worksheet.RowsUsed().Skip(1); // Başlık satırını atla
                    foreach (var row in rows)
                    {
                        DataRow dr = dt.NewRow();
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            // Hücre indeksleri 1'den başladığı için i + 1 yazıyoruz
                            dr[i] = row.Cell(i + 1).Value.ToString().Trim();
                        }
                        dt.Rows.Add(dr);
                    }

                    tumExcelVerileri = dt;
                    suanki_sayfa = 1;
                    ExcelSayfala();

                    MessageBox.Show($"Toplam {dt.Rows.Count} adet ürün Excel'den okundu. Kontrol edip 'İçe Aktar' butonuna basabilirsiniz.",
                                    "Önizleme Hazır", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excel dosyası okunurken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
                openFileDialog.Title = "Lütfen Yüklenecek Excel Dosyasını Seçin";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string secilenDosyaYolu = openFileDialog.FileName;
                    txtDosyaYolu.Text = secilenDosyaYolu;


                    ExcelVerileriniGrideYukle(secilenDosyaYolu);
                }





            }
        }

        private void btnIceAktar_Click(object sender, EventArgs e)
        {
            if (tumExcelVerileri == null || tumExcelVerileri.Rows.Count == 0)
            {
                MessageBox.Show("Lütfen önce geçerli bir Excel dosyası seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = tumExcelVerileri;

            // Sütun adı kontrolleri
            bool varKod = dt.Columns.Contains("urun_kodu");
            bool varAd = dt.Columns.Contains("urun_adi");
            bool varBirim = dt.Columns.Contains("birim");
            bool varKdv = dt.Columns.Contains("kdv");

            if (!varKod || !varAd || !varBirim)
            {
                MessageBox.Show("Excel dosyasında gerekli sütun başlıkları bulunamadı!\n\nBeklenen Sütunlar: 'urun_kodu', 'urun_adi', 'birim', 'kdv'", 
                                "Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int basariliSayac = 0;
            int hataliSayac = 0;
            var urunService = new UrunService();

            foreach (DataRow row in dt.Rows)
            {
                try
                {
                    string kod = row["urun_kodu"]?.ToString()?.Trim() ?? "";
                    string ad = row["urun_adi"]?.ToString()?.Trim() ?? "";
                    string birim = row["birim"]?.ToString()?.Trim() ?? "";
                    string kdvStr = varKdv ? row["kdv"]?.ToString()?.Replace('.', ',') ?? "20" : "20";

                    if (string.IsNullOrWhiteSpace(kod) || string.IsNullOrWhiteSpace(ad))
                    {
                        hataliSayac++;
                        continue;
                    }

                    if (!decimal.TryParse(kdvStr, out decimal kdvDecimal) || kdvDecimal < 0)
                    {
                        kdvDecimal = 20; // Dönüşmezse varsayılan KDV %20 olsun
                    }

                    bool basarili = urunService.ManuelUrunGiris(
                        kod,
                        ad,
                        birim,
                        Session.AktifKullanici.id,
                        kdvDecimal,
                        out string mesaj
                    );

                    if (basarili) basariliSayac++;
                    else hataliSayac++;
                }
                catch
                {
                    hataliSayac++;
                }
            }

            MessageBox.Show($"Aktarım Tamamlandı!\n\n✅ Başarılı: {basariliSayac} adet\n❌ Hatalı/Zaten Var Olan: {hataliSayac} adet",
                            "İşlem Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Ürün paneli açık ise listesini yenile
            FormUrunPanel form = Application.OpenForms["FormUrunPanel"] as FormUrunPanel;
            if (form != null)
            {
                form.UrunListele("");
            }

            tumExcelVerileri = null;
            ExcelSayfala();
        }

        private void FormExcelUrunEkle_Load(object sender, EventArgs e)
        {
            UIHelper.ModernizeDataGridView(dgvExcel);
            dgvExcel.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(16, 124, 65);
            ExcelSayfala();
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            if (suanki_sayfa < toplam_sayfa_sayisi)
            {
                suanki_sayfa++;
                ExcelSayfala();
            }
        }

        private void btnSonSayfa_Click(object sender, EventArgs e)
        {
            suanki_sayfa = toplam_sayfa_sayisi;
            ExcelSayfala();
        }

        private void btnOnceki_Click(object sender, EventArgs e)
        {
            if (suanki_sayfa > 1)
            {
                suanki_sayfa--;
                ExcelSayfala();
            }
        }

        private void btnIlkSayfa_Click(object sender, EventArgs e)
        {
            suanki_sayfa = 1;
            ExcelSayfala();
        }
    }
}
