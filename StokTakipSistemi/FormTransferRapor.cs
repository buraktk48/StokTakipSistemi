using Microsoft.EntityFrameworkCore;
using StokTakipSistemi.Data;
using StokTakipSistemi.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Diagnostics;


namespace StokTakipSistemi
{



    public partial class FormTransferRapor : Form
    {
        public FormTransferRapor()
        {
            InitializeComponent();
        }

        private async void FormTransferRapor_Load(object sender, EventArgs e)
        {
            UIHelper.ModernizeDataGridView(dgvRapor);

            try
            {
            using (var context = new AppDbContext())
            {
                cboxCikisDepo.DataSource = await context.Depolar.AsNoTracking().ToListAsync();

                cboxCikisDepo.DisplayMember = "depo_bilgisi";
                cboxCikisDepo.ValueMember = "id";

                cboxVarisDepo.DataSource = await context.Depolar.AsNoTracking().ToListAsync();

                cboxVarisDepo.DisplayMember = "depo_bilgisi";
                cboxVarisDepo.ValueMember = "id";

                cboxUrun.DataSource = await context.Urunler.AsNoTracking().ToListAsync();

                cboxUrun.DisplayMember = "urun_bilgisi";
                cboxUrun.ValueMember = "id";



            }

            cboxCikisDepo.SelectedIndex = -1;
            cboxVarisDepo.SelectedIndex = -1;
            cboxUrun.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private async void RaporFiltre(int? CikisDepoId, int? VarisDepoId, string? FisNumarasi,
            int? UrunId, DateTime BaslangicTarihi, DateTime BitisTarihi)
        {
            try
            {
            using (var context = new AppDbContext())
            {
                var sorgu = context.TransferDetaylari.AsNoTracking();

                if (CikisDepoId != null)
                {
                    sorgu = sorgu.Where(u => u.transfer.cikis_depo_id == CikisDepoId);
                }

                if (VarisDepoId != null)
                {
                    sorgu = sorgu.Where(u => u.transfer.varis_depo_id == VarisDepoId);
                }

                if (!string.IsNullOrWhiteSpace(FisNumarasi))
                {
                    sorgu = sorgu.Where(u => u.transfer.fis_numarasi.Contains(FisNumarasi));
                }

                if (UrunId != null)
                {
                    sorgu = sorgu.Where(u => u.urun_id == UrunId);
                }

                sorgu = sorgu.Where(u => u.olusturulma_zamani >= BaslangicTarihi && u.olusturulma_zamani <= BitisTarihi);

                dgvRapor.DataSource = await sorgu.Select(u => new
                {
                    Transfer_Fisi = u.transfer.fis_numarasi,
                    Urun_Ismi = u.urun.urun_adi,
                    Birimi = u.urun.birim,
                    KDV_Orani = u.urun.kdv,
                    Cikis_Deposu = u.transfer.cikis_depo.ad,
                    Varis_Deposu = u.transfer.varis_depo.ad,
                    Miktar = u.miktar,
                    Transferi_Yapan_Kullanici = u.transfer.transfer_kullanici.ad,
                    Transfer_Tarihi = u.olusturulma_zamani,



                })
                .ToListAsync();

                    dgvRapor.Columns["Transfer_Fisi"].HeaderText = "Transfer Fişi";
                    dgvRapor.Columns["Urun_Ismi"].HeaderText = "Ürün İsmi";
                    dgvRapor.Columns["KDV_Orani"].HeaderText = "KDV Oranı";
                    dgvRapor.Columns["Cikis_Deposu"].HeaderText = "Çıkış Deposu";
                    dgvRapor.Columns["Varis_Deposu"].HeaderText = "Varış Deposu";
                    dgvRapor.Columns["Transferi_Yapan_Kullanici"].HeaderText = "Transferi Yapan Kullanıcı";
                    dgvRapor.Columns["Transfer_Tarihi"].HeaderText = "Transfer Tarihi";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnPdfRapor_Click(object sender, EventArgs e)
        {
            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;

            if (dgvRapor.Rows.Count == 0)
            {
                MessageBox.Show("Raporlanacak veri bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Dosyası (*.pdf)|*.pdf";
                saveFileDialog.FileName = $"Transfer_Raporu_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return;


                Document.Create(container =>
                {

                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4.Landscape());
                        page.Margin(1, Unit.Centimetre);
                        page.PageColor(Colors.White);
                        page.DefaultTextStyle(x => x.FontSize(10).FontFamily("Arial"));

                        page.Header().Column(col =>
                        {
                            col.Item().Text("STOK TAKİP SİSTEMİ").FontSize(18).Bold().FontColor(Colors.Blue.Darken3);
                            col.Item().Text("TRANSFER RAPORU").FontSize(14).SemiBold().FontColor(Colors.Grey.Darken2);
                            col.Item().Text($"Rapor Tarihi: {DateTime.Now:dd.MM.yyyy HH:mm}").FontSize(9).Italic();
                            col.Item().PaddingTop(5).BorderBottom(1).BorderColor(Colors.Grey.Lighten1);

                        });


                        page.Content().PaddingVertical(10).Table(table =>
                        {
                            table.ColumnsDefinition(col =>
                            {
                                col.RelativeColumn(1.5f);
                                col.RelativeColumn(2);
                                col.RelativeColumn(1);
                                col.RelativeColumn(1);
                                col.RelativeColumn(1.5f);
                                col.RelativeColumn(1.5f);
                                col.RelativeColumn(1.5f);
                                col.RelativeColumn(1);
                                col.RelativeColumn(1.5f);
                            });

                            table.Header(header =>
                            {
                                string[] sutunlar = new string[]
                                {
                                    "Transfer Fişi",
                                    "Ürün İsmi",
                                    "Birimi",
                                    "KDV Oranı",
                                    "Çıkış Deposu",
                                    "Varış Deposu",
                                    "Miktar",
                                    "Transfer Girişini Yapan Kullanıcı",
                                    "Transfer Tarihi",
                                };

                                foreach (var sutun in sutunlar)
                                {
                                    header.Cell().Background(Colors.Grey.Lighten3).Padding(4).Text(sutun).Bold();
                                }
                            });

                            foreach (DataGridViewRow row in dgvRapor.Rows)
                            {
                                if (row.IsNewRow) continue;

                                table.Cell().BorderBottom(0.5f).BorderColor(Colors.Grey.Lighten3).Padding(4).Text(row.Cells["Transfer_Fisi"].Value?.ToString() ?? "");
                                table.Cell().BorderBottom(0.5f).BorderColor(Colors.Grey.Lighten3).Padding(4).Text(row.Cells["Urun_Ismi"].Value?.ToString() ?? "");
                                table.Cell().BorderBottom(0.5f).BorderColor(Colors.Grey.Lighten3).Padding(4).Text(row.Cells["Birimi"].Value?.ToString() ?? "");
                                table.Cell().BorderBottom(0.5f).BorderColor(Colors.Grey.Lighten3).Padding(4).Text(row.Cells["KDV_Orani"].Value?.ToString() ?? "");
                                table.Cell().BorderBottom(0.5f).BorderColor(Colors.Grey.Lighten3).Padding(4).Text(row.Cells["Cikis_Deposu"].Value?.ToString() ?? "");
                                table.Cell().BorderBottom(0.5f).BorderColor(Colors.Grey.Lighten3).Padding(4).Text(row.Cells["Varis_Deposu"].Value?.ToString() ?? "");
                                table.Cell().BorderBottom(0.5f).BorderColor(Colors.Grey.Lighten3).Padding(4).Text(row.Cells["Miktar"].Value?.ToString() ?? "");
                                table.Cell().BorderBottom(0.5f).BorderColor(Colors.Grey.Lighten3).Padding(4).Text(row.Cells["Transferi_Yapan_Kullanici"].Value?.ToString() ?? "");
                                table.Cell().BorderBottom(0.5f).BorderColor(Colors.Grey.Lighten3).Padding(4).Text(row.Cells["Transfer_Tarihi"].Value?.ToString() ?? "");

                                

                            }


                        });

                        page.Footer().AlignRight().Text(x =>
                        {
                            x.Span("Sayfa ");
                            x.CurrentPageNumber();
                            x.Span(" / ");
                            x.TotalPages();
                        });



                    });
                    

                })
                .GeneratePdf(saveFileDialog.FileName);

                var cevap = MessageBox.Show("PDF Raporu oluşturuldu! Dosyayı açmak ister misiniz?", "Başarılı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (cevap == DialogResult.Yes)
                {
                    Process.Start(new ProcessStartInfo(saveFileDialog.FileName) { UseShellExecute = true });
                }

            }

           

        
        
        
        
        }





        private void btnListele_Click(object sender, EventArgs e)
        {
            int? cikisDepoId = cboxCikisDepo.SelectedValue as int?;
            int? varisDepoId = cboxVarisDepo.SelectedValue as int?;

            int? urunId = cboxUrun.SelectedValue as int?;

            DateTime baslangicTarihi = dtpBaslangic.Value;
            DateTime bitisTarihi = dtpBitis.Value;

            string fisNumarasi = txtFisNum.Text.Trim();

            RaporFiltre(cikisDepoId, varisDepoId, fisNumarasi, urunId, baslangicTarihi, bitisTarihi);

        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            cboxCikisDepo.SelectedIndex = -1;
            cboxVarisDepo.SelectedIndex = -1;

            cboxUrun.SelectedIndex = -1;

            txtFisNum.Clear();
        } 
    }
}
