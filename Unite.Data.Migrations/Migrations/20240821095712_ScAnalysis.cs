using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Unite.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class ScAnalysis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "com",
                table: "AnalysisTaskTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                schema: "com",
                table: "AnalysisTaskTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "RNA-DE", "RNA-DE" },
                    { 2, "RNASC", "RNASC" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "com",
                table: "AnalysisTaskTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "com",
                table: "AnalysisTaskTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                schema: "com",
                table: "AnalysisTaskTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[] { 1, "DExp", "DExp" });
        }
    }
}
