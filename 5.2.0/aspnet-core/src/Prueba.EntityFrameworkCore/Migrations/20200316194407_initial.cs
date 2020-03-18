using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Prueba.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Celda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    NumeroCelda = table.Column<string>(nullable: false),
                    Estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Celda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Indentificacion = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoVehiculo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoVehiculo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Placa = table.Column<string>(nullable: false),
                    EmpleadoId = table.Column<int>(nullable: false),
                    TipoVehiculoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Empleado_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehiculo_TipoVehiculo_TipoVehiculoId",
                        column: x => x.TipoVehiculoId,
                        principalTable: "TipoVehiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ingreso",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    VehiculoId = table.Column<int>(nullable: false),
                    HoraIngreso = table.Column<DateTime>(nullable: false),
                    HoraSalida = table.Column<DateTime>(nullable: false),
                    CeldaId = table.Column<int>(nullable: false),
                    EmpleadoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingreso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingreso_Celda_CeldaId",
                        column: x => x.CeldaId,
                        principalTable: "Celda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ingreso_Empleado_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ingreso_Vehiculo_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "Vehiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingreso_CeldaId",
                table: "Ingreso",
                column: "CeldaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingreso_EmpleadoId",
                table: "Ingreso",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingreso_VehiculoId",
                table: "Ingreso",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_EmpleadoId",
                table: "Vehiculo",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_TipoVehiculoId",
                table: "Vehiculo",
                column: "TipoVehiculoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingreso");

            migrationBuilder.DropTable(
                name: "Celda");

            migrationBuilder.DropTable(
                name: "Vehiculo");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "TipoVehiculo");
        }
    }
}
