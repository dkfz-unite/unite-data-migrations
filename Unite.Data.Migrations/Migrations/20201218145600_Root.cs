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
                name: "CellLineTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Value = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
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
                    Value = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contigs", x => x.Id);
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
                name: "GeneExpressionSubtypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Value = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneExpressionSubtypes", x => x.Id);
                    table.UniqueConstraint("AK_GeneExpressionSubtypes_Value", x => x.Value);
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
                });

            migrationBuilder.CreateTable(
                name: "IDHMutations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Value = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
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
                    Id = table.Column<int>(nullable: false),
                    Value = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MethylationStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Value = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
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
                    Id = table.Column<int>(nullable: false),
                    Value = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
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
                name: "Species",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Value = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studies", x => x.Id);
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
                    ReferenceId = table.Column<string>(maxLength: 100, nullable: true),
                    GeneId = table.Column<int>(nullable: true),
                    ChromosomeId = table.Column<int>(nullable: true),
                    ContigId = table.Column<int>(nullable: true),
                    SequenceTypeId = table.Column<int>(nullable: false),
                    Position = table.Column<int>(nullable: false),
                    TypeId = table.Column<int>(nullable: false),
                    ReferenceAllele = table.Column<string>(maxLength: 500, nullable: true),
                    AlternateAllele = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mutations", x => x.Id);
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
                name: "CellLines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ParentId = table.Column<int>(nullable: true),
                    DonorId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    TypeId = table.Column<int>(nullable: true),
                    SpeciesId = table.Column<int>(nullable: true),
                    GeneExpressionSubtypeId = table.Column<int>(nullable: true),
                    IdhStatusId = table.Column<int>(nullable: true),
                    IdhMutationId = table.Column<int>(nullable: true),
                    MethylationStatusId = table.Column<int>(nullable: true),
                    MethylationSubtypeId = table.Column<int>(nullable: true),
                    GcimpMethylation = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CellLines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CellLines_Donors_DonorId",
                        column: x => x.DonorId,
                        principalTable: "Donors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CellLines_GeneExpressionSubtypes_GeneExpressionSubtypeId",
                        column: x => x.GeneExpressionSubtypeId,
                        principalTable: "GeneExpressionSubtypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CellLines_IDHMutations_IdhMutationId",
                        column: x => x.IdhMutationId,
                        principalTable: "IDHMutations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CellLines_IDHStatuses_IdhStatusId",
                        column: x => x.IdhStatusId,
                        principalTable: "IDHStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CellLines_MethylationStatuses_MethylationStatusId",
                        column: x => x.MethylationStatusId,
                        principalTable: "MethylationStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CellLines_MethylationSubtypes_MethylationSubtypeId",
                        column: x => x.MethylationSubtypeId,
                        principalTable: "MethylationSubtypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CellLines_CellLines_ParentId",
                        column: x => x.ParentId,
                        principalTable: "CellLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CellLines_Species_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Species",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CellLines_CellLineTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "CellLineTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "CellLineIndexingTasks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CellLineId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CellLineIndexingTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CellLineIndexingTasks_CellLines_CellLineId",
                        column: x => x.CellLineId,
                        principalTable: "CellLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CellLineInfos",
                columns: table => new
                {
                    CellLineId = table.Column<int>(nullable: false),
                    DepositorName = table.Column<string>(maxLength: 100, nullable: true),
                    DepositorEstablishment = table.Column<string>(maxLength: 100, nullable: true),
                    EstablishmentYear = table.Column<DateTime>(nullable: true),
                    FirstPublication = table.Column<string>(maxLength: 500, nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    AtccLink = table.Column<string>(maxLength: 500, nullable: true),
                    ExPasyLink = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CellLineInfos", x => x.CellLineId);
                    table.ForeignKey(
                        name: "FK_CellLineInfos_CellLines_CellLineId",
                        column: x => x.CellLineId,
                        principalTable: "CellLines",
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
                    CellLineId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(maxLength: 500, nullable: true),
                    Link = table.Column<string>(maxLength: 500, nullable: true),
                    TypeId = table.Column<int>(nullable: true),
                    SubtypeId = table.Column<int>(nullable: true),
                    Format = table.Column<string>(maxLength: 100, nullable: true),
                    Data = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Samples", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Samples_CellLines_CellLineId",
                        column: x => x.CellLineId,
                        principalTable: "CellLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "SampleMutations",
                columns: table => new
                {
                    SampleId = table.Column<int>(nullable: false),
                    MutationId = table.Column<int>(nullable: false),
                    Quality = table.Column<string>(maxLength: 100, nullable: true),
                    Filter = table.Column<string>(maxLength: 100, nullable: true),
                    Info = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleMutations", x => new { x.SampleId, x.MutationId });
                    table.ForeignKey(
                        name: "FK_SampleMutations_Mutations_MutationId",
                        column: x => x.MutationId,
                        principalTable: "Mutations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SampleMutations_Samples_SampleId",
                        column: x => x.SampleId,
                        principalTable: "Samples",
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
                table: "CellLineTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "GSC", "GSC" },
                    { 2, "Suspension", "Suspension" }
                });

            migrationBuilder.InsertData(
                table: "Chromosomes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 23, "Chromosome X", "X" },
                    { 1, "Chromosome 1", "1" },
                    { 2, "Chromosome 2", "2" },
                    { 4, "Chromosome 4", "4" },
                    { 5, "Chromosome 5", "5" },
                    { 6, "Chromosome 6", "6" },
                    { 7, "Chromosome 7", "7" },
                    { 8, "Chromosome 8", "8" },
                    { 9, "Chromosome 9", "9" },
                    { 10, "Chromosome 10", "10" },
                    { 11, "Chromosome 11", "11" },
                    { 12, "Chromosome 12", "12" },
                    { 14, "Chromosome 14", "14" },
                    { 15, "Chromosome 15", "15" },
                    { 16, "Chromosome 16", "16" },
                    { 17, "Chromosome 17", "17" },
                    { 18, "Chromosome 18", "18" },
                    { 19, "Chromosome 19", "19" },
                    { 20, "Chromosome 20", "20" },
                    { 21, "Chromosome 21", "21" },
                    { 22, "Chromosome 22", "22" },
                    { 24, "Chromosome Y", "Y" },
                    { 13, "Chromosome 13", "13" },
                    { 3, "Chromosome 3", "3" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Female", "Female" },
                    { 2, "Male", "Male" },
                    { 3, "Other", "Other" }
                });

            migrationBuilder.InsertData(
                table: "GeneExpressionSubtypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Classical", "Classical" },
                    { 2, "Mesenchymal", "Mesenchymal" },
                    { 3, "Proneural", "Proneural" }
                });

            migrationBuilder.InsertData(
                table: "IDHMutations",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 5, "IDH1 R132S", "IDH1 R132S" },
                    { 9, "IDH2 R172T", "IDH2 R172T" },
                    { 8, "IDH2 R172K", "IDH2 R172K" },
                    { 7, "IDH2 R172W", "IDH2 R172W" },
                    { 6, "IDH2 R172G", "IDH2 R172G" },
                    { 2, "IDH1 R132C", "IDH1 R132C" },
                    { 3, "IDH1 R132G", "IDH1 R132G" },
                    { 10, "IDH2 R172M", "IDH2 R172M" },
                    { 1, "IDH1 R132H", "IDH1 R132H" },
                    { 4, "IDH1 R132L", "IDH1 R132L" },
                    { 11, "IDH2 R172S", "IDH2 R172S" }
                });

            migrationBuilder.InsertData(
                table: "IDHStatuses",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "WildType", "WildType" },
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
                    { 1, "H3-K27", "H3-K27" },
                    { 2, "H3-G34", "H3-G34" },
                    { 3, "RTKI", "RTKI" },
                    { 4, "RTKII", "RTKII" },
                    { 5, "Mesenchymal", "Mesenchymal" }
                });

            migrationBuilder.InsertData(
                table: "MutationTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 3, "Deletion", "DEL" },
                    { 4, "Multiple Nucleotide Variant", "MNV" },
                    { 1, "Single Nucleotide Variant", "SNV" },
                    { 2, "Insertion", "INS" }
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
                    { 2, "Tumor", "Tumor" },
                    { 1, "Control", "Control" }
                });

            migrationBuilder.InsertData(
                table: "SequenceTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Coding DNA", "c" },
                    { 2, "Non Coding DNA", "n" },
                    { 3, "Linear Genomic DNA", "g" },
                    { 4, "Curcular Genomic DNA", "o" },
                    { 5, "Mitochondrial DNA", "m" },
                    { 6, "RNA", "r" },
                    { 7, "Protein", "p" }
                });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 2, "Mouse", "Mouse" },
                    { 1, "Human", "Human" }
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
                name: "IX_CellLineIndexingTasks_CellLineId",
                table: "CellLineIndexingTasks",
                column: "CellLineId");

            migrationBuilder.CreateIndex(
                name: "IX_CellLines_DonorId",
                table: "CellLines",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_CellLines_GeneExpressionSubtypeId",
                table: "CellLines",
                column: "GeneExpressionSubtypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CellLines_IdhMutationId",
                table: "CellLines",
                column: "IdhMutationId");

            migrationBuilder.CreateIndex(
                name: "IX_CellLines_IdhStatusId",
                table: "CellLines",
                column: "IdhStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CellLines_MethylationStatusId",
                table: "CellLines",
                column: "MethylationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CellLines_MethylationSubtypeId",
                table: "CellLines",
                column: "MethylationSubtypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CellLines_ParentId",
                table: "CellLines",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_CellLines_SpeciesId",
                table: "CellLines",
                column: "SpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_CellLines_TypeId",
                table: "CellLines",
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
                name: "IX_Contigs_Value",
                table: "Contigs",
                column: "Value",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DonorIndexingTasks_DonorId",
                table: "DonorIndexingTasks",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_Donors_PrimarySiteId",
                table: "Donors",
                column: "PrimarySiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Genes_Name",
                table: "Genes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Localizations_Value",
                table: "Localizations",
                column: "Value",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MutationIndexingTasks_MutationId",
                table: "MutationIndexingTasks",
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
                name: "IX_PrimarySites_Value",
                table: "PrimarySites",
                column: "Value",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SampleMutations_MutationId",
                table: "SampleMutations",
                column: "MutationId");

            migrationBuilder.CreateIndex(
                name: "IX_Samples_CellLineId",
                table: "Samples",
                column: "CellLineId");

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
                name: "IX_Studies_Name",
                table: "Studies",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudyDonors_DonorId",
                table: "StudyDonors",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_Therapies_Name",
                table: "Therapies",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_TherapyId",
                table: "Treatments",
                column: "TherapyId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPackageDonors_DonorId",
                table: "WorkPackageDonors",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPackages_Name",
                table: "WorkPackages",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CellLineIndexingTasks");

            migrationBuilder.DropTable(
                name: "CellLineInfos");

            migrationBuilder.DropTable(
                name: "ClinicalData");

            migrationBuilder.DropTable(
                name: "DonorIndexingTasks");

            migrationBuilder.DropTable(
                name: "MutationIndexingTasks");

            migrationBuilder.DropTable(
                name: "SampleMutations");

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
                name: "Mutations");

            migrationBuilder.DropTable(
                name: "Samples");

            migrationBuilder.DropTable(
                name: "Studies");

            migrationBuilder.DropTable(
                name: "Therapies");

            migrationBuilder.DropTable(
                name: "WorkPackages");

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
                name: "CellLines");

            migrationBuilder.DropTable(
                name: "SampleSubtypes");

            migrationBuilder.DropTable(
                name: "SampleTypes");

            migrationBuilder.DropTable(
                name: "Donors");

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
                name: "Species");

            migrationBuilder.DropTable(
                name: "CellLineTypes");

            migrationBuilder.DropTable(
                name: "PrimarySites");
        }
    }
}
