using Microsoft.EntityFrameworkCore.Migrations;

namespace RLCore.Migrations
{
    public partial class wwww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FlcLev",
                schema: "rl",
                table: "Reservoirs",
                newName: "FlcoLev");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FlcoLev",
                schema: "rl",
                table: "Reservoirs",
                newName: "FlcLev");
        }
    }
}
