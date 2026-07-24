using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Entities
{
    internal class Depo
    {
        public int id { get; set; }
        public string ad { get; set; }
        public DateTime olusturulma_zamani { get; set; }

        public string lokasyon {  get; set; }

    }
}
