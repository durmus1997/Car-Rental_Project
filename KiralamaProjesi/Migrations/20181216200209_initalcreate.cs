using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KiralamaProjesi.Migrations
{
    public partial class initalcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Markalar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ad = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Picture = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Arabalar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MarkaId = table.Column<int>(nullable: false),
                    Ad = table.Column<string>(nullable: true),
                    KisiSayisi = table.Column<string>(nullable: true),
                    Bagaj = table.Column<string>(nullable: true),
                    KmSiniri = table.Column<string>(nullable: true),
                    YasSiniri = table.Column<string>(nullable: true),
                    Guvenlik = table.Column<string>(nullable: true),
                    Picture = table.Column<string>(nullable: true),
                    Fiyat = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arabalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arabalar_Markalar_MarkaId",
                        column: x => x.MarkaId,
                        principalTable: "Markalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Musteriler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArabaId = table.Column<int>(nullable: false),
                    Ad = table.Column<string>(nullable: true),
                    Soyad = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    Adres = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Ulke = table.Column<string>(nullable: true),
                    Sehir = table.Column<string>(nullable: true),
                    PostaKodu = table.Column<string>(nullable: true),
                    OdemeTipi = table.Column<string>(nullable: true),
                    KrediAd = table.Column<string>(nullable: true),
                    Kredino = table.Column<string>(nullable: true),
                    Cvv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteriler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Musteriler_Arabalar_ArabaId",
                        column: x => x.ArabaId,
                        principalTable: "Arabalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arabalar_MarkaId",
                table: "Arabalar",
                column: "MarkaId");

            migrationBuilder.CreateIndex(
                name: "IX_Musteriler_ArabaId",
                table: "Musteriler",
                column: "ArabaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Musteriler");

            migrationBuilder.DropTable(
                name: "Arabalar");

            migrationBuilder.DropTable(
                name: "Markalar");
        }
    }
}
