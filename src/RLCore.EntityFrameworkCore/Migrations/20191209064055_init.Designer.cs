﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RLCore.EntityFrameworkCore;

namespace RLCore.Migrations
{
    [DbContext(typeof(RLCoreDbContext))]
    [Migration("20191209064055_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("rl")
                .HasAnnotation("Npgsql:PostgresExtension:postgis", "'postgis', '', ''")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("RLCore.RL.Channel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double?>("Acfl");

                    b.Property<string>("Adag");

                    b.Property<string>("Bdtm");

                    b.Property<double?>("Bepo");

                    b.Property<double?>("Chle");

                    b.Property<double?>("Chleli");

                    b.Property<string>("Clas");

                    b.Property<string>("Code");

                    b.Property<long?>("Count");

                    b.Property<double?>("Dcia");

                    b.Property<double?>("Dpyn");

                    b.Property<long?>("Dpyt");

                    b.Property<double?>("ELat");

                    b.Property<double?>("ELong");

                    b.Property<double?>("Ecia");

                    b.Property<string>("Eloc");

                    b.Property<double?>("Flow");

                    b.Property<string>("Flth");

                    b.Property<string>("Func");

                    b.Property<MultiLineString>("Geom")
                        .HasColumnType("geometry (MultiLineString)");

                    b.Property<string>("Grad");

                    b.Property<string>("HasNew");

                    b.Property<string>("Hnnm");

                    b.Property<string>("Idname");

                    b.Property<string>("Idtype");

                    b.Property<double?>("Lat");

                    b.Property<string>("Level");

                    b.Property<string>("Loc");

                    b.Property<double?>("Long");

                    b.Property<long?>("Mbnu");

                    b.Property<string>("Name");

                    b.Property<string>("NoLeader");

                    b.Property<string>("Note");

                    b.Property<string>("Pac");

                    b.Property<string>("Prname");

                    b.Property<string>("Prname1");

                    b.Property<string>("Sid");

                    b.Property<string>("StartDate");

                    b.Property<string>("Type");

                    b.Property<string>("Village");

                    b.Property<string>("Wqle");

                    b.Property<string>("Wrcd");

                    b.Property<string>("Wrco");

                    b.Property<string>("Wrus");

                    b.HasKey("Id");

                    b.ToTable("Channels");
                });

            modelBuilder.Entity("RLCore.RL.Lake", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Alias");

                    b.Property<double?>("Area");

                    b.Property<string>("Basin");

                    b.Property<string>("CrOverType");

                    b.Property<DateTime?>("EffDate");

                    b.Property<DateTime?>("ExprDate");

                    b.Property<MultiPolygon>("Geom")
                        .HasColumnType("geometry (multipolygon)");

                    b.Property<int?>("HasNewBool");

                    b.Property<string>("Hydc");

                    b.Property<string>("Level");

                    b.Property<string>("Loc");

                    b.Property<double?>("LowLeftLat");

                    b.Property<double?>("LowLeftLong");

                    b.Property<double?>("MaxDept");

                    b.Property<double?>("MeaAnnWatDept");

                    b.Property<string>("Name");

                    b.Property<int?>("NoleaderBool");

                    b.Property<string>("Note");

                    b.Property<string>("Pac");

                    b.Property<string>("River");

                    b.Property<string>("Sid");

                    b.Property<string>("Type");

                    b.Property<double?>("UpRightLat");

                    b.Property<double?>("UpRightLong");

                    b.Property<string>("Village");

                    b.Property<double?>("Vol");

                    b.Property<string>("Wql");

                    b.HasKey("Id");

                    b.ToTable("Lakes");
                });

            modelBuilder.Entity("RLCore.RL.Manager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdRank");

                    b.Property<string>("Belongtobasin");

                    b.Property<string>("City");

                    b.Property<string>("County");

                    b.Property<string>("Department");

                    b.Property<string>("Explain");

                    b.Property<int?>("HasNorvBool");

                    b.Property<string>("Manaobname");

                    b.Property<string>("Name");

                    b.Property<string>("Pac");

                    b.Property<string>("Phone");

                    b.Property<string>("Post");

                    b.Property<string>("Riverchief");

                    b.Property<string>("Town");

                    b.Property<string>("Village");

