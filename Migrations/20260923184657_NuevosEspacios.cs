using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SoporteColegio.Migrations
{
    /// <inheritdoc />
    public partial class NuevosEspacios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nombre",
                value: "Sala 1");

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nombre",
                value: "Sala 2");

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Nombre",
                value: "Sala 3");

            migrationBuilder.InsertData(
                table: "Salas",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 4, "Sala 4" },
                    { 5, "Sala 5" },
                    { 6, "Sala 6" },
                    { 7, "Sala 7" },
                    { 8, "Sala 8" },
                    { 9, "Sala 9" },
                    { 10, "Sala 10" },
                    { 11, "Sala 11" },
                    { 12, "Sala 12" },
                    { 13, "Sala 13" },
                    { 14, "Sala 14" },
                    { 15, "Sala 15" },
                    { 16, "Sala 16" },
                    { 17, "Sala 17" },
                    { 18, "Sala 18" },
                    { 19, "Sala 19" },
                    { 20, "Sala 20" },
                    { 21, "Sala 21" },
                    { 22, "Sala 22" },
                    { 23, "Sala 23" },
                    { 24, "Sala 24" },
                    { 25, "Sala 25" },
                    { 26, "Sala 26" },
                    { 27, "Sala 27" },
                    { 28, "Sala 28" },
                    { 29, "Sala 29" },
                    { 30, "Sala 30" },
                    { 31, "Sala 31" },
                    { 32, "Sala 32" },
                    { 33, "Sala de Computacion" },
                    { 34, "Inspectoría" },
                    { 35, "Oficina de UTP" },
                    { 36, "Oficina PIE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nombre",
                value: "Laboratorio 1");

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nombre",
                value: "Sala 4B");

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Nombre",
                value: "Biblioteca");
        }
    }
}
