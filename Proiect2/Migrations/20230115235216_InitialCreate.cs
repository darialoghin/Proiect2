using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Manichiura",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Culoare = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Forma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manichiura", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Manichiura");
        }
    }
}
