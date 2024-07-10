using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Configuration;
namespace Question2.Models;

public partial class Prn212TrialContext : DbContext
{
    public Prn212TrialContext()
    {
    }

    public Prn212TrialContext(DbContextOptions<Prn212TrialContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<ItemVarian> ItemVarians { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<Service> Services { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        IConfigurationRoot configuration = builder.Build();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("SonicStore"));
    }
        

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CatId).HasName("PK__categori__17B6DD2626DFB1BA");

            entity.Property(e => e.CatId).ValueGeneratedNever();

            entity.HasOne(d => d.Item).WithMany(p => p.Categories).HasConstraintName("FK__categorie__itemI__38996AB5");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasName("PK__items__56A128AA0267349B");

            entity.Property(e => e.ItemId).ValueGeneratedNever();
        });

        modelBuilder.Entity<ItemVarian>(entity =>
        {
            entity.HasKey(e => e.VariantId).HasName("PK__itemVari__69E44B2DE8741F5C");

            entity.Property(e => e.VariantId).ValueGeneratedNever();

            entity.HasOne(d => d.Item).WithMany(p => p.ItemVarians).HasConstraintName("FK__itemVaria__itemI__3B75D760");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasOne(d => d.EmployeeNavigation).WithMany(p => p.Services).HasConstraintName("FK_Services_Employees");

            entity.HasOne(d => d.RoomTitleNavigation).WithMany(p => p.Services).HasConstraintName("FK_Services_Rooms");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
