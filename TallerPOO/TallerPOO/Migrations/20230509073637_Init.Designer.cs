﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TallerPOO.Models.dbModels;

#nullable disable

namespace TallerPOO.Migrations
{
    [DbContext(typeof(ProyectofarmContext))]
    [Migration("20230509073637_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TallerPOO.Models.dbModels.Almacen", b =>
                {
                    b.Property<int>("IdAlm")
                        .HasColumnType("int")
                        .HasColumnName("Id_alm");

                    b.Property<string>("NomAlm")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasColumnName("nom_alm");

                    b.HasKey("IdAlm")
                        .HasName("PK_almacen_Id_alm");

                    b.ToTable("almacen", "farmacia");
                });

            modelBuilder.Entity("TallerPOO.Models.dbModels.DetalleEv", b =>
                {
                    b.Property<int>("IdVent")
                        .HasColumnType("int")
                        .HasColumnName("id_vent");

                    b.Property<DateTime>("FechVent")
                        .HasColumnType("date")
                        .HasColumnName("fech_vent");

                    b.Property<int>("IdEmpl")
                        .HasColumnType("int")
                        .HasColumnName("id_empl");

                    b.Property<string>("TurnEmpl")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("turn_empl");

                    b.HasKey("IdVent")
                        .HasName("PK_detalle_ev_id_vent");

                    b.ToTable("detalle_ev", "farmacia");
                });

            modelBuilder.Entity("TallerPOO.Models.dbModels.Detalleap", b =>
                {
                    b.Property<int>("IdDetalleap")
                        .HasColumnType("int")
                        .HasColumnName("Id_detalleap");

                    b.Property<int>("IdAlm")
                        .HasColumnType("int")
                        .HasColumnName("Id_alm");

                    b.Property<int>("IdProd")
                        .HasColumnType("int")
                        .HasColumnName("id_prod");

                    b.Property<string>("NomAlm")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nom_alm");

                    b.Property<int>("NomProd")
                        .HasColumnType("int")
                        .HasColumnName("nom_prod");

                    b.HasKey("IdDetalleap")
                        .HasName("PK_detalleap_Id_detalleap");

                    b.ToTable("detalleap", "farmacia");
                });

            modelBuilder.Entity("TallerPOO.Models.dbModels.Detalleea", b =>
                {
                    b.Property<int>("IdDetalleEa")
                        .HasColumnType("int")
                        .HasColumnName("id_detalleEA");

                    b.Property<DateTime>("FechaDetalleEa")
                        .HasColumnType("date")
                        .HasColumnName("fecha_detalleEA");

                    b.Property<int>("IdEmpl")
                        .HasColumnType("int")
                        .HasColumnName("id_empl");

                    b.Property<string>("NomAlm")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nom_alm");

                    b.HasKey("IdDetalleEa")
                        .HasName("PK_detalleea_id_detalleEA");

                    b.ToTable("detalleea", "farmacia");
                });

            modelBuilder.Entity("TallerPOO.Models.dbModels.Detalleev1", b =>
                {
                    b.Property<int>("IdDetalleEp")
                        .HasColumnType("int")
                        .HasColumnName("Id_detalleEP");

                    b.Property<DateTime>("FechDetalleEp")
                        .HasColumnType("date")
                        .HasColumnName("fech_detalleEP");

                    b.Property<int>("IdEmpl")
                        .HasColumnType("int")
                        .HasColumnName("Id_empl");

                    b.Property<int>("IdProv")
                        .HasColumnType("int")
                        .HasColumnName("Id_prov");

                    b.HasKey("IdDetalleEp")
                        .HasName("PK_detalleev_Id_detalleEP");

                    b.ToTable("detalleev", "farmacia");
                });

            modelBuilder.Entity("TallerPOO.Models.dbModels.Detallepp", b =>
                {
                    b.Property<int>("IdDetallepp")
                        .HasColumnType("int")
                        .HasColumnName("id_detallepp");

                    b.Property<int>("CantProd")
                        .HasColumnType("int")
                        .HasColumnName("cant_prod");

                    b.Property<int>("IdProd")
                        .HasColumnType("int")
                        .HasColumnName("id_prod");

                    b.Property<int>("IdProv")
                        .HasColumnType("int")
                        .HasColumnName("id_prov");

                    b.Property<string>("NomProd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nom_prod");

                    b.HasKey("IdDetallepp")
                        .HasName("PK_detallepp_id_detallepp");

                    b.ToTable("detallepp", "farmacia");
                });

            modelBuilder.Entity("TallerPOO.Models.dbModels.Empleado", b =>
                {
                    b.Property<int>("IdEmpl")
                        .HasColumnType("int")
                        .HasColumnName("Id_empl");

                    b.Property<string>("DirEmpl")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("dir_empl");

                    b.Property<string>("NomEmpl")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasColumnName("nom_empl");

                    b.Property<string>("RfcEmpl")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("RFC_empl");

                    b.Property<string>("TelEmp")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("tel_emp");

                    b.Property<string>("TurnEmpl")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("turn_empl");

                    b.HasKey("IdEmpl")
                        .HasName("PK_empleado_Id_empl");

                    b.ToTable("empleado", "farmacia");
                });

            modelBuilder.Entity("TallerPOO.Models.dbModels.Producto", b =>
                {
                    b.Property<int>("IdProd")
                        .HasColumnType("int")
                        .HasColumnName("Id_prod");

                    b.Property<int>("CantProd")
                        .HasColumnType("int")
                        .HasColumnName("cant_prod");

                    b.Property<string>("NomProd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nom_prod");

                    b.Property<int>("PrecProd")
                        .HasColumnType("int")
                        .HasColumnName("prec_prod");

                    b.HasKey("IdProd")
                        .HasName("PK_productos_Id_prod");

                    b.ToTable("productos", "farmacia");
                });

            modelBuilder.Entity("TallerPOO.Models.dbModels.Proveedor", b =>
                {
                    b.Property<int>("IdProv")
                        .HasColumnType("int")
                        .HasColumnName("Id_prov");

                    b.Property<string>("CorrProv")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("corr_prov");

                    b.Property<string>("DirProv")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("dir_prov");

                    b.Property<string>("NomProv")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasColumnName("nom_prov");

                    b.Property<string>("TelProv")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("tel_prov");

                    b.HasKey("IdProv")
                        .HasName("PK_proveedor_Id_prov");

                    b.ToTable("proveedor", "farmacia");
                });

            modelBuilder.Entity("TallerPOO.Models.dbModels.Ventum", b =>
                {
                    b.Property<int>("IdVent")
                        .HasColumnType("int")
                        .HasColumnName("Id_vent");

                    b.Property<DateTime>("FechVent")
                        .HasColumnType("date")
                        .HasColumnName("Fech_vent");

                    b.Property<int>("IdEmpl")
                        .HasColumnType("int")
                        .HasColumnName("Id_empl");

                    b.Property<decimal>("TotalVent")
                        .HasColumnType("decimal(19, 4)")
                        .HasColumnName("total_vent");

                    b.HasKey("IdVent")
                        .HasName("PK_venta_Id_vent");

                    b.ToTable("venta", "farmacia");
                });
#pragma warning restore 612, 618
        }
    }
}
