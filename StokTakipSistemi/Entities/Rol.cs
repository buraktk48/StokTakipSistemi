using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Entities
{
    internal class Rol
    {
        public int id { get; set; }
        public string adi { get; set; }

        public DateTime olusturulma_zamani { get; set; } = DateTime.Now;
    }
}
