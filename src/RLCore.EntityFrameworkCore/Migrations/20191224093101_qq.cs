using Microsoft.EntityFrameworkCore.Migrations;

namespace RLCore.Migrations
{
    public partial class qq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "rl",
                table: "TreeConfigs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "rl",
                table: "TreeConfigs",
                nullable: false,
                defaultValue: false);
        }
    }
}
