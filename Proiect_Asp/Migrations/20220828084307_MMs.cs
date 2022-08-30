using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect_Asp.Migrations
{
    public partial class MMs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctori",
                columns: table => new
                {
                    IdDoctor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specializare = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctori", x => x.IdDoctor);
                });

            migrationBuilder.CreateTable(
                name: "ProgramariDoctori",
                columns: table => new
                {
                    ProgramareId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramariDoctori", x => new { x.DoctorId, x.ProgramareId });
                    table.ForeignKey(
                        name: "FK_ProgramariDoctori_Doctori_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctori",
                        principalColumn: "IdDoctor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgramariDoctori_Programari_ProgramareId",
                        column: x => x.ProgramareId,
                        principalTable: "Programari",
                        principalColumn: "IdProgramare",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProgramariDoctori_ProgramareId",
                table: "ProgramariDoctori",
                column: "ProgramareId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProgramariDoctori");

            migrationBuilder.DropTable(
                name: "Doctori");
        }
    }
}
