using ClosedXML.Excel;
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
    public partial class FormExcelUrunEkle : Form
    {
        private Kullanici _aktifKullanici;

        public FormExcelUrunEkle(Kullanici _kullanici)
        {
            _aktifKullanici = _kullanici;
            InitializeComponent();
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

                    // DataGridView'e veriyi bağlama
                    dgvExcel.DataSource = dt;
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
        
            if (dgvExcel.Rows.Count == 0 || dgvExcel.DataSource == null)
            {
                MessageBox.Show("Lütfen önce geçerli bir Excel dosyası seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int basariliSayac = 0;
            int hataliSayac = 0;
            var urunService = new UrunService();

            // DataGridView üzerindeki DataTable satırlarında dönüyoruz
            DataTable dt = (DataTable)dgvExcel.DataSource;

            foreach (DataRow row in dt.Rows)
            {
                string kod = row["urun_kodu"]?.ToString(); // Excel'deki sütun adlarıyla BİREBİR aynı olmalı
                string ad = row["urun_adi"]?.ToString();
                string birim = row["birim"]?.ToString();
                string kdvStr = row["kdv"]?.ToString().Replace('.', ',');

                if (!decimal.TryParse(kdvStr, out decimal kdvDecimal))
                {
                    kdvDecimal = 20; // Dönüşmezse varsayılan KDV %20 olsun
                }

                // Servisimizdeki ManuelUrunGiris metodunu çağırıyoruz
                bool basarili = urunService.ManuelUrunGiris(
                    kod,
                    ad,
                    birim,
                    _aktifKullanici.id, // 👈 Giriş yapan kullanıcının ID'si otomatik ekleniyor
                    kdvDecimal,
                    out string mesaj
                );

                if (basarili) basariliSayac++;
                else hataliSayac++;
            }

            MessageBox.Show($"Aktarım Tamamlandı!\n\n✅ Başarılı: {basariliSayac} adet\n❌ Hatalı/Zaten Var Olan: {hataliSayac} adet",
                            "İşlem Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // İşlem bitince DataGridView'i temizleyebiliriz
            dgvExcel.DataSource = null;
            
        }
    }
}
