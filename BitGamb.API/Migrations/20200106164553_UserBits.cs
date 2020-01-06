using Microsoft.EntityFrameworkCore.Migrations;

namespace BitGamb.API.Migrations
{
    public partial class UserBits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "bits",
                table: "Users",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bits",
                table: "Users");
        }
    }
}
