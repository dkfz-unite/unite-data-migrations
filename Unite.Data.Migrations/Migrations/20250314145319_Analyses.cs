using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Unite.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Analyses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "gen",
                table: "AnalysisTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                schema: "gen",
                table: "AnalysisTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 4, "Single Cell RNA Sequencing", "scRNASeq" },
                    { 5, "Single Nucleus RNA Sequencing", "snRNASeq" },
                    { 6, "Bulk ATAC Sequencing", "ATACSeq" },
                    { 7, "Single Cell ATAC Sequencing", "scATACSeq" },
                    { 8, "Single Nucleus ATAC Sequencing", "snATACSeq" },
                    { 9, "Illumina Infinium Methylation Arrays Assay", "MethArray" },
                    { 10, "Whole Genome Bisulfite Sequencing", "WGBS" },
                    { 11, "Reduced Representation Bisulfite Sequencing", "RRBS" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "gen",
                table: "AnalysisTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "gen",
                table: "AnalysisTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "gen",
                table: "AnalysisTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "gen",
                table: "AnalysisTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "gen",
                table: "AnalysisTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "gen",
                table: "AnalysisTypes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "gen",
                table: "AnalysisTypes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "gen",
                table: "AnalysisTypes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.InsertData(
                schema: "gen",
                table: "AnalysisTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[] { 4, "Single Cell RNA Sequencing", "RNASeqSc" });
        }
    }
}
