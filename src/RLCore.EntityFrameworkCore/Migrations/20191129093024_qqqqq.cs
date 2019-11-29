using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RLCore.Migrations
{
    public partial class qqqqq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Channels",
                schema: "rl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Idname = table.Column<string>(nullable: true),
                    Idtype = table.Column<string>(nullable: true),
                    Prname = table.Column<string>(nullable: true),
                    Loc = table.Column<string>(nullable: true),
                    Flth = table.Column<string>(nullable: true),
                    Eloc = table.Column<string>(nullable: true),
                    Bdtm = table.Column<string>(nullable: true),
                    Adag = table.Column<string>(nullable: true),
                    Prname1 = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Wqle = table.Column<string>(nullable: true),
                    Func = table.Column<string>(nullable: true),
                    Wrus = table.Column<string>(nullable: true),
                    Count = table.Column<long>(nullable: true),
                    Flow = table.Column<double>(nullable: true),
                    Acfl = table.Column<double>(nullable: true),
                    Dpyn = table.Column<double>(nullable: true),
                    Dpyt = table.Column<long>(nullable: true),
                    Chle = table.Column<double>(nullable: true),
                    Chleli = table.Column<double>(nullable: true),
                    Mbnu = table.Column<long>(nullable: true),
                    Dcia = table.Column<double>(nullable: true),
                    Ecia = table.Column<double>(nullable: true),
                    Bepo = table.Column<double>(nullable: true),
                    Wrcd = table.Column<string>(nullable: true),
                    Wrco = table.Column<string>(nullable: true),
                    Hnnm = table.Column<string>(nullable: true),
                    Grad = table.Column<string>(nullable: true),
                    Pac = table.Column<string>(nullable: true),
                    Level = table.Column<string>(nullable: true),
                    Sid = table.Column<string>(nullable: true),
                    HasNew = table.Column<string>(nullable: true),
                    NoLeader = table.Column<string>(nullable: true),
                    Long = table.Column<double>(nullable: true),
                    Lat = table.Column<double>(nullable: true),
                    ELong = table.Column<double>(nullable: true),
                    ELat = table.Column<double>(nullable: true),
                    StartDate = table.Column<string>(nullable: true),
                    Clas = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Village = table.Column<string>(nullable: true),
                    Geom = table.Column<MultiLineString>(type: "geometry (MultiLineString)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Channels", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Channels",
                schema: "rl");
        }
    }
}