                    b.HasKey("Id");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("RLCore.RL.ManagerLakeRelation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<int>("LakeId");

                    b.Property<int>("ManagerId");

                    b.HasKey("Id");

                    b.HasIndex("LakeId");

                    b.HasIndex("ManagerId");

                    b.ToTable("ManagerLakeRelations");
                });

            modelBuilder.Entity("RLCore.RL.ManagerLakeSidRelation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("LakeSid")
                        .IsRequired();

                    b.Property<int>("ManagerId");

                    b.HasKey("Id");

                    b.HasIndex("LakeSid");

                    b.HasIndex("ManagerId");

                    b.ToTable("ManagerLakeSidRelations");
                });

            modelBuilder.Entity("RLCore.RL.ManagerReservoirRelation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<int>("ManagerId");

                    b.Property<int>("ReservoirId");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.HasIndex("ReservoirId");

                    b.ToTable("ManagerReservoirRelations");
                });

            modelBuilder.Entity("RLCore.RL.ManagerReservoirSidRelation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<int>("ManagerId");

                    b.Property<string>("ReservoirSid")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.HasIndex("ReservoirSid");

                    b.ToTable("ManagerReservoirSidRelations");
                });

            modelBuilder.Entity("RLCore.RL.ManagerRiverRelation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<int>("ManagerId");

                    b.Property<int>("RiverId");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.HasIndex("RiverId");

                    b.ToTable("ManagerRiverRelations");
                });

            modelBuilder.Entity("RLCore.RL.ManagerWetlandRelation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<int>("ManagerId");

                    b.Property<int>("WetlandId");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.HasIndex("WetlandId");

                    b.ToTable("ManagerWetlandRelations");
                });

            modelBuilder.Entity("RLCore.RL.ManagerWetlandSidRelation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<int>("ManagerId");

                    b.Property<string>("WetlandSid")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.HasIndex("WetlandSid");

                    b.ToTable("ManagerWetlandSidRelations");
                });

            modelBuilder.Entity("RLCore.RL.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<MultiPolygon>("Geom")
                        .IsRequired()
                        .HasColumnType("geometry (multipolygon)");

                    b.Property<string>("Level")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Pac")
                        .IsRequired();

                    b.Property<string>("Parent")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("RLCore.RL.Reservoir", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AbnsStand");

                    b.Property<string>("AbnsType");

                    b.Property<string>("Adag");

                    b.Property<string>("AdmDep");

                    b.Property<string>("AdmDepName");

                    b.Property<double?>("Area");

                    b.Property<string>("Bdtm");

                    b.Property<double?>("BenResCap");

                    b.Property<double?>("ChLev");

                    b.Property<long?>("ChStand");

                    b.Property<string>("City");

                    b.Property<string>("Code");

                    b.Property<long?>("Count");

                    b.Property<string>("County");

                    b.Property<double?>("DacrElev");

                    b.Property<double?>("DeIrar");

                    b.Property<double?>("DeLev");

                    b.Property<long?>("DeStand");

                    b.Property<double?>("DeadCap");

                    b.Property<double?>("Elev");

                    b.Property<string>("Elsy");

                    b.Property<string>("EmtuType");

                    b.Property<string>("EngGrad");

                    b.Property<string>("EngStat");

                    b.Property<double?>("FlLowLimLev");

                    b.Property<double?>("FlLowLimLevCap");

                    b.Property<double?>("FlcoCap");

                    b.Property<double?>("FlcoLev");

                    b.Property<double?>("Flow");

                    b.Property<string>("Func");

                    b.Property<MultiPolygon>("Geom")
                        .HasColumnType("geometry (multipolygon)");

                    b.Property<string>("Grad");

                    b.Property<string>("HasNew");

                    b.Property<double?>("Height");

                    b.Property<string>("Hnnm");

                    b.Property<string>("Iaob");

                    b.Property<double?>("KdLength");

                    b.Property<string>("KdStrType");

                    b.Property<double?>("Lat");

                    b.Property<string>("Level");

                    b.Property<double?>("Long");

                    b.Property<string>("Matrl");

                    b.Property<double?>("MaxDifl");

                    b.Property<double?>("MaxRfw");

                    b.Property<string>("Mnag");

                    b.Property<string>("MoTime");

                    b.Property<string>("Mpob");

                    b.Property<string>("Name");

                    b.Property<int?>("NoLeaderBool");

                    b.Property<double?>("NormPoolStagCap");

                    b.Property<string>("Note");

                    b.Property<double?>("NsMaxRfw");

                    b.Property<string>("NsType");

                    b.Property<double?>("NsWeirHeght");

                    b.Property<string>("NsWeirType");

                    b.Property<string>("NsWrSlco");

                    b.Property<string>("Pac");

                    b.Property<string>("ReLicCode");

                    b.Property<string>("Repe");

                    b.Property<string>("Rvnm");

                    b.Property<string>("Sid");

                    b.Property<string>("Ssk");

                    b.Property<string>("StartDate");

                    b.Property<double?>("StorFlCap");

                    b.Property<string>("Tegr");

                    b.Property<string>("Town");

                    b.Property<string>("Type");

                    b.Property<string>("Village");

                    b.Property<double?>("Vol");

                    b.Property<long?>("WainNum");

                    b.Property<string>("WainType");

                    b.Property<double?>("WatLev");

                    b.Property<double?>("WatShedArea");

                    b.Property<string>("Wqle");

                    b.Property<string>("WrAbns");

                    b.Property<string>("Wrcd");

                    b.Property<string>("WrcdDp");

                    b.Property<string>("Wrco");

                    b.Property<string>("Wrpd");

                    b.Property<string>("Wrrs");

                    b.Property<string>("Wrws");

                    b.Property<string>("WrwsSp");

                    b.Property<string>("Wsob");

                    b.HasKey("Id");

                    b.ToTable("Reservoirs");
                });

            modelBuilder.Entity("RLCore.RL.River", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Alias");

                    b.Property<double?>("Area");

                    b.Property<int?>("BoundaryRiverBool");

                    b.Property<double?>("BranchLevel");

                    b.Property<string>("BranchRelation");

                    b.Property<string>("ByVillage");

                    b.Property<string>("Censcode");

                    b.Property<string>("CrossType");

                    b.Property<double?>("Flow");

                    b.Property<MultiLineString>("Geom")
                        .HasColumnType("geometry (MultiLineString)");

                    b.Property<string>("Grade");

                    b.Property<string>("Level");

                    b.Property<string>("Name");

                    b.Property<int?>("NoLeaderBool");

                    b.Property<string>("Pac");

                    b.Property<string>("Prname");

                    b.Property<double?>("Rlen");

                    b.Property<string>("Rname");

                    b.Property<string>("Sid");

                    b.Property<string>("SidDown");

                    b.Property<string>("SidUp");

                    b.Property<string>("Side");

                    b.Property<string>("SideType");

                    b.Property<string>("Srname");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Rivers");
                });

            modelBuilder.Entity("RLCore.RL.Wetland", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double?>("Area");

                    b.Property<string>("Bscd");

                    b.Property<string>("City");

                    b.Property<string>("Clas");

                    b.Property<string>("County");

                    b.Property<double?>("Elev");

                    b.Property<string>("Fact");

                    b.Property<MultiPolygon>("Geom")
                        .HasColumnType("geometry (multipolygon)");

                    b.Property<string>("HasNew");

                    b.Property<string>("Inde");

                    b.Property<string>("Inti");

                    b.Property<string>("Inv");

                    b.Property<string>("Krname");

                    b.Property<string>("Level");

                    b.Property<string>("Name");

                    b.Property<int?>("NoLeaderBool");

                    b.Property<string>("Note");

                    b.Property<string>("Owag");

                    b.Property<string>("Pac");

                    b.Property<string>("Pmst");

                    b.Property<string>("Province");

                    b.Property<string>("Retype");

                    b.Property<string>("Rvlv");

                    b.Property<string>("Sid");

                    b.Property<string>("Type");

                    b.Property<double?>("Vgar");

                    b.Property<string>("Waid");

                    b.Property<string>("Waname");

                    b.Property<string>("Wasu");

                    b.Property<string>("Wrfi");

                    b.Property<string>("Wrkr");

                    b.HasKey("Id");

                    b.ToTable("Wetlands");
                });

            modelBuilder.Entity("RLCore.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("Birthday");

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Email");

                    b.Property<int>("Gender");

                    b.Property<string>("LastIp");

                    b.Property<DateTime?>("LastLogin");

                    b.Property<string>("LimitAgent");

                    b.Property<string>("LimitIp");

                    b.Property<string>("LimitProtocol");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Phone");

                    b.Property<string>("Realname")
                        .IsRequired();

                    b.Property<string>("Remark");

                    b.Property<int>("State");

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CreationTime");

                    b.HasIndex("Gender");

                    b.HasIndex("Password");

                    b.HasIndex("Realname");

                    b.HasIndex("State");

                    b.HasIndex("Username");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RLCore.RL.ManagerLakeRelation", b =>
                {
                    b.HasOne("RLCore.RL.Lake", "Lake")
                        .WithMany()
                        .HasForeignKey("LakeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RLCore.RL.Manager", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RLCore.RL.ManagerLakeSidRelation", b =>
                {
                    b.HasOne("RLCore.RL.Manager", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RLCore.RL.ManagerReservoirRelation", b =>
                {
                    b.HasOne("RLCore.RL.Manager", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RLCore.RL.Reservoir", "Reservoir")
                        .WithMany()
                        .HasForeignKey("ReservoirId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RLCore.RL.ManagerReservoirSidRelation", b =>
                {
                    b.HasOne("RLCore.RL.Manager", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RLCore.RL.ManagerRiverRelation", b =>
                {
                    b.HasOne("RLCore.RL.Manager", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RLCore.RL.River", "River")
                        .WithMany()
                        .HasForeignKey("RiverId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RLCore.RL.ManagerWetlandRelation", b =>
                {
                    b.HasOne("RLCore.RL.Manager", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RLCore.RL.Wetland", "Wetland")
                        .WithMany()
                        .HasForeignKey("WetlandId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RLCore.RL.ManagerWetlandSidRelation", b =>
                {
                    b.HasOne("RLCore.RL.Manager", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
