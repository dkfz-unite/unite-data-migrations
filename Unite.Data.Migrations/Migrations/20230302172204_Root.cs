using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Unite.Data.Migrations.Migrations
{
    public partial class Root : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "img");

            migrationBuilder.EnsureSchema(
                name: "gen");

            migrationBuilder.EnsureSchema(
                name: "com");

            migrationBuilder.EnsureSchema(
                name: "spe");

            migrationBuilder.EnsureSchema(
                name: "don");

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
                name: "AnnotationTaskTypes",
                schema: "com",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnotationTaskTypes", x => x.Id);
                    table.UniqueConstraint("AK_AnnotationTaskTypes_Value", x => x.Value);
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
                name: "CnvTypes",
                schema: "gen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CnvTypes", x => x.Id);
                    table.UniqueConstraint("AK_CnvTypes_Value", x => x.Value);
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
                name: "Drugs",
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
                    table.PrimaryKey("PK_Drugs", x => x.Id);
                    table.UniqueConstraint("AK_Drugs_Name", x => x.Name);
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
                name: "IndexingTaskTypes",
                schema: "com",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndexingTaskTypes", x => x.Id);
                    table.UniqueConstraint("AK_IndexingTaskTypes_Value", x => x.Value);
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
                name: "Projects",
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
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.UniqueConstraint("AK_Projects_Name", x => x.Name);
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
                name: "SsmTypes",
                schema: "gen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SsmTypes", x => x.Id);
                    table.UniqueConstraint("AK_SsmTypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "Studies",
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
                    table.PrimaryKey("PK_Studies", x => x.Id);
                    table.UniqueConstraint("AK_Studies_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "SubmissionTaskTypes",
                schema: "com",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubmissionTaskTypes", x => x.Id);
                    table.UniqueConstraint("AK_SubmissionTaskTypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "SvTypes",
                schema: "gen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SvTypes", x => x.Id);
                    table.UniqueConstraint("AK_SvTypes_Value", x => x.Value);
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
                    Date = table.Column<DateOnly>(type: "date", nullable: true),
                    Parameters = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analyses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Analyses_AnalysisTypes_TypeId",
                        column: x => x.TypeId,
                        principalSchema: "gen",
                        principalTable: "AnalysisTypes",
                        principalColumn: "Id");
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
                    Date = table.Column<DateOnly>(type: "date", nullable: true),
                    Parameters = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analyses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Analyses_AnalysisTypes_TypeId",
                        column: x => x.TypeId,
                        principalSchema: "img",
                        principalTable: "AnalysisTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Genes",
                schema: "gen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StableId = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ChromosomeId = table.Column<int>(type: "integer", nullable: true),
                    Start = table.Column<int>(type: "integer", nullable: true),
                    End = table.Column<int>(type: "integer", nullable: true),
                    Strand = table.Column<bool>(type: "boolean", nullable: true),
                    ExonicLength = table.Column<int>(type: "integer", nullable: true),
                    Symbol = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Biotype = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genes", x => x.Id);
                    table.UniqueConstraint("AK_Genes_StableId", x => x.StableId);
                    table.ForeignKey(
                        name: "FK_Genes_Chromosomes_ChromosomeId",
                        column: x => x.ChromosomeId,
                        principalSchema: "gen",
                        principalTable: "Chromosomes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CNVs",
                schema: "gen",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TypeId = table.Column<int>(type: "integer", nullable: true),
                    Loh = table.Column<bool>(type: "boolean", nullable: true),
                    HomoDel = table.Column<bool>(type: "boolean", nullable: true),
                    C1Mean = table.Column<double>(type: "double precision", nullable: true),
                    C2Mean = table.Column<double>(type: "double precision", nullable: true),
                    TcnMean = table.Column<double>(type: "double precision", nullable: true),
                    C1 = table.Column<int>(type: "integer", nullable: true),
                    C2 = table.Column<int>(type: "integer", nullable: true),
                    Tcn = table.Column<int>(type: "integer", nullable: true),
                    TcnRatio = table.Column<double>(type: "double precision", nullable: true),
                    DhMax = table.Column<double>(type: "double precision", nullable: true),
                    ChromosomeId = table.Column<int>(type: "integer", nullable: false),
                    Start = table.Column<int>(type: "integer", nullable: false),
                    End = table.Column<int>(type: "integer", nullable: false),
                    Length = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CNVs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CNVs_Chromosomes_ChromosomeId",
                        column: x => x.ChromosomeId,
                        principalSchema: "gen",
                        principalTable: "Chromosomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CNVs_CnvTypes_TypeId",
                        column: x => x.TypeId,
                        principalSchema: "gen",
                        principalTable: "CnvTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Images",
                schema: "img",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DonorId = table.Column<int>(type: "integer", nullable: false),
                    ScanningDate = table.Column<DateOnly>(type: "date", nullable: true),
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
                    CreationDate = table.Column<DateOnly>(type: "date", nullable: true),
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
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProjectDonors",
                schema: "don",
                columns: table => new
                {
                    DonorId = table.Column<int>(type: "integer", nullable: false),
                    ProjectId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDonors", x => new { x.DonorId, x.ProjectId });
                    table.ForeignKey(
                        name: "FK_ProjectDonors_Donors_DonorId",
                        column: x => x.DonorId,
                        principalSchema: "don",
                        principalTable: "Donors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectDonors_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalSchema: "don",
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SSMs",
                schema: "gen",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TypeId = table.Column<int>(type: "integer", nullable: false),
                    ReferenceBase = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    AlternateBase = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    ChromosomeId = table.Column<int>(type: "integer", nullable: false),
                    Start = table.Column<int>(type: "integer", nullable: false),
                    End = table.Column<int>(type: "integer", nullable: false),
                    Length = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SSMs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SSMs_Chromosomes_ChromosomeId",
                        column: x => x.ChromosomeId,
                        principalSchema: "gen",
                        principalTable: "Chromosomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SSMs_SsmTypes_TypeId",
                        column: x => x.TypeId,
                        principalSchema: "gen",
                        principalTable: "SsmTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudyDonors",
                schema: "don",
                columns: table => new
                {
                    DonorId = table.Column<int>(type: "integer", nullable: false),
                    StudyId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyDonors", x => new { x.DonorId, x.StudyId });
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
                    SubmissionTypeId = table.Column<int>(type: "integer", nullable: true),
                    AnnotationTypeId = table.Column<int>(type: "integer", nullable: true),
                    IndexingTypeId = table.Column<int>(type: "integer", nullable: true),
                    Target = table.Column<string>(type: "text", nullable: false),
                    Data = table.Column<string>(type: "text", nullable: true),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_AnnotationTaskTypes_AnnotationTypeId",
                        column: x => x.AnnotationTypeId,
                        principalSchema: "com",
                        principalTable: "AnnotationTaskTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tasks_IndexingTaskTypes_IndexingTypeId",
                        column: x => x.IndexingTypeId,
                        principalSchema: "com",
                        principalTable: "IndexingTaskTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tasks_SubmissionTaskTypes_SubmissionTypeId",
                        column: x => x.SubmissionTypeId,
                        principalSchema: "com",
                        principalTable: "SubmissionTaskTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SVs",
                schema: "gen",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OtherChromosomeId = table.Column<int>(type: "integer", nullable: false),
                    OtherStart = table.Column<int>(type: "integer", nullable: false),
                    OtherEnd = table.Column<int>(type: "integer", nullable: false),
                    TypeId = table.Column<int>(type: "integer", nullable: false),
                    Inverted = table.Column<bool>(type: "boolean", nullable: true),
                    FlankingSequenceFrom = table.Column<string>(type: "text", nullable: true),
                    FlankingSequenceTo = table.Column<string>(type: "text", nullable: true),
                    ChromosomeId = table.Column<int>(type: "integer", nullable: false),
                    Start = table.Column<int>(type: "integer", nullable: false),
                    End = table.Column<int>(type: "integer", nullable: false),
                    Length = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SVs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SVs_Chromosomes_ChromosomeId",
                        column: x => x.ChromosomeId,
                        principalSchema: "gen",
                        principalTable: "Chromosomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SVs_Chromosomes_OtherChromosomeId",
                        column: x => x.OtherChromosomeId,
                        principalSchema: "gen",
                        principalTable: "Chromosomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SVs_SvTypes_TypeId",
                        column: x => x.TypeId,
                        principalSchema: "gen",
                        principalTable: "SvTypes",
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
                    StartDate = table.Column<DateOnly>(type: "date", nullable: true),
                    StartDay = table.Column<int>(type: "integer", nullable: true),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DurationDays = table.Column<int>(type: "integer", nullable: true),
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
                    DiagnosisDate = table.Column<DateOnly>(type: "date", nullable: true),
                    PrimarySiteId = table.Column<int>(type: "integer", nullable: true),
                    LocalizationId = table.Column<int>(type: "integer", nullable: true),
                    VitalStatus = table.Column<bool>(type: "boolean", nullable: true),
                    VitalStatusChangeDate = table.Column<DateOnly>(type: "date", nullable: true),
                    VitalStatusChangeDay = table.Column<int>(type: "integer", nullable: true),
                    ProgressionStatus = table.Column<bool>(type: "boolean", nullable: true),
                    ProgressionStatusChangeDate = table.Column<DateOnly>(type: "date", nullable: true),
                    ProgressionStatusChangeDay = table.Column<int>(type: "integer", nullable: true),
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClinicalData_TumorLocalizations_LocalizationId",
                        column: x => x.LocalizationId,
                        principalSchema: "don",
                        principalTable: "TumorLocalizations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClinicalData_TumorPrimarySites_PrimarySiteId",
                        column: x => x.PrimarySiteId,
                        principalSchema: "don",
                        principalTable: "TumorPrimarySites",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Transcripts",
                schema: "gen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StableId = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    GeneId = table.Column<int>(type: "integer", nullable: true),
                    ChromosomeId = table.Column<int>(type: "integer", nullable: true),
                    Start = table.Column<int>(type: "integer", nullable: true),
                    End = table.Column<int>(type: "integer", nullable: true),
                    Strand = table.Column<bool>(type: "boolean", nullable: true),
                    ExonicLength = table.Column<int>(type: "integer", nullable: true),
                    Symbol = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Biotype = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    IsCanonical = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transcripts", x => x.Id);
                    table.UniqueConstraint("AK_Transcripts_StableId", x => x.StableId);
                    table.ForeignKey(
                        name: "FK_Transcripts_Chromosomes_ChromosomeId",
                        column: x => x.ChromosomeId,
                        principalSchema: "gen",
                        principalTable: "Chromosomes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Transcripts_Genes_GeneId",
                        column: x => x.GeneId,
                        principalSchema: "gen",
                        principalTable: "Genes",
                        principalColumn: "Id");
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CellLines_CellLineTypes_TypeId",
                        column: x => x.TypeId,
                        principalSchema: "spe",
                        principalTable: "CellLineTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CellLines_Species_SpeciesId",
                        column: x => x.SpeciesId,
                        principalSchema: "spe",
                        principalTable: "Species",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CellLines_Specimens_SpecimenId",
                        column: x => x.SpecimenId,
                        principalSchema: "spe",
                        principalTable: "Specimens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DrugScreenings",
                schema: "spe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SpecimenId = table.Column<int>(type: "integer", nullable: false),
                    DrugId = table.Column<int>(type: "integer", nullable: false),
                    Dss = table.Column<double>(type: "double precision", nullable: true),
                    DssSelective = table.Column<double>(type: "double precision", nullable: true),
                    Gof = table.Column<double>(type: "double precision", nullable: true),
                    MinConcentration = table.Column<double>(type: "double precision", nullable: true),
                    MaxConcentration = table.Column<double>(type: "double precision", nullable: true),
                    AbsIC25 = table.Column<double>(type: "double precision", nullable: true),
                    AbsIC50 = table.Column<double>(type: "double precision", nullable: true),
                    AbsIC75 = table.Column<double>(type: "double precision", nullable: true),
                    Concentration = table.Column<string>(type: "text", nullable: true),
                    Inhibition = table.Column<string>(type: "text", nullable: true),
                    Dose = table.Column<string>(type: "text", nullable: true),
                    Response = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugScreenings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DrugScreenings_Drugs_DrugId",
                        column: x => x.DrugId,
                        principalSchema: "spe",
                        principalTable: "Drugs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DrugScreenings_Specimens_SpecimenId",
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MolecularData_IdhMutations_IdhMutationId",
                        column: x => x.IdhMutationId,
                        principalSchema: "spe",
                        principalTable: "IdhMutations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MolecularData_IdhStatuses_IdhStatusId",
                        column: x => x.IdhStatusId,
                        principalSchema: "spe",
                        principalTable: "IdhStatuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MolecularData_MethylationSubtypes_MethylationSubtypeId",
                        column: x => x.MethylationSubtypeId,
                        principalSchema: "spe",
                        principalTable: "MethylationSubtypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MolecularData_MgmtStatuses_MgmtStatusId",
                        column: x => x.MgmtStatusId,
                        principalSchema: "spe",
                        principalTable: "MgmtStatuses",
                        principalColumn: "Id");
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tissues_TissueTypes_TypeId",
                        column: x => x.TypeId,
                        principalSchema: "spe",
                        principalTable: "TissueTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tissues_TumorTypes_TumorTypeId",
                        column: x => x.TumorTypeId,
                        principalSchema: "spe",
                        principalTable: "TumorTypes",
                        principalColumn: "Id");
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
                        principalColumn: "Id");
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Xenografts_TumorGrowthForms_TumorGrowthFormId",
                        column: x => x.TumorGrowthFormId,
                        principalSchema: "spe",
                        principalTable: "TumorGrowthForms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CnvAffectedTranscripts",
                schema: "gen",
                columns: table => new
                {
                    VariantId = table.Column<long>(type: "bigint", nullable: false),
                    FeatureId = table.Column<int>(type: "integer", nullable: false),
                    Distance = table.Column<int>(type: "integer", nullable: true),
                    OverlapBpNumber = table.Column<int>(type: "integer", nullable: true),
                    OverlapPercentage = table.Column<double>(type: "double precision", nullable: true),
                    CDNAStart = table.Column<int>(type: "integer", nullable: true),
                    CDNAEnd = table.Column<int>(type: "integer", nullable: true),
                    CDSStart = table.Column<int>(type: "integer", nullable: true),
                    CDSEnd = table.Column<int>(type: "integer", nullable: true),
                    ProteinStart = table.Column<int>(type: "integer", nullable: true),
                    ProteinEnd = table.Column<int>(type: "integer", nullable: true),
                    Consequences = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CnvAffectedTranscripts", x => new { x.VariantId, x.FeatureId });
                    table.ForeignKey(
                        name: "FK_CnvAffectedTranscripts_CNVs_VariantId",
                        column: x => x.VariantId,
                        principalSchema: "gen",
                        principalTable: "CNVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CnvAffectedTranscripts_Transcripts_FeatureId",
                        column: x => x.FeatureId,
                        principalSchema: "gen",
                        principalTable: "Transcripts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Proteins",
                schema: "gen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StableId = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    TranscriptId = table.Column<int>(type: "integer", nullable: true),
                    Start = table.Column<int>(type: "integer", nullable: true),
                    End = table.Column<int>(type: "integer", nullable: true),
                    Length = table.Column<int>(type: "integer", nullable: true),
                    IsCanonical = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proteins", x => x.Id);
                    table.UniqueConstraint("AK_Proteins_StableId", x => x.StableId);
                    table.ForeignKey(
                        name: "FK_Proteins_Transcripts_TranscriptId",
                        column: x => x.TranscriptId,
                        principalSchema: "gen",
                        principalTable: "Transcripts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SsmAffectedTranscripts",
                schema: "gen",
                columns: table => new
                {
                    VariantId = table.Column<long>(type: "bigint", nullable: false),
                    FeatureId = table.Column<int>(type: "integer", nullable: false),
                    Distance = table.Column<int>(type: "integer", nullable: true),
                    CDNAStart = table.Column<int>(type: "integer", nullable: true),
                    CDNAEnd = table.Column<int>(type: "integer", nullable: true),
                    CDSStart = table.Column<int>(type: "integer", nullable: true),
                    CDSEnd = table.Column<int>(type: "integer", nullable: true),
                    ProteinStart = table.Column<int>(type: "integer", nullable: true),
                    ProteinEnd = table.Column<int>(type: "integer", nullable: true),
                    AminoAcidChange = table.Column<string>(type: "text", nullable: true),
                    CodonChange = table.Column<string>(type: "text", nullable: true),
                    Consequences = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SsmAffectedTranscripts", x => new { x.VariantId, x.FeatureId });
                    table.ForeignKey(
                        name: "FK_SsmAffectedTranscripts_SSMs_VariantId",
                        column: x => x.VariantId,
                        principalSchema: "gen",
                        principalTable: "SSMs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SsmAffectedTranscripts_Transcripts_FeatureId",
                        column: x => x.FeatureId,
                        principalSchema: "gen",
                        principalTable: "Transcripts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SvAffectedTranscripts",
                schema: "gen",
                columns: table => new
                {
                    VariantId = table.Column<long>(type: "bigint", nullable: false),
                    FeatureId = table.Column<int>(type: "integer", nullable: false),
                    Distance = table.Column<int>(type: "integer", nullable: true),
                    OverlapBpNumber = table.Column<int>(type: "integer", nullable: true),
                    OverlapPercentage = table.Column<double>(type: "double precision", nullable: true),
                    CDNAStart = table.Column<int>(type: "integer", nullable: true),
                    CDNAEnd = table.Column<int>(type: "integer", nullable: true),
                    CDSStart = table.Column<int>(type: "integer", nullable: true),
                    CDSEnd = table.Column<int>(type: "integer", nullable: true),
                    ProteinStart = table.Column<int>(type: "integer", nullable: true),
                    ProteinEnd = table.Column<int>(type: "integer", nullable: true),
                    Consequences = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SvAffectedTranscripts", x => new { x.VariantId, x.FeatureId });
                    table.ForeignKey(
                        name: "FK_SvAffectedTranscripts_SVs_VariantId",
                        column: x => x.VariantId,
                        principalSchema: "gen",
                        principalTable: "SVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SvAffectedTranscripts_Transcripts_FeatureId",
                        column: x => x.FeatureId,
                        principalSchema: "gen",
                        principalTable: "Transcripts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    EstablishmentDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
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
                    StartDate = table.Column<DateOnly>(type: "date", nullable: true),
                    StartDay = table.Column<int>(type: "integer", nullable: true),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: true),
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
                    MatchedSampleId = table.Column<int>(type: "integer", nullable: true),
                    Purity = table.Column<double>(type: "double precision", nullable: true),
                    Ploidy = table.Column<double>(type: "double precision", nullable: true)
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
                        principalColumn: "Id");
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
                    StartDate = table.Column<DateOnly>(type: "date", nullable: true),
                    StartDay = table.Column<int>(type: "integer", nullable: true),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: true),
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
                name: "CnvOccurrences",
                schema: "gen",
                columns: table => new
                {
                    VariantId = table.Column<long>(type: "bigint", nullable: false),
                    AnalysedSampleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CnvOccurrences", x => new { x.VariantId, x.AnalysedSampleId });
                    table.ForeignKey(
                        name: "FK_CnvOccurrences_AnalysedSamples_AnalysedSampleId",
                        column: x => x.AnalysedSampleId,
                        principalSchema: "gen",
                        principalTable: "AnalysedSamples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CnvOccurrences_CNVs_VariantId",
                        column: x => x.VariantId,
                        principalSchema: "gen",
                        principalTable: "CNVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GeneExpressions",
                schema: "gen",
                columns: table => new
                {
                    GeneId = table.Column<int>(type: "integer", nullable: false),
                    AnalysedSampleId = table.Column<int>(type: "integer", nullable: false),
                    Reads = table.Column<int>(type: "integer", nullable: false),
                    TPM = table.Column<double>(type: "double precision", nullable: false),
                    FPKM = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneExpressions", x => new { x.GeneId, x.AnalysedSampleId });
                    table.ForeignKey(
                        name: "FK_GeneExpressions_AnalysedSamples_AnalysedSampleId",
                        column: x => x.AnalysedSampleId,
                        principalSchema: "gen",
                        principalTable: "AnalysedSamples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GeneExpressions_Genes_GeneId",
                        column: x => x.GeneId,
                        principalSchema: "gen",
                        principalTable: "Genes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SsmOccurrences",
                schema: "gen",
                columns: table => new
                {
                    VariantId = table.Column<long>(type: "bigint", nullable: false),
                    AnalysedSampleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SsmOccurrences", x => new { x.VariantId, x.AnalysedSampleId });
                    table.ForeignKey(
                        name: "FK_SsmOccurrences_AnalysedSamples_AnalysedSampleId",
                        column: x => x.AnalysedSampleId,
                        principalSchema: "gen",
                        principalTable: "AnalysedSamples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SsmOccurrences_SSMs_VariantId",
                        column: x => x.VariantId,
                        principalSchema: "gen",
                        principalTable: "SSMs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SvOccurrences",
                schema: "gen",
                columns: table => new
                {
                    VariantId = table.Column<long>(type: "bigint", nullable: false),
                    AnalysedSampleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SvOccurrences", x => new { x.VariantId, x.AnalysedSampleId });
                    table.ForeignKey(
                        name: "FK_SvOccurrences_AnalysedSamples_AnalysedSampleId",
                        column: x => x.AnalysedSampleId,
                        principalSchema: "gen",
                        principalTable: "AnalysedSamples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SvOccurrences_SVs_VariantId",
                        column: x => x.VariantId,
                        principalSchema: "gen",
                        principalTable: "SVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "gen",
                table: "AnalysisTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Other Analysis", "Other" },
                    { 2, "Whole Genome Sequencing", "WGS" },
                    { 3, "Whole Exome Sequencing", "WES" },
                    { 4, "RNA Sequencing", "RNA-Seq" },
                    { 5, "Mass Spectrometry", "MS" },
                    { 6, "Microarray Analysis", "Microarray" }
                });

            migrationBuilder.InsertData(
                schema: "img",
                table: "AnalysisTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[] { 1, "RFE", "RFE" });

            migrationBuilder.InsertData(
                schema: "com",
                table: "AnnotationTaskTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "SSM", "SSM" },
                    { 2, "CNV", "CNV" },
                    { 3, "SV", "SV" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "CellLineCultureTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Suspension", "Suspension" },
                    { 2, "Adherent", "Adherent" },
                    { 3, "Both", "Both" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "CellLineTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Stem Cell", "Stem Cell" },
                    { 2, "Differentiated", "Differentiated" }
                });

            migrationBuilder.InsertData(
                schema: "gen",
                table: "Chromosomes",
                columns: new[] { "Id", "Name", "Value" },
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
                    { 24, "Chromosome Y", "Y" }
                });

            migrationBuilder.InsertData(
                schema: "gen",
                table: "CnvTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "TCN gain", "Gain" },
                    { 2, "TCN loss", "Loss" },
                    { 3, "TCN neutral", "Neutral" }
                });

            migrationBuilder.InsertData(
                schema: "don",
                table: "Genders",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Other", "Other" },
                    { 2, "Female", "Female" },
                    { 3, "Male", "Male" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "GeneExpressionSubtypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Classical", "Classical" },
                    { 2, "Mesenchymal", "Mesenchymal" },
                    { 3, "Proneural", "Proneural" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "IdhMutations",
                columns: new[] { "Id", "Name", "Value" },
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
                table: "IdhStatuses",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Wild Type", "Wild Type" },
                    { 2, "Mutant", "Mutant" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "ImplantTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Other", "Other" },
                    { 2, "Orhtotopical", "Orhtotopical" }
                });

            migrationBuilder.InsertData(
                schema: "com",
                table: "IndexingTaskTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Donor", "Donor" },
                    { 2, "Image", "Image" },
                    { 3, "Specimen", "Specimen" },
                    { 4, "Gene", "Gene" },
                    { 5, "SSM", "SSM" },
                    { 6, "CNV", "CNV" },
                    { 7, "SV", "SV" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "MethylationSubtypes",
                columns: new[] { "Id", "Name", "Value" },
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
                table: "MgmtStatuses",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Unmethylated", "Unmethylated" },
                    { 2, "Methylated", "Methylated" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "Species",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Human", "Human" },
                    { 2, "Mouse", "Mouse" }
                });

            migrationBuilder.InsertData(
                schema: "gen",
                table: "SsmTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Single Nucleotide Variant", "SNV" },
                    { 2, "Insertion", "INS" },
                    { 3, "Deletion", "DEL" },
                    { 4, "Multiple Nucleotide Variant", "MNV" }
                });

            migrationBuilder.InsertData(
                schema: "com",
                table: "SubmissionTaskTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "SSM", "SSM" },
                    { 2, "CNV", "CNV" },
                    { 3, "SV", "SV" },
                    { 4, "TEX", "TEX" }
                });

            migrationBuilder.InsertData(
                schema: "gen",
                table: "SvTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Duplication", "DUP" },
                    { 2, "Tandem duplication", "TDUP" },
                    { 3, "Insertion", "INS" },
                    { 4, "Deletion", "DEL" },
                    { 5, "Inversion", "INV" },
                    { 6, "Intra-choromosmal translocation", "ITX" },
                    { 7, "Inter-chromosomal translocation", "CTX" },
                    { 8, "Complex", "COM" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "TissueLocations",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Other", "Other" },
                    { 2, "Striatal", "Striatal" },
                    { 3, "Cortical", "Cortical" }
                });

            migrationBuilder.InsertData(
                schema: "spe",
                table: "TissueTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Control", "Control" },
                    { 2, "Tumor", "Tumor" }
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
                    { 1, "Primary", "Primary" },
                    { 2, "Metastasis", "Metastasis" },
                    { 3, "Recurrent", "Recurrent" }
                });

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
                name: "IX_CnvAffectedTranscripts_FeatureId",
                schema: "gen",
                table: "CnvAffectedTranscripts",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_CnvOccurrences_AnalysedSampleId",
                schema: "gen",
                table: "CnvOccurrences",
                column: "AnalysedSampleId");

            migrationBuilder.CreateIndex(
                name: "IX_CNVs_ChromosomeId",
                schema: "gen",
                table: "CNVs",
                column: "ChromosomeId");

            migrationBuilder.CreateIndex(
                name: "IX_CNVs_TypeId",
                schema: "gen",
                table: "CNVs",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Donors_ReferenceId",
                schema: "don",
                table: "Donors",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_DrugScreenings_DrugId",
                schema: "spe",
                table: "DrugScreenings",
                column: "DrugId");

            migrationBuilder.CreateIndex(
                name: "IX_DrugScreenings_SpecimenId",
                schema: "spe",
                table: "DrugScreenings",
                column: "SpecimenId");

            migrationBuilder.CreateIndex(
                name: "IX_FeatureOccurrences_AnalysedImageId",
                schema: "img",
                table: "FeatureOccurrences",
                column: "AnalysedImageId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneExpressions_AnalysedSampleId",
                schema: "gen",
                table: "GeneExpressions",
                column: "AnalysedSampleId");

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
                name: "IX_ProjectDonors_ProjectId",
                schema: "don",
                table: "ProjectDonors",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Proteins_TranscriptId",
                schema: "gen",
                table: "Proteins",
                column: "TranscriptId",
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
                name: "IX_SsmAffectedTranscripts_FeatureId",
                schema: "gen",
                table: "SsmAffectedTranscripts",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_SsmOccurrences_AnalysedSampleId",
                schema: "gen",
                table: "SsmOccurrences",
                column: "AnalysedSampleId");

            migrationBuilder.CreateIndex(
                name: "IX_SSMs_ChromosomeId",
                schema: "gen",
                table: "SSMs",
                column: "ChromosomeId");

            migrationBuilder.CreateIndex(
                name: "IX_SSMs_TypeId",
                schema: "gen",
                table: "SSMs",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyDonors_StudyId",
                schema: "don",
                table: "StudyDonors",
                column: "StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_SvAffectedTranscripts_FeatureId",
                schema: "gen",
                table: "SvAffectedTranscripts",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_SvOccurrences_AnalysedSampleId",
                schema: "gen",
                table: "SvOccurrences",
                column: "AnalysedSampleId");

            migrationBuilder.CreateIndex(
                name: "IX_SVs_ChromosomeId",
                schema: "gen",
                table: "SVs",
                column: "ChromosomeId");

            migrationBuilder.CreateIndex(
                name: "IX_SVs_OtherChromosomeId",
                schema: "gen",
                table: "SVs",
                column: "OtherChromosomeId");

            migrationBuilder.CreateIndex(
                name: "IX_SVs_TypeId",
                schema: "gen",
                table: "SVs",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_AnnotationTypeId",
                schema: "com",
                table: "Tasks",
                column: "AnnotationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_IndexingTypeId",
                schema: "com",
                table: "Tasks",
                column: "IndexingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_SubmissionTypeId",
                schema: "com",
                table: "Tasks",
                column: "SubmissionTypeId");

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
                name: "CellLineInfo",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "ClinicalData",
                schema: "don");

            migrationBuilder.DropTable(
                name: "CnvAffectedTranscripts",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "CnvOccurrences",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "DrugScreenings",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "FeatureOccurrences",
                schema: "img");

            migrationBuilder.DropTable(
                name: "GeneExpressions",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "MolecularData",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "MriImages",
                schema: "img");

            migrationBuilder.DropTable(
                name: "OrganoidInterventions",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "ProjectDonors",
                schema: "don");

            migrationBuilder.DropTable(
                name: "Proteins",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "SsmAffectedTranscripts",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "SsmOccurrences",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "StudyDonors",
                schema: "don");

            migrationBuilder.DropTable(
                name: "SvAffectedTranscripts",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "SvOccurrences",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "Tasks",
                schema: "com");

            migrationBuilder.DropTable(
                name: "Tissues",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "Treatments",
                schema: "don");

            migrationBuilder.DropTable(
                name: "XenograftInterventions",
                schema: "spe");

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
                name: "CNVs",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "Drugs",
                schema: "spe");

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
                name: "OrganoidInterventionTypes",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "Organoids",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "Projects",
                schema: "don");

            migrationBuilder.DropTable(
                name: "SSMs",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "Studies",
                schema: "don");

            migrationBuilder.DropTable(
                name: "Transcripts",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "AnalysedSamples",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "SVs",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "AnnotationTaskTypes",
                schema: "com");

            migrationBuilder.DropTable(
                name: "IndexingTaskTypes",
                schema: "com");

            migrationBuilder.DropTable(
                name: "SubmissionTaskTypes",
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
                name: "XenograftInterventionTypes",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "Xenografts",
                schema: "spe");

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
                name: "CnvTypes",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "Analyses",
                schema: "img");

            migrationBuilder.DropTable(
                name: "Images",
                schema: "img");

            migrationBuilder.DropTable(
                name: "SsmTypes",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "Genes",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "Analyses",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "Samples",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "SvTypes",
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
                name: "AnalysisTypes",
                schema: "img");

            migrationBuilder.DropTable(
                name: "Chromosomes",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "AnalysisTypes",
                schema: "gen");

            migrationBuilder.DropTable(
                name: "Specimens",
                schema: "spe");

            migrationBuilder.DropTable(
                name: "Donors",
                schema: "don");
        }
    }
}
