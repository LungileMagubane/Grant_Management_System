using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Grant_Management_System.Data.Migrations
{
    public partial class asd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Duration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Duration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FundingProgramme",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundingProgramme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Race",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Race", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Title",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Title", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grant",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfGrant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameOfFunder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusOfGrant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearOfApplication = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FundingProgrammeID = table.Column<int>(type: "int", nullable: true),
                    ResearchKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DurationID = table.Column<int>(type: "int", nullable: true),
                    GrantYearStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GrantYearEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalGrantValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountInYear1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountInYear2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountInYear3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountInYear4 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountInYear5 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StaffNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleID = table.Column<int>(type: "int", nullable: true),
                    Initials = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstNames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderID = table.Column<int>(type: "int", nullable: true),
                    RaceID = table.Column<int>(type: "int", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacultyID = table.Column<int>(type: "int", nullable: true),
                    DepartmentID = table.Column<int>(type: "int", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grant_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Grant_Duration_DurationID",
                        column: x => x.DurationID,
                        principalTable: "Duration",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Grant_Faculty_FacultyID",
                        column: x => x.FacultyID,
                        principalTable: "Faculty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Grant_FundingProgramme_FundingProgrammeID",
                        column: x => x.FundingProgrammeID,
                        principalTable: "FundingProgramme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Grant_Gender_GenderID",
                        column: x => x.GenderID,
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Grant_Race_RaceID",
                        column: x => x.RaceID,
                        principalTable: "Race",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Grant_Title_TitleID",
                        column: x => x.TitleID,
                        principalTable: "Title",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grant_DepartmentID",
                table: "Grant",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Grant_DurationID",
                table: "Grant",
                column: "DurationID");

            migrationBuilder.CreateIndex(
                name: "IX_Grant_FacultyID",
                table: "Grant",
                column: "FacultyID");

            migrationBuilder.CreateIndex(
                name: "IX_Grant_FundingProgrammeID",
                table: "Grant",
                column: "FundingProgrammeID");

            migrationBuilder.CreateIndex(
                name: "IX_Grant_GenderID",
                table: "Grant",
                column: "GenderID");

            migrationBuilder.CreateIndex(
                name: "IX_Grant_RaceID",
                table: "Grant",
                column: "RaceID");

            migrationBuilder.CreateIndex(
                name: "IX_Grant_TitleID",
                table: "Grant",
                column: "TitleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grant");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Duration");

            migrationBuilder.DropTable(
                name: "Faculty");

            migrationBuilder.DropTable(
                name: "FundingProgramme");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "Race");

            migrationBuilder.DropTable(
                name: "Title");
        }
    }
}
