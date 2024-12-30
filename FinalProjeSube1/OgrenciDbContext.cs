using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjeSube1
{
    internal class OgrenciDbContext : DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<OgrenciDers> OgrenciDersler { get; set; }
        public DbSet<Sinif> Siniflar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source = localhost;Initial Catalog = FinalProjeDB;Integrated Security = true;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Sinif>().Property(s => s.SinifAd).HasColumnType("varchar").HasMaxLength(5).IsRequired();
            modelBuilder.Entity<Sinif>().Property(s => s.Kontenjan).HasColumnType("varchar").HasMaxLength(5).IsRequired();

            modelBuilder.Entity<Ders>().Property(d => d.DersKod).HasColumnType("varchar").HasMaxLength(10).IsRequired();
            modelBuilder.Entity<Ders>().Property(d => d.DersAd).HasColumnType("varchar").HasMaxLength(30).IsRequired();

            modelBuilder.Entity<Ogrenci>().Property(o => o.Ad).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Ogrenci>().Property(o => o.Soyad).HasColumnType("varchar").HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Ogrenci>().Property(o => o.Numara).HasColumnType("varchar").HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Ogrenci>().Property(o => o.SinifId).HasColumnType("varchar").HasMaxLength(5).IsRequired();

            



            modelBuilder.Entity<Ogrenci>().HasOne(o => o.Sinif).WithMany(s => s.Ogrenciler).HasForeignKey(o => o.SinifId);
            modelBuilder.Entity<OgrenciDers>().HasKey(od => new { od.OgrenciId, od.DersId });   

            modelBuilder.Entity<OgrenciDers>().HasOne(od => od.Ogrenci).WithMany(o => o.OgrenciDersler).HasForeignKey(od => od.OgrenciId);

            modelBuilder.Entity<OgrenciDers>().HasOne(od => od.Ders).WithMany(d => d.OgrenciDersler).HasForeignKey(od => od.DersId);


        }
    }
}
