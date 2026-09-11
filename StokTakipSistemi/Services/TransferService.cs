using Microsoft.EntityFrameworkCore;
using StokTakipSistemi.Data;
using StokTakipSistemi.Entities;
using StokTakipSistemi.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StokTakipSistemi.Services
{
    public class TransferService
    {
        public bool TransferEkle(List<TransferListe> sepet, int kullanici_id, out string mesaj)
        {
            if (sepet == null || sepet.Count == 0)
            {
                mesaj = "Transfer sepeti boş olamaz!";
                return false;
            }

            try
            {
                using (var context = new AppDbContext())
                {
                    // Depo Çıkış ve Varış Çakışma Kontrolü
                    if (sepet.Any(x => x.cikis_depo_id == x.varis_depo_id))
                    {
                        mesaj = "Çıkış deposu ile varış deposu aynı olamaz!";
                        return false;
                    }

                    // Tüm ürünler için stok yeterlilik kontrolü
                    foreach (var item in sepet)
                    {
                        var cikis_stok = context.DepoStoklari
                            .FirstOrDefault(s => s.depo_id == item.cikis_depo_id && s.urun_id == item.urun_id);

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

                    // DB Transaction 
                    using (var transaction = context.Database.BeginTransaction())
                    {
                        try
                        {
                            // Transfer Ana Kaydı
                            var yeniTransfer = new Transfer
                            {
                                cikis_depo_id = sepet[0].cikis_depo_id,
                                varis_depo_id = sepet[0].varis_depo_id,
                                fis_numarasi = sepet[0].Fis_Numarasi,
                                transfer_kullanici_id = kullanici_id,
                                olusturulma_zamani = sepet[0].tarih
                            };

                            context.Transferler.Add(yeniTransfer);
                            context.SaveChanges(); // Fiş ID

                            // Transfer Detayları ve Stok Güncellemeleri
                            foreach (var item in sepet)
                            {
                                var transferDetay = new TransferDetay
                                {
                                    transfer_id = yeniTransfer.id,
                                    urun_id = item.urun_id,
                                    miktar = item.miktar
                                };

                                context.TransferDetaylari.Add(transferDetay);

                                // Çıkış Deposu Stok Düşüşü
                                var cikis_deposu = context.DepoStoklari
                                    .FirstOrDefault(s => s.depo_id == item.cikis_depo_id && s.urun_id == item.urun_id);

                                if (cikis_deposu != null)
                                {
                                    cikis_deposu.miktar -= item.miktar;
                                }

                                // Varış Deposu Stok Artışı
                                var varis_deposu = context.DepoStoklari
                                    .FirstOrDefault(s => s.depo_id == item.varis_depo_id && s.urun_id == item.urun_id);

                                if (varis_deposu != null)
                                {
                                    varis_deposu.miktar += item.miktar;
                                }
                                else
                                {
                                    var depoStok = new DepoStok()
                                    {
                                        depo_id = item.varis_depo_id,
                                        urun_id = item.urun_id,
                                        miktar = item.miktar,
                                        olusturan_kullanici_id = kullanici_id
                                    };

                                    context.DepoStoklari.Add(depoStok);
                                }
                            }

                            context.SaveChanges();
                            transaction.Commit(); // Tüm veritabanı değişikliklerini onayla

                            mesaj = "Transfer Girişi Başarıyla Gerçekleşmiştir!";
                            return true;
                        }
                        catch
                        {
                            transaction.Rollback(); // Hata durumunda yapılan tüm DB değişikliklerini geri al
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mesaj = "Transfer işlemi sırasında veritabanı hatası oluştu: " + ex.Message;
                return false;
            }
        }
    }
}
