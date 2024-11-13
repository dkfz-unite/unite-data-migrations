using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unite.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Tasks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comment",
                schema: "com",
                table: "Tasks",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                schema: "com",
                table: "TaskStatusTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[] { 6, "Rejected", "Rejected" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "com",
                table: "TaskStatusTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "Comment",
                schema: "com",
                table: "Tasks");
        }
    }
}
