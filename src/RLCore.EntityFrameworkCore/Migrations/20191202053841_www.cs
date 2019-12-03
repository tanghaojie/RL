using Microsoft.EntityFrameworkCore.Migrations;

namespace RLCore.Migrations
{
    public partial class www : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HasNew",
                schema: "rl",
                table: "Reservoirs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Level",
                schema: "rl",
                table: "Reservoirs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NoLeaderBool",
                schema: "rl",
                table: "Reservoirs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pac",
                schema: "rl",
                table: "Reservoirs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sid",
                schema: "rl",
                table: "Reservoirs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ssk",
                schema: "rl",
                table: "Reservoirs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasNew",
                schema: "rl",
                table: "Reservoirs");

            migrationBuilder.DropColumn(
                name: "Level",
                schema: "rl",
                table: "Reservoirs");

            migrationBuilder.DropColumn(
                name: "NoLeaderBool",
                schema: "rl",
                table: "Reservoirs");

            migrationBuilder.DropColumn(
                name: "Pac",
                schema: "rl",
                table: "Reservoirs");

            migrationBuilder.DropColumn(
                name: "Sid",
                schema: "rl",
                table: "Reservoirs");

            migrationBuilder.DropColumn(
                name: "Ssk",
                schema: "rl",
                table: "Reservoirs");
        }
    }
}
