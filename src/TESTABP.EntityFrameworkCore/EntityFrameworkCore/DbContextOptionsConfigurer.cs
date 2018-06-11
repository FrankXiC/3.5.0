using Microsoft.EntityFrameworkCore;

namespace TESTABP.EntityFrameworkCore {
    public static class DbContextOptionsConfigurer {
        public static void Configure(
            DbContextOptionsBuilder<TESTABPDbContext> dbContextOptions,
            string connectionString
            ) {
            /* This is the single point to configure DbContextOptions for TESTABPDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
