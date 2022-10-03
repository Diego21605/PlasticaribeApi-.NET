using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlasticaribeApi_Prueba.Migrations
{
    public partial class CreacionBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Area_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Area_Nombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    Area_Descripcion = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Area_Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorias_Archivos",
                columns: table => new
                {
                    Categoria_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categoria_Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    Categoria_Descricion = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias_Archivos", x => x.Categoria_Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorias_Insumos",
                columns: table => new
                {
                    CatInsu_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatInsu_Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    CatInsu_Descripcion = table.Column<string>(type: "text", nullable: false),
                    CatInsu_UrlImagen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias_Insumos", x => x.CatInsu_Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorias_MatPrima",
                columns: table => new
                {
                    CatMP_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatMP_Nombre = table.Column<string>(type: "varchar(MAX)", nullable: false),
                    CatMP_Descripcion = table.Column<string>(type: "varchar(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias_MatPrima", x => x.CatMP_Id);
                });

            migrationBuilder.CreateTable(
                name: "Formato",
                columns: table => new
                {
                    Formato_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Formato_Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    Formato_Descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formato", x => x.Formato_Id);
                });

            migrationBuilder.CreateTable(
                name: "Laminado_Capa",
                columns: table => new
                {
                    LamCapa_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LamCapa_Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    LamCapa_Descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laminado_Capa", x => x.LamCapa_Id);
                });

            migrationBuilder.CreateTable(
                name: "Materiales_MatPrima",
                columns: table => new
                {
                    Material_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Material_Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    Material_Descripcion = table.Column<string>(type: "varchar(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materiales_MatPrima", x => x.Material_Id);
                });

            migrationBuilder.CreateTable(
                name: "Mezclas_Materiales",
                columns: table => new
                {
                    MezMaterial_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MezMaterial_Nombre = table.Column<string>(type: "varchar(150)", nullable: false),
                    MezMaterial_Descripcion = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mezclas_Materiales", x => x.MezMaterial_Id);
                });

            migrationBuilder.CreateTable(
                name: "Mezclas_Pigmentos",
                columns: table => new
                {
                    MezPigmto_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MezPigmto_Nombre = table.Column<string>(type: "varchar(150)", nullable: false),
                    MezPigmto_Descripcion = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mezclas_Pigmentos", x => x.MezPigmto_Id);
                });

            migrationBuilder.CreateTable(
                name: "Pigmentos",
                columns: table => new
                {
                    Pigmt_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pigmt_Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    Pigmt_Descripcion = table.Column<string>(type: "varchar(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pigmentos", x => x.Pigmt_Id);
                });

            migrationBuilder.CreateTable(
                name: "Pistas",
                columns: table => new
                {
                    Pista_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pista_Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    Pista_Descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pistas", x => x.Pista_Id);
                });

            migrationBuilder.CreateTable(
                name: "Procesos",
                columns: table => new
                {
                    Proceso_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    Proceso_Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Proceso_Nombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    Proceso_Descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procesos", x => x.Proceso_Id);
                });

            migrationBuilder.CreateTable(
                name: "Rodillos",
                columns: table => new
                {
                    Rodillo_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rodillo_Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    Rodillo_Descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rodillos", x => x.Rodillo_Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles_Usuarios",
                columns: table => new
                {
                    RolUsu_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolUsu_Nombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    RolUsu_Descripcion = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles_Usuarios", x => x.RolUsu_Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoIdentificaciones",
                columns: table => new
                {
                    TipoIdentificacion_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    TipoIdentificacion_Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoIdentificacion_Nombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    TipoIdentificacion_Descripcion = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoIdentificaciones", x => x.TipoIdentificacion_Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos_Clientes",
                columns: table => new
                {
                    TPCli_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TPCli_Nombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    TPCli_Descripcion = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_Clientes", x => x.TPCli_Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos_Documentos",
                columns: table => new
                {
                    TpDoc_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    TpDoc_Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    TpDoc_Descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_Documentos", x => x.TpDoc_Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos_Estados",
                columns: table => new
                {
                    TpEstado_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TpEstado_Nombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    TpEstado_Descripcion = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_Estados", x => x.TpEstado_Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos_FallasTecnicas",
                columns: table => new
                {
                    TipoFalla_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoFalla_Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    TipoFalla_Descripcion = table.Column<string>(type: "varchar(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_FallasTecnicas", x => x.TipoFalla_Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos_Impresion",
                columns: table => new
                {
                    TpImpresion_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TpImpresion_Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    Tp_Impresion_Descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_Impresion", x => x.TpImpresion_Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos_Monedas",
                columns: table => new
                {
                    TpMoneda_Id = table.Column<string>(type: "varchar(50)", nullable: false),
                    TpMoneda_Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TpMoneda_Nombre = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_Monedas", x => x.TpMoneda_Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos_Productos",
                columns: table => new
                {
                    TpProd_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TpProd_Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    TpProd_Descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_Productos", x => x.TpProd_Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos_Proveedores",
                columns: table => new
                {
                    TpProv_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TpProv_Nombre = table.Column<string>(type: "varchar(MAX)", nullable: false),
                    TpProv_Descripcion = table.Column<string>(type: "varchar(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_Proveedores", x => x.TpProv_Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos_Recuperados",
                columns: table => new
                {
                    TpRecu_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    TpRecu_Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    TpRecu_Descripcion = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_Recuperados", x => x.TpRecu_Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos_Sellados",
                columns: table => new
                {
                    TpSellado_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TpSellados_Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    TpSellado_Descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_Sellados", x => x.TpSellado_Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos_Usuarios",
                columns: table => new
                {
                    tpUsu_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tpUsu_Nombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    tpUsu_Descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_Usuarios", x => x.tpUsu_Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposDevoluciones_ProductosFacturados",
                columns: table => new
                {
                    TipoDevProdFact_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoDevProdFact_Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    TipoDevProdFact_Descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDevoluciones_ProductosFacturados", x => x.TipoDevProdFact_Id);
                });

            migrationBuilder.CreateTable(
                name: "Tratado",
                columns: table => new
                {
                    Tratado_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tratado_Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    Tratado_Descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tratado", x => x.Tratado_Id);
                });

            migrationBuilder.CreateTable(
                name: "Unidades_Medidas",
                columns: table => new
                {
                    UndMed_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    UndMed_Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UndMed_Nombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    UndMed_Descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidades_Medidas", x => x.UndMed_Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos_Bodegas",
                columns: table => new
                {
                    TpBod_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TpBod_Nombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    TpBod_Descripcion = table.Column<string>(type: "text", nullable: false),
                    Area_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_Bodegas", x => x.TpBod_Id);
                    table.ForeignKey(
                        name: "FK_Tipos_Bodegas_Areas_Area_Id",
                        column: x => x.Area_Id,
                        principalTable: "Areas",
                        principalColumn: "Area_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cajas_Compensaciones",
                columns: table => new
                {
                    cajComp_Id = table.Column<long>(type: "bigint", nullable: false),
                    TipoIdentificacion_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    cajComp_Nombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    cajComp_Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    cajComp_Telefono = table.Column<string>(type: "varchar(50)", nullable: false),
                    cajComp_CuentaBancaria = table.Column<long>(type: "bigint", nullable: false),
                    cajComp_Direccion = table.Column<string>(type: "varchar(100)", nullable: false),
                    cajComp_Ciudad = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cajas_Compensaciones", x => x.cajComp_Id);
                    table.ForeignKey(
                        name: "FK_Cajas_Compensaciones_TipoIdentificaciones_TipoIdentificacion_Id",
                        column: x => x.TipoIdentificacion_Id,
                        principalTable: "TipoIdentificaciones",
                        principalColumn: "TipoIdentificacion_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Empresa_Id = table.Column<long>(type: "bigint", nullable: false),
                    Empresa_Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoIdentificacion_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    Empresa_Nombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    Empresa_Direccion = table.Column<string>(type: "varchar(100)", nullable: false),
                    Empresa_Ciudad = table.Column<string>(type: "varchar(50)", nullable: false),
                    Empresa_Telefono = table.Column<string>(type: "varchar(50)", nullable: false),
                    Empresa_Correo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Empresa_COdigoPostal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Empresa_Id);
                    table.ForeignKey(
                        name: "FK_Empresas_TipoIdentificaciones_TipoIdentificacion_Id",
                        column: x => x.TipoIdentificacion_Id,
                        principalTable: "TipoIdentificaciones",
                        principalColumn: "TipoIdentificacion_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EPS",
                columns: table => new
                {
                    eps_Id = table.Column<long>(type: "bigint", nullable: false),
                    eps_Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoIdentificacion_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    eps_Nombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    eps_Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    eps_Telefono = table.Column<string>(type: "varchar(50)", nullable: false),
                    eps_CuentaBancaria = table.Column<long>(type: "bigint", nullable: false),
                    eps_Direccion = table.Column<string>(type: "varchar(100)", nullable: false),
                    eps_Ciudad = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EPS", x => x.eps_Id);
                    table.ForeignKey(
                        name: "FK_EPS_TipoIdentificaciones_TipoIdentificacion_Id",
                        column: x => x.TipoIdentificacion_Id,
                        principalTable: "TipoIdentificaciones",
                        principalColumn: "TipoIdentificacion_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FondosPensiones",
                columns: table => new
                {
                    fPen_Id = table.Column<long>(type: "bigint", nullable: false),
                    fPen_Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoIdentificacion_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    fPen_Nombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    fPen_Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    fPen_Telefono = table.Column<string>(type: "varchar(50)", nullable: false),
                    fPen_CuentaBancaria = table.Column<long>(type: "bigint", nullable: false),
                    fPen_Direccion = table.Column<string>(type: "varchar(100)", nullable: false),
                    fPen_Ciudad = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FondosPensiones", x => x.fPen_Id);
                    table.ForeignKey(
                        name: "FK_FondosPensiones_TipoIdentificaciones_TipoIdentificacion_Id",
                        column: x => x.TipoIdentificacion_Id,
                        principalTable: "TipoIdentificaciones",
                        principalColumn: "TipoIdentificacion_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    Estado_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado_Nombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    Estado_Descripcion = table.Column<string>(type: "text", nullable: true),
                    TpEstado_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.Estado_Id);
                    table.ForeignKey(
                        name: "FK_Estados_Tipos_Estados_TpEstado_Id",
                        column: x => x.TpEstado_Id,
                        principalTable: "Tipos_Estados",
                        principalColumn: "TpEstado_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fallas_Tecnicas",
                columns: table => new
                {
                    Falla_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Falla_Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    Falla_Descripcion = table.Column<string>(type: "varchar(MAX)", nullable: false),
                    TipoFalla_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fallas_Tecnicas", x => x.Falla_Id);
                    table.ForeignKey(
                        name: "FK_Fallas_Tecnicas_Tipos_FallasTecnicas_TipoFalla_Id",
                        column: x => x.TipoFalla_Id,
                        principalTable: "Tipos_FallasTecnicas",
                        principalColumn: "TipoFalla_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    Prov_Id = table.Column<long>(type: "bigint", nullable: false),
                    Prov_Codigo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoIdentificacion_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    Prov_Nombre = table.Column<string>(type: "varchar(MAX)", nullable: false),
                    TpProv_Id = table.Column<int>(type: "int", nullable: false),
                    Prov_Ciudad = table.Column<string>(type: "varchar(100)", nullable: true),
                    Prov_Telefono = table.Column<string>(type: "varchar(100)", nullable: true),
                    Prov_Email = table.Column<string>(type: "varchar(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.Prov_Id);
                    table.ForeignKey(
                        name: "FK_Proveedores_TipoIdentificaciones_TipoIdentificacion_Id",
                        column: x => x.TipoIdentificacion_Id,
                        principalTable: "TipoIdentificaciones",
                        principalColumn: "TipoIdentificacion_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proveedores_Tipos_Proveedores_TpProv_Id",
                        column: x => x.TpProv_Id,
                        principalTable: "Tipos_Proveedores",
                        principalColumn: "TpProv_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Insumos",
                columns: table => new
                {
                    Insu_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Insu_Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    Insu_Stock = table.Column<string>(type: "varchar(100)", precision: 18, scale: 2, nullable: false),
                    UndMed_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    CatInsu_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insumos", x => x.Insu_Id);
                    table.ForeignKey(
                        name: "FK_Insumos_Categorias_Insumos_CatInsu_Id",
                        column: x => x.CatInsu_Id,
                        principalTable: "Categorias_Insumos",
                        principalColumn: "CatInsu_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Insumos_Unidades_Medidas_UndMed_Id",
                        column: x => x.UndMed_Id,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InventarioInicialXDias_MatPrima",
                columns: table => new
                {
                    MatPri_Id = table.Column<long>(type: "bigint", nullable: false),
                    InvInicial_Stock = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    UndMed_Id = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventarioInicialXDias_MatPrima", x => x.MatPri_Id);
                    table.ForeignKey(
                        name: "FK_InventarioInicialXDias_MatPrima_Unidades_Medidas_UndMed_Id",
                        column: x => x.UndMed_Id,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Materias_Primas",
                columns: table => new
                {
                    MatPri_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatPri_Nombre = table.Column<string>(type: "varchar(MAX)", nullable: false),
                    MatPri_Descripcion = table.Column<string>(type: "varchar(MAX)", nullable: false),
                    MatPri_Stock = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    UndMed_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    CatMP_Id = table.Column<int>(type: "int", nullable: false),
                    MatPri_Precio = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    TpBod_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias_Primas", x => x.MatPri_Id);
                    table.ForeignKey(
                        name: "FK_Materias_Primas_Categorias_MatPrima_CatMP_Id",
                        column: x => x.CatMP_Id,
                        principalTable: "Categorias_MatPrima",
                        principalColumn: "CatMP_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Materias_Primas_Tipos_Bodegas_TpBod_Id",
                        column: x => x.TpBod_Id,
                        principalTable: "Tipos_Bodegas",
                        principalColumn: "TpBod_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Materias_Primas_Unidades_Medidas_UndMed_Id",
                        column: x => x.UndMed_Id,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tintas",
                columns: table => new
                {
                    Tinta_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tinta_Nombre = table.Column<string>(type: "varchar(MAX)", nullable: false),
                    Tinta_Descripcion = table.Column<string>(type: "varchar(MAX)", nullable: true),
                    Tinta_CodigoHexadecimal = table.Column<string>(type: "varchar(50)", nullable: true),
                    Tinta_Stock = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    UndMed_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    Tinta_Precio = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    CatMP_Id = table.Column<int>(type: "int", nullable: false),
                    TpBod_Id = table.Column<int>(type: "int", nullable: false),
                    Tinta_InvInicial = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tintas", x => x.Tinta_Id);
                    table.ForeignKey(
                        name: "FK_Tintas_Categorias_MatPrima_CatMP_Id",
                        column: x => x.CatMP_Id,
                        principalTable: "Categorias_MatPrima",
                        principalColumn: "CatMP_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tintas_Tipos_Bodegas_TpBod_Id",
                        column: x => x.TpBod_Id,
                        principalTable: "Tipos_Bodegas",
                        principalColumn: "TpBod_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tintas_Unidades_Medidas_UndMed_Id",
                        column: x => x.UndMed_Id,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Prod_Cod = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prod_Id = table.Column<int>(type: "int", nullable: false),
                    Prod_Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    Prod_Descripcion = table.Column<string>(type: "text", nullable: true),
                    TpProd_Id = table.Column<int>(type: "int", nullable: false),
                    Prod_Peso_Millar = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    Prod_Peso = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    UndMedPeso = table.Column<string>(type: "varchar(10)", nullable: false),
                    Prod_Fuelle = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: true),
                    Prod_Ancho = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: true),
                    Prod_Largo = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: true),
                    Prod_Calibre = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: true),
                    UndMedACF = table.Column<string>(type: "varchar(10)", nullable: false),
                    Estado_Id = table.Column<int>(type: "int", nullable: true),
                    Pigmt_Id = table.Column<int>(type: "int", nullable: true),
                    Material_Id = table.Column<int>(type: "int", nullable: true),
                    TpSellado_Id = table.Column<int>(type: "int", nullable: true),
                    Prod_CantBolsasPaquete = table.Column<int>(type: "int", precision: 14, scale: 2, nullable: true),
                    Prod_CantBolsasBulto = table.Column<int>(type: "int", precision: 14, scale: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Prod_Id);
                    table.ForeignKey(
                        name: "FK_Productos_Estados_Estado_Id",
                        column: x => x.Estado_Id,
                        principalTable: "Estados",
                        principalColumn: "Estado_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Productos_Materiales_MatPrima_Material_Id",
                        column: x => x.Material_Id,
                        principalTable: "Materiales_MatPrima",
                        principalColumn: "Material_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Productos_Pigmentos_Pigmt_Id",
                        column: x => x.Pigmt_Id,
                        principalTable: "Pigmentos",
                        principalColumn: "Pigmt_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Productos_Tipos_Productos_TpProd_Id",
                        column: x => x.TpProd_Id,
                        principalTable: "Tipos_Productos",
                        principalColumn: "TpProd_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Productos_Tipos_Sellados_TpSellado_Id",
                        column: x => x.TpSellado_Id,
                        principalTable: "Tipos_Sellados",
                        principalColumn: "TpSellado_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Productos_Unidades_Medidas_UndMedACF",
                        column: x => x.UndMedACF,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Productos_Unidades_Medidas_UndMedPeso",
                        column: x => x.UndMedPeso,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Usua_Id = table.Column<long>(type: "bigint", nullable: false),
                    Usua_Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoIdentificacion_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    Usua_Nombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    Area_Id = table.Column<long>(type: "bigint", nullable: false),
                    tpUsu_Id = table.Column<int>(type: "int", nullable: false),
                    RolUsu_Id = table.Column<int>(type: "int", nullable: false),
                    Empresa_Id = table.Column<long>(type: "bigint", nullable: false),
                    Estado_Id = table.Column<int>(type: "int", nullable: false),
                    Usua_Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    Usua_Telefono = table.Column<string>(type: "varchar(50)", nullable: false),
                    Usua_Contrasena = table.Column<string>(type: "varchar(100)", nullable: false),
                    cajComp_Id = table.Column<long>(type: "bigint", nullable: false),
                    eps_Id = table.Column<long>(type: "bigint", nullable: false),
                    fPen_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Usua_Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Areas_Area_Id",
                        column: x => x.Area_Id,
                        principalTable: "Areas",
                        principalColumn: "Area_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuarios_Cajas_Compensaciones_cajComp_Id",
                        column: x => x.cajComp_Id,
                        principalTable: "Cajas_Compensaciones",
                        principalColumn: "cajComp_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuarios_Empresas_Empresa_Id",
                        column: x => x.Empresa_Id,
                        principalTable: "Empresas",
                        principalColumn: "Empresa_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuarios_EPS_eps_Id",
                        column: x => x.eps_Id,
                        principalTable: "EPS",
                        principalColumn: "eps_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuarios_Estados_Estado_Id",
                        column: x => x.Estado_Id,
                        principalTable: "Estados",
                        principalColumn: "Estado_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuarios_FondosPensiones_fPen_Id",
                        column: x => x.fPen_Id,
                        principalTable: "FondosPensiones",
                        principalColumn: "fPen_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuarios_Roles_Usuarios_RolUsu_Id",
                        column: x => x.RolUsu_Id,
                        principalTable: "Roles_Usuarios",
                        principalColumn: "RolUsu_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuarios_TipoIdentificaciones_TipoIdentificacion_Id",
                        column: x => x.TipoIdentificacion_Id,
                        principalTable: "TipoIdentificaciones",
                        principalColumn: "TipoIdentificacion_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuarios_Tipos_Usuarios_tpUsu_Id",
                        column: x => x.tpUsu_Id,
                        principalTable: "Tipos_Usuarios",
                        principalColumn: "tpUsu_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estados_ProcesosOT",
                columns: table => new
                {
                    EstProcOT_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstProcOT_OrdenTrabajo = table.Column<long>(type: "bigint", nullable: false),
                    EstProcOT_ExtrusionKg = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    EstProcOT_ImpresionKg = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    EstProcOT_RotograbadoKg = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    EstProcOT_LaminadoKg = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    EstProcOT_CorteKg = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    EstProcOT_DobladoKg = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    EstProcOT_EmpaqueKg = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    EstProcOT_SelladoKg = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    EstProcOT_SelladoUnd = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    EstProcOT_WiketiadoKg = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    EstProcOT_WiketiadoUnd = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    EstProcOT_CantidadPedida = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    UndMed_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    Estado_Id = table.Column<int>(type: "int", nullable: false),
                    Falla_Id = table.Column<int>(type: "int", nullable: false),
                    EstProcOT_Observacion = table.Column<string>(type: "varchar(MAX)", nullable: false),
                    EstProcOT_FechaCreacion = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados_ProcesosOT", x => x.EstProcOT_Id);
                    table.ForeignKey(
                        name: "FK_Estados_ProcesosOT_Estados_Estado_Id",
                        column: x => x.Estado_Id,
                        principalTable: "Estados",
                        principalColumn: "Estado_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estados_ProcesosOT_Fallas_Tecnicas_Falla_Id",
                        column: x => x.Falla_Id,
                        principalTable: "Fallas_Tecnicas",
                        principalColumn: "Falla_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estados_ProcesosOT_Unidades_Medidas_UndMed_Id",
                        column: x => x.UndMed_Id,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores_MateriasPrimas",
                columns: table => new
                {
                    Prov_Id = table.Column<long>(type: "bigint", nullable: false),
                    MatPri_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores_MateriasPrimas", x => new { x.Prov_Id, x.MatPri_Id });
                    table.ForeignKey(
                        name: "FK_Proveedores_MateriasPrimas_Materias_Primas_MatPri_Id",
                        column: x => x.MatPri_Id,
                        principalTable: "Materias_Primas",
                        principalColumn: "MatPri_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proveedores_MateriasPrimas_Proveedores_Prov_Id",
                        column: x => x.Prov_Id,
                        principalTable: "Proveedores",
                        principalColumn: "Prov_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tintas_MateriasPrimas",
                columns: table => new
                {
                    Tinta_Id = table.Column<long>(type: "bigint", nullable: false),
                    MatPri_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tintas_MateriasPrimas", x => new { x.Tinta_Id, x.MatPri_Id });
                    table.ForeignKey(
                        name: "FK_Tintas_MateriasPrimas_Materias_Primas_MatPri_Id",
                        column: x => x.MatPri_Id,
                        principalTable: "Materias_Primas",
                        principalColumn: "MatPri_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tintas_MateriasPrimas_Tintas_Tinta_Id",
                        column: x => x.Tinta_Id,
                        principalTable: "Tintas",
                        principalColumn: "Tinta_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Existencias_Productos",
                columns: table => new
                {
                    Prod_Id = table.Column<int>(type: "int", nullable: false),
                    ExProd_Cantidad = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    UndMed_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    TpBod_Id = table.Column<int>(type: "int", nullable: false),
                    ExProd_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExProd_Precio = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ExProd_PrecioExistencia = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ExProd_PrecioSinInflacion = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    TpMoneda_Id = table.Column<string>(type: "varchar(50)", nullable: false),
                    ExProd_PrecioVenta = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    ExProd_CantMinima = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Existencias_Productos", x => x.ExProd_Id);
                    table.ForeignKey(
                        name: "FK_Existencias_Productos_Productos_Prod_Id",
                        column: x => x.Prod_Id,
                        principalTable: "Productos",
                        principalColumn: "Prod_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Existencias_Productos_Tipos_Bodegas_TpBod_Id",
                        column: x => x.TpBod_Id,
                        principalTable: "Tipos_Bodegas",
                        principalColumn: "TpBod_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Existencias_Productos_Tipos_Monedas_TpMoneda_Id",
                        column: x => x.TpMoneda_Id,
                        principalTable: "Tipos_Monedas",
                        principalColumn: "TpMoneda_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Existencias_Productos_Unidades_Medidas_UndMed_Id",
                        column: x => x.UndMed_Id,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Archivos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "date", nullable: false),
                    Categoria_Id = table.Column<int>(type: "int", nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Usua_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Archivos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Archivos_Categorias_Archivos_Categoria_Id",
                        column: x => x.Categoria_Id,
                        principalTable: "Categorias_Archivos",
                        principalColumn: "Categoria_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Archivos_Usuarios_Usua_Id",
                        column: x => x.Usua_Id,
                        principalTable: "Usuarios",
                        principalColumn: "Usua_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Asignaciones_BOPP",
                columns: table => new
                {
                    AsigBOPP_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsigBOPP_FechaEntrega = table.Column<DateTime>(type: "Date", nullable: false),
                    AsigBOPP_Observacion = table.Column<string>(type: "text", nullable: true),
                    Usua_Id = table.Column<long>(type: "bigint", nullable: false),
                    Estado_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignaciones_BOPP", x => x.AsigBOPP_Id);
                    table.ForeignKey(
                        name: "FK_Asignaciones_BOPP_Estados_Estado_Id",
                        column: x => x.Estado_Id,
                        principalTable: "Estados",
                        principalColumn: "Estado_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asignaciones_BOPP_Usuarios_Usua_Id",
                        column: x => x.Usua_Id,
                        principalTable: "Usuarios",
                        principalColumn: "Usua_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Asignaciones_MatPrima",
                columns: table => new
                {
                    AsigMp_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsigMP_OrdenTrabajo = table.Column<long>(type: "bigint", nullable: false),
                    AsigMp_FechaEntrega = table.Column<DateTime>(type: "Date", nullable: false),
                    AsigMp_Observacion = table.Column<string>(type: "text", nullable: true),
                    Usua_Id = table.Column<long>(type: "bigint", nullable: false),
                    Estado_Id = table.Column<int>(type: "int", nullable: false),
                    AsigMp_Maquina = table.Column<int>(type: "int", nullable: false),
                    Estado_OrdenTrabajo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignaciones_MatPrima", x => x.AsigMp_Id);
                    table.ForeignKey(
                        name: "FK_Asignaciones_MatPrima_Estados_Estado_Id",
                        column: x => x.Estado_Id,
                        principalTable: "Estados",
                        principalColumn: "Estado_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asignaciones_MatPrima_Estados_Estado_OrdenTrabajo",
                        column: x => x.Estado_OrdenTrabajo,
                        principalTable: "Estados",
                        principalColumn: "Estado_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asignaciones_MatPrima_Usuarios_Usua_Id",
                        column: x => x.Usua_Id,
                        principalTable: "Usuarios",
                        principalColumn: "Usua_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Asignaciones_MatPrimasXTintas",
                columns: table => new
                {
                    AsigMPxTinta_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tinta_Id = table.Column<long>(type: "bigint", nullable: false),
                    AsigMPxTinta_Cantidad = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    UndMed_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    AsigMPxTinta_FechaEntrega = table.Column<DateTime>(type: "Date", nullable: false),
                    AsigMPxTinta_Observacion = table.Column<string>(type: "text", nullable: true),
                    Usua_Id = table.Column<long>(type: "bigint", nullable: false),
                    Estado_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignaciones_MatPrimasXTintas", x => x.AsigMPxTinta_Id);
                    table.ForeignKey(
                        name: "FK_Asignaciones_MatPrimasXTintas_Estados_Estado_Id",
                        column: x => x.Estado_Id,
                        principalTable: "Estados",
                        principalColumn: "Estado_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asignaciones_MatPrimasXTintas_Tintas_Tinta_Id",
                        column: x => x.Tinta_Id,
                        principalTable: "Tintas",
                        principalColumn: "Tinta_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asignaciones_MatPrimasXTintas_Unidades_Medidas_UndMed_Id",
                        column: x => x.UndMed_Id,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asignaciones_MatPrimasXTintas_Usuarios_Usua_Id",
                        column: x => x.Usua_Id,
                        principalTable: "Usuarios",
                        principalColumn: "Usua_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BOPP",
                columns: table => new
                {
                    BOPP_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BOPP_Nombre = table.Column<string>(type: "varchar(MAX)", nullable: false),
                    BOPP_Descripcion = table.Column<string>(type: "varchar(MAX)", nullable: true),
                    BOPP_Serial = table.Column<long>(type: "bigint", nullable: false),
                    BOPP_CantidadMicras = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    UndMed_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    CatMP_Id = table.Column<int>(type: "int", nullable: false),
                    BOPP_Precio = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    TpBod_Id = table.Column<int>(type: "int", nullable: false),
                    BOPP_FechaIngreso = table.Column<DateTime>(type: "Date", nullable: false),
                    BOPP_Ancho = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    BOPP_Stock = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    UndMed_Kg = table.Column<string>(type: "varchar(10)", nullable: false),
                    BOPP_CantidadInicialKg = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    Usua_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOPP", x => x.BOPP_Id);
                    table.ForeignKey(
                        name: "FK_BOPP_Categorias_MatPrima_CatMP_Id",
                        column: x => x.CatMP_Id,
                        principalTable: "Categorias_MatPrima",
                        principalColumn: "CatMP_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BOPP_Tipos_Bodegas_TpBod_Id",
                        column: x => x.TpBod_Id,
                        principalTable: "Tipos_Bodegas",
                        principalColumn: "TpBod_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BOPP_Unidades_Medidas_UndMed_Id",
                        column: x => x.UndMed_Id,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BOPP_Unidades_Medidas_UndMed_Kg",
                        column: x => x.UndMed_Kg,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BOPP_Usuarios_Usua_Id",
                        column: x => x.Usua_Id,
                        principalTable: "Usuarios",
                        principalColumn: "Usua_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Cli_Id = table.Column<long>(type: "bigint", nullable: false),
                    Cli_Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoIdentificacion_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    Cli_Nombre = table.Column<string>(type: "varchar(MAX)", nullable: false),
                    Cli_Telefono = table.Column<string>(type: "varchar(60)", nullable: false),
                    Cli_Email = table.Column<string>(type: "varchar(MAX)", nullable: false),
                    TPCli_Id = table.Column<int>(type: "int", nullable: false),
                    usua_Id = table.Column<long>(type: "bigint", nullable: false),
                    Estado_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Cli_Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Estados_Estado_Id",
                        column: x => x.Estado_Id,
                        principalTable: "Estados",
                        principalColumn: "Estado_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clientes_TipoIdentificaciones_TipoIdentificacion_Id",
                        column: x => x.TipoIdentificacion_Id,
                        principalTable: "TipoIdentificaciones",
                        principalColumn: "TipoIdentificacion_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clientes_Tipos_Clientes_TPCli_Id",
                        column: x => x.TPCli_Id,
                        principalTable: "Tipos_Clientes",
                        principalColumn: "TPCli_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clientes_Usuarios_usua_Id",
                        column: x => x.usua_Id,
                        principalTable: "Usuarios",
                        principalColumn: "Usua_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Devoluciones_MatPrima",
                columns: table => new
                {
                    DevMatPri_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DevMatPri_OrdenTrabajo = table.Column<long>(type: "bigint", nullable: false),
                    DevMatPri_Fecha = table.Column<DateTime>(type: "Date", nullable: false),
                    DevMatPri_Motivo = table.Column<string>(type: "text", nullable: true),
                    Usua_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devoluciones_MatPrima", x => x.DevMatPri_Id);
                    table.ForeignKey(
                        name: "FK_Devoluciones_MatPrima_Usuarios_Usua_Id",
                        column: x => x.Usua_Id,
                        principalTable: "Usuarios",
                        principalColumn: "Usua_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Entradas_Tintas",
                columns: table => new
                {
                    EntTinta_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    entTinta_FechaEntrada = table.Column<DateTime>(type: "Date", nullable: false),
                    Usua_Id = table.Column<long>(type: "bigint", nullable: false),
                    EntTinta_Observacion = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entradas_Tintas", x => x.EntTinta_Id);
                    table.ForeignKey(
                        name: "FK_Entradas_Tintas_Usuarios_Usua_Id",
                        column: x => x.Usua_Id,
                        principalTable: "Usuarios",
                        principalColumn: "Usua_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EntradasRollos_Productos",
                columns: table => new
                {
                    EntRolloProd_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntRolloProd_Fecha = table.Column<DateTime>(type: "date", nullable: false),
                    EntRolloProd_Observacion = table.Column<string>(type: "text", nullable: true),
                    Usua_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntradasRollos_Productos", x => x.EntRolloProd_Id);
                    table.ForeignKey(
                        name: "FK_EntradasRollos_Productos_Usuarios_Usua_Id",
                        column: x => x.Usua_Id,
                        principalTable: "Usuarios",
                        principalColumn: "Usua_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Facturas_Compras",
                columns: table => new
                {
                    Facco_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Facco_Codigo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Facco_FechaFactura = table.Column<DateTime>(type: "Date", nullable: false),
                    Facco_FechaVencimiento = table.Column<DateTime>(type: "Date", nullable: false),
                    Prov_Id = table.Column<long>(type: "bigint", nullable: false),
                    Facco_ValorTotal = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Facco_Observacion = table.Column<string>(type: "text", nullable: true),
                    Estado_Id = table.Column<int>(type: "int", nullable: false),
                    Usua_Id = table.Column<long>(type: "bigint", nullable: false),
                    TpDoc_Id = table.Column<string>(type: "varchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas_Compras", x => x.Facco_Id);
                    table.ForeignKey(
                        name: "FK_Facturas_Compras_Estados_Estado_Id",
                        column: x => x.Estado_Id,
                        principalTable: "Estados",
                        principalColumn: "Estado_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Facturas_Compras_Proveedores_Prov_Id",
                        column: x => x.Prov_Id,
                        principalTable: "Proveedores",
                        principalColumn: "Prov_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Facturas_Compras_Tipos_Documentos_TpDoc_Id",
                        column: x => x.TpDoc_Id,
                        principalTable: "Tipos_Documentos",
                        principalColumn: "TpDoc_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Facturas_Compras_Usuarios_Usua_Id",
                        column: x => x.Usua_Id,
                        principalTable: "Usuarios",
                        principalColumn: "Usua_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mezclas",
                columns: table => new
                {
                    Mezcla_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mezcla_Nombre = table.Column<string>(type: "varchar(MAX)", nullable: false),
                    Mezcla_NroCapas = table.Column<int>(type: "int", nullable: false),
                    Material_Id = table.Column<int>(type: "int", nullable: false),
                    Mezcla_PorcentajeCapa1 = table.Column<int>(type: "int", precision: 18, scale: 2, nullable: false),
                    MezMaterial_Id1xCapa1 = table.Column<int>(type: "int", nullable: false),
                    Mezcla_PorcentajeMaterial1_Capa1 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MezMaterial_Id2xCapa1 = table.Column<int>(type: "int", nullable: false),
                    Mezcla_PorcentajeMaterial2_Capa1 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MezMaterial_Id3xCapa1 = table.Column<int>(type: "int", nullable: false),
                    Mezcla_PorcentajeMaterial3_Capa1 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MezMaterial_Id4xCapa1 = table.Column<int>(type: "int", nullable: false),
                    Mezcla_PorcentajeMaterial4_Capa1 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MezPigmto_Id1xCapa1 = table.Column<int>(type: "int", nullable: false),
                    Mezcla_PorcentajePigmto1_Capa1 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MezPigmto_Id2xCapa1 = table.Column<int>(type: "int", nullable: false),
                    Mezcla_PorcentajePigmto2_Capa1 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Mezcla_PorcentajeCapa2 = table.Column<int>(type: "int", nullable: false),
                    MezMaterial_Id1xCapa2 = table.Column<int>(type: "int", nullable: false),
                    Mezcla_PorcentajeMaterial1_Capa2 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MezMaterial_Id2xCapa2 = table.Column<int>(type: "int", nullable: false),
                    Mezcla_PorcentajeMaterial2_Capa2 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MezMaterial_Id3xCapa2 = table.Column<int>(type: "int", nullable: false),
                    Mezcla_PorcentajeMaterial3_Capa2 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MezMaterial_Id4xCapa2 = table.Column<int>(type: "int", nullable: false),
                    Mezcla_PorcentajeMaterial4_Capa2 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MezPigmto_Id1xCapa2 = table.Column<int>(type: "int", nullable: false),
                    Mezcla_PorcentajePigmto1_Capa2 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MezPigmto_Id2xCapa2 = table.Column<int>(type: "int", nullable: false),
                    Mezcla_PorcentajePigmto2_Capa2 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Mezcla_PorcentajeCapa3 = table.Column<int>(type: "int", nullable: false),
                    MezMaterial_Id1xCapa3 = table.Column<int>(type: "int", nullable: false),
                    Mezcla_PorcentajeMaterial1_Capa3 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MezMaterial_Id2xCapa3 = table.Column<int>(type: "int", nullable: false),
                    Mezcla_PorcentajeMaterial2_Capa3 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MezMaterial_Id3xCapa3 = table.Column<int>(type: "int", nullable: false),
                    Mezcla_PorcentajeMaterial3_Capa3 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MezMaterial_Id4xCapa3 = table.Column<int>(type: "int", nullable: false),
                    Mezcla_PorcentajeMaterial4_Capa3 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MezPigmto_Id1xCapa3 = table.Column<int>(type: "int", nullable: false),
                    Mezcla_PorcentajePigmto1_Capa3 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MezPigmto_Id2xCapa3 = table.Column<int>(type: "int", nullable: false),
                    Mezcla_PorcentajePigmto2_Capa3 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Usua_Id = table.Column<long>(type: "bigint", nullable: false),
                    Mezcla_FechaIngreso = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mezclas", x => x.Mezcla_Id);
                    table.ForeignKey(
                        name: "FK_Mezclas_Materiales_MatPrima_Material_Id",
                        column: x => x.Material_Id,
                        principalTable: "Materiales_MatPrima",
                        principalColumn: "Material_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mezclas_Mezclas_Materiales_MezMaterial_Id1xCapa1",
                        column: x => x.MezMaterial_Id1xCapa1,
                        principalTable: "Mezclas_Materiales",
                        principalColumn: "MezMaterial_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mezclas_Mezclas_Materiales_MezMaterial_Id1xCapa2",
                        column: x => x.MezMaterial_Id1xCapa2,
                        principalTable: "Mezclas_Materiales",
                        principalColumn: "MezMaterial_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mezclas_Mezclas_Materiales_MezMaterial_Id1xCapa3",
                        column: x => x.MezMaterial_Id1xCapa3,
                        principalTable: "Mezclas_Materiales",
                        principalColumn: "MezMaterial_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mezclas_Mezclas_Materiales_MezMaterial_Id2xCapa1",
                        column: x => x.MezMaterial_Id2xCapa1,
                        principalTable: "Mezclas_Materiales",
                        principalColumn: "MezMaterial_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mezclas_Mezclas_Materiales_MezMaterial_Id2xCapa2",
                        column: x => x.MezMaterial_Id2xCapa2,
                        principalTable: "Mezclas_Materiales",
                        principalColumn: "MezMaterial_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mezclas_Mezclas_Materiales_MezMaterial_Id2xCapa3",
                        column: x => x.MezMaterial_Id2xCapa3,
                        principalTable: "Mezclas_Materiales",
                        principalColumn: "MezMaterial_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mezclas_Mezclas_Materiales_MezMaterial_Id3xCapa1",
                        column: x => x.MezMaterial_Id3xCapa1,
                        principalTable: "Mezclas_Materiales",
                        principalColumn: "MezMaterial_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mezclas_Mezclas_Materiales_MezMaterial_Id3xCapa2",
                        column: x => x.MezMaterial_Id3xCapa2,
                        principalTable: "Mezclas_Materiales",
                        principalColumn: "MezMaterial_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mezclas_Mezclas_Materiales_MezMaterial_Id3xCapa3",
                        column: x => x.MezMaterial_Id3xCapa3,
                        principalTable: "Mezclas_Materiales",
                        principalColumn: "MezMaterial_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mezclas_Mezclas_Materiales_MezMaterial_Id4xCapa1",
                        column: x => x.MezMaterial_Id4xCapa1,
                        principalTable: "Mezclas_Materiales",
                        principalColumn: "MezMaterial_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mezclas_Mezclas_Materiales_MezMaterial_Id4xCapa2",
                        column: x => x.MezMaterial_Id4xCapa2,
                        principalTable: "Mezclas_Materiales",
                        principalColumn: "MezMaterial_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mezclas_Mezclas_Materiales_MezMaterial_Id4xCapa3",
                        column: x => x.MezMaterial_Id4xCapa3,
                        principalTable: "Mezclas_Materiales",
                        principalColumn: "MezMaterial_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mezclas_Mezclas_Pigmentos_MezPigmto_Id1xCapa1",
                        column: x => x.MezPigmto_Id1xCapa1,
                        principalTable: "Mezclas_Pigmentos",
                        principalColumn: "MezPigmto_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mezclas_Mezclas_Pigmentos_MezPigmto_Id1xCapa2",
                        column: x => x.MezPigmto_Id1xCapa2,
                        principalTable: "Mezclas_Pigmentos",
                        principalColumn: "MezPigmto_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mezclas_Mezclas_Pigmentos_MezPigmto_Id1xCapa3",
                        column: x => x.MezPigmto_Id1xCapa3,
                        principalTable: "Mezclas_Pigmentos",
                        principalColumn: "MezPigmto_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mezclas_Mezclas_Pigmentos_MezPigmto_Id2xCapa1",
                        column: x => x.MezPigmto_Id2xCapa1,
                        principalTable: "Mezclas_Pigmentos",
                        principalColumn: "MezPigmto_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mezclas_Mezclas_Pigmentos_MezPigmto_Id2xCapa2",
                        column: x => x.MezPigmto_Id2xCapa2,
                        principalTable: "Mezclas_Pigmentos",
                        principalColumn: "MezPigmto_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mezclas_Mezclas_Pigmentos_MezPigmto_Id2xCapa3",
                        column: x => x.MezPigmto_Id2xCapa3,
                        principalTable: "Mezclas_Pigmentos",
                        principalColumn: "MezPigmto_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mezclas_Usuarios_Usua_Id",
                        column: x => x.Usua_Id,
                        principalTable: "Usuarios",
                        principalColumn: "Usua_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PreEntrega_RollosDespacho",
                columns: table => new
                {
                    PreEntRollo_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PreEntRollo_Fecha = table.Column<DateTime>(type: "date", nullable: false),
                    PreEntRollo_Observacion = table.Column<string>(type: "text", nullable: true),
                    Usua_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreEntrega_RollosDespacho", x => x.PreEntRollo_Id);
                    table.ForeignKey(
                        name: "FK_PreEntrega_RollosDespacho_Usuarios_Usua_Id",
                        column: x => x.Usua_Id,
                        principalTable: "Usuarios",
                        principalColumn: "Usua_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recuperados_MatPrima",
                columns: table => new
                {
                    RecMp_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecMp_FechaIngreso = table.Column<DateTime>(type: "date", nullable: false),
                    Usua_Id = table.Column<long>(type: "bigint", nullable: false),
                    RecMp_Observacion = table.Column<string>(type: "text", nullable: true),
                    Proc_Id = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recuperados_MatPrima", x => x.RecMp_Id);
                    table.ForeignKey(
                        name: "FK_Recuperados_MatPrima_Procesos_Proc_Id",
                        column: x => x.Proc_Id,
                        principalTable: "Procesos",
                        principalColumn: "Proceso_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recuperados_MatPrima_Usuarios_Usua_Id",
                        column: x => x.Usua_Id,
                        principalTable: "Usuarios",
                        principalColumn: "Usua_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Remisiones",
                columns: table => new
                {
                    Rem_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rem_Codigo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Rem_Fecha = table.Column<DateTime>(type: "Date", nullable: false),
                    Rem_PrecioEstimado = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    Prov_Id = table.Column<long>(type: "bigint", nullable: false),
                    Estado_Id = table.Column<int>(type: "int", nullable: false),
                    Usua_Id = table.Column<long>(type: "bigint", nullable: false),
                    TpDoc_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    Rem_Observacion = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Remisiones", x => x.Rem_Id);
                    table.ForeignKey(
                        name: "FK_Remisiones_Estados_Estado_Id",
                        column: x => x.Estado_Id,
                        principalTable: "Estados",
                        principalColumn: "Estado_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Remisiones_Proveedores_Prov_Id",
                        column: x => x.Prov_Id,
                        principalTable: "Proveedores",
                        principalColumn: "Prov_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Remisiones_Tipos_Documentos_TpDoc_Id",
                        column: x => x.TpDoc_Id,
                        principalTable: "Tipos_Documentos",
                        principalColumn: "TpDoc_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Remisiones_Usuarios_Usua_Id",
                        column: x => x.Usua_Id,
                        principalTable: "Usuarios",
                        principalColumn: "Usua_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleAsignaciones_Tintas",
                columns: table => new
                {
                    AsigMp_Id = table.Column<long>(type: "bigint", nullable: false),
                    Tinta_Id = table.Column<long>(type: "bigint", nullable: false),
                    DtAsigTinta_Cantidad = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    UndMed_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    Proceso_Id = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleAsignaciones_Tintas", x => new { x.AsigMp_Id, x.Tinta_Id });
                    table.ForeignKey(
                        name: "FK_DetalleAsignaciones_Tintas_Asignaciones_MatPrima_AsigMp_Id",
                        column: x => x.AsigMp_Id,
                        principalTable: "Asignaciones_MatPrima",
                        principalColumn: "AsigMp_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleAsignaciones_Tintas_Procesos_Proceso_Id",
                        column: x => x.Proceso_Id,
                        principalTable: "Procesos",
                        principalColumn: "Proceso_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleAsignaciones_Tintas_Tintas_Tinta_Id",
                        column: x => x.Tinta_Id,
                        principalTable: "Tintas",
                        principalColumn: "Tinta_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleAsignaciones_Tintas_Unidades_Medidas_UndMed_Id",
                        column: x => x.UndMed_Id,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetallesAsignaciones_MateriasPrimas",
                columns: table => new
                {
                    AsigMp_Id = table.Column<long>(type: "bigint", nullable: false),
                    MatPri_Id = table.Column<long>(type: "bigint", nullable: false),
                    DtAsigMp_Cantidad = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    UndMed_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    Proceso_Id = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesAsignaciones_MateriasPrimas", x => new { x.AsigMp_Id, x.MatPri_Id });
                    table.ForeignKey(
                        name: "FK_DetallesAsignaciones_MateriasPrimas_Asignaciones_MatPrima_AsigMp_Id",
                        column: x => x.AsigMp_Id,
                        principalTable: "Asignaciones_MatPrima",
                        principalColumn: "AsigMp_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesAsignaciones_MateriasPrimas_Materias_Primas_MatPri_Id",
                        column: x => x.MatPri_Id,
                        principalTable: "Materias_Primas",
                        principalColumn: "MatPri_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesAsignaciones_MateriasPrimas_Procesos_Proceso_Id",
                        column: x => x.Proceso_Id,
                        principalTable: "Procesos",
                        principalColumn: "Proceso_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesAsignaciones_MateriasPrimas_Unidades_Medidas_UndMed_Id",
                        column: x => x.UndMed_Id,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetallesAsignaciones_MatPrimasXTintas",
                columns: table => new
                {
                    AsigMPxTinta_Id = table.Column<long>(type: "bigint", nullable: false),
                    MatPri_Id = table.Column<long>(type: "bigint", nullable: false),
                    DetAsigMPxTinta_Cantidad = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    UndMed_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    Proceso_Id = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesAsignaciones_MatPrimasXTintas", x => new { x.AsigMPxTinta_Id, x.MatPri_Id });
                    table.ForeignKey(
                        name: "FK_DetallesAsignaciones_MatPrimasXTintas_Asignaciones_MatPrimasXTintas_AsigMPxTinta_Id",
                        column: x => x.AsigMPxTinta_Id,
                        principalTable: "Asignaciones_MatPrimasXTintas",
                        principalColumn: "AsigMPxTinta_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesAsignaciones_MatPrimasXTintas_Materias_Primas_MatPri_Id",
                        column: x => x.MatPri_Id,
                        principalTable: "Materias_Primas",
                        principalColumn: "MatPri_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesAsignaciones_MatPrimasXTintas_Procesos_Proceso_Id",
                        column: x => x.Proceso_Id,
                        principalTable: "Procesos",
                        principalColumn: "Proceso_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesAsignaciones_MatPrimasXTintas_Unidades_Medidas_UndMed_Id",
                        column: x => x.UndMed_Id,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetallesAsignaciones_BOPP",
                columns: table => new
                {
                    DtAsigBOPP_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsigBOPP_Id = table.Column<long>(type: "bigint", nullable: false),
                    BOPP_Id = table.Column<long>(type: "bigint", nullable: false),
                    DtAsigBOPP_Cantidad = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    UndMed_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    Proceso_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    DtAsigBOPP_OrdenTrabajo = table.Column<long>(type: "bigint", nullable: false),
                    Estado_OrdenTrabajo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesAsignaciones_BOPP", x => x.DtAsigBOPP_Id);
                    table.ForeignKey(
                        name: "FK_DetallesAsignaciones_BOPP_Asignaciones_BOPP_AsigBOPP_Id",
                        column: x => x.AsigBOPP_Id,
                        principalTable: "Asignaciones_BOPP",
                        principalColumn: "AsigBOPP_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesAsignaciones_BOPP_BOPP_BOPP_Id",
                        column: x => x.BOPP_Id,
                        principalTable: "BOPP",
                        principalColumn: "BOPP_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesAsignaciones_BOPP_Estados_Estado_OrdenTrabajo",
                        column: x => x.Estado_OrdenTrabajo,
                        principalTable: "Estados",
                        principalColumn: "Estado_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesAsignaciones_BOPP_Procesos_Proceso_Id",
                        column: x => x.Proceso_Id,
                        principalTable: "Procesos",
                        principalColumn: "Proceso_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesAsignaciones_BOPP_Unidades_Medidas_UndMed_Id",
                        column: x => x.UndMed_Id,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AsignacionesProductos_FacturasVentas",
                columns: table => new
                {
                    AsigProdFV_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacturaVta_Id = table.Column<string>(type: "varchar(100)", nullable: true),
                    NotaCredito_Id = table.Column<string>(type: "varchar(100)", nullable: true),
                    Usua_Id = table.Column<long>(type: "bigint", nullable: false),
                    AsigProdFV_Fecha = table.Column<DateTime>(type: "date", nullable: false),
                    AsigProdFV_Observacion = table.Column<string>(type: "text", nullable: true),
                    Cli_Id = table.Column<long>(type: "bigint", nullable: false),
                    Usua_Conductor = table.Column<long>(type: "bigint", nullable: false),
                    AsigProdFV_PlacaCamion = table.Column<string>(type: "varchar(50)", nullable: false),
                    AsigProdFV_FechaEnvio = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsignacionesProductos_FacturasVentas", x => x.AsigProdFV_Id);
                    table.ForeignKey(
                        name: "FK_AsignacionesProductos_FacturasVentas_Clientes_Cli_Id",
                        column: x => x.Cli_Id,
                        principalTable: "Clientes",
                        principalColumn: "Cli_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AsignacionesProductos_FacturasVentas_Usuarios_Usua_Conductor",
                        column: x => x.Usua_Conductor,
                        principalTable: "Usuarios",
                        principalColumn: "Usua_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AsignacionesProductos_FacturasVentas_Usuarios_Usua_Id",
                        column: x => x.Usua_Id,
                        principalTable: "Usuarios",
                        principalColumn: "Usua_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clientes_Productos",
                columns: table => new
                {
                    Cli_Id = table.Column<long>(type: "bigint", nullable: false),
                    Prod_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes_Productos", x => new { x.Prod_Id, x.Cli_Id });
                    table.ForeignKey(
                        name: "FK_Clientes_Productos_Clientes_Cli_Id",
                        column: x => x.Cli_Id,
                        principalTable: "Clientes",
                        principalColumn: "Cli_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clientes_Productos_Productos_Prod_Id",
                        column: x => x.Prod_Id,
                        principalTable: "Productos",
                        principalColumn: "Prod_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Devoluciones_ProductosFacturados",
                columns: table => new
                {
                    DevProdFact_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacturaVta_Id = table.Column<string>(type: "varchar(100)", nullable: false),
                    Cli_Id = table.Column<long>(type: "bigint", nullable: false),
                    DevProdFact_Fecha = table.Column<DateTime>(type: "date", nullable: false),
                    DevProdFact_Observacion = table.Column<string>(type: "text", nullable: true),
                    TipoDevProdFact_Id = table.Column<int>(type: "int", nullable: false),
                    Usua_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devoluciones_ProductosFacturados", x => x.DevProdFact_Id);
                    table.ForeignKey(
                        name: "FK_Devoluciones_ProductosFacturados_Clientes_Cli_Id",
                        column: x => x.Cli_Id,
                        principalTable: "Clientes",
                        principalColumn: "Cli_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Devoluciones_ProductosFacturados_TiposDevoluciones_ProductosFacturados_TipoDevProdFact_Id",
                        column: x => x.TipoDevProdFact_Id,
                        principalTable: "TiposDevoluciones_ProductosFacturados",
                        principalColumn: "TipoDevProdFact_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Devoluciones_ProductosFacturados_Usuarios_Usua_Id",
                        column: x => x.Usua_Id,
                        principalTable: "Usuarios",
                        principalColumn: "Usua_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sedes_Clientes",
                columns: table => new
                {
                    SedeCli_Id = table.Column<long>(type: "bigint", nullable: false),
                    SedeCli_Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SedeCliente_Ciudad = table.Column<string>(type: "varchar(100)", nullable: false),
                    SedeCliente_Direccion = table.Column<string>(type: "varchar(MAX)", nullable: false),
                    SedeCli_CodPostal = table.Column<long>(type: "bigint", nullable: true),
                    Cli_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sedes_Clientes", x => x.SedeCli_Id);
                    table.ForeignKey(
                        name: "FK_Sedes_Clientes_Clientes_Cli_Id",
                        column: x => x.Cli_Id,
                        principalTable: "Clientes",
                        principalColumn: "Cli_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetallesDevoluciones_MateriasPrimas",
                columns: table => new
                {
                    DevMatPri_Id = table.Column<long>(type: "bigint", nullable: false),
                    MatPri_Id = table.Column<long>(type: "bigint", nullable: false),
                    DtDevMatPri_CantidadDevuelta = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    UndMed_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    Proceso_Id = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesDevoluciones_MateriasPrimas", x => new { x.DevMatPri_Id, x.MatPri_Id });
                    table.ForeignKey(
                        name: "FK_DetallesDevoluciones_MateriasPrimas_Devoluciones_MatPrima_DevMatPri_Id",
                        column: x => x.DevMatPri_Id,
                        principalTable: "Devoluciones_MatPrima",
                        principalColumn: "DevMatPri_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesDevoluciones_MateriasPrimas_Materias_Primas_MatPri_Id",
                        column: x => x.MatPri_Id,
                        principalTable: "Materias_Primas",
                        principalColumn: "MatPri_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesDevoluciones_MateriasPrimas_Procesos_Proceso_Id",
                        column: x => x.Proceso_Id,
                        principalTable: "Procesos",
                        principalColumn: "Proceso_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesDevoluciones_MateriasPrimas_Unidades_Medidas_UndMed_Id",
                        column: x => x.UndMed_Id,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Detalles_EntradaTintas",
                columns: table => new
                {
                    EntTinta_Id = table.Column<int>(type: "int", nullable: false),
                    Tinta_Id = table.Column<long>(type: "bigint", nullable: false),
                    DtEntTinta_Cantidad = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    UndMed_Id = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalles_EntradaTintas", x => new { x.EntTinta_Id, x.Tinta_Id });
                    table.ForeignKey(
                        name: "FK_Detalles_EntradaTintas_Entradas_Tintas_EntTinta_Id",
                        column: x => x.EntTinta_Id,
                        principalTable: "Entradas_Tintas",
                        principalColumn: "EntTinta_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Detalles_EntradaTintas_Tintas_Tinta_Id",
                        column: x => x.Tinta_Id,
                        principalTable: "Tintas",
                        principalColumn: "Tinta_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Detalles_EntradaTintas_Unidades_Medidas_UndMed_Id",
                        column: x => x.UndMed_Id,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetallesEntradasRollos_Productos",
                columns: table => new
                {
                    Rollo_Id = table.Column<long>(type: "bigint", nullable: false),
                    DtEntRolloProd_Codigo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntRolloProd_Id = table.Column<long>(type: "bigint", nullable: false),
                    DtEntRolloProd_Cantidad = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    UndMed_Rollo = table.Column<string>(type: "varchar(10)", nullable: false),
                    Estado_Id = table.Column<int>(type: "int", nullable: false),
                    DtEntRolloProd_OT = table.Column<long>(type: "bigint", nullable: false),
                    Prod_Id = table.Column<int>(type: "int", nullable: false),
                    UndMed_Prod = table.Column<string>(type: "varchar(10)", nullable: false),
                    Prod_CantPaquetesRestantes = table.Column<int>(type: "int", precision: 14, scale: 2, nullable: false),
                    Prod_CantBolsasPaquete = table.Column<int>(type: "int", precision: 14, scale: 2, nullable: false),
                    Prod_CantBolsasBulto = table.Column<int>(type: "int", precision: 14, scale: 2, nullable: false),
                    Prod_CantBolsasRestates = table.Column<int>(type: "int", precision: 14, scale: 2, nullable: false),
                    Prod_CantBolsasFacturadas = table.Column<int>(type: "int", precision: 14, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesEntradasRollos_Productos", x => x.DtEntRolloProd_Codigo);
                    table.ForeignKey(
                        name: "FK_DetallesEntradasRollos_Productos_EntradasRollos_Productos_EntRolloProd_Id",
                        column: x => x.EntRolloProd_Id,
                        principalTable: "EntradasRollos_Productos",
                        principalColumn: "EntRolloProd_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesEntradasRollos_Productos_Estados_Estado_Id",
                        column: x => x.Estado_Id,
                        principalTable: "Estados",
                        principalColumn: "Estado_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesEntradasRollos_Productos_Productos_Prod_Id",
                        column: x => x.Prod_Id,
                        principalTable: "Productos",
                        principalColumn: "Prod_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesEntradasRollos_Productos_Unidades_Medidas_UndMed_Prod",
                        column: x => x.UndMed_Prod,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesEntradasRollos_Productos_Unidades_Medidas_UndMed_Rollo",
                        column: x => x.UndMed_Rollo,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FacturasCompras_MateriaPrimas",
                columns: table => new
                {
                    Facco_Id = table.Column<long>(type: "bigint", nullable: false),
                    MatPri_Id = table.Column<long>(type: "bigint", nullable: false),
                    FaccoMatPri_Cantidad = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    UndMed_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    FaccoMatPri_ValorUnitario = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacturasCompras_MateriaPrimas", x => new { x.Facco_Id, x.MatPri_Id });
                    table.ForeignKey(
                        name: "FK_FacturasCompras_MateriaPrimas_Facturas_Compras_Facco_Id",
                        column: x => x.Facco_Id,
                        principalTable: "Facturas_Compras",
                        principalColumn: "Facco_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FacturasCompras_MateriaPrimas_Materias_Primas_MatPri_Id",
                        column: x => x.MatPri_Id,
                        principalTable: "Materias_Primas",
                        principalColumn: "MatPri_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FacturasCompras_MateriaPrimas_Unidades_Medidas_UndMed_Id",
                        column: x => x.UndMed_Id,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetallesPreEntrega_RollosDespacho",
                columns: table => new
                {
                    DtlPreEntRollo_OT = table.Column<long>(type: "bigint", nullable: false),
                    Prod_Id = table.Column<int>(type: "int", nullable: false),
                    UndMed_Producto = table.Column<string>(type: "varchar(10)", nullable: false),
                    Cli_Id = table.Column<long>(type: "bigint", nullable: false),
                    DtlPreEntRollo_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PreEntRollo_Id = table.Column<long>(type: "bigint", nullable: false),
                    Rollo_Id = table.Column<long>(type: "bigint", nullable: false),
                    DtlPreEntRollo_Cantidad = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    UndMed_Rollo = table.Column<string>(type: "varchar(10)", nullable: false),
                    Proceso_Id = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesPreEntrega_RollosDespacho", x => x.DtlPreEntRollo_Id);
                    table.ForeignKey(
                        name: "FK_DetallesPreEntrega_RollosDespacho_Clientes_Cli_Id",
                        column: x => x.Cli_Id,
                        principalTable: "Clientes",
                        principalColumn: "Cli_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesPreEntrega_RollosDespacho_PreEntrega_RollosDespacho_PreEntRollo_Id",
                        column: x => x.PreEntRollo_Id,
                        principalTable: "PreEntrega_RollosDespacho",
                        principalColumn: "PreEntRollo_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesPreEntrega_RollosDespacho_Procesos_Proceso_Id",
                        column: x => x.Proceso_Id,
                        principalTable: "Procesos",
                        principalColumn: "Proceso_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesPreEntrega_RollosDespacho_Productos_Prod_Id",
                        column: x => x.Prod_Id,
                        principalTable: "Productos",
                        principalColumn: "Prod_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesPreEntrega_RollosDespacho_Unidades_Medidas_UndMed_Producto",
                        column: x => x.UndMed_Producto,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesPreEntrega_RollosDespacho_Unidades_Medidas_UndMed_Rollo",
                        column: x => x.UndMed_Rollo,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetallesRecuperados_MateriasPrimas",
                columns: table => new
                {
                    RecMp_Id = table.Column<long>(type: "bigint", nullable: false),
                    MatPri_Id = table.Column<long>(type: "bigint", nullable: false),
                    RecMatPri_Cantidad = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    UndMed_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    TpRecu_Id = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesRecuperados_MateriasPrimas", x => new { x.RecMp_Id, x.MatPri_Id });
                    table.ForeignKey(
                        name: "FK_DetallesRecuperados_MateriasPrimas_Materias_Primas_MatPri_Id",
                        column: x => x.MatPri_Id,
                        principalTable: "Materias_Primas",
                        principalColumn: "MatPri_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesRecuperados_MateriasPrimas_Recuperados_MatPrima_RecMp_Id",
                        column: x => x.RecMp_Id,
                        principalTable: "Recuperados_MatPrima",
                        principalColumn: "RecMp_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesRecuperados_MateriasPrimas_Tipos_Recuperados_TpRecu_Id",
                        column: x => x.TpRecu_Id,
                        principalTable: "Tipos_Recuperados",
                        principalColumn: "TpRecu_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesRecuperados_MateriasPrimas_Unidades_Medidas_UndMed_Id",
                        column: x => x.UndMed_Id,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Remisiones_FacturasCompras",
                columns: table => new
                {
                    Rem_Id = table.Column<int>(type: "int", nullable: false),
                    Facco_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Remisiones_FacturasCompras", x => new { x.Facco_Id, x.Rem_Id });
                    table.ForeignKey(
                        name: "FK_Remisiones_FacturasCompras_Facturas_Compras_Facco_Id",
                        column: x => x.Facco_Id,
                        principalTable: "Facturas_Compras",
                        principalColumn: "Facco_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Remisiones_FacturasCompras_Remisiones_Rem_Id",
                        column: x => x.Rem_Id,
                        principalTable: "Remisiones",
                        principalColumn: "Rem_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Remisiones_MateriasPrimas",
                columns: table => new
                {
                    Rem_Id = table.Column<int>(type: "int", nullable: false),
                    MatPri_Id = table.Column<long>(type: "bigint", nullable: false),
                    RemiMatPri_Cantidad = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    UndMed_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    RemiMatPri_ValorUnitario = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Remisiones_MateriasPrimas", x => new { x.Rem_Id, x.MatPri_Id });
                    table.ForeignKey(
                        name: "FK_Remisiones_MateriasPrimas_Materias_Primas_MatPri_Id",
                        column: x => x.MatPri_Id,
                        principalTable: "Materias_Primas",
                        principalColumn: "MatPri_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Remisiones_MateriasPrimas_Remisiones_Rem_Id",
                        column: x => x.Rem_Id,
                        principalTable: "Remisiones",
                        principalColumn: "Rem_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Remisiones_MateriasPrimas_Unidades_Medidas_UndMed_Id",
                        column: x => x.UndMed_Id,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetallesAsignacionesProductos_FacturasVentas",
                columns: table => new
                {
                    DtAsigProdFV_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsigProdFV_Id = table.Column<long>(type: "bigint", nullable: false),
                    Prod_Id = table.Column<int>(type: "int", nullable: false),
                    Rollo_Id = table.Column<long>(type: "bigint", nullable: false),
                    DtAsigProdFV_Cantidad = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    UndMed_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    Prod_CantUnidades = table.Column<int>(type: "int", precision: 14, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesAsignacionesProductos_FacturasVentas", x => x.DtAsigProdFV_Id);
                    table.ForeignKey(
                        name: "FK_DetallesAsignacionesProductos_FacturasVentas_AsignacionesProductos_FacturasVentas_AsigProdFV_Id",
                        column: x => x.AsigProdFV_Id,
                        principalTable: "AsignacionesProductos_FacturasVentas",
                        principalColumn: "AsigProdFV_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesAsignacionesProductos_FacturasVentas_Productos_Prod_Id",
                        column: x => x.Prod_Id,
                        principalTable: "Productos",
                        principalColumn: "Prod_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesAsignacionesProductos_FacturasVentas_Unidades_Medidas_UndMed_Id",
                        column: x => x.UndMed_Id,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetallesDevoluciones_ProductosFacturados",
                columns: table => new
                {
                    DtDevProdFact_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DevProdFact_Id = table.Column<long>(type: "bigint", nullable: false),
                    Prod_Id = table.Column<int>(type: "int", nullable: false),
                    Rollo_Id = table.Column<long>(type: "bigint", nullable: false),
                    DtDevProdFact_Cantidad = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    UndMed_Id = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesDevoluciones_ProductosFacturados", x => x.DtDevProdFact_Id);
                    table.ForeignKey(
                        name: "FK_DetallesDevoluciones_ProductosFacturados_Devoluciones_ProductosFacturados_DevProdFact_Id",
                        column: x => x.DevProdFact_Id,
                        principalTable: "Devoluciones_ProductosFacturados",
                        principalColumn: "DevProdFact_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesDevoluciones_ProductosFacturados_Productos_Prod_Id",
                        column: x => x.Prod_Id,
                        principalTable: "Productos",
                        principalColumn: "Prod_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesDevoluciones_ProductosFacturados_Unidades_Medidas_UndMed_Id",
                        column: x => x.UndMed_Id,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos_Externos",
                columns: table => new
                {
                    Usua_Id = table.Column<long>(type: "bigint", nullable: true),
                    PedExt_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PedExt_Codigo = table.Column<long>(type: "bigint", nullable: false),
                    PedExt_FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PedExt_FechaEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Empresa_Id = table.Column<long>(type: "bigint", nullable: false),
                    SedeCli_Id = table.Column<long>(type: "bigint", nullable: true),
                    Estado_Id = table.Column<int>(type: "int", nullable: false),
                    PedExt_Observacion = table.Column<string>(type: "text", nullable: false),
                    PedExt_PrecioTotal = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    PedExt_Archivo = table.Column<byte[]>(type: "binary(4)", nullable: false),
                    PedExt_Descuento = table.Column<int>(type: "int", precision: 18, scale: 2, nullable: true),
                    PedExt_Iva = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    PedExt_PrecioTotalFinal = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos_Externos", x => x.PedExt_Id);
                    table.ForeignKey(
                        name: "FK_Pedidos_Externos_Empresas_Empresa_Id",
                        column: x => x.Empresa_Id,
                        principalTable: "Empresas",
                        principalColumn: "Empresa_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_Externos_Estados_Estado_Id",
                        column: x => x.Estado_Id,
                        principalTable: "Estados",
                        principalColumn: "Estado_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_Externos_Sedes_Clientes_SedeCli_Id",
                        column: x => x.SedeCli_Id,
                        principalTable: "Sedes_Clientes",
                        principalColumn: "SedeCli_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_Externos_Usuarios_Usua_Id",
                        column: x => x.Usua_Id,
                        principalTable: "Usuarios",
                        principalColumn: "Usua_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orden_Trabajo",
                columns: table => new
                {
                    Ot_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SedeCli_Id = table.Column<long>(type: "bigint", nullable: false),
                    Prod_Id = table.Column<int>(type: "int", nullable: false),
                    UndMed_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    Ot_CantidadKilos = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    Ot_CantidadUnidades = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    Ot_MargenAdicional = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    Ot_CantidadKilos_Margen = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    Ot_CantidadUnidades_Margen = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    Ot_FechaCreacion = table.Column<DateTime>(type: "Date", nullable: false),
                    Estado_Id = table.Column<int>(type: "int", nullable: false),
                    Usua_Id = table.Column<long>(type: "bigint", nullable: false),
                    PedExt_Id = table.Column<long>(type: "bigint", nullable: false),
                    Ot_Observacion = table.Column<string>(type: "text", nullable: false),
                    Ot_Cyrel = table.Column<string>(type: "varchar(10)", nullable: false),
                    Ot_Corte = table.Column<string>(type: "varchar(10)", nullable: false),
                    Mezcla_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orden_Trabajo", x => x.Ot_Id);
                    table.ForeignKey(
                        name: "FK_Orden_Trabajo_Estados_Estado_Id",
                        column: x => x.Estado_Id,
                        principalTable: "Estados",
                        principalColumn: "Estado_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orden_Trabajo_Mezclas_Mezcla_Id",
                        column: x => x.Mezcla_Id,
                        principalTable: "Mezclas",
                        principalColumn: "Mezcla_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orden_Trabajo_Pedidos_Externos_PedExt_Id",
                        column: x => x.PedExt_Id,
                        principalTable: "Pedidos_Externos",
                        principalColumn: "PedExt_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orden_Trabajo_Productos_Prod_Id",
                        column: x => x.Prod_Id,
                        principalTable: "Productos",
                        principalColumn: "Prod_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orden_Trabajo_Sedes_Clientes_SedeCli_Id",
                        column: x => x.SedeCli_Id,
                        principalTable: "Sedes_Clientes",
                        principalColumn: "SedeCli_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orden_Trabajo_Unidades_Medidas_UndMed_Id",
                        column: x => x.UndMed_Id,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orden_Trabajo_Usuarios_Usua_Id",
                        column: x => x.Usua_Id,
                        principalTable: "Usuarios",
                        principalColumn: "Usua_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PedidosExternos_Productos",
                columns: table => new
                {
                    Prod_Id = table.Column<int>(type: "int", nullable: false),
                    PedExt_Id = table.Column<long>(type: "bigint", nullable: false),
                    PedExtProd_Cantidad = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    UndMed_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    PedExtProd_PrecioUnitario = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidosExternos_Productos", x => new { x.Prod_Id, x.PedExt_Id });
                    table.ForeignKey(
                        name: "FK_PedidosExternos_Productos_Pedidos_Externos_PedExt_Id",
                        column: x => x.PedExt_Id,
                        principalTable: "Pedidos_Externos",
                        principalColumn: "PedExt_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidosExternos_Productos_Productos_Prod_Id",
                        column: x => x.Prod_Id,
                        principalTable: "Productos",
                        principalColumn: "Prod_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidosExternos_Productos_Unidades_Medidas_UndMed_Id",
                        column: x => x.UndMed_Id,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OT_Extrusion",
                columns: table => new
                {
                    Extrusion_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ot_Id = table.Column<long>(type: "bigint", nullable: false),
                    Material_Id = table.Column<int>(type: "int", nullable: false),
                    Formato_Id = table.Column<long>(type: "bigint", nullable: false),
                    Pigmt_Id = table.Column<int>(type: "int", nullable: false),
                    Extrusion_Calibre = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    Extrusion_Ancho1 = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    Extrusion_Ancho2 = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    Extrusion_Ancho3 = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    UndMed_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    Tratado_Id = table.Column<int>(type: "int", precision: 14, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OT_Extrusion", x => x.Extrusion_Id);
                    table.ForeignKey(
                        name: "FK_OT_Extrusion_Formato_Formato_Id",
                        column: x => x.Formato_Id,
                        principalTable: "Formato",
                        principalColumn: "Formato_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OT_Extrusion_Materiales_MatPrima_Material_Id",
                        column: x => x.Material_Id,
                        principalTable: "Materiales_MatPrima",
                        principalColumn: "Material_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OT_Extrusion_Orden_Trabajo_Ot_Id",
                        column: x => x.Ot_Id,
                        principalTable: "Orden_Trabajo",
                        principalColumn: "Ot_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OT_Extrusion_Pigmentos_Pigmt_Id",
                        column: x => x.Pigmt_Id,
                        principalTable: "Pigmentos",
                        principalColumn: "Pigmt_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OT_Extrusion_Tratado_Tratado_Id",
                        column: x => x.Tratado_Id,
                        principalTable: "Tratado",
                        principalColumn: "Tratado_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OT_Extrusion_Unidades_Medidas_UndMed_Id",
                        column: x => x.UndMed_Id,
                        principalTable: "Unidades_Medidas",
                        principalColumn: "UndMed_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OT_Impresion",
                columns: table => new
                {
                    Impresion_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ot_Id = table.Column<long>(type: "bigint", nullable: false),
                    TpImpresion_Id = table.Column<int>(type: "int", nullable: false),
                    Rodillo_Id = table.Column<int>(type: "int", nullable: false),
                    Pista_Id = table.Column<int>(type: "int", nullable: false),
                    Tinta1_Id = table.Column<long>(type: "bigint", nullable: false),
                    Tinta2_Id = table.Column<long>(type: "bigint", nullable: false),
                    Tinta3_Id = table.Column<long>(type: "bigint", nullable: false),
                    Tinta4_Id = table.Column<long>(type: "bigint", nullable: false),
                    Tinta5_Id = table.Column<long>(type: "bigint", nullable: false),
                    Tinta6_Id = table.Column<long>(type: "bigint", nullable: false),
                    Tinta7_Id = table.Column<long>(type: "bigint", nullable: false),
                    Tinta8_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OT_Impresion", x => x.Impresion_Id);
                    table.ForeignKey(
                        name: "FK_OT_Impresion_Orden_Trabajo_Ot_Id",
                        column: x => x.Ot_Id,
                        principalTable: "Orden_Trabajo",
                        principalColumn: "Ot_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OT_Impresion_Tintas_Tinta1_Id",
                        column: x => x.Tinta1_Id,
                        principalTable: "Tintas",
                        principalColumn: "Tinta_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OT_Impresion_Tintas_Tinta2_Id",
                        column: x => x.Tinta2_Id,
                        principalTable: "Tintas",
                        principalColumn: "Tinta_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OT_Impresion_Tintas_Tinta3_Id",
                        column: x => x.Tinta3_Id,
                        principalTable: "Tintas",
                        principalColumn: "Tinta_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OT_Impresion_Tintas_Tinta4_Id",
                        column: x => x.Tinta4_Id,
                        principalTable: "Tintas",
                        principalColumn: "Tinta_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OT_Impresion_Tintas_Tinta5_Id",
                        column: x => x.Tinta5_Id,
                        principalTable: "Tintas",
                        principalColumn: "Tinta_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OT_Impresion_Tintas_Tinta6_Id",
                        column: x => x.Tinta6_Id,
                        principalTable: "Tintas",
                        principalColumn: "Tinta_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OT_Impresion_Tintas_Tinta7_Id",
                        column: x => x.Tinta7_Id,
                        principalTable: "Tintas",
                        principalColumn: "Tinta_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OT_Impresion_Tintas_Tinta8_Id",
                        column: x => x.Tinta8_Id,
                        principalTable: "Tintas",
                        principalColumn: "Tinta_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OT_Impresion_Tipos_Impresion_TpImpresion_Id",
                        column: x => x.TpImpresion_Id,
                        principalTable: "Tipos_Impresion",
                        principalColumn: "TpImpresion_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OT_Laminado",
                columns: table => new
                {
                    LamCapa_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OT_Id = table.Column<long>(type: "bigint", nullable: false),
                    Capa_Id1 = table.Column<int>(type: "int", nullable: false),
                    Capa_Id2 = table.Column<int>(type: "int", nullable: false),
                    Capa_Id3 = table.Column<int>(type: "int", nullable: false),
                    LamCapa_Calibre1 = table.Column<double>(type: "float(14)", precision: 14, scale: 2, nullable: false),
                    LamCapa_Calibre2 = table.Column<double>(type: "float(14)", precision: 14, scale: 2, nullable: false),
                    LamCapa_Calibre3 = table.Column<double>(type: "float(14)", precision: 14, scale: 2, nullable: false),
                    LamCapa_Cantidad1 = table.Column<double>(type: "float(14)", precision: 14, scale: 2, nullable: false),
                    LamCapa_Cantidad2 = table.Column<double>(type: "float(14)", precision: 14, scale: 2, nullable: false),
                    LamCapa_Cantidad3 = table.Column<double>(type: "float(14)", precision: 14, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OT_Laminado", x => x.LamCapa_Id);
                    table.ForeignKey(
                        name: "FK_OT_Laminado_Laminado_Capa_Capa_Id1",
                        column: x => x.Capa_Id1,
                        principalTable: "Laminado_Capa",
                        principalColumn: "LamCapa_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OT_Laminado_Laminado_Capa_Capa_Id2",
                        column: x => x.Capa_Id2,
                        principalTable: "Laminado_Capa",
                        principalColumn: "LamCapa_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OT_Laminado_Laminado_Capa_Capa_Id3",
                        column: x => x.Capa_Id3,
                        principalTable: "Laminado_Capa",
                        principalColumn: "LamCapa_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OT_Laminado_Orden_Trabajo_OT_Id",
                        column: x => x.OT_Id,
                        principalTable: "Orden_Trabajo",
                        principalColumn: "Ot_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Archivos_Categoria_Id",
                table: "Archivos",
                column: "Categoria_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Archivos_Usua_Id",
                table: "Archivos",
                column: "Usua_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Asignaciones_BOPP_Estado_Id",
                table: "Asignaciones_BOPP",
                column: "Estado_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Asignaciones_BOPP_Usua_Id",
                table: "Asignaciones_BOPP",
                column: "Usua_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Asignaciones_MatPrima_Estado_Id",
                table: "Asignaciones_MatPrima",
                column: "Estado_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Asignaciones_MatPrima_Estado_OrdenTrabajo",
                table: "Asignaciones_MatPrima",
                column: "Estado_OrdenTrabajo");

            migrationBuilder.CreateIndex(
                name: "IX_Asignaciones_MatPrima_Usua_Id",
                table: "Asignaciones_MatPrima",
                column: "Usua_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Asignaciones_MatPrimasXTintas_Estado_Id",
                table: "Asignaciones_MatPrimasXTintas",
                column: "Estado_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Asignaciones_MatPrimasXTintas_Tinta_Id",
                table: "Asignaciones_MatPrimasXTintas",
                column: "Tinta_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Asignaciones_MatPrimasXTintas_UndMed_Id",
                table: "Asignaciones_MatPrimasXTintas",
                column: "UndMed_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Asignaciones_MatPrimasXTintas_Usua_Id",
                table: "Asignaciones_MatPrimasXTintas",
                column: "Usua_Id");

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionesProductos_FacturasVentas_Cli_Id",
                table: "AsignacionesProductos_FacturasVentas",
                column: "Cli_Id");

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionesProductos_FacturasVentas_Usua_Conductor",
                table: "AsignacionesProductos_FacturasVentas",
                column: "Usua_Conductor");

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionesProductos_FacturasVentas_Usua_Id",
                table: "AsignacionesProductos_FacturasVentas",
                column: "Usua_Id");

            migrationBuilder.CreateIndex(
                name: "IX_BOPP_CatMP_Id",
                table: "BOPP",
                column: "CatMP_Id");

            migrationBuilder.CreateIndex(
                name: "IX_BOPP_TpBod_Id",
                table: "BOPP",
                column: "TpBod_Id");

            migrationBuilder.CreateIndex(
                name: "IX_BOPP_UndMed_Id",
                table: "BOPP",
                column: "UndMed_Id");

            migrationBuilder.CreateIndex(
                name: "IX_BOPP_UndMed_Kg",
                table: "BOPP",
                column: "UndMed_Kg");

            migrationBuilder.CreateIndex(
                name: "IX_BOPP_Usua_Id",
                table: "BOPP",
                column: "Usua_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cajas_Compensaciones_TipoIdentificacion_Id",
                table: "Cajas_Compensaciones",
                column: "TipoIdentificacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_Estado_Id",
                table: "Clientes",
                column: "Estado_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_TipoIdentificacion_Id",
                table: "Clientes",
                column: "TipoIdentificacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_TPCli_Id",
                table: "Clientes",
                column: "TPCli_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_usua_Id",
                table: "Clientes",
                column: "usua_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_Productos_Cli_Id",
                table: "Clientes_Productos",
                column: "Cli_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleAsignaciones_Tintas_Proceso_Id",
                table: "DetalleAsignaciones_Tintas",
                column: "Proceso_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleAsignaciones_Tintas_Tinta_Id",
                table: "DetalleAsignaciones_Tintas",
                column: "Tinta_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleAsignaciones_Tintas_UndMed_Id",
                table: "DetalleAsignaciones_Tintas",
                column: "UndMed_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_EntradaTintas_Tinta_Id",
                table: "Detalles_EntradaTintas",
                column: "Tinta_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_EntradaTintas_UndMed_Id",
                table: "Detalles_EntradaTintas",
                column: "UndMed_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesAsignaciones_BOPP_AsigBOPP_Id",
                table: "DetallesAsignaciones_BOPP",
                column: "AsigBOPP_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesAsignaciones_BOPP_BOPP_Id",
                table: "DetallesAsignaciones_BOPP",
                column: "BOPP_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesAsignaciones_BOPP_Estado_OrdenTrabajo",
                table: "DetallesAsignaciones_BOPP",
                column: "Estado_OrdenTrabajo");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesAsignaciones_BOPP_Proceso_Id",
                table: "DetallesAsignaciones_BOPP",
                column: "Proceso_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesAsignaciones_BOPP_UndMed_Id",
                table: "DetallesAsignaciones_BOPP",
                column: "UndMed_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesAsignaciones_MateriasPrimas_MatPri_Id",
                table: "DetallesAsignaciones_MateriasPrimas",
                column: "MatPri_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesAsignaciones_MateriasPrimas_Proceso_Id",
                table: "DetallesAsignaciones_MateriasPrimas",
                column: "Proceso_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesAsignaciones_MateriasPrimas_UndMed_Id",
                table: "DetallesAsignaciones_MateriasPrimas",
                column: "UndMed_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesAsignaciones_MatPrimasXTintas_MatPri_Id",
                table: "DetallesAsignaciones_MatPrimasXTintas",
                column: "MatPri_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesAsignaciones_MatPrimasXTintas_Proceso_Id",
                table: "DetallesAsignaciones_MatPrimasXTintas",
                column: "Proceso_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesAsignaciones_MatPrimasXTintas_UndMed_Id",
                table: "DetallesAsignaciones_MatPrimasXTintas",
                column: "UndMed_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesAsignacionesProductos_FacturasVentas_AsigProdFV_Id",
                table: "DetallesAsignacionesProductos_FacturasVentas",
                column: "AsigProdFV_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesAsignacionesProductos_FacturasVentas_Prod_Id",
                table: "DetallesAsignacionesProductos_FacturasVentas",
                column: "Prod_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesAsignacionesProductos_FacturasVentas_UndMed_Id",
                table: "DetallesAsignacionesProductos_FacturasVentas",
                column: "UndMed_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesDevoluciones_MateriasPrimas_MatPri_Id",
                table: "DetallesDevoluciones_MateriasPrimas",
                column: "MatPri_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesDevoluciones_MateriasPrimas_Proceso_Id",
                table: "DetallesDevoluciones_MateriasPrimas",
                column: "Proceso_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesDevoluciones_MateriasPrimas_UndMed_Id",
                table: "DetallesDevoluciones_MateriasPrimas",
                column: "UndMed_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesDevoluciones_ProductosFacturados_DevProdFact_Id",
                table: "DetallesDevoluciones_ProductosFacturados",
                column: "DevProdFact_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesDevoluciones_ProductosFacturados_Prod_Id",
                table: "DetallesDevoluciones_ProductosFacturados",
                column: "Prod_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesDevoluciones_ProductosFacturados_UndMed_Id",
                table: "DetallesDevoluciones_ProductosFacturados",
                column: "UndMed_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesEntradasRollos_Productos_EntRolloProd_Id",
                table: "DetallesEntradasRollos_Productos",
                column: "EntRolloProd_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesEntradasRollos_Productos_Estado_Id",
                table: "DetallesEntradasRollos_Productos",
                column: "Estado_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesEntradasRollos_Productos_Prod_Id",
                table: "DetallesEntradasRollos_Productos",
                column: "Prod_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesEntradasRollos_Productos_UndMed_Prod",
                table: "DetallesEntradasRollos_Productos",
                column: "UndMed_Prod");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesEntradasRollos_Productos_UndMed_Rollo",
                table: "DetallesEntradasRollos_Productos",
                column: "UndMed_Rollo");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesPreEntrega_RollosDespacho_Cli_Id",
                table: "DetallesPreEntrega_RollosDespacho",
                column: "Cli_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesPreEntrega_RollosDespacho_PreEntRollo_Id",
                table: "DetallesPreEntrega_RollosDespacho",
                column: "PreEntRollo_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesPreEntrega_RollosDespacho_Proceso_Id",
                table: "DetallesPreEntrega_RollosDespacho",
                column: "Proceso_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesPreEntrega_RollosDespacho_Prod_Id",
                table: "DetallesPreEntrega_RollosDespacho",
                column: "Prod_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesPreEntrega_RollosDespacho_UndMed_Producto",
                table: "DetallesPreEntrega_RollosDespacho",
                column: "UndMed_Producto");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesPreEntrega_RollosDespacho_UndMed_Rollo",
                table: "DetallesPreEntrega_RollosDespacho",
                column: "UndMed_Rollo");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesRecuperados_MateriasPrimas_MatPri_Id",
                table: "DetallesRecuperados_MateriasPrimas",
                column: "MatPri_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesRecuperados_MateriasPrimas_TpRecu_Id",
                table: "DetallesRecuperados_MateriasPrimas",
                column: "TpRecu_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesRecuperados_MateriasPrimas_UndMed_Id",
                table: "DetallesRecuperados_MateriasPrimas",
                column: "UndMed_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Devoluciones_MatPrima_Usua_Id",
                table: "Devoluciones_MatPrima",
                column: "Usua_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Devoluciones_ProductosFacturados_Cli_Id",
                table: "Devoluciones_ProductosFacturados",
                column: "Cli_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Devoluciones_ProductosFacturados_TipoDevProdFact_Id",
                table: "Devoluciones_ProductosFacturados",
                column: "TipoDevProdFact_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Devoluciones_ProductosFacturados_Usua_Id",
                table: "Devoluciones_ProductosFacturados",
                column: "Usua_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_TipoIdentificacion_Id",
                table: "Empresas",
                column: "TipoIdentificacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Entradas_Tintas_Usua_Id",
                table: "Entradas_Tintas",
                column: "Usua_Id");

            migrationBuilder.CreateIndex(
                name: "IX_EntradasRollos_Productos_Usua_Id",
                table: "EntradasRollos_Productos",
                column: "Usua_Id");

            migrationBuilder.CreateIndex(
                name: "IX_EPS_TipoIdentificacion_Id",
                table: "EPS",
                column: "TipoIdentificacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Estados_TpEstado_Id",
                table: "Estados",
                column: "TpEstado_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Estados_ProcesosOT_Estado_Id",
                table: "Estados_ProcesosOT",
                column: "Estado_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Estados_ProcesosOT_Falla_Id",
                table: "Estados_ProcesosOT",
                column: "Falla_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Estados_ProcesosOT_UndMed_Id",
                table: "Estados_ProcesosOT",
                column: "UndMed_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Existencias_Productos_Prod_Id",
                table: "Existencias_Productos",
                column: "Prod_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Existencias_Productos_TpBod_Id",
                table: "Existencias_Productos",
                column: "TpBod_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Existencias_Productos_TpMoneda_Id",
                table: "Existencias_Productos",
                column: "TpMoneda_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Existencias_Productos_UndMed_Id",
                table: "Existencias_Productos",
                column: "UndMed_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_Compras_Estado_Id",
                table: "Facturas_Compras",
                column: "Estado_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_Compras_Prov_Id",
                table: "Facturas_Compras",
                column: "Prov_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_Compras_TpDoc_Id",
                table: "Facturas_Compras",
                column: "TpDoc_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_Compras_Usua_Id",
                table: "Facturas_Compras",
                column: "Usua_Id");

            migrationBuilder.CreateIndex(
                name: "IX_FacturasCompras_MateriaPrimas_MatPri_Id",
                table: "FacturasCompras_MateriaPrimas",
                column: "MatPri_Id");

            migrationBuilder.CreateIndex(
                name: "IX_FacturasCompras_MateriaPrimas_UndMed_Id",
                table: "FacturasCompras_MateriaPrimas",
                column: "UndMed_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Fallas_Tecnicas_TipoFalla_Id",
                table: "Fallas_Tecnicas",
                column: "TipoFalla_Id");

            migrationBuilder.CreateIndex(
                name: "IX_FondosPensiones_TipoIdentificacion_Id",
                table: "FondosPensiones",
                column: "TipoIdentificacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Insumos_CatInsu_Id",
                table: "Insumos",
                column: "CatInsu_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Insumos_UndMed_Id",
                table: "Insumos",
                column: "UndMed_Id");

            migrationBuilder.CreateIndex(
                name: "IX_InventarioInicialXDias_MatPrima_UndMed_Id",
                table: "InventarioInicialXDias_MatPrima",
                column: "UndMed_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Materias_Primas_CatMP_Id",
                table: "Materias_Primas",
                column: "CatMP_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Materias_Primas_TpBod_Id",
                table: "Materias_Primas",
                column: "TpBod_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Materias_Primas_UndMed_Id",
                table: "Materias_Primas",
                column: "UndMed_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Mezclas_Material_Id",
                table: "Mezclas",
                column: "Material_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Mezclas_MezMaterial_Id1xCapa1",
                table: "Mezclas",
                column: "MezMaterial_Id1xCapa1");

            migrationBuilder.CreateIndex(
                name: "IX_Mezclas_MezMaterial_Id1xCapa2",
                table: "Mezclas",
                column: "MezMaterial_Id1xCapa2");

            migrationBuilder.CreateIndex(
                name: "IX_Mezclas_MezMaterial_Id1xCapa3",
                table: "Mezclas",
                column: "MezMaterial_Id1xCapa3");

            migrationBuilder.CreateIndex(
                name: "IX_Mezclas_MezMaterial_Id2xCapa1",
                table: "Mezclas",
                column: "MezMaterial_Id2xCapa1");

            migrationBuilder.CreateIndex(
                name: "IX_Mezclas_MezMaterial_Id2xCapa2",
                table: "Mezclas",
                column: "MezMaterial_Id2xCapa2");

            migrationBuilder.CreateIndex(
                name: "IX_Mezclas_MezMaterial_Id2xCapa3",
                table: "Mezclas",
                column: "MezMaterial_Id2xCapa3");

            migrationBuilder.CreateIndex(
                name: "IX_Mezclas_MezMaterial_Id3xCapa1",
                table: "Mezclas",
                column: "MezMaterial_Id3xCapa1");

            migrationBuilder.CreateIndex(
                name: "IX_Mezclas_MezMaterial_Id3xCapa2",
                table: "Mezclas",
                column: "MezMaterial_Id3xCapa2");

            migrationBuilder.CreateIndex(
                name: "IX_Mezclas_MezMaterial_Id3xCapa3",
                table: "Mezclas",
                column: "MezMaterial_Id3xCapa3");

            migrationBuilder.CreateIndex(
                name: "IX_Mezclas_MezMaterial_Id4xCapa1",
                table: "Mezclas",
                column: "MezMaterial_Id4xCapa1");

            migrationBuilder.CreateIndex(
                name: "IX_Mezclas_MezMaterial_Id4xCapa2",
                table: "Mezclas",
                column: "MezMaterial_Id4xCapa2");

            migrationBuilder.CreateIndex(
                name: "IX_Mezclas_MezMaterial_Id4xCapa3",
                table: "Mezclas",
                column: "MezMaterial_Id4xCapa3");

            migrationBuilder.CreateIndex(
                name: "IX_Mezclas_MezPigmto_Id1xCapa1",
                table: "Mezclas",
                column: "MezPigmto_Id1xCapa1");

            migrationBuilder.CreateIndex(
                name: "IX_Mezclas_MezPigmto_Id1xCapa2",
                table: "Mezclas",
                column: "MezPigmto_Id1xCapa2");

            migrationBuilder.CreateIndex(
                name: "IX_Mezclas_MezPigmto_Id1xCapa3",
                table: "Mezclas",
                column: "MezPigmto_Id1xCapa3");

            migrationBuilder.CreateIndex(
                name: "IX_Mezclas_MezPigmto_Id2xCapa1",
                table: "Mezclas",
                column: "MezPigmto_Id2xCapa1");

            migrationBuilder.CreateIndex(
                name: "IX_Mezclas_MezPigmto_Id2xCapa2",
                table: "Mezclas",
                column: "MezPigmto_Id2xCapa2");

            migrationBuilder.CreateIndex(
                name: "IX_Mezclas_MezPigmto_Id2xCapa3",
                table: "Mezclas",
                column: "MezPigmto_Id2xCapa3");

            migrationBuilder.CreateIndex(
                name: "IX_Mezclas_Usua_Id",
                table: "Mezclas",
                column: "Usua_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orden_Trabajo_Estado_Id",
                table: "Orden_Trabajo",
                column: "Estado_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orden_Trabajo_Mezcla_Id",
                table: "Orden_Trabajo",
                column: "Mezcla_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orden_Trabajo_PedExt_Id",
                table: "Orden_Trabajo",
                column: "PedExt_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orden_Trabajo_Prod_Id",
                table: "Orden_Trabajo",
                column: "Prod_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orden_Trabajo_SedeCli_Id",
                table: "Orden_Trabajo",
                column: "SedeCli_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orden_Trabajo_UndMed_Id",
                table: "Orden_Trabajo",
                column: "UndMed_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orden_Trabajo_Usua_Id",
                table: "Orden_Trabajo",
                column: "Usua_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OT_Extrusion_Formato_Id",
                table: "OT_Extrusion",
                column: "Formato_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OT_Extrusion_Material_Id",
                table: "OT_Extrusion",
                column: "Material_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OT_Extrusion_Ot_Id",
                table: "OT_Extrusion",
                column: "Ot_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OT_Extrusion_Pigmt_Id",
                table: "OT_Extrusion",
                column: "Pigmt_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OT_Extrusion_Tratado_Id",
                table: "OT_Extrusion",
                column: "Tratado_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OT_Extrusion_UndMed_Id",
                table: "OT_Extrusion",
                column: "UndMed_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OT_Impresion_Ot_Id",
                table: "OT_Impresion",
                column: "Ot_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OT_Impresion_Tinta1_Id",
                table: "OT_Impresion",
                column: "Tinta1_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OT_Impresion_Tinta2_Id",
                table: "OT_Impresion",
                column: "Tinta2_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OT_Impresion_Tinta3_Id",
                table: "OT_Impresion",
                column: "Tinta3_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OT_Impresion_Tinta4_Id",
                table: "OT_Impresion",
                column: "Tinta4_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OT_Impresion_Tinta5_Id",
                table: "OT_Impresion",
                column: "Tinta5_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OT_Impresion_Tinta6_Id",
                table: "OT_Impresion",
                column: "Tinta6_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OT_Impresion_Tinta7_Id",
                table: "OT_Impresion",
                column: "Tinta7_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OT_Impresion_Tinta8_Id",
                table: "OT_Impresion",
                column: "Tinta8_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OT_Impresion_TpImpresion_Id",
                table: "OT_Impresion",
                column: "TpImpresion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OT_Laminado_Capa_Id1",
                table: "OT_Laminado",
                column: "Capa_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_OT_Laminado_Capa_Id2",
                table: "OT_Laminado",
                column: "Capa_Id2");

            migrationBuilder.CreateIndex(
                name: "IX_OT_Laminado_Capa_Id3",
                table: "OT_Laminado",
                column: "Capa_Id3");

            migrationBuilder.CreateIndex(
                name: "IX_OT_Laminado_OT_Id",
                table: "OT_Laminado",
                column: "OT_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_Externos_Empresa_Id",
                table: "Pedidos_Externos",
                column: "Empresa_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_Externos_Estado_Id",
                table: "Pedidos_Externos",
                column: "Estado_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_Externos_SedeCli_Id",
                table: "Pedidos_Externos",
                column: "SedeCli_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_Externos_Usua_Id",
                table: "Pedidos_Externos",
                column: "Usua_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosExternos_Productos_PedExt_Id",
                table: "PedidosExternos_Productos",
                column: "PedExt_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosExternos_Productos_UndMed_Id",
                table: "PedidosExternos_Productos",
                column: "UndMed_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PreEntrega_RollosDespacho_Usua_Id",
                table: "PreEntrega_RollosDespacho",
                column: "Usua_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_Estado_Id",
                table: "Productos",
                column: "Estado_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_Material_Id",
                table: "Productos",
                column: "Material_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_Pigmt_Id",
                table: "Productos",
                column: "Pigmt_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_TpProd_Id",
                table: "Productos",
                column: "TpProd_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_TpSellado_Id",
                table: "Productos",
                column: "TpSellado_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_UndMedACF",
                table: "Productos",
                column: "UndMedACF");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_UndMedPeso",
                table: "Productos",
                column: "UndMedPeso");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_TipoIdentificacion_Id",
                table: "Proveedores",
                column: "TipoIdentificacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_TpProv_Id",
                table: "Proveedores",
                column: "TpProv_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_MateriasPrimas_MatPri_Id",
                table: "Proveedores_MateriasPrimas",
                column: "MatPri_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Recuperados_MatPrima_Proc_Id",
                table: "Recuperados_MatPrima",
                column: "Proc_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Recuperados_MatPrima_Usua_Id",
                table: "Recuperados_MatPrima",
                column: "Usua_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Remisiones_Estado_Id",
                table: "Remisiones",
                column: "Estado_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Remisiones_Prov_Id",
                table: "Remisiones",
                column: "Prov_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Remisiones_TpDoc_Id",
                table: "Remisiones",
                column: "TpDoc_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Remisiones_Usua_Id",
                table: "Remisiones",
                column: "Usua_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Remisiones_FacturasCompras_Rem_Id",
                table: "Remisiones_FacturasCompras",
                column: "Rem_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Remisiones_MateriasPrimas_MatPri_Id",
                table: "Remisiones_MateriasPrimas",
                column: "MatPri_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Remisiones_MateriasPrimas_UndMed_Id",
                table: "Remisiones_MateriasPrimas",
                column: "UndMed_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Sedes_Clientes_Cli_Id",
                table: "Sedes_Clientes",
                column: "Cli_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tintas_CatMP_Id",
                table: "Tintas",
                column: "CatMP_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tintas_TpBod_Id",
                table: "Tintas",
                column: "TpBod_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tintas_UndMed_Id",
                table: "Tintas",
                column: "UndMed_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tintas_MateriasPrimas_MatPri_Id",
                table: "Tintas_MateriasPrimas",
                column: "MatPri_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tipos_Bodegas_Area_Id",
                table: "Tipos_Bodegas",
                column: "Area_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Area_Id",
                table: "Usuarios",
                column: "Area_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_cajComp_Id",
                table: "Usuarios",
                column: "cajComp_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Empresa_Id",
                table: "Usuarios",
                column: "Empresa_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_eps_Id",
                table: "Usuarios",
                column: "eps_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Estado_Id",
                table: "Usuarios",
                column: "Estado_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_fPen_Id",
                table: "Usuarios",
                column: "fPen_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_RolUsu_Id",
                table: "Usuarios",
                column: "RolUsu_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_TipoIdentificacion_Id",
                table: "Usuarios",
                column: "TipoIdentificacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_tpUsu_Id",
                table: "Usuarios",
                column: "tpUsu_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Archivos");

            migrationBuilder.DropTable(
                name: "Clientes_Productos");

            migrationBuilder.DropTable(
                name: "DetalleAsignaciones_Tintas");

            migrationBuilder.DropTable(
                name: "Detalles_EntradaTintas");

            migrationBuilder.DropTable(
                name: "DetallesAsignaciones_BOPP");

            migrationBuilder.DropTable(
                name: "DetallesAsignaciones_MateriasPrimas");

            migrationBuilder.DropTable(
                name: "DetallesAsignaciones_MatPrimasXTintas");

            migrationBuilder.DropTable(
                name: "DetallesAsignacionesProductos_FacturasVentas");

            migrationBuilder.DropTable(
                name: "DetallesDevoluciones_MateriasPrimas");

            migrationBuilder.DropTable(
                name: "DetallesDevoluciones_ProductosFacturados");

            migrationBuilder.DropTable(
                name: "DetallesEntradasRollos_Productos");

            migrationBuilder.DropTable(
                name: "DetallesPreEntrega_RollosDespacho");

            migrationBuilder.DropTable(
                name: "DetallesRecuperados_MateriasPrimas");

            migrationBuilder.DropTable(
                name: "Estados_ProcesosOT");

            migrationBuilder.DropTable(
                name: "Existencias_Productos");

            migrationBuilder.DropTable(
                name: "FacturasCompras_MateriaPrimas");

            migrationBuilder.DropTable(
                name: "Insumos");

            migrationBuilder.DropTable(
                name: "InventarioInicialXDias_MatPrima");

            migrationBuilder.DropTable(
                name: "OT_Extrusion");

            migrationBuilder.DropTable(
                name: "OT_Impresion");

            migrationBuilder.DropTable(
                name: "OT_Laminado");

            migrationBuilder.DropTable(
                name: "PedidosExternos_Productos");

            migrationBuilder.DropTable(
                name: "Pistas");

            migrationBuilder.DropTable(
                name: "Proveedores_MateriasPrimas");

            migrationBuilder.DropTable(
                name: "Remisiones_FacturasCompras");

            migrationBuilder.DropTable(
                name: "Remisiones_MateriasPrimas");

            migrationBuilder.DropTable(
                name: "Rodillos");

            migrationBuilder.DropTable(
                name: "Tintas_MateriasPrimas");

            migrationBuilder.DropTable(
                name: "Categorias_Archivos");

            migrationBuilder.DropTable(
                name: "Entradas_Tintas");

            migrationBuilder.DropTable(
                name: "Asignaciones_BOPP");

            migrationBuilder.DropTable(
                name: "BOPP");

            migrationBuilder.DropTable(
                name: "Asignaciones_MatPrima");

            migrationBuilder.DropTable(
                name: "Asignaciones_MatPrimasXTintas");

            migrationBuilder.DropTable(
                name: "AsignacionesProductos_FacturasVentas");

            migrationBuilder.DropTable(
                name: "Devoluciones_MatPrima");

            migrationBuilder.DropTable(
                name: "Devoluciones_ProductosFacturados");

            migrationBuilder.DropTable(
                name: "EntradasRollos_Productos");

            migrationBuilder.DropTable(
                name: "PreEntrega_RollosDespacho");

            migrationBuilder.DropTable(
                name: "Recuperados_MatPrima");

            migrationBuilder.DropTable(
                name: "Tipos_Recuperados");

            migrationBuilder.DropTable(
                name: "Fallas_Tecnicas");

            migrationBuilder.DropTable(
                name: "Tipos_Monedas");

            migrationBuilder.DropTable(
                name: "Categorias_Insumos");

            migrationBuilder.DropTable(
                name: "Formato");

            migrationBuilder.DropTable(
                name: "Tratado");

            migrationBuilder.DropTable(
                name: "Tipos_Impresion");

            migrationBuilder.DropTable(
                name: "Laminado_Capa");

            migrationBuilder.DropTable(
                name: "Orden_Trabajo");

            migrationBuilder.DropTable(
                name: "Facturas_Compras");

            migrationBuilder.DropTable(
                name: "Remisiones");

            migrationBuilder.DropTable(
                name: "Materias_Primas");

            migrationBuilder.DropTable(
                name: "Tintas");

            migrationBuilder.DropTable(
                name: "TiposDevoluciones_ProductosFacturados");

            migrationBuilder.DropTable(
                name: "Procesos");

            migrationBuilder.DropTable(
                name: "Tipos_FallasTecnicas");

            migrationBuilder.DropTable(
                name: "Mezclas");

            migrationBuilder.DropTable(
                name: "Pedidos_Externos");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Tipos_Documentos");

            migrationBuilder.DropTable(
                name: "Categorias_MatPrima");

            migrationBuilder.DropTable(
                name: "Tipos_Bodegas");

            migrationBuilder.DropTable(
                name: "Mezclas_Materiales");

            migrationBuilder.DropTable(
                name: "Mezclas_Pigmentos");

            migrationBuilder.DropTable(
                name: "Sedes_Clientes");

            migrationBuilder.DropTable(
                name: "Materiales_MatPrima");

            migrationBuilder.DropTable(
                name: "Pigmentos");

            migrationBuilder.DropTable(
                name: "Tipos_Productos");

            migrationBuilder.DropTable(
                name: "Tipos_Sellados");

            migrationBuilder.DropTable(
                name: "Unidades_Medidas");

            migrationBuilder.DropTable(
                name: "Tipos_Proveedores");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Tipos_Clientes");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Cajas_Compensaciones");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "EPS");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "FondosPensiones");

            migrationBuilder.DropTable(
                name: "Roles_Usuarios");

            migrationBuilder.DropTable(
                name: "Tipos_Usuarios");

            migrationBuilder.DropTable(
                name: "Tipos_Estados");

            migrationBuilder.DropTable(
                name: "TipoIdentificaciones");
        }
    }
}
