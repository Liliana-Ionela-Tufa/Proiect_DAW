using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect_Asp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.CreateTable(
                name: "Pacienti",
                columns: table => new
                {
                    IdPacient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CNP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacienti", x => x.IdPacient);
                });

            migrationBuilder.CreateTable(
                name: "Adresa",
                columns: table => new
                {
                    IdAdresa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tara = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Oras = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Strada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NrStrada = table.Column<int>(type: "int", nullable: false),
                    PacientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresa", x => x.IdAdresa);
                    table.ForeignKey(
                        name: "FK_Adresa_Pacienti_PacientId",
                        column: x => x.PacientId,
                        principalTable: "Pacienti",
                        principalColumn: "IdPacient",
                        onDelete: ReferentialAction.Cascade);
                });
            */
            migrationBuilder.CreateTable(
                name: "Programari",
                columns: table => new
                {
                    IdProgramare = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Compensata = table.Column<bool>(type: "bit", nullable: false),
                    PacientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programari", x => x.IdProgramare);
                    table.ForeignKey(
                        name: "FK_Programari_Pacienti_PacientId",
                        column: x => x.PacientId,
                        principalTable: "Pacienti",
                        principalColumn: "IdPacient",
                        onDelete: ReferentialAction.Cascade);
                });

            /*migrationBuilder.CreateIndex(
                name: "IX_Adresa_PacientId",
                table: "Adresa",
                column: "PacientId",
                unique: true); */

            migrationBuilder.CreateIndex(
                name: "IX_Programari_PacientId",
                table: "Programari",
                column: "PacientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adresa");

            migrationBuilder.DropTable(
                name: "Programari");

            migrationBuilder.DropTable(
                name: "Pacienti");
        }
    }
}
