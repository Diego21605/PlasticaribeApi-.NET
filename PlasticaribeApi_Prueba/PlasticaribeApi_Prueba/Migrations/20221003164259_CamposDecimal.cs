using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlasticaribeApi_Prueba.Migrations
{
    public partial class CamposDecimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Prod_CantPaquetesRestantes",
                table: "DetallesEntradasRollos_Productos",
                type: "decimal(14,2)",
                precision: 14,
                scale: 2,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldPrecision: 14,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "Prod_CantBolsasRestates",
                table: "DetallesEntradasRollos_Productos",
                type: "decimal(14,2)",
                precision: 14,
                scale: 2,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldPrecision: 14,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "Prod_CantBolsasPaquete",
                table: "DetallesEntradasRollos_Productos",
                type: "decimal(14,2)",
                precision: 14,
                scale: 2,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldPrecision: 14,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "Prod_CantBolsasFacturadas",
                table: "DetallesEntradasRollos_Productos",
                type: "decimal(14,2)",
                precision: 14,
                scale: 2,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldPrecision: 14,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "Prod_CantBolsasBulto",
                table: "DetallesEntradasRollos_Productos",
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
                name: "Prod_CantPaquetesRestantes",
                table: "DetallesEntradasRollos_Productos",
                type: "int",
                precision: 14,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(14,2)",
                oldPrecision: 14,
                oldScale: 2);

            migrationBuilder.AlterColumn<int>(
                name: "Prod_CantBolsasRestates",
                table: "DetallesEntradasRollos_Productos",
                type: "int",
                precision: 14,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(14,2)",
                oldPrecision: 14,
                oldScale: 2);

            migrationBuilder.AlterColumn<int>(
                name: "Prod_CantBolsasPaquete",
                table: "DetallesEntradasRollos_Productos",
                type: "int",
                precision: 14,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(14,2)",
                oldPrecision: 14,
                oldScale: 2);

            migrationBuilder.AlterColumn<int>(
                name: "Prod_CantBolsasFacturadas",
                table: "DetallesEntradasRollos_Productos",
                type: "int",
                precision: 14,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(14,2)",
                oldPrecision: 14,
                oldScale: 2);

            migrationBuilder.AlterColumn<int>(
                name: "Prod_CantBolsasBulto",
                table: "DetallesEntradasRollos_Productos",
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
