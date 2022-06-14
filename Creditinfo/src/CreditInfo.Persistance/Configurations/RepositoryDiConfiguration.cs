using CreditInfo.Persistance.Repository;
using CreditInfo.Persistance.Repository.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CreditInfo.Persistance.Configurations;

public static class RepositoryDiConfiguration
{
    public static void Configure(IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IContractRepository, ContractRepository>();
    }
}