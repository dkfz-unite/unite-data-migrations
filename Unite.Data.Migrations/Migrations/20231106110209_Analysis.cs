using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unite.Data.Migrations.Migrations
{
    public partial class Analysis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnalysisTypeId",
                schema: "com",
                table: "Tasks",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusTypeId",
                schema: "com",
                table: "Tasks",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AnalysisTaskTypes",
                schema: "com",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalysisTaskTypes", x => x.Id);
                    table.UniqueConstraint("AK_AnalysisTaskTypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "TaskStatusTypes",
                schema: "com",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskStatusTypes", x => x.Id);
                    table.UniqueConstraint("AK_TaskStatusTypes_Value", x => x.Value);
                });

            migrationBuilder.InsertData(
                schema: "com",
                table: "AnalysisTaskTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[] { 1, "DExp", "DExp" });

            migrationBuilder.InsertData(
                schema: "com",
                table: "TaskStatusTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Preparing", "Preparing" },
                    { 2, "Prepared", "Prepared" },
                    { 3, "Processing", "Processing" },
                    { 4, "Processed", "Processed" },
                    { 5, "Failed", "Failed" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_AnalysisTypeId",
                schema: "com",
                table: "Tasks",
                column: "AnalysisTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_StatusTypeId",
                schema: "com",
                table: "Tasks",
                column: "StatusTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_AnalysisTaskTypes_AnalysisTypeId",
                schema: "com",
                table: "Tasks",
                column: "AnalysisTypeId",
                principalSchema: "com",
                principalTable: "AnalysisTaskTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_TaskStatusTypes_StatusTypeId",
                schema: "com",
                table: "Tasks",
                column: "StatusTypeId",
                principalSchema: "com",
                principalTable: "TaskStatusTypes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_AnalysisTaskTypes_AnalysisTypeId",
                schema: "com",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_TaskStatusTypes_StatusTypeId",
                schema: "com",
                table: "Tasks");

            migrationBuilder.DropTable(
                name: "AnalysisTaskTypes",
                schema: "com");

            migrationBuilder.DropTable(
                name: "TaskStatusTypes",
                schema: "com");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_AnalysisTypeId",
                schema: "com",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_StatusTypeId",
                schema: "com",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "AnalysisTypeId",
                schema: "com",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "StatusTypeId",
                schema: "com",
                table: "Tasks");
        }
    }
}
