using Microsoft.EntityFrameworkCore.Migrations;

namespace Grant_Management_System.Data.Migrations
{
    public partial class added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusOfGrant",
                table: "Grant");

            migrationBuilder.AddColumn<int>(
                name: "StatusOfGrantID",
                table: "Grant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "StatusOfGrant",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusOfGrant", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grant_StatusOfGrantID",
                table: "Grant",
                column: "StatusOfGrantID");

            migrationBuilder.AddForeignKey(
                name: "FK_Grant_StatusOfGrant_StatusOfGrantID",
                table: "Grant",
                column: "StatusOfGrantID",
                principalTable: "StatusOfGrant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grant_StatusOfGrant_StatusOfGrantID",
                table: "Grant");

            migrationBuilder.DropTable(
                name: "StatusOfGrant");

            migrationBuilder.DropIndex(
                name: "IX_Grant_StatusOfGrantID",
                table: "Grant");

            migrationBuilder.DropColumn(
                name: "StatusOfGrantID",
                table: "Grant");

            migrationBuilder.AddColumn<string>(
                name: "StatusOfGrant",
                table: "Grant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
