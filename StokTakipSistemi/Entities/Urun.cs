using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Entities
{
    internal class Urun
    {
        public int id { get; set; }
        public string urun_kodu { get; set; }
        public string urun_adi { get; set; }
        public string birim { get; set; }
        
        public decimal kdv { get; set; }

        public DateTime olusturulma_zamani { get; set; } = DateTime.Now;


    }
}
