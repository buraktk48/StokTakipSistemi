using Microsoft.EntityFrameworkCore;
using StokTakipSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Depo> Depolar { get; set; }
        public DbSet<DepoStok> DepoStoklari { get; set; }
        public DbSet<Transfer> Transferler { get; set; }
        public DbSet<TransferDetay> TransferDetaylari { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Rol> Roller { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=StokTakipDb;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Decimal Uyarisi Icin Precision Ayarları
            modelBuilder.Entity<TransferDetay>().Property(u => u.miktar).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<DepoStok>().Property(u => u.miktar).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Urun>().Property(u => u.kdv).HasColumnType("decimal(18,2)");



            modelBuilder.Entity<Kullanici>()
                .HasOne(u => u.rol)                  // 1. Kullanıcı'nın BİR TANE 'rol' Nesnesi vardır.
                .WithMany()                          // 2. Bir Rol'ün ÇOKÇA Kullanıcısı olabilir.
                .HasForeignKey(u => u.rol_id)        // 3. Bu bağ 'rol_id' sayısal sütunu üzerinden kurulur!
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Transfer>()
                .HasOne(t => t.cikis_depo)
                .WithMany()
                .HasForeignKey(t => t.cikis_depo_id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Transfer>()
                .HasOne(t => t.varis_depo)
                .WithMany()
                .HasForeignKey(t => t.varis_depo_id)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<DepoStok>()
                .HasOne(t => t.olusturan_kullanici)
                .WithMany()
                .HasForeignKey(t => t.olusturan_kullanici_id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Urun>()
                .HasOne(u => u.ekleyen_kullanici)
                .WithMany()
                .HasForeignKey(u => u.ekleyen_kullanici_id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Depo>()
                .HasOne(d => d.olusturan_kullanici)
                .WithMany()
                .HasForeignKey(d => d.olusturan_kullanici_id)
                .OnDelete(DeleteBehavior.Restrict);





            //Seed Data( Başlangıç Verileri)

            modelBuilder.Entity<Rol>().HasData(
                new Rol { id = 1, adi = "Admin", olusturulma_zamani = new DateTime(2026, 1, 1) },
                new Rol { id = 2, adi = "Personel", olusturulma_zamani = new DateTime(2026, 1, 1) }
            );

            modelBuilder.Entity<Kullanici>().HasData(
                new Kullanici
                {
                    id = 1,
                    ad = "Yonetici",
                    soyad = "Hesap",
                    kullanici_durum = true,
                    kullanici_adi = "admin",
                    sifre = "123456",
                    rol_id = 1,
                    olusturulma_zamani = new DateTime(2026, 1, 1)
                }
            );

          





        }



    }

}

