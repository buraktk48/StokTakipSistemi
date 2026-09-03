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
            if (sepet == null || sepet.Count == 0)
            {
                mesaj = "Transfer sepeti boş olamaz!";
                return false;
            }
            
            using (var context = new AppDbContext())
            {

                //Stok kontrol
                foreach (var item in sepet)
                {
                    var cikis_stok = context.DepoStoklari.FirstOrDefault(s => s.depo_id == item.cikis_depo_id && s.urun_id == item.urun_id);

                    if (cikis_stok == null)
                    {
                        mesaj = $"Hata: Çıkış deposunda '{item.Urun_Adi}' ürünü bulunamadı!";
                        return false;
                    }

                    if (cikis_stok.miktar < item.miktar)
                    {
                        mesaj = $"Hata: Çıkış deposunda '{item.Urun_Adi}' için yeterli stok yok! (Mevcut Stok: {cikis_stok.miktar}, Talep Edilen: {item.miktar})";
                        return false;
                    }
                }

                // 2. ADIM: Transfer ana kaydını oluştur
                var yeniTransfer = new Transfer
                {
                    cikis_depo_id = sepet[0].cikis_depo_id,
                    varis_depo_id= sepet[0].varis_depo_id,
                    fis_numarasi = sepet[0].Fis_Numarasi,
                    transfer_kullanici_id = kullanici_id,
                    olusturulma_zamani = sepet[0].tarih

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

                    var cikis_deposu = context.DepoStoklari.FirstOrDefault(s => s.depo_id == item.cikis_depo_id && s.urun_id == item.urun_id);

                    if (cikis_deposu!=null)
                    {
                        cikis_deposu.miktar -= transferDetay.miktar;
                    }


                    var varis_deposu = context.DepoStoklari.FirstOrDefault(s => s.depo_id == item.varis_depo_id && s.urun_id == item.urun_id);

                    if (varis_deposu != null)
                    {
                        varis_deposu.miktar += transferDetay.miktar;
                    }
                    else
                    {
                        var depoStok = new DepoStok()
                        {
                            depo_id = item.varis_depo_id,
                            urun_id = item.urun_id,
                            miktar= item.miktar,
                            olusturan_kullanici_id = kullanici_id

                        };

                        context.DepoStoklari.Add(depoStok);
                    }

                    context.TransferDetaylari.Add(transferDetay);
                    context.SaveChanges();
                



                }

                



            }
            mesaj = "Transfer Girişi Başarıyla Gerçekleşmiştir!";

            return true;
        }

        
        

    }
}
