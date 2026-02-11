using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unite.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class CnvProfile_RenameColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cnv_profile_sample_SampleId",
                schema: "omi",
                table: "cnv_profile");

            migrationBuilder.RenameColumn(
                name: "Neutral",
                schema: "omi",
                table: "cnv_profile",
                newName: "neutral");

            migrationBuilder.RenameColumn(
                name: "Loss",
                schema: "omi",
                table: "cnv_profile",
                newName: "loss");

            migrationBuilder.RenameColumn(
                name: "Gain",
                schema: "omi",
                table: "cnv_profile",
                newName: "gain");

            migrationBuilder.RenameColumn(
                name: "Chromosome",
                schema: "omi",
                table: "cnv_profile",
                newName: "chromosome");

            migrationBuilder.RenameColumn(
                name: "SampleId",
                schema: "omi",
                table: "cnv_profile",
                newName: "sample_id");

            migrationBuilder.RenameColumn(
                name: "ChromosomeArm",
                schema: "omi",
                table: "cnv_profile",
                newName: "chromosome_arm");

            migrationBuilder.RenameIndex(
                name: "IX_cnv_profile_SampleId",
                schema: "omi",
                table: "cnv_profile",
                newName: "IX_cnv_profile_sample_id");

            migrationBuilder.AddForeignKey(
                name: "FK_cnv_profile_sample_sample_id",
                schema: "omi",
                table: "cnv_profile",
                column: "sample_id",
                principalSchema: "omi",
                principalTable: "sample",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cnv_profile_sample_sample_id",
                schema: "omi",
                table: "cnv_profile");

            migrationBuilder.RenameColumn(
                name: "neutral",
                schema: "omi",
                table: "cnv_profile",
                newName: "Neutral");

            migrationBuilder.RenameColumn(
                name: "loss",
                schema: "omi",
                table: "cnv_profile",
                newName: "Loss");

            migrationBuilder.RenameColumn(
                name: "gain",
                schema: "omi",
                table: "cnv_profile",
                newName: "Gain");

            migrationBuilder.RenameColumn(
                name: "chromosome",
                schema: "omi",
                table: "cnv_profile",
                newName: "Chromosome");

            migrationBuilder.RenameColumn(
                name: "sample_id",
                schema: "omi",
                table: "cnv_profile",
                newName: "SampleId");

            migrationBuilder.RenameColumn(
                name: "chromosome_arm",
                schema: "omi",
                table: "cnv_profile",
                newName: "ChromosomeArm");

            migrationBuilder.RenameIndex(
                name: "IX_cnv_profile_sample_id",
                schema: "omi",
                table: "cnv_profile",
                newName: "IX_cnv_profile_SampleId");

            migrationBuilder.AddForeignKey(
                name: "FK_cnv_profile_sample_SampleId",
                schema: "omi",
                table: "cnv_profile",
                column: "SampleId",
                principalSchema: "omi",
                principalTable: "sample",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
