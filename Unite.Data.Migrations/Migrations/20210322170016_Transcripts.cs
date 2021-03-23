using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Unite.Data.Migrations.Migrations
{
    public partial class Transcripts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DonorIndexingTasks");

            migrationBuilder.DropTable(
                name: "MutationIndexingTasks");

            migrationBuilder.CreateTable(
                name: "Biotypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Value = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biotypes", x => x.Id);
                    table.UniqueConstraint("AK_Biotypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "ConsequenceImpacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
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
                    Value = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsequenceTypes", x => x.Id);
                    table.UniqueConstraint("AK_ConsequenceTypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "TaskTargetTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
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
                    Value = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTypes", x => x.Id);
                    table.UniqueConstraint("AK_TaskTypes_Value", x => x.Value);
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
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
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
                name: "GeneInfo",
                columns: table => new
                {
                    GeneId = table.Column<int>(type: "integer", nullable: false),
                    EnsemblId = table.Column<string>(type: "text", nullable: true)
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
                name: "AffectedTranscripts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MutationId = table.Column<int>(type: "integer", nullable: false),
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
                name: "TranscriptInfo",
                columns: table => new
                {
                    TranscriptId = table.Column<int>(type: "integer", nullable: false),
                    EnsemblId = table.Column<string>(type: "text", nullable: true)
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
                name: "AffectedTranscriptConsequences",
                columns: table => new
                {
                    AffectedTranscriptId = table.Column<int>(type: "integer", nullable: false),
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

            migrationBuilder.InsertData(
                table: "ConsequenceImpacts",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 4, "Unknown", "Unknown" },
                    { 1, "High", "High" },
                    { 3, "Low", "Low" },
                    { 2, "Moderate", "Moderate" }
                });

            migrationBuilder.InsertData(
                table: "ConsequenceTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Transcript ablation", "transcript_ablation" },
                    { 16, "Stop retained variant", "stop_retained_variant" },
                    { 15, "Start retained variant", "start_retained_variant" },
                    { 14, "Incomplete terminal codon variant", "incomplete_terminal_codon_variant" },
                    { 13, "Splice region variant", "splice_region_variant" },
                    { 12, "Protein altering variant", "protein_altering_variant" },
                    { 11, "Missense variant", "missense_variant" },
                    { 10, "Inframe deletion", "inframe_deletion" },
                    { 17, "Synonymous variant", "synonymous_variant" },
                    { 7, "Start lost", "start_lost" },
                    { 6, "Stop lost", "stop_lost" },
                    { 5, "Frameshift variant", "frameshift_variant" },
                    { 4, "Stop gained", "stop_gained" },
                    { 3, "Splice donor variant", "splice_donor_variant" },
                    { 9, "Inframe insertion", "inframe_insertion" },
                    { 8, "Transcript amplification", "transcript_amplification" },
                    { 18, "Coding sequence variant", "coding_sequence_variant" },
                    { 20, "5 prime UTR variant", "5_prime_UTR_variant" },
                    { 36, "Intergenic variant", "intergenic_variant" },
                    { 35, "Feature truncation", "feature_truncation" },
                    { 34, "Regulatory region variant", "regulatory_region_variant" },
                    { 33, "Feature elongation", "feature_elongation" },
                    { 32, "Regulatory region amplification", "regulatory_region_amplification" },
                    { 31, "Regulatory region ablation", "regulatory_region_ablation" },
                    { 30, "TF binding site variant", "TF_binding_site_variant" },
                    { 19, "Mature miRNA variant", "mature_miRNA_variant" },
                    { 29, "TFBS amplification", "TFBS_amplification" },
                    { 27, "Downstream gene variant", "downstream_gene_variant" },
                    { 26, "Upstream gene variant", "upstream_gene_variant" },
                    { 25, "Non coding transcript variant", "non_coding_transcript_variant" },
                    { 24, "NMD transcript variant", "NMD_transcript_variant" },
                    { 23, "Intron variant", "intron_variant" },
                    { 22, "Non coding transcript exon variant", "non_coding_transcript_exon_variant" },
                    { 21, "3 prime UTR variant", "3_prime_UTR_variant" },
                    { 28, "TFBS ablation", "TFBS_ablation" },
                    { 2, "Splice acceptor variant", "splice_acceptor_variant" }
                });

            migrationBuilder.InsertData(
                table: "Consequences",
                columns: new[] { "TypeId", "ImpactId", "Severity" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 15, 3, 15 },
                    { 36, 4, 36 },
                    { 14, 3, 14 },
                    { 13, 3, 13 },
                    { 12, 2, 12 },
                    { 11, 2, 11 },
                    { 10, 2, 10 },
                    { 17, 3, 17 },
                    { 9, 2, 9 },
                    { 7, 1, 7 },
                    { 6, 1, 6 },
                    { 5, 1, 5 },
                    { 4, 1, 4 },
                    { 3, 1, 3 },
                    { 2, 1, 2 },
                    { 8, 1, 8 },
                    { 18, 4, 18 },
                    { 16, 3, 16 },
                    { 20, 4, 20 },
                    { 35, 4, 35 },
                    { 34, 4, 34 },
                    { 33, 4, 33 },
                    { 32, 4, 32 },
                    { 31, 2, 31 },
                    { 19, 4, 19 },
                    { 29, 4, 29 },
                    { 28, 4, 28 },
                    { 30, 4, 30 },
                    { 26, 4, 26 },
                    { 25, 4, 25 },
                    { 24, 4, 24 },
                    { 23, 4, 23 },
                    { 22, 4, 22 },
                    { 21, 4, 21 },
                    { 27, 4, 27 }
                });

            migrationBuilder.InsertData(
                table: "TaskTargetTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 5, "Xenograft", "Xenograft" },
                    { 1, "Donor", "Donor" },
                    { 2, "Mutation", "Mutation" },
                    { 3, "Gene", "Gene" },
                    { 4, "CellLine", "CellLine" },
                    { 6, "MRIFeature", "MRIFeature" }
                });

            migrationBuilder.InsertData(
                table: "TaskTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Indexing", "Indexing" },
                    { 2, "Anotation(VEP)", "Anotation(VEP)" }
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
                name: "IX_Genes_BiotypeId",
                table: "Genes",
                column: "BiotypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TargetTypeId",
                table: "Tasks",
                column: "TargetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TypeId",
                table: "Tasks",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Transcripts_BiotypeId",
                table: "Transcripts",
                column: "BiotypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AffectedTranscriptConsequences");

            migrationBuilder.DropTable(
                name: "ConsequenceImpacts");

            migrationBuilder.DropTable(
                name: "ConsequenceTypes");

            migrationBuilder.DropTable(
                name: "GeneInfo");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "TranscriptInfo");

            migrationBuilder.DropTable(
                name: "AffectedTranscripts");

            migrationBuilder.DropTable(
                name: "Consequences");

            migrationBuilder.DropTable(
                name: "TaskTargetTypes");

            migrationBuilder.DropTable(
                name: "TaskTypes");

            migrationBuilder.DropTable(
                name: "Genes");

            migrationBuilder.DropTable(
                name: "Transcripts");

            migrationBuilder.DropTable(
                name: "Biotypes");

            migrationBuilder.CreateTable(
                name: "DonorIndexingTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DonorId = table.Column<string>(type: "character varying(100)", nullable: false)
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
                name: "MutationIndexingTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    MutationId = table.Column<int>(type: "integer", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_DonorIndexingTasks_DonorId",
                table: "DonorIndexingTasks",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_MutationIndexingTasks_MutationId",
                table: "MutationIndexingTasks",
                column: "MutationId");
        }
    }
}
