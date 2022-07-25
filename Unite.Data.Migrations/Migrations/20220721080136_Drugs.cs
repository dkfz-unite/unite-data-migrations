using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Unite.Data.Migrations.Migrations
{
    public partial class Drugs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drugs",
                schema: "spe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drugs", x => x.Id);
                    table.UniqueConstraint("AK_Drugs_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "DrugScreenings",
                schema: "spe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SpecimenId = table.Column<int>(type: "integer", nullable: false),
                    DrugId = table.Column<int>(type: "integer", nullable: false),
                    MinConcentration = table.Column<double>(type: "double precision", nullable: true),
                    MaxConcentration = table.Column<double>(type: "double precision", nullable: true),
                    Dss = table.Column<double>(type: "double precision", nullable: true),
                    DssSelective = table.Column<double>(type: "double precision", nullable: true),
                    AbsIC25 = table.Column<double>(type: "double precision", nullable: true),
                    AbsIC50 = table.Column<double>(type: "double precision", nullable: true),
                    AbsIC75 = table.Column<double>(type: "double precision", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugScreenings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DrugScreenings_Drugs_DrugId",
                        column: x => x.DrugId,
                        principalSchema: "spe",
                        principalTable: "Drugs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DrugScreenings_Specimens_SpecimenId",
                        column: x => x.SpecimenId,
                        principalSchema: "spe",
                        principalTable: "Specimens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DrugScreenings_DrugId",
                schema: "spe",
                table: "DrugScreenings",
                column: "DrugId");

            migrationBuilder.CreateIndex(
                name: "IX_DrugScreenings_SpecimenId",
                schema: "spe",
                table: "DrugScreenings",
                column: "SpecimenId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DrugScreenings",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "Drugs",
                schema: "spe");
        }
    }
}
