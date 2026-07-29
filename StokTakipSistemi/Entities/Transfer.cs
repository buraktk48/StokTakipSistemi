using System.ComponentModel.DataAnnotations.Schema;

namespace StokTakipSistemi.Entities
{
    internal class Transfer
    {
        public int id { get; set; }
        public int cikis_depo_id { get; set; }
        public int varis_depo_id { get; set; }
        public string fis_numarasi { get; set; }
        public DateTime olusturulma_zamani { get; set; } = DateTime.Now;
        
        public int transfer_kullanici_id { get; set; }

        [ForeignKey("transfer_kullanici_id")]
        public virtual Kullanici transfer_kullanici { get; set; }




    }
}
