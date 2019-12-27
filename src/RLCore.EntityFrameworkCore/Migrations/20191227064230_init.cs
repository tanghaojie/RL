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

            migrationBuilder.CreateTable(
                name: "OptionTreeSharedTable",
                schema: "rl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ParentId = table.Column<int>(nullable: true),
                    OptionType = table.Column<string>(nullable: false),
                    Option = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Data = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionTreeSharedTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OptionTreeSharedTable_OptionTreeSharedTable_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "rl",
                        principalTable: "OptionTreeSharedTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    Geom = table.Column<MultiPolygon>(type: "geometry (multipolygon)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

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
                    FlcoLev = table.Column<double>(nullable: true),
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
                    Ssk = table.Column<string>(nullable: true),
                    Pac = table.Column<string>(nullable: true),
                    Level = table.Column<string>(nullable: true),
                    Sid = table.Column<string>(nullable: true),
                    HasNew = table.Column<string>(nullable: true),
                    NoLeaderBool = table.Column<int>(nullable: true),
                    Geom = table.Column<MultiPolygon>(type: "geometry (multipolygon)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservoirs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RiverPatrolEventSourceTypes",
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
                    table.PrimaryKey("PK_RiverPatrolEventSourceTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiverPatrolEventSourceTypes_RiverPatrolEventSourceTypes_Par~",
                        column: x => x.ParentId,
                        principalSchema: "rl",
                        principalTable: "RiverPatrolEventSourceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RiverPatrolEventTypes",
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
                    table.PrimaryKey("PK_RiverPatrolEventTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiverPatrolEventTypes_RiverPatrolEventTypes_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "rl",
                        principalTable: "RiverPatrolEventTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    Rlen = table.Column<double>(nullable: true),
                    Grade = table.Column<string>(nullable: true),
                    Censcode = table.Column<string>(nullable: true),
                    BranchLevel = table.Column<double>(nullable: true),
                    SideType = table.Column<string>(nullable: true),
                    Area = table.Column<double>(nullable: true),
                    Flow = table.Column<double>(nullable: true),
                    CrossType = table.Column<string>(nullable: true),
                    Sid = table.Column<string>(nullable: true),
                    SidUp = table.Column<string>(nullable: true),
                    SidDown = table.Column<string>(nullable: true),
                    BranchRelation = table.Column<string>(nullable: true),
                    Alias = table.Column<string>(nullable: true),
                    Pac = table.Column<string>(nullable: true),
                    BoundaryRiverBool = table.Column<int>(nullable: true),
                    ByVillage = table.Column<string>(nullable: true),
                    Level = table.Column<string>(nullable: true),
                    NoLeaderBool = table.Column<int>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Side = table.Column<string>(nullable: true),
                    Geom = table.Column<MultiLineString>(type: "geometry (MultiLineString)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rivers", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "ManagerLakeRelations",
                schema: "rl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ManagerId = table.Column<int>(nullable: false),
                    LakeId = table.Column<int>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerLakeRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManagerLakeRelations_Lakes_LakeId",
                        column: x => x.LakeId,
                        principalSchema: "rl",
                        principalTable: "Lakes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ManagerLakeRelations_Managers_ManagerId",
                        column: x => x.ManagerId,
                        principalSchema: "rl",
                        principalTable: "Managers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManagerLakeSidRelations",
                schema: "rl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ManagerId = table.Column<int>(nullable: false),
                    LakeSid = table.Column<string>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerLakeSidRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManagerLakeSidRelations_Managers_ManagerId",
                        column: x => x.ManagerId,
                        principalSchema: "rl",
                        principalTable: "Managers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManagerReservoirSidRelations",
                schema: "rl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ManagerId = table.Column<int>(nullable: false),
                    ReservoirSid = table.Column<string>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerReservoirSidRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManagerReservoirSidRelations_Managers_ManagerId",
                        column: x => x.ManagerId,
                        principalSchema: "rl",
                        principalTable: "Managers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManagerWetlandSidRelations",
                schema: "rl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ManagerId = table.Column<int>(nullable: false),
                    WetlandSid = table.Column<string>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerWetlandSidRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManagerWetlandSidRelations_Managers_ManagerId",
                        column: x => x.ManagerId,
                        principalSchema: "rl",
                        principalTable: "Managers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManagerReservoirRelations",
                schema: "rl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ManagerId = table.Column<int>(nullable: false),
                    ReservoirId = table.Column<int>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerReservoirRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManagerReservoirRelations_Managers_ManagerId",
                        column: x => x.ManagerId,
                        principalSchema: "rl",
                        principalTable: "Managers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ManagerReservoirRelations_Reservoirs_ReservoirId",
                        column: x => x.ReservoirId,
                        principalSchema: "rl",
                        principalTable: "Reservoirs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManagerRiverRelations",
                schema: "rl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ManagerId = table.Column<int>(nullable: false),
                    RiverId = table.Column<int>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerRiverRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManagerRiverRelations_Managers_ManagerId",
                        column: x => x.ManagerId,
                        principalSchema: "rl",
                        principalTable: "Managers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ManagerRiverRelations_Rivers_RiverId",
                        column: x => x.RiverId,
                        principalSchema: "rl",
                        principalTable: "Rivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RiverPatrols",
                schema: "rl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UserId = table.Column<int>(nullable: false),
                    ManagerId = table.Column<int>(nullable: true),
                    RiverId = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    State = table.Column<int>(nullable: false),
                    StartPoint = table.Column<Point>(type: "geometry (point)", nullable: true),
                    EndPoint = table.Column<Point>(type: "geometry (point)", nullable: true),
                    Track = table.Column<LineString>(type: "geometry (LineString)", nullable: true),
                    TrackPointIndexAndSecondWithoutASecond = table.Column<int[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiverPatrols", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiverPatrols_Managers_ManagerId",
                        column: x => x.ManagerId,
                        principalSchema: "rl",
                        principalTable: "Managers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiverPatrols_Rivers_RiverId",
                        column: x => x.RiverId,
                        principalSchema: "rl",
                        principalTable: "Rivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RiverPatrols_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "rl",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManagerWetlandRelations",
                schema: "rl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ManagerId = table.Column<int>(nullable: false),
                    WetlandId = table.Column<int>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerWetlandRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManagerWetlandRelations_Managers_ManagerId",
                        column: x => x.ManagerId,
                        principalSchema: "rl",
                        principalTable: "Managers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ManagerWetlandRelations_Wetlands_WetlandId",
                        column: x => x.WetlandId,
                        principalSchema: "rl",
                        principalTable: "Wetlands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ManagerLakeRelations_LakeId",
                schema: "rl",
                table: "ManagerLakeRelations",
                column: "LakeId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerLakeRelations_ManagerId",
                schema: "rl",
                table: "ManagerLakeRelations",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerLakeSidRelations_LakeSid",
                schema: "rl",
                table: "ManagerLakeSidRelations",
                column: "LakeSid");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerLakeSidRelations_ManagerId",
                schema: "rl",
                table: "ManagerLakeSidRelations",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerReservoirRelations_ManagerId",
                schema: "rl",
                table: "ManagerReservoirRelations",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerReservoirRelations_ReservoirId",
                schema: "rl",
                table: "ManagerReservoirRelations",
                column: "ReservoirId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerReservoirSidRelations_ManagerId",
                schema: "rl",
                table: "ManagerReservoirSidRelations",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerReservoirSidRelations_ReservoirSid",
                schema: "rl",
                table: "ManagerReservoirSidRelations",
                column: "ReservoirSid");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerRiverRelations_ManagerId",
                schema: "rl",
                table: "ManagerRiverRelations",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerRiverRelations_RiverId",
                schema: "rl",
                table: "ManagerRiverRelations",
                column: "RiverId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerWetlandRelations_ManagerId",
                schema: "rl",
                table: "ManagerWetlandRelations",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerWetlandRelations_WetlandId",
                schema: "rl",
                table: "ManagerWetlandRelations",
                column: "WetlandId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerWetlandSidRelations_ManagerId",
                schema: "rl",
                table: "ManagerWetlandSidRelations",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerWetlandSidRelations_WetlandSid",
                schema: "rl",
                table: "ManagerWetlandSidRelations",
                column: "WetlandSid");

            migrationBuilder.CreateIndex(
                name: "IX_OptionTreeSharedTable_CreationTime",
                schema: "rl",
                table: "OptionTreeSharedTable",
                column: "CreationTime");

            migrationBuilder.CreateIndex(
                name: "IX_OptionTreeSharedTable_Option",
                schema: "rl",
                table: "OptionTreeSharedTable",
                column: "Option");

            migrationBuilder.CreateIndex(
                name: "IX_OptionTreeSharedTable_OptionType",
                schema: "rl",
                table: "OptionTreeSharedTable",
                column: "OptionType");

            migrationBuilder.CreateIndex(
                name: "IX_OptionTreeSharedTable_ParentId",
                schema: "rl",
                table: "OptionTreeSharedTable",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_RiverPatrolEventSourceTypes_CreationTime",
                schema: "rl",
                table: "RiverPatrolEventSourceTypes",
                column: "CreationTime");

            migrationBuilder.CreateIndex(
                name: "IX_RiverPatrolEventSourceTypes_Option",
                schema: "rl",
                table: "RiverPatrolEventSourceTypes",
                column: "Option");

            migrationBuilder.CreateIndex(
                name: "IX_RiverPatrolEventSourceTypes_ParentId",
                schema: "rl",
                table: "RiverPatrolEventSourceTypes",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_RiverPatrolEventTypes_CreationTime",
                schema: "rl",
                table: "RiverPatrolEventTypes",
                column: "CreationTime");

            migrationBuilder.CreateIndex(
                name: "IX_RiverPatrolEventTypes_Option",
                schema: "rl",
                table: "RiverPatrolEventTypes",
                column: "Option");

            migrationBuilder.CreateIndex(
                name: "IX_RiverPatrolEventTypes_ParentId",
                schema: "rl",
                table: "RiverPatrolEventTypes",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_RiverPatrols_ManagerId",
                schema: "rl",
                table: "RiverPatrols",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_RiverPatrols_RiverId",
                schema: "rl",
                table: "RiverPatrols",
                column: "RiverId");

            migrationBuilder.CreateIndex(
                name: "IX_RiverPatrols_UserId",
                schema: "rl",
                table: "RiverPatrols",
                column: "UserId");

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
                name: "Channels",
                schema: "rl");

            migrationBuilder.DropTable(
                name: "ManagerLakeRelations",
                schema: "rl");

            migrationBuilder.DropTable(
                name: "ManagerLakeSidRelations",
                schema: "rl");

            migrationBuilder.DropTable(
                name: "ManagerReservoirRelations",
                schema: "rl");

            migrationBuilder.DropTable(
                name: "ManagerReservoirSidRelations",
                schema: "rl");

            migrationBuilder.DropTable(
                name: "ManagerRiverRelations",
                schema: "rl");

            migrationBuilder.DropTable(
                name: "ManagerWetlandRelations",
                schema: "rl");

            migrationBuilder.DropTable(
                name: "ManagerWetlandSidRelations",
                schema: "rl");

            migrationBuilder.DropTable(
                name: "OptionTreeSharedTable",
                schema: "rl");

            migrationBuilder.DropTable(
                name: "Regions",
                schema: "rl");

            migrationBuilder.DropTable(
                name: "RiverPatrolEventSourceTypes",
                schema: "rl");

            migrationBuilder.DropTable(
                name: "RiverPatrolEventTypes",
                schema: "rl");

            migrationBuilder.DropTable(
                name: "RiverPatrols",
                schema: "rl");

            migrationBuilder.DropTable(
                name: "Lakes",
                schema: "rl");

            migrationBuilder.DropTable(
                name: "Reservoirs",
                schema: "rl");

            migrationBuilder.DropTable(
                name: "Wetlands",
                schema: "rl");

            migrationBuilder.DropTable(
                name: "Managers",
                schema: "rl");

            migrationBuilder.DropTable(
                name: "Rivers",
                schema: "rl");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "rl");
        }
    }
}
