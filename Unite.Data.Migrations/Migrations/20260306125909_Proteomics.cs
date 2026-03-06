using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Unite.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Proteomics : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "reads",
                schema: "omi",
                table: "gene_expression",
                newName: "raw");

            migrationBuilder.AddColumn<string>(
                name: "accession_id",
                schema: "omi",
                table: "protein",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "chromosome_id",
                schema: "omi",
                table: "protein",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "database",
                schema: "omi",
                table: "protein",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "description",
                schema: "omi",
                table: "protein",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "symbol",
                schema: "omi",
                table: "protein",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "normalized",
                schema: "omi",
                table: "gene_expression",
                type: "double precision",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "protein_expression",
                schema: "omi",
                columns: table => new
                {
                    sample_id = table.Column<int>(type: "integer", nullable: false),
                    protein_id = table.Column<int>(type: "integer", nullable: false),
                    raw = table.Column<double>(type: "double precision", nullable: false),
                    normalized = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_protein_expression", x => new { x.protein_id, x.sample_id });
                    table.ForeignKey(
                        name: "FK_protein_expression_protein_protein_id",
                        column: x => x.protein_id,
                        principalSchema: "omi",
                        principalTable: "protein",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_protein_expression_sample_sample_id",
                        column: x => x.sample_id,
                        principalSchema: "omi",
                        principalTable: "sample",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "omi",
                table: "analysis_type",
                columns: new[] { "id", "name", "value" },
                values: new object[] { 12, "Mass Spectrometry", "MS" });

            migrationBuilder.InsertData(
                schema: "com",
                table: "indexing_task_type",
                columns: new[] { "id", "name", "value" },
                values: new object[] { 10, "Protein", "Protein" });

            migrationBuilder.InsertData(
                schema: "com",
                table: "submission_task_types",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 340, "prot", "prot" },
                    { 341, "prot-exp", "prot-exp" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_protein_chromosome_id",
                schema: "omi",
                table: "protein",
                column: "chromosome_id");

            migrationBuilder.CreateIndex(
                name: "IX_protein_expression_sample_id",
                schema: "omi",
                table: "protein_expression",
                column: "sample_id");

            migrationBuilder.AddForeignKey(
                name: "FK_protein_chromosome_chromosome_id",
                schema: "omi",
                table: "protein",
                column: "chromosome_id",
                principalSchema: "omi",
                principalTable: "chromosome",
                principalColumn: "id");

            // Set chromosome values from associated transcript
            migrationBuilder.Sql(@"
                UPDATE omi.protein AS p
                SET chromosome_id = t.chromosome_id
                FROM omi.transcript AS t
                WHERE p.transcript_id = t.id;
            ");

            // Set normalized values: Log2(TPM + 1) for existing values
            migrationBuilder.Sql(@"
                UPDATE omi.gene_expression
                SET normalized = LOG(2.0, (tpm + 1)::numeric)
                WHERE tpm IS NOT NULL;
            ");

            // Make the normalized column non-nullable after populating it
            migrationBuilder.Sql(@"
                ALTER TABLE omi.gene_expression
                ALTER COLUMN normalized SET NOT NULL;
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_protein_chromosome_chromosome_id",
                schema: "omi",
                table: "protein");

            migrationBuilder.DropTable(
                name: "protein_expression",
                schema: "omi");

            migrationBuilder.DropIndex(
                name: "IX_protein_chromosome_id",
                schema: "omi",
                table: "protein");

            migrationBuilder.DeleteData(
                schema: "omi",
                table: "analysis_type",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "com",
                table: "indexing_task_type",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "com",
                table: "submission_task_types",
                keyColumn: "id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                schema: "com",
                table: "submission_task_types",
                keyColumn: "id",
                keyValue: 341);

            migrationBuilder.DropColumn(
                name: "accession_id",
                schema: "omi",
                table: "protein");

            migrationBuilder.DropColumn(
                name: "chromosome_id",
                schema: "omi",
                table: "protein");

            migrationBuilder.DropColumn(
                name: "database",
                schema: "omi",
                table: "protein");

            migrationBuilder.DropColumn(
                name: "description",
                schema: "omi",
                table: "protein");

            migrationBuilder.DropColumn(
                name: "symbol",
                schema: "omi",
                table: "protein");

            migrationBuilder.DropColumn(
                name: "normalized",
                schema: "omi",
                table: "gene_expression");

            migrationBuilder.RenameColumn(
                name: "raw",
                schema: "omi",
                table: "gene_expression",
                newName: "reads");
        }
    }
}
