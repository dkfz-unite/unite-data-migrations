using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Unite.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Fixation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FixationTypeId",
                schema: "spe",
                table: "Materials",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "TumorGrade",
                schema: "spe",
                table: "Materials",
                type: "smallint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FixationTypes",
                schema: "spe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FixationTypes", x => x.Id);
                    table.UniqueConstraint("AK_FixationTypes_Value", x => x.Value);
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "FixationTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "FFPE", "FFPE" },
                    { 2, "Fresh Frozen", "Fresh Frozen" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Materials_FixationTypeId",
                schema: "spe",
                table: "Materials",
                column: "FixationTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_FixationTypes_FixationTypeId",
                schema: "spe",
                table: "Materials",
                column: "FixationTypeId",
                principalSchema: "spe",
                principalTable: "FixationTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_FixationTypes_FixationTypeId",
                schema: "spe",
                table: "Materials");

            migrationBuilder.DropTable(
                name: "FixationTypes",
                schema: "spe");

            migrationBuilder.DropIndex(
                name: "IX_Materials_FixationTypeId",
                schema: "spe",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "FixationTypeId",
                schema: "spe",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "TumorGrade",
                schema: "spe",
                table: "Materials");
        }
    }
}
