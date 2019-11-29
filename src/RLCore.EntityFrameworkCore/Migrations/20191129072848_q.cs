using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

namespace RLCore.Migrations
{
    public partial class q : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<MultiPolygon>(
                name: "Geom",
                schema: "rl",
                table: "Regions",
                type: "geometry (multipolygon)",
                nullable: false,
                oldClrType: typeof(MultiPolygon),
                oldType: "geometry (multipolygon, 4326)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<MultiPolygon>(
                name: "Geom",
                schema: "rl",
                table: "Regions",
                type: "geometry (multipolygon, 4326)",
                nullable: false,
                oldClrType: typeof(MultiPolygon),
                oldType: "geometry (multipolygon)");
        }
    }
}
