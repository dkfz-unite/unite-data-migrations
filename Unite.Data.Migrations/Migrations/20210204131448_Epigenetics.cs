using Microsoft.EntityFrameworkCore.Migrations;

namespace Unite.Data.Migrations.Migrations
{
    public partial class Epigenetics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "EpigeneticsData",
                columns: table => new
                {
                    DonorId = table.Column<string>(nullable: false),
                    GeneExpressionSubtypeId = table.Column<int>(nullable: true),
                    IdhStatusId = table.Column<int>(nullable: true),
                    IdhMutationId = table.Column<int>(nullable: true),
                    MethylationStatusId = table.Column<int>(nullable: true),
                    MethylationSubtypeId = table.Column<int>(nullable: true),
                    GcimpMethylation = table.Column<bool>(nullable: true)
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
                        name: "FK_EpigeneticsData_GeneExpressionSubtypes_GeneExpressionSubtype~",
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
                    { 11, "IDH2 R172S", "IDH2 R172S" },
                    { 10, "IDH2 R172M", "IDH2 R172M" },
                    { 8, "IDH2 R172K", "IDH2 R172K" },
                    { 7, "IDH2 R172W", "IDH2 R172W" },
                    { 6, "IDH2 R172G", "IDH2 R172G" },
                    { 9, "IDH2 R172T", "IDH2 R172T" },
                    { 4, "IDH1 R132L", "IDH1 R132L" },
                    { 3, "IDH1 R132G", "IDH1 R132G" },
                    { 2, "IDH1 R132C", "IDH1 R132C" },
                    { 1, "IDH1 R132H", "IDH1 R132H" },
                    { 5, "IDH1 R132S", "IDH1 R132S" }
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
                    { 4, "RTKII", "RTKII" },
                    { 1, "H3-K27", "H3-K27" },
                    { 2, "H3-G34", "H3-G34" },
                    { 3, "RTKI", "RTKI" },
                    { 5, "Mesenchymal", "Mesenchymal" }
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EpigeneticsData");

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
        }
    }
}
