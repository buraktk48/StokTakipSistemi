namespace StokTakipSistemi.Entities
{
    internal class Transfer
    {
        public int id { get; set; }
        public int cikis_depo_id { get; set; }
        public int varis_depo_id { get; set; }
        public string fis_numarasi { get; set; }
        public DateTime olusturulma_zamani { get; set; } = DateTime.Now;


    }
}
