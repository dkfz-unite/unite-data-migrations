using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unite.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class CnvProfileAnalysisTaskType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "com",
                table: "analysis_task_type",
                columns: new[] { "id", "name", "value" },
                values: new object[] { 9, "cnv_profile", "cnv_profile" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "com",
                table: "analysis_task_type",
                keyColumn: "id",
                keyValue: 9);
        }
    }
}
