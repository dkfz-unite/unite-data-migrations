using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Unite.Data.Migrations.Migrations
{
    public partial class sampledate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Analyses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Samples",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Analyses",
                type: "timestamp without time zone",
                nullable: true);
        }
    }
}
