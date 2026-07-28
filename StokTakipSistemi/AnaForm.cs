using StokTakipSistemi.Entities;
using System.Drawing.Text;

namespace StokTakipSistemi
{
    public partial class AnaForm : Form
    {
        private Kullanici _aktifKullanici;
        public AnaForm(Kullanici _kullanici)
        {

            InitializeComponent();
            _aktifKullanici = _kullanici;
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            label1.Text = $"Stok Takip Sistemi - Hoþ Geldin, {_aktifKullanici.ad} {_aktifKullanici.soyad}";

        }

        private void btnManuelUrunGiris_Click(object sender, EventArgs e)
        {
            FormManuelUrunGiris formManuelUrunGiris = new FormManuelUrunGiris();
            formManuelUrunGiris.ShowDialog();
        }
    }
}
