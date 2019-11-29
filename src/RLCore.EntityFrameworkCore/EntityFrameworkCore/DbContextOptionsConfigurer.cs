using Microsoft.EntityFrameworkCore;

namespace RLCore.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<RLCoreDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for RLCoreDbContext */
            dbContextOptions.UseNpgsql(connectionString, o => o.UseNetTopologySuite());
        }
    }
}
