using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Entities
{
    internal class DepoStok
    {
        public int id {  get; set; }
        public int depo_id { get; set; }
        public int urun_id { get; set; }
        public int olusturan_kullanici_id { get; set; }
        public decimal miktar {  get; set; }
        public DateTime olusturulma_zamani { get; set; } = DateTime.Now;

        [ForeignKey("depo_id")]
        public virtual Depo depo { get; set; }

        [ForeignKey("urun_id")]
        public virtual Urun urun { get; set; }

        [ForeignKey("olusturan_kullanici_id")]
        public virtual Kullanici? olusturan_kullanici { get; set; }

    }
}
