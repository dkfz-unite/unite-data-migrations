using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Unite.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Dep : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "com",
                table: "analysis_task_type",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "name", "value" },
                values: new object[] { "deg", "deg" });

            migrationBuilder.InsertData(
                schema: "com",
                table: "analysis_task_type",
                columns: new[] { "id", "name", "value" },
                values: new object[] { 7, "dep", "dep" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "com",
                table: "analysis_task_type",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                schema: "com",
                table: "analysis_task_type",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "name", "value" },
                values: new object[] { "de", "de" });
        }
    }
}
