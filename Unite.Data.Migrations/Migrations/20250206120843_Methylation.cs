using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unite.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Methylation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "com",
                table: "SubmissionTaskTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[] { 304, "dna-meth", "dna-meth" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "com",
                table: "SubmissionTaskTypes",
                keyColumn: "Id",
                keyValue: 304);
        }
    }
}
