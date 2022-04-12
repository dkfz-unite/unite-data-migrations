using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Unite.Data.Migrations.Migrations
{
    public partial class Root : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "gen");

            migrationBuilder.EnsureSchema(
                name: "img");

            migrationBuilder.EnsureSchema(
                name: "spe");

            migrationBuilder.EnsureSchema(
                name: "don");

            migrationBuilder.EnsureSchema(
                name: "com");

            migrationBuilder.CreateTable(
                name: "AnalysisParameters",
                schema: "gen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalysisParameters", x => x.Id);
                    table.UniqueConstraint("AK_AnalysisParameters_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "AnalysisParameters",
                schema: "img",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalysisParameters", x => x.Id);
                    table.UniqueConstraint("AK_AnalysisParameters_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "AnalysisTypes",
                schema: "gen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalysisTypes", x => x.Id);
                    table.UniqueConstraint("AK_AnalysisTypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "AnalysisTypes",
                schema: "img",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalysisTypes", x => x.Id);
                    table.UniqueConstraint("AK_AnalysisTypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "CellLineCultureTypes",
                schema: "spe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CellLineCultureTypes", x => x.Id);
                    table.UniqueConstraint("AK_CellLineCultureTypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "CellLineTypes",
                schema: "spe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CellLineTypes", x => x.Id);
                    table.UniqueConstraint("AK_CellLineTypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "Chromosomes",
                schema: "gen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chromosomes", x => x.Id);
                    table.UniqueConstraint("AK_Chromosomes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "ConsequenceImpacts",
                schema: "gen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsequenceImpacts", x => x.Id);
                    table.UniqueConstraint("AK_ConsequenceImpacts_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "Consequences",
                schema: "gen",
                columns: table => new
                {
                    TypeId = table.Column<int>(type: "integer", nullable: false),
                    ImpactId = table.Column<int>(type: "integer", nullable: false),
                    Severity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consequences", x => x.TypeId);
                });

            migrationBuilder.CreateTable(
                name: "ConsequenceTypes",
                schema: "gen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsequenceTypes", x => x.Id);
                    table.UniqueConstraint("AK_ConsequenceTypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "Donors",
                schema: "don",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ReferenceId = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    MtaProtected = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                schema: "img",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                    table.UniqueConstraint("AK_Features_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                schema: "don",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                    table.UniqueConstraint("AK_Genders_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "GeneBiotypes",
                schema: "gen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneBiotypes", x => x.Id);
                    table.UniqueConstraint("AK_GeneBiotypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "GeneExpressionSubtypes",
                schema: "spe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneExpressionSubtypes", x => x.Id);
                    table.UniqueConstraint("AK_GeneExpressionSubtypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "IdhMutations",
                schema: "spe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdhMutations", x => x.Id);
                    table.UniqueConstraint("AK_IdhMutations_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "IdhStatuses",
                schema: "spe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdhStatuses", x => x.Id);
                    table.UniqueConstraint("AK_IdhStatuses_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "ImplantTypes",
                schema: "spe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImplantTypes", x => x.Id);
                    table.UniqueConstraint("AK_ImplantTypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "MethylationSubtypes",
                schema: "spe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MethylationSubtypes", x => x.Id);
                    table.UniqueConstraint("AK_MethylationSubtypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "MgmtStatuses",
                schema: "spe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MgmtStatuses", x => x.Id);
                    table.UniqueConstraint("AK_MgmtStatuses_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "MutationTypes",
                schema: "gen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MutationTypes", x => x.Id);
                    table.UniqueConstraint("AK_MutationTypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "OrganoidInterventionTypes",
                schema: "spe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganoidInterventionTypes", x => x.Id);
                    table.UniqueConstraint("AK_OrganoidInterventionTypes_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Proteins",
                schema: "gen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Symbol = table.Column<string>(type: "text", nullable: true),
                    Start = table.Column<int>(type: "integer", nullable: true),
                    End = table.Column<int>(type: "integer", nullable: true),
                    Length = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proteins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Species",
                schema: "spe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.Id);
                    table.UniqueConstraint("AK_Species_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "Studies",
                schema: "don",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studies", x => x.Id);
                    table.UniqueConstraint("AK_Studies_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "TaskTargetTypes",
                schema: "com",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTargetTypes", x => x.Id);
                    table.UniqueConstraint("AK_TaskTargetTypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "TaskTypes",
                schema: "com",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTypes", x => x.Id);
                    table.UniqueConstraint("AK_TaskTypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "Therapies",
                schema: "don",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Therapies", x => x.Id);
                    table.UniqueConstraint("AK_Therapies_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "TissueLocations",
                schema: "spe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TissueLocations", x => x.Id);
                    table.UniqueConstraint("AK_TissueLocations_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "TissueSources",
                schema: "spe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TissueSources", x => x.Id);
                    table.UniqueConstraint("AK_TissueSources_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "TissueTypes",
                schema: "spe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TissueTypes", x => x.Id);
                    table.UniqueConstraint("AK_TissueTypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "TranscriptBiotypes",
                schema: "gen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranscriptBiotypes", x => x.Id);
                    table.UniqueConstraint("AK_TranscriptBiotypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "TumorGrowthForms",
                schema: "spe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TumorGrowthForms", x => x.Id);
                    table.UniqueConstraint("AK_TumorGrowthForms_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "TumorLocalizations",
                schema: "don",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TumorLocalizations", x => x.Id);
                    table.UniqueConstraint("AK_TumorLocalizations_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "TumorPrimarySites",
                schema: "don",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TumorPrimarySites", x => x.Id);
                    table.UniqueConstraint("AK_TumorPrimarySites_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "TumorTypes",
                schema: "spe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TumorTypes", x => x.Id);
                    table.UniqueConstraint("AK_TumorTypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "WorkPackages",
                schema: "don",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkPackages", x => x.Id);
                    table.UniqueConstraint("AK_WorkPackages_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "XenograftInterventionTypes",
                schema: "spe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XenograftInterventionTypes", x => x.Id);
                    table.UniqueConstraint("AK_XenograftInterventionTypes_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Analyses",
                schema: "gen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ReferenceId = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    TypeId = table.Column<int>(type: "integer", nullable: true),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analyses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Analyses_AnalysisTypes_TypeId",
                        column: x => x.TypeId,
                        principalSchema: "gen",
                        principalTable: "AnalysisTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Analyses",
                schema: "img",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ReferenceId = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    TypeId = table.Column<int>(type: "integer", nullable: true),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analyses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Analyses_AnalysisTypes_TypeId",
                        column: x => x.TypeId,
                        principalSchema: "img",
                        principalTable: "AnalysisTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                schema: "img",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DonorId = table.Column<int>(type: "integer", nullable: false),
                    ScanningDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ScanningDay = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Donors_DonorId",
                        column: x => x.DonorId,
                        principalSchema: "don",
                        principalTable: "Donors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Specimens",
                schema: "spe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ParentId = table.Column<int>(type: "integer", nullable: true),
                    DonorId = table.Column<int>(type: "integer", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreationDay = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specimens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Specimens_Donors_DonorId",
                        column: x => x.DonorId,
                        principalSchema: "don",
                        principalTable: "Donors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Specimens_Specimens_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "spe",
                        principalTable: "Specimens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Genes",
                schema: "gen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BiotypeId = table.Column<int>(type: "integer", nullable: true),
                    Symbol = table.Column<string>(type: "text", nullable: true),
                    ChromosomeId = table.Column<int>(type: "integer", nullable: true),
                    Start = table.Column<int>(type: "integer", nullable: true),
                    End = table.Column<int>(type: "integer", nullable: true),
                    Strand = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Genes_Chromosomes_ChromosomeId",
                        column: x => x.ChromosomeId,
                        principalSchema: "gen",
                        principalTable: "Chromosomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Genes_GeneBiotypes_BiotypeId",
                        column: x => x.BiotypeId,
                        principalSchema: "gen",
                        principalTable: "GeneBiotypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mutations",
                schema: "gen",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    ChromosomeId = table.Column<int>(type: "integer", nullable: false),
                    Start = table.Column<int>(type: "integer", nullable: false),
                    End = table.Column<int>(type: "integer", nullable: false),
                    TypeId = table.Column<int>(type: "integer", nullable: false),
                    ReferenceBase = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    AlternateBase = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mutations", x => x.Id);
                    table.UniqueConstraint("AK_Mutations_Code", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Mutations_Chromosomes_ChromosomeId",
                        column: x => x.ChromosomeId,
                        principalSchema: "gen",
                        principalTable: "Chromosomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mutations_MutationTypes_TypeId",
                        column: x => x.TypeId,
                        principalSchema: "gen",
                        principalTable: "MutationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProteinInfo",
                schema: "gen",
                columns: table => new
                {
                    ProteinId = table.Column<int>(type: "integer", nullable: false),
                    EnsemblId = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProteinInfo", x => x.ProteinId);
                    table.ForeignKey(
                        name: "FK_ProteinInfo_Proteins_ProteinId",
                        column: x => x.ProteinId,
                        principalSchema: "gen",
                        principalTable: "Proteins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudyDonors",
                schema: "don",
                columns: table => new
                {
                    StudyId = table.Column<int>(type: "integer", nullable: false),
                    DonorId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyDonors", x => new { x.StudyId, x.DonorId });
                    table.ForeignKey(
                        name: "FK_StudyDonors_Donors_DonorId",
                        column: x => x.DonorId,
                        principalSchema: "don",
                        principalTable: "Donors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudyDonors_Studies_StudyId",
                        column: x => x.StudyId,
                        principalSchema: "don",
                        principalTable: "Studies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                schema: "com",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TypeId = table.Column<int>(type: "integer", nullable: false),
                    TargetTypeId = table.Column<int>(type: "integer", nullable: false),
                    Target = table.Column<string>(type: "text", nullable: false),
                    Data = table.Column<string>(type: "text", nullable: true),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_TaskTargetTypes_TargetTypeId",
                        column: x => x.TargetTypeId,
                        principalSchema: "com",
                        principalTable: "TaskTargetTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_TaskTypes_TypeId",
                        column: x => x.TypeId,
                        principalSchema: "com",
                        principalTable: "TaskTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Treatments",
                schema: "don",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DonorId = table.Column<int>(type: "integer", nullable: false),
                    TherapyId = table.Column<int>(type: "integer", nullable: false),
                    Details = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    StartDay = table.Column<int>(type: "integer", nullable: true),
                    EndDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DurationDays = table.Column<int>(type: "integer", nullable: true),
                    ProgressionStatus = table.Column<bool>(type: "boolean", nullable: true),
                    ProgressionStatusChangeDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ProgressionStatusChangeDay = table.Column<int>(type: "integer", nullable: true),
                    Results = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treatments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Treatments_Donors_DonorId",
                        column: x => x.DonorId,
                        principalSchema: "don",
                        principalTable: "Donors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Treatments_Therapies_TherapyId",
                        column: x => x.TherapyId,
                        principalSchema: "don",
                        principalTable: "Therapies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClinicalData",
                schema: "don",
                columns: table => new
                {
                    DonorId = table.Column<int>(type: "integer", nullable: false),
                    GenderId = table.Column<int>(type: "integer", nullable: true),
                    Age = table.Column<int>(type: "integer", nullable: true),
                    Diagnosis = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    DiagnosisDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    PrimarySiteId = table.Column<int>(type: "integer", nullable: true),
                    LocalizationId = table.Column<int>(type: "integer", nullable: true),
                    VitalStatus = table.Column<bool>(type: "boolean", nullable: true),
                    VitalStatusChangeDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    VitalStatusChangeDay = table.Column<int>(type: "integer", nullable: true),
                    KpsBaseline = table.Column<int>(type: "integer", nullable: true),
                    SteroidsBaseline = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicalData", x => x.DonorId);
                    table.ForeignKey(
                        name: "FK_ClinicalData_Donors_DonorId",
                        column: x => x.DonorId,
                        principalSchema: "don",
                        principalTable: "Donors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClinicalData_Genders_GenderId",
                        column: x => x.GenderId,
                        principalSchema: "don",
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClinicalData_TumorLocalizations_LocalizationId",
                        column: x => x.LocalizationId,
                        principalSchema: "don",
                        principalTable: "TumorLocalizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClinicalData_TumorPrimarySites_PrimarySiteId",
                        column: x => x.PrimarySiteId,
                        principalSchema: "don",
                        principalTable: "TumorPrimarySites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkPackageDonors",
                schema: "don",
                columns: table => new
                {
                    WorkPackageId = table.Column<int>(type: "integer", nullable: false),
                    DonorId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkPackageDonors", x => new { x.WorkPackageId, x.DonorId });
                    table.ForeignKey(
                        name: "FK_WorkPackageDonors_Donors_DonorId",
                        column: x => x.DonorId,
                        principalSchema: "don",
                        principalTable: "Donors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkPackageDonors_WorkPackages_WorkPackageId",
                        column: x => x.WorkPackageId,
                        principalSchema: "don",
                        principalTable: "WorkPackages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnalysisParameterOccurrences",
                schema: "gen",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AnalysisId = table.Column<int>(type: "integer", nullable: false),
                    ParameterId = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalysisParameterOccurrences", x => x.Id);
                    table.UniqueConstraint("AK_AnalysisParameterOccurrences_ParameterId_AnalysisId", x => new { x.ParameterId, x.AnalysisId });
                    table.ForeignKey(
                        name: "FK_AnalysisParameterOccurrences_Analyses_AnalysisId",
                        column: x => x.AnalysisId,
                        principalSchema: "gen",
                        principalTable: "Analyses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnalysisParameterOccurrences_AnalysisParameters_ParameterId",
                        column: x => x.ParameterId,
                        principalSchema: "gen",
                        principalTable: "AnalysisParameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnalysisParameterOccurrences",
                schema: "img",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AnalysisId = table.Column<int>(type: "integer", nullable: false),
                    ParameterId = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalysisParameterOccurrences", x => x.Id);
                    table.UniqueConstraint("AK_AnalysisParameterOccurrences_ParameterId_AnalysisId", x => new { x.ParameterId, x.AnalysisId });
                    table.ForeignKey(
                        name: "FK_AnalysisParameterOccurrences_Analyses_AnalysisId",
                        column: x => x.AnalysisId,
                        principalSchema: "img",
                        principalTable: "Analyses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnalysisParameterOccurrences_AnalysisParameters_ParameterId",
                        column: x => x.ParameterId,
                        principalSchema: "img",
                        principalTable: "AnalysisParameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnalysedImages",
                schema: "img",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AnalysisId = table.Column<int>(type: "integer", nullable: false),
                    ImageId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalysedImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnalysedImages_Analyses_AnalysisId",
                        column: x => x.AnalysisId,
                        principalSchema: "img",
                        principalTable: "Analyses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnalysedImages_Images_ImageId",
                        column: x => x.ImageId,
                        principalSchema: "img",
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MriImages",
                schema: "img",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "integer", nullable: false),
                    ReferenceId = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    WholeTumor = table.Column<double>(type: "double precision", nullable: true),
                    ContrastEnhancing = table.Column<double>(type: "double precision", nullable: true),
                    NonContrastEnhancing = table.Column<double>(type: "double precision", nullable: true),
                    MedianAdcTumor = table.Column<double>(type: "double precision", nullable: true),
                    MedianAdcCe = table.Column<double>(type: "double precision", nullable: true),
                    MedianAdcEdema = table.Column<double>(type: "double precision", nullable: true),
                    MedianCbfTumor = table.Column<double>(type: "double precision", nullable: true),
                    MedianCbfCe = table.Column<double>(type: "double precision", nullable: true),
                    MedianCbfEdema = table.Column<double>(type: "double precision", nullable: true),
                    MedianCbvTumor = table.Column<double>(type: "double precision", nullable: true),
                    MedianCbvCe = table.Column<double>(type: "double precision", nullable: true),
                    MedianCbvEdema = table.Column<double>(type: "double precision", nullable: true),
                    MedianMttTumor = table.Column<double>(type: "double precision", nullable: true),
                    MedianMttCe = table.Column<double>(type: "double precision", nullable: true),
                    MedianMttEdema = table.Column<double>(type: "double precision", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MriImages", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_MriImages_Images_ImageId",
                        column: x => x.ImageId,
                        principalSchema: "img",
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CellLines",
                schema: "spe",
                columns: table => new
                {
                    SpecimenId = table.Column<int>(type: "integer", nullable: false),
                    ReferenceId = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    SpeciesId = table.Column<int>(type: "integer", nullable: true),
                    TypeId = table.Column<int>(type: "integer", nullable: true),
                    CultureTypeId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CellLines", x => x.SpecimenId);
                    table.ForeignKey(
                        name: "FK_CellLines_CellLineCultureTypes_CultureTypeId",
                        column: x => x.CultureTypeId,
                        principalSchema: "spe",
                        principalTable: "CellLineCultureTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CellLines_CellLineTypes_TypeId",
                        column: x => x.TypeId,
                        principalSchema: "spe",
                        principalTable: "CellLineTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CellLines_Species_SpeciesId",
                        column: x => x.SpeciesId,
                        principalSchema: "spe",
                        principalTable: "Species",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CellLines_Specimens_SpecimenId",
                        column: x => x.SpecimenId,
                        principalSchema: "spe",
                        principalTable: "Specimens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MolecularData",
                schema: "spe",
                columns: table => new
                {
                    SpecimenId = table.Column<int>(type: "integer", nullable: false),
                    MgmtStatusId = table.Column<int>(type: "integer", nullable: true),
                    IdhStatusId = table.Column<int>(type: "integer", nullable: true),
                    IdhMutationId = table.Column<int>(type: "integer", nullable: true),
                    GeneExpressionSubtypeId = table.Column<int>(type: "integer", nullable: true),
                    MethylationSubtypeId = table.Column<int>(type: "integer", nullable: true),
                    GcimpMethylation = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MolecularData", x => x.SpecimenId);
                    table.ForeignKey(
                        name: "FK_MolecularData_GeneExpressionSubtypes_GeneExpressionSubtypeId",
                        column: x => x.GeneExpressionSubtypeId,
                        principalSchema: "spe",
                        principalTable: "GeneExpressionSubtypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MolecularData_IdhMutations_IdhMutationId",
                        column: x => x.IdhMutationId,
                        principalSchema: "spe",
                        principalTable: "IdhMutations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MolecularData_IdhStatuses_IdhStatusId",
                        column: x => x.IdhStatusId,
                        principalSchema: "spe",
                        principalTable: "IdhStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MolecularData_MethylationSubtypes_MethylationSubtypeId",
                        column: x => x.MethylationSubtypeId,
                        principalSchema: "spe",
                        principalTable: "MethylationSubtypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MolecularData_MgmtStatuses_MgmtStatusId",
                        column: x => x.MgmtStatusId,
                        principalSchema: "spe",
                        principalTable: "MgmtStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MolecularData_Specimens_SpecimenId",
                        column: x => x.SpecimenId,
                        principalSchema: "spe",
                        principalTable: "Specimens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Organoids",
                schema: "spe",
                columns: table => new
                {
                    SpecimenId = table.Column<int>(type: "integer", nullable: false),
                    ReferenceId = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    ImplantedCellsNumber = table.Column<int>(type: "integer", nullable: true),
                    Tumorigenicity = table.Column<bool>(type: "boolean", nullable: true),
                    Medium = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organoids", x => x.SpecimenId);
                    table.ForeignKey(
                        name: "FK_Organoids_Specimens_SpecimenId",
                        column: x => x.SpecimenId,
                        principalSchema: "spe",
                        principalTable: "Specimens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Samples",
                schema: "gen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ReferenceId = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    SpecimenId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Samples", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Samples_Specimens_SpecimenId",
                        column: x => x.SpecimenId,
                        principalSchema: "spe",
                        principalTable: "Specimens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tissues",
                schema: "spe",
                columns: table => new
                {
                    SpecimenId = table.Column<int>(type: "integer", nullable: false),
                    ReferenceId = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    SourceId = table.Column<int>(type: "integer", nullable: true),
                    TypeId = table.Column<int>(type: "integer", nullable: true),
                    TumorTypeId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tissues", x => x.SpecimenId);
                    table.ForeignKey(
                        name: "FK_Tissues_Specimens_SpecimenId",
                        column: x => x.SpecimenId,
                        principalSchema: "spe",
                        principalTable: "Specimens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tissues_TissueSources_SourceId",
                        column: x => x.SourceId,
                        principalSchema: "spe",
                        principalTable: "TissueSources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tissues_TissueTypes_TypeId",
                        column: x => x.TypeId,
                        principalSchema: "spe",
                        principalTable: "TissueTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tissues_TumorTypes_TumorTypeId",
                        column: x => x.TumorTypeId,
                        principalSchema: "spe",
                        principalTable: "TumorTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Xenografts",
                schema: "spe",
                columns: table => new
                {
                    SpecimenId = table.Column<int>(type: "integer", nullable: false),
                    ReferenceId = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    MouseStrain = table.Column<string>(type: "text", nullable: true),
                    GroupSize = table.Column<int>(type: "integer", nullable: true),
                    ImplantTypeId = table.Column<int>(type: "integer", nullable: true),
                    TissueLocationId = table.Column<int>(type: "integer", nullable: true),
                    ImplantedCellsNumber = table.Column<int>(type: "integer", nullable: true),
                    Tumorigenicity = table.Column<bool>(type: "boolean", nullable: true),
                    TumorGrowthFormId = table.Column<int>(type: "integer", nullable: true),
                    SurvivalDaysFrom = table.Column<int>(type: "integer", nullable: true),
                    SurvivalDaysTo = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xenografts", x => x.SpecimenId);
                    table.ForeignKey(
                        name: "FK_Xenografts_ImplantTypes_ImplantTypeId",
                        column: x => x.ImplantTypeId,
                        principalSchema: "spe",
                        principalTable: "ImplantTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Xenografts_Specimens_SpecimenId",
                        column: x => x.SpecimenId,
                        principalSchema: "spe",
                        principalTable: "Specimens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Xenografts_TissueLocations_TissueLocationId",
                        column: x => x.TissueLocationId,
                        principalSchema: "spe",
                        principalTable: "TissueLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Xenografts_TumorGrowthForms_TumorGrowthFormId",
                        column: x => x.TumorGrowthFormId,
                        principalSchema: "spe",
                        principalTable: "TumorGrowthForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GeneInfo",
                schema: "gen",
                columns: table => new
                {
                    GeneId = table.Column<int>(type: "integer", nullable: false),
                    EnsemblId = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneInfo", x => x.GeneId);
                    table.ForeignKey(
                        name: "FK_GeneInfo_Genes_GeneId",
                        column: x => x.GeneId,
                        principalSchema: "gen",
                        principalTable: "Genes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transcripts",
                schema: "gen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GeneId = table.Column<int>(type: "integer", nullable: true),
                    ProteinId = table.Column<int>(type: "integer", nullable: true),
                    BiotypeId = table.Column<int>(type: "integer", nullable: true),
                    Symbol = table.Column<string>(type: "text", nullable: true),
                    ChromosomeId = table.Column<int>(type: "integer", nullable: true),
                    Start = table.Column<int>(type: "integer", nullable: true),
                    End = table.Column<int>(type: "integer", nullable: true),
                    Strand = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transcripts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transcripts_Chromosomes_ChromosomeId",
                        column: x => x.ChromosomeId,
                        principalSchema: "gen",
                        principalTable: "Chromosomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transcripts_Genes_GeneId",
                        column: x => x.GeneId,
                        principalSchema: "gen",
                        principalTable: "Genes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transcripts_Proteins_ProteinId",
                        column: x => x.ProteinId,
                        principalSchema: "gen",
                        principalTable: "Proteins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transcripts_TranscriptBiotypes_BiotypeId",
                        column: x => x.BiotypeId,
                        principalSchema: "gen",
                        principalTable: "TranscriptBiotypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FeatureOccurrences",
                schema: "img",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AnalysedImageId = table.Column<int>(type: "integer", nullable: false),
                    FeatureId = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureOccurrences", x => x.Id);
                    table.UniqueConstraint("AK_FeatureOccurrences_FeatureId_AnalysedImageId", x => new { x.FeatureId, x.AnalysedImageId });
                    table.ForeignKey(
                        name: "FK_FeatureOccurrences_AnalysedImages_AnalysedImageId",
                        column: x => x.AnalysedImageId,
                        principalSchema: "img",
                        principalTable: "AnalysedImages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeatureOccurrences_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalSchema: "img",
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CellLineInfo",
                schema: "spe",
                columns: table => new
                {
                    SpecimenId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    DepositorName = table.Column<string>(type: "text", nullable: true),
                    DepositorEstablishment = table.Column<string>(type: "text", nullable: true),
                    EstablishmentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    PubMedLink = table.Column<string>(type: "text", nullable: true),
                    AtccLink = table.Column<string>(type: "text", nullable: true),
                    ExPasyLink = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CellLineInfo", x => x.SpecimenId);
                    table.ForeignKey(
                        name: "FK_CellLineInfo_CellLines_SpecimenId",
                        column: x => x.SpecimenId,
                        principalSchema: "spe",
                        principalTable: "CellLines",
                        principalColumn: "SpecimenId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrganoidInterventions",
                schema: "spe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SpecimenId = table.Column<int>(type: "integer", nullable: false),
                    TypeId = table.Column<int>(type: "integer", nullable: false),
                    Details = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    StartDay = table.Column<int>(type: "integer", nullable: true),
                    EndDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DurationDays = table.Column<int>(type: "integer", nullable: true),
                    Results = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganoidInterventions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganoidInterventions_OrganoidInterventionTypes_TypeId",
                        column: x => x.TypeId,
                        principalSchema: "spe",
                        principalTable: "OrganoidInterventionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrganoidInterventions_Organoids_SpecimenId",
                        column: x => x.SpecimenId,
                        principalSchema: "spe",
                        principalTable: "Organoids",
                        principalColumn: "SpecimenId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnalysedSamples",
                schema: "gen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AnalysisId = table.Column<int>(type: "integer", nullable: false),
                    SampleId = table.Column<int>(type: "integer", nullable: false),
                    MatchedSampleId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalysedSamples", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnalysedSamples_Analyses_AnalysisId",
                        column: x => x.AnalysisId,
                        principalSchema: "gen",
                        principalTable: "Analyses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnalysedSamples_Samples_MatchedSampleId",
                        column: x => x.MatchedSampleId,
                        principalSchema: "gen",
                        principalTable: "Samples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnalysedSamples_Samples_SampleId",
                        column: x => x.SampleId,
                        principalSchema: "gen",
                        principalTable: "Samples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "XenograftInterventions",
                schema: "spe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SpecimenId = table.Column<int>(type: "integer", nullable: false),
                    TypeId = table.Column<int>(type: "integer", nullable: false),
                    Details = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    StartDay = table.Column<int>(type: "integer", nullable: true),
                    EndDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DurationDays = table.Column<int>(type: "integer", nullable: true),
                    Results = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XenograftInterventions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_XenograftInterventions_XenograftInterventionTypes_TypeId",
                        column: x => x.TypeId,
                        principalSchema: "spe",
                        principalTable: "XenograftInterventionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_XenograftInterventions_Xenografts_SpecimenId",
                        column: x => x.SpecimenId,
                        principalSchema: "spe",
                        principalTable: "Xenografts",
                        principalColumn: "SpecimenId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AffectedTranscripts",
                schema: "gen",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MutationId = table.Column<long>(type: "bigint", nullable: false),
                    TranscriptId = table.Column<int>(type: "integer", nullable: false),
                    CDNAStart = table.Column<int>(type: "integer", nullable: true),
                    CDNAEnd = table.Column<int>(type: "integer", nullable: true),
                    CDSStart = table.Column<int>(type: "integer", nullable: true),
                    CDSEnd = table.Column<int>(type: "integer", nullable: true),
                    ProteinStart = table.Column<int>(type: "integer", nullable: true),
                    ProteinEnd = table.Column<int>(type: "integer", nullable: true),
                    AminoAcidChange = table.Column<string>(type: "text", nullable: true),
                    CodonChange = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AffectedTranscripts", x => x.Id);
                    table.UniqueConstraint("AK_AffectedTranscripts_MutationId_TranscriptId", x => new { x.MutationId, x.TranscriptId });
                    table.ForeignKey(
                        name: "FK_AffectedTranscripts_Mutations_MutationId",
                        column: x => x.MutationId,
                        principalSchema: "gen",
                        principalTable: "Mutations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AffectedTranscripts_Transcripts_TranscriptId",
                        column: x => x.TranscriptId,
                        principalSchema: "gen",
                        principalTable: "Transcripts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TranscriptInfo",
                schema: "gen",
                columns: table => new
                {
                    TranscriptId = table.Column<int>(type: "integer", nullable: false),
                    EnsemblId = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranscriptInfo", x => x.TranscriptId);
                    table.ForeignKey(
                        name: "FK_TranscriptInfo_Transcripts_TranscriptId",
                        column: x => x.TranscriptId,
                        principalSchema: "gen",
                        principalTable: "Transcripts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MutationOccurrences",
                schema: "gen",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AnalysedSampleId = table.Column<int>(type: "integer", nullable: false),
                    MutationId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MutationOccurrences", x => x.Id);
                    table.UniqueConstraint("AK_MutationOccurrences_MutationId_AnalysedSampleId", x => new { x.MutationId, x.AnalysedSampleId });
                    table.ForeignKey(
                        name: "FK_MutationOccurrences_AnalysedSamples_AnalysedSampleId",
                        column: x => x.AnalysedSampleId,
                        principalSchema: "gen",
                        principalTable: "AnalysedSamples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MutationOccurrences_Mutations_MutationId",
                        column: x => x.MutationId,
                        principalSchema: "gen",
                        principalTable: "Mutations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AffectedTranscriptConsequences",
                schema: "gen",
                columns: table => new
                {
                    AffectedTranscriptId = table.Column<long>(type: "bigint", nullable: false),
                    ConsequenceId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AffectedTranscriptConsequences", x => new { x.AffectedTranscriptId, x.ConsequenceId });
                    table.ForeignKey(
                        name: "FK_AffectedTranscriptConsequences_AffectedTranscripts_Affected~",
                        column: x => x.AffectedTranscriptId,
                        principalSchema: "gen",
                        principalTable: "AffectedTranscripts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AffectedTranscriptConsequences_Consequences_ConsequenceId",
                        column: x => x.ConsequenceId,
                        principalSchema: "gen",
                        principalTable: "Consequences",
                        principalColumn: "TypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "com",
                table: "TaskTargetTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 5, "Image", "Image" },
                    { 4, "Gene", "Gene" },
                    { 3, "Mutation", "Mutation" },
                    { 2, "Specimen", "Specimen" },
                    { 1, "Donor", "Donor" }
                });

            migrationBuilder.InsertData(
                schema: "com",
                table: "TaskTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 2, "Anotation", "Anotation" },
                    { 1, "Indexing", "Indexing" }
                });

            migrationBuilder.InsertData(
                schema: "don",
                table: "Genders",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Other", "Other" },
                    { 3, "Male", "Male" },
                    { 2, "Female", "Female" }
                });

            migrationBuilder.InsertData(
                schema: "gen",
                table: "AnalysisTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "WGS", "WGS" },
                    { 2, "WES", "WES" }
                });

            migrationBuilder.InsertData(
                schema: "gen",
                table: "Chromosomes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 4, "Chromosome 4", "4" },
                    { 5, "Chromosome 5", "5" },
                    { 6, "Chromosome 6", "6" },
                    { 3, "Chromosome 3", "3" },
                    { 7, "Chromosome 7", "7" },
                    { 8, "Chromosome 8", "8" },
                    { 9, "Chromosome 9", "9" },
                    { 10, "Chromosome 10", "10" },
                    { 11, "Chromosome 11", "11" },
                    { 12, "Chromosome 12", "12" },
                    { 13, "Chromosome 13", "13" },
                    { 17, "Chromosome 17", "17" },
                    { 15, "Chromosome 15", "15" },
                    { 24, "Chromosome Y", "Y" },
                    { 14, "Chromosome 14", "14" },
                    { 22, "Chromosome 22", "22" },
                    { 21, "Chromosome 21", "21" },
                    { 23, "Chromosome X", "X" },
                    { 19, "Chromosome 19", "19" },
                    { 18, "Chromosome 18", "18" },
                    { 1, "Chromosome 1", "1" },
                    { 16, "Chromosome 16", "16" },
                    { 20, "Chromosome 20", "20" },
                    { 2, "Chromosome 2", "2" }
                });

            migrationBuilder.InsertData(
                schema: "gen",
                table: "ConsequenceImpacts",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "High", "High" },
                    { 2, "Moderate", "Moderate" },
                    { 3, "Low", "Low" },
                    { 4, "Unknown", "Unknown" }
                });

            migrationBuilder.InsertData(
                schema: "gen",
                table: "ConsequenceTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 6, "Stop lost", "stop_lost" },
                    { 7, "Start lost", "start_lost" },
                    { 8, "Transcript amplification", "transcript_amplification" },
                    { 36, "Intergenic variant", "intergenic_variant" },
                    { 35, "Feature truncation", "feature_truncation" },
                    { 34, "Regulatory region variant", "regulatory_region_variant" },
                    { 33, "Feature elongation", "feature_elongation" },
                    { 32, "Regulatory region amplification", "regulatory_region_amplification" },
                    { 31, "Regulatory region ablation", "regulatory_region_ablation" },
                    { 30, "TF binding site variant", "TF_binding_site_variant" },
                    { 29, "TFBS amplification", "TFBS_amplification" },
                    { 28, "TFBS ablation", "TFBS_ablation" },
                    { 27, "Downstream gene variant", "downstream_gene_variant" },
                    { 26, "Upstream gene variant", "upstream_gene_variant" },
                    { 25, "Non coding transcript variant", "non_coding_transcript_variant" },
                    { 24, "NMD transcript variant", "NMD_transcript_variant" },
                    { 23, "Intron variant", "intron_variant" },
                    { 22, "Non coding transcript exon variant", "non_coding_transcript_exon_variant" },
                    { 21, "3 prime UTR variant", "3_prime_UTR_variant" },
                    { 20, "5 prime UTR variant", "5_prime_UTR_variant" },
                    { 19, "Mature miRNA variant", "mature_miRNA_variant" },
                    { 18, "Coding sequence variant", "coding_sequence_variant" },
                    { 17, "Synonymous variant", "synonymous_variant" },
                    { 16, "Stop retained variant", "stop_retained_variant" },
                    { 15, "Start retained variant", "start_retained_variant" },
                    { 14, "Incomplete terminal codon variant", "incomplete_terminal_codon_variant" },
                    { 13, "Splice region variant", "splice_region_variant" },
                    { 12, "Protein altering variant", "protein_altering_variant" },
                    { 10, "Inframe deletion", "inframe_deletion" },
                    { 9, "Inframe insertion", "inframe_insertion" },
                    { 5, "Frameshift variant", "frameshift_variant" },
                    { 4, "Stop gained", "stop_gained" },
                    { 11, "Missense variant", "missense_variant" },
                    { 2, "Splice acceptor variant", "splice_acceptor_variant" },
                    { 1, "Transcript ablation", "transcript_ablation" },
                    { 3, "Splice donor variant", "splice_donor_variant" }
                });

            migrationBuilder.InsertData(
                schema: "gen",
                table: "Consequences",
                columns: new[] { "TypeId", "ImpactId", "Severity" },
                values: new object[,]
                {
                    { 16, 3, 16 },
                    { 15, 3, 15 },
                    { 14, 3, 14 },
                    { 13, 3, 13 },
                    { 12, 2, 12 },
                    { 11, 2, 11 },
                    { 10, 2, 10 },
                    { 8, 1, 8 },
                    { 17, 3, 17 },
                    { 7, 1, 7 },
                    { 6, 1, 6 },
                    { 5, 1, 5 },
                    { 4, 1, 4 },
                    { 3, 1, 3 },
                    { 2, 1, 2 },
                    { 9, 2, 9 },
                    { 18, 4, 18 },
                    { 1, 1, 1 },
                    { 20, 4, 20 },
                    { 35, 4, 35 },
                    { 34, 4, 34 },
                    { 33, 4, 33 },
                    { 32, 4, 32 },
                    { 19, 4, 19 },
                    { 31, 2, 31 },
                    { 30, 4, 30 },
                    { 29, 4, 29 },
                    { 36, 4, 36 },
                    { 27, 4, 27 },
                    { 26, 4, 26 },
                    { 25, 4, 25 },
                    { 24, 4, 24 },
                    { 23, 4, 23 },
                    { 22, 4, 22 },
                    { 21, 4, 21 },
                    { 28, 4, 28 }
                });

            migrationBuilder.InsertData(
                schema: "gen",
                table: "MutationTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 2, "Insertion", "INS" },
                    { 3, "Deletion", "DEL" },
                    { 4, "Multiple Nucleotide Variant", "MNV" },
                    { 1, "Single Nucleotide Variant", "SNV" }
                });

            migrationBuilder.InsertData(
                schema: "img",
                table: "AnalysisTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[] { 1, "RFE", "RFE" });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "CellLineCultureTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Suspension", "Suspension" },
                    { 3, "Both", "Both" },
                    { 2, "Adherent", "Adherent" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "CellLineTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 2, "Differentiated", "Differentiated" },
                    { 1, "Stem Cell", "Stem Cell" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "GeneExpressionSubtypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 2, "Mesenchymal", "Mesenchymal" },
                    { 3, "Proneural", "Proneural" },
                    { 1, "Classical", "Classical" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "IdhMutations",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 11, "IDH2 R172S", "IDH2 R172S" },
                    { 10, "IDH2 R172M", "IDH2 R172M" },
                    { 9, "IDH2 R172T", "IDH2 R172T" },
                    { 7, "IDH2 R172W", "IDH2 R172W" },
                    { 6, "IDH2 R172G", "IDH2 R172G" },
                    { 3, "IDH1 R132G", "IDH1 R132G" },
                    { 8, "IDH2 R172K", "IDH2 R172K" },
                    { 2, "IDH1 R132C", "IDH1 R132C" },
                    { 1, "IDH1 R132H", "IDH1 R132H" },
                    { 4, "IDH1 R132L", "IDH1 R132L" },
                    { 5, "IDH1 R132S", "IDH1 R132S" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "IdhStatuses",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 2, "Mutant", "Mutant" },
                    { 1, "Wild Type", "Wild Type" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "ImplantTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 2, "Orhtotopical", "Orhtotopical" },
                    { 1, "Other", "Other" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "MethylationSubtypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 3, "RTKI", "RTKI" },
                    { 4, "RTKII", "RTKII" },
                    { 5, "Mesenchymal", "Mesenchymal" },
                    { 1, "H3-K27", "H3-K27" },
                    { 2, "H3-G34", "H3-G34" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "MgmtStatuses",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 2, "Methylated", "Methylated" },
                    { 1, "Unmethylated", "Unmethylated" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "Species",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 2, "Mouse", "Mouse" },
                    { 1, "Human", "Human" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "TissueLocations",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 3, "Cortical", "Cortical" },
                    { 1, "Other", "Other" },
                    { 2, "Striatal", "Striatal" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "TissueTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 2, "Tumor", "Tumor" },
                    { 1, "Control", "Control" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "TumorGrowthForms",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Encapsulated", "Encapsulated" },
                    { 2, "Invasive", "Invasive" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "TumorTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 3, "Recurrent", "Recurrent" },
                    { 1, "Primary", "Primary" },
                    { 2, "Metastasis", "Metastasis" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AffectedTranscriptConsequences_ConsequenceId",
                schema: "gen",
                table: "AffectedTranscriptConsequences",
                column: "ConsequenceId");

            migrationBuilder.CreateIndex(
                name: "IX_AffectedTranscripts_TranscriptId",
                schema: "gen",
                table: "AffectedTranscripts",
                column: "TranscriptId");

            migrationBuilder.CreateIndex(
                name: "IX_AnalysedImages_AnalysisId",
                schema: "img",
                table: "AnalysedImages",
                column: "AnalysisId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AnalysedImages_ImageId",
                schema: "img",
                table: "AnalysedImages",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_AnalysedSamples_AnalysisId",
                schema: "gen",
                table: "AnalysedSamples",
                column: "AnalysisId");

            migrationBuilder.CreateIndex(
                name: "IX_AnalysedSamples_MatchedSampleId",
                schema: "gen",
                table: "AnalysedSamples",
                column: "MatchedSampleId");

            migrationBuilder.CreateIndex(
                name: "IX_AnalysedSamples_SampleId",
                schema: "gen",
                table: "AnalysedSamples",
                column: "SampleId");

            migrationBuilder.CreateIndex(
                name: "IX_Analyses_ReferenceId",
                schema: "gen",
                table: "Analyses",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Analyses_TypeId",
                schema: "gen",
                table: "Analyses",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Analyses_ReferenceId1",
                schema: "img",
                table: "Analyses",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Analyses_TypeId1",
                schema: "img",
                table: "Analyses",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AnalysisParameterOccurrences_AnalysisId",
                schema: "gen",
                table: "AnalysisParameterOccurrences",
                column: "AnalysisId");

            migrationBuilder.CreateIndex(
                name: "IX_AnalysisParameterOccurrences_AnalysisId1",
                schema: "img",
                table: "AnalysisParameterOccurrences",
                column: "AnalysisId");

            migrationBuilder.CreateIndex(
                name: "IX_CellLines_CultureTypeId",
                schema: "spe",
                table: "CellLines",
                column: "CultureTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CellLines_ReferenceId",
                schema: "spe",
                table: "CellLines",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_CellLines_SpeciesId",
                schema: "spe",
                table: "CellLines",
                column: "SpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_CellLines_TypeId",
                schema: "spe",
                table: "CellLines",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicalData_GenderId",
                schema: "don",
                table: "ClinicalData",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicalData_LocalizationId",
                schema: "don",
                table: "ClinicalData",
                column: "LocalizationId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicalData_PrimarySiteId",
                schema: "don",
                table: "ClinicalData",
                column: "PrimarySiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Donors_ReferenceId",
                schema: "don",
                table: "Donors",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_FeatureOccurrences_AnalysedImageId",
                schema: "img",
                table: "FeatureOccurrences",
                column: "AnalysedImageId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneInfo_EnsemblId",
                schema: "gen",
                table: "GeneInfo",
                column: "EnsemblId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Genes_BiotypeId",
                schema: "gen",
                table: "Genes",
                column: "BiotypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Genes_ChromosomeId",
                schema: "gen",
                table: "Genes",
                column: "ChromosomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_DonorId",
                schema: "img",
                table: "Images",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_MolecularData_GeneExpressionSubtypeId",
                schema: "spe",
                table: "MolecularData",
                column: "GeneExpressionSubtypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MolecularData_IdhMutationId",
                schema: "spe",
                table: "MolecularData",
                column: "IdhMutationId");

            migrationBuilder.CreateIndex(
                name: "IX_MolecularData_IdhStatusId",
                schema: "spe",
                table: "MolecularData",
                column: "IdhStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_MolecularData_MethylationSubtypeId",
                schema: "spe",
                table: "MolecularData",
                column: "MethylationSubtypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MolecularData_MgmtStatusId",
                schema: "spe",
                table: "MolecularData",
                column: "MgmtStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_MutationOccurrences_AnalysedSampleId",
                schema: "gen",
                table: "MutationOccurrences",
                column: "AnalysedSampleId");

            migrationBuilder.CreateIndex(
                name: "IX_Mutations_ChromosomeId",
                schema: "gen",
                table: "Mutations",
                column: "ChromosomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Mutations_TypeId",
                schema: "gen",
                table: "Mutations",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganoidInterventions_SpecimenId",
                schema: "spe",
                table: "OrganoidInterventions",
                column: "SpecimenId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganoidInterventions_TypeId",
                schema: "spe",
                table: "OrganoidInterventions",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Organoids_ReferenceId",
                schema: "spe",
                table: "Organoids",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_ProteinInfo_EnsemblId",
                schema: "gen",
                table: "ProteinInfo",
                column: "EnsemblId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Samples_ReferenceId",
                schema: "gen",
                table: "Samples",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Samples_SpecimenId",
                schema: "gen",
                table: "Samples",
                column: "SpecimenId");

            migrationBuilder.CreateIndex(
                name: "IX_Specimens_DonorId",
                schema: "spe",
                table: "Specimens",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_Specimens_ParentId",
                schema: "spe",
                table: "Specimens",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyDonors_DonorId",
                schema: "don",
                table: "StudyDonors",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TargetTypeId",
                schema: "com",
                table: "Tasks",
                column: "TargetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TypeId",
                schema: "com",
                table: "Tasks",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tissues_ReferenceId",
                schema: "spe",
                table: "Tissues",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Tissues_SourceId",
                schema: "spe",
                table: "Tissues",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Tissues_TumorTypeId",
                schema: "spe",
                table: "Tissues",
                column: "TumorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tissues_TypeId",
                schema: "spe",
                table: "Tissues",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TranscriptInfo_EnsemblId",
                schema: "gen",
                table: "TranscriptInfo",
                column: "EnsemblId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transcripts_BiotypeId",
                schema: "gen",
                table: "Transcripts",
                column: "BiotypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Transcripts_ChromosomeId",
                schema: "gen",
                table: "Transcripts",
                column: "ChromosomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Transcripts_GeneId",
                schema: "gen",
                table: "Transcripts",
                column: "GeneId");

            migrationBuilder.CreateIndex(
                name: "IX_Transcripts_ProteinId",
                schema: "gen",
                table: "Transcripts",
                column: "ProteinId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_DonorId",
                schema: "don",
                table: "Treatments",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_TherapyId",
                schema: "don",
                table: "Treatments",
                column: "TherapyId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPackageDonors_DonorId",
                schema: "don",
                table: "WorkPackageDonors",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_XenograftInterventions_SpecimenId",
                schema: "spe",
                table: "XenograftInterventions",
                column: "SpecimenId");

            migrationBuilder.CreateIndex(
                name: "IX_XenograftInterventions_TypeId",
                schema: "spe",
                table: "XenograftInterventions",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Xenografts_ImplantTypeId",
                schema: "spe",
                table: "Xenografts",
                column: "ImplantTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Xenografts_ReferenceId",
                schema: "spe",
                table: "Xenografts",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Xenografts_TissueLocationId",
                schema: "spe",
                table: "Xenografts",
                column: "TissueLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Xenografts_TumorGrowthFormId",
                schema: "spe",
                table: "Xenografts",
                column: "TumorGrowthFormId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AffectedTranscriptConsequences",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "AnalysisParameterOccurrences",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "AnalysisParameterOccurrences",
                schema: "img");

            migrationBuilder.DropTable(
                name: "CellLineInfo",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "ClinicalData",
                schema: "don");

            migrationBuilder.DropTable(
                name: "ConsequenceImpacts",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "ConsequenceTypes",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "FeatureOccurrences",
                schema: "img");

            migrationBuilder.DropTable(
                name: "GeneInfo",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "MolecularData",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "MriImages",
                schema: "img");

            migrationBuilder.DropTable(
                name: "MutationOccurrences",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "OrganoidInterventions",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "ProteinInfo",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "StudyDonors",
                schema: "don");

            migrationBuilder.DropTable(
                name: "Tasks",
                schema: "com");

            migrationBuilder.DropTable(
                name: "Tissues",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "TranscriptInfo",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "Treatments",
                schema: "don");

            migrationBuilder.DropTable(
                name: "WorkPackageDonors",
                schema: "don");

            migrationBuilder.DropTable(
                name: "XenograftInterventions",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "AffectedTranscripts",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "Consequences",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "AnalysisParameters",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "AnalysisParameters",
                schema: "img");

            migrationBuilder.DropTable(
                name: "CellLines",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "Genders",
                schema: "don");

            migrationBuilder.DropTable(
                name: "TumorLocalizations",
                schema: "don");

            migrationBuilder.DropTable(
                name: "TumorPrimarySites",
                schema: "don");

            migrationBuilder.DropTable(
                name: "AnalysedImages",
                schema: "img");

            migrationBuilder.DropTable(
                name: "Features",
                schema: "img");

            migrationBuilder.DropTable(
                name: "GeneExpressionSubtypes",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "IdhMutations",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "IdhStatuses",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "MethylationSubtypes",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "MgmtStatuses",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "AnalysedSamples",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "OrganoidInterventionTypes",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "Organoids",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "Studies",
                schema: "don");

            migrationBuilder.DropTable(
                name: "TaskTargetTypes",
                schema: "com");

            migrationBuilder.DropTable(
                name: "TaskTypes",
                schema: "com");

            migrationBuilder.DropTable(
                name: "TissueSources",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "TissueTypes",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "TumorTypes",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "Therapies",
                schema: "don");

            migrationBuilder.DropTable(
                name: "WorkPackages",
                schema: "don");

            migrationBuilder.DropTable(
                name: "XenograftInterventionTypes",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "Xenografts",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "Mutations",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "Transcripts",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "CellLineCultureTypes",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "CellLineTypes",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "Species",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "Analyses",
                schema: "img");

            migrationBuilder.DropTable(
                name: "Images",
                schema: "img");

            migrationBuilder.DropTable(
                name: "Analyses",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "Samples",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "ImplantTypes",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "TissueLocations",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "TumorGrowthForms",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "MutationTypes",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "Genes",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "Proteins",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "TranscriptBiotypes",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "AnalysisTypes",
                schema: "img");

            migrationBuilder.DropTable(
                name: "AnalysisTypes",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "Specimens",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "Chromosomes",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "GeneBiotypes",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "Donors",
                schema: "don");
        }
    }
}
