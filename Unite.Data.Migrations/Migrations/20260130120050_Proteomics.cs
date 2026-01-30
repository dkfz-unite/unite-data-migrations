using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unite.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Proteomics : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "accession_id",
                schema: "omi",
                table: "protein",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "database",
                schema: "omi",
                table: "protein",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "description",
                schema: "omi",
                table: "protein",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "symbol",
                schema: "omi",
                table: "protein",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "accession_id",
                schema: "omi",
                table: "protein");

            migrationBuilder.DropColumn(
                name: "database",
                schema: "omi",
                table: "protein");

            migrationBuilder.DropColumn(
                name: "description",
                schema: "omi",
                table: "protein");

            migrationBuilder.DropColumn(
                name: "symbol",
                schema: "omi",
                table: "protein");
        }
    }
}
