using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unite.Data.Migrations.Migrations
{
    public partial class ResponseCurve : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InhibitionsSample",
                schema: "spe",
                table: "DrugScreenings",
                newName: "Response");

            migrationBuilder.RenameColumn(
                name: "InhibitionsControl",
                schema: "spe",
                table: "DrugScreenings",
                newName: "Inhibition");

            migrationBuilder.RenameColumn(
                name: "Inhibitions",
                schema: "spe",
                table: "DrugScreenings",
                newName: "Dose");

            migrationBuilder.RenameColumn(
                name: "Concentrations",
                schema: "spe",
                table: "DrugScreenings",
                newName: "Concentration");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Response",
                schema: "spe",
                table: "DrugScreenings",
                newName: "InhibitionsSample");

            migrationBuilder.RenameColumn(
                name: "Inhibition",
                schema: "spe",
                table: "DrugScreenings",
                newName: "InhibitionsControl");

            migrationBuilder.RenameColumn(
                name: "Dose",
                schema: "spe",
                table: "DrugScreenings",
                newName: "Inhibitions");

            migrationBuilder.RenameColumn(
                name: "Concentration",
                schema: "spe",
                table: "DrugScreenings",
                newName: "Concentrations");
        }
    }
}
