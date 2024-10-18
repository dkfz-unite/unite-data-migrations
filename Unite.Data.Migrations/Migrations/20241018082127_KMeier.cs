using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Unite.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class KMeier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "com",
                table: "AnalysisTaskTypes",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                schema: "com",
                table: "AnalysisTaskTypes",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.InsertData(
                schema: "com",
                table: "AnalysisTaskTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "deseq2", "deseq2" },
                    { 2, "scell", "scell" },
                    { 3, "kmeier", "kmeier" }
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

            migrationBuilder.DeleteData(
                schema: "com",
                table: "AnalysisTaskTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                schema: "com",
                table: "AnalysisTaskTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 320, "rna-de", "rna-de" },
                    { 340, "rnacs", "rnacs" }
                });
        }
    }
}
