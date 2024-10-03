using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3___Net.DAL
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MSI;Database=QUANLYSPNET;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("SANPHAM");
                entity.HasKey(e => e.MaSP);
                entity.Property(e => e.MaSP).HasColumnName("MASP");
                entity.Property(e => e.TenSP).HasColumnName("TENSP");
                entity.Property(e => e.SoLuong).HasColumnName("SOLUONG");
                entity.Property(e => e.DonGia).HasColumnName("DONGIA");
                entity.Property(e => e.XuatXu).HasColumnName("XUATXU");
                entity.Property(e => e.NgayHetHan).HasColumnName("NGAYHETHAN");
            });
        }
    }
}
