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
            dbContextOptions.UseNpgsql(connectionString, o => o.UseNetTopologySuite());
        }
    }
}
