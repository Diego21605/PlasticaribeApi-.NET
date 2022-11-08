using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlasticaribeApi_Prueba.Migrations
{
    public partial class AdicionCampoTinta_EnFacCompras2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FacturasCompras_MateriaPrimas_Facturas_Compras_Facco_Id",
                table: "FacturasCompras_MateriaPrimas");

            migrationBuilder.DropForeignKey(
                name: "FK_FacturasCompras_MateriaPrimas_Materias_Primas_MatPri_Id",
                table: "FacturasCompras_MateriaPrimas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FacturasCompras_MateriaPrimas",
                table: "FacturasCompras_MateriaPrimas");

            
            migrationBuilder.AlterColumn<decimal>(
                name: "FaccoMatPri_ValorUnitario",
                table: "FacturasCompras_MateriaPrimas",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2)
                .Annotation("Relational:ColumnOrder", 6);


            migrationBuilder.AlterColumn<string>(
                name: "UndMed_Id",
                table: "FacturasCompras_MateriaPrimas",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)")
                .Annotation("Relational:ColumnOrder", 5);


            migrationBuilder.AlterColumn<decimal>(
                name: "FaccoMatPri_Cantidad",
                table: "FacturasCompras_MateriaPrimas",
                type: "decimal(14,2)",
                precision: 14,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(14,2)",
                oldPrecision: 14,
                oldScale: 2)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AddColumn<long>(
               name: "Tinta_Id",
               table: "FacturasCompras_MateriaPrimas",
               type: "bigint",
               nullable: false,
               defaultValue: 0L)
               .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<long>(
                name: "MatPri_Id",
                table: "FacturasCompras_MateriaPrimas",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "Facco_Id",
                table: "FacturasCompras_MateriaPrimas",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Relational:ColumnOrder", 1);

            
            migrationBuilder.AddColumn<long>(
                name: "Facco_Codigo",
                table: "FacturasCompras_MateriaPrimas",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1");


            migrationBuilder.AddPrimaryKey(
                name: "PK_FacturasCompras_MateriaPrimas",
                table: "FacturasCompras_MateriaPrimas",
                column: "Facco_Codigo");

            migrationBuilder.CreateIndex(
                name: "IX_FacturasCompras_MateriaPrimas_Facco_Id",
                table: "FacturasCompras_MateriaPrimas",
                column: "Facco_Id");

            migrationBuilder.CreateIndex(
                name: "IX_FacturasCompras_MateriaPrimas_Materia_PrimaMatPri_Id",
                table: "FacturasCompras_MateriaPrimas",
                column: "MatPri_Id");

            migrationBuilder.CreateIndex(
                name: "IX_FacturasCompras_MateriaPrimas_Tinta_Id",
                table: "FacturasCompras_MateriaPrimas",
                column: "Tinta_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FacturasCompras_MateriaPrimas_Facturas_Compras_Facco_Id",
                table: "FacturasCompras_MateriaPrimas",
                column: "Facco_Id",
                principalTable: "Facturas_Compras",
                principalColumn: "Facco_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FacturasCompras_MateriaPrimas_Materias_Primas_MatPri_Id",
                table: "FacturasCompras_MateriaPrimas",
                column: "MatPri_Id",
                principalTable: "Materias_Primas",
                principalColumn: "MatPri_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FacturasCompras_MateriaPrimas_Tintas_Tinta_Id",
                table: "FacturasCompras_MateriaPrimas",
                column: "Tinta_Id",
                principalTable: "Tintas",
                principalColumn: "Tinta_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FacturasCompras_MateriaPrimas_Facturas_Compras_Facco_Id",
                table: "FacturasCompras_MateriaPrimas");


            migrationBuilder.DropForeignKey(
                name: "FK_FacturasCompras_MateriaPrimas_Materias_Primas_MatPri_Id",
                table: "FacturasCompras_MateriaPrimas");

            migrationBuilder.DropForeignKey(
                name: "FK_FacturasCompras_MateriaPrimas_Tintas_Tinta_Id",
                table: "FacturasCompras_MateriaPrimas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FacturasCompras_MateriaPrimas",
                table: "FacturasCompras_MateriaPrimas");

            migrationBuilder.DropIndex(
                name: "IX_FacturasCompras_MateriaPrimas_Facco_Id",
                table: "FacturasCompras_MateriaPrimas");

            migrationBuilder.DropIndex(
                name: "IX_FacturasCompras_MateriaPrimas_MatPri_Id",
                table: "FacturasCompras_MateriaPrimas");

            migrationBuilder.DropIndex(
                name: "IX_FacturasCompras_MateriaPrimas_Tinta_Id",
                table: "FacturasCompras_MateriaPrimas");

            migrationBuilder.DropColumn(
                name: "Facco_Codigo",
                table: "FacturasCompras_MateriaPrimas");

            migrationBuilder.DropColumn(
                name: "Facco_Id",
                table: "FacturasCompras_MateriaPrimas");

            migrationBuilder.DropColumn(
                name: "MatPri_Id",
                table: "FacturasCompras_MateriaPrimas");

            migrationBuilder.DropColumn(
                name: "Tinta_Id",
                table: "FacturasCompras_MateriaPrimas");

            migrationBuilder.AlterColumn<string>(
                name: "UndMed_Id",
                table: "FacturasCompras_MateriaPrimas",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<long>(
                name: "MatPri_Id",
                table: "FacturasCompras_MateriaPrimas",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<long>(
                name: "Facco_Id",
                table: "FacturasCompras_MateriaPrimas",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<decimal>(
                name: "FaccoMatPri_ValorUnitario",
                table: "FacturasCompras_MateriaPrimas",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<decimal>(
                name: "FaccoMatPri_Cantidad",
                table: "FacturasCompras_MateriaPrimas",
                type: "decimal(14,2)",
                precision: 14,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(14,2)",
                oldPrecision: 14,
                oldScale: 2)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FacturasCompras_MateriaPrimas",
                table: "FacturasCompras_MateriaPrimas",
                columns: new[] { "Facco_Id", "MatPri_Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_FacturasCompras_MateriaPrimas_Facturas_Compras_Facco_Id",
                table: "FacturasCompras_MateriaPrimas",
                column: "Facco_Id",
                principalTable: "Facturas_Compras",
                principalColumn: "Facco_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FacturasCompras_MateriaPrimas_Materias_Primas_MatPri_Id",
                table: "FacturasCompras_MateriaPrimas",
                column: "MatPri_Id",
                principalTable: "Materias_Primas",
                principalColumn: "MatPri_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
