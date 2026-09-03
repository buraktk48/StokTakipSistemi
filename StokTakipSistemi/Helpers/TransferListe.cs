using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Helpers
{
    public class TransferListe
    {

        [Browsable(false)]
        public int cikis_depo_id { get; set; }
        [Browsable(false)]
        public int varis_depo_id { get; set; }
        [Browsable(false)]
        public int urun_id { get; set; }

        public string Fis_Numarasi { get; set; }
        public string Urun_Adi { get; set; }
        public string Cikis_Depo_Adi { get; set; }
        public string Varis_Depo_Adi { get; set; }
        public decimal miktar { get; set; }
        
        public string birim {  get; set; }

        public DateTime tarih { get; set; }



        
        
        

    }
}
