using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Week3Exercise1.Migrations
{
    public partial class bankaccounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AccountHolder",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "AccountHolder",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Zip",
                table: "AccountHolder",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "AccountHolder");

            migrationBuilder.DropColumn(
                name: "State",
                table: "AccountHolder");

            migrationBuilder.DropColumn(
                name: "Zip",
                table: "AccountHolder");
        }
    }
}
