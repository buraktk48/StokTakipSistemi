using Microsoft.EntityFrameworkCore;
using StokTakipSistemi.Data;
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
    public partial class FormStokPanel : Form
    {
        public FormStokPanel()
        {
            InitializeComponent();
            UIHelper.ModernizeDataGridView(dgvDepoStok);

            AramaZamanlayici.AramaSinirlayici(txtArama, (aranan) =>
            {
                suanki_sayfa = 1;
                StokListele(aranan);
            });


        }

        private int sayfa_boyutu = 10;
        private int suanki_sayfa = 1;
        private int toplam_sayfa_sayisi = 1;
        int secilenUrunId = 0;
        string secilenUrunAdi = "";
        private void FormTemizle()
        {
            txtArama.Clear();
            numericUpDown1.Value = 0;
            cboxDepo.SelectedIndex = -1;
            
            rbtnStokEkle.Checked = false;
            rbtnStokDus.Checked = false;
        }

        private async void StokListele(string aranan)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    //Buralarda await yazılmamasının sebebi ortada sorgu hazırlanıyor sql ile ilgili bir şey yok

                    var sorgu = context.DepoStoklari
                        .AsNoTracking()
                        .Where(r => r.depo.ad.Contains(aranan) || r.urun.urun_adi.Contains(aranan));

                    int toplam_kayit = await sorgu.CountAsync();

                    toplam_sayfa_sayisi = (int)Math.Ceiling(toplam_kayit / (double)sayfa_boyutu);

                    if (toplam_sayfa_sayisi == 0) toplam_sayfa_sayisi = 1;


                    if (suanki_sayfa > toplam_sayfa_sayisi) suanki_sayfa = 1;


                    dgvDepoStok.DataSource = await sorgu
                        .OrderByDescending(u => u.id)
                        .Skip((suanki_sayfa - 1) * sayfa_boyutu)
                        .Take(sayfa_boyutu)
                        .Select(u => new
                        {
                            id = u.id,
                            Depo_Adi = u.depo.ad,
                            Urun_Adi = u.urun.urun_adi,
                            Miktar = u.miktar,
                            Birim = u.urun.birim,
                            Kdv = u.urun.kdv,
                            Ekleyen_Kullanici = u.olusturan_kullanici != null
                                ? u.olusturan_kullanici.ad + " " + u.olusturan_kullanici.soyad
                                : "-",
                            Olusturulma_Zamani = u.olusturulma_zamani
                        })
                        .ToListAsync();

                    if (dgvDepoStok.Columns["id"] != null)
                    {
                        dgvDepoStok.Columns["id"].Visible = false;

                    }

                    dgvDepoStok.Columns["Depo_Adi"].HeaderText = "Depo Adı";
                    dgvDepoStok.Columns["Urun_Adi"].HeaderText = "Ürün Adı";
                    dgvDepoStok.Columns["Ekleyen_Kullanici"].HeaderText = "Ekleyen Kullanıcı";
                    dgvDepoStok.Columns["Olusturulma_Zamani"].HeaderText = "Oluşturulma Zamanı";


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


        private async void FormStokPanel_Load(object sender, EventArgs e)
        {

            label2.Text = "Ürün : ";

            try
            {

                StokListele("");

                using (var context = new AppDbContext())
                {
                   

                    cboxDepo.DataSource = await context.Depolar
                    .AsNoTracking()
                    .ToListAsync();

                    cboxDepo.DisplayMember = "depo_bilgisi";
                    cboxDepo.ValueMember = "id";
                }

                cboxDepo.SelectedIndex = -1;
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (secilenUrunId==0)
            {
                MessageBox.Show("Lütfen bir ürün seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboxDepo.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir depo seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Miktar 0'dan büyük olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!rbtnStokEkle.Checked && !rbtnStokDus.Checked)
            {
                MessageBox.Show("Lütfen yapılacak işlemi seçiniz (Stok Ekle / Stok Düş)!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int secilenDepoId = (int)cboxDepo.SelectedValue;

            decimal girilenMiktar = numericUpDown1.Value;
            bool isStokEkle = rbtnStokEkle.Checked;


            var depostokService = new DepoStokService();
            bool basarili = depostokService.StokIslemiYap(
                secilenDepoId,
                secilenUrunId,
                girilenMiktar,
                isStokEkle,
                Session.AktifKullanici.id,
                out string mesaj
            );


            if (basarili)
            {
                MessageBox.Show(mesaj, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StokListele("");
                numericUpDown1.Value = 0;
            }
            else
            {
                MessageBox.Show(mesaj, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormTemizle();

        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            StokListele("");

        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            if (suanki_sayfa < toplam_sayfa_sayisi)
            {
                suanki_sayfa++;
                StokListele(txtArama.Text.Trim());
            }

        }

        private void btnOnceki_Click(object sender, EventArgs e)
        {
            if (suanki_sayfa > 1)
            {
                suanki_sayfa--;
                StokListele(txtArama.Text.Trim());
            }

        }

        private void btnSonSayfa_Click(object sender, EventArgs e)
        {
            suanki_sayfa = toplam_sayfa_sayisi;
            StokListele(txtArama.Text.Trim());
        }

        private void btnIlkSayfa_Click(object sender, EventArgs e)
        {
            suanki_sayfa = 1;
            StokListele(txtArama.Text.Trim());
        }

        private void btnUrunSecim_Click(object sender, EventArgs e)
        {
            using (var form = new FormUrunSecim())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    secilenUrunId = form.SecilenUrunId;
                    secilenUrunAdi = form.SecilenUrunAdi;

                    label2.Text = $"Ürün: {secilenUrunAdi}";
                }
                
                
            }

            

            


        }
    }





}
