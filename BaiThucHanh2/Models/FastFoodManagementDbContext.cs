using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BaiThucHanh2.Models;

public partial class FastFoodManagementDbContext : DbContext
{
    public FastFoodManagementDbContext()
    {
    }

    public FastFoodManagementDbContext(DbContextOptions<FastFoodManagementDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Ingredient> Ingredients { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }

    public virtual DbSet<PurchaseInvoiceItem> PurchaseInvoiceItems { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=MSI;Initial Catalog=FastFoodManagementDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Branch>(entity =>
        {
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Location).HasMaxLength(256);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(15);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(e => e.Image).HasMaxLength(256);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasIndex(e => e.BranchId, "IX_Employees_BranchId");

            entity.HasIndex(e => e.PositionId, "IX_Employees_PositionId");

            entity.Property(e => e.Cccd)
                .HasMaxLength(15)
                .HasColumnName("CCCD");
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Location).HasMaxLength(256);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(15);

            entity.HasOne(d => d.Branch).WithMany(p => p.Employees).HasForeignKey(d => d.BranchId);

            entity.HasOne(d => d.Position).WithMany(p => p.Employees).HasForeignKey(d => d.PositionId);
        });

        modelBuilder.Entity<Ingredient>(entity =>
        {
            entity.Property(e => e.Image).HasMaxLength(256);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Unit).HasMaxLength(50);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasIndex(e => e.BranchId, "IX_Orders_BranchId");

            entity.HasIndex(e => e.PaymentMethodId, "IX_Orders_PaymentMethodId");

            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Branch).WithMany(p => p.Orders).HasForeignKey(d => d.BranchId);

            entity.HasOne(d => d.PaymentMethod).WithMany(p => p.Orders).HasForeignKey(d => d.PaymentMethodId);
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.ProductId });

            entity.HasIndex(e => e.ProductId, "IX_OrderItems_ProductId");

            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderItems).HasForeignKey(d => d.OrderId);

            entity.HasOne(d => d.Product).WithMany(p => p.OrderItems).HasForeignKey(d => d.ProductId);
        });

        modelBuilder.Entity<PaymentMethod>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasIndex(e => e.CategoryId, "IX_Products_CategoryId");

            entity.Property(e => e.Image).HasMaxLength(256);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Category).WithMany(p => p.Products).HasForeignKey(d => d.CategoryId);
        });

        modelBuilder.Entity<PurchaseInvoice>(entity =>
        {
            entity.HasIndex(e => e.BranchId, "IX_PurchaseInvoices_BranchId");

            entity.HasIndex(e => e.EmployeeId, "IX_PurchaseInvoices_EmployeeId");

            entity.HasIndex(e => e.SupplierId, "IX_PurchaseInvoices_SupplierId");

            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Branch).WithMany(p => p.PurchaseInvoices).HasForeignKey(d => d.BranchId);

            entity.HasOne(d => d.Employee).WithMany(p => p.PurchaseInvoices)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Supplier).WithMany(p => p.PurchaseInvoices)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<PurchaseInvoiceItem>(entity =>
        {
            entity.HasKey(e => new { e.PurchaseInvoiceId, e.IngredientId });

            entity.HasIndex(e => e.IngredientId, "IX_PurchaseInvoiceItems_IngredientId");

            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Ingredient).WithMany(p => p.PurchaseInvoiceItems).HasForeignKey(d => d.IngredientId);

            entity.HasOne(d => d.PurchaseInvoice).WithMany(p => p.PurchaseInvoiceItems).HasForeignKey(d => d.PurchaseInvoiceId);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasIndex(e => e.BranchId, "IX_Suppliers_BranchId");

            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Location).HasMaxLength(256);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(15);

            entity.HasOne(d => d.Branch).WithMany(p => p.Suppliers).HasForeignKey(d => d.BranchId);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(e => e.BranchId, "IX_Users_BranchId");

            entity.HasIndex(e => e.RoleId, "IX_Users_RoleId");

            entity.HasIndex(e => e.Username, "IX_Users_Username").IsUnique();

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(256);
            entity.Property(e => e.Phone).HasMaxLength(15);
            entity.Property(e => e.Username).HasMaxLength(50);

            entity.HasOne(d => d.Branch).WithMany(p => p.Users).HasForeignKey(d => d.BranchId);

            entity.HasOne(d => d.Role).WithMany(p => p.Users).HasForeignKey(d => d.RoleId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
