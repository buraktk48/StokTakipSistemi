using StokTakipSistemi.Data;
using StokTakipSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Services
{
    public class DepoService
    {

        public bool DepoEkle(string depoad,string lokasyon,int ekleyen_kullanici_id,out string mesaj)
        {
            using (var context = new AppDbContext())
            {
                //2.Güvenlik Kontrolü
                if (string.IsNullOrWhiteSpace(depoad) || string.IsNullOrEmpty(lokasyon))

                {
                    mesaj = "Ürün bilgileri boş olamaz!";
                    return false;

                }

                //Aynı depodan var mı
                bool varMi = context.Depolar.Any(u => u.ad == depoad);
                if (varMi)
                {
                    mesaj = "Bu depo zaten listede var!";
                    return false;
                }

                var yeni_depo = new Depo
                {
                    ad = depoad,
                    lokasyon = lokasyon,
                    olusturan_kullanici_id = ekleyen_kullanici_id

                };

                context.Depolar.Add(yeni_depo);
                context.SaveChanges();





            }
           




            mesaj = "Depo Girişi Başarılı";
            return true;


        }
        
        
    }
}
