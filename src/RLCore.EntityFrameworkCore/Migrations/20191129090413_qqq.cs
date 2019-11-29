using Microsoft.EntityFrameworkCore.Migrations;

namespace RLCore.Migrations
{
    public partial class qqq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BoundaryRiver",
                schema: "rl",
                table: "Rivers");

            migrationBuilder.DropColumn(
                name: "NoLeader",
                schema: "rl",
                table: "Rivers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "BoundaryRiver",
                schema: "rl",
                table: "Rivers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NoLeader",
                schema: "rl",
                table: "Rivers",
                nullable: false,
                defaultValue: false);
        }
    }
}
