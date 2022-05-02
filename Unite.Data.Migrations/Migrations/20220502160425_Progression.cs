using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Unite.Data.Migrations.Migrations
{
    public partial class Progression : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProgressionStatus",
                schema: "don",
                table: "Treatments");

            migrationBuilder.DropColumn(
                name: "ProgressionStatusChangeDate",
                schema: "don",
                table: "Treatments");

            migrationBuilder.DropColumn(
                name: "ProgressionStatusChangeDay",
                schema: "don",
                table: "Treatments");

            migrationBuilder.AddColumn<bool>(
                name: "ProgressionStatus",
                schema: "don",
                table: "ClinicalData",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ProgressionStatusChangeDate",
                schema: "don",
                table: "ClinicalData",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProgressionStatusChangeDay",
                schema: "don",
                table: "ClinicalData",
                type: "integer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProgressionStatus",
                schema: "don",
                table: "ClinicalData");

            migrationBuilder.DropColumn(
                name: "ProgressionStatusChangeDate",
                schema: "don",
                table: "ClinicalData");

            migrationBuilder.DropColumn(
                name: "ProgressionStatusChangeDay",
                schema: "don",
                table: "ClinicalData");

            migrationBuilder.AddColumn<bool>(
                name: "ProgressionStatus",
                schema: "don",
                table: "Treatments",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ProgressionStatusChangeDate",
                schema: "don",
                table: "Treatments",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProgressionStatusChangeDay",
                schema: "don",
                table: "Treatments",
                type: "integer",
                nullable: true);
        }
    }
}
