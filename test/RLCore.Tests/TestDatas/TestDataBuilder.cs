using RLCore.EntityFrameworkCore;

namespace RLCore.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly RLCoreDbContext _context;

        public TestDataBuilder(RLCoreDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}