using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StokTakipSistemi.Migrations
{
    /// <inheritdoc />
    public partial class kdv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "kdv",
                table: "Urunler",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Depolar",
                keyColumn: "id",
                keyValue: 1,
                column: "olusturulma_zamani",
                value: new DateTime(2026, 7, 28, 10, 3, 9, 264, DateTimeKind.Local).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "id",
                keyValue: 1,
                column: "olusturulma_zamani",
                value: new DateTime(2026, 7, 28, 10, 3, 9, 264, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "id",
                keyValue: 1,
                column: "olusturulma_zamani",
                value: new DateTime(2026, 7, 28, 10, 3, 9, 264, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "id",
                keyValue: 2,
                column: "olusturulma_zamani",
                value: new DateTime(2026, 7, 28, 10, 3, 9, 264, DateTimeKind.Local).AddTicks(1844));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "kdv",
                table: "Urunler");

            migrationBuilder.UpdateData(
                table: "Depolar",
                keyColumn: "id",
                keyValue: 1,
                column: "olusturulma_zamani",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "id",
                keyValue: 1,
                column: "olusturulma_zamani",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "id",
                keyValue: 1,
                column: "olusturulma_zamani",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "id",
                keyValue: 2,
                column: "olusturulma_zamani",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
