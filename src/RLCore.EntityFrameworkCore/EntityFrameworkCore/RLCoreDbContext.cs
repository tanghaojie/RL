using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using RLCore.Authorization;
using RLCore.Entities.EF;
using RLCore.RL;

namespace RLCore.EntityFrameworkCore
{
    public class RLCoreDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public DbSet<User> Users { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<TestEntityGeo> TestEntities { get; set; }
        public DbSet<TestEntityGeo2> TestEntitie2s { get; set; }
        //public DbSet<TestEntityGeo3> TestEntitie3s { get; set; }
        public RLCoreDbContext(DbContextOptions<RLCoreDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("rl");
            builder.HasPostgresExtension("postgis");
            builder.Entity<User>().HasIndex(u => u.Username);
            builder.Entity<User>().HasIndex(u => u.Password);
            builder.Entity<User>().HasIndex(u => u.Realname);
            builder.Entity<User>().HasIndex(u => u.Gender);
            builder.Entity<User>().HasIndex(u => u.State);
            builder.Entity<User>().HasIndex(u => u.CreationTime);
        }
    }
}
