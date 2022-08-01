using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unite.Data.Migrations.Migrations
{
    public partial class DrugsResponse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Inhibition",
                schema: "spe",
                table: "DrugScreenings",
                newName: "InhibitionsSample");

            migrationBuilder.AddColumn<string>(
                name: "Concentrations",
                schema: "spe",
                table: "DrugScreenings",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Inhibitions",
                schema: "spe",
                table: "DrugScreenings",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InhibitionsControl",
                schema: "spe",
                table: "DrugScreenings",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Concentrations",
                schema: "spe",
                table: "DrugScreenings");

            migrationBuilder.DropColumn(
                name: "Inhibitions",
                schema: "spe",
                table: "DrugScreenings");

            migrationBuilder.DropColumn(
                name: "InhibitionsControl",
                schema: "spe",
                table: "DrugScreenings");

            migrationBuilder.RenameColumn(
                name: "InhibitionsSample",
                schema: "spe",
                table: "DrugScreenings",
                newName: "Inhibition");
        }
    }
}
