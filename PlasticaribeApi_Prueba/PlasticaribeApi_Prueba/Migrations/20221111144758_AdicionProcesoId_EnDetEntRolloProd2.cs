using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlasticaribeApi_Prueba.Migrations
{
    public partial class AdicionProcesoId_EnDetEntRolloProd2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Proceso_Id",
                table: "DetallesEntradasRollos_Productos",
                type: "varchar(10)",
                nullable: true);

           /* migrationBuilder.AddColumn<string>(
                name: "AsigProdFV_Hora",
                table: "AsignacionesProductos_FacturasVentas",
                type: "varchar(50)",
                nullable: false,
                defaultValue: ""); */

            migrationBuilder.CreateIndex(
                name: "IX_DetallesEntradasRollos_Productos_Proceso_Id",
                table: "DetallesEntradasRollos_Productos",
                column: "Proceso_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesEntradasRollos_Productos_Procesos_Proceso_Id",
                table: "DetallesEntradasRollos_Productos",
                column: "Proceso_Id",
                principalTable: "Procesos",
                principalColumn: "Proceso_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallesEntradasRollos_Productos_Procesos_Proceso_Id",
                table: "DetallesEntradasRollos_Productos");

            migrationBuilder.DropIndex(
                name: "IX_DetallesEntradasRollos_Productos_Proceso_Id",
                table: "DetallesEntradasRollos_Productos");

            migrationBuilder.DropColumn(
                name: "Proceso_Id",
                table: "DetallesEntradasRollos_Productos");

            /*migrationBuilder.DropColumn(
                name: "AsigProdFV_Hora",
                table: "AsignacionesProductos_FacturasVentas");*/
        }
    }
}
