using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Unite.Data.Migrations.Migrations
{
    public partial class Root : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgeCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgeCategories", x => x.Id);
                    table.UniqueConstraint("AK_AgeCategories_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "AnalysisTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalysisTypes", x => x.Id);
                    table.UniqueConstraint("AK_AnalysisTypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "Chromosomes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chromosomes", x => x.Id);
                    table.UniqueConstraint("AK_Chromosomes_Value", x => x.Value);
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
                    Value = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
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
                    Value = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
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
                    Value = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
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
                    Value = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IDHStatuses", x => x.Id);
                    table.UniqueConstraint("AK_IDHStatuses_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "Localizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Value = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localizations", x => x.Id);
                    table.UniqueConstraint("AK_Localizations_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "MethylationStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
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
                    Value = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
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
                    Value = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MutationTypes", x => x.Id);
                    table.UniqueConstraint("AK_MutationTypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "PrimarySites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Value = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimarySites", x => x.Id);
                    table.UniqueConstraint("AK_PrimarySites_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "SampleSubtypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleSubtypes", x => x.Id);
                    table.UniqueConstraint("AK_SampleSubtypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "SampleTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleTypes", x => x.Id);
                    table.UniqueConstraint("AK_SampleTypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "SequenceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SequenceTypes", x => x.Id);
                    table.UniqueConstraint("AK_SequenceTypes_Value", x => x.Value);
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
                name: "VitalStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VitalStatuses", x => x.Id);
                    table.UniqueConstraint("AK_VitalStatuses_Value", x => x.Value);
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
                name: "Donors",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Diagnosis = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    DiagnosisDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    PrimarySiteId = table.Column<int>(type: "integer", nullable: true),
                    Origin = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    MtaProtected = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Donors_PrimarySites_PrimarySiteId",
                        column: x => x.PrimarySiteId,
                        principalTable: "PrimarySites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mutations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
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
                name: "Analyses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DonorId = table.Column<string>(type: "character varying(100)", nullable: false),
                    Name = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
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
                        name: "FK_Analyses_Donors_DonorId",
                        column: x => x.DonorId,
                        principalTable: "Donors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Analyses_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClinicalData",
                columns: table => new
                {
                    DonorId = table.Column<string>(type: "character varying(100)", nullable: false),
                    GenderId = table.Column<int>(type: "integer", nullable: true),
                    Age = table.Column<int>(type: "integer", nullable: true),
                    AgeCategoryId = table.Column<int>(type: "integer", nullable: true),
                    LocalizationId = table.Column<int>(type: "integer", nullable: true),
                    VitalStatusId = table.Column<int>(type: "integer", nullable: true),
                    VitalStatusChangeDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    SurvivalDays = table.Column<int>(type: "integer", nullable: true),
                    ProgressionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ProgressionFreeDays = table.Column<int>(type: "integer", nullable: true),
                    RelapseDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    RelapseFreeDays = table.Column<int>(type: "integer", nullable: true),
                    KpsBaseline = table.Column<int>(type: "integer", nullable: true),
                    SteroidsBaseline = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicalData", x => x.DonorId);
                    table.ForeignKey(
                        name: "FK_ClinicalData_AgeCategories_AgeCategoryId",
                        column: x => x.AgeCategoryId,
                        principalTable: "AgeCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        name: "FK_ClinicalData_Localizations_LocalizationId",
                        column: x => x.LocalizationId,
                        principalTable: "Localizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClinicalData_VitalStatuses_VitalStatusId",
                        column: x => x.VitalStatusId,
                        principalTable: "VitalStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DonorIndexingTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DonorId = table.Column<string>(type: "character varying(100)", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonorIndexingTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DonorIndexingTasks_Donors_DonorId",
                        column: x => x.DonorId,
                        principalTable: "Donors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EpigeneticsData",
                columns: table => new
                {
                    DonorId = table.Column<string>(type: "character varying(100)", nullable: false),
                    GeneExpressionSubtypeId = table.Column<int>(type: "integer", nullable: true),
                    IdhStatusId = table.Column<int>(type: "integer", nullable: true),
                    IdhMutationId = table.Column<int>(type: "integer", nullable: true),
                    MethylationStatusId = table.Column<int>(type: "integer", nullable: true),
                    MethylationSubtypeId = table.Column<int>(type: "integer", nullable: true),
                    GcimpMethylation = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EpigeneticsData", x => x.DonorId);
                    table.ForeignKey(
                        name: "FK_EpigeneticsData_Donors_DonorId",
                        column: x => x.DonorId,
                        principalTable: "Donors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EpigeneticsData_GeneExpressionSubtypes_GeneExpressionSubtyp~",
                        column: x => x.GeneExpressionSubtypeId,
                        principalTable: "GeneExpressionSubtypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EpigeneticsData_IDHMutations_IdhMutationId",
                        column: x => x.IdhMutationId,
                        principalTable: "IDHMutations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EpigeneticsData_IDHStatuses_IdhStatusId",
                        column: x => x.IdhStatusId,
                        principalTable: "IDHStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EpigeneticsData_MethylationStatuses_MethylationStatusId",
                        column: x => x.MethylationStatusId,
                        principalTable: "MethylationStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EpigeneticsData_MethylationSubtypes_MethylationSubtypeId",
                        column: x => x.MethylationSubtypeId,
                        principalTable: "MethylationSubtypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Samples",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DonorId = table.Column<string>(type: "character varying(100)", nullable: false),
                    Name = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    TypeId = table.Column<int>(type: "integer", nullable: true),
                    SubtypeId = table.Column<int>(type: "integer", nullable: true),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Samples", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Samples_Donors_DonorId",
                        column: x => x.DonorId,
                        principalTable: "Donors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Samples_SampleSubtypes_SubtypeId",
                        column: x => x.SubtypeId,
                        principalTable: "SampleSubtypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Samples_SampleTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "SampleTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudyDonors",
                columns: table => new
                {
                    StudyId = table.Column<int>(type: "integer", nullable: false),
                    DonorId = table.Column<string>(type: "character varying(100)", nullable: false)
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
                name: "Treatments",
                columns: table => new
                {
                    DonorId = table.Column<string>(type: "character varying(100)", nullable: false),
                    TherapyId = table.Column<int>(type: "integer", nullable: false),
                    Details = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    EndDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Results = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treatments", x => new { x.DonorId, x.TherapyId });
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
                name: "WorkPackageDonors",
                columns: table => new
                {
                    WorkPackageId = table.Column<int>(type: "integer", nullable: false),
                    DonorId = table.Column<string>(type: "character varying(100)", nullable: false)
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
                name: "MutationIndexingTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MutationId = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MutationIndexingTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MutationIndexingTasks_Mutations_MutationId",
                        column: x => x.MutationId,
                        principalTable: "Mutations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnalysedSamples",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AnalysisId = table.Column<int>(type: "integer", nullable: false),
                    SampleId = table.Column<int>(type: "integer", nullable: false)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AnalysedSampleId = table.Column<int>(type: "integer", nullable: false),
                    MutationId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MutationOccurrences", x => x.Id);
                    table.UniqueConstraint("AK_MutationOccurrences_AnalysedSampleId_MutationId", x => new { x.AnalysedSampleId, x.MutationId });
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
                table: "AgeCategories",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Pediatric", "Pediatric" },
                    { 2, "Adult", "Adult" }
                });

            migrationBuilder.InsertData(
                table: "AnalysisTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 3, "WGA", "WGA" },
                    { 4, "RNASeq", "RNASeq" },
                    { 5, "Validation", "Validation" },
                    { 6, "Amplicon", "Amplicon" },
                    { 2, "WES", "WES" },
                    { 1, "WGS", "WGS" }
                });

            migrationBuilder.InsertData(
                table: "Chromosomes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 18, "Chromosome 18", "18" },
                    { 24, "Chromosome Y", "Y" },
                    { 23, "Chromosome X", "X" },
                    { 22, "Chromosome 22", "22" },
                    { 21, "Chromosome 21", "21" },
                    { 1, "Chromosome 1", "1" },
                    { 3, "Chromosome 3", "3" },
                    { 4, "Chromosome 4", "4" },
                    { 5, "Chromosome 5", "5" },
                    { 6, "Chromosome 6", "6" },
                    { 19, "Chromosome 19", "19" },
                    { 7, "Chromosome 7", "7" },
                    { 9, "Chromosome 9", "9" },
                    { 10, "Chromosome 10", "10" },
                    { 20, "Chromosome 20", "20" },
                    { 12, "Chromosome 12", "12" },
                    { 13, "Chromosome 13", "13" },
                    { 14, "Chromosome 14", "14" },
                    { 15, "Chromosome 15", "15" },
                    { 16, "Chromosome 16", "16" },
                    { 17, "Chromosome 17", "17" },
                    { 8, "Chromosome 8", "8" },
                    { 11, "Chromosome 11", "11" },
                    { 2, "Chromosome 2", "2" }
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
                    { 2, "Mesenchymal", "Mesenchymal" },
                    { 1, "Classical", "Classical" },
                    { 3, "Proneural", "Proneural" }
                });

            migrationBuilder.InsertData(
                table: "IDHMutations",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 11, "IDH2 R172S", "IDH2 R172S" },
                    { 1, "IDH1 R132H", "IDH1 R132H" },
                    { 9, "IDH2 R172T", "IDH2 R172T" },
                    { 8, "IDH2 R172K", "IDH2 R172K" },
                    { 7, "IDH2 R172W", "IDH2 R172W" },
                    { 6, "IDH2 R172G", "IDH2 R172G" },
                    { 5, "IDH1 R132S", "IDH1 R132S" },
                    { 4, "IDH1 R132L", "IDH1 R132L" },
                    { 3, "IDH1 R132G", "IDH1 R132G" },
                    { 2, "IDH1 R132C", "IDH1 R132C" },
                    { 10, "IDH2 R172M", "IDH2 R172M" }
                });

            migrationBuilder.InsertData(
                table: "IDHStatuses",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 2, "Mutant", "Mutant" },
                    { 1, "WildType", "WildType" }
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
                    { 1, "H3-K27", "H3-K27" },
                    { 2, "H3-G34", "H3-G34" },
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
                table: "SampleSubtypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Primary", "Primary" },
                    { 2, "Recurrent", "Recurrent" }
                });

            migrationBuilder.InsertData(
                table: "SampleTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Control", "Control" },
                    { 2, "Tumor", "Tumor" }
                });

            migrationBuilder.InsertData(
                table: "SequenceTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 5, "Mitochondrial DNA", "m" },
                    { 4, "Curcular Genomic DNA", "o" },
                    { 3, "Linear Genomic DNA", "g" },
                    { 6, "RNA", "r" },
                    { 1, "Coding DNA", "c" },
                    { 2, "Non Coding DNA", "n" },
                    { 7, "Protein", "p" }
                });

            migrationBuilder.InsertData(
                table: "VitalStatuses",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Living", "Living" },
                    { 2, "Deceased", "Deceased" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnalysedSamples_SampleId",
                table: "AnalysedSamples",
                column: "SampleId");

            migrationBuilder.CreateIndex(
                name: "IX_Analyses_DonorId",
                table: "Analyses",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_Analyses_FileId",
                table: "Analyses",
                column: "FileId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Analyses_TypeId",
                table: "Analyses",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicalData_AgeCategoryId",
                table: "ClinicalData",
                column: "AgeCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicalData_GenderId",
                table: "ClinicalData",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicalData_LocalizationId",
                table: "ClinicalData",
                column: "LocalizationId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicalData_VitalStatusId",
                table: "ClinicalData",
                column: "VitalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_DonorIndexingTasks_DonorId",
                table: "DonorIndexingTasks",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_Donors_PrimarySiteId",
                table: "Donors",
                column: "PrimarySiteId");

            migrationBuilder.CreateIndex(
                name: "IX_EpigeneticsData_GeneExpressionSubtypeId",
                table: "EpigeneticsData",
                column: "GeneExpressionSubtypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EpigeneticsData_IdhMutationId",
                table: "EpigeneticsData",
                column: "IdhMutationId");

            migrationBuilder.CreateIndex(
                name: "IX_EpigeneticsData_IdhStatusId",
                table: "EpigeneticsData",
                column: "IdhStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_EpigeneticsData_MethylationStatusId",
                table: "EpigeneticsData",
                column: "MethylationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_EpigeneticsData_MethylationSubtypeId",
                table: "EpigeneticsData",
                column: "MethylationSubtypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchedSamples_MatchedSampleId",
                table: "MatchedSamples",
                column: "MatchedSampleId");

            migrationBuilder.CreateIndex(
                name: "IX_MutationIndexingTasks_MutationId",
                table: "MutationIndexingTasks",
                column: "MutationId");

            migrationBuilder.CreateIndex(
                name: "IX_MutationOccurrences_MutationId",
                table: "MutationOccurrences",
                column: "MutationId");

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
                name: "IX_Samples_DonorId",
                table: "Samples",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_Samples_SubtypeId",
                table: "Samples",
                column: "SubtypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Samples_TypeId",
                table: "Samples",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyDonors_DonorId",
                table: "StudyDonors",
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
                name: "ClinicalData");

            migrationBuilder.DropTable(
                name: "DonorIndexingTasks");

            migrationBuilder.DropTable(
                name: "EpigeneticsData");

            migrationBuilder.DropTable(
                name: "MatchedSamples");

            migrationBuilder.DropTable(
                name: "MutationIndexingTasks");

            migrationBuilder.DropTable(
                name: "MutationOccurrences");

            migrationBuilder.DropTable(
                name: "StudyDonors");

            migrationBuilder.DropTable(
                name: "Treatments");

            migrationBuilder.DropTable(
                name: "UserSessions");

            migrationBuilder.DropTable(
                name: "WorkPackageDonors");

            migrationBuilder.DropTable(
                name: "AgeCategories");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Localizations");

            migrationBuilder.DropTable(
                name: "VitalStatuses");

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
                name: "Mutations");

            migrationBuilder.DropTable(
                name: "Studies");

            migrationBuilder.DropTable(
                name: "Therapies");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "WorkPackages");

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
                name: "AnalysisTypes");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "Donors");

            migrationBuilder.DropTable(
                name: "SampleSubtypes");

            migrationBuilder.DropTable(
                name: "SampleTypes");

            migrationBuilder.DropTable(
                name: "PrimarySites");
        }
    }
}
