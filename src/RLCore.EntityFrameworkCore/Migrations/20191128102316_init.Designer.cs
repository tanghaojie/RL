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
    [Migration("20191128102316_init")]
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

            modelBuilder.Entity("RLCore.Authorization.User", b =>
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

            modelBuilder.Entity("RLCore.Entities.EF.TestEntityGeo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<Point>("Location");

                    b.Property<int>("PostId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("TestEntities");
                });

            modelBuilder.Entity("RLCore.Entities.EF.TestEntityGeo2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<Point>("Location")
                        .HasColumnType("geometry (point, 4326)");

                    b.Property<int>("PostId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("TestEntitie2s");
                });

            modelBuilder.Entity("RLCore.RL.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<MultiPolygon>("Geom")
                        .IsRequired()
                        .HasColumnType("geometry (multipolygon, 4326)");

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
#pragma warning restore 612, 618
        }
    }
}
