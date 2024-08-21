using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PMS_Api.Model.Scaffold;

public partial class PmsContext : DbContext
{
    public PmsContext()
    {
    }

    public PmsContext(DbContextOptions<PmsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("Server=localhost;Port=3308;Database=pms;uid=root;pwd=root;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("admins");

            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Uuid).HasMaxLength(36);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("products");

            entity.Property(e => e.DateOfCreation)
                .HasColumnType("datetime")
                .HasColumnName("dateOfCreation");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
