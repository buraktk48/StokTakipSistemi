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
            
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=StokTakipDb;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Decimal Uyarisi Icin Precision Ayarları
            modelBuilder.Entity<TransferDetay>().Property(u => u.miktar).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<DepoStok>().Property(u => u.miktar).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Urun>().Property(u => u.kdv).HasColumnType("decimal(18,2)");


            //Seed Data( Başlangıç Verileri)

            modelBuilder.Entity<Rol>().HasData(
                new Rol { id = 1, adi = "Admin" },
                new Rol { id = 2, adi = "Personel" }
            );

            modelBuilder.Entity<Kullanici>().HasData(
                new Kullanici
                {
                    id = 1,
                    ad = "Yonetici",
                    soyad ="Hesap",
                    kullanici_durum = true,
                    kullanici_adi = "admin",
                    sifre = "123456",
                    rol_id = 1 
                }
            );

            modelBuilder.Entity<Depo>().HasData(
                new Depo { id = 1, ad = "Ana Depo", lokasyon = "Merkez" }
            );






        }



    }

}

