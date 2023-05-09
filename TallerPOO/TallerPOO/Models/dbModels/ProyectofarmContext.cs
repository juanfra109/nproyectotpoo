using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TallerPOO.Models.dbModels;

public partial class ProyectofarmContext : DbContext
{
    public ProyectofarmContext()
    {
    }

    public ProyectofarmContext(DbContextOptions<ProyectofarmContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Almacen> Almacens { get; set; }

    public virtual DbSet<DetalleEv> DetalleEvs { get; set; }

    public virtual DbSet<Detalleap> Detalleaps { get; set; }

    public virtual DbSet<Detalleea> Detalleeas { get; set; }

    public virtual DbSet<Detalleev1> Detalleevs1 { get; set; }

    public virtual DbSet<Detallepp> Detallepps { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Proveedor> Proveedors { get; set; }

    public virtual DbSet<Ventum> Venta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=proyectofarm;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Almacen>(entity =>
        {
            entity.HasKey(e => e.IdAlm).HasName("PK_almacen_Id_alm");

            entity.Property(e => e.IdAlm).ValueGeneratedNever();
        });

        modelBuilder.Entity<DetalleEv>(entity =>
        {
            entity.HasKey(e => e.IdVent).HasName("PK_detalle_ev_id_vent");

            entity.Property(e => e.IdVent).ValueGeneratedNever();
        });

        modelBuilder.Entity<Detalleap>(entity =>
        {
            entity.HasKey(e => e.IdDetalleap).HasName("PK_detalleap_Id_detalleap");

            entity.Property(e => e.IdDetalleap).ValueGeneratedNever();
        });

        modelBuilder.Entity<Detalleea>(entity =>
        {
            entity.HasKey(e => e.IdDetalleEa).HasName("PK_detalleea_id_detalleEA");

            entity.Property(e => e.IdDetalleEa).ValueGeneratedNever();
        });

        modelBuilder.Entity<Detalleev1>(entity =>
        {
            entity.HasKey(e => e.IdDetalleEp).HasName("PK_detalleev_Id_detalleEP");

            entity.Property(e => e.IdDetalleEp).ValueGeneratedNever();
        });

        modelBuilder.Entity<Detallepp>(entity =>
        {
            entity.HasKey(e => e.IdDetallepp).HasName("PK_detallepp_id_detallepp");

            entity.Property(e => e.IdDetallepp).ValueGeneratedNever();
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.IdEmpl).HasName("PK_empleado_Id_empl");

            entity.Property(e => e.IdEmpl).ValueGeneratedNever();
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProd).HasName("PK_productos_Id_prod");

            entity.Property(e => e.IdProd).ValueGeneratedNever();
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.IdProv).HasName("PK_proveedor_Id_prov");

            entity.Property(e => e.IdProv).ValueGeneratedNever();
        });

        modelBuilder.Entity<Ventum>(entity =>
        {
            entity.HasKey(e => e.IdVent).HasName("PK_venta_Id_vent");

            entity.Property(e => e.IdVent).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
