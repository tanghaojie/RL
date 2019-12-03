using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RLCore.Migrations
{
    public partial class wwwww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Wetlands",
                schema: "rl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Province = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Wrkr = table.Column<string>(nullable: true),
                    Retype = table.Column<string>(nullable: true),
                    Krname = table.Column<string>(nullable: true),
                    Waname = table.Column<string>(nullable: true),
                    Waid = table.Column<string>(nullable: true),
                    Clas = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Area = table.Column<double>(nullable: true),
                    Elev = table.Column<double>(nullable: true),
                    Bscd = table.Column<string>(nullable: true),
                    Rvlv = table.Column<string>(nullable: true),
                    Wasu = table.Column<string>(nullable: true),
                    Vgar = table.Column<double>(nullable: true),
                    Owag = table.Column<string>(nullable: true),
                    Fact = table.Column<string>(nullable: true),
                    Pmst = table.Column<string>(nullable: true),
                    Inv = table.Column<string>(nullable: true),
                    Inti = table.Column<string>(nullable: true),
                    Inde = table.Column<string>(nullable: true),
                    Wrfi = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Pac = table.Column<string>(nullable: true),
                    Level = table.Column<string>(nullable: true),
                    Sid = table.Column<string>(nullable: true),
                    HasNew = table.Column<string>(nullable: true),
                    NoLeaderBool = table.Column<int>(nullable: true),
                    Geom = table.Column<MultiPolygon>(type: "geometry (multipolygon)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wetlands", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Wetlands",
                schema: "rl");
        }
    }
}
