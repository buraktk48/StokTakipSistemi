using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StokTakipSistemi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Depolar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    olusturulma_zamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lokasyon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depolar", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DepoStoklari",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    depo_id = table.Column<int>(type: "int", nullable: false),
                    urun_id = table.Column<int>(type: "int", nullable: false),
                    miktar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    olusturulma_zamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepoStoklari", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kullanici_adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kullanici_durum = table.Column<bool>(type: "bit", nullable: false),
                    rol_id = table.Column<int>(type: "int", nullable: false),
                    olusturulma_zamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Roller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    olusturulma_zamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roller", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransferDetaylari",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    transfer_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    urun_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    miktar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    olusturulma_zamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferDetaylari", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Transferler",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cikis_depo_id = table.Column<int>(type: "int", nullable: false),
                    varis_depo_id = table.Column<int>(type: "int", nullable: false),
                    fis_numarasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    olusturulma_zamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transferler", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    urun_kodu = table.Column<int>(type: "int", nullable: false),
                    urun_adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birim = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    olusturulma_zamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Depolar");

            migrationBuilder.DropTable(
                name: "DepoStoklari");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "Roller");

            migrationBuilder.DropTable(
                name: "TransferDetaylari");

            migrationBuilder.DropTable(
                name: "Transferler");

            migrationBuilder.DropTable(
                name: "Urunler");
        }
    }
}
