using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Unite.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class SpecimenCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "condition",
                schema: "spe",
                newName: "category",
                newSchema: "spe");

            migrationBuilder.RenameColumn(
                name: "condition_id",
                schema: "spe",
                table: "specimen",
                newName: "category_id");

            migrationBuilder.RenameIndex(
                name: "IX_specimen_condition_id",
                schema: "spe",
                table: "specimen",
                newName: "IX_specimen_category_id");

            migrationBuilder.Sql("ALTER TABLE spe.category RENAME CONSTRAINT \"PK_condition\" TO \"PK_category\";");
            migrationBuilder.Sql("ALTER TABLE spe.category RENAME CONSTRAINT \"AK_condition_value\" TO \"AK_category_value\";");

            migrationBuilder.Sql("ALTER TABLE spe.specimen RENAME CONSTRAINT \"FK_specimen_condition_condition_id\" TO \"FK_specimen_category_category_id\";");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("ALTER TABLE spe.specimen RENAME CONSTRAINT \"FK_specimen_category_category_id\" TO \"FK_specimen_condition_condition_id\";");

            migrationBuilder.Sql("ALTER TABLE spe.category RENAME CONSTRAINT \"PK_category\" TO \"PK_condition\";");
            migrationBuilder.Sql("ALTER TABLE spe.category RENAME CONSTRAINT \"AK_category_value\" TO \"AK_condition_value\";");

            migrationBuilder.RenameIndex(
                name: "IX_specimen_category_id",
                schema: "spe",
                table: "specimen",
                newName: "IX_specimen_condition_id");

            migrationBuilder.RenameColumn(
                name: "category_id",
                schema: "spe",
                table: "specimen",
                newName: "condition_id");

            migrationBuilder.RenameTable(
                name: "category",
                schema: "spe",
                newName: "condition",
                newSchema: "spe");
        }
    }
}
