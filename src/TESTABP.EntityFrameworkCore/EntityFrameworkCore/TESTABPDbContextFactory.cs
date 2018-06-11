using TESTABP.Configuration;
using TESTABP.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace TESTABP.EntityFrameworkCore {
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class TESTABPDbContextFactory : IDesignTimeDbContextFactory<TESTABPDbContext> {
        public TESTABPDbContext CreateDbContext(string[] args) {
            var builder = new DbContextOptionsBuilder<TESTABPDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(TESTABPConsts.ConnectionStringName)
            );

            return new TESTABPDbContext(builder.Options);
        }
    }
}