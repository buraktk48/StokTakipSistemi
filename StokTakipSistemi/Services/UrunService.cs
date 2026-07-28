using StokTakipSistemi.Data;
using StokTakipSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Services
{
    internal class UrunService
    {
        //Ürün Ekleme

        public bool ManuelUrunGiris(string urunkodu, string urunadi, string urunbirim, int ekleyenkullaniciid,decimal urunkdv , out string mesaj)
        {
            using (var context = new AppDbContext())
            {
                //2.Güvenlik Kontrolü
                if (string.IsNullOrWhiteSpace(urunkodu) || string.IsNullOrEmpty(urunadi) ||
                    string.IsNullOrWhiteSpace(urunbirim))
                {
                    mesaj = "Ürün bilgileri boş olamaz!";
                    return false;

                }


                if (urunkdv < 0)
                {
                    mesaj = "KDV oranı 0'dan küçük olamaz!";
                    return false;
                }


                //Aynı üründen var mı
                bool varMi = context.Urunler.Any(u => u.urun_kodu == urunkodu);
                if (varMi)
                {
                    mesaj = "Bu ürün kodu zaten listede var!";
                    return false;
                }



                // Ürün nesnesi
                var yeni_urun = new Urun
                {
                    urun_kodu = urunkodu,
                    urun_adi = urunadi,
                    birim = urunbirim,
                    kdv = urunkdv,
                    ekleyen_kullanici_id = ekleyenkullaniciid

                };



                context.Urunler.Add(yeni_urun);
                context.SaveChanges();



                mesaj = "Ürün Girişi Başarıyla Gerçekleşmiştir!";

                return true;



            }

            
        }
    }
}
