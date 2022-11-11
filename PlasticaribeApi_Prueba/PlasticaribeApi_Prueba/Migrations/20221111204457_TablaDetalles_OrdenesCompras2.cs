using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlasticaribeApi_Prueba.Migrations
{
    public partial class TablaDetalles_OrdenesCompras2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Oc_Observacion",
                table: "Ordenes_Compras",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateTable(
                name: "Detalles_OrdenesCompras",
                columns: table => new
                {
                    Doc_Codigo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Oc_Id = table.Column<long>(type: "bigint", nullable: false),
                    MatPri_Id = table.Column<long>(type: "bigint", nullable: false),
                    Tinta_Id = table.Column<long>(type: "bigint", nullable: false),
                    BOPP_Id = table.Column<long>(type: "bigint", nullable: false),
                    Doc_CantidadPedida = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    UndMed_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    Doc_PrecioUnitario = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalles_OrdenesCompras", x => x.Doc_Codigo);
                    table.ForeignKey(
                        name: "FK_Detalles_OrdenesCompras_BOPP_BOPP_Id",
                        column: x => x.BOPP_Id,
                        principalTable: "BOPP",
                        principalColumn: "BOPP_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Detalles_OrdenesCompras_Materias_Primas_MatPri_Id",
                        column: x => x.MatPri_Id,
                        principalTable: "Materias_Primas",
                        principalColumn: "MatPri_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Detalles_OrdenesCompras_Ordenes_Compras_Oc_Id",
                        column: x => x.Oc_Id,
                        principalTable: "Ordenes_Compras",
                        principalColumn: "Oc_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Detalles_OrdenesCompras_Tintas_Tinta_Id",
                        column: x => x.Tinta_Id,
                        principalTable: "Tintas",
                        principalColumn: "Tinta_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Detalles_OrdenesCompras_Unidades_Medidas_UndMed_Id",
                        column: x => x.UndMed_Id,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_OrdenesCompras_BOPP_Id",
                table: "Detalles_OrdenesCompras",
                column: "BOPP_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_OrdenesCompras_MatPri_Id",
                table: "Detalles_OrdenesCompras",
                column: "MatPri_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_OrdenesCompras_Oc_Id",
                table: "Detalles_OrdenesCompras",
                column: "Oc_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_OrdenesCompras_Tinta_Id",
                table: "Detalles_OrdenesCompras",
                column: "Tinta_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_OrdenesCompras_UndMed_Id",
                table: "Detalles_OrdenesCompras",
                column: "UndMed_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalles_OrdenesCompras");

            migrationBuilder.AlterColumn<string>(
                name: "Oc_Observacion",
                table: "Ordenes_Compras",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
