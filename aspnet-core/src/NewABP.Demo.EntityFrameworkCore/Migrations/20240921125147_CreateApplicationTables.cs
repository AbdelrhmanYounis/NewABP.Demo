using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewABP.Demo.Migrations
{
    /// <inheritdoc />
    public partial class CreateApplicationTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Demo");

            migrationBuilder.CreateTable(
                name: "Bands",
                schema: "Demo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Governorates",
                schema: "Demo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Governorates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                schema: "Demo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                schema: "Demo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GovernorateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Governorates_GovernorateId",
                        column: x => x.GovernorateId,
                        principalSchema: "Demo",
                        principalTable: "Governorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Areas",
                schema: "Demo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Areas_Cities_CityId",
                        column: x => x.CityId,
                        principalSchema: "Demo",
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Parks",
                schema: "Demo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AreaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parks_Areas_AreaId",
                        column: x => x.AreaId,
                        principalSchema: "Demo",
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Surveys",
                schema: "Demo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParkId = table.Column<int>(type: "int", nullable: false),
                    ProblemsAndSuggestions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surveys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Surveys_Parks_ParkId",
                        column: x => x.ParkId,
                        principalSchema: "Demo",
                        principalTable: "Parks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SurveyBands",
                schema: "Demo",
                columns: table => new
                {
                    SurveyId = table.Column<int>(type: "int", nullable: false),
                    BandId = table.Column<int>(type: "int", nullable: false),
                    GradeId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyBands", x => new { x.SurveyId, x.BandId });
                    table.ForeignKey(
                        name: "FK_SurveyBands_Bands_BandId",
                        column: x => x.BandId,
                        principalSchema: "Demo",
                        principalTable: "Bands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SurveyBands_Grades_GradeId",
                        column: x => x.GradeId,
                        principalSchema: "Demo",
                        principalTable: "Grades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SurveyBands_Surveys_SurveyId",
                        column: x => x.SurveyId,
                        principalSchema: "Demo",
                        principalTable: "Surveys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Areas_CityId",
                schema: "Demo",
                table: "Areas",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_GovernorateId",
                schema: "Demo",
                table: "Cities",
                column: "GovernorateId");

            migrationBuilder.CreateIndex(
                name: "IX_Parks_AreaId",
                schema: "Demo",
                table: "Parks",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyBands_BandId",
                schema: "Demo",
                table: "SurveyBands",
                column: "BandId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyBands_GradeId",
                schema: "Demo",
                table: "SurveyBands",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Surveys_ParkId",
                schema: "Demo",
                table: "Surveys",
                column: "ParkId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SurveyBands",
                schema: "Demo");

            migrationBuilder.DropTable(
                name: "Bands",
                schema: "Demo");

            migrationBuilder.DropTable(
                name: "Grades",
                schema: "Demo");

            migrationBuilder.DropTable(
                name: "Surveys",
                schema: "Demo");

            migrationBuilder.DropTable(
                name: "Parks",
                schema: "Demo");

            migrationBuilder.DropTable(
                name: "Areas",
                schema: "Demo");

            migrationBuilder.DropTable(
                name: "Cities",
                schema: "Demo");

            migrationBuilder.DropTable(
                name: "Governorates",
                schema: "Demo");
        }
    }
}
