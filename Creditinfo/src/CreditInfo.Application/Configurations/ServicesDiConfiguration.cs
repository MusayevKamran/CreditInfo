using CreditInfo.Application.Interfaces;
using CreditInfo.Application.Services;
using Microsoft.Extensions.DependencyInjection;


namespace CreditInfo.Application.Configurations
{
    public static class ServicesDiConfiguration
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IContractService, ContractService>();
        }
    }
}
