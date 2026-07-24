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
            
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=StokTakipDb;Trusted_Connection=True;");
        }
    }

}

