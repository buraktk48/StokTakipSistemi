using StokTakipSistemi.Entities;
using System.Drawing.Text;
using StokTakipSistemi.Helpers;

namespace StokTakipSistemi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            label1.Text = $"Stok Takip Sistemi - Hoş Geldin, {Session.AktifKullanici.ad} {Session.AktifKullanici.soyad}";

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

                
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                
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





    }
}
