using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BlazorDemo.Models;

public partial class ContosoCraftsContext : DbContext
{
    public ContosoCraftsContext()
    {
    }

    public ContosoCraftsContext(DbContextOptions<ContosoCraftsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Rating> Ratings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=contoso-crafts.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("products");

            entity.Property(e => e.Id).HasColumnType("NVARCHAR(255)");
            entity.Property(e => e.Maker).HasColumnType("NVARCHAR(100)");
            entity.Property(e => e.Title).HasColumnType("NVARCHAR(255)");
        });

        modelBuilder.Entity<Rating>(entity =>
        {
            entity.ToTable("ratings");

            entity.Property(e => e.ProductId).HasColumnType("nvarchar(255)");

            entity.HasOne(d => d.Product).WithMany(p => p.Ratings).HasForeignKey(d => d.ProductId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
