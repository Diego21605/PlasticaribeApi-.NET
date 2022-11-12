using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlasticaribeApi_Prueba.Migrations
{
    public partial class Rollos_Extrusion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AsigProdFV_Hora",
                table: "AsignacionesProductos_FacturasVentas",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "IngresoRollos_Extrusion",
                columns: table => new
                {
                    IngRollo_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngRollo_Observacion = table.Column<string>(type: "text", nullable: true),
                    Usua_Id = table.Column<long>(type: "bigint", nullable: false),
                    IngRollo_Fecha = table.Column<DateTime>(type: "date", nullable: false),
                    IngRollo_Hora = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngresoRollos_Extrusion", x => x.IngRollo_Id);
                    table.ForeignKey(
                        name: "FK_IngresoRollos_Extrusion_Usuarios_Usua_Id",
                        column: x => x.Usua_Id,
                        principalTable: "Usuarios",
                        principalColumn: "Usua_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetallesIngRollos_Extrusion",
                columns: table => new
                {
                    DtIngRollo_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngRollo_Id = table.Column<long>(type: "bigint", nullable: false),
                    Rollo_Id = table.Column<int>(type: "int", nullable: false),
                    DtIngRollo_Cantidad = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    UndMed_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    DtIngRollo_OT = table.Column<int>(type: "int", nullable: false),
                    Estado_Id = table.Column<int>(type: "int", nullable: false),
                    Proceso_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    Prod_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesIngRollos_Extrusion", x => x.DtIngRollo_Id);
                    table.ForeignKey(
                        name: "FK_DetallesIngRollos_Extrusion_Estados_Estado_Id",
                        column: x => x.Estado_Id,
                        principalTable: "Estados",
                        principalColumn: "Estado_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesIngRollos_Extrusion_IngresoRollos_Extrusion_IngRollo_Id",
                        column: x => x.IngRollo_Id,
                        principalTable: "IngresoRollos_Extrusion",
                        principalColumn: "IngRollo_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesIngRollos_Extrusion_Procesos_Proceso_Id",
                        column: x => x.Proceso_Id,
                        principalTable: "Procesos",
                        principalColumn: "Proceso_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesIngRollos_Extrusion_Productos_Prod_Id",
                        column: x => x.Prod_Id,
                        principalTable: "Productos",
                        principalColumn: "Prod_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesIngRollos_Extrusion_Unidades_Medidas_UndMed_Id",
                        column: x => x.UndMed_Id,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetallesIngRollos_Extrusion_Estado_Id",
                table: "DetallesIngRollos_Extrusion",
                column: "Estado_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesIngRollos_Extrusion_IngRollo_Id",
                table: "DetallesIngRollos_Extrusion",
                column: "IngRollo_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesIngRollos_Extrusion_Proceso_Id",
                table: "DetallesIngRollos_Extrusion",
                column: "Proceso_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesIngRollos_Extrusion_Prod_Id",
                table: "DetallesIngRollos_Extrusion",
                column: "Prod_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesIngRollos_Extrusion_UndMed_Id",
                table: "DetallesIngRollos_Extrusion",
                column: "UndMed_Id");

            migrationBuilder.CreateIndex(
                name: "IX_IngresoRollos_Extrusion_Usua_Id",
                table: "IngresoRollos_Extrusion",
                column: "Usua_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallesIngRollos_Extrusion");

            migrationBuilder.DropTable(
                name: "IngresoRollos_Extrusion");

            migrationBuilder.DropColumn(
                name: "AsigProdFV_Hora",
                table: "AsignacionesProductos_FacturasVentas");
        }
    }
}
