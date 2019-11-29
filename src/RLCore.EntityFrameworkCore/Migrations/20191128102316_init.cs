using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RLCore.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "rl");

            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:postgis", "'postgis', '', ''");

            migrationBuilder.CreateTable(
                name: "Regions",
                schema: "rl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: false),
                    Parent = table.Column<string>(nullable: false),
                    Pac = table.Column<string>(nullable: false),
                    Level = table.Column<string>(nullable: false),
                    Geom = table.Column<MultiPolygon>(type: "geometry (multipolygon, 4326)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestEntitie2s",
                schema: "rl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    PostId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Location = table.Column<Point>(type: "geometry (point, 4326)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestEntitie2s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestEntities",
                schema: "rl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    PostId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Location = table.Column<Point>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "rl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Realname = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    Birthday = table.Column<DateTime>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    State = table.Column<int>(nullable: false),
                    LimitAgent = table.Column<string>(nullable: true),
                    LimitProtocol = table.Column<string>(nullable: true),
                    LimitIp = table.Column<string>(nullable: true),
                    LastIp = table.Column<string>(nullable: true),
                    LastLogin = table.Column<DateTime>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CreationTime",
                schema: "rl",
                table: "Users",
                column: "CreationTime");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Gender",
                schema: "rl",
                table: "Users",
                column: "Gender");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Password",
                schema: "rl",
                table: "Users",
                column: "Password");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Realname",
                schema: "rl",
                table: "Users",
                column: "Realname");

            migrationBuilder.CreateIndex(
                name: "IX_Users_State",
                schema: "rl",
                table: "Users",
                column: "State");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                schema: "rl",
                table: "Users",
                column: "Username");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Regions",
                schema: "rl");

            migrationBuilder.DropTable(
                name: "TestEntitie2s",
                schema: "rl");

            migrationBuilder.DropTable(
                name: "TestEntities",
                schema: "rl");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "rl");
        }
    }
}
