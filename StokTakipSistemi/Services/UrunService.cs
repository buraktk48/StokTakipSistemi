using Microsoft.EntityFrameworkCore;
using StokTakipSistemi.Data;
using StokTakipSistemi.Entities;
using System;
using System.Linq;

namespace StokTakipSistemi.Services
{
    public class UrunService
    {
        // Ürün Ekleme
        public bool ManuelUrunGiris(string urunkodu, string urunadi, string urunbirim, int ekleyenkullaniciid, decimal urunkdv, out string mesaj)
        {
            try
            {
                using (var context = new AppDbContext())
                {
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

                    bool varMi = context.Urunler.AsNoTracking().Any(u => u.urun_kodu == urunkodu);
                    if (varMi)
                    {
                        mesaj = "Bu ürün kodu zaten listede var!";
                        return false;
                    }

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
                }

                mesaj = "Ürün Girişi Başarıyla Gerçekleşmiştir!";
                return true;
            }
            catch (Exception ex)
            {
                mesaj = "Ürün kaydı sırasında hata oluştu: " + ex.Message;
                return false;
            }
        }

        // Ürün Güncelleme
        public bool UrunGuncelle(int urunId, string urunkodu, string urunadi, string urunbirim, decimal urunkdv, out string mesaj)
        {
            try
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

                    bool kodVarMi = context.Urunler.AsNoTracking().Any(u => u.urun_kodu == urunkodu && u.id != urunId);
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
            catch (Exception ex)
            {
                mesaj = "Ürün güncelleme sırasında hata oluştu: " + ex.Message;
                return false;
            }
        }

        // Ürün Silme
        public bool UrunSilme(int urunid, out string gelenmesaj)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var sonuc = context.Urunler.Find(urunid);
                    if (sonuc == null)
                    {
                        gelenmesaj = "Silinecek ürün bulunamadı!";
                        return false;
                    }

                    // Ürünün stok veya transfer kaydı var mı kontrolü
                    bool iliskiliKayitVar = context.DepoStoklari.Any(s => s.urun_id == urunid) || 
                                            context.TransferDetaylari.Any(td => td.urun_id == urunid);

                    if (iliskiliKayitVar)
                    {
                        gelenmesaj = "Bu ürüne ait depolarda stok kaydı veya transfer hareketi bulunduğu için silinemez!";
                        return false;
                    }

                    context.Urunler.Remove(sonuc);
                    context.SaveChanges();
                }

                gelenmesaj = "Silme İşlemi Başarılı!";
                return true;
            }
            catch (Exception ex)
            {
                gelenmesaj = "Ürün silme işlemi sırasında hata oluştu: " + ex.Message;
                return false;
            }
        }
    }
}
