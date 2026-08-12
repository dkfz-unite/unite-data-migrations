using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Unite.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class DataUserProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "is_public",
                schema: "don",
                table: "project",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "data_user",
                schema: "don",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_data_user", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "project_user",
                schema: "don",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    project_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_project_user", x => new { x.project_id, x.user_id });
                    table.ForeignKey(
                        name: "FK_project_user_data_user_user_id",
                        column: x => x.user_id,
                        principalSchema: "don",
                        principalTable: "data_user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_project_user_project_project_id",
                        column: x => x.project_id,
                        principalSchema: "don",
                        principalTable: "project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_project_user_user_id",
                schema: "don",
                table: "project_user",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "project_user",
                schema: "don");

            migrationBuilder.DropTable(
                name: "data_user",
                schema: "don");

            migrationBuilder.DropColumn(
                name: "is_public",
                schema: "don",
                table: "project");
        }
    }
}
