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
            
        }
        private void FormTemizle()
        {
            txtArama.Clear();
            numericUpDown1.Value = 0;
            cboxDepo.SelectedIndex = -1;
            cboxUrun.SelectedIndex = -1;
            rbtnStokEkle.Checked = false;
            rbtnStokDus.Checked = false;
        }

        private void StokListele(string aranan)
        {
            using (var context = new AppDbContext())
            {

                dgvDepoStok.DataSource = context.DepoStoklari
                    .Where(r => r.depo.ad.Contains(aranan) || r.urun.urun_adi.Contains(aranan))
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
                    .ToList();
            }
        }


        private void FormStokPanel_Load(object sender, EventArgs e)
        {
            StokListele("");

            using (var context = new AppDbContext())
            {
                cboxUrun.DataSource = context.Urunler.ToList();

                cboxUrun.DisplayMember = "urun_bilgisi";
                cboxUrun.ValueMember = "id";

                cboxDepo.DataSource = context.Depolar.ToList();

                cboxDepo.DisplayMember = "depo_bilgisi";
                cboxDepo.ValueMember = "id";
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cboxDepo.SelectedValue == null || cboxUrun.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir depo ve ürün seçiniz!", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            int secilenUrunId = (int)cboxUrun.SelectedValue;
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
            StokListele(txtArama.Text.Trim());


        }








    }

       
    


}
