using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlasticaribeApi_Prueba.Migrations
{
    public partial class CamposPruebas_EstProcOT2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "EstProcOT_CantProdFacturada",
                table: "Estados_ProcesosOT",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "EstProcOT_CantProdIngresada",
                table: "Estados_ProcesosOT",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "EstProcOT_CantidadPedidaUnd",
                table: "Estados_ProcesosOT",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EstProcOT_DiffDiasInicio_Fin",
                table: "Estados_ProcesosOT",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EstProcOT_FechaFinal",
                table: "Estados_ProcesosOT",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EstProcOT_FechaInicio",
                table: "Estados_ProcesosOT",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstProcOT_HoraFinal",
                table: "Estados_ProcesosOT",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstProcOT_HoraInicio",
                table: "Estados_ProcesosOT",
                type: "varchar(20)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstProcOT_CantProdFacturada",
                table: "Estados_ProcesosOT");

            migrationBuilder.DropColumn(
                name: "EstProcOT_CantProdIngresada",
                table: "Estados_ProcesosOT");

            migrationBuilder.DropColumn(
                name: "EstProcOT_CantidadPedidaUnd",
                table: "Estados_ProcesosOT");

            migrationBuilder.DropColumn(
                name: "EstProcOT_DiffDiasInicio_Fin",
                table: "Estados_ProcesosOT");

            migrationBuilder.DropColumn(
                name: "EstProcOT_FechaFinal",
                table: "Estados_ProcesosOT");

            migrationBuilder.DropColumn(
                name: "EstProcOT_FechaInicio",
                table: "Estados_ProcesosOT");

            migrationBuilder.DropColumn(
                name: "EstProcOT_HoraFinal",
                table: "Estados_ProcesosOT");

            migrationBuilder.DropColumn(
                name: "EstProcOT_HoraInicio",
                table: "Estados_ProcesosOT");
        }
    }
}
