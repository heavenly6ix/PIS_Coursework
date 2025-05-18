using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Runtime.InteropServices;

namespace DataAccess.Models;
public static class DbContextFactory
{
    public static LibraryContext Create()
    {
        var connStr = ConnectionStringProvider.Instance.ConnectionString;
        var options = new DbContextOptionsBuilder<LibraryContext>()
            .UseNpgsql(connStr)
            .Options;
        return new LibraryContext(options);
    }
}

public partial class LibraryContext : DbContext
{
    public LibraryContext()
    {
    }

    public LibraryContext(DbContextOptions<LibraryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CompletedOrder> CompletedOrders { get; set; }

    public virtual DbSet<Courier> Couriers { get; set; }

    public virtual DbSet<Manager> Managers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }

    public virtual DbSet<StockAdmin> StockAdmins { get; set; }

    public virtual DbSet<TakenOrder> TakenOrders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresEnum("status_enum", new[] { "Создан", "Принят в доставку", "Доставляется", "Доставлен" });

        modelBuilder.Entity<CompletedOrder>(entity =>
        {
            entity.HasKey(e => e.IdTakenOrder).HasName("completed_orders_pkey");

            entity.ToTable("completed_orders");

            entity.Property(e => e.IdTakenOrder).HasColumnName("id_taken_order");
            entity.Property(e => e.DeliveryDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("delivery_date");
            entity.Property(e => e.IdCourier).HasColumnName("id_courier");
            entity.Property(e => e.IdManager).HasColumnName("id_manager");
            entity.Property(e => e.IdOrder).HasColumnName("id_order");

            entity.HasOne(d => d.IdCourierNavigation).WithMany(p => p.CompletedOrders)
                .HasForeignKey(d => d.IdCourier)
                .HasConstraintName("completed_orders_id_courier_fkey");

            entity.HasOne(d => d.IdOrderNavigation).WithMany(p => p.CompletedOrders)
                .HasForeignKey(d => d.IdOrder)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("completed_orders_id_order_fkey");
        });

        modelBuilder.Entity<Courier>(entity =>
        {
            entity.HasKey(e => e.IdCourier).HasName("courier_pkey");

            entity.ToTable("courier");

            entity.Property(e => e.IdCourier).HasColumnName("id_courier");
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .HasColumnName("full_name");
            entity.Property(e => e.HashPassword)
                .HasMaxLength(50)
                .HasColumnName("hash_password");
            entity.Property(e => e.Login)
                .HasMaxLength(20)
                .HasColumnName("login");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(10)
                .HasColumnName("phone_number");
        });

        modelBuilder.Entity<Manager>(entity =>
        {
            entity.HasKey(e => e.IdManager).HasName("manager_pkey");

            entity.ToTable("manager");

            entity.Property(e => e.IdManager).HasColumnName("id_manager");
            entity.Property(e => e.DeliveryAdress)
                .HasMaxLength(50)
                .HasColumnName("delivery_adress");
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .HasColumnName("full_name");
            entity.Property(e => e.HashPassword)
                .HasMaxLength(50)
                .HasColumnName("hash_password");
            entity.Property(e => e.Login)
                .HasMaxLength(20)
                .HasColumnName("login");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(10)
                .HasColumnName("phone_number");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.IdOrder).HasName("orders_pkey");

            entity.ToTable("orders");

            entity.Property(e => e.IdOrder).HasColumnName("id_order");
            entity.Property(e => e.CreatedDate)
            .HasColumnType("timestamp without time zone")
            .HasColumnName("created_date");
            entity.Property(e => e.IdManager).HasColumnName("id_manager");
            entity.Property(e => e.IsCart).HasColumnName("is_cart");


            entity.HasOne(d => d.IdManagerNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdManager)
                .HasConstraintName("orders_id_manager_fkey");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => new { e.IdOrderItem }).HasName("id_order_item_pkey");

            entity.ToTable("order_items");

            entity.Property(e => e.IdOrderItem).HasColumnName("id_order_item");
            entity.Property(e => e.IdOrder).HasColumnName("id_order");
            entity.Property(e => e.IdProduct).HasColumnName("id_product");
            entity.Property(e => e.CountProduct).HasColumnName("count_product");

            entity.HasOne(d => d.IdOrderNavigation).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.IdOrder)
                .HasConstraintName("order_items_id_order_fkey");

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.IdProduct)
                .HasConstraintName("order_items_id_product_fkey");
        });

        modelBuilder.Entity<Stock>(entity =>
        {
            entity.HasKey(e => e.IdProduct).HasName("stock_pkey");

            entity.ToTable("stock");

            entity.Property(e => e.IdProduct).HasColumnName("id_product");
            entity.Property(e => e.CountInStock).HasColumnName("count_in_stock");
            entity.Property(e => e.NameProduct)
                .HasMaxLength(50)
                .HasColumnName("name_product");
            entity.Property(e => e.TypeProduct)
                .HasMaxLength(50)
                .HasColumnName("type_product");
        });

        modelBuilder.Entity<StockAdmin>(entity =>
        {
            entity.HasKey(e => e.IdAdmin).HasName("stock_admin_pkey");

            entity.ToTable("stock_admin");

            entity.Property(e => e.IdAdmin).HasColumnName("id_admin");
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .HasColumnName("full_name");
            entity.Property(e => e.HashPassword)
                .HasMaxLength(50)
                .HasColumnName("hash_password");
            entity.Property(e => e.Login)
                .HasMaxLength(20)
                .HasColumnName("login");
        });

        modelBuilder.Entity<TakenOrder>(entity =>
        {
            entity.HasKey(e => e.IdTakenOrder).HasName("taken_orders_pkey");

            entity.ToTable("taken_orders");

            entity.Property(e => e.IdTakenOrder).HasColumnName("id_taken_order");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_date");
            entity.Property(e => e.IdCourier).HasColumnName("id_courier");
            entity.Property(e => e.IdManager).HasColumnName("id_manager");
            entity.Property(e => e.IdOrder).HasColumnName("id_order");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.IdCourierNavigation).WithMany(p => p.TakenOrders)
                .HasForeignKey(d => d.IdCourier)
                .HasConstraintName("taken_orders_id_courier_fkey");

            entity.HasOne(d => d.IdOrderNavigation).WithMany(p => p.TakenOrders)
                .HasForeignKey(d => d.IdOrder)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("taken_orders_id_order_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
