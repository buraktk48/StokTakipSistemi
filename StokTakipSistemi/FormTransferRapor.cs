using StokTakipSistemi.Data;
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



    public partial class FormTransferRapor : Form
    {
        public FormTransferRapor()
        {
            InitializeComponent();
        }

        private void FormTransferRapor_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                cboxCikisDepo.DataSource = context.Depolar.ToList();

                cboxCikisDepo.DisplayMember = "depo_bilgisi";
                cboxCikisDepo.ValueMember = "id";

                cboxVarisDepo.DataSource = context.Depolar.ToList();

                cboxVarisDepo.DisplayMember = "depo_bilgisi";
                cboxVarisDepo.ValueMember = "id";

                cboxUrun.DataSource = context.Urunler.ToList();

                cboxUrun.DisplayMember = "urun_bilgisi";
                cboxUrun.ValueMember = "id";



            }

            cboxCikisDepo.SelectedIndex = -1;
            cboxVarisDepo.SelectedIndex = -1;
            cboxUrun.SelectedIndex = -1;


        }


        private void RaporFiltre(int? CikisDepoId, int? VarisDepoId, string? FisNumarasi,
            int? UrunId, DateTime BaslangicTarihi, DateTime BitisTarihi)
        {
            using (var context = new AppDbContext())
            {
                var sorgu = context.TransferDetaylari.AsQueryable();

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

                sorgu = sorgu.Where(u => u.olusturulma_zamani > BaslangicTarihi && u.olusturulma_zamani < BitisTarihi);

                dgvRapor.DataSource = sorgu.Select(u => new
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
                .ToList();


            }

        }

        private void btnPdfRapor_Click(object sender, EventArgs e)
        {
            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;


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

      
    }
}
