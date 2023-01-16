using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect2.Migrations
{
    public partial class InitCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublishingDate",
                table: "Manichiura");

            migrationBuilder.AddColumn<string>(
                name: "Desen",
                table: "Manichiura",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManichiuraID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Client_Manichiura_ManichiuraID",
                        column: x => x.ManichiuraID,
                        principalTable: "Manichiura",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_ManichiuraID",
                table: "Client",
                column: "ManichiuraID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropColumn(
                name: "Desen",
                table: "Manichiura");

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishingDate",
                table: "Manichiura",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
