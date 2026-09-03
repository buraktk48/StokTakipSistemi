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
    public partial class FormTransferGiris : Form
    {
        public FormTransferGiris()
        {
            InitializeComponent();
            this.AcceptButton = btnTransferiKaydet;
        }

        public List<TransferListe> _sepet = new List<TransferListe>();

        private void FormTransferGiris_Load(object sender, EventArgs e)
        {
            UIHelper.ModernizeDataGridView(dgvListe);

            FormTransferPanel form = Application.OpenForms["FormTransferPanel"] as FormTransferPanel;

            if (form != null) { form.TransferListele(""); }

            using (var context = new AppDbContext())
            {
                cboxCikisDepo.DataSource = context.Depolar.ToList();
                cboxVarisDepo.DataSource = context.Depolar.ToList();
                cboxUrun.DataSource = context.Urunler.ToList();

                cboxCikisDepo.DisplayMember = "depo_bilgisi";
                cboxCikisDepo.ValueMember = "id";

                cboxVarisDepo.DisplayMember = "depo_bilgisi";
                cboxVarisDepo.ValueMember = "id";

                cboxUrun.DisplayMember = "urun_bilgisi";
                cboxUrun.ValueMember = "id";


            }
        }

        private void btnListeyeEkle_Click(object sender, EventArgs e)
        {
            if (cboxCikisDepo.SelectedValue == null || cboxVarisDepo.SelectedValue == null || cboxUrun.SelectedValue == null)
            {
                MessageBox.Show("Lütfen çıkış-varış depolarını ve ürünü seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            //CS 8600 uyarı kontrolü
            if (cboxCikisDepo.SelectedItem is not Depo cikisdepo || cboxVarisDepo.SelectedItem is not Depo varisdepo
                || cboxUrun.SelectedItem is not Urun secilenurun)
            {
                MessageBox.Show("Geçersiz seçim.");
                return;
            }
            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Miktar 0'dan büyük olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if ((int)cboxCikisDepo.SelectedValue == (int)cboxVarisDepo.SelectedValue)
            {
                MessageBox.Show("Çıkış deposu ile Varış deposu aynı olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtFisNum.Text))
            {
                MessageBox.Show("Lütfen Fiş Numarası Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            decimal miktar = (decimal)numericUpDown1.Value;

            var eleman = new TransferListe
            {
                Fis_Numarasi = txtFisNum.Text.Trim(),
                urun_id = secilenurun.id,
                Urun_Adi = secilenurun.urun_adi,
                birim = secilenurun.birim,

                cikis_depo_id = cikisdepo.id,
                Cikis_Depo_Adi = cikisdepo.ad,

                varis_depo_id = varisdepo.id,
                Varis_Depo_Adi = varisdepo.ad,

                miktar = miktar,

                tarih = dtpTarih.Value
            };

            _sepet.Add(eleman);

          
            // dgv'nin eski bağlantısının koparılması gerek, aynısı zannedip refresh atmıyor"
            dgvListe.DataSource = null;

            // güncellenmiş _sepet listesini sıfırdan yeniden bağlamak!"
            dgvListe.DataSource = _sepet;

            dgvListe.Columns["Fis_Numarasi"].HeaderText = "Fiş Numarası";
            dgvListe.Columns["Urun_Adi"].HeaderText = "Ürün Adı";
            dgvListe.Columns["Cikis_Depo_Adi"].HeaderText = "Çıkış Deposu";
            dgvListe.Columns["Varis_Depo_Adi"].HeaderText = "Varış Deposu";
            dgvListe.Columns["tarih"].HeaderText = "Transfer Tarihi";


            cboxCikisDepo.Enabled = false;
            cboxVarisDepo.Enabled = false;


        }

        private void btnTransferiKaydet_Click(object sender, EventArgs e)
        {
            var transferService = new TransferService();
            int kullanici_id = Session.AktifKullanici.id;

            bool basariliMi = transferService.TransferEkle(_sepet, kullanici_id,
                out string gelenMesaj);




            if (basariliMi)
            {
                MessageBox.Show(gelenMesaj, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _sepet.Clear();
                txtFisNum.Clear();

                dgvListe.DataSource = null;

                cboxCikisDepo.Enabled = true;
                cboxVarisDepo.Enabled = true;

                FormTransferPanel form = Application.OpenForms["FormTransferPanel"] as FormTransferPanel;
                if (form != null)
                {
                    form.TransferListele("");
                }
            }
            else
            {
                MessageBox.Show(gelenMesaj, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }

        private void btnTransferSil_Click(object sender, EventArgs e)
        {
            if (dgvListe.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silmek istediğiniz ürünü seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            

            DialogResult sonuc = MessageBox.Show("Bu ürünü silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.No)
                return;

            else if (sonuc == DialogResult.Yes)
            {
                var SecilenEleman = dgvListe.CurrentRow.DataBoundItem as TransferListe;
                //Null Reference Exception hatası vermemesi için
                if (SecilenEleman != null)
                {
                    _sepet.Remove(SecilenEleman);

                    dgvListe.DataSource = null;
                    dgvListe.DataSource = _sepet;

                    if (_sepet.Count == 0)
                    {
                        cboxCikisDepo.Enabled = true;
                        cboxVarisDepo.Enabled = true;
                    }


                    MessageBox.Show("Seçilen Transfer Listeden Başarıyla Silindi","Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }   }




        }
    }
}
