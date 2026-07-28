using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StokTakipSistemi.Migrations
{
    /// <inheritdoc />
    public partial class Urunler : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "urun_kodu",
                table: "Urunler",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "birim",
                table: "Urunler",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Depolar",
                keyColumn: "id",
                keyValue: 1,
                column: "olusturulma_zamani",
                value: new DateTime(2026, 7, 28, 12, 12, 21, 666, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "id",
                keyValue: 1,
                column: "olusturulma_zamani",
                value: new DateTime(2026, 7, 28, 12, 12, 21, 666, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "id",
                keyValue: 1,
                column: "olusturulma_zamani",
                value: new DateTime(2026, 7, 28, 12, 12, 21, 666, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "id",
                keyValue: 2,
                column: "olusturulma_zamani",
                value: new DateTime(2026, 7, 28, 12, 12, 21, 666, DateTimeKind.Local).AddTicks(6930));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "urun_kodu",
                table: "Urunler",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "birim",
                table: "Urunler",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
