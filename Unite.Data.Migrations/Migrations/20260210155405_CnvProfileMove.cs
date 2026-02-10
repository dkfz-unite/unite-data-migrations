using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unite.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class CnvProfileMove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CnvProfiles_sample_SampleId",
                table: "CnvProfiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CnvProfiles",
                table: "CnvProfiles");

            migrationBuilder.RenameTable(
                name: "CnvProfiles",
                newName: "cnv_profile",
                newSchema: "omi");

            migrationBuilder.RenameIndex(
                name: "IX_CnvProfiles_SampleId",
                schema: "omi",
                table: "cnv_profile",
                newName: "IX_cnv_profile_SampleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cnv_profile",
                schema: "omi",
                table: "cnv_profile",
                column: "id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cnv_profile_sample_SampleId",
                schema: "omi",
                table: "cnv_profile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cnv_profile",
                schema: "omi",
                table: "cnv_profile");

            migrationBuilder.RenameTable(
                name: "cnv_profile",
                schema: "omi",
                newName: "CnvProfiles");

            migrationBuilder.RenameIndex(
                name: "IX_cnv_profile_SampleId",
                table: "CnvProfiles",
                newName: "IX_CnvProfiles_SampleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CnvProfiles",
                table: "CnvProfiles",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_CnvProfiles_sample_SampleId",
                table: "CnvProfiles",
                column: "SampleId",
                principalSchema: "omi",
                principalTable: "sample",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
