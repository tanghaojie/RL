using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RLCore.Migrations
{
    public partial class w : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lakes",
                schema: "rl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Hydc = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Alias = table.Column<string>(nullable: true),
                    LowLeftLong = table.Column<double>(nullable: true),
                    LowLeftLat = table.Column<double>(nullable: true),
                    UpRightLong = table.Column<double>(nullable: true),
                    UpRightLat = table.Column<double>(nullable: true),
                    Sid = table.Column<string>(nullable: true),
                    CrOverType = table.Column<string>(nullable: true),
                    Loc = table.Column<string>(nullable: true),
                    Vol = table.Column<double>(nullable: true),
                    Pac = table.Column<string>(nullable: true),
                    Area = table.Column<double>(nullable: true),
                    Level = table.Column<string>(nullable: true),
                    Wql = table.Column<string>(nullable: true),
                    Basin = table.Column<string>(nullable: true),
                    River = table.Column<string>(nullable: true),
                    MeaAnnWatDept = table.Column<double>(nullable: true),
                    MaxDept = table.Column<double>(nullable: true),
                    HasNewBool = table.Column<int>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    NoleaderBool = table.Column<int>(nullable: true),
                    Village = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    EffDate = table.Column<DateTime>(nullable: true),
                    ExprDate = table.Column<DateTime>(nullable: true),
                    Geom = table.Column<MultiPolygon>(type: "geometry (multipolygon)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lakes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lakes",
                schema: "rl");
        }
    }
}
