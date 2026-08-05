using DocumentFormat.OpenXml.InkML;
using StokTakipSistemi.Data;
using StokTakipSistemi.Entities;
using StokTakipSistemi.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Services
{
    internal class TransferService
    {
        public bool TransferEkle(List<TransferListe> sepet, int kullanici_id,
            out string mesaj)
        {
            using (var context = new AppDbContext())
            {
                var yeniTransfer = new Transfer
                {
                    cikis_depo_id = sepet[0].cikis_depo_id,
                    varis_depo_id= sepet[0].varis_depo_id,
                    fis_numarasi = sepet[0].Fis_Numarasi,
                    transfer_kullanici_id = kullanici_id

                };

                context.Transferler.Add(yeniTransfer);
                context.SaveChanges();

                foreach (var item in sepet)
                {
                    var transferDetay = new TransferDetay
                    {
                        transfer_id = yeniTransfer.id,
                        urun_id = item.urun_id,
                        miktar = item.miktar
                    };

                    context.TransferDetaylari.Add(transferDetay);
                    context.SaveChanges();

                    var cikis_stok = context.DepoStoklari.FirstOrDefault(s => s.depo_id == item.cikis_depo_id
                && s.urun_id == item.urun_id);

                    var varis_stok = context.DepoStoklari.FirstOrDefault(s => s.depo_id == item.varis_depo_id
                && s.urun_id == item.urun_id);

                if (varis_stok == null)
                {
                    mesaj = "Hata: Varış Deposunda belirtilen ürün bulunamadı.";
                    return false;
                }

                if (cikis_stok == null)
                {
                    mesaj = "Hata: Çıkış Deposunda belirtilen ürün bulunamadı.";
                    return false;
                }
                if (cikis_stok.miktar < item.miktar)
                {
                    mesaj = "Hata: Çıkış Deposunda yeterli ürün bulunamadı.";
                    return false;
                }

                



                }

                



            }
            mesaj = "Transfer Girişi Başarıyla Gerçekleşmiştir!";

            return true;
        }

        

    }
}
