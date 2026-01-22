using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Unite.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Classifier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "condition_id",
                schema: "spe",
                table: "specimen",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "tumor_grade",
                schema: "spe",
                table: "specimen",
                type: "smallint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tumor_type_id",
                schema: "spe",
                table: "specimen",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "condition",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_condition", x => x.id);
                    table.UniqueConstraint("AK_condition_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "tumor_class",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tumor_class", x => x.id);
                    table.UniqueConstraint("AK_tumor_class_name", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "tumor_family",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tumor_family", x => x.id);
                    table.UniqueConstraint("AK_tumor_family_name", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "tumor_subclass",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tumor_subclass", x => x.id);
                    table.UniqueConstraint("AK_tumor_subclass_name", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "tumor_superfamily",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tumor_superfamily", x => x.id);
                    table.UniqueConstraint("AK_tumor_superfamily_name", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "tumor_classification",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    specimen_id = table.Column<int>(type: "integer", nullable: false),
                    superfamily_id = table.Column<int>(type: "integer", nullable: true),
                    family_id = table.Column<int>(type: "integer", nullable: true),
                    class_id = table.Column<int>(type: "integer", nullable: true),
                    subclass_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tumor_classification", x => x.id);
                    table.ForeignKey(
                        name: "FK_tumor_classification_specimen_specimen_id",
                        column: x => x.specimen_id,
                        principalSchema: "spe",
                        principalTable: "specimen",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tumor_classification_tumor_class_class_id",
                        column: x => x.class_id,
                        principalSchema: "spe",
                        principalTable: "tumor_class",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_tumor_classification_tumor_family_family_id",
                        column: x => x.family_id,
                        principalSchema: "spe",
                        principalTable: "tumor_family",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_tumor_classification_tumor_subclass_subclass_id",
                        column: x => x.subclass_id,
                        principalSchema: "spe",
                        principalTable: "tumor_subclass",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_tumor_classification_tumor_superfamily_superfamily_id",
                        column: x => x.superfamily_id,
                        principalSchema: "spe",
                        principalTable: "tumor_superfamily",
                        principalColumn: "id");
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "condition",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "Normal", "Normal" },
                    { 2, "Tumor", "Tumor" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_specimen_condition_id",
                schema: "spe",
                table: "specimen",
                column: "condition_id");

            migrationBuilder.CreateIndex(
                name: "IX_specimen_tumor_type_id",
                schema: "spe",
                table: "specimen",
                column: "tumor_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_tumor_classification_class_id",
                schema: "spe",
                table: "tumor_classification",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_tumor_classification_family_id",
                schema: "spe",
                table: "tumor_classification",
                column: "family_id");

            migrationBuilder.CreateIndex(
                name: "IX_tumor_classification_specimen_id",
                schema: "spe",
                table: "tumor_classification",
                column: "specimen_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tumor_classification_subclass_id",
                schema: "spe",
                table: "tumor_classification",
                column: "subclass_id");

            migrationBuilder.CreateIndex(
                name: "IX_tumor_classification_superfamily_id",
                schema: "spe",
                table: "tumor_classification",
                column: "superfamily_id");

            migrationBuilder.AddForeignKey(
                name: "FK_specimen_condition_condition_id",
                schema: "spe",
                table: "specimen",
                column: "condition_id",
                principalSchema: "spe",
                principalTable: "condition",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_specimen_tumor_type_tumor_type_id",
                schema: "spe",
                table: "specimen",
                column: "tumor_type_id",
                principalSchema: "spe",
                principalTable: "tumor_type",
                principalColumn: "id");

            // Migrate data from material table to specimen table
            migrationBuilder.Sql(@"
                UPDATE spe.specimen AS s
                SET 
                    condition_id = m.type_id,
                    tumor_type_id = m.tumor_type_id,
                    tumor_grade = m.tumor_grade
                FROM spe.material AS m
                WHERE s.id = m.specimen_id;
            ");

            migrationBuilder.DropForeignKey(
                name: "FK_material_material_type_type_id",
                schema: "spe",
                table: "material");

            migrationBuilder.DropForeignKey(
                name: "FK_material_tumor_type_tumor_type_id",
                schema: "spe",
                table: "material");

            migrationBuilder.DropTable(
                name: "material_type",
                schema: "spe");

            migrationBuilder.DropIndex(
                name: "IX_material_tumor_type_id",
                schema: "spe",
                table: "material");

            migrationBuilder.DropIndex(
                name: "IX_material_type_id",
                schema: "spe",
                table: "material");

            migrationBuilder.DropColumn(
                name: "tumor_grade",
                schema: "spe",
                table: "material");

            migrationBuilder.DropColumn(
                name: "tumor_type_id",
                schema: "spe",
                table: "material");

            migrationBuilder.DropColumn(
                name: "type_id",
                schema: "spe",
                table: "material");   
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "tumor_grade",
                schema: "spe",
                table: "material",
                type: "smallint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tumor_type_id",
                schema: "spe",
                table: "material",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "type_id",
                schema: "spe",
                table: "material",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "material_type",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_material_type", x => x.id);
                    table.UniqueConstraint("AK_material_type_value", x => x.value);
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "material_type",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "Normal", "Normal" },
                    { 2, "Tumor", "Tumor" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_material_tumor_type_id",
                schema: "spe",
                table: "material",
                column: "tumor_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_material_type_id",
                schema: "spe",
                table: "material",
                column: "type_id");

            migrationBuilder.AddForeignKey(
                name: "FK_material_material_type_type_id",
                schema: "spe",
                table: "material",
                column: "type_id",
                principalSchema: "spe",
                principalTable: "material_type",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_material_tumor_type_tumor_type_id",
                schema: "spe",
                table: "material",
                column: "tumor_type_id",
                principalSchema: "spe",
                principalTable: "tumor_type",
                principalColumn: "id");

            // Migrate data back from specimen table to material table
            migrationBuilder.Sql(@"
                UPDATE spe.material AS m
                SET 
                    type_id = s.condition_id,
                    tumor_type_id = s.tumor_type_id,
                    tumor_grade = s.tumor_grade
                FROM spe.specimen AS s
                WHERE m.specimen_id = s.id;
            ");

            migrationBuilder.DropForeignKey(
                name: "FK_specimen_condition_condition_id",
                schema: "spe",
                table: "specimen");

            migrationBuilder.DropForeignKey(
                name: "FK_specimen_tumor_type_tumor_type_id",
                schema: "spe",
                table: "specimen");

            migrationBuilder.DropTable(
                name: "condition",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "tumor_classification",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "tumor_class",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "tumor_family",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "tumor_subclass",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "tumor_superfamily",
                schema: "spe");

            migrationBuilder.DropIndex(
                name: "IX_specimen_condition_id",
                schema: "spe",
                table: "specimen");

            migrationBuilder.DropIndex(
                name: "IX_specimen_tumor_type_id",
                schema: "spe",
                table: "specimen");

            migrationBuilder.DropColumn(
                name: "condition_id",
                schema: "spe",
                table: "specimen");

            migrationBuilder.DropColumn(
                name: "tumor_grade",
                schema: "spe",
                table: "specimen");

            migrationBuilder.DropColumn(
                name: "tumor_type_id",
                schema: "spe",
                table: "specimen");
        }
    }
}
