using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unite.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class SampleBatch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "batch",
                schema: "omi",
                table: "sample",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "batch",
                schema: "omi",
                table: "sample");
        }
    }
}
