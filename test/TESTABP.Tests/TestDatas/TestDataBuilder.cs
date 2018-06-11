using TESTABP.EntityFrameworkCore;

namespace TESTABP.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly TESTABPDbContext _context;

        public TestDataBuilder(TESTABPDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}