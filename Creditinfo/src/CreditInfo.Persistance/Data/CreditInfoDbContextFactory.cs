using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CreditInfo.Persistance.Data
{
    public class CreditInfoDbContextFactory : IDesignTimeDbContextFactory<CreditInfoDbContext>
    {

        public CreditInfoDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CreditInfoDbContext>();

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=CreditInfo;Integrated Security=True;MultipleActiveResultSets=True");

            return new CreditInfoDbContext(optionsBuilder.Options);
        }
    }
}
