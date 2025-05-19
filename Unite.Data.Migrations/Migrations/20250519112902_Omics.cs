using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unite.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Omics : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "omi");

            migrationBuilder.RenameTable(
                name: "transcript",
                schema: "gen",
                newName: "transcript",
                newSchema: "omi");

            migrationBuilder.RenameTable(
                name: "sv_type",
                schema: "gen",
                newName: "sv_type",
                newSchema: "omi");

            migrationBuilder.RenameTable(
                name: "sv_entry",
                schema: "gen",
                newName: "sv_entry",
                newSchema: "omi");

            migrationBuilder.RenameTable(
                name: "sv_affected_transcript",
                schema: "gen",
                newName: "sv_affected_transcript",
                newSchema: "omi");

            migrationBuilder.RenameTable(
                name: "sv",
                schema: "gen",
                newName: "sv",
                newSchema: "omi");

            migrationBuilder.RenameTable(
                name: "sm_type",
                schema: "gen",
                newName: "sm_type",
                newSchema: "omi");

            migrationBuilder.RenameTable(
                name: "sm_entry",
                schema: "gen",
                newName: "sm_entry",
                newSchema: "omi");

            migrationBuilder.RenameTable(
                name: "sm_affected_transcript",
                schema: "gen",
                newName: "sm_affected_transcript",
                newSchema: "omi");

            migrationBuilder.RenameTable(
                name: "sm",
                schema: "gen",
                newName: "sm",
                newSchema: "omi");

            migrationBuilder.RenameTable(
                name: "sample_resource",
                schema: "gen",
                newName: "sample_resource",
                newSchema: "omi");

            migrationBuilder.RenameTable(
                name: "sample",
                schema: "gen",
                newName: "sample",
                newSchema: "omi");

            migrationBuilder.RenameTable(
                name: "protein",
                schema: "gen",
                newName: "protein",
                newSchema: "omi");

            migrationBuilder.RenameTable(
                name: "gene_expression",
                schema: "gen",
                newName: "gene_expression",
                newSchema: "omi");

            migrationBuilder.RenameTable(
                name: "gene",
                schema: "gen",
                newName: "gene",
                newSchema: "omi");

            migrationBuilder.RenameTable(
                name: "cnv_type",
                schema: "gen",
                newName: "cnv_type",
                newSchema: "omi");

            migrationBuilder.RenameTable(
                name: "cnv_entry",
                schema: "gen",
                newName: "cnv_entry",
                newSchema: "omi");

            migrationBuilder.RenameTable(
                name: "cnv_affected_transcript",
                schema: "gen",
                newName: "cnv_affected_transcript",
                newSchema: "omi");

            migrationBuilder.RenameTable(
                name: "cnv",
                schema: "gen",
                newName: "cnv",
                newSchema: "omi");

            migrationBuilder.RenameTable(
                name: "chromosome",
                schema: "gen",
                newName: "chromosome",
                newSchema: "omi");

            migrationBuilder.RenameTable(
                name: "analysis_type",
                schema: "gen",
                newName: "analysis_type",
                newSchema: "omi");

            migrationBuilder.RenameTable(
                name: "analysis",
                schema: "gen",
                newName: "analysis",
                newSchema: "omi");

            migrationBuilder.RenameIndex(
                name: "IX_sample_analysis_id1",
                schema: "img",
                table: "sample",
                newName: "IX_sample_analysis_id");

            migrationBuilder.RenameIndex(
                name: "IX_analysis_type_id1",
                schema: "img",
                table: "analysis",
                newName: "IX_analysis_type_id");

            migrationBuilder.RenameIndex(
                name: "IX_sample_analysis_id",
                schema: "omi",
                table: "sample",
                newName: "IX_sample_analysis_id1");

            migrationBuilder.RenameIndex(
                name: "IX_analysis_type_id",
                schema: "omi",
                table: "analysis",
                newName: "IX_analysis_type_id1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "gen");

            migrationBuilder.RenameTable(
                name: "transcript",
                schema: "omi",
                newName: "transcript",
                newSchema: "gen");

            migrationBuilder.RenameTable(
                name: "sv_type",
                schema: "omi",
                newName: "sv_type",
                newSchema: "gen");

            migrationBuilder.RenameTable(
                name: "sv_entry",
                schema: "omi",
                newName: "sv_entry",
                newSchema: "gen");

            migrationBuilder.RenameTable(
                name: "sv_affected_transcript",
                schema: "omi",
                newName: "sv_affected_transcript",
                newSchema: "gen");

            migrationBuilder.RenameTable(
                name: "sv",
                schema: "omi",
                newName: "sv",
                newSchema: "gen");

            migrationBuilder.RenameTable(
                name: "sm_type",
                schema: "omi",
                newName: "sm_type",
                newSchema: "gen");

            migrationBuilder.RenameTable(
                name: "sm_entry",
                schema: "omi",
                newName: "sm_entry",
                newSchema: "gen");

            migrationBuilder.RenameTable(
                name: "sm_affected_transcript",
                schema: "omi",
                newName: "sm_affected_transcript",
                newSchema: "gen");

            migrationBuilder.RenameTable(
                name: "sm",
                schema: "omi",
                newName: "sm",
                newSchema: "gen");

            migrationBuilder.RenameTable(
                name: "sample_resource",
                schema: "omi",
                newName: "sample_resource",
                newSchema: "gen");

            migrationBuilder.RenameTable(
                name: "sample",
                schema: "omi",
                newName: "sample",
                newSchema: "gen");

            migrationBuilder.RenameTable(
                name: "protein",
                schema: "omi",
                newName: "protein",
                newSchema: "gen");

            migrationBuilder.RenameTable(
                name: "gene_expression",
                schema: "omi",
                newName: "gene_expression",
                newSchema: "gen");

            migrationBuilder.RenameTable(
                name: "gene",
                schema: "omi",
                newName: "gene",
                newSchema: "gen");

            migrationBuilder.RenameTable(
                name: "cnv_type",
                schema: "omi",
                newName: "cnv_type",
                newSchema: "gen");

            migrationBuilder.RenameTable(
                name: "cnv_entry",
                schema: "omi",
                newName: "cnv_entry",
                newSchema: "gen");

            migrationBuilder.RenameTable(
                name: "cnv_affected_transcript",
                schema: "omi",
                newName: "cnv_affected_transcript",
                newSchema: "gen");

            migrationBuilder.RenameTable(
                name: "cnv",
                schema: "omi",
                newName: "cnv",
                newSchema: "gen");

            migrationBuilder.RenameTable(
                name: "chromosome",
                schema: "omi",
                newName: "chromosome",
                newSchema: "gen");

            migrationBuilder.RenameTable(
                name: "analysis_type",
                schema: "omi",
                newName: "analysis_type",
                newSchema: "gen");

            migrationBuilder.RenameTable(
                name: "analysis",
                schema: "omi",
                newName: "analysis",
                newSchema: "gen");

            migrationBuilder.RenameIndex(
                name: "IX_sample_analysis_id",
                schema: "img",
                table: "sample",
                newName: "IX_sample_analysis_id1");

            migrationBuilder.RenameIndex(
                name: "IX_analysis_type_id",
                schema: "img",
                table: "analysis",
                newName: "IX_analysis_type_id1");

            migrationBuilder.RenameIndex(
                name: "IX_sample_analysis_id1",
                schema: "gen",
                table: "sample",
                newName: "IX_sample_analysis_id");

            migrationBuilder.RenameIndex(
                name: "IX_analysis_type_id1",
                schema: "gen",
                table: "analysis",
                newName: "IX_analysis_type_id");
        }
    }
}
