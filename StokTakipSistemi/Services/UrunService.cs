using StokTakipSistemi.Data;
using StokTakipSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
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

        //Urun Guncelleme

        public bool UrunGuncelle(int urunId, string urunkodu, string urunadi, string urunbirim, decimal urunkdv, out string mesaj)
        {
            using (var context = new AppDbContext())
            {
                var urun = context.Urunler.FirstOrDefault(u => u.id == urunId);
                if (urun == null)
                {
                    mesaj = "Güncellenecek ürün bulunamadı!";
                    return false;
                }

                if (string.IsNullOrWhiteSpace(urunkodu) || string.IsNullOrWhiteSpace(urunadi) || string.IsNullOrWhiteSpace(urunbirim))
                {
                    mesaj = "Ürün bilgileri boş olamaz!";
                    return false;
                }

                if (urunkdv < 0)
                {
                    mesaj = "KDV oranı 0'dan küçük olamaz!";
                    return false;
                }

                bool kodVarMi = context.Urunler.Any(u => u.urun_kodu == urunkodu && u.id != urunId);
                if (kodVarMi)
                {
                    mesaj = "Bu ürün kodu başka bir ürün için zaten kullanılıyor!";
                    return false;
                }

                urun.urun_kodu = urunkodu;
                urun.urun_adi = urunadi;
                urun.birim = urunbirim;
                urun.kdv = urunkdv;

                context.SaveChanges();
                mesaj = "Ürün bilgileri başarıyla güncellendi!";
                return true;
            }
        }


        public bool UrunSilme(int urunid,out string gelenmesaj)
        {
            using (var context = new AppDbContext())
            {
                var sonuc = context.Urunler.Find(urunid);

                if (sonuc != null)
                {
                    context.Urunler.Remove(sonuc);
                    context.SaveChanges();
                }



            }


            gelenmesaj = "Silme İşlemi Başarılı!";

            return true;
        }


    }
}
