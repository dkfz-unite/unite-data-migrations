using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Unite.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Resources : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "com",
                table: "SubmissionTaskTypes",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                schema: "com",
                table: "SubmissionTaskTypes",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                schema: "gen",
                table: "SampleResources",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                schema: "com",
                table: "SubmissionTaskTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 300, "dna", "dna" },
                    { 310, "meth", "meth" },
                    { 311, "meth-lvl", "meth-lvl" },
                    { 320, "rna", "rna" },
                    { 330, "rnasc", "rnasc" },
                    { 331, "rnasc-exp", "rnasc-exp" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "com",
                table: "SubmissionTaskTypes",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                schema: "com",
                table: "SubmissionTaskTypes",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                schema: "com",
                table: "SubmissionTaskTypes",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                schema: "com",
                table: "SubmissionTaskTypes",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                schema: "com",
                table: "SubmissionTaskTypes",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                schema: "com",
                table: "SubmissionTaskTypes",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DropColumn(
                name: "Name",
                schema: "gen",
                table: "SampleResources");

            migrationBuilder.InsertData(
                schema: "com",
                table: "SubmissionTaskTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 304, "dna-meth", "dna-meth" },
                    { 341, "rnasc-exp", "rnasc-exp" }
                });
        }
    }
}
