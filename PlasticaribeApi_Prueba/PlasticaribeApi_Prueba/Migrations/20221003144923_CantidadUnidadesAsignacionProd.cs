using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlasticaribeApi_Prueba.Migrations
{
    public partial class CantidadUnidadesAsignacionProd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Prod_CantUnidades",
                table: "DetallesAsignacionesProductos_FacturasVentas",
                newName: "Prod_CantidadUnidades");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Prod_CantidadUnidades",
                table: "DetallesAsignacionesProductos_FacturasVentas",
                newName: "Prod_CantUnidades");
        }
    }
}
