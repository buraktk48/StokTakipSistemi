using StokTakipSistemi.Entities;
using System.Drawing.Drawing2D;
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
            ApplyCustomStyles();
        }

        private void ApplyCustomStyles()
        {
            panel2.Paint += (s, e) => UIHelper.DrawCardBorder(s, e, 12);
            panel3.Paint += (s, e) => UIHelper.DrawCardBorder(s, e, 12);
            panel4.Paint += (s, e) => UIHelper.DrawCardBorder(s, e, 12);

            this.Resize += (s, e) => AutoLayoutControls();
            AutoLayoutControls();
        }

        private void AutoLayoutControls()
        {
            if (this.ClientSize.Width <= 0) return;

            // 1. Üstteki 3 İstatistik Kartını Ekranın Tam Ortasına Hizala:
            int cardWidth = 355;
            int cardGap = 40;
            int totalCardsWidth = (cardWidth * 3) + (cardGap * 2);
            int startCardX = Math.Max(20, (this.ClientSize.Width - totalCardsWidth) / 2);

            panel2.Left = startCardX;
            panel3.Left = startCardX + cardWidth + cardGap;
            panel4.Left = startCardX + (cardWidth + cardGap) * 2;

            // 2. Buton Sütunlarını Ekranın Tam Ortasına Hizala:
            int btnWidth = 460;
            int btnGap = 80;
            int totalBtnsWidth = (btnWidth * 2) + btnGap;
            int startBtnX = Math.Max(20, (this.ClientSize.Width - totalBtnsWidth) / 2);

            btnUrunPanel.Left = startBtnX;
            btnDepoPanel.Left = startBtnX;
            btnStok.Left = startBtnX;

            btnTransferPanel.Left = startBtnX + btnWidth + btnGap;
            btnTransferRaporuCikart.Left = startBtnX + btnWidth + btnGap;

            // 3. Çıkış Yap Butonunu Tam Ortala:
            btnCikisYap.Left = (this.ClientSize.Width - btnCikisYap.Width) / 2;

            // Panellerin ve Butonların köşelerini ovalleştirme:
            UIHelper.SetRoundedRegion(panel2, 12);
            UIHelper.SetRoundedRegion(panel3, 12);
            UIHelper.SetRoundedRegion(panel4, 12);

            UIHelper.SetRoundedRegion(btnUrunPanel, 10);
            UIHelper.SetRoundedRegion(btnDepoPanel, 10);
            UIHelper.SetRoundedRegion(btnStok, 10);
            UIHelper.SetRoundedRegion(btnTransferPanel, 10);
            UIHelper.SetRoundedRegion(btnTransferRaporuCikart, 10);
            UIHelper.SetRoundedRegion(btnCikisYap, 10);
        }

        private async void IstatistikleriGetir()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    int toplamDepo = await context.Depolar.AsNoTracking().CountAsync();
                    
                    
                    int toplamStokluUrun = await context.DepoStoklari.AsNoTracking().CountAsync();

                    var sonTransfer = await context.Transferler
                        .AsNoTracking()
                        .Include(x => x.cikis_depo)
                        .Include(x => x.varis_depo)
                        .OrderByDescending(x => x.id)
                        .FirstOrDefaultAsync();

                    lblToplamDepo.Text = toplamDepo.ToString("N0");
                    lblStokluUrun.Text = toplamStokluUrun.ToString("N0");

                    if (sonTransfer != null)
                    {
                        string cikis = sonTransfer.cikis_depo?.ad ?? "Depo A";
                        string varis = sonTransfer.varis_depo?.ad ?? "Depo B";
                        lblTransferDepo.Text = $"{cikis} -> {varis}";

                        if (sonTransfer.olusturulma_zamani.Date == DateTime.Today)
                        {
                            lblSonTransfer.Text = $"Bugün, {sonTransfer.olusturulma_zamani:HH:mm}";
                        }
                        else
                        {
                            lblSonTransfer.Text = sonTransfer.olusturulma_zamani.ToString("dd MMMM, HH:mm");
                        }
                    }
                    else
                    {
                        lblTransferDepo.Text = "Henüz transfer yok";
                        lblSonTransfer.Text = "-";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("İstatistikler yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Stok Takip Programı";

            string kullaniciAdi = Session.AktifKullanici != null
                ? $"{Session.AktifKullanici.ad} {Session.AktifKullanici.soyad}"
                : "Kullanıcı";

            lblHeaderUser.Text = $"Hoş Geldin, {kullaniciAdi} | {DateTime.Now:dd MMMM yyyy, HH:mm}";

            lblFooter.Text = $"© {DateTime.Now.Year} Dalaman Belediyesi ";

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
