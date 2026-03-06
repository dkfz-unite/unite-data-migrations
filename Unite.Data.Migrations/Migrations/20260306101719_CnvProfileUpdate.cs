using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Unite.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class CnvProfileUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Update sample_id foreign key to CASCADE on delete
            migrationBuilder.Sql(@"
                ALTER TABLE omi.cnv_profile 
                DROP CONSTRAINT ""FK_cnv_profile_sample_sample_id""");

            migrationBuilder.Sql(@"
                ALTER TABLE omi.cnv_profile 
                ADD CONSTRAINT ""FK_cnv_profile_sample_sample_id"" 
                FOREIGN KEY (""sample_id"") 
                REFERENCES omi.sample(""id"") 
                ON DELETE CASCADE ON UPDATE NO ACTION");

            // Rename foreign key constraints using raw SQL (EF doesn't support RenameConstraint)
            migrationBuilder.Sql(@"
                ALTER TABLE omi.cnv_profile 
                RENAME CONSTRAINT ""FK_cnv_profile_chromosome_arm_chromosome_arm"" 
                TO ""FK_cnv_profile_chromosome_arm_chromosome_arm_id""");

            migrationBuilder.Sql(@"
                ALTER TABLE omi.cnv_profile 
                RENAME CONSTRAINT ""FK_cnv_profile_chromosome_chromosome"" 
                TO ""FK_cnv_profile_chromosome_chromosome_id""");

            // Rename columns
            migrationBuilder.RenameColumn(
                name: "chromosome_arm",
                schema: "omi",
                table: "cnv_profile",
                newName: "chromosome_id");

            migrationBuilder.RenameColumn(
                name: "chromosome",
                schema: "omi",
                table: "cnv_profile",
                newName: "chromosome_arm_id");

            // Rename indexes
            migrationBuilder.RenameIndex(
                name: "IX_cnv_profile_chromosome_arm",
                schema: "omi",
                table: "cnv_profile",
                newName: "IX_cnv_profile_chromosome_id");

            migrationBuilder.RenameIndex(
                name: "IX_cnv_profile_chromosome",
                schema: "omi",
                table: "cnv_profile",
                newName: "IX_cnv_profile_chromosome_arm_id");

            // Alter column types
            migrationBuilder.AlterColumn<double>(
                name: "neutral",
                schema: "omi",
                table: "cnv_profile",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "loss",
                schema: "omi",
                table: "cnv_profile",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "gain",
                schema: "omi",
                table: "cnv_profile",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            // Update existing chromosome_arm data instead of deleting and re-inserting
            migrationBuilder.Sql(@"
                UPDATE omi.chromosome_arm 
                SET value = 'P' 
                WHERE id = 1 AND value = '1'");

            migrationBuilder.Sql(@"
                UPDATE omi.chromosome_arm 
                SET value = 'Q' 
                WHERE id = 2 AND value = '2'");

            // Update existing submission_task_types data instead of deleting and re-inserting
            migrationBuilder.Sql(@"
                UPDATE com.submission_task_types 
                SET value = 'dna-cnvp', name = 'dna-cnvp'
                WHERE id = 304 AND value = 'dna-cnv-profile'");

            // Insert new indexing task type
            migrationBuilder.InsertData(
                schema: "com",
                table: "indexing_task_type",
                columns: new[] { "id", "name", "value" },
                values: new object[] { 9, "CNVProfile", "CNVProfile" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Revert sample_id foreign key from CASCADE to RESTRICT
            migrationBuilder.Sql(@"
                ALTER TABLE omi.cnv_profile 
                DROP CONSTRAINT ""FK_cnv_profile_sample_sample_id""");

            migrationBuilder.Sql(@"
                ALTER TABLE omi.cnv_profile 
                ADD CONSTRAINT ""FK_cnv_profile_sample_sample_id"" 
                FOREIGN KEY (""sample_id"") 
                REFERENCES omi.sample(""id"") 
                ON DELETE RESTRICT ON UPDATE NO ACTION");

            // Delete the indexing task type that was inserted
            migrationBuilder.DeleteData(
                schema: "com",
                table: "indexing_task_type",
                keyColumn: "id",
                keyValue: 9);

            // Revert submission_task_types data update
            migrationBuilder.Sql(@"
                UPDATE com.submission_task_types 
                SET value = 'dna-cnv-profile', name = 'dna-cnv-profile'
                WHERE id = 304 AND value = 'dna-cnvp'");

            // Revert chromosome_arm data updates
            migrationBuilder.Sql(@"
                UPDATE omi.chromosome_arm 
                SET value = '1' 
                WHERE id = 1 AND value = 'P'");

            migrationBuilder.Sql(@"
                UPDATE omi.chromosome_arm 
                SET value = '2' 
                WHERE id = 2 AND value = 'Q'");

            // Revert column type changes
            migrationBuilder.AlterColumn<float>(
                name: "neutral",
                schema: "omi",
                table: "cnv_profile",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<float>(
                name: "loss",
                schema: "omi",
                table: "cnv_profile",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<float>(
                name: "gain",
                schema: "omi",
                table: "cnv_profile",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            // Rename indexes back
            migrationBuilder.RenameIndex(
                name: "IX_cnv_profile_chromosome_id",
                schema: "omi",
                table: "cnv_profile",
                newName: "IX_cnv_profile_chromosome_arm");

            migrationBuilder.RenameIndex(
                name: "IX_cnv_profile_chromosome_arm_id",
                schema: "omi",
                table: "cnv_profile",
                newName: "IX_cnv_profile_chromosome");

            // Rename columns back
            migrationBuilder.RenameColumn(
                name: "chromosome_id",
                schema: "omi",
                table: "cnv_profile",
                newName: "chromosome_arm");

            migrationBuilder.RenameColumn(
                name: "chromosome_arm_id",
                schema: "omi",
                table: "cnv_profile",
                newName: "chromosome");
        }
    }
}
