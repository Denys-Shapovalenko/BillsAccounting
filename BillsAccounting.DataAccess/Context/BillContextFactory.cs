using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BillsAccounting.DataAccess.Context
{
    public class BillContextFactory : IDesignTimeDbContextFactory<BillContext>
    {
        public BillContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BillContext>();
            optionsBuilder.UseSqlite("DataSource=bills.db");

            return new BillContext(optionsBuilder.Options);
        }
    }
}