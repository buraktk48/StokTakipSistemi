using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Entities
{
    internal class Depo
    {
        public int id { get; set; }
        public string ad { get; set; }
        public DateTime olusturulma_zamani { get; set; } = DateTime.Now;

        public string lokasyon {  get; set; }
        
        public int olusturan_kullanici_id { get; set; }
        [ForeignKey("olusturan_kullanici_id")]
        public Kullanici? olusturan_kullanici { get; set; }

        [NotMapped]
        public string depo_bilgisi => $"{ad} - {lokasyon}";

    }
}
