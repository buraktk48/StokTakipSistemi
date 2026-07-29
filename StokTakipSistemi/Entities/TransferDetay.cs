using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Entities
{
    internal class TransferDetay
    {
        public int id {  get; set; }
        public int transfer_id { get; set; }
        public int urun_id { get; set; }
        public decimal miktar {  get; set; }
        public DateTime olusturulma_zamani { get; set; } = DateTime.Now;

        [ForeignKey("transfer_id")]
        public virtual Transfer transfer { get; set; }

        [ForeignKey("urun_id")]
        public virtual Urun urun { get; set; }
    }
}
