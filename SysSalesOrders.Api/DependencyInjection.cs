using SysSalesOrders.Application;
using SysSalesOrders.Domain;
using SysSalesOrders.Infrastructure;

namespace SysSalesOrders.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiDI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAplicationDI().AddInfrastructureDI().AddDomainDI(configuration);
            return services;
        }
    }
}
