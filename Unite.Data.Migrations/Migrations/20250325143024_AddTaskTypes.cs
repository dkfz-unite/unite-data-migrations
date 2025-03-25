using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unite.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddTaskTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "com",
                table: "AnalysisTaskTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[] { 4, "meth", "meth" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "com",
                table: "AnalysisTaskTypes",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
