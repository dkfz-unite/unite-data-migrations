using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Unite.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class CnvProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CnvProfiles",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SampleId = table.Column<int>(type: "integer", nullable: false),
                    Chromosome = table.Column<int>(type: "integer", nullable: false),
                    ChromosomeArm = table.Column<int>(type: "integer", nullable: false),
                    Gain = table.Column<float>(type: "real", nullable: false),
                    Loss = table.Column<float>(type: "real", nullable: false),
                    Neutral = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CnvProfiles", x => x.id);
                    table.ForeignKey(
                        name: "FK_CnvProfiles_sample_SampleId",
                        column: x => x.SampleId,
                        principalSchema: "omi",
                        principalTable: "sample",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                schema: "com",
                table: "submission_task_types",
                columns: new[] { "id", "name", "value" },
                values: new object[] { 304, "dna-cnv-profile", "dna-cnv-profile" });

            migrationBuilder.CreateIndex(
                name: "IX_CnvProfiles_SampleId",
                table: "CnvProfiles",
                column: "SampleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CnvProfiles");

            migrationBuilder.DeleteData(
                schema: "com",
                table: "submission_task_types",
                keyColumn: "id",
                keyValue: 304);
        }
    }
}
