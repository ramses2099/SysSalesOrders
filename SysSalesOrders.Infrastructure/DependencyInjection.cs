using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SysSalesOrders.Domain.Interfaces;
using SysSalesOrders.Infrastructure.Data;
using SysSalesOrders.Infrastructure.Repositories;


namespace SysSalesOrders.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
        {

            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(@"User ID='ad-6920';Password='P@ssword01';Initial Catalog=DbSSIS;Server=10.192.1.150;Encrypt=false;Trusted_Connection=False");
            });

            services.AddScoped<ICustomerRepository, CustomerRepository>();

            return services;
        }
    }
}
