using Microsoft.EntityFrameworkCore.Migrations;

namespace Grant_Management_System.Data.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grant_Duration_DurationID",
                table: "Grant");

            migrationBuilder.DropForeignKey(
                name: "FK_Grant_Faculty_FacultyID",
                table: "Grant");

            migrationBuilder.DropForeignKey(
                name: "FK_Grant_FundingProgramme_FundingProgrammeID",
                table: "Grant");

            migrationBuilder.DropForeignKey(
                name: "FK_Grant_Gender_GenderID",
                table: "Grant");

            migrationBuilder.DropForeignKey(
                name: "FK_Grant_Race_RaceID",
                table: "Grant");

            migrationBuilder.DropForeignKey(
                name: "FK_Grant_StatusOfGrant_StatusOfGrantID",
                table: "Grant");

            migrationBuilder.DropForeignKey(
                name: "FK_Grant_Title_TitleID",
                table: "Grant");

            migrationBuilder.AlterColumn<int>(
                name: "TitleID",
                table: "Grant",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StatusOfGrantID",
                table: "Grant",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RaceID",
                table: "Grant",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Grant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GrantYearStart",
                table: "Grant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GenderID",
                table: "Grant",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FundingProgrammeID",
                table: "Grant",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FacultyID",
                table: "Grant",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DurationID",
                table: "Grant",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Grant_Duration_DurationID",
                table: "Grant",
                column: "DurationID",
                principalTable: "Duration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grant_Faculty_FacultyID",
                table: "Grant",
                column: "FacultyID",
                principalTable: "Faculty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grant_FundingProgramme_FundingProgrammeID",
                table: "Grant",
                column: "FundingProgrammeID",
                principalTable: "FundingProgramme",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grant_Gender_GenderID",
                table: "Grant",
                column: "GenderID",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grant_Race_RaceID",
                table: "Grant",
                column: "RaceID",
                principalTable: "Race",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grant_StatusOfGrant_StatusOfGrantID",
                table: "Grant",
                column: "StatusOfGrantID",
                principalTable: "StatusOfGrant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grant_Title_TitleID",
                table: "Grant",
                column: "TitleID",
                principalTable: "Title",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grant_Duration_DurationID",
                table: "Grant");

            migrationBuilder.DropForeignKey(
                name: "FK_Grant_Faculty_FacultyID",
                table: "Grant");

            migrationBuilder.DropForeignKey(
                name: "FK_Grant_FundingProgramme_FundingProgrammeID",
                table: "Grant");

            migrationBuilder.DropForeignKey(
                name: "FK_Grant_Gender_GenderID",
                table: "Grant");

            migrationBuilder.DropForeignKey(
                name: "FK_Grant_Race_RaceID",
                table: "Grant");

            migrationBuilder.DropForeignKey(
                name: "FK_Grant_StatusOfGrant_StatusOfGrantID",
                table: "Grant");

            migrationBuilder.DropForeignKey(
                name: "FK_Grant_Title_TitleID",
                table: "Grant");

            migrationBuilder.AlterColumn<int>(
                name: "TitleID",
                table: "Grant",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "StatusOfGrantID",
                table: "Grant",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RaceID",
                table: "Grant",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Grant",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "GrantYearStart",
                table: "Grant",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "GenderID",
                table: "Grant",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FundingProgrammeID",
                table: "Grant",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FacultyID",
                table: "Grant",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DurationID",
                table: "Grant",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Grant_Duration_DurationID",
                table: "Grant",
                column: "DurationID",
                principalTable: "Duration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grant_Faculty_FacultyID",
                table: "Grant",
                column: "FacultyID",
                principalTable: "Faculty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grant_FundingProgramme_FundingProgrammeID",
                table: "Grant",
                column: "FundingProgrammeID",
                principalTable: "FundingProgramme",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grant_Gender_GenderID",
                table: "Grant",
                column: "GenderID",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grant_Race_RaceID",
                table: "Grant",
                column: "RaceID",
                principalTable: "Race",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grant_StatusOfGrant_StatusOfGrantID",
                table: "Grant",
                column: "StatusOfGrantID",
                principalTable: "StatusOfGrant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grant_Title_TitleID",
                table: "Grant",
                column: "TitleID",
                principalTable: "Title",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
