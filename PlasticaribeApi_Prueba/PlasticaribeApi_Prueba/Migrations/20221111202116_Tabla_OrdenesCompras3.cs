using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlasticaribeApi_Prueba.Migrations
{
    public partial class Tabla_OrdenesCompras3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ordenes_Compras",
                columns: table => new
                {
                    Oc_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usua_Id = table.Column<long>(type: "bigint", nullable: false),
                    Oc_Fecha = table.Column<DateTime>(type: "date", nullable: false),
                    Oc_Hora = table.Column<string>(type: "varchar(10)", nullable: false),
                    Prov_Id = table.Column<long>(type: "bigint", nullable: false),
                    Estado_Id = table.Column<int>(type: "int", nullable: false),
                    Oc_ValorTotal = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    TpDoc_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    Oc_Observacion = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordenes_Compras", x => x.Oc_Id);
                    table.ForeignKey(
                        name: "FK_Ordenes_Compras_Estados_Estado_Id",
                        column: x => x.Estado_Id,
                        principalTable: "Estados",
                        principalColumn: "Estado_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ordenes_Compras_Proveedores_Prov_Id",
                        column: x => x.Prov_Id,
                        principalTable: "Proveedores",
                        principalColumn: "Prov_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ordenes_Compras_Tipos_Documentos_TpDoc_Id",
                        column: x => x.TpDoc_Id,
                        principalTable: "Tipos_Documentos",
                        principalColumn: "TpDoc_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ordenes_Compras_Usuarios_Usua_Id",
                        column: x => x.Usua_Id,
                        principalTable: "Usuarios",
                        principalColumn: "Usua_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ordenes_Compras_Estado_Id",
                table: "Ordenes_Compras",
                column: "Estado_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ordenes_Compras_Prov_Id",
                table: "Ordenes_Compras",
                column: "Prov_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ordenes_Compras_TpDoc_Id",
                table: "Ordenes_Compras",
                column: "TpDoc_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ordenes_Compras_Usua_Id",
                table: "Ordenes_Compras",
                column: "Usua_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ordenes_Compras");
        }
    }
}
