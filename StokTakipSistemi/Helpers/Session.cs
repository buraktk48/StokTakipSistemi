using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StokTakipSistemi.Entities;
using System.Threading.Tasks;

namespace StokTakipSistemi.Helpers
{
    public static class Session
    {       
        public static Kullanici AktifKullanici { get; set; }
      
        public static bool OturumAcikMi => AktifKullanici != null;
      
        public static void OturumuKapat()
        {
            AktifKullanici = null;
        }
    }
}
