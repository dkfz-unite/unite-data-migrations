using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Unite.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Submissions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "com",
                table: "SubmissionTaskTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 0, "don", "don" },
                    { 1, "don-trt", "don-trt" },
                    { 100, "mri", "mri" },
                    { 101, "img-rad", "img-rad" },
                    { 200, "mat", "mat" },
                    { 201, "lne", "lne" },
                    { 202, "org", "org" },
                    { 203, "xen", "xen" },
                    { 204, "spe-int", "spe-int" },
                    { 205, "spe-drg", "spe-drg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "com",
                table: "SubmissionTaskTypes",
                keyColumn: "Id",
                keyValue: 0);

            migrationBuilder.DeleteData(
                schema: "com",
                table: "SubmissionTaskTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "com",
                table: "SubmissionTaskTypes",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                schema: "com",
                table: "SubmissionTaskTypes",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                schema: "com",
                table: "SubmissionTaskTypes",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                schema: "com",
                table: "SubmissionTaskTypes",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                schema: "com",
                table: "SubmissionTaskTypes",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                schema: "com",
                table: "SubmissionTaskTypes",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                schema: "com",
                table: "SubmissionTaskTypes",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                schema: "com",
                table: "SubmissionTaskTypes",
                keyColumn: "Id",
                keyValue: 205);
        }
    }
}
