using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using SysSalesOrders.Domain.Options;

namespace SysSalesOrders.Domain
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDomainDI(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ConnectionStringOptions>(configuration.GetSection(ConnectionStringOptions.SectionName));
           
            return services;
        }
    }

}
