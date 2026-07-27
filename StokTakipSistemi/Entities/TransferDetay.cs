using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Entities
{
    internal class TransferDetay
    {
        public int id {  get; set; }
        public string transfer_id { get; set; }
        public string urun_id { get; set; }
        public decimal miktar {  get; set; }
        public DateTime olusturulma_zamani { get; set; } = DateTime.Now;

    }
}
