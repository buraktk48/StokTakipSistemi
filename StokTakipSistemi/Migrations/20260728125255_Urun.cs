using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StokTakipSistemi.Migrations
{
    /// <inheritdoc />
    public partial class Urun : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ekleyen_kullanici_id",
                table: "Urunler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Depolar",
                keyColumn: "id",
                keyValue: 1,
                column: "olusturulma_zamani",
                value: new DateTime(2026, 7, 28, 15, 52, 54, 898, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "id",
                keyValue: 1,
                column: "olusturulma_zamani",
                value: new DateTime(2026, 7, 28, 15, 52, 54, 898, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "id",
                keyValue: 1,
                column: "olusturulma_zamani",
                value: new DateTime(2026, 7, 28, 15, 52, 54, 898, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "id",
                keyValue: 2,
                column: "olusturulma_zamani",
                value: new DateTime(2026, 7, 28, 15, 52, 54, 898, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_ekleyen_kullanici_id",
                table: "Urunler",
                column: "ekleyen_kullanici_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Urunler_Kullanicilar_ekleyen_kullanici_id",
                table: "Urunler",
                column: "ekleyen_kullanici_id",
                principalTable: "Kullanicilar",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urunler_Kullanicilar_ekleyen_kullanici_id",
                table: "Urunler");

            migrationBuilder.DropIndex(
                name: "IX_Urunler_ekleyen_kullanici_id",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "ekleyen_kullanici_id",
                table: "Urunler");

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
    }
}
