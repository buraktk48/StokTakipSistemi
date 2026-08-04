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
    public partial class FormTransferGiris : Form
    {
        public FormTransferGiris()
        {
            InitializeComponent();
        }

        private void FormTransferGiris_Load(object sender, EventArgs e)
        {
            FormTransferPanel form = Application.OpenForms["FormTransferPanel"] as FormTransferPanel;

            if (form != null) { form.TransferListele(""); }

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
    }
}
