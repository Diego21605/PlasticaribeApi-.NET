using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlasticaribeApi_Prueba.Migrations
{
    public partial class CampoDecimalAsgRollo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Prod_CantidadUnidades",
                table: "DetallesAsignacionesProductos_FacturasVentas",
                type: "decimal(14,2)",
                precision: 14,
                scale: 2,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldPrecision: 14,
                oldScale: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Prod_CantidadUnidades",
                table: "DetallesAsignacionesProductos_FacturasVentas",
                type: "int",
                precision: 14,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(14,2)",
                oldPrecision: 14,
                oldScale: 2);
        }
    }
}
