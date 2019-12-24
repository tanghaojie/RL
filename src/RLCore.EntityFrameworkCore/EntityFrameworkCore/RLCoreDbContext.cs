﻿using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using RLCore.Users;
using RLCore.RL;
using System.Linq;
using RLCore.Configuration;
using System.Collections.Generic;

namespace RLCore.EntityFrameworkCore
{
    public class RLCoreDbContext : AbpDbContext
    {
        public DbSet<TreeConfiguration> TreeConfigs { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<River> Rivers { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Lake> Lakes { get; set; }
        public DbSet<Reservoir> Reservoirs { get; set; }
        public DbSet<Wetland> Wetlands { get; set; }


        public DbSet<ManagerRiverRelation> ManagerRiverRelations { get; set; }
        public DbSet<ManagerLakeRelation> ManagerLakeRelations { get; set; }
        public DbSet<ManagerReservoirRelation> ManagerReservoirRelations { get; set; }
        public DbSet<ManagerWetlandRelation> ManagerWetlandRelations { get; set; }

        public DbSet<ManagerLakeSidRelation> ManagerLakeSidRelations { get; set; }
        public DbSet<ManagerReservoirSidRelation> ManagerReservoirSidRelations { get; set; }
        public DbSet<ManagerWetlandSidRelation> ManagerWetlandSidRelations { get; set; }



        public DbSet<RiverPatrol> RiverPatrols { get; set; }



        public RLCoreDbContext(DbContextOptions<RLCoreDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("rl");
            builder.HasPostgresExtension("postgis");

            Index(builder);

            builder.Entity<TreeConfiguration>().HasMany(e => e.Subs).WithOne(o => o.Parent).HasForeignKey(j => j.ParentId).OnDelete(DeleteBehavior.Cascade);  
        }

        private void Index(ModelBuilder builder)
        {
            builder.Entity<User>().HasIndex(u => u.Username);
            builder.Entity<User>().HasIndex(u => u.Password);
            builder.Entity<User>().HasIndex(u => u.Realname);
            builder.Entity<User>().HasIndex(u => u.Gender);
            builder.Entity<User>().HasIndex(u => u.State);
            builder.Entity<User>().HasIndex(u => u.CreationTime);

            builder.Entity<ManagerRiverRelation>().HasIndex(u => u.ManagerId);
            builder.Entity<ManagerRiverRelation>().HasIndex(u => u.RiverId);

            builder.Entity<ManagerLakeRelation>().HasIndex(u => u.ManagerId);
            builder.Entity<ManagerLakeRelation>().HasIndex(u => u.LakeId);

            builder.Entity<ManagerReservoirRelation>().HasIndex(u => u.ManagerId);
            builder.Entity<ManagerReservoirRelation>().HasIndex(u => u.ReservoirId);

            builder.Entity<ManagerWetlandRelation>().HasIndex(u => u.ManagerId);
            builder.Entity<ManagerWetlandRelation>().HasIndex(u => u.WetlandId);

            builder.Entity<ManagerLakeSidRelation>().HasIndex(u => u.ManagerId);
            builder.Entity<ManagerLakeSidRelation>().HasIndex(u => u.LakeSid);

            builder.Entity<ManagerReservoirSidRelation>().HasIndex(u => u.ManagerId);
            builder.Entity<ManagerReservoirSidRelation>().HasIndex(u => u.ReservoirSid);

            builder.Entity<ManagerWetlandSidRelation>().HasIndex(u => u.ManagerId);
            builder.Entity<ManagerWetlandSidRelation>().HasIndex(u => u.WetlandSid);

            builder.Entity<TreeConfiguration>().HasIndex(u => u.ConfigName);
            builder.Entity<TreeConfiguration>().HasIndex(u => u.Name);
            builder.Entity<TreeConfiguration>().HasIndex(u => u.ParentId);
            builder.Entity<TreeConfiguration>().HasIndex(u => u.CreationTime);
        }
    }
}
