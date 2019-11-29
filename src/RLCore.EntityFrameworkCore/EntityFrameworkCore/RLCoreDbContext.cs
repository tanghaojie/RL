using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using RLCore.Users;
using RLCore.RL;

namespace RLCore.EntityFrameworkCore
{
    public class RLCoreDbContext : AbpDbContext
    {
        public DbSet<Users.User> Users { get; set; }

        public DbSet<Region> Regions { get; set; }
        public DbSet<River> Rivers { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<Manager> Managers { get; set; }

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
