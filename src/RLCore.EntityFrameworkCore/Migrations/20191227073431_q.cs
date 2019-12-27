using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RLCore.Migrations
{
    public partial class q : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RiverPatrolEventLevels",
                schema: "rl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ParentId = table.Column<int>(nullable: true),
                    Option = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Data = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiverPatrolEventLevels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiverPatrolEventLevels_RiverPatrolEventLevels_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "rl",
                        principalTable: "RiverPatrolEventLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RiverPatrolEvents",
                schema: "rl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UserId = table.Column<int>(nullable: false),
                    RiverPatrolId = table.Column<int>(nullable: false),
                    RiverPatrolEventTypeId = table.Column<int>(nullable: false),
                    EventDate = table.Column<DateTime>(nullable: true),
                    FindDate = table.Column<DateTime>(nullable: false),
                    PlanFinishDate = table.Column<DateTime>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    EventDescription = table.Column<string>(nullable: true),
                    RiverPatrolEventLevelId = table.Column<int>(nullable: false),
                    RiverPatrolEventSourceTypeId = table.Column<int>(nullable: false),
                    Location = table.Column<Point>(type: "geometry (point)", nullable: true),
                    LocationDesciption = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiverPatrolEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiverPatrolEvents_RiverPatrolEventLevels_RiverPatrolEventLe~",
                        column: x => x.RiverPatrolEventLevelId,
                        principalSchema: "rl",
                        principalTable: "RiverPatrolEventLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RiverPatrolEvents_RiverPatrolEventSourceTypes_RiverPatrolEv~",
                        column: x => x.RiverPatrolEventSourceTypeId,
                        principalSchema: "rl",
                        principalTable: "RiverPatrolEventSourceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RiverPatrolEvents_RiverPatrolEventTypes_RiverPatrolEventTyp~",
                        column: x => x.RiverPatrolEventTypeId,
                        principalSchema: "rl",
                        principalTable: "RiverPatrolEventTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RiverPatrolEvents_RiverPatrols_RiverPatrolId",
                        column: x => x.RiverPatrolId,
                        principalSchema: "rl",
                        principalTable: "RiverPatrols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RiverPatrolEvents_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "rl",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RiverPatrolEventLevels_CreationTime",
                schema: "rl",
                table: "RiverPatrolEventLevels",
                column: "CreationTime");

            migrationBuilder.CreateIndex(
                name: "IX_RiverPatrolEventLevels_Option",
                schema: "rl",
                table: "RiverPatrolEventLevels",
                column: "Option");

            migrationBuilder.CreateIndex(
                name: "IX_RiverPatrolEventLevels_ParentId",
                schema: "rl",
                table: "RiverPatrolEventLevels",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_RiverPatrolEvents_RiverPatrolEventLevelId",
                schema: "rl",
                table: "RiverPatrolEvents",
                column: "RiverPatrolEventLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_RiverPatrolEvents_RiverPatrolEventSourceTypeId",
                schema: "rl",
                table: "RiverPatrolEvents",
                column: "RiverPatrolEventSourceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RiverPatrolEvents_RiverPatrolEventTypeId",
                schema: "rl",
                table: "RiverPatrolEvents",
                column: "RiverPatrolEventTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RiverPatrolEvents_RiverPatrolId",
                schema: "rl",
                table: "RiverPatrolEvents",
                column: "RiverPatrolId");

            migrationBuilder.CreateIndex(
                name: "IX_RiverPatrolEvents_UserId",
                schema: "rl",
                table: "RiverPatrolEvents",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RiverPatrolEvents",
                schema: "rl");

            migrationBuilder.DropTable(
                name: "RiverPatrolEventLevels",
                schema: "rl");
        }
    }
}
