using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StokTakipSistemi.Migrations
{
    /// <inheritdoc />
    public partial class iliskiler : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "urun_id",
                table: "TransferDetaylari",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "transfer_id",
                table: "TransferDetaylari",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "olusturan_kullanici_id",
                table: "DepoStoklari",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "olusturan_kullanici_id",
                table: "Depolar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Depolar",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "olusturan_kullanici_id", "olusturulma_zamani" },
                values: new object[] { 0, new DateTime(2026, 7, 29, 12, 14, 36, 403, DateTimeKind.Local).AddTicks(4882) });

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "id",
                keyValue: 1,
                column: "olusturulma_zamani",
                value: new DateTime(2026, 7, 29, 12, 14, 36, 403, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "id",
                keyValue: 1,
                column: "olusturulma_zamani",
                value: new DateTime(2026, 7, 29, 12, 14, 36, 403, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "Roller",
                keyColumn: "id",
                keyValue: 2,
                column: "olusturulma_zamani",
                value: new DateTime(2026, 7, 29, 12, 14, 36, 403, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.CreateIndex(
                name: "IX_Transferler_cikis_depo_id",
                table: "Transferler",
                column: "cikis_depo_id");

            migrationBuilder.CreateIndex(
                name: "IX_Transferler_varis_depo_id",
                table: "Transferler",
                column: "varis_depo_id");

            migrationBuilder.CreateIndex(
                name: "IX_TransferDetaylari_transfer_id",
                table: "TransferDetaylari",
                column: "transfer_id");

            migrationBuilder.CreateIndex(
                name: "IX_TransferDetaylari_urun_id",
                table: "TransferDetaylari",
                column: "urun_id");

            migrationBuilder.CreateIndex(
                name: "IX_DepoStoklari_depo_id",
                table: "DepoStoklari",
                column: "depo_id");

            migrationBuilder.CreateIndex(
                name: "IX_DepoStoklari_olusturan_kullanici_id",
                table: "DepoStoklari",
                column: "olusturan_kullanici_id");

            migrationBuilder.CreateIndex(
                name: "IX_DepoStoklari_urun_id",
                table: "DepoStoklari",
                column: "urun_id");

            migrationBuilder.CreateIndex(
                name: "IX_Depolar_olusturan_kullanici_id",
                table: "Depolar",
                column: "olusturan_kullanici_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Depolar_Kullanicilar_olusturan_kullanici_id",
                table: "Depolar",
                column: "olusturan_kullanici_id",
                principalTable: "Kullanicilar",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepoStoklari_Depolar_depo_id",
                table: "DepoStoklari",
                column: "depo_id",
                principalTable: "Depolar",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepoStoklari_Kullanicilar_olusturan_kullanici_id",
                table: "DepoStoklari",
                column: "olusturan_kullanici_id",
                principalTable: "Kullanicilar",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepoStoklari_Urunler_urun_id",
                table: "DepoStoklari",
                column: "urun_id",
                principalTable: "Urunler",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransferDetaylari_Transferler_transfer_id",
                table: "TransferDetaylari",
                column: "transfer_id",
                principalTable: "Transferler",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransferDetaylari_Urunler_urun_id",
                table: "TransferDetaylari",
                column: "urun_id",
                principalTable: "Urunler",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transferler_Depolar_cikis_depo_id",
                table: "Transferler",
                column: "cikis_depo_id",
                principalTable: "Depolar",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transferler_Depolar_varis_depo_id",
                table: "Transferler",
                column: "varis_depo_id",
                principalTable: "Depolar",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Depolar_Kullanicilar_olusturan_kullanici_id",
                table: "Depolar");

            migrationBuilder.DropForeignKey(
                name: "FK_DepoStoklari_Depolar_depo_id",
                table: "DepoStoklari");

            migrationBuilder.DropForeignKey(
                name: "FK_DepoStoklari_Kullanicilar_olusturan_kullanici_id",
                table: "DepoStoklari");

            migrationBuilder.DropForeignKey(
                name: "FK_DepoStoklari_Urunler_urun_id",
                table: "DepoStoklari");

            migrationBuilder.DropForeignKey(
                name: "FK_TransferDetaylari_Transferler_transfer_id",
                table: "TransferDetaylari");

            migrationBuilder.DropForeignKey(
                name: "FK_TransferDetaylari_Urunler_urun_id",
                table: "TransferDetaylari");

            migrationBuilder.DropForeignKey(
                name: "FK_Transferler_Depolar_cikis_depo_id",
                table: "Transferler");

            migrationBuilder.DropForeignKey(
                name: "FK_Transferler_Depolar_varis_depo_id",
                table: "Transferler");

            migrationBuilder.DropIndex(
                name: "IX_Transferler_cikis_depo_id",
                table: "Transferler");

            migrationBuilder.DropIndex(
                name: "IX_Transferler_varis_depo_id",
                table: "Transferler");

            migrationBuilder.DropIndex(
                name: "IX_TransferDetaylari_transfer_id",
                table: "TransferDetaylari");

            migrationBuilder.DropIndex(
                name: "IX_TransferDetaylari_urun_id",
                table: "TransferDetaylari");

            migrationBuilder.DropIndex(
                name: "IX_DepoStoklari_depo_id",
                table: "DepoStoklari");

            migrationBuilder.DropIndex(
                name: "IX_DepoStoklari_olusturan_kullanici_id",
                table: "DepoStoklari");

            migrationBuilder.DropIndex(
                name: "IX_DepoStoklari_urun_id",
                table: "DepoStoklari");

            migrationBuilder.DropIndex(
                name: "IX_Depolar_olusturan_kullanici_id",
                table: "Depolar");

            migrationBuilder.DropColumn(
                name: "olusturan_kullanici_id",
                table: "DepoStoklari");

            migrationBuilder.DropColumn(
                name: "olusturan_kullanici_id",
                table: "Depolar");

            migrationBuilder.AlterColumn<string>(
                name: "urun_id",
                table: "TransferDetaylari",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "transfer_id",
                table: "TransferDetaylari",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
        }
    }
}
