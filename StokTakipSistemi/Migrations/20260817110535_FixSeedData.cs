using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StokTakipSistemi.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "id",
                keyValue: 1,
                column: "olusturulma_zamani",
                value: new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "id",
                keyValue: 1,
                column: "olusturulma_zamani",
                value: new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "id",
                keyValue: 2,
                column: "olusturulma_zamani",
                value: new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "id",
                keyValue: 1,
                column: "olusturulma_zamani",
                value: new DateTime(2026, 7, 29, 12, 29, 35, 150, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "id",
                keyValue: 1,
                column: "olusturulma_zamani",
                value: new DateTime(2026, 7, 29, 12, 29, 35, 150, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "id",
                keyValue: 2,
                column: "olusturulma_zamani",
                value: new DateTime(2026, 7, 29, 12, 29, 35, 150, DateTimeKind.Local).AddTicks(334));
        }
    }
}
