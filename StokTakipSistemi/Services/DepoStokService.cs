using StokTakipSistemi.Data;
using StokTakipSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Services
{
    internal class DepoStokService
    {
        public bool StokIslemiYap(int depoId, int urunId, decimal miktar, bool stokEkleMi, int kullaniciId, out string mesaj)
        {
            using (var context = new AppDbContext())
            {
                
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
    }
}

    

