using Microsoft.EntityFrameworkCore;
using StokTakipSistemi.Data;
using StokTakipSistemi.Entities;
using StokTakipSistemi.Migrations;
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
            try
            {
                using (var context = new AppDbContext())
                {
                    //2.Güvenlik Kontrolü
                    if (string.IsNullOrWhiteSpace(depoad) || string.IsNullOrEmpty(lokasyon))

                    {
                        mesaj = "Depo bilgileri boş olamaz!";
                        return false;

                    }

                    //Aynı depodan var mı
                    bool varMi = context.Depolar.AsNoTracking().Any(u => u.ad == depoad);
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
            catch (Exception ex)
            {
                mesaj = "Veritabanı işlemi sırasında bir hata oluştu: " + ex.Message;
                return false;
            }
            


        }
        
        public bool DepoGuncelle(int depoid,string depoad, string lokasyon,out string mesaj)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    bool kontrol = context.Depolar.AsNoTracking().Any(r => r.ad == depoad && r.id != depoid);

                    if (kontrol)
                    {
                        mesaj = "Bu depo adı zaten başka bir depoda mevcut!";
                        return false;
                    }

                    var depo = context.Depolar.FirstOrDefault(u => u.id == depoid);
                    if (depo == null)
                    {
                        mesaj = "Güncellenecek depo bulunamadı!";
                        return false;
                    }

                    if (string.IsNullOrWhiteSpace(depoad) || string.IsNullOrWhiteSpace(lokasyon))
                    {
                        mesaj = "Depo bilgileri boş olamaz!";
                        return false;
                    }

                    depo.ad = depoad;
                    depo.lokasyon = lokasyon;

                    context.SaveChanges();

                    mesaj = "Depo bilgileri başarıyla güncellendi!";
                    return true;
                }
            }
            catch (Exception ex)
            {
                mesaj = "Veritabanı işlemi sırasında bir hata oluştu: " + ex.Message;
                return false;
            }
        }

        public bool DepoSil(int depoid, out string mesaj)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var sonuc = context.Depolar.Find(depoid);

                    if (sonuc == null)
                    {
                        mesaj = "Silinecek depo bulunamadı!";
                        return false;
                    }

                    // Depoya ait stok veya transfer kaydı var mı kontrolü
                    bool iliskiliKayitVar = context.DepoStoklari.Any(s => s.depo_id == depoid) ||
                                            context.Transferler.Any(t => t.cikis_depo_id == depoid || t.varis_depo_id == depoid);

                    if (iliskiliKayitVar)
                    {
                        mesaj = "Bu depoya ait stok veya transfer hareketi bulunduğu için silinemez!";
                        return false;
                    }

                    context.Depolar.Remove(sonuc);
                    context.SaveChanges();
                }

                mesaj = "Silme İşlemi Başarılı!";
                return true;
            }
            catch (Exception ex)
            {
                mesaj = "Veritabanı işlemi sırasında bir hata oluştu: " + ex.Message;
                return false;
            }
        }






        
    }





}
