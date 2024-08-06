using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace agadadotnet.Models;

public partial class AgadaContext : DbContext
{
    public AgadaContext()
    {
    }

    public AgadaContext(DbContextOptions<AgadaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Shop> Shops { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=root;database=agada", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.2.0-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.AId).HasName("PRIMARY");

            entity.ToTable("area");

            entity.HasIndex(e => e.CId, "fk_cname_idx");

            entity.Property(e => e.AId).HasColumnName("a_id");
            entity.Property(e => e.Aname)
                .HasMaxLength(255)
                .HasColumnName("aname");
            entity.Property(e => e.CId).HasColumnName("c_id");
            entity.Property(e => e.Pincode)
                .HasMaxLength(45)
                .HasColumnName("pincode");

            entity.HasOne(d => d.CIdNavigation).WithMany(p => p.Areas)
                .HasForeignKey(d => d.CId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_cid");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.CId).HasName("PRIMARY");

            entity.ToTable("city");

            entity.Property(e => e.CId).HasColumnName("c_id");
            entity.Property(e => e.Cname)
                .HasMaxLength(45)
                .HasColumnName("cname");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RId).HasName("PRIMARY");

            entity.ToTable("roles");

            entity.Property(e => e.RId).HasColumnName("r_id");
            entity.Property(e => e.Rname)
                .HasMaxLength(45)
                .HasColumnName("rname");
        });

        modelBuilder.Entity<Shop>(entity =>
        {
            entity.HasKey(e => e.ShId).HasName("PRIMARY");

            entity.ToTable("shop");

            entity.HasIndex(e => e.AId, "fk_said_idx");

            entity.HasIndex(e => e.UId, "fk_uid_idx");

            entity.Property(e => e.ShId).HasColumnName("sh_id");
            entity.Property(e => e.AId).HasColumnName("a_id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.LicenseNo)
                .HasMaxLength(100)
                .HasColumnName("license_no");
            entity.Property(e => e.RegNo)
                .HasMaxLength(100)
                .HasColumnName("reg_no");
            entity.Property(e => e.Shname)
                .HasMaxLength(100)
                .HasColumnName("shname");
            entity.Property(e => e.UId).HasColumnName("u_id");

            entity.HasOne(d => d.AIdNavigation).WithMany(p => p.Shops)
                .HasForeignKey(d => d.AId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_said");

            entity.HasOne(d => d.UIdNavigation).WithMany(p => p.Shops)
                .HasForeignKey(d => d.UId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_uid");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UId).HasName("PRIMARY");

            entity.ToTable("user");

            entity.HasIndex(e => e.AId, "fk_uaid_idx");

            entity.HasIndex(e => e.RId, "fk_urid_idx");

            entity.Property(e => e.UId).HasColumnName("u_id");
            entity.Property(e => e.AId).HasColumnName("a_id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.Contact)
                .HasMaxLength(45)
                .HasColumnName("contact");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Fname)
                .HasMaxLength(45)
                .HasColumnName("fname");
            entity.Property(e => e.Lname)
                .HasMaxLength(45)
                .HasColumnName("lname");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.RId).HasColumnName("r_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");

            entity.HasOne(d => d.AIdNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.AId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_uaid");

            entity.HasOne(d => d.RIdNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.RId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_urid");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
