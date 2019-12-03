using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RLCore.Migrations
{
    public partial class ww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservoirs",
                schema: "rl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    Town = table.Column<string>(nullable: true),
                    Village = table.Column<string>(nullable: true),
                    ReLicCode = table.Column<string>(nullable: true),
                    Vol = table.Column<double>(nullable: true),
                    Tegr = table.Column<string>(nullable: true),
                    EngGrad = table.Column<string>(nullable: true),
                    Hnnm = table.Column<string>(nullable: true),
                    Rvnm = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Long = table.Column<double>(nullable: true),
                    Lat = table.Column<double>(nullable: true),
                    Matrl = table.Column<string>(nullable: true),
                    KdStrType = table.Column<string>(nullable: true),
                    Height = table.Column<double>(nullable: true),
                    KdLength = table.Column<double>(nullable: true),
                    WatShedArea = table.Column<double>(nullable: true),
                    Flow = table.Column<double>(nullable: true),
                    StartDate = table.Column<string>(nullable: true),
                    Bdtm = table.Column<string>(nullable: true),
                    Repe = table.Column<string>(nullable: true),
                    NsType = table.Column<string>(nullable: true),
                    NsWeirType = table.Column<string>(nullable: true),
                    NsWeirHeght = table.Column<double>(nullable: true),
                    NsWrSlco = table.Column<string>(nullable: true),
                    NsMaxRfw = table.Column<double>(nullable: true),
                    WrAbns = table.Column<string>(nullable: true),
                    AbnsType = table.Column<string>(nullable: true),
                    AbnsStand = table.Column<string>(nullable: true),
                    WainNum = table.Column<long>(nullable: true),
                    WainType = table.Column<string>(nullable: true),
                    MaxDifl = table.Column<double>(nullable: true),
                    EmtuType = table.Column<string>(nullable: true),
                    MaxRfw = table.Column<double>(nullable: true),
                    DeStand = table.Column<long>(nullable: true),
                    ChStand = table.Column<long>(nullable: true),
                    Elsy = table.Column<string>(nullable: true),
                    DacrElev = table.Column<double>(nullable: true),
                    ChLev = table.Column<double>(nullable: true),
                    DeLev = table.Column<double>(nullable: true),
                    FlcLev = table.Column<double>(nullable: true),
                    WatLev = table.Column<double>(nullable: true),
                    NormPoolStagCap = table.Column<double>(nullable: true),
                    FlLowLimLev = table.Column<double>(nullable: true),
                    FlLowLimLevCap = table.Column<double>(nullable: true),
                    Elev = table.Column<double>(nullable: true),
                    StorFlCap = table.Column<double>(nullable: true),
                    FlcoCap = table.Column<double>(nullable: true),
                    BenResCap = table.Column<double>(nullable: true),
                    DeadCap = table.Column<double>(nullable: true),
                    Area = table.Column<double>(nullable: true),
                    Func = table.Column<string>(nullable: true),
                    Mpob = table.Column<string>(nullable: true),
                    Wsob = table.Column<string>(nullable: true),
                    DeIrar = table.Column<double>(nullable: true),
                    Iaob = table.Column<string>(nullable: true),
                    EngStat = table.Column<string>(nullable: true),
                    AdmDep = table.Column<string>(nullable: true),
                    AdmDepName = table.Column<string>(nullable: true),
                    Grad = table.Column<string>(nullable: true),
                    Adag = table.Column<string>(nullable: true),
                    Wrcd = table.Column<string>(nullable: true),
                    Wrpd = table.Column<string>(nullable: true),
                    Wrco = table.Column<string>(nullable: true),
                    Wrws = table.Column<string>(nullable: true),
                    WrwsSp = table.Column<string>(nullable: true),
                    WrcdDp = table.Column<string>(nullable: true),
                    Count = table.Column<long>(nullable: true),
                    Wqle = table.Column<string>(nullable: true),
                    Wrrs = table.Column<string>(nullable: true),
                    MoTime = table.Column<string>(nullable: true),
                    Mnag = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Geom = table.Column<MultiPolygon>(type: "geometry (multipolygon)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservoirs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservoirs",
                schema: "rl");
        }
    }
}
