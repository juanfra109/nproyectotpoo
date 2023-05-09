using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TallerPOO.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "farmacia");

            migrationBuilder.CreateTable(
                name: "almacen",
                schema: "farmacia",
                columns: table => new
                {
                    Id_alm = table.Column<int>(type: "int", nullable: false),
                    nom_alm = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_almacen_Id_alm", x => x.Id_alm);
                });

            migrationBuilder.CreateTable(
                name: "detalle_ev",
                schema: "farmacia",
                columns: table => new
                {
                    id_vent = table.Column<int>(type: "int", nullable: false),
                    fech_vent = table.Column<DateTime>(type: "date", nullable: false),
                    id_empl = table.Column<int>(type: "int", nullable: false),
                    turn_empl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalle_ev_id_vent", x => x.id_vent);
                });

            migrationBuilder.CreateTable(
                name: "detalleap",
                schema: "farmacia",
                columns: table => new
                {
                    Id_detalleap = table.Column<int>(type: "int", nullable: false),
                    id_prod = table.Column<int>(type: "int", nullable: false),
                    nom_prod = table.Column<int>(type: "int", nullable: false),
                    Id_alm = table.Column<int>(type: "int", nullable: false),
                    nom_alm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalleap_Id_detalleap", x => x.Id_detalleap);
                });

            migrationBuilder.CreateTable(
                name: "detalleea",
                schema: "farmacia",
                columns: table => new
                {
                    id_detalleEA = table.Column<int>(type: "int", nullable: false),
                    id_empl = table.Column<int>(type: "int", nullable: false),
                    nom_alm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fecha_detalleEA = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalleea_id_detalleEA", x => x.id_detalleEA);
                });

            migrationBuilder.CreateTable(
                name: "detalleev",
                schema: "farmacia",
                columns: table => new
                {
                    Id_detalleEP = table.Column<int>(type: "int", nullable: false),
                    Id_empl = table.Column<int>(type: "int", nullable: false),
                    Id_prov = table.Column<int>(type: "int", nullable: false),
                    fech_detalleEP = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalleev_Id_detalleEP", x => x.Id_detalleEP);
                });

            migrationBuilder.CreateTable(
                name: "detallepp",
                schema: "farmacia",
                columns: table => new
                {
                    id_detallepp = table.Column<int>(type: "int", nullable: false),
                    id_prod = table.Column<int>(type: "int", nullable: false),
                    nom_prod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    cant_prod = table.Column<int>(type: "int", nullable: false),
                    id_prov = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detallepp_id_detallepp", x => x.id_detallepp);
                });

            migrationBuilder.CreateTable(
                name: "empleado",
                schema: "farmacia",
                columns: table => new
                {
                    Id_empl = table.Column<int>(type: "int", nullable: false),
                    nom_empl = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    tel_emp = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    RFC_empl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    dir_empl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    turn_empl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empleado_Id_empl", x => x.Id_empl);
                });

            migrationBuilder.CreateTable(
                name: "productos",
                schema: "farmacia",
                columns: table => new
                {
                    Id_prod = table.Column<int>(type: "int", nullable: false),
                    nom_prod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    prec_prod = table.Column<int>(type: "int", nullable: false),
                    cant_prod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productos_Id_prod", x => x.Id_prod);
                });

            migrationBuilder.CreateTable(
                name: "proveedor",
                schema: "farmacia",
                columns: table => new
                {
                    Id_prov = table.Column<int>(type: "int", nullable: false),
                    nom_prov = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    tel_prov = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    corr_prov = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    dir_prov = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proveedor_Id_prov", x => x.Id_prov);
                });

            migrationBuilder.CreateTable(
                name: "venta",
                schema: "farmacia",
                columns: table => new
                {
                    Id_vent = table.Column<int>(type: "int", nullable: false),
                    Fech_vent = table.Column<DateTime>(type: "date", nullable: false),
                    total_vent = table.Column<decimal>(type: "decimal(19,4)", nullable: false),
                    Id_empl = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_venta_Id_vent", x => x.Id_vent);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "almacen",
                schema: "farmacia");

            migrationBuilder.DropTable(
                name: "detalle_ev",
                schema: "farmacia");

            migrationBuilder.DropTable(
                name: "detalleap",
                schema: "farmacia");

            migrationBuilder.DropTable(
                name: "detalleea",
                schema: "farmacia");

            migrationBuilder.DropTable(
                name: "detalleev",
                schema: "farmacia");

            migrationBuilder.DropTable(
                name: "detallepp",
                schema: "farmacia");

            migrationBuilder.DropTable(
                name: "empleado",
                schema: "farmacia");

            migrationBuilder.DropTable(
                name: "productos",
                schema: "farmacia");

            migrationBuilder.DropTable(
                name: "proveedor",
                schema: "farmacia");

            migrationBuilder.DropTable(
                name: "venta",
                schema: "farmacia");
        }
    }
}
