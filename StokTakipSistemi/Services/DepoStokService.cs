using Microsoft.EntityFrameworkCore;
using StokTakipSistemi.Data;
using StokTakipSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Services
{
    public class DepoStokService
    {
        public bool StokIslemiYap(int depoId, int urunId, decimal miktar, bool stokEkleMi, int kullaniciId, out string mesaj)
        {
            try
            {
                if (miktar <= 0)
                {
                    mesaj = "İşlem miktarı 0'dan büyük olmalıdır!";
                    return false;
                }

                using (var context = new AppDbContext())
                {
                    var depoVarMi = context.Depolar.AsNoTracking().Any(d => d.id == depoId);
                    if (!depoVarMi)
                    {
                        mesaj = "İşlem yapılacak depo bulunamadı!";
                        return false;
                    }

                    var urunVarMi = context.Urunler.AsNoTracking().Any(u => u.id == urunId);
                    if (!urunVarMi)
                    {
                        mesaj = "İşlem yapılacak ürün bulunamadı!";
                        return false;
                    }

                    var depoStok = context.DepoStoklari.FirstOrDefault(ds => ds.depo_id == depoId && ds.urun_id == urunId);

                    if (stokEkleMi) 
                    {
                        if (depoStok != null)
                        {
                            depoStok.miktar += miktar;
                        }
                        else
                        {
                            var yeniStok = new DepoStok
                            {
                                depo_id = depoId,
                                urun_id = urunId,
                                miktar = miktar,
                                olusturan_kullanici_id = kullaniciId
                            };
                            context.DepoStoklari.Add(yeniStok);
                        }

                        context.SaveChanges();
                        mesaj = "Stok başarıyla eklendi.";
                        return true;
                    }
                    else 
                    {
                        if (depoStok == null)
                        {
                            mesaj = "Bu depoda seçilen ürün stokta bulunmamaktadır!";
                            return false;
                        }
                        if (depoStok.miktar < miktar)
                        {
                            mesaj = $"Yetersiz stok! Depodaki mevcut miktar: {depoStok.miktar}";
                            return false;
                        }

                        depoStok.miktar -= miktar;
                        context.SaveChanges();

                        mesaj = "Stok düşürme işlemi başarıyla uygulandı.";
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                mesaj = "Stok işlemi sırasında veritabanı hatası oluştu: " + ex.Message;
                return false;
            }
        }
    }
}

    

