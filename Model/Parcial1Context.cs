using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Model;

public partial class Parcial1Context : DbContext
{
    public Parcial1Context()
    {
    }

    public Parcial1Context(DbContextOptions<Parcial1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Drogueria> Droguerias { get; set; }

    public virtual DbSet<Medicamento> Medicamentos { get; set; }

    public virtual DbSet<Monodroga> Monodrogas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Parcial1;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Drogueria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DROGUERI__3214EC27BE7737C1");

            entity.ToTable("DROGUERIAS");

            entity.HasIndex(e => e.Cuit, "UQ__DROGUERI__F46C159804750638").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cuit).HasColumnName("CUIT");
            entity.Property(e => e.Direccion)
                .HasMaxLength(150)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Email)
                .HasMaxLength(254)
                .HasColumnName("EMAIL");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(50)
                .HasColumnName("RAZON_SOCIAL");
        });

        modelBuilder.Entity<Medicamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MEDICAME__3214EC27E78FE195");

            entity.ToTable("MEDICAMENTOS");

            entity.HasIndex(e => e.NombreComercial, "UQ__MEDICAME__912CD23FCEB45AB8").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EsVentaLibre).HasColumnName("ES_VENTA_LIBRE");
            entity.Property(e => e.IdMonodrogra).HasColumnName("ID_MONODROGRA");
            entity.Property(e => e.NombreComercial)
                .HasMaxLength(50)
                .HasColumnName("NOMBRE_COMERCIAL");
            entity.Property(e => e.PrecioVenta)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("PRECIO_VENTA");
            entity.Property(e => e.Stock).HasColumnName("STOCK");
            entity.Property(e => e.StockMinimo).HasColumnName("STOCK_MINIMO");

            entity.HasOne(d => d.IdMonodrograNavigation).WithMany(p => p.Medicamentos)
                .HasForeignKey(d => d.IdMonodrogra)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MEDICAMEN__ID_MO__2D27B809");

            entity.HasMany(d => d.IdDrogueria).WithMany(p => p.IdMedicamentos)
                .UsingEntity<Dictionary<string, object>>(
                    "MedicamentosDrogueria",
                    r => r.HasOne<Drogueria>().WithMany()
                        .HasForeignKey("IdDrogueria")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__MEDICAMEN__ID_DR__30F848ED"),
                    l => l.HasOne<Medicamento>().WithMany()
                        .HasForeignKey("IdMedicamento")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__MEDICAMEN__ID_ME__300424B4"),
                    j =>
                    {
                        j.HasKey("IdMedicamento", "IdDrogueria").HasName("PK__MEDICAME__9BEAB3D922F8E69A");
                        j.ToTable("MEDICAMENTOS_DROGUERIAS");
                        j.IndexerProperty<int>("IdMedicamento").HasColumnName("ID_MEDICAMENTO");
                        j.IndexerProperty<int>("IdDrogueria").HasColumnName("ID_DROGUERIA");
                    });
        });

        modelBuilder.Entity<Monodroga>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MONODROG__3214EC277B501F93");

            entity.ToTable("MONODROGAS");

            entity.HasIndex(e => e.Nombre, "UQ__MONODROG__B21D0AB9C668E7B8").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("NOMBRE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
