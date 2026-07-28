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
                // 2.Güvenlik Kontrolü
                if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(soyad) ||
                    string.IsNullOrWhiteSpace(sifre) || string.IsNullOrWhiteSpace(ad))
                {
                    mesaj = "Kullanıcı bilgileri boş olamaz!";
                    return false; // Veritabanına kayıt işlemini başlamadan durdurmak için
                }

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
                    soyad = soyad,
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

        public bool GirisYap(string kullaniciAdi, string sifre, out string mesaj,out Kullanici giris_yapan_kullanici)
        {
            giris_yapan_kullanici = null;

            using (var context = new AppDbContext())
            {
                //2.Güvenlik Kontrolü

                if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrEmpty(sifre))
                {
                    mesaj = "Kullanıcı bilgileri boş olamaz!";
                    return false;

                }

                var kullanici = context.Kullanicilar.FirstOrDefault(u => u.kullanici_adi == kullaniciAdi && u.sifre == sifre);


                if (kullanici == null)
                {
                    mesaj = "Kullanıcı Adı veya Şifre Yanlış!";
                    return false;

                }



                if (kullanici.kullanici_durum == false)
                {
                    mesaj = "Bu hesap artık aktif değildir.! Lütfen yöneticinizle iletişime geçin.";
                    return false;
                }



                mesaj = "Giriş Başarılı!";

                giris_yapan_kullanici = kullanici;
                return true;


                



            }


            





        }




    }
}
