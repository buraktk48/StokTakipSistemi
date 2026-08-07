using StokTakipSistemi.Entities;
using System.Drawing.Text;
using StokTakipSistemi.Helpers;
using StokTakipSistemi.Data;
using Microsoft.EntityFrameworkCore;

namespace StokTakipSistemi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();

        }

        private void IstatistikleriGetir()
        {
            using (var context = new AppDbContext())
            {
                int toplamDepo = context.Depolar.Count();
                int toplamStok = context.DepoStoklari.Count();

                var sonKayit = context.Transferler.OrderByDescending(x => x.id).FirstOrDefault();
                var sonDepolar = context.Transferler
                    .Include(x => x.cikis_depo)
                    .Include(x=>x.varis_depo)
                    .OrderByDescending(x => x.id)
                    .FirstOrDefault();

                if (sonDepolar !=null)
                {
                    lblTransferDepo.Text = $"{sonDepolar.cikis_depo.ad}-{sonDepolar.varis_depo.ad}";

                }


                lblToplamDepo.Text = toplamDepo.ToString();
                lblStokluUrun.Text = toplamStok.ToString();
                lblSonTransfer.Text = sonKayit.olusturulma_zamani.ToString();


            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            label1.Text = $"Stok Takip Sistemi | Hoş Geldin, {Session.AktifKullanici.ad} {Session.AktifKullanici.soyad}";

            IstatistikleriGetir();


        }

        private void btnUrunPanel_Click(object sender, EventArgs e)
        {
            FormUrunPanel FormUrunListe = new FormUrunPanel();
            FormUrunListe.ShowDialog();
        }

        private void btnDepoPanel_Click(object sender, EventArgs e)
        {
            FormDepoPanel FormDepoPanel = new FormDepoPanel();
            FormDepoPanel.ShowDialog();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Hesabınızdan Çıkış yapmak istediğinize emin misiniz?",
                "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                Session.OturumuKapat();

                this.Close();

            }
        }

        private void AnaForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (Session.OturumAcikMi)
            {
                Application.Exit();
            }
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            FormStokPanel formStokPanel = new FormStokPanel();
            formStokPanel.ShowDialog();
        }

        private void btnTransferPanel_Click(object sender, EventArgs e)
        {
            FormTransferPanel formTransferPanel = new FormTransferPanel();
            formTransferPanel.ShowDialog();

        }

        private void btnTransferRaporuCikart_Click(object sender, EventArgs e)
        {
            FormTransferRapor formTransferRapor = new FormTransferRapor();
            formTransferRapor.ShowDialog();

        }
    }
}
