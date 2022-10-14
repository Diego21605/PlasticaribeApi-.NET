using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlasticaribeApi_Prueba.Migrations
{
    public partial class Hora2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AsigProdFV_Hora",
                table: "AsignacionesProductos_FacturasVentas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AsigProdFV_Hora",
                table: "AsignacionesProductos_FacturasVentas",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");
        }
    }
}
