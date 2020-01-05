using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BitGamb.API.Migrations
{
    public partial class RaceRegistries2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RaceRegistries",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Userid = table.Column<int>(nullable: true),
                    RobotRaceid = table.Column<int>(nullable: true),
                    Robotid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceRegistries", x => x.id);
                    table.ForeignKey(
                        name: "FK_RaceRegistries_RobotRaces_RobotRaceid",
                        column: x => x.RobotRaceid,
                        principalTable: "RobotRaces",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RaceRegistries_Robots_Robotid",
                        column: x => x.Robotid,
                        principalTable: "Robots",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RaceRegistries_Users_Userid",
                        column: x => x.Userid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RaceRegistries_RobotRaceid",
                table: "RaceRegistries",
                column: "RobotRaceid");

            migrationBuilder.CreateIndex(
                name: "IX_RaceRegistries_Robotid",
                table: "RaceRegistries",
                column: "Robotid");

            migrationBuilder.CreateIndex(
                name: "IX_RaceRegistries_Userid",
                table: "RaceRegistries",
                column: "Userid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RaceRegistries");
        }
    }
}
