using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unite.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Projects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "com",
                table: "IndexingTaskTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[] { 8, "Project", "Project" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "com",
                table: "IndexingTaskTypes",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
