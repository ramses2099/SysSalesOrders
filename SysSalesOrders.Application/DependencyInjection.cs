using Microsoft.Extensions.DependencyInjection;

namespace SysSalesOrders.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAplicationDI(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(DependencyInjection).Assembly));

            return services;
        }
    }
}
