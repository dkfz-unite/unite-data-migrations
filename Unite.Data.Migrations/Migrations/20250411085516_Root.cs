using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Unite.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Root : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "gen");

            migrationBuilder.EnsureSchema(
                name: "img");

            migrationBuilder.EnsureSchema(
                name: "spe");

            migrationBuilder.EnsureSchema(
                name: "com");

            migrationBuilder.EnsureSchema(
                name: "don");

            migrationBuilder.CreateTable(
                name: "analysis_task_type",
                schema: "com",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_analysis_task_type", x => x.id);
                    table.UniqueConstraint("AK_analysis_task_type_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "analysis_type",
                schema: "gen",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_analysis_type", x => x.id);
                    table.UniqueConstraint("AK_analysis_type_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "analysis_type",
                schema: "img",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_analysis_type", x => x.id);
                    table.UniqueConstraint("AK_analysis_type_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "analysis_type",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_analysis_type", x => x.id);
                    table.UniqueConstraint("AK_analysis_type_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "annotation_task_type",
                schema: "com",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_annotation_task_type", x => x.id);
                    table.UniqueConstraint("AK_annotation_task_type_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "cells_culture_type",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cells_culture_type", x => x.id);
                    table.UniqueConstraint("AK_cells_culture_type_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "cells_species",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cells_species", x => x.id);
                    table.UniqueConstraint("AK_cells_species_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "cells_type",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cells_type", x => x.id);
                    table.UniqueConstraint("AK_cells_type_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "chromosome",
                schema: "gen",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chromosome", x => x.id);
                    table.UniqueConstraint("AK_chromosome_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "cnv_type",
                schema: "gen",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cnv_type", x => x.id);
                    table.UniqueConstraint("AK_cnv_type_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "donor",
                schema: "don",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    reference_id = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    mta_protected = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_donor", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "drug",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drug", x => x.id);
                    table.UniqueConstraint("AK_drug_name", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "fixation_type",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fixation_type", x => x.id);
                    table.UniqueConstraint("AK_fixation_type_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "gene_expression_subtype",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gene_expression_subtype", x => x.id);
                    table.UniqueConstraint("AK_gene_expression_subtype_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "idh_mutation",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_idh_mutation", x => x.id);
                    table.UniqueConstraint("AK_idh_mutation_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "idh_status",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_idh_status", x => x.id);
                    table.UniqueConstraint("AK_idh_status_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "image_type",
                schema: "img",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_image_type", x => x.id);
                    table.UniqueConstraint("AK_image_type_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "implant_location",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_implant_location", x => x.id);
                    table.UniqueConstraint("AK_implant_location_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "implant_type",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_implant_type", x => x.id);
                    table.UniqueConstraint("AK_implant_type_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "indexing_task_type",
                schema: "com",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_indexing_task_type", x => x.id);
                    table.UniqueConstraint("AK_indexing_task_type_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "intervention_type",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_intervention_type", x => x.id);
                    table.UniqueConstraint("AK_intervention_type_name", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "material_source",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_material_source", x => x.id);
                    table.UniqueConstraint("AK_material_source_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "material_type",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_material_type", x => x.id);
                    table.UniqueConstraint("AK_material_type_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "methylation_subtype",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_methylation_subtype", x => x.id);
                    table.UniqueConstraint("AK_methylation_subtype_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "mgmt_status",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mgmt_status", x => x.id);
                    table.UniqueConstraint("AK_mgmt_status_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "project",
                schema: "don",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_project", x => x.id);
                    table.UniqueConstraint("AK_project_name", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "radiomics_feature",
                schema: "img",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_radiomics_feature", x => x.id);
                    table.UniqueConstraint("AK_radiomics_feature_name", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "sex",
                schema: "don",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sex", x => x.id);
                    table.UniqueConstraint("AK_sex_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "sm_type",
                schema: "gen",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sm_type", x => x.id);
                    table.UniqueConstraint("AK_sm_type_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "specimen_type",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_specimen_type", x => x.id);
                    table.UniqueConstraint("AK_specimen_type_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "study",
                schema: "don",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_study", x => x.id);
                    table.UniqueConstraint("AK_study_name", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "submission_task_types",
                schema: "com",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_submission_task_types", x => x.id);
                    table.UniqueConstraint("AK_submission_task_types_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "sv_type",
                schema: "gen",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sv_type", x => x.id);
                    table.UniqueConstraint("AK_sv_type_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "task_status_type",
                schema: "com",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_task_status_type", x => x.id);
                    table.UniqueConstraint("AK_task_status_type_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "therapy",
                schema: "don",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_therapy", x => x.id);
                    table.UniqueConstraint("AK_therapy_name", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "tumor_growth_form",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tumor_growth_form", x => x.id);
                    table.UniqueConstraint("AK_tumor_growth_form_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "tumor_localization",
                schema: "don",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tumor_localization", x => x.id);
                    table.UniqueConstraint("AK_tumor_localization_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "tumor_primary_site",
                schema: "don",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tumor_primary_site", x => x.id);
                    table.UniqueConstraint("AK_tumor_primary_site_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "tumor_type",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tumor_type", x => x.id);
                    table.UniqueConstraint("AK_tumor_type_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "worker_type",
                schema: "com",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_worker_type", x => x.id);
                    table.UniqueConstraint("AK_worker_type_value", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "analysis",
                schema: "gen",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<DateOnly>(type: "date", nullable: true),
                    day = table.Column<int>(type: "integer", nullable: true),
                    parameters = table.Column<string>(type: "text", nullable: true),
                    type_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_analysis", x => x.id);
                    table.ForeignKey(
                        name: "FK_analysis_analysis_type_type_id",
                        column: x => x.type_id,
                        principalSchema: "gen",
                        principalTable: "analysis_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "analysis",
                schema: "img",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<DateOnly>(type: "date", nullable: true),
                    day = table.Column<int>(type: "integer", nullable: true),
                    parameters = table.Column<string>(type: "text", nullable: true),
                    type_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_analysis", x => x.id);
                    table.ForeignKey(
                        name: "FK_analysis_analysis_type_type_id",
                        column: x => x.type_id,
                        principalSchema: "img",
                        principalTable: "analysis_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "analysis",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<DateOnly>(type: "date", nullable: true),
                    day = table.Column<int>(type: "integer", nullable: true),
                    parameters = table.Column<string>(type: "text", nullable: true),
                    type_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_analysis", x => x.id);
                    table.ForeignKey(
                        name: "FK_analysis_analysis_type_type_id",
                        column: x => x.type_id,
                        principalSchema: "spe",
                        principalTable: "analysis_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gene",
                schema: "gen",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    stable_id = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    chromosome_id = table.Column<int>(type: "integer", nullable: true),
                    start = table.Column<int>(type: "integer", nullable: true),
                    end = table.Column<int>(type: "integer", nullable: true),
                    strand = table.Column<bool>(type: "boolean", nullable: true),
                    exonic_length = table.Column<int>(type: "integer", nullable: true),
                    symbol = table.Column<string>(type: "text", nullable: true),
                    biotype = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gene", x => x.id);
                    table.UniqueConstraint("AK_gene_stable_id", x => x.stable_id);
                    table.ForeignKey(
                        name: "FK_gene_chromosome_chromosome_id",
                        column: x => x.chromosome_id,
                        principalSchema: "gen",
                        principalTable: "chromosome",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "cnv",
                schema: "gen",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    type_id = table.Column<int>(type: "integer", nullable: false),
                    loh = table.Column<bool>(type: "boolean", nullable: true),
                    del = table.Column<bool>(type: "boolean", nullable: true),
                    c1_mean = table.Column<double>(type: "double precision", nullable: true),
                    c2_mean = table.Column<double>(type: "double precision", nullable: true),
                    tcn_mean = table.Column<double>(type: "double precision", nullable: true),
                    c1 = table.Column<int>(type: "integer", nullable: true),
                    c2 = table.Column<int>(type: "integer", nullable: true),
                    tcn = table.Column<int>(type: "integer", nullable: true),
                    tcn_ratio = table.Column<double>(type: "double precision", nullable: true),
                    dh_max = table.Column<double>(type: "double precision", nullable: true),
                    chromosome_id = table.Column<int>(type: "integer", nullable: false),
                    start = table.Column<int>(type: "integer", nullable: false),
                    end = table.Column<int>(type: "integer", nullable: false),
                    length = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cnv", x => x.id);
                    table.ForeignKey(
                        name: "FK_cnv_chromosome_chromosome_id",
                        column: x => x.chromosome_id,
                        principalSchema: "gen",
                        principalTable: "chromosome",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cnv_cnv_type_type_id",
                        column: x => x.type_id,
                        principalSchema: "gen",
                        principalTable: "cnv_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "image",
                schema: "img",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    reference_id = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    donor_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateOnly>(type: "date", nullable: true),
                    creation_day = table.Column<int>(type: "integer", nullable: true),
                    type_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_image", x => x.id);
                    table.ForeignKey(
                        name: "FK_image_donor_donor_id",
                        column: x => x.donor_id,
                        principalSchema: "don",
                        principalTable: "donor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_image_image_type_type_id",
                        column: x => x.type_id,
                        principalSchema: "img",
                        principalTable: "image_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "project_donor",
                schema: "don",
                columns: table => new
                {
                    donor_id = table.Column<int>(type: "integer", nullable: false),
                    project_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_project_donor", x => new { x.project_id, x.donor_id });
                    table.ForeignKey(
                        name: "FK_project_donor_donor_donor_id",
                        column: x => x.donor_id,
                        principalSchema: "don",
                        principalTable: "donor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_project_donor_project_project_id",
                        column: x => x.project_id,
                        principalSchema: "don",
                        principalTable: "project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sm",
                schema: "gen",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    type_id = table.Column<int>(type: "integer", nullable: false),
                    @ref = table.Column<string>(name: "ref", type: "character varying(200)", maxLength: 200, nullable: true),
                    alt = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    chromosome_id = table.Column<int>(type: "integer", nullable: false),
                    start = table.Column<int>(type: "integer", nullable: false),
                    end = table.Column<int>(type: "integer", nullable: false),
                    length = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sm", x => x.id);
                    table.ForeignKey(
                        name: "FK_sm_chromosome_chromosome_id",
                        column: x => x.chromosome_id,
                        principalSchema: "gen",
                        principalTable: "chromosome",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sm_sm_type_type_id",
                        column: x => x.type_id,
                        principalSchema: "gen",
                        principalTable: "sm_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "specimen",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    parent_id = table.Column<int>(type: "integer", nullable: true),
                    reference_id = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    donor_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateOnly>(type: "date", nullable: true),
                    creation_day = table.Column<int>(type: "integer", nullable: true),
                    type_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_specimen", x => x.id);
                    table.ForeignKey(
                        name: "FK_specimen_donor_donor_id",
                        column: x => x.donor_id,
                        principalSchema: "don",
                        principalTable: "donor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_specimen_specimen_parent_id",
                        column: x => x.parent_id,
                        principalSchema: "spe",
                        principalTable: "specimen",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_specimen_specimen_type_type_id",
                        column: x => x.type_id,
                        principalSchema: "spe",
                        principalTable: "specimen_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "study_donor",
                schema: "don",
                columns: table => new
                {
                    donor_id = table.Column<int>(type: "integer", nullable: false),
                    study_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_study_donor", x => new { x.study_id, x.donor_id });
                    table.ForeignKey(
                        name: "FK_study_donor_donor_donor_id",
                        column: x => x.donor_id,
                        principalSchema: "don",
                        principalTable: "donor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_study_donor_study_study_id",
                        column: x => x.study_id,
                        principalSchema: "don",
                        principalTable: "study",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sv",
                schema: "gen",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    other_chromosome_id = table.Column<int>(type: "integer", nullable: false),
                    other_start = table.Column<int>(type: "integer", nullable: false),
                    other_end = table.Column<int>(type: "integer", nullable: false),
                    type_id = table.Column<int>(type: "integer", nullable: false),
                    inverted = table.Column<bool>(type: "boolean", nullable: true),
                    flanking_sequence_from = table.Column<string>(type: "text", nullable: true),
                    flanking_sequence_to = table.Column<string>(type: "text", nullable: true),
                    chromosome_id = table.Column<int>(type: "integer", nullable: false),
                    start = table.Column<int>(type: "integer", nullable: false),
                    end = table.Column<int>(type: "integer", nullable: false),
                    length = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sv", x => x.id);
                    table.ForeignKey(
                        name: "FK_sv_chromosome_chromosome_id",
                        column: x => x.chromosome_id,
                        principalSchema: "gen",
                        principalTable: "chromosome",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sv_chromosome_other_chromosome_id",
                        column: x => x.other_chromosome_id,
                        principalSchema: "gen",
                        principalTable: "chromosome",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sv_sv_type_type_id",
                        column: x => x.type_id,
                        principalSchema: "gen",
                        principalTable: "sv_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "task",
                schema: "com",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    submission_type_id = table.Column<int>(type: "integer", nullable: true),
                    annotation_type_id = table.Column<int>(type: "integer", nullable: true),
                    indexing_type_id = table.Column<int>(type: "integer", nullable: true),
                    analysis_type_id = table.Column<int>(type: "integer", nullable: true),
                    task_status_type_id = table.Column<int>(type: "integer", nullable: true),
                    target = table.Column<string>(type: "text", nullable: false),
                    data = table.Column<string>(type: "text", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_task", x => x.id);
                    table.ForeignKey(
                        name: "FK_task_analysis_task_type_analysis_type_id",
                        column: x => x.analysis_type_id,
                        principalSchema: "com",
                        principalTable: "analysis_task_type",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_task_annotation_task_type_annotation_type_id",
                        column: x => x.annotation_type_id,
                        principalSchema: "com",
                        principalTable: "annotation_task_type",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_task_indexing_task_type_indexing_type_id",
                        column: x => x.indexing_type_id,
                        principalSchema: "com",
                        principalTable: "indexing_task_type",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_task_submission_task_types_submission_type_id",
                        column: x => x.submission_type_id,
                        principalSchema: "com",
                        principalTable: "submission_task_types",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_task_task_status_type_task_status_type_id",
                        column: x => x.task_status_type_id,
                        principalSchema: "com",
                        principalTable: "task_status_type",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "treatment",
                schema: "don",
                columns: table => new
                {
                    donor_id = table.Column<int>(type: "integer", nullable: false),
                    therapy_id = table.Column<int>(type: "integer", nullable: false),
                    details = table.Column<string>(type: "text", nullable: true),
                    start_date = table.Column<DateOnly>(type: "date", nullable: true),
                    start_day = table.Column<int>(type: "integer", nullable: true),
                    end_date = table.Column<DateOnly>(type: "date", nullable: true),
                    duration_days = table.Column<int>(type: "integer", nullable: true),
                    results = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_treatment", x => new { x.donor_id, x.therapy_id });
                    table.ForeignKey(
                        name: "FK_treatment_donor_donor_id",
                        column: x => x.donor_id,
                        principalSchema: "don",
                        principalTable: "donor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_treatment_therapy_therapy_id",
                        column: x => x.therapy_id,
                        principalSchema: "don",
                        principalTable: "therapy",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "clinical_data",
                schema: "don",
                columns: table => new
                {
                    donor_id = table.Column<int>(type: "integer", nullable: false),
                    sex_id = table.Column<int>(type: "integer", nullable: true),
                    enrollment_date = table.Column<DateOnly>(type: "date", nullable: true),
                    enrollment_age = table.Column<int>(type: "integer", nullable: true),
                    diagnosis = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    primary_site_id = table.Column<int>(type: "integer", nullable: true),
                    localization_id = table.Column<int>(type: "integer", nullable: true),
                    vital_status = table.Column<bool>(type: "boolean", nullable: true),
                    vital_status_change_date = table.Column<DateOnly>(type: "date", nullable: true),
                    vital_status_change_day = table.Column<int>(type: "integer", nullable: true),
                    progression_status = table.Column<bool>(type: "boolean", nullable: true),
                    progression_status_change_date = table.Column<DateOnly>(type: "date", nullable: true),
                    progression_status_change_day = table.Column<int>(type: "integer", nullable: true),
                    steroids_reactive = table.Column<bool>(type: "boolean", nullable: true),
                    kps = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clinical_data", x => x.donor_id);
                    table.ForeignKey(
                        name: "FK_clinical_data_donor_donor_id",
                        column: x => x.donor_id,
                        principalSchema: "don",
                        principalTable: "donor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_clinical_data_sex_sex_id",
                        column: x => x.sex_id,
                        principalSchema: "don",
                        principalTable: "sex",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_clinical_data_tumor_localization_localization_id",
                        column: x => x.localization_id,
                        principalSchema: "don",
                        principalTable: "tumor_localization",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_clinical_data_tumor_primary_site_primary_site_id",
                        column: x => x.primary_site_id,
                        principalSchema: "don",
                        principalTable: "tumor_primary_site",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "worker",
                schema: "com",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    type_id = table.Column<int>(type: "integer", nullable: false),
                    active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_worker", x => x.id);
                    table.ForeignKey(
                        name: "FK_worker_worker_type_type_id",
                        column: x => x.type_id,
                        principalSchema: "com",
                        principalTable: "worker_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "transcript",
                schema: "gen",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    stable_id = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    gene_id = table.Column<int>(type: "integer", nullable: true),
                    chromosome_id = table.Column<int>(type: "integer", nullable: true),
                    start = table.Column<int>(type: "integer", nullable: true),
                    end = table.Column<int>(type: "integer", nullable: true),
                    strand = table.Column<bool>(type: "boolean", nullable: true),
                    exonic_length = table.Column<int>(type: "integer", nullable: true),
                    symbol = table.Column<string>(type: "text", nullable: true),
                    biotype = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    is_canonical = table.Column<bool>(type: "boolean", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transcript", x => x.id);
                    table.UniqueConstraint("AK_transcript_stable_id", x => x.stable_id);
                    table.ForeignKey(
                        name: "FK_transcript_chromosome_chromosome_id",
                        column: x => x.chromosome_id,
                        principalSchema: "gen",
                        principalTable: "chromosome",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_transcript_gene_gene_id",
                        column: x => x.gene_id,
                        principalSchema: "gen",
                        principalTable: "gene",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "mr_image",
                schema: "img",
                columns: table => new
                {
                    image_id = table.Column<int>(type: "integer", nullable: false),
                    whole_tumor = table.Column<double>(type: "double precision", nullable: true),
                    contrast_enhancing = table.Column<double>(type: "double precision", nullable: true),
                    non_contrast_enhancing = table.Column<double>(type: "double precision", nullable: true),
                    median_adc_tumor = table.Column<double>(type: "double precision", nullable: true),
                    median_adc_ce = table.Column<double>(type: "double precision", nullable: true),
                    median_adc_edema = table.Column<double>(type: "double precision", nullable: true),
                    median_cbf_tumor = table.Column<double>(type: "double precision", nullable: true),
                    median_cbf_ce = table.Column<double>(type: "double precision", nullable: true),
                    median_cbf_edema = table.Column<double>(type: "double precision", nullable: true),
                    median_cbv_tumor = table.Column<double>(type: "double precision", nullable: true),
                    median_cbv_ce = table.Column<double>(type: "double precision", nullable: true),
                    median_cbv_edema = table.Column<double>(type: "double precision", nullable: true),
                    median_mtt_tumor = table.Column<double>(type: "double precision", nullable: true),
                    median_mtt_ce = table.Column<double>(type: "double precision", nullable: true),
                    median_mtt_edema = table.Column<double>(type: "double precision", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mr_image", x => x.image_id);
                    table.ForeignKey(
                        name: "FK_mr_image_image_image_id",
                        column: x => x.image_id,
                        principalSchema: "img",
                        principalTable: "image",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sample",
                schema: "img",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    image_id = table.Column<int>(type: "integer", nullable: false),
                    analysis_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sample", x => x.id);
                    table.ForeignKey(
                        name: "FK_sample_analysis_analysis_id",
                        column: x => x.analysis_id,
                        principalSchema: "img",
                        principalTable: "analysis",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sample_image_image_id",
                        column: x => x.image_id,
                        principalSchema: "img",
                        principalTable: "image",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "intervention",
                schema: "spe",
                columns: table => new
                {
                    specimen_id = table.Column<int>(type: "integer", nullable: false),
                    type_id = table.Column<int>(type: "integer", nullable: false),
                    details = table.Column<string>(type: "text", nullable: true),
                    start_date = table.Column<DateOnly>(type: "date", nullable: true),
                    start_day = table.Column<int>(type: "integer", nullable: true),
                    end_date = table.Column<DateOnly>(type: "date", nullable: true),
                    duration_days = table.Column<int>(type: "integer", nullable: true),
                    results = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_intervention", x => new { x.type_id, x.specimen_id });
                    table.ForeignKey(
                        name: "FK_intervention_intervention_type_type_id",
                        column: x => x.type_id,
                        principalSchema: "spe",
                        principalTable: "intervention_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_intervention_specimen_specimen_id",
                        column: x => x.specimen_id,
                        principalSchema: "spe",
                        principalTable: "specimen",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "line",
                schema: "spe",
                columns: table => new
                {
                    specimen_id = table.Column<int>(type: "integer", nullable: false),
                    cells_species_id = table.Column<int>(type: "integer", nullable: true),
                    cells_type_id = table.Column<int>(type: "integer", nullable: true),
                    cells_culture_type_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_line", x => x.specimen_id);
                    table.ForeignKey(
                        name: "FK_line_cells_culture_type_cells_culture_type_id",
                        column: x => x.cells_culture_type_id,
                        principalSchema: "spe",
                        principalTable: "cells_culture_type",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_line_cells_species_cells_species_id",
                        column: x => x.cells_species_id,
                        principalSchema: "spe",
                        principalTable: "cells_species",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_line_cells_type_cells_type_id",
                        column: x => x.cells_type_id,
                        principalSchema: "spe",
                        principalTable: "cells_type",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_line_specimen_specimen_id",
                        column: x => x.specimen_id,
                        principalSchema: "spe",
                        principalTable: "specimen",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "material",
                schema: "spe",
                columns: table => new
                {
                    specimen_id = table.Column<int>(type: "integer", nullable: false),
                    source_id = table.Column<int>(type: "integer", nullable: true),
                    type_id = table.Column<int>(type: "integer", nullable: true),
                    fixation_type_id = table.Column<int>(type: "integer", nullable: true),
                    tumor_type_id = table.Column<int>(type: "integer", nullable: true),
                    tumor_grade = table.Column<byte>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_material", x => x.specimen_id);
                    table.ForeignKey(
                        name: "FK_material_fixation_type_fixation_type_id",
                        column: x => x.fixation_type_id,
                        principalSchema: "spe",
                        principalTable: "fixation_type",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_material_material_source_source_id",
                        column: x => x.source_id,
                        principalSchema: "spe",
                        principalTable: "material_source",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_material_material_type_type_id",
                        column: x => x.type_id,
                        principalSchema: "spe",
                        principalTable: "material_type",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_material_specimen_specimen_id",
                        column: x => x.specimen_id,
                        principalSchema: "spe",
                        principalTable: "specimen",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_material_tumor_type_tumor_type_id",
                        column: x => x.tumor_type_id,
                        principalSchema: "spe",
                        principalTable: "tumor_type",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "molecular_data",
                schema: "spe",
                columns: table => new
                {
                    specimen_id = table.Column<int>(type: "integer", nullable: false),
                    mgmt_status_id = table.Column<int>(type: "integer", nullable: true),
                    idh_status_id = table.Column<int>(type: "integer", nullable: true),
                    idh_mutation_id = table.Column<int>(type: "integer", nullable: true),
                    gene_expression_subtype_id = table.Column<int>(type: "integer", nullable: true),
                    methylation_subtype_id = table.Column<int>(type: "integer", nullable: true),
                    gcimp_methylation = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_molecular_data", x => x.specimen_id);
                    table.ForeignKey(
                        name: "FK_molecular_data_gene_expression_subtype_gene_expression_subt~",
                        column: x => x.gene_expression_subtype_id,
                        principalSchema: "spe",
                        principalTable: "gene_expression_subtype",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_molecular_data_idh_mutation_idh_mutation_id",
                        column: x => x.idh_mutation_id,
                        principalSchema: "spe",
                        principalTable: "idh_mutation",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_molecular_data_idh_status_idh_status_id",
                        column: x => x.idh_status_id,
                        principalSchema: "spe",
                        principalTable: "idh_status",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_molecular_data_methylation_subtype_methylation_subtype_id",
                        column: x => x.methylation_subtype_id,
                        principalSchema: "spe",
                        principalTable: "methylation_subtype",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_molecular_data_mgmt_status_mgmt_status_id",
                        column: x => x.mgmt_status_id,
                        principalSchema: "spe",
                        principalTable: "mgmt_status",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_molecular_data_specimen_specimen_id",
                        column: x => x.specimen_id,
                        principalSchema: "spe",
                        principalTable: "specimen",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "organoid",
                schema: "spe",
                columns: table => new
                {
                    specimen_id = table.Column<int>(type: "integer", nullable: false),
                    implanted_cells_number = table.Column<int>(type: "integer", nullable: true),
                    tumorigenicity = table.Column<bool>(type: "boolean", nullable: true),
                    medium = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organoid", x => x.specimen_id);
                    table.ForeignKey(
                        name: "FK_organoid_specimen_specimen_id",
                        column: x => x.specimen_id,
                        principalSchema: "spe",
                        principalTable: "specimen",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sample",
                schema: "gen",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    matched_sample_id = table.Column<int>(type: "integer", nullable: true),
                    genome = table.Column<string>(type: "text", nullable: true),
                    purity = table.Column<double>(type: "double precision", nullable: true),
                    ploidy = table.Column<double>(type: "double precision", nullable: true),
                    cells = table.Column<int>(type: "integer", nullable: true),
                    specimen_id = table.Column<int>(type: "integer", nullable: false),
                    analysis_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sample", x => x.id);
                    table.ForeignKey(
                        name: "FK_sample_analysis_analysis_id",
                        column: x => x.analysis_id,
                        principalSchema: "gen",
                        principalTable: "analysis",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sample_sample_matched_sample_id",
                        column: x => x.matched_sample_id,
                        principalSchema: "gen",
                        principalTable: "sample",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_sample_specimen_specimen_id",
                        column: x => x.specimen_id,
                        principalSchema: "spe",
                        principalTable: "specimen",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sample",
                schema: "spe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    specimen_id = table.Column<int>(type: "integer", nullable: false),
                    analysis_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sample", x => x.id);
                    table.ForeignKey(
                        name: "FK_sample_analysis_analysis_id",
                        column: x => x.analysis_id,
                        principalSchema: "spe",
                        principalTable: "analysis",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sample_specimen_specimen_id",
                        column: x => x.specimen_id,
                        principalSchema: "spe",
                        principalTable: "specimen",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "xenograft",
                schema: "spe",
                columns: table => new
                {
                    specimen_id = table.Column<int>(type: "integer", nullable: false),
                    mouse_strain = table.Column<string>(type: "text", nullable: true),
                    group_size = table.Column<int>(type: "integer", nullable: true),
                    implant_type_id = table.Column<int>(type: "integer", nullable: true),
                    implant_location_id = table.Column<int>(type: "integer", nullable: true),
                    implanted_cells_number = table.Column<int>(type: "integer", nullable: true),
                    tumorigenicity = table.Column<bool>(type: "boolean", nullable: true),
                    tumor_growth_form_id = table.Column<int>(type: "integer", nullable: true),
                    survival_days_from = table.Column<int>(type: "integer", nullable: true),
                    survival_days_to = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_xenograft", x => x.specimen_id);
                    table.ForeignKey(
                        name: "FK_xenograft_implant_location_implant_location_id",
                        column: x => x.implant_location_id,
                        principalSchema: "spe",
                        principalTable: "implant_location",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_xenograft_implant_type_implant_type_id",
                        column: x => x.implant_type_id,
                        principalSchema: "spe",
                        principalTable: "implant_type",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_xenograft_specimen_specimen_id",
                        column: x => x.specimen_id,
                        principalSchema: "spe",
                        principalTable: "specimen",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_xenograft_tumor_growth_form_tumor_growth_form_id",
                        column: x => x.tumor_growth_form_id,
                        principalSchema: "spe",
                        principalTable: "tumor_growth_form",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "cnv_affected_transcript",
                schema: "gen",
                columns: table => new
                {
                    variant_id = table.Column<int>(type: "integer", nullable: false),
                    feature_id = table.Column<int>(type: "integer", nullable: false),
                    effects = table.Column<string>(type: "text", nullable: true),
                    distance = table.Column<int>(type: "integer", nullable: true),
                    overlap_bp_number = table.Column<int>(type: "integer", nullable: true),
                    overlap_percentage = table.Column<double>(type: "double precision", nullable: true),
                    cdna_start = table.Column<int>(type: "integer", nullable: true),
                    cdna_end = table.Column<int>(type: "integer", nullable: true),
                    cds_start = table.Column<int>(type: "integer", nullable: true),
                    cds_end = table.Column<int>(type: "integer", nullable: true),
                    aa_start = table.Column<int>(type: "integer", nullable: true),
                    aa_end = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cnv_affected_transcript", x => new { x.variant_id, x.feature_id });
                    table.ForeignKey(
                        name: "FK_cnv_affected_transcript_cnv_variant_id",
                        column: x => x.variant_id,
                        principalSchema: "gen",
                        principalTable: "cnv",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cnv_affected_transcript_transcript_feature_id",
                        column: x => x.feature_id,
                        principalSchema: "gen",
                        principalTable: "transcript",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "protein",
                schema: "gen",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    stable_id = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    transcript_id = table.Column<int>(type: "integer", nullable: true),
                    start = table.Column<int>(type: "integer", nullable: true),
                    end = table.Column<int>(type: "integer", nullable: true),
                    length = table.Column<int>(type: "integer", nullable: true),
                    is_canonical = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_protein", x => x.id);
                    table.UniqueConstraint("AK_protein_stable_id", x => x.stable_id);
                    table.ForeignKey(
                        name: "FK_protein_transcript_transcript_id",
                        column: x => x.transcript_id,
                        principalSchema: "gen",
                        principalTable: "transcript",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "sm_affected_transcript",
                schema: "gen",
                columns: table => new
                {
                    variant_id = table.Column<int>(type: "integer", nullable: false),
                    feature_id = table.Column<int>(type: "integer", nullable: false),
                    protein_change = table.Column<string>(type: "text", nullable: true),
                    codon_change = table.Column<string>(type: "text", nullable: true),
                    effects = table.Column<string>(type: "text", nullable: true),
                    distance = table.Column<int>(type: "integer", nullable: true),
                    overlap_bp_number = table.Column<int>(type: "integer", nullable: true),
                    overlap_percentage = table.Column<double>(type: "double precision", nullable: true),
                    cdna_start = table.Column<int>(type: "integer", nullable: true),
                    cdna_end = table.Column<int>(type: "integer", nullable: true),
                    cds_start = table.Column<int>(type: "integer", nullable: true),
                    cds_end = table.Column<int>(type: "integer", nullable: true),
                    aa_start = table.Column<int>(type: "integer", nullable: true),
                    aa_end = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sm_affected_transcript", x => new { x.variant_id, x.feature_id });
                    table.ForeignKey(
                        name: "FK_sm_affected_transcript_sm_variant_id",
                        column: x => x.variant_id,
                        principalSchema: "gen",
                        principalTable: "sm",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sm_affected_transcript_transcript_feature_id",
                        column: x => x.feature_id,
                        principalSchema: "gen",
                        principalTable: "transcript",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sv_affected_transcript",
                schema: "gen",
                columns: table => new
                {
                    variant_id = table.Column<int>(type: "integer", nullable: false),
                    feature_id = table.Column<int>(type: "integer", nullable: false),
                    effects = table.Column<string>(type: "text", nullable: true),
                    distance = table.Column<int>(type: "integer", nullable: true),
                    overlap_bp_number = table.Column<int>(type: "integer", nullable: true),
                    overlap_percentage = table.Column<double>(type: "double precision", nullable: true),
                    cdna_start = table.Column<int>(type: "integer", nullable: true),
                    cdna_end = table.Column<int>(type: "integer", nullable: true),
                    cds_start = table.Column<int>(type: "integer", nullable: true),
                    cds_end = table.Column<int>(type: "integer", nullable: true),
                    aa_start = table.Column<int>(type: "integer", nullable: true),
                    aa_end = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sv_affected_transcript", x => new { x.variant_id, x.feature_id });
                    table.ForeignKey(
                        name: "FK_sv_affected_transcript_sv_variant_id",
                        column: x => x.variant_id,
                        principalSchema: "gen",
                        principalTable: "sv",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sv_affected_transcript_transcript_feature_id",
                        column: x => x.feature_id,
                        principalSchema: "gen",
                        principalTable: "transcript",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "radiomics_feature_entry",
                schema: "img",
                columns: table => new
                {
                    sample_id = table.Column<int>(type: "integer", nullable: false),
                    feature_id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_radiomics_feature_entry", x => new { x.feature_id, x.sample_id });
                    table.ForeignKey(
                        name: "FK_radiomics_feature_entry_radiomics_feature_feature_id",
                        column: x => x.feature_id,
                        principalSchema: "img",
                        principalTable: "radiomics_feature",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_radiomics_feature_entry_sample_sample_id",
                        column: x => x.sample_id,
                        principalSchema: "img",
                        principalTable: "sample",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "line_info",
                schema: "spe",
                columns: table => new
                {
                    specimen_id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true),
                    depositor_name = table.Column<string>(type: "text", nullable: true),
                    depositor_establishment = table.Column<string>(type: "text", nullable: true),
                    establishment_date = table.Column<DateOnly>(type: "date", nullable: true),
                    pubmed_link = table.Column<string>(type: "text", nullable: true),
                    atcc_link = table.Column<string>(type: "text", nullable: true),
                    expasy_link = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_line_info", x => x.specimen_id);
                    table.ForeignKey(
                        name: "FK_line_info_line_specimen_id",
                        column: x => x.specimen_id,
                        principalSchema: "spe",
                        principalTable: "line",
                        principalColumn: "specimen_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cnv_entry",
                schema: "gen",
                columns: table => new
                {
                    sample_id = table.Column<int>(type: "integer", nullable: false),
                    variant_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cnv_entry", x => new { x.variant_id, x.sample_id });
                    table.ForeignKey(
                        name: "FK_cnv_entry_cnv_variant_id",
                        column: x => x.variant_id,
                        principalSchema: "gen",
                        principalTable: "cnv",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cnv_entry_sample_sample_id",
                        column: x => x.sample_id,
                        principalSchema: "gen",
                        principalTable: "sample",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gene_expression",
                schema: "gen",
                columns: table => new
                {
                    sample_id = table.Column<int>(type: "integer", nullable: false),
                    gene_id = table.Column<int>(type: "integer", nullable: false),
                    reads = table.Column<int>(type: "integer", nullable: false),
                    tpm = table.Column<double>(type: "double precision", nullable: false),
                    fpkm = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gene_expression", x => new { x.gene_id, x.sample_id });
                    table.ForeignKey(
                        name: "FK_gene_expression_gene_gene_id",
                        column: x => x.gene_id,
                        principalSchema: "gen",
                        principalTable: "gene",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_gene_expression_sample_sample_id",
                        column: x => x.sample_id,
                        principalSchema: "gen",
                        principalTable: "sample",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sample_resource",
                schema: "gen",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    sample_id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    type = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    format = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    archive = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    url = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sample_resource", x => x.id);
                    table.ForeignKey(
                        name: "FK_sample_resource_sample_sample_id",
                        column: x => x.sample_id,
                        principalSchema: "gen",
                        principalTable: "sample",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sm_entry",
                schema: "gen",
                columns: table => new
                {
                    sample_id = table.Column<int>(type: "integer", nullable: false),
                    variant_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sm_entry", x => new { x.variant_id, x.sample_id });
                    table.ForeignKey(
                        name: "FK_sm_entry_sample_sample_id",
                        column: x => x.sample_id,
                        principalSchema: "gen",
                        principalTable: "sample",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sm_entry_sm_variant_id",
                        column: x => x.variant_id,
                        principalSchema: "gen",
                        principalTable: "sm",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sv_entry",
                schema: "gen",
                columns: table => new
                {
                    sample_id = table.Column<int>(type: "integer", nullable: false),
                    variant_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sv_entry", x => new { x.variant_id, x.sample_id });
                    table.ForeignKey(
                        name: "FK_sv_entry_sample_sample_id",
                        column: x => x.sample_id,
                        principalSchema: "gen",
                        principalTable: "sample",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sv_entry_sv_variant_id",
                        column: x => x.variant_id,
                        principalSchema: "gen",
                        principalTable: "sv",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "drug_screening",
                schema: "spe",
                columns: table => new
                {
                    sample_id = table.Column<int>(type: "integer", nullable: false),
                    drug_id = table.Column<int>(type: "integer", nullable: false),
                    gof = table.Column<double>(type: "double precision", nullable: true),
                    dss = table.Column<double>(type: "double precision", nullable: true),
                    dss_s = table.Column<double>(type: "double precision", nullable: true),
                    dose_min = table.Column<double>(type: "double precision", nullable: true),
                    dose_max = table.Column<double>(type: "double precision", nullable: true),
                    dose_25 = table.Column<double>(type: "double precision", nullable: true),
                    dose_50 = table.Column<double>(type: "double precision", nullable: true),
                    dose_75 = table.Column<double>(type: "double precision", nullable: true),
                    doses = table.Column<string>(type: "text", nullable: true),
                    responses = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drug_screening", x => new { x.drug_id, x.sample_id });
                    table.ForeignKey(
                        name: "FK_drug_screening_drug_drug_id",
                        column: x => x.drug_id,
                        principalSchema: "spe",
                        principalTable: "drug",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_drug_screening_sample_sample_id",
                        column: x => x.sample_id,
                        principalSchema: "spe",
                        principalTable: "sample",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "com",
                table: "analysis_task_type",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "don-sce", "don-sce" },
                    { 300, "meth-dm", "meth-dm" },
                    { 301, "rna_de", "rna_de" },
                    { 302, "rnasc_dc", "rnasc_dc" }
                });

            migrationBuilder.InsertData(
                schema: "gen",
                table: "analysis_type",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "Whole Genome Sequencing", "WGS" },
                    { 2, "Whole Exome Sequencing", "WES" },
                    { 3, "Bulk RNA Sequencing", "RNASeq" },
                    { 4, "Single Cell RNA Sequencing", "scRNASeq" },
                    { 5, "Single Nucleus RNA Sequencing", "snRNASeq" },
                    { 6, "Bulk ATAC Sequencing", "ATACSeq" },
                    { 7, "Single Cell ATAC Sequencing", "scATACSeq" },
                    { 8, "Single Nucleus ATAC Sequencing", "snATACSeq" },
                    { 9, "Illumina Infinium Methylation Arrays Assay", "MethArray" },
                    { 10, "Whole Genome Bisulfite Sequencing", "WGBS" },
                    { 11, "Reduced Representation Bisulfite Sequencing", "RRBS" }
                });

            migrationBuilder.InsertData(
                schema: "img",
                table: "analysis_type",
                columns: new[] { "id", "name", "value" },
                values: new object[] { 1, "Radiomics Features Extraction", "RFE" });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "analysis_type",
                columns: new[] { "id", "name", "value" },
                values: new object[] { 1, "Drugs Screening Analysis", "DSA" });

            migrationBuilder.InsertData(
                schema: "com",
                table: "annotation_task_type",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 301, "dna-sm", "dna-sm" },
                    { 302, "dna-cnv", "dna-cnv" },
                    { 303, "dna-sv", "dna-sv" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "cells_culture_type",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "Suspension", "Suspension" },
                    { 2, "Adherent", "Adherent" },
                    { 3, "Both", "Both" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "cells_species",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "Human", "Human" },
                    { 2, "Mouse", "Mouse" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "cells_type",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "Stem Cell", "Stem Cell" },
                    { 2, "Differentiated", "Differentiated" }
                });

            migrationBuilder.InsertData(
                schema: "gen",
                table: "chromosome",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "Chromosome 1", "1" },
                    { 2, "Chromosome 2", "2" },
                    { 3, "Chromosome 3", "3" },
                    { 4, "Chromosome 4", "4" },
                    { 5, "Chromosome 5", "5" },
                    { 6, "Chromosome 6", "6" },
                    { 7, "Chromosome 7", "7" },
                    { 8, "Chromosome 8", "8" },
                    { 9, "Chromosome 9", "9" },
                    { 10, "Chromosome 10", "10" },
                    { 11, "Chromosome 11", "11" },
                    { 12, "Chromosome 12", "12" },
                    { 13, "Chromosome 13", "13" },
                    { 14, "Chromosome 14", "14" },
                    { 15, "Chromosome 15", "15" },
                    { 16, "Chromosome 16", "16" },
                    { 17, "Chromosome 17", "17" },
                    { 18, "Chromosome 18", "18" },
                    { 19, "Chromosome 19", "19" },
                    { 20, "Chromosome 20", "20" },
                    { 21, "Chromosome 21", "21" },
                    { 22, "Chromosome 22", "22" },
                    { 23, "Chromosome X", "X" },
                    { 24, "Chromosome Y", "Y" },
                    { 25, "Chromosome MT", "MT" }
                });

            migrationBuilder.InsertData(
                schema: "gen",
                table: "cnv_type",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "TCN gain", "Gain" },
                    { 2, "TCN loss", "Loss" },
                    { 3, "TCN neutral", "Neutral" },
                    { 4, "Undetermined", "Undetermined" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "fixation_type",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "FFPE", "FFPE" },
                    { 2, "Fresh Frozen", "Fresh Frozen" }
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
                table: "idh_mutation",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "IDH1 R132H", "IDH1 R132H" },
                    { 2, "IDH1 R132C", "IDH1 R132C" },
                    { 3, "IDH1 R132G", "IDH1 R132G" },
                    { 4, "IDH1 R132L", "IDH1 R132L" },
                    { 5, "IDH1 R132S", "IDH1 R132S" },
                    { 6, "IDH2 R172G", "IDH2 R172G" },
                    { 7, "IDH2 R172W", "IDH2 R172W" },
                    { 8, "IDH2 R172K", "IDH2 R172K" },
                    { 9, "IDH2 R172T", "IDH2 R172T" },
                    { 10, "IDH2 R172M", "IDH2 R172M" },
                    { 11, "IDH2 R172S", "IDH2 R172S" }
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
                schema: "img",
                table: "image_type",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "MR", "MR" },
                    { 2, "CT", "CT" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "implant_location",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "Other", "Other" },
                    { 2, "Striatal", "Striatal" },
                    { 3, "Cortical", "Cortical" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "implant_type",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "Other", "Other" },
                    { 2, "Orhtotopical", "Orhtotopical" }
                });

            migrationBuilder.InsertData(
                schema: "com",
                table: "indexing_task_type",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "Project", "Project" },
                    { 2, "Donor", "Donor" },
                    { 3, "Image", "Image" },
                    { 4, "Specimen", "Specimen" },
                    { 5, "Gene", "Gene" },
                    { 6, "SM", "SM" },
                    { 7, "CNV", "CNV" },
                    { 8, "SV", "SV" }
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

            migrationBuilder.InsertData(
                schema: "spe",
                table: "methylation_subtype",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "H3-K27", "H3-K27" },
                    { 2, "H3-G34", "H3-G34" },
                    { 3, "RTKI", "RTKI" },
                    { 4, "RTKII", "RTKII" },
                    { 5, "Mesenchymal", "Mesenchymal" }
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

            migrationBuilder.InsertData(
                schema: "don",
                table: "sex",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "Other", "Other" },
                    { 2, "Female", "Female" },
                    { 3, "Male", "Male" }
                });

            migrationBuilder.InsertData(
                schema: "gen",
                table: "sm_type",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "Single Nucleotide Variant", "SNV" },
                    { 2, "Insertion", "INS" },
                    { 3, "Deletion", "DEL" },
                    { 4, "Multiple Nucleotide Variant", "MNV" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "specimen_type",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "Material", "Material" },
                    { 2, "Line", "Line" },
                    { 3, "Organoid", "Organoid" },
                    { 4, "Xenograft", "Xenograft" }
                });

            migrationBuilder.InsertData(
                schema: "com",
                table: "submission_task_types",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 0, "don", "don" },
                    { 1, "don-trt", "don-trt" },
                    { 100, "mr", "mr" },
                    { 101, "img-rad", "img-rad" },
                    { 200, "mat", "mat" },
                    { 201, "lne", "lne" },
                    { 202, "org", "org" },
                    { 203, "xen", "xen" },
                    { 204, "spe-int", "spe-int" },
                    { 205, "spe-drg", "spe-drg" },
                    { 300, "dna", "dna" },
                    { 301, "dna-sm", "dna-sm" },
                    { 302, "dna-cnv", "dna-cnv" },
                    { 303, "dna-sv", "dna-sv" },
                    { 310, "meth", "meth" },
                    { 311, "meth-lvl", "meth-lvl" },
                    { 320, "rna", "rna" },
                    { 321, "rna-exp", "rna-exp" },
                    { 330, "rnasc", "rnasc" },
                    { 331, "rnasc-exp", "rnasc-exp" }
                });

            migrationBuilder.InsertData(
                schema: "gen",
                table: "sv_type",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "Duplication", "DUP" },
                    { 2, "Tandem duplication", "TDUP" },
                    { 3, "Insertion", "INS" },
                    { 4, "Deletion", "DEL" },
                    { 5, "Inversion", "INV" },
                    { 6, "Intra-choromosmal translocation", "ITX" },
                    { 7, "Inter-chromosomal translocation", "CTX" },
                    { 8, "Complex rearrangement", "COM" }
                });

            migrationBuilder.InsertData(
                schema: "com",
                table: "task_status_type",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "Preparing", "Preparing" },
                    { 2, "Prepared", "Prepared" },
                    { 3, "Processing", "Processing" },
                    { 4, "Processed", "Processed" },
                    { 5, "Failed", "Failed" },
                    { 6, "Rejected", "Rejected" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "tumor_growth_form",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "Encapsulated", "Encapsulated" },
                    { 2, "Invasive", "Invasive" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "tumor_type",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "Primary", "Primary" },
                    { 2, "Metastasis", "Metastasis" },
                    { 3, "Recurrent", "Recurrent" }
                });

            migrationBuilder.InsertData(
                schema: "com",
                table: "worker_type",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "Submission", "Submission" },
                    { 2, "Annotation", "Annotation" },
                    { 3, "Indexing", "Indexing" }
                });

            migrationBuilder.InsertData(
                schema: "com",
                table: "worker",
                columns: new[] { "id", "active", "type_id" },
                values: new object[,]
                {
                    { 1, true, 1 },
                    { 2, true, 2 },
                    { 3, true, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_analysis_type_id",
                schema: "gen",
                table: "analysis",
                column: "type_id");

            migrationBuilder.CreateIndex(
                name: "IX_analysis_type_id1",
                schema: "img",
                table: "analysis",
                column: "type_id");

            migrationBuilder.CreateIndex(
                name: "IX_analysis_type_id2",
                schema: "spe",
                table: "analysis",
                column: "type_id");

            migrationBuilder.CreateIndex(
                name: "IX_clinical_data_localization_id",
                schema: "don",
                table: "clinical_data",
                column: "localization_id");

            migrationBuilder.CreateIndex(
                name: "IX_clinical_data_primary_site_id",
                schema: "don",
                table: "clinical_data",
                column: "primary_site_id");

            migrationBuilder.CreateIndex(
                name: "IX_clinical_data_sex_id",
                schema: "don",
                table: "clinical_data",
                column: "sex_id");

            migrationBuilder.CreateIndex(
                name: "IX_cnv_chromosome_id",
                schema: "gen",
                table: "cnv",
                column: "chromosome_id");

            migrationBuilder.CreateIndex(
                name: "IX_cnv_type_id",
                schema: "gen",
                table: "cnv",
                column: "type_id");

            migrationBuilder.CreateIndex(
                name: "IX_cnv_affected_transcript_feature_id",
                schema: "gen",
                table: "cnv_affected_transcript",
                column: "feature_id");

            migrationBuilder.CreateIndex(
                name: "IX_cnv_entry_sample_id",
                schema: "gen",
                table: "cnv_entry",
                column: "sample_id");

            migrationBuilder.CreateIndex(
                name: "IX_donor_reference_id",
                schema: "don",
                table: "donor",
                column: "reference_id");

            migrationBuilder.CreateIndex(
                name: "IX_drug_screening_sample_id",
                schema: "spe",
                table: "drug_screening",
                column: "sample_id");

            migrationBuilder.CreateIndex(
                name: "IX_gene_chromosome_id",
                schema: "gen",
                table: "gene",
                column: "chromosome_id");

            migrationBuilder.CreateIndex(
                name: "IX_gene_expression_sample_id",
                schema: "gen",
                table: "gene_expression",
                column: "sample_id");

            migrationBuilder.CreateIndex(
                name: "IX_image_donor_id",
                schema: "img",
                table: "image",
                column: "donor_id");

            migrationBuilder.CreateIndex(
                name: "IX_image_reference_id",
                schema: "img",
                table: "image",
                column: "reference_id");

            migrationBuilder.CreateIndex(
                name: "IX_image_type_id",
                schema: "img",
                table: "image",
                column: "type_id");

            migrationBuilder.CreateIndex(
                name: "IX_intervention_specimen_id",
                schema: "spe",
                table: "intervention",
                column: "specimen_id");

            migrationBuilder.CreateIndex(
                name: "IX_line_cells_culture_type_id",
                schema: "spe",
                table: "line",
                column: "cells_culture_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_line_cells_species_id",
                schema: "spe",
                table: "line",
                column: "cells_species_id");

            migrationBuilder.CreateIndex(
                name: "IX_line_cells_type_id",
                schema: "spe",
                table: "line",
                column: "cells_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_material_fixation_type_id",
                schema: "spe",
                table: "material",
                column: "fixation_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_material_source_id",
                schema: "spe",
                table: "material",
                column: "source_id");

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

            migrationBuilder.CreateIndex(
                name: "IX_molecular_data_gene_expression_subtype_id",
                schema: "spe",
                table: "molecular_data",
                column: "gene_expression_subtype_id");

            migrationBuilder.CreateIndex(
                name: "IX_molecular_data_idh_mutation_id",
                schema: "spe",
                table: "molecular_data",
                column: "idh_mutation_id");

            migrationBuilder.CreateIndex(
                name: "IX_molecular_data_idh_status_id",
                schema: "spe",
                table: "molecular_data",
                column: "idh_status_id");

            migrationBuilder.CreateIndex(
                name: "IX_molecular_data_methylation_subtype_id",
                schema: "spe",
                table: "molecular_data",
                column: "methylation_subtype_id");

            migrationBuilder.CreateIndex(
                name: "IX_molecular_data_mgmt_status_id",
                schema: "spe",
                table: "molecular_data",
                column: "mgmt_status_id");

            migrationBuilder.CreateIndex(
                name: "IX_project_donor_donor_id",
                schema: "don",
                table: "project_donor",
                column: "donor_id");

            migrationBuilder.CreateIndex(
                name: "IX_protein_transcript_id",
                schema: "gen",
                table: "protein",
                column: "transcript_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_radiomics_feature_entry_sample_id",
                schema: "img",
                table: "radiomics_feature_entry",
                column: "sample_id");

            migrationBuilder.CreateIndex(
                name: "IX_sample_analysis_id",
                schema: "gen",
                table: "sample",
                column: "analysis_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_sample_matched_sample_id",
                schema: "gen",
                table: "sample",
                column: "matched_sample_id");

            migrationBuilder.CreateIndex(
                name: "IX_sample_specimen_id",
                schema: "gen",
                table: "sample",
                column: "specimen_id");

            migrationBuilder.CreateIndex(
                name: "IX_sample_analysis_id1",
                schema: "img",
                table: "sample",
                column: "analysis_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_sample_image_id",
                schema: "img",
                table: "sample",
                column: "image_id");

            migrationBuilder.CreateIndex(
                name: "IX_sample_analysis_id2",
                schema: "spe",
                table: "sample",
                column: "analysis_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_sample_specimen_id1",
                schema: "spe",
                table: "sample",
                column: "specimen_id");

            migrationBuilder.CreateIndex(
                name: "IX_sample_resource_sample_id",
                schema: "gen",
                table: "sample_resource",
                column: "sample_id");

            migrationBuilder.CreateIndex(
                name: "IX_sm_chromosome_id",
                schema: "gen",
                table: "sm",
                column: "chromosome_id");

            migrationBuilder.CreateIndex(
                name: "IX_sm_type_id",
                schema: "gen",
                table: "sm",
                column: "type_id");

            migrationBuilder.CreateIndex(
                name: "IX_sm_affected_transcript_feature_id",
                schema: "gen",
                table: "sm_affected_transcript",
                column: "feature_id");

            migrationBuilder.CreateIndex(
                name: "IX_sm_entry_sample_id",
                schema: "gen",
                table: "sm_entry",
                column: "sample_id");

            migrationBuilder.CreateIndex(
                name: "IX_specimen_donor_id",
                schema: "spe",
                table: "specimen",
                column: "donor_id");

            migrationBuilder.CreateIndex(
                name: "IX_specimen_parent_id",
                schema: "spe",
                table: "specimen",
                column: "parent_id");

            migrationBuilder.CreateIndex(
                name: "IX_specimen_reference_id",
                schema: "spe",
                table: "specimen",
                column: "reference_id");

            migrationBuilder.CreateIndex(
                name: "IX_specimen_type_id",
                schema: "spe",
                table: "specimen",
                column: "type_id");

            migrationBuilder.CreateIndex(
                name: "IX_study_donor_donor_id",
                schema: "don",
                table: "study_donor",
                column: "donor_id");

            migrationBuilder.CreateIndex(
                name: "IX_sv_chromosome_id",
                schema: "gen",
                table: "sv",
                column: "chromosome_id");

            migrationBuilder.CreateIndex(
                name: "IX_sv_other_chromosome_id",
                schema: "gen",
                table: "sv",
                column: "other_chromosome_id");

            migrationBuilder.CreateIndex(
                name: "IX_sv_type_id",
                schema: "gen",
                table: "sv",
                column: "type_id");

            migrationBuilder.CreateIndex(
                name: "IX_sv_affected_transcript_feature_id",
                schema: "gen",
                table: "sv_affected_transcript",
                column: "feature_id");

            migrationBuilder.CreateIndex(
                name: "IX_sv_entry_sample_id",
                schema: "gen",
                table: "sv_entry",
                column: "sample_id");

            migrationBuilder.CreateIndex(
                name: "IX_task_analysis_type_id",
                schema: "com",
                table: "task",
                column: "analysis_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_task_annotation_type_id",
                schema: "com",
                table: "task",
                column: "annotation_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_task_indexing_type_id",
                schema: "com",
                table: "task",
                column: "indexing_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_task_submission_type_id",
                schema: "com",
                table: "task",
                column: "submission_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_task_task_status_type_id",
                schema: "com",
                table: "task",
                column: "task_status_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_transcript_chromosome_id",
                schema: "gen",
                table: "transcript",
                column: "chromosome_id");

            migrationBuilder.CreateIndex(
                name: "IX_transcript_gene_id",
                schema: "gen",
                table: "transcript",
                column: "gene_id");

            migrationBuilder.CreateIndex(
                name: "IX_treatment_therapy_id",
                schema: "don",
                table: "treatment",
                column: "therapy_id");

            migrationBuilder.CreateIndex(
                name: "IX_worker_type_id",
                schema: "com",
                table: "worker",
                column: "type_id");

            migrationBuilder.CreateIndex(
                name: "IX_xenograft_implant_location_id",
                schema: "spe",
                table: "xenograft",
                column: "implant_location_id");

            migrationBuilder.CreateIndex(
                name: "IX_xenograft_implant_type_id",
                schema: "spe",
                table: "xenograft",
                column: "implant_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_xenograft_tumor_growth_form_id",
                schema: "spe",
                table: "xenograft",
                column: "tumor_growth_form_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clinical_data",
                schema: "don");

            migrationBuilder.DropTable(
                name: "cnv_affected_transcript",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "cnv_entry",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "drug_screening",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "gene_expression",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "intervention",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "line_info",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "material",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "molecular_data",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "mr_image",
                schema: "img");

            migrationBuilder.DropTable(
                name: "organoid",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "project_donor",
                schema: "don");

            migrationBuilder.DropTable(
                name: "protein",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "radiomics_feature_entry",
                schema: "img");

            migrationBuilder.DropTable(
                name: "sample_resource",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "sm_affected_transcript",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "sm_entry",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "study_donor",
                schema: "don");

            migrationBuilder.DropTable(
                name: "sv_affected_transcript",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "sv_entry",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "task",
                schema: "com");

            migrationBuilder.DropTable(
                name: "treatment",
                schema: "don");

            migrationBuilder.DropTable(
                name: "worker",
                schema: "com");

            migrationBuilder.DropTable(
                name: "xenograft",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "sex",
                schema: "don");

            migrationBuilder.DropTable(
                name: "tumor_localization",
                schema: "don");

            migrationBuilder.DropTable(
                name: "tumor_primary_site",
                schema: "don");

            migrationBuilder.DropTable(
                name: "cnv",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "drug",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "sample",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "intervention_type",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "line",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "fixation_type",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "material_source",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "material_type",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "tumor_type",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "gene_expression_subtype",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "idh_mutation",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "idh_status",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "methylation_subtype",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "mgmt_status",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "project",
                schema: "don");

            migrationBuilder.DropTable(
                name: "radiomics_feature",
                schema: "img");

            migrationBuilder.DropTable(
                name: "sample",
                schema: "img");

            migrationBuilder.DropTable(
                name: "sm",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "study",
                schema: "don");

            migrationBuilder.DropTable(
                name: "transcript",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "sample",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "sv",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "analysis_task_type",
                schema: "com");

            migrationBuilder.DropTable(
                name: "annotation_task_type",
                schema: "com");

            migrationBuilder.DropTable(
                name: "indexing_task_type",
                schema: "com");

            migrationBuilder.DropTable(
                name: "submission_task_types",
                schema: "com");

            migrationBuilder.DropTable(
                name: "task_status_type",
                schema: "com");

            migrationBuilder.DropTable(
                name: "therapy",
                schema: "don");

            migrationBuilder.DropTable(
                name: "worker_type",
                schema: "com");

            migrationBuilder.DropTable(
                name: "implant_location",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "implant_type",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "tumor_growth_form",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "cnv_type",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "analysis",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "cells_culture_type",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "cells_species",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "cells_type",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "analysis",
                schema: "img");

            migrationBuilder.DropTable(
                name: "image",
                schema: "img");

            migrationBuilder.DropTable(
                name: "sm_type",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "gene",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "analysis",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "specimen",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "sv_type",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "analysis_type",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "analysis_type",
                schema: "img");

            migrationBuilder.DropTable(
                name: "image_type",
                schema: "img");

            migrationBuilder.DropTable(
                name: "chromosome",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "analysis_type",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "donor",
                schema: "don");

            migrationBuilder.DropTable(
                name: "specimen_type",
                schema: "spe");
        }
    }
}
