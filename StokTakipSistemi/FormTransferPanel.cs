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
    public partial class FormTransferPanel : Form
    {
        public FormTransferPanel()
        {
            InitializeComponent();
        }

        public void TransferListele(string aranan)
        {
            using (var context = new AppDbContext())
            {
                dgvTransferler.DataSource = context.Transferler
                    .Where(r => r.fis_numarasi.Contains(aranan))
                    .Select(u => new
                    {
                        id = u.id,
                        Cikis_Depo = u.cikis_depo.id,
                        Varis_Depo = u.varis_depo.id,
                        Fis_Numarasi = u.fis_numarasi,
                        Transfer_Yapan_Kullanici = u.transfer_kullanici != null
                        ? u.transfer_kullanici.ad + " " + u.transfer_kullanici.soyad : "",
                        Olusturulma_Zamani = u.olusturulma_zamani,


                    })
                    .ToList();

            }
        }

        private void TransferDetayListele(string aranan)
        {
            using (var context = new AppDbContext())
            {
                dgvTransferDetay.DataSource = context.TransferDetaylari
                    .Select(u => new
                    {
                        id = u.id,
                        Fis_Numarasi = u.transfer.fis_numarasi,
                        Urun_Adi = u.urun.urun_adi,
                        Miktar = u.miktar,
                        Olusturulma_Zamani = u.olusturulma_zamani

                    })
                    .ToList();


            }
        }

        private void TransferDetayFiltre(string FisNo)
        {

            using (var context = new AppDbContext())
            {
                var query = context.TransferDetaylari.AsQueryable();
                
                if (!string.IsNullOrWhiteSpace(FisNo))
                {
                    query = query.Where(u => u.transfer.fis_numarasi == FisNo);
                }

                dgvTransferDetay.DataSource = query
                   .Select(u => new
                   {
                       id = u.id,
                       Fis_Numarasi = u.transfer.fis_numarasi,
                       Urun_Adi = u.urun.urun_adi,
                       Miktar = u.miktar,
                       Olusturulma_Zamani = u.olusturulma_zamani
                   })
                   .ToList();

            }

        }

        private void btnTransferGirisi_Click(object sender, EventArgs e)
        {
            FormTransferGiris formTransferGiris = new FormTransferGiris();
            formTransferGiris.ShowDialog();
        }

        private void btnTransferYenile_Click(object sender, EventArgs e)
        {
            TransferListele("");
            TransferDetayListele("");

        }

        private void FormTransferPanel_Load(object sender, EventArgs e)
        {

            TransferListele("");
            TransferDetayListele("");

            using (var context = new AppDbContext())
            {
                cboxCikisDepo.DataSource = context.Depolar.ToList();
                cboxVarisDepo.DataSource = context.Depolar.ToList();

                cboxCikisDepo.DisplayMember = "depo_bilgisi";
                cboxCikisDepo.ValueMember = "id";

                cboxVarisDepo.DisplayMember = "depo_bilgisi";
                cboxVarisDepo.ValueMember = "id";

            }
        }

        private void txtFisNoAra_TextChanged(object sender, EventArgs e)
        {
            TransferListele(txtFisNoAra.Text.Trim());
        }

        private void dgvTransferler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTransferler.CurrentRow != null && e.RowIndex >= 0)
            {

                string secilenFisNo = dgvTransferler.CurrentRow.Cells["Fis_Numarasi"].Value?.ToString() ?? "";
                TransferDetayFiltre(secilenFisNo);
            }
    }   }
}
