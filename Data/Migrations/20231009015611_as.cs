using Microsoft.EntityFrameworkCore.Migrations;

namespace Grant_Management_System.Data.Migrations
{
    public partial class @as : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grant_Department_DepartmentID",
                table: "Grant");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentID",
                table: "Grant",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Grant_Department_DepartmentID",
                table: "Grant",
                column: "DepartmentID",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grant_Department_DepartmentID",
                table: "Grant");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentID",
                table: "Grant",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Grant_Department_DepartmentID",
                table: "Grant",
                column: "DepartmentID",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
