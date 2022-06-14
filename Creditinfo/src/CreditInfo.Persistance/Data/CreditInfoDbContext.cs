using CreditInfo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CreditInfo.Persistance.Data;

public class CreditInfoDbContext : DbContext
{

    public CreditInfoDbContext(DbContextOptions<CreditInfoDbContext> options) : base(options) { }

    public virtual DbSet<Contract>? Articles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CreditInfoDbContext).Assembly);
    }
}