using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unite.Data.Migrations.Migrations
{
    public partial class DrugsInhibition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Gof",
                schema: "spe",
                table: "DrugScreenings",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Inhibition",
                schema: "spe",
                table: "DrugScreenings",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gof",
                schema: "spe",
                table: "DrugScreenings");

            migrationBuilder.DropColumn(
                name: "Inhibition",
                schema: "spe",
                table: "DrugScreenings");
        }
    }
}
