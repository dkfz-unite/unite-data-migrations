using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Unite.Data.Migrations.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnalysisTypes",
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
                name: "Biotypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biotypes", x => x.Id);
                    table.UniqueConstraint("AK_Biotypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "CellLineTypes",
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
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Link = table.Column<string>(type: "text", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Updated = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
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
                name: "IDHMutations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IDHMutations", x => x.Id);
                    table.UniqueConstraint("AK_IDHMutations_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "IDHStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IDHStatuses", x => x.Id);
                    table.UniqueConstraint("AK_IDHStatuses_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "MethylationStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MethylationStatuses", x => x.Id);
                    table.UniqueConstraint("AK_MethylationStatuses_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "MethylationSubtypes",
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
                name: "MutationTypes",
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
                name: "SequenceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SequenceTypes", x => x.Id);
                    table.UniqueConstraint("AK_SequenceTypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "Species",
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
                name: "TissueSources",
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
                name: "TumourLocalizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TumourLocalizations", x => x.Id);
                    table.UniqueConstraint("AK_TumourLocalizations_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "TumourPrimarySites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TumourPrimarySites", x => x.Id);
                    table.UniqueConstraint("AK_TumourPrimarySites_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "TumourTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TumourTypes", x => x.Id);
                    table.UniqueConstraint("AK_TumourTypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.UniqueConstraint("AK_Users_Email", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "WorkPackages",
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
                name: "Genes",
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
                        name: "FK_Genes_Biotypes_BiotypeId",
                        column: x => x.BiotypeId,
                        principalTable: "Biotypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transcripts",
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
                    table.PrimaryKey("PK_Transcripts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transcripts_Biotypes_BiotypeId",
                        column: x => x.BiotypeId,
                        principalTable: "Biotypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Specimens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ParentId = table.Column<int>(type: "integer", nullable: true),
                    ReferenceId = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    DonorId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specimens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Specimens_Donors_DonorId",
                        column: x => x.DonorId,
                        principalTable: "Donors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Specimens_Specimens_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Specimens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Analyses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ReferenceId = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    TypeId = table.Column<int>(type: "integer", nullable: true),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    FileId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analyses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Analyses_AnalysisTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "AnalysisTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Analyses_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mutations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    ChromosomeId = table.Column<int>(type: "integer", nullable: false),
                    SequenceTypeId = table.Column<int>(type: "integer", nullable: false),
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
                        principalTable: "Chromosomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mutations_MutationTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "MutationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mutations_SequenceTypes_SequenceTypeId",
                        column: x => x.SequenceTypeId,
                        principalTable: "SequenceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudyDonors",
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
                        principalTable: "Donors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudyDonors_Studies_StudyId",
                        column: x => x.StudyId,
                        principalTable: "Studies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
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
                        principalTable: "TaskTargetTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_TaskTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "TaskTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Treatments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DonorId = table.Column<int>(type: "integer", nullable: false),
                    TherapyId = table.Column<int>(type: "integer", nullable: false),
                    Details = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    EndDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ProgressionStatus = table.Column<bool>(type: "boolean", nullable: true),
                    ProgressionStatusChangeDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Results = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treatments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Treatments_Donors_DonorId",
                        column: x => x.DonorId,
                        principalTable: "Donors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Treatments_Therapies_TherapyId",
                        column: x => x.TherapyId,
                        principalTable: "Therapies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClinicalData",
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
                    KpsBaseline = table.Column<int>(type: "integer", nullable: true),
                    SteroidsBaseline = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicalData", x => x.DonorId);
                    table.ForeignKey(
                        name: "FK_ClinicalData_Donors_DonorId",
                        column: x => x.DonorId,
                        principalTable: "Donors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClinicalData_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClinicalData_TumourLocalizations_LocalizationId",
                        column: x => x.LocalizationId,
                        principalTable: "TumourLocalizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClinicalData_TumourPrimarySites_PrimarySiteId",
                        column: x => x.PrimarySiteId,
                        principalTable: "TumourPrimarySites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserSessions",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Session = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Client = table.Column<string>(type: "text", nullable: true),
                    Token = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSessions", x => new { x.UserId, x.Session });
                    table.ForeignKey(
                        name: "FK_UserSessions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkPackageDonors",
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
                        principalTable: "Donors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkPackageDonors_WorkPackages_WorkPackageId",
                        column: x => x.WorkPackageId,
                        principalTable: "WorkPackages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GeneInfo",
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
                        principalTable: "Genes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TranscriptInfo",
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
                        principalTable: "Transcripts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CellLines",
                columns: table => new
                {
                    SpecimenId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    TypeId = table.Column<int>(type: "integer", nullable: true),
                    SpeciesId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CellLines", x => x.SpecimenId);
                    table.ForeignKey(
                        name: "FK_CellLines_CellLineTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "CellLineTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CellLines_Species_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Species",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CellLines_Specimens_SpecimenId",
                        column: x => x.SpecimenId,
                        principalTable: "Specimens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MolecularData",
                columns: table => new
                {
                    SpecimenId = table.Column<int>(type: "integer", nullable: false),
                    GeneExpressionSubtypeId = table.Column<int>(type: "integer", nullable: true),
                    IdhStatusId = table.Column<int>(type: "integer", nullable: true),
                    IdhMutationId = table.Column<int>(type: "integer", nullable: true),
                    MethylationStatusId = table.Column<int>(type: "integer", nullable: true),
                    MethylationSubtypeId = table.Column<int>(type: "integer", nullable: true),
                    GcimpMethylation = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MolecularData", x => x.SpecimenId);
                    table.ForeignKey(
                        name: "FK_MolecularData_GeneExpressionSubtypes_GeneExpressionSubtypeId",
                        column: x => x.GeneExpressionSubtypeId,
                        principalTable: "GeneExpressionSubtypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MolecularData_IDHMutations_IdhMutationId",
                        column: x => x.IdhMutationId,
                        principalTable: "IDHMutations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MolecularData_IDHStatuses_IdhStatusId",
                        column: x => x.IdhStatusId,
                        principalTable: "IDHStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MolecularData_MethylationStatuses_MethylationStatusId",
                        column: x => x.MethylationStatusId,
                        principalTable: "MethylationStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MolecularData_MethylationSubtypes_MethylationSubtypeId",
                        column: x => x.MethylationSubtypeId,
                        principalTable: "MethylationSubtypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MolecularData_Specimens_SpecimenId",
                        column: x => x.SpecimenId,
                        principalTable: "Specimens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Samples",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ReferenceId = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    SpecimenId = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Samples", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Samples_Specimens_SpecimenId",
                        column: x => x.SpecimenId,
                        principalTable: "Specimens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tissues",
                columns: table => new
                {
                    SpecimenId = table.Column<int>(type: "integer", nullable: false),
                    SourceId = table.Column<int>(type: "integer", nullable: true),
                    TypeId = table.Column<int>(type: "integer", nullable: true),
                    TumourTypeId = table.Column<int>(type: "integer", nullable: true),
                    ExtractionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tissues", x => x.SpecimenId);
                    table.ForeignKey(
                        name: "FK_Tissues_Specimens_SpecimenId",
                        column: x => x.SpecimenId,
                        principalTable: "Specimens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tissues_TissueSources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "TissueSources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tissues_TissueTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "TissueTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tissues_TumourTypes_TumourTypeId",
                        column: x => x.TumourTypeId,
                        principalTable: "TumourTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AffectedTranscripts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MutationId = table.Column<long>(type: "bigint", nullable: false),
                    GeneId = table.Column<int>(type: "integer", nullable: false),
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
                    table.UniqueConstraint("AK_AffectedTranscripts_MutationId_GeneId_TranscriptId", x => new { x.MutationId, x.GeneId, x.TranscriptId });
                    table.ForeignKey(
                        name: "FK_AffectedTranscripts_Genes_GeneId",
                        column: x => x.GeneId,
                        principalTable: "Genes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AffectedTranscripts_Mutations_MutationId",
                        column: x => x.MutationId,
                        principalTable: "Mutations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AffectedTranscripts_Transcripts_TranscriptId",
                        column: x => x.TranscriptId,
                        principalTable: "Transcripts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CellLineInfo",
                columns: table => new
                {
                    SpecimenId = table.Column<int>(type: "integer", nullable: false),
                    DepositorName = table.Column<string>(type: "text", nullable: true),
                    DepositorEstablishment = table.Column<string>(type: "text", nullable: true),
                    EstablishmentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    PublicationId = table.Column<string>(type: "text", nullable: true),
                    AtccId = table.Column<string>(type: "text", nullable: true),
                    ExPasyId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CellLineInfo", x => x.SpecimenId);
                    table.ForeignKey(
                        name: "FK_CellLineInfo_CellLines_SpecimenId",
                        column: x => x.SpecimenId,
                        principalTable: "CellLines",
                        principalColumn: "SpecimenId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnalysedSamples",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SampleId = table.Column<int>(type: "integer", nullable: false),
                    AnalysisId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalysedSamples", x => x.Id);
                    table.UniqueConstraint("AK_AnalysedSamples_AnalysisId_SampleId", x => new { x.AnalysisId, x.SampleId });
                    table.ForeignKey(
                        name: "FK_AnalysedSamples_Analyses_AnalysisId",
                        column: x => x.AnalysisId,
                        principalTable: "Analyses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnalysedSamples_Samples_SampleId",
                        column: x => x.SampleId,
                        principalTable: "Samples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AffectedTranscriptConsequences",
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
                        principalTable: "AffectedTranscripts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AffectedTranscriptConsequences_Consequences_ConsequenceId",
                        column: x => x.ConsequenceId,
                        principalTable: "Consequences",
                        principalColumn: "TypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MatchedSamples",
                columns: table => new
                {
                    AnalysedSampleId = table.Column<int>(type: "integer", nullable: false),
                    MatchedSampleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchedSamples", x => new { x.AnalysedSampleId, x.MatchedSampleId });
                    table.ForeignKey(
                        name: "FK_MatchedSamples_AnalysedSamples_AnalysedSampleId",
                        column: x => x.AnalysedSampleId,
                        principalTable: "AnalysedSamples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatchedSamples_AnalysedSamples_MatchedSampleId",
                        column: x => x.MatchedSampleId,
                        principalTable: "AnalysedSamples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MutationOccurrences",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MutationId = table.Column<long>(type: "bigint", nullable: false),
                    AnalysedSampleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MutationOccurrences", x => x.Id);
                    table.UniqueConstraint("AK_MutationOccurrences_MutationId_AnalysedSampleId", x => new { x.MutationId, x.AnalysedSampleId });
                    table.ForeignKey(
                        name: "FK_MutationOccurrences_AnalysedSamples_AnalysedSampleId",
                        column: x => x.AnalysedSampleId,
                        principalTable: "AnalysedSamples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MutationOccurrences_Mutations_MutationId",
                        column: x => x.MutationId,
                        principalTable: "Mutations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AnalysisTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 2, "WES", "WES" },
                    { 6, "Amplicon", "Amplicon" },
                    { 5, "Validation", "Validation" },
                    { 4, "RNASeq", "RNASeq" },
                    { 3, "WGA", "WGA" },
                    { 1, "WGS", "WGS" }
                });

            migrationBuilder.InsertData(
                table: "CellLineTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 2, "Suspension", "Suspension" },
                    { 1, "GSC", "GSC" }
                });

            migrationBuilder.InsertData(
                table: "Chromosomes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 16, "Chromosome 16", "16" },
                    { 17, "Chromosome 17", "17" },
                    { 18, "Chromosome 18", "18" },
                    { 19, "Chromosome 19", "19" },
                    { 11, "Chromosome 11", "11" },
                    { 21, "Chromosome 21", "21" },
                    { 15, "Chromosome 15", "15" },
                    { 22, "Chromosome 22", "22" },
                    { 23, "Chromosome X", "X" },
                    { 20, "Chromosome 20", "20" },
                    { 14, "Chromosome 14", "14" },
                    { 9, "Chromosome 9", "9" },
                    { 12, "Chromosome 12", "12" },
                    { 10, "Chromosome 10", "10" },
                    { 24, "Chromosome Y", "Y" },
                    { 8, "Chromosome 8", "8" },
                    { 7, "Chromosome 7", "7" },
                    { 6, "Chromosome 6", "6" },
                    { 5, "Chromosome 5", "5" },
                    { 1, "Chromosome 1", "1" },
                    { 2, "Chromosome 2", "2" },
                    { 13, "Chromosome 13", "13" },
                    { 3, "Chromosome 3", "3" },
                    { 4, "Chromosome 4", "4" }
                });

            migrationBuilder.InsertData(
                table: "ConsequenceImpacts",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "High", "High" },
                    { 4, "Unknown", "Unknown" },
                    { 3, "Low", "Low" },
                    { 2, "Moderate", "Moderate" }
                });

            migrationBuilder.InsertData(
                table: "ConsequenceTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 23, "Intron variant", "intron_variant" },
                    { 24, "NMD transcript variant", "NMD_transcript_variant" },
                    { 25, "Non coding transcript variant", "non_coding_transcript_variant" },
                    { 26, "Upstream gene variant", "upstream_gene_variant" },
                    { 27, "Downstream gene variant", "downstream_gene_variant" },
                    { 28, "TFBS ablation", "TFBS_ablation" },
                    { 29, "TFBS amplification", "TFBS_amplification" },
                    { 7, "Start lost", "start_lost" },
                    { 22, "Non coding transcript exon variant", "non_coding_transcript_exon_variant" },
                    { 31, "Regulatory region ablation", "regulatory_region_ablation" },
                    { 32, "Regulatory region amplification", "regulatory_region_amplification" },
                    { 33, "Feature elongation", "feature_elongation" },
                    { 34, "Regulatory region variant", "regulatory_region_variant" },
                    { 35, "Feature truncation", "feature_truncation" },
                    { 36, "Intergenic variant", "intergenic_variant" },
                    { 30, "TF binding site variant", "TF_binding_site_variant" },
                    { 21, "3 prime UTR variant", "3_prime_UTR_variant" },
                    { 18, "Coding sequence variant", "coding_sequence_variant" },
                    { 19, "Mature miRNA variant", "mature_miRNA_variant" },
                    { 6, "Stop lost", "stop_lost" },
                    { 5, "Frameshift variant", "frameshift_variant" },
                    { 9, "Inframe insertion", "inframe_insertion" },
                    { 3, "Splice donor variant", "splice_donor_variant" },
                    { 2, "Splice acceptor variant", "splice_acceptor_variant" },
                    { 1, "Transcript ablation", "transcript_ablation" },
                    { 10, "Inframe deletion", "inframe_deletion" },
                    { 11, "Missense variant", "missense_variant" },
                    { 12, "Protein altering variant", "protein_altering_variant" },
                    { 13, "Splice region variant", "splice_region_variant" },
                    { 14, "Incomplete terminal codon variant", "incomplete_terminal_codon_variant" },
                    { 15, "Start retained variant", "start_retained_variant" },
                    { 16, "Stop retained variant", "stop_retained_variant" },
                    { 17, "Synonymous variant", "synonymous_variant" },
                    { 8, "Transcript amplification", "transcript_amplification" },
                    { 20, "5 prime UTR variant", "5_prime_UTR_variant" },
                    { 4, "Stop gained", "stop_gained" }
                });

            migrationBuilder.InsertData(
                table: "Consequences",
                columns: new[] { "TypeId", "ImpactId", "Severity" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 21, 4, 21 },
                    { 32, 4, 32 },
                    { 31, 2, 31 },
                    { 30, 4, 30 },
                    { 29, 4, 29 },
                    { 28, 4, 28 },
                    { 27, 4, 27 },
                    { 26, 4, 26 },
                    { 25, 4, 25 },
                    { 24, 4, 24 },
                    { 23, 4, 23 },
                    { 22, 4, 22 },
                    { 33, 4, 33 },
                    { 6, 1, 6 },
                    { 19, 4, 19 },
                    { 18, 4, 18 },
                    { 17, 3, 17 },
                    { 16, 3, 16 },
                    { 15, 3, 15 },
                    { 14, 3, 14 },
                    { 13, 3, 13 },
                    { 12, 2, 12 },
                    { 11, 2, 11 },
                    { 10, 2, 10 },
                    { 9, 2, 9 },
                    { 20, 4, 20 },
                    { 34, 4, 34 },
                    { 35, 4, 35 },
                    { 36, 4, 36 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 1, 4 },
                    { 5, 1, 5 },
                    { 8, 1, 8 },
                    { 7, 1, 7 }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 2, "Female", "Female" },
                    { 3, "Male", "Male" },
                    { 1, "Other", "Other" }
                });

            migrationBuilder.InsertData(
                table: "GeneExpressionSubtypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Classical", "Classical" },
                    { 3, "Proneural", "Proneural" },
                    { 2, "Mesenchymal", "Mesenchymal" }
                });

            migrationBuilder.InsertData(
                table: "IDHMutations",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "IDH1 R132H", "IDH1 R132H" },
                    { 10, "IDH2 R172M", "IDH2 R172M" },
                    { 11, "IDH2 R172S", "IDH2 R172S" },
                    { 8, "IDH2 R172K", "IDH2 R172K" },
                    { 6, "IDH2 R172G", "IDH2 R172G" },
                    { 5, "IDH1 R132S", "IDH1 R132S" },
                    { 4, "IDH1 R132L", "IDH1 R132L" },
                    { 3, "IDH1 R132G", "IDH1 R132G" },
                    { 2, "IDH1 R132C", "IDH1 R132C" },
                    { 9, "IDH2 R172T", "IDH2 R172T" },
                    { 7, "IDH2 R172W", "IDH2 R172W" }
                });

            migrationBuilder.InsertData(
                table: "IDHStatuses",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Wild Type", "Wild Type" },
                    { 2, "Mutant", "Mutant" }
                });

            migrationBuilder.InsertData(
                table: "MethylationStatuses",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Unmethylated", "Unmethylated" },
                    { 2, "Methylated", "Methylated" }
                });

            migrationBuilder.InsertData(
                table: "MethylationSubtypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 4, "RTKII", "RTKII" },
                    { 2, "H3-G34", "H3-G34" },
                    { 1, "H3-K27", "H3-K27" },
                    { 3, "RTKI", "RTKI" },
                    { 5, "Mesenchymal", "Mesenchymal" }
                });

            migrationBuilder.InsertData(
                table: "MutationTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Single Nucleotide Variant", "SNV" },
                    { 2, "Insertion", "INS" },
                    { 3, "Deletion", "DEL" },
                    { 4, "Multiple Nucleotide Variant", "MNV" }
                });

            migrationBuilder.InsertData(
                table: "SequenceTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 7, "Protein", "p" },
                    { 6, "RNA", "r" },
                    { 4, "Curcular Genomic DNA", "o" },
                    { 3, "Linear Genomic DNA", "g" },
                    { 2, "Non Coding DNA", "n" },
                    { 1, "Coding DNA", "c" },
                    { 5, "Mitochondrial DNA", "m" }
                });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Human", "Human" },
                    { 2, "Mouse", "Mouse" }
                });

            migrationBuilder.InsertData(
                table: "TaskTargetTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 2, "Specimen", "Specimen" },
                    { 3, "Mutation", "Mutation" },
                    { 1, "Donor", "Donor" }
                });

            migrationBuilder.InsertData(
                table: "TaskTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Indexing", "Indexing" },
                    { 2, "Anotation", "Anotation" }
                });

            migrationBuilder.InsertData(
                table: "TissueTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 2, "Tumour", "Tumour" },
                    { 1, "Control", "Control" }
                });

            migrationBuilder.InsertData(
                table: "TumourTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 3, "Recurrent", "Recurrent" },
                    { 1, "Primary", "Primary" },
                    { 2, "Metastasis", "Metastasis" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AffectedTranscriptConsequences_ConsequenceId",
                table: "AffectedTranscriptConsequences",
                column: "ConsequenceId");

            migrationBuilder.CreateIndex(
                name: "IX_AffectedTranscripts_GeneId",
                table: "AffectedTranscripts",
                column: "GeneId");

            migrationBuilder.CreateIndex(
                name: "IX_AffectedTranscripts_TranscriptId",
                table: "AffectedTranscripts",
                column: "TranscriptId");

            migrationBuilder.CreateIndex(
                name: "IX_AnalysedSamples_SampleId",
                table: "AnalysedSamples",
                column: "SampleId");

            migrationBuilder.CreateIndex(
                name: "IX_Analyses_FileId",
                table: "Analyses",
                column: "FileId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Analyses_ReferenceId",
                table: "Analyses",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Analyses_TypeId",
                table: "Analyses",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CellLines_SpeciesId",
                table: "CellLines",
                column: "SpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_CellLines_TypeId",
                table: "CellLines",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicalData_GenderId",
                table: "ClinicalData",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicalData_LocalizationId",
                table: "ClinicalData",
                column: "LocalizationId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicalData_PrimarySiteId",
                table: "ClinicalData",
                column: "PrimarySiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Donors_ReferenceId",
                table: "Donors",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneInfo_EnsemblId",
                table: "GeneInfo",
                column: "EnsemblId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Genes_BiotypeId",
                table: "Genes",
                column: "BiotypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchedSamples_MatchedSampleId",
                table: "MatchedSamples",
                column: "MatchedSampleId");

            migrationBuilder.CreateIndex(
                name: "IX_MolecularData_GeneExpressionSubtypeId",
                table: "MolecularData",
                column: "GeneExpressionSubtypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MolecularData_IdhMutationId",
                table: "MolecularData",
                column: "IdhMutationId");

            migrationBuilder.CreateIndex(
                name: "IX_MolecularData_IdhStatusId",
                table: "MolecularData",
                column: "IdhStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_MolecularData_MethylationStatusId",
                table: "MolecularData",
                column: "MethylationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_MolecularData_MethylationSubtypeId",
                table: "MolecularData",
                column: "MethylationSubtypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MutationOccurrences_AnalysedSampleId",
                table: "MutationOccurrences",
                column: "AnalysedSampleId");

            migrationBuilder.CreateIndex(
                name: "IX_Mutations_ChromosomeId",
                table: "Mutations",
                column: "ChromosomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Mutations_SequenceTypeId",
                table: "Mutations",
                column: "SequenceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Mutations_TypeId",
                table: "Mutations",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Samples_ReferenceId",
                table: "Samples",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Samples_SpecimenId",
                table: "Samples",
                column: "SpecimenId");

            migrationBuilder.CreateIndex(
                name: "IX_Specimens_DonorId",
                table: "Specimens",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_Specimens_ParentId",
                table: "Specimens",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Specimens_ReferenceId",
                table: "Specimens",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyDonors_DonorId",
                table: "StudyDonors",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TargetTypeId",
                table: "Tasks",
                column: "TargetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TypeId",
                table: "Tasks",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tissues_SourceId",
                table: "Tissues",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Tissues_TumourTypeId",
                table: "Tissues",
                column: "TumourTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tissues_TypeId",
                table: "Tissues",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TranscriptInfo_EnsemblId",
                table: "TranscriptInfo",
                column: "EnsemblId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transcripts_BiotypeId",
                table: "Transcripts",
                column: "BiotypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_DonorId",
                table: "Treatments",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_TherapyId",
                table: "Treatments",
                column: "TherapyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSessions_Session",
                table: "UserSessions",
                column: "Session");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPackageDonors_DonorId",
                table: "WorkPackageDonors",
                column: "DonorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AffectedTranscriptConsequences");

            migrationBuilder.DropTable(
                name: "CellLineInfo");

            migrationBuilder.DropTable(
                name: "ClinicalData");

            migrationBuilder.DropTable(
                name: "ConsequenceImpacts");

            migrationBuilder.DropTable(
                name: "ConsequenceTypes");

            migrationBuilder.DropTable(
                name: "GeneInfo");

            migrationBuilder.DropTable(
                name: "MatchedSamples");

            migrationBuilder.DropTable(
                name: "MolecularData");

            migrationBuilder.DropTable(
                name: "MutationOccurrences");

            migrationBuilder.DropTable(
                name: "StudyDonors");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Tissues");

            migrationBuilder.DropTable(
                name: "TranscriptInfo");

            migrationBuilder.DropTable(
                name: "Treatments");

            migrationBuilder.DropTable(
                name: "UserSessions");

            migrationBuilder.DropTable(
                name: "WorkPackageDonors");

            migrationBuilder.DropTable(
                name: "AffectedTranscripts");

            migrationBuilder.DropTable(
                name: "Consequences");

            migrationBuilder.DropTable(
                name: "CellLines");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "TumourLocalizations");

            migrationBuilder.DropTable(
                name: "TumourPrimarySites");

            migrationBuilder.DropTable(
                name: "GeneExpressionSubtypes");

            migrationBuilder.DropTable(
                name: "IDHMutations");

            migrationBuilder.DropTable(
                name: "IDHStatuses");

            migrationBuilder.DropTable(
                name: "MethylationStatuses");

            migrationBuilder.DropTable(
                name: "MethylationSubtypes");

            migrationBuilder.DropTable(
                name: "AnalysedSamples");

            migrationBuilder.DropTable(
                name: "Studies");

            migrationBuilder.DropTable(
                name: "TaskTargetTypes");

            migrationBuilder.DropTable(
                name: "TaskTypes");

            migrationBuilder.DropTable(
                name: "TissueSources");

            migrationBuilder.DropTable(
                name: "TissueTypes");

            migrationBuilder.DropTable(
                name: "TumourTypes");

            migrationBuilder.DropTable(
                name: "Therapies");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "WorkPackages");

            migrationBuilder.DropTable(
                name: "Genes");

            migrationBuilder.DropTable(
                name: "Mutations");

            migrationBuilder.DropTable(
                name: "Transcripts");

            migrationBuilder.DropTable(
                name: "CellLineTypes");

            migrationBuilder.DropTable(
                name: "Species");

            migrationBuilder.DropTable(
                name: "Analyses");

            migrationBuilder.DropTable(
                name: "Samples");

            migrationBuilder.DropTable(
                name: "Chromosomes");

            migrationBuilder.DropTable(
                name: "MutationTypes");

            migrationBuilder.DropTable(
                name: "SequenceTypes");

            migrationBuilder.DropTable(
                name: "Biotypes");

            migrationBuilder.DropTable(
                name: "AnalysisTypes");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "Specimens");

            migrationBuilder.DropTable(
                name: "Donors");
        }
    }
}
