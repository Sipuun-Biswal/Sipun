using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirstApproachOneToMany.Models;

public partial class CompanyContext : DbContext
{
    public CompanyContext()
    {
    }

    public CompanyContext(DbContextOptions<CompanyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Credentialss> Credentialsses { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Employee1> Employees1 { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Sipun> Sipuns { get; set; }

    public virtual DbSet<Table1> Table1s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { 
}


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasIndex(e => e.AuthorId, "IX_Books_AuthorId");

            entity.HasOne(d => d.Author).WithMany(p => p.Books).HasForeignKey(d => d.AuthorId);
        });
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasMany(e => e.Products)
                .WithOne(e => e.Category)
                .HasForeignKey(e => e.CategoryId);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(e => e.Category)
                .WithMany(e => e.Products)
                .HasForeignKey(e => e.CategoryId);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Category__19093A0B8BF0FBC0");

            entity.ToTable("Category");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Credentialss>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Credenti__3213E83FB6587154");

            entity.ToTable("Credentialss");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Names)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("names");
            entity.Property(e => e.Passwords)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC072A98D13C");

            entity.ToTable("Employee");

            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Salary).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<Employee1>(entity =>
        {
            entity.HasKey(e => e.Slno).HasName("PK__Employee__32DD162D41494062");

            entity.ToTable("Employees");

            entity.Property(e => e.Slno).HasColumnName("slno");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Domain)
                .HasMaxLength(50)
                .HasColumnName("domain");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Product__B40CC6CD868EC385");

            entity.ToTable("Product");

            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__Product__Categor__2B0A656D");
        });

        modelBuilder.Entity<Sipun>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Sipun");

            entity.Property(e => e.Addresss)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("addresss");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Names)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Table1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Table_1");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
