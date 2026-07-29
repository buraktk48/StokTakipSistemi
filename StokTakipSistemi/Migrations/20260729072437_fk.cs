using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StokTakipSistemi.Migrations
{
    /// <inheritdoc />
    public partial class fk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "transfer_kullanici_id",
                table: "Transferler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Depolar",
                keyColumn: "id",
                keyValue: 1,
                column: "olusturulma_zamani",
                value: new DateTime(2026, 7, 29, 10, 24, 37, 455, DateTimeKind.Local).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "id",
                keyValue: 1,
                column: "olusturulma_zamani",
                value: new DateTime(2026, 7, 29, 10, 24, 37, 455, DateTimeKind.Local).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "id",
                keyValue: 1,
                column: "olusturulma_zamani",
                value: new DateTime(2026, 7, 29, 10, 24, 37, 455, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "id",
                keyValue: 2,
                column: "olusturulma_zamani",
                value: new DateTime(2026, 7, 29, 10, 24, 37, 455, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.CreateIndex(
                name: "IX_Transferler_transfer_kullanici_id",
                table: "Transferler",
                column: "transfer_kullanici_id");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_rol_id",
                table: "Kullanicilar",
                column: "rol_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanicilar_Roller_rol_id",
                table: "Kullanicilar",
                column: "rol_id",
                principalTable: "Roller",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transferler_Kullanicilar_transfer_kullanici_id",
                table: "Transferler",
                column: "transfer_kullanici_id",
                principalTable: "Kullanicilar",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicilar_Roller_rol_id",
                table: "Kullanicilar");

            migrationBuilder.DropForeignKey(
                name: "FK_Transferler_Kullanicilar_transfer_kullanici_id",
                table: "Transferler");

            migrationBuilder.DropIndex(
                name: "IX_Transferler_transfer_kullanici_id",
                table: "Transferler");

            migrationBuilder.DropIndex(
                name: "IX_Kullanicilar_rol_id",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "transfer_kullanici_id",
                table: "Transferler");

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
        }
    }
}
