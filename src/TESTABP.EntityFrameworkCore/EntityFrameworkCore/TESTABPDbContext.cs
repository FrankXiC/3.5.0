using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TESTABP.EntityFrameworkCore
{
    public class TESTABPDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public TESTABPDbContext(DbContextOptions<TESTABPDbContext> options) 
            : base(options)
        {

        }
    }
}
