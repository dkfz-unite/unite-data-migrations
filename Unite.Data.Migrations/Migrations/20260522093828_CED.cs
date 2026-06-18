using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Unite.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class CED : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "com",
                table: "analysis_task_type",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 10, "cedp", "cedp" },
                    { 11, "cedg", "cedg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "com",
                table: "analysis_task_type",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "com",
                table: "analysis_task_type",
                keyColumn: "id",
                keyValue: 11);
        }
    }
}
