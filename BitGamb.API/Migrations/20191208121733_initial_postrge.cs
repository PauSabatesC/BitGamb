using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BitGamb.API.Migrations
{
    public partial class initial_postrge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "consecWins",
                table: "Robots");

            migrationBuilder.AlterColumn<string>(
                name: "username",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "passwordSalt",
                table: "Users",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "BLOB",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "passwordHash",
                table: "Users",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "BLOB",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Users",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "robotName",
                table: "Robots",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Robots",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "LastRacePosition",
                table: "Robots",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "RobotRaces",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    reward = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RobotRaces", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RobotRaces");

            migrationBuilder.DropColumn(
                name: "LastRacePosition",
                table: "Robots");

            migrationBuilder.AlterColumn<string>(
                name: "username",
                table: "Users",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "passwordSalt",
                table: "Users",
                type: "BLOB",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "passwordHash",
                table: "Users",
                type: "BLOB",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Users",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "robotName",
                table: "Robots",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Robots",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "consecWins",
                table: "Robots",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
