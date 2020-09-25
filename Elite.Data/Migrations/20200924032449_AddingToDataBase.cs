using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Elite.Data.Migrations
{
    public partial class AddingToDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Cedula = table.Column<string>(type: "nvarchar(11)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Contacto = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Cedula = table.Column<string>(type: "nvarchar(11)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Contacto = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoVehiculos",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoVehiculos", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Masters",
                columns: table => new
                {
                    Codigo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fecha = table.Column<DateTime>(type: "date", nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    NombreCliente = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    EmpleadoId = table.Column<int>(nullable: false),
                    NombreEmpleado = table.Column<string>(type: "nvarchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Masters", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Masters_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Masters_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Modelos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: true),
                    MarcaId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modelos_Marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Placa = table.Column<string>(type: "nvarchar(7)", nullable: true),
                    Marca = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TVDescripcion = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Lavado = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    SubTotal = table.Column<double>(type: "float", nullable: false),
                    ITBIS = table.Column<double>(type: "float", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Details_Masters_MasterId",
                        column: x => x.MasterId,
                        principalTable: "Masters",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lavados",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    DetailCodigo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lavados", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Lavados_Details_DetailCodigo",
                        column: x => x.DetailCodigo,
                        principalTable: "Details",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    Placa = table.Column<string>(type: "nvarchar(7)", nullable: false),
                    MarcaId = table.Column<int>(nullable: false),
                    DescripcionMarca = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    DescripcionModelo = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TipoVehiculoId = table.Column<int>(nullable: false),
                    DescripcionVehiculo = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    DetailCodigo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.Placa);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Details_DetailCodigo",
                        column: x => x.DetailCodigo,
                        principalTable: "Details",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehiculos_TipoVehiculos_TipoVehiculoId",
                        column: x => x.TipoVehiculoId,
                        principalTable: "TipoVehiculos",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Details_MasterId",
                table: "Details",
                column: "MasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Lavados_DetailCodigo",
                table: "Lavados",
                column: "DetailCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_Masters_ClienteId",
                table: "Masters",
                column: "ClienteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Masters_EmpleadoId",
                table: "Masters",
                column: "EmpleadoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Modelos_MarcaId",
                table: "Modelos",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_DetailCodigo",
                table: "Vehiculos",
                column: "DetailCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_MarcaId",
                table: "Vehiculos",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_TipoVehiculoId",
                table: "Vehiculos",
                column: "TipoVehiculoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lavados");

            migrationBuilder.DropTable(
                name: "Modelos");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "TipoVehiculos");

            migrationBuilder.DropTable(
                name: "Masters");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Empleados");
        }
    }
}
