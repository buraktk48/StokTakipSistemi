using StokTakipSistemi.Data;
using StokTakipSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Services
{
    internal class KullaniciService
    {
        // Kullanıcı Kayıt Metodu
        public bool KayitOl(string kullaniciAdi, string sifre, string ad,string soyad ,out string mesaj)
        {
            using (var context = new AppDbContext())
            {
                // 1. Kullanıcı adı kontrolü
                bool varMi = context.Kullanicilar.Any(u => u.kullanici_adi == kullaniciAdi);
                if (varMi)
                {
                    mesaj = "Bu kullanıcı adı zaten kullanılıyor!";
                    return false;
                }

                // 2. Yeni Kullanıcı Nesnesi
                var yeniKullanici = new Kullanici
                {
                    kullanici_adi = kullaniciAdi,
                    sifre = sifre,
                    ad = ad,
                    rol_id = 2, // Personel
                    kullanici_durum = true
                };

                //Veritabanına ekleme ve kaydetme
                context.Kullanicilar.Add(yeniKullanici);
                context.SaveChanges();

                mesaj = "Kayıt başarıyla oluşturuldu!";
                return true;
            }
        }




    }
}
