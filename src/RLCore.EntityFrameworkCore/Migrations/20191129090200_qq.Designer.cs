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
    [Migration("20191129090200_qq")]
    partial class qq
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

            modelBuilder.Entity("RLCore.RL.River", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Alias");

                    b.Property<double>("Area");

                    b.Property<bool>("BoundaryRiver");

                    b.Property<int>("BoundaryRiverBool");

                    b.Property<double>("BranchLevel");

                    b.Property<string>("BranchRelation");

                    b.Property<string>("ByVillage");

                    b.Property<string>("Censcode");

                    b.Property<string>("CrossType");

                    b.Property<double>("Flow");

                    b.Property<MultiLineString>("Geom")
                        .HasColumnType("geometry (MultiLineString)");

                    b.Property<string>("Grade");

                    b.Property<string>("Level");

                    b.Property<string>("Name");

                    b.Property<bool>("NoLeader");

                    b.Property<int>("NoLeaderBool");

                    b.Property<string>("Pac");

                    b.Property<string>("Prname");

                    b.Property<double>("Rlen");

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
#pragma warning restore 612, 618
        }
    }
}
