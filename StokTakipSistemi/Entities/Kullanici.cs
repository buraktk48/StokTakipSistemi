using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Entities
{
    internal class Kullanici
    {
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string kullanici_adi { get; set; }

        public string sifre { get; set; }
        public bool kullanici_durum { get; set; }
        public int rol_id { get; set; }
        public DateTime olusturulma_zamani { get; set; } = DateTime.Now;

    }
}
