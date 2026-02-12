using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Unite.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class ChromosomeArm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "chromosome_arm",
                schema: "omi",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chromosome_arm", x => x.id);
                    table.UniqueConstraint("AK_chromosome_arm_value", x => x.value);
                });

            migrationBuilder.InsertData(
                schema: "omi",
                table: "chromosome_arm",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "Short arm", "1" },
                    { 2, "Long arm", "2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_cnv_profile_chromosome",
                schema: "omi",
                table: "cnv_profile",
                column: "chromosome");

            migrationBuilder.CreateIndex(
                name: "IX_cnv_profile_chromosome_arm",
                schema: "omi",
                table: "cnv_profile",
                column: "chromosome_arm");

            migrationBuilder.AddForeignKey(
                name: "FK_cnv_profile_chromosome_arm_chromosome_arm",
                schema: "omi",
                table: "cnv_profile",
                column: "chromosome_arm",
                principalSchema: "omi",
                principalTable: "chromosome_arm",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cnv_profile_chromosome_chromosome",
                schema: "omi",
                table: "cnv_profile",
                column: "chromosome",
                principalSchema: "omi",
                principalTable: "chromosome",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cnv_profile_chromosome_arm_chromosome_arm",
                schema: "omi",
                table: "cnv_profile");

            migrationBuilder.DropForeignKey(
                name: "FK_cnv_profile_chromosome_chromosome",
                schema: "omi",
                table: "cnv_profile");

            migrationBuilder.DropTable(
                name: "chromosome_arm",
                schema: "omi");

            migrationBuilder.DropIndex(
                name: "IX_cnv_profile_chromosome",
                schema: "omi",
                table: "cnv_profile");

            migrationBuilder.DropIndex(
                name: "IX_cnv_profile_chromosome_arm",
                schema: "omi",
                table: "cnv_profile");
        }
    }
}
