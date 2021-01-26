using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

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
                    Id = table.Column<int>(nullable: false),
                    Value = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
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
                    Id = table.Column<int>(nullable: false),
                    Value = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
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
                    Id = table.Column<int>(nullable: false),
                    Value = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chromosomes", x => x.Id);
                    table.UniqueConstraint("AK_Chromosomes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "Contigs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contigs", x => x.Id);
                    table.UniqueConstraint("AK_Contigs_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Link = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: true),
                    Updated = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Value = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                    table.UniqueConstraint("AK_Genders_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "Genes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genes", x => x.Id);
                    table.UniqueConstraint("AK_Genes_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Localizations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localizations", x => x.Id);
                    table.UniqueConstraint("AK_Localizations_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "MutationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Value = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(maxLength: 50, nullable: false)
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
                    Id = table.Column<int>(nullable: false),
                    Value = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
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
                    Id = table.Column<int>(nullable: false),
                    Value = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
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
                    Id = table.Column<int>(nullable: false),
                    Value = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Therapies", x => x.Id);
                    table.UniqueConstraint("AK_Therapies_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "VitalStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Value = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkPackages", x => x.Id);
                    table.UniqueConstraint("AK_WorkPackages_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Analyses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 500, nullable: false),
                    TypeId = table.Column<int>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    FileId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analyses", x => x.Id);
                    table.UniqueConstraint("AK_Analyses_Name", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Analyses_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Analyses_AnalysisTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "AnalysisTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Donors",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 100, nullable: false),
                    Diagnosis = table.Column<string>(maxLength: 100, nullable: true),
                    DiagnosisDate = table.Column<DateTime>(nullable: true),
                    PrimarySiteId = table.Column<int>(nullable: true),
                    Origin = table.Column<string>(maxLength: 100, nullable: true),
                    MtaProtected = table.Column<bool>(nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 500, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    GeneId = table.Column<int>(nullable: true),
                    ChromosomeId = table.Column<int>(nullable: true),
                    ContigId = table.Column<int>(nullable: true),
                    SequenceTypeId = table.Column<int>(nullable: false),
                    Position = table.Column<int>(nullable: false),
                    TypeId = table.Column<int>(nullable: false),
                    ReferenceBase = table.Column<string>(maxLength: 200, nullable: true),
                    AlternateBase = table.Column<string>(maxLength: 200, nullable: true)
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mutations_Contigs_ContigId",
                        column: x => x.ContigId,
                        principalTable: "Contigs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mutations_Genes_GeneId",
                        column: x => x.GeneId,
                        principalTable: "Genes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mutations_SequenceTypes_SequenceTypeId",
                        column: x => x.SequenceTypeId,
                        principalTable: "SequenceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mutations_MutationTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "MutationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClinicalData",
                columns: table => new
                {
                    DonorId = table.Column<string>(nullable: false),
                    GenderId = table.Column<int>(nullable: true),
                    Age = table.Column<int>(nullable: true),
                    AgeCategoryId = table.Column<int>(nullable: true),
                    LocalizationId = table.Column<int>(nullable: true),
                    VitalStatusId = table.Column<int>(nullable: true),
                    VitalStatusChangeDate = table.Column<DateTime>(nullable: true),
                    SurvivalDays = table.Column<int>(nullable: true),
                    ProgressionDate = table.Column<DateTime>(nullable: true),
                    ProgressionFreeDays = table.Column<int>(nullable: true),
                    RelapseDate = table.Column<DateTime>(nullable: true),
                    RelapseFreeDays = table.Column<int>(nullable: true),
                    KpsBaseline = table.Column<int>(nullable: true),
                    SteroidsBaseline = table.Column<bool>(nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    DonorId = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
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
                name: "Samples",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    DonorId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 500, nullable: true),
                    TypeId = table.Column<int>(nullable: true),
                    SubtypeId = table.Column<int>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true)
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
                    StudyId = table.Column<int>(nullable: false),
                    DonorId = table.Column<string>(nullable: false)
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
                    DonorId = table.Column<string>(nullable: false),
                    TherapyId = table.Column<int>(nullable: false),
                    Details = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true),
                    Results = table.Column<string>(nullable: true)
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
                    WorkPackageId = table.Column<int>(nullable: false),
                    DonorId = table.Column<string>(nullable: false)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MutationId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AnalysisId = table.Column<int>(nullable: false),
                    SampleId = table.Column<int>(nullable: false)
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
                    AnalysedSampleId = table.Column<int>(nullable: false),
                    MatchedSampleId = table.Column<int>(nullable: false)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AnalysedSampleId = table.Column<int>(nullable: false),
                    MutationId = table.Column<int>(nullable: false)
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
                    { 6, "Amplicon", "Amplicon" },
                    { 5, "Validation", "Validation" },
                    { 3, "WGA", "WGA" },
                    { 2, "WES", "WES" },
                    { 1, "WGS", "WGS" },
                    { 4, "RNASeq", "RNASeq" }
                });

            migrationBuilder.InsertData(
                table: "Chromosomes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 21, "Chromosome 21", "21" },
                    { 22, "Chromosome 22", "22" },
                    { 11, "Chromosome 11", "11" },
                    { 23, "Chromosome X", "X" },
                    { 24, "Chromosome Y", "Y" },
                    { 19, "Chromosome 19", "19" },
                    { 18, "Chromosome 18", "18" },
                    { 17, "Chromosome 17", "17" },
                    { 16, "Chromosome 16", "16" },
                    { 15, "Chromosome 15", "15" },
                    { 14, "Chromosome 14", "14" },
                    { 12, "Chromosome 12", "12" },
                    { 20, "Chromosome 20", "20" },
                    { 10, "Chromosome 10", "10" },
                    { 13, "Chromosome 13", "13" },
                    { 8, "Chromosome 8", "8" },
                    { 7, "Chromosome 7", "7" },
                    { 6, "Chromosome 6", "6" },
                    { 5, "Chromosome 5", "5" },
                    { 4, "Chromosome 4", "4" },
                    { 3, "Chromosome 3", "3" },
                    { 2, "Chromosome 2", "2" },
                    { 1, "Chromosome 1", "1" },
                    { 9, "Chromosome 9", "9" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Other", "Other" },
                    { 3, "Male", "Male" },
                    { 2, "Female", "Female" }
                });

            migrationBuilder.InsertData(
                table: "MutationTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 4, "Multiple Nucleotide Variant", "MNV" },
                    { 3, "Deletion", "DEL" },
                    { 2, "Insertion", "INS" },
                    { 1, "Single Nucleotide Variant", "SNV" }
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
                    { 6, "RNA", "r" },
                    { 1, "Coding DNA", "c" },
                    { 2, "Non Coding DNA", "n" },
                    { 3, "Linear Genomic DNA", "g" },
                    { 4, "Curcular Genomic DNA", "o" },
                    { 5, "Mitochondrial DNA", "m" },
                    { 7, "Protein", "p" }
                });

            migrationBuilder.InsertData(
                table: "VitalStatuses",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 2, "Deceased", "Deceased" },
                    { 1, "Living", "Living" }
                });

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
                name: "IX_Mutations_ContigId",
                table: "Mutations",
                column: "ContigId");

            migrationBuilder.CreateIndex(
                name: "IX_Mutations_GeneId",
                table: "Mutations",
                column: "GeneId");

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
                name: "AnalysedSamples");

            migrationBuilder.DropTable(
                name: "Mutations");

            migrationBuilder.DropTable(
                name: "Studies");

            migrationBuilder.DropTable(
                name: "Therapies");

            migrationBuilder.DropTable(
                name: "WorkPackages");

            migrationBuilder.DropTable(
                name: "Analyses");

            migrationBuilder.DropTable(
                name: "Samples");

            migrationBuilder.DropTable(
                name: "Chromosomes");

            migrationBuilder.DropTable(
                name: "Contigs");

            migrationBuilder.DropTable(
                name: "Genes");

            migrationBuilder.DropTable(
                name: "SequenceTypes");

            migrationBuilder.DropTable(
                name: "MutationTypes");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "AnalysisTypes");

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
