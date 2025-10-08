using SysSalesOrders.Application;
using SysSalesOrders.Infrastructure;

namespace SysSalesOrders.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiDI(this IServiceCollection services)
        {
            services.AddAplicationDI().AddInfrastructureDI();
            return services;
        }
    }
}
