using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect2.Migrations
{
    public partial class PublishingDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "Manichiura");

            migrationBuilder.AddColumn<decimal>(
                name: "Pret",
                table: "Manichiura",
                type: "decimal(6,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishingDate",
                table: "Manichiura",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pret",
                table: "Manichiura");

            migrationBuilder.DropColumn(
                name: "PublishingDate",
                table: "Manichiura");

            migrationBuilder.AddColumn<int>(
                name: "Data",
                table: "Manichiura",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
