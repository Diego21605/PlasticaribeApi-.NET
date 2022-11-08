using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlasticaribeApi_Prueba.Migrations
{
    public partial class AdicionCampoTinta_EnRemisionMatPrimas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.DropForeignKey(
                name: "FK_FacturasCompras_MateriaPrimas_Facturas_Compras_Factura_CompraFacco_Id",
                table: "FacturasCompras_MateriaPrimas");

            migrationBuilder.DropForeignKey(
                name: "FK_FacturasCompras_MateriaPrimas_Materias_Primas_Materia_PrimaMatPri_Id",
                table: "FacturasCompras_MateriaPrimas");*/

            migrationBuilder.DropForeignKey(
                name: "FK_Remisiones_MateriasPrimas_Materias_Primas_MatPri_Id",
                table: "Remisiones_MateriasPrimas");

            migrationBuilder.DropForeignKey(
                name: "FK_Remisiones_MateriasPrimas_Remisiones_Rem_Id",
                table: "Remisiones_MateriasPrimas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Remisiones_MateriasPrimas",
                table: "Remisiones_MateriasPrimas");

           /* migrationBuilder.DropIndex(
                name: "IX_FacturasCompras_MateriaPrimas_Factura_CompraFacco_Id",
                table: "FacturasCompras_MateriaPrimas");

            migrationBuilder.DropIndex(
                name: "IX_FacturasCompras_MateriaPrimas_Materia_PrimaMatPri_Id",
                table: "FacturasCompras_MateriaPrimas"); 

            migrationBuilder.DropColumn(
                name: "Factura_CompraFacco_Id",
                table: "FacturasCompras_MateriaPrimas");

            migrationBuilder.DropColumn(
                name: "Materia_PrimaMatPri_Id",
                table: "FacturasCompras_MateriaPrimas");*/

            migrationBuilder.AddColumn<long>(
                name: "RemiMatPri_Codigo",
                table: "Remisiones_MateriasPrimas",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "Tinta_Id",
                table: "Remisiones_MateriasPrimas",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Remisiones_MateriasPrimas",
                table: "Remisiones_MateriasPrimas",
                column: "RemiMatPri_Codigo");

            migrationBuilder.CreateIndex(
                name: "IX_Remisiones_MateriasPrimas_Rem_Id",
                table: "Remisiones_MateriasPrimas",
                column: "Rem_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Remisiones_MateriasPrimas_Tinta_Id",
                table: "Remisiones_MateriasPrimas",
                column: "Tinta_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Remisiones_MateriasPrimas_Materias_Primas_MatPri_Id",
                table: "Remisiones_MateriasPrimas",
                column: "MatPri_Id",
                principalTable: "Materias_Primas",
                principalColumn: "MatPri_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Remisiones_MateriasPrimas_Remisiones_Rem_Id",
                table: "Remisiones_MateriasPrimas",
                column: "Rem_Id",
                principalTable: "Remisiones",
                principalColumn: "Rem_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Remisiones_MateriasPrimas_Tintas_Tinta_Id",
                table: "Remisiones_MateriasPrimas",
                column: "Tinta_Id",
                principalTable: "Tintas",
                principalColumn: "Tinta_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Remisiones_MateriasPrimas_Materias_Primas_MatPri_Id",
                table: "Remisiones_MateriasPrimas");

            migrationBuilder.DropForeignKey(
                name: "FK_Remisiones_MateriasPrimas_Remisiones_Rem_Id",
                table: "Remisiones_MateriasPrimas");

            migrationBuilder.DropForeignKey(
                name: "FK_Remisiones_MateriasPrimas_Tintas_Tinta_Id",
                table: "Remisiones_MateriasPrimas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Remisiones_MateriasPrimas",
                table: "Remisiones_MateriasPrimas");

            migrationBuilder.DropIndex(
                name: "IX_Remisiones_MateriasPrimas_Rem_Id",
                table: "Remisiones_MateriasPrimas");

            migrationBuilder.DropIndex(
                name: "IX_Remisiones_MateriasPrimas_Tinta_Id",
                table: "Remisiones_MateriasPrimas");

            migrationBuilder.DropColumn(
                name: "RemiMatPri_Codigo",
                table: "Remisiones_MateriasPrimas");

            migrationBuilder.DropColumn(
                name: "Tinta_Id",
                table: "Remisiones_MateriasPrimas");

           /* migrationBuilder.AddColumn<long>(
                name: "Factura_CompraFacco_Id",
                table: "FacturasCompras_MateriaPrimas",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Materia_PrimaMatPri_Id",
                table: "FacturasCompras_MateriaPrimas",
                type: "bigint",
                nullable: true); */

            migrationBuilder.AddPrimaryKey(
                name: "PK_Remisiones_MateriasPrimas",
                table: "Remisiones_MateriasPrimas",
                columns: new[] { "Rem_Id", "MatPri_Id" });

           /* migrationBuilder.CreateIndex(
                name: "IX_FacturasCompras_MateriaPrimas_Factura_CompraFacco_Id",
                table: "FacturasCompras_MateriaPrimas",
                column: "Factura_CompraFacco_Id");

            migrationBuilder.CreateIndex(
                name: "IX_FacturasCompras_MateriaPrimas_Materia_PrimaMatPri_Id",
                table: "FacturasCompras_MateriaPrimas",
                column: "Materia_PrimaMatPri_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FacturasCompras_MateriaPrimas_Facturas_Compras_Factura_CompraFacco_Id",
                table: "FacturasCompras_MateriaPrimas",
                column: "Factura_CompraFacco_Id",
                principalTable: "Facturas_Compras",
                principalColumn: "Facco_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FacturasCompras_MateriaPrimas_Materias_Primas_Materia_PrimaMatPri_Id",
                table: "FacturasCompras_MateriaPrimas",
                column: "Materia_PrimaMatPri_Id",
                principalTable: "Materias_Primas",
                principalColumn: "MatPri_Id"); */

            migrationBuilder.AddForeignKey(
                name: "FK_Remisiones_MateriasPrimas_Materias_Primas_MatPri_Id",
                table: "Remisiones_MateriasPrimas",
                column: "MatPri_Id",
                principalTable: "Materias_Primas",
                principalColumn: "MatPri_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Remisiones_MateriasPrimas_Remisiones_Rem_Id",
                table: "Remisiones_MateriasPrimas",
                column: "Rem_Id",
                principalTable: "Remisiones",
                principalColumn: "Rem_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
