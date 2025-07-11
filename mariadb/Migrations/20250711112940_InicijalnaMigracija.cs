using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mariadb.Migrations
{
    /// <inheritdoc />
    public partial class InicijalnaMigracija : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Goriva",
                columns: table => new
                {
                    IdGoriva = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NazivGoriva = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CijenaGoriva = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goriva", x => x.IdGoriva);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    IdKorisnika = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    KorisnickoIme = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Lozinka = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    JeAdmin = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ImePrezime = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.IdKorisnika);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PravnaOsoba",
                columns: table => new
                {
                    IdPravnaOsoba = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Adresa = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Mjesto = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PravnaOsoba", x => x.IdPravnaOsoba);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Proizvodjaci",
                columns: table => new
                {
                    IdProizvodjac = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NazivProizvodjaca = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvodjaci", x => x.IdProizvodjac);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Automobili",
                columns: table => new
                {
                    IdAutomobila = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Registracija = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdProizvodjac = table.Column<int>(type: "int", nullable: false),
                    IdGoriva = table.Column<int>(type: "int", nullable: false),
                    DatumRegistracije = table.Column<DateTime>(type: "date", nullable: false),
                    Model = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GodinaProizvodnje = table.Column<int>(type: "int", nullable: true),
                    ccm = table.Column<int>(type: "int", nullable: true),
                    kW = table.Column<int>(type: "int", nullable: true),
                    Potrosnja = table.Column<decimal>(type: "decimal(4,2)", nullable: true),
                    Dostupan = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    KilometriNaRegistraciji = table.Column<decimal>(type: "decimal(10,1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Automobili", x => x.IdAutomobila);
                    table.ForeignKey(
                        name: "FK_Automobili_Goriva_IdGoriva",
                        column: x => x.IdGoriva,
                        principalTable: "Goriva",
                        principalColumn: "IdGoriva",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Automobili_Proizvodjaci_IdProizvodjac",
                        column: x => x.IdProizvodjac,
                        principalTable: "Proizvodjaci",
                        principalColumn: "IdProizvodjac",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Rezervacije",
                columns: table => new
                {
                    IdRezervacije = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdKorisnika = table.Column<int>(type: "int", nullable: false),
                    IdAutomobila = table.Column<int>(type: "int", nullable: false),
                    DatumOdlaska = table.Column<DateTime>(type: "date", nullable: false),
                    DatumDolaska = table.Column<DateTime>(type: "date", nullable: false),
                    Mjesto = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Udaljenost = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    RazlogOpis = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Odobreno = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacije", x => x.IdRezervacije);
                    table.ForeignKey(
                        name: "FK_Rezervacije_Automobili_IdAutomobila",
                        column: x => x.IdAutomobila,
                        principalTable: "Automobili",
                        principalColumn: "IdAutomobila",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezervacije_Korisnici_IdKorisnika",
                        column: x => x.IdKorisnika,
                        principalTable: "Korisnici",
                        principalColumn: "IdKorisnika",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Servisi",
                columns: table => new
                {
                    IdServisa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdAutomobila = table.Column<int>(type: "int", nullable: false),
                    DatumServisa = table.Column<DateTime>(type: "date", nullable: false),
                    CijenaServisa = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    OpisServisa = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servisi", x => x.IdServisa);
                    table.ForeignKey(
                        name: "FK_Servisi_Automobili_IdAutomobila",
                        column: x => x.IdAutomobila,
                        principalTable: "Automobili",
                        principalColumn: "IdAutomobila",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Automobili_IdGoriva",
                table: "Automobili",
                column: "IdGoriva");

            migrationBuilder.CreateIndex(
                name: "IX_Automobili_IdProizvodjac",
                table: "Automobili",
                column: "IdProizvodjac");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_IdAutomobila",
                table: "Rezervacije",
                column: "IdAutomobila");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_IdKorisnika",
                table: "Rezervacije",
                column: "IdKorisnika");

            migrationBuilder.CreateIndex(
                name: "IX_Servisi_IdAutomobila",
                table: "Servisi",
                column: "IdAutomobila");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PravnaOsoba");

            migrationBuilder.DropTable(
                name: "Rezervacije");

            migrationBuilder.DropTable(
                name: "Servisi");

            migrationBuilder.DropTable(
                name: "Korisnici");

            migrationBuilder.DropTable(
                name: "Automobili");

            migrationBuilder.DropTable(
                name: "Goriva");

            migrationBuilder.DropTable(
                name: "Proizvodjaci");
        }
    }
}
