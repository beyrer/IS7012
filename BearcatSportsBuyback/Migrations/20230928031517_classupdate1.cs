using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BearcatSportsBuyback.Migrations
{
    public partial class classupdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_League_Sport_SportId",
                table: "League");

            migrationBuilder.DropForeignKey(
                name: "FK_SportingGood_Sport_SportId",
                table: "SportingGood");

            migrationBuilder.AlterColumn<int>(
                name: "SportId",
                table: "SportingGood",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SportId",
                table: "League",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_League_Sport_SportId",
                table: "League",
                column: "SportId",
                principalTable: "Sport",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SportingGood_Sport_SportId",
                table: "SportingGood",
                column: "SportId",
                principalTable: "Sport",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_League_Sport_SportId",
                table: "League");

            migrationBuilder.DropForeignKey(
                name: "FK_SportingGood_Sport_SportId",
                table: "SportingGood");

            migrationBuilder.AlterColumn<int>(
                name: "SportId",
                table: "SportingGood",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SportId",
                table: "League",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_League_Sport_SportId",
                table: "League",
                column: "SportId",
                principalTable: "Sport",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SportingGood_Sport_SportId",
                table: "SportingGood",
                column: "SportId",
                principalTable: "Sport",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
