using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlasticaribeApi_Prueba.Migrations
{
    public partial class OrdenCompra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detalles_OrdenesCompras_BOPP_BOPP_Id",
                table: "Detalles_OrdenesCompras");

            migrationBuilder.AddColumn<decimal>(
                name: "Oc_PesoTotal",
                table: "Ordenes_Compras",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Bopp_Generico",
                columns: table => new
                {
                    BoppGen_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoppGen_Nombre = table.Column<string>(type: "varchar(MAX)", nullable: false),
                    BoppGen_Ancho = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    BoppGen_Micra = table.Column<long>(type: "bigint", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bopp_Generico", x => x.BoppGen_Id);
                });

            migrationBuilder.CreateTable(
                name: "OrdenesCompras_FacturasCompras",
                columns: table => new
                {
                    Oc_Id = table.Column<long>(type: "bigint", nullable: false),
                    Facco_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenesCompras_FacturasCompras", x => new { x.Oc_Id, x.Facco_Id });
                    table.ForeignKey(
                        name: "FK_OrdenesCompras_FacturasCompras_Facturas_Compras_Facco_Id",
                        column: x => x.Facco_Id,
                        principalTable: "Facturas_Compras",
                        principalColumn: "Facco_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdenesCompras_FacturasCompras_Ordenes_Compras_Oc_Id",
                        column: x => x.Oc_Id,
                        principalTable: "Ordenes_Compras",
                        principalColumn: "Oc_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesCompras_FacturasCompras_Facco_Id",
                table: "OrdenesCompras_FacturasCompras",
                column: "Facco_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Detalles_OrdenesCompras_Bopp_Generico_BOPP_Id",
                table: "Detalles_OrdenesCompras",
                column: "BOPP_Id",
                principalTable: "Bopp_Generico",
                principalColumn: "BoppGen_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detalles_OrdenesCompras_Bopp_Generico_BOPP_Id",
                table: "Detalles_OrdenesCompras");

            migrationBuilder.DropTable(
                name: "Bopp_Generico");

            migrationBuilder.DropTable(
                name: "OrdenesCompras_FacturasCompras");

            migrationBuilder.DropColumn(
                name: "Oc_PesoTotal",
                table: "Ordenes_Compras");

            migrationBuilder.AddForeignKey(
                name: "FK_Detalles_OrdenesCompras_BOPP_BOPP_Id",
                table: "Detalles_OrdenesCompras",
                column: "BOPP_Id",
                principalTable: "BOPP",
                principalColumn: "BOPP_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
