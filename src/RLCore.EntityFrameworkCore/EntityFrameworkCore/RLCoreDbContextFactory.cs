using RLCore.Configuration;
using RLCore.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace RLCore.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class RLCoreDbContextFactory : IDesignTimeDbContextFactory<RLCoreDbContext>
    {
        public RLCoreDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<RLCoreDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(RLCoreConsts.ConnectionStringName)
            );

            return new RLCoreDbContext(builder.Options);
        }
    }
}