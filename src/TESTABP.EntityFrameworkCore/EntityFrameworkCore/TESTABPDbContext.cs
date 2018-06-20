using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TESTABP.EntityFrameworkCore {
    public class TESTABPDbContext : AbpDbContext {
        //Add DbSet properties for your entities...
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Course> Courses { get; set; }

        public TESTABPDbContext(DbContextOptions<TESTABPDbContext> options)
            : base(options) {

        }
    }
}
