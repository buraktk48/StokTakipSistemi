using Microsoft.EntityFrameworkCore;
using StokTakipSistemi.Data;
using StokTakipSistemi.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
            UIHelper.ModernizeDataGridView(dgvTransferler);
            UIHelper.ModernizeDataGridView(dgvTransferDetay);

            AramaZamanlayici.AramaSinirlayici(txtFisNoAra, (aranan) =>
            {
                suanki_sayfa = 1;
                TransferListele(txtFisNoAra.Text.Trim());
            });

        }

        private bool yukleniyor_bayrak = true;

        private int suanki_sayfa = 1;
        private int toplam_sayfa_sayisi = 1;
        private int sayfa_boyutu = 10;

        public async void TransferListele(string aranan = "", int? CikisDepoId = null, int? VarisDepoId = null)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var sorgu = context.Transferler.AsNoTracking();

                    if (!string.IsNullOrWhiteSpace(aranan))
                    {
                        sorgu = sorgu.Where(r => r.fis_numarasi.Contains(aranan));
                    }

                    if (CikisDepoId.HasValue && CikisDepoId > 0)
                    {
                        sorgu = sorgu.Where(r => r.cikis_depo_id == CikisDepoId);
                    }

                    if (VarisDepoId.HasValue && VarisDepoId > 0)
                    {
                        sorgu = sorgu.Where(r => r.varis_depo_id == VarisDepoId);
                    }

                    int toplam_kayit = await sorgu.CountAsync();

                    toplam_sayfa_sayisi = (int)Math.Ceiling(toplam_kayit / (double)sayfa_boyutu);

                    if (toplam_sayfa_sayisi == 0) toplam_sayfa_sayisi = 1;


                    if (suanki_sayfa > toplam_sayfa_sayisi) suanki_sayfa = 1;


                    dgvTransferler.DataSource = await sorgu
                        .Select(u => new
                        {
                            id = u.id,
                            Cikis_Depo = u.cikis_depo.ad,
                            Varis_Depo = u.varis_depo.ad,
                            Fis_Numarasi = u.fis_numarasi,
                            Transfer_Yapan_Kullanici = u.transfer_kullanici != null
                            ? u.transfer_kullanici.ad + " " + u.transfer_kullanici.soyad : "",
                            Olusturulma_Zamani = u.olusturulma_zamani,


                        })
                        .ToListAsync();

                    if (dgvTransferler.Columns["id"]!=null)
                    {
                        dgvTransferler.Columns["id"].Visible = false;
                        dgvTransferler.Columns["Olusturulma_Zamani"].Visible = false;
                        dgvTransferler.Columns["Transfer_Yapan_Kullanici"].Visible=false;
                    }

                    dgvTransferler.Columns["Cikis_Depo"].HeaderText = "Çıkış Deposu";
                    dgvTransferler.Columns["Varis_Depo"].HeaderText = "Varış Deposu";
                    dgvTransferler.Columns["Fis_Numarasi"].HeaderText = "Fiş Numarası";
                    dgvTransferler.Columns["Transfer_Yapan_Kullanici"].HeaderText = "Ekleyen Kullanıcı";
                    dgvTransferler.Columns["Olusturulma_Zamani"].HeaderText = "Oluşturulma Zamanı";



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

        


        private void TransferFiltrele()
        {
            string arananFisNo = txtFisNoAra.Text.Trim();
            int? cikisDepoId = cboxCikisDepo.SelectedValue as int?;
            int? varisDepoId = cboxVarisDepo.SelectedValue as int?;


            TransferListele(arananFisNo, cikisDepoId, varisDepoId);
        }



        private async void TransferDetayFiltre(string FisNo)
        {
            try
            {

                using (var context = new AppDbContext())
                {
                    //Buralarda await yazılmamasının sebebi ortada sorgu hazırlanıyor sql ile ilgili bir şey yok

                    var query = context.TransferDetaylari.AsNoTracking();

                    if (!string.IsNullOrWhiteSpace(FisNo))
                    {
                        query = query.Where(u => u.transfer.fis_numarasi == FisNo);
                    }

                    dgvTransferDetay.DataSource = await query
                       .Select(u => new
                       {
                           id = u.id,
                           Fis_Numarasi = u.transfer.fis_numarasi,
                           Urun_Adi = u.urun.urun_adi,
                           Miktar = u.miktar,
                           Olusturulma_Zamani = u.olusturulma_zamani
                       })
                       .ToListAsync();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTransferGirisi_Click(object sender, EventArgs e)
        {
            FormTransferGiris formTransferGiris = new FormTransferGiris();
            formTransferGiris.ShowDialog();
            TransferListele(txtFisNoAra.Text.Trim());
        }

        private void btnTransferYenile_Click(object sender, EventArgs e)
        {
            TransferListele("");
            dgvTransferDetay.DataSource = null;
        }

        private void FormTransferPanel_Load(object sender, EventArgs e)
        {
            yukleniyor_bayrak = true;

            TransferListele("");
            dgvTransferDetay.DataSource = null;

            using (var context = new AppDbContext())
            {
                cboxCikisDepo.DataSource = context.Depolar.AsNoTracking().ToList();
                cboxVarisDepo.DataSource = context.Depolar.AsNoTracking().ToList();

                cboxCikisDepo.DisplayMember = "depo_bilgisi";
                cboxCikisDepo.ValueMember = "id";

                cboxVarisDepo.DisplayMember = "depo_bilgisi";
                cboxVarisDepo.ValueMember = "id";
            }

            cboxCikisDepo.SelectedIndex = -1;
            cboxVarisDepo.SelectedIndex = -1;

            yukleniyor_bayrak = false;
        }

        private void txtFisNoAra_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvTransferler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTransferler.CurrentRow != null && e.RowIndex >= 0)
            {
                string secilenFisNo = dgvTransferler.CurrentRow.Cells["Fis_Numarasi"].Value?.ToString() ?? "";

                if (!string.IsNullOrEmpty(secilenFisNo))
                {
                    TransferDetayFiltre(secilenFisNo);
                }
            }
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            txtFisNoAra.Clear();

            cboxCikisDepo.SelectedIndex = -1;
            cboxVarisDepo.SelectedIndex = -1;

            dgvTransferler.ClearSelection();

            TransferListele("");
            dgvTransferDetay.DataSource = null;
        }

        private void cboxCikisDepo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (yukleniyor_bayrak)
            {
                return;
            }
            TransferFiltrele();

        }

        private void cboxVarisDepo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (yukleniyor_bayrak)
            {
                return;
            }
            TransferFiltrele();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            if (suanki_sayfa < toplam_sayfa_sayisi)
            {
                suanki_sayfa++;
                TransferListele(txtFisNoAra.Text.Trim());
            }
        }

        private void btnSonSayfa_Click(object sender, EventArgs e)
        {
            suanki_sayfa = toplam_sayfa_sayisi;
            TransferListele(txtFisNoAra.Text.Trim());

        }

        private void btnOnceki_Click(object sender, EventArgs e)
        {
            if (suanki_sayfa>1)
            {
                suanki_sayfa--;
                TransferListele(txtFisNoAra.Text.Trim());
            }

        }

        private void btnIlkSayfa_Click(object sender, EventArgs e)
        {
            suanki_sayfa = 1;
            TransferListele(txtFisNoAra.Text.Trim());
        }
    }
}
