using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace TuT.ba.Migrations
{
    public partial class PrvaMigracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankovniRacun",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    BrojRacuna = table.Column<long>(nullable: false),
                    StanjeRacuna = table.Column<double>(nullable: false),
                    CSC = table.Column<int>(nullable: false),
                    DatumIsteka = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankovniRacun", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Predmet",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: false),
                    Opis = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Predmet", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: false),
                    Prezime = table.Column<string>(nullable: false),
                    KorisnickoIme = table.Column<string>(nullable: false),
                    DatumRodjenja = table.Column<DateTime>(nullable: false),
                    Sifra = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    BankovniRacunID = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Slika = table.Column<string>(nullable: true),
                    ProsjecnaOcjena = table.Column<double>(nullable: true),
                    DozvoljeniNacinRealizacije = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Korisnik_BankovniRacun_BankovniRacunID",
                        column: x => x.BankovniRacunID,
                        principalTable: "BankovniRacun",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Materijal",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    URL = table.Column<string>(nullable: false),
                    predmetID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materijal", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Materijal_Predmet_predmetID",
                        column: x => x.predmetID,
                        principalTable: "Predmet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Instrukcija",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    StudentID = table.Column<int>(nullable: false),
                    TutorID = table.Column<int>(nullable: false),
                    DatumOdrzavanja = table.Column<DateTime>(nullable: false),
                    Trajanje = table.Column<int>(nullable: false),
                    NacinOdrzavanja = table.Column<int>(nullable: false),
                    Cijena = table.Column<double>(nullable: false),
                    Popust = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instrukcija", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Instrukcija_Korisnik_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Korisnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Instrukcija_Korisnik_TutorID",
                        column: x => x.TutorID,
                        principalTable: "Korisnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Instrukcija_StudentID",
                table: "Instrukcija",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Instrukcija_TutorID",
                table: "Instrukcija",
                column: "TutorID");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_BankovniRacunID",
                table: "Korisnik",
                column: "BankovniRacunID");

            migrationBuilder.CreateIndex(
                name: "IX_Materijal_predmetID",
                table: "Materijal",
                column: "predmetID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instrukcija");

            migrationBuilder.DropTable(
                name: "Materijal");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "Predmet");

            migrationBuilder.DropTable(
                name: "BankovniRacun");
        }
    }
}
