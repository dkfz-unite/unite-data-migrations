using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unite.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Samples : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GenesModel",
                schema: "gen",
                table: "Samples",
                newName: "Genome");

            migrationBuilder.RenameColumn(
                name: "CellsNumber",
                schema: "gen",
                table: "Samples",
                newName: "Cells");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Genome",
                schema: "gen",
                table: "Samples",
                newName: "GenesModel");

            migrationBuilder.RenameColumn(
                name: "Cells",
                schema: "gen",
                table: "Samples",
                newName: "CellsNumber");
        }
    }
}
