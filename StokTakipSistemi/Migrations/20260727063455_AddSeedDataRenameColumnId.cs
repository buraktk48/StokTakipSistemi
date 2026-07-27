using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StokTakipSistemi.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedDataRenameColumnId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Roller",
                newName: "id");

            migrationBuilder.InsertData(
                table: "Depolar",
                columns: new[] { "id", "ad", "lokasyon", "olusturulma_zamani" },
                values: new object[] { 1, "Ana Depo", "Merkez", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "id", "ad", "kullanici_adi", "kullanici_durum", "olusturulma_zamani", "rol_id", "sifre", "soyad" },
                values: new object[] { 1, "Yonetici", "admin", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "123456", "Hesap" });

            migrationBuilder.InsertData(
                table: "Roller",
                columns: new[] { "id", "adi", "olusturulma_zamani" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Personel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Depolar",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roller",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roller",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Roller",
                newName: "Id");
        }
    }
}
