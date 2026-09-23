using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SoporteColegio.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FallasComunes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Equipo = table.Column<string>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FallasComunes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Salas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SalaId = table.Column<int>(type: "INTEGER", nullable: false),
                    FallaComunId = table.Column<int>(type: "INTEGER", nullable: false),
                    DetalleAdicional = table.Column<string>(type: "TEXT", nullable: true),
                    FechaReporte = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Estado = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_FallasComunes_FallaComunId",
                        column: x => x.FallaComunId,
                        principalTable: "FallasComunes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Salas_SalaId",
                        column: x => x.SalaId,
                        principalTable: "Salas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FallasComunes",
                columns: new[] { "Id", "Descripcion", "Equipo" },
                values: new object[,]
                {
                    { 1, "No da imagen / Pantalla azul", "Proyector" },
                    { 2, "No enciende", "Proyector" },
                    { 3, "No enciende / No da video", "PC" },
                    { 4, "No tiene internet", "PC" },
                    { 5, "No responde el cursor o teclas", "Mouse/Teclado" },
                    { 6, "No se escucha el audio", "Parlantes" }
                });

            migrationBuilder.InsertData(
                table: "Salas",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Laboratorio 1" },
                    { 2, "Sala 4B" },
                    { 3, "Biblioteca" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_FallaComunId",
                table: "Tickets",
                column: "FallaComunId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_SalaId",
                table: "Tickets",
                column: "SalaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "FallasComunes");

            migrationBuilder.DropTable(
                name: "Salas");
        }
    }
}
