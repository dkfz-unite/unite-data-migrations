using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Unite.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Tert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 1) Add new schema (do not rename/drop first)
            migrationBuilder.AddColumn<bool>(
                name: "idh_status",
                schema: "spe",
                table: "molecular_data",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "mgmt_status",
                schema: "spe",
                table: "molecular_data",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "tert_status",
                schema: "spe",
                table: "molecular_data",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "expression_subtype_id",
                schema: "spe",
                table: "molecular_data",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tert_mutation_id",
                schema: "spe",
                table: "molecular_data",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "expression_subtype",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_expression_subtype", x => x.id);
                    table.UniqueConstraint("AK_expression_subtype_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "tert_mutation",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tert_mutation", x => x.id);
                    table.UniqueConstraint("AK_tert_mutation_value", x => x.value);
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "expression_subtype",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "Classical", "Classical" },
                    { 2, "Mesenchymal", "Mesenchymal" },
                    { 3, "Proneural", "Proneural" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "tert_mutation",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "C228T", "C228T" },
                    { 2, "C250T", "C250T" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_molecular_data_expression_subtype_id",
                schema: "spe",
                table: "molecular_data",
                column: "expression_subtype_id");

            migrationBuilder.CreateIndex(
                name: "IX_molecular_data_tert_mutation_id",
                schema: "spe",
                table: "molecular_data",
                column: "tert_mutation_id");

            migrationBuilder.AddForeignKey(
                name: "FK_molecular_data_expression_subtype_expression_subtype_id",
                schema: "spe",
                table: "molecular_data",
                column: "expression_subtype_id",
                principalSchema: "spe",
                principalTable: "expression_subtype",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_molecular_data_tert_mutation_tert_mutation_id",
                schema: "spe",
                table: "molecular_data",
                column: "tert_mutation_id",
                principalSchema: "spe",
                principalTable: "tert_mutation",
                principalColumn: "id");

            // 2) Migrate data from old schema to new
            // idh_status: Wild Type (1) -> false; Mutant (2) -> true; else NULL
            migrationBuilder.Sql(@"
                UPDATE spe.molecular_data
                SET idh_status = CASE
                    WHEN idh_status_id = 2 THEN TRUE
                    WHEN idh_status_id = 1 THEN FALSE
                    ELSE NULL
                END;
            ");

            // mgmt_status: Unmethylated (1) -> false; Methylated (2) -> true; else NULL
            migrationBuilder.Sql(@"
                UPDATE spe.molecular_data
                SET mgmt_status = CASE
                    WHEN mgmt_status_id = 2 THEN TRUE
                    WHEN mgmt_status_id = 1 THEN FALSE
                    ELSE NULL
                END;
            ");

            // expression_subtype_id takes values from gene_expression_subtype_id
            migrationBuilder.Sql(@"
                UPDATE spe.molecular_data
                SET expression_subtype_id = gene_expression_subtype_id;
            ");

            // 3) Remove old schema
            migrationBuilder.DropForeignKey(
                name: "FK_molecular_data_gene_expression_subtype_gene_expression_subt~",
                schema: "spe",
                table: "molecular_data");

            migrationBuilder.DropForeignKey(
                name: "FK_molecular_data_idh_status_idh_status_id",
                schema: "spe",
                table: "molecular_data");

            migrationBuilder.DropForeignKey(
                name: "FK_molecular_data_mgmt_status_mgmt_status_id",
                schema: "spe",
                table: "molecular_data");

            migrationBuilder.DropIndex(
                name: "IX_molecular_data_gene_expression_subtype_id",
                schema: "spe",
                table: "molecular_data");

            migrationBuilder.DropColumn(
                name: "gene_expression_subtype_id",
                schema: "spe",
                table: "molecular_data");

            migrationBuilder.DropColumn(
                name: "idh_status_id",
                schema: "spe",
                table: "molecular_data");

            migrationBuilder.DropColumn(
                name: "mgmt_status_id",
                schema: "spe",
                table: "molecular_data");

            migrationBuilder.DropTable(
                name: "gene_expression_subtype",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "idh_status",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "mgmt_status",
                schema: "spe");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remove new FKs and tables first
            migrationBuilder.DropForeignKey(
                name: "FK_molecular_data_expression_subtype_expression_subtype_id",
                schema: "spe",
                table: "molecular_data");

            migrationBuilder.DropForeignKey(
                name: "FK_molecular_data_tert_mutation_tert_mutation_id",
                schema: "spe",
                table: "molecular_data");

            migrationBuilder.DropTable(
                name: "expression_subtype",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "tert_mutation",
                schema: "spe");

            // Restore old columns
            migrationBuilder.AddColumn<int>(
                name: "gene_expression_subtype_id",
                schema: "spe",
                table: "molecular_data",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idh_status_id",
                schema: "spe",
                table: "molecular_data",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "mgmt_status_id",
                schema: "spe",
                table: "molecular_data",
                type: "integer",
                nullable: true);

            // Recreate old lookup tables
            migrationBuilder.CreateTable(
                name: "gene_expression_subtype",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gene_expression_subtype", x => x.id);
                    table.UniqueConstraint("AK_gene_expression_subtype_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "idh_status",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_idh_status", x => x.id);
                    table.UniqueConstraint("AK_idh_status_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "mgmt_status",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mgmt_status", x => x.id);
                    table.UniqueConstraint("AK_mgmt_status_value", x => x.value);
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "gene_expression_subtype",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "Classical", "Classical" },
                    { 2, "Mesenchymal", "Mesenchymal" },
                    { 3, "Proneural", "Proneural" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "idh_status",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "Wild Type", "Wild Type" },
                    { 2, "Mutant", "Mutant" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "mgmt_status",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "Unmethylated", "Unmethylated" },
                    { 2, "Methylated", "Methylated" }
                });

            // Rehydrate old IDs from new columns
            migrationBuilder.Sql(@"
                UPDATE spe.molecular_data
                SET gene_expression_subtype_id = expression_subtype_id;
            ");

            migrationBuilder.Sql(@"
                UPDATE spe.molecular_data
                SET idh_status_id = CASE
                    WHEN idh_status = TRUE THEN 2
                    WHEN idh_status = FALSE THEN 1
                    ELSE NULL
                END;
            ");

            migrationBuilder.Sql(@"
                UPDATE spe.molecular_data
                SET mgmt_status_id = CASE
                    WHEN mgmt_status = TRUE THEN 2
                    WHEN mgmt_status = FALSE THEN 1
                    ELSE NULL
                END;
            ");

            // Drop new columns after restoring the old ones
            migrationBuilder.DropColumn(
                name: "idh_status",
                schema: "spe",
                table: "molecular_data");

            migrationBuilder.DropColumn(
                name: "mgmt_status",
                schema: "spe",
                table: "molecular_data");

            migrationBuilder.DropColumn(
                name: "tert_status",
                schema: "spe",
                table: "molecular_data");

            migrationBuilder.DropColumn(
                name: "expression_subtype_id",
                schema: "spe",
                table: "molecular_data");

            migrationBuilder.DropColumn(
                name: "tert_mutation_id",
                schema: "spe",
                table: "molecular_data");

            migrationBuilder.CreateIndex(
                name: "IX_molecular_data_gene_expression_subtype_id",
                schema: "spe",
                table: "molecular_data",
                column: "gene_expression_subtype_id");

            migrationBuilder.AddForeignKey(
                name: "FK_molecular_data_gene_expression_subtype_gene_expression_subt~",
                schema: "spe",
                table: "molecular_data",
                column: "gene_expression_subtype_id",
                principalSchema: "spe",
                principalTable: "gene_expression_subtype",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_molecular_data_idh_status_idh_status_id",
                schema: "spe",
                table: "molecular_data",
                column: "idh_status_id",
                principalSchema: "spe",
                principalTable: "idh_status",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_molecular_data_mgmt_status_mgmt_status_id",
                schema: "spe",
                table: "molecular_data",
                column: "mgmt_status_id",
                principalSchema: "spe",
                principalTable: "mgmt_status",
                principalColumn: "id");
        }
    }
}
