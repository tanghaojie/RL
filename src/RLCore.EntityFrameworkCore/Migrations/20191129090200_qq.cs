using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RLCore.Migrations
{
    public partial class qq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rivers",
                schema: "rl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Srname = table.Column<string>(nullable: true),
                    Prname = table.Column<string>(nullable: true),
                    Rname = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Rlen = table.Column<double>(nullable: false),
                    Grade = table.Column<string>(nullable: true),
                    Censcode = table.Column<string>(nullable: true),
                    BranchLevel = table.Column<double>(nullable: false),
                    SideType = table.Column<string>(nullable: true),
                    Area = table.Column<double>(nullable: false),
                    Flow = table.Column<double>(nullable: false),
                    CrossType = table.Column<string>(nullable: true),
                    Sid = table.Column<string>(nullable: true),
                    SidUp = table.Column<string>(nullable: true),
                    SidDown = table.Column<string>(nullable: true),
                    BranchRelation = table.Column<string>(nullable: true),
                    Alias = table.Column<string>(nullable: true),
                    Pac = table.Column<string>(nullable: true),
                    BoundaryRiver = table.Column<bool>(nullable: false),
                    BoundaryRiverBool = table.Column<int>(nullable: false),
                    ByVillage = table.Column<string>(nullable: true),
                    Level = table.Column<string>(nullable: true),
                    NoLeader = table.Column<bool>(nullable: false),
                    NoLeaderBool = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Side = table.Column<string>(nullable: true),
                    Geom = table.Column<MultiLineString>(type: "geometry (MultiLineString)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rivers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rivers",
                schema: "rl");
        }
    }
}
