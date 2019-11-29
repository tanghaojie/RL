using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RLCore.Migrations
{
    public partial class qqqqqq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Managers",
                schema: "rl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true),
                    Post = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Explain = table.Column<string>(nullable: true),
                    AdRank = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    Town = table.Column<string>(nullable: true),
                    Village = table.Column<string>(nullable: true),
                    Pac = table.Column<string>(nullable: true),
                    Riverchief = table.Column<string>(nullable: true),
                    HasNorvBool = table.Column<int>(nullable: true),
                    Belongtobasin = table.Column<string>(nullable: true),
                    Manaobname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Managers",
                schema: "rl");
        }
    }
}
