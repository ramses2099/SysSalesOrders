using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using SysSalesOrders.Domain.Interfaces;
using SysSalesOrders.Domain.Options;
using SysSalesOrders.Infrastructure.Data;
using SysSalesOrders.Infrastructure.Repositories;
using SysSalesOrders.Infrastructure.Services;


namespace SysSalesOrders.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
        {

            services.AddDbContext<AppDbContext>((provider, options) =>
            {
                //options.UseSqlServer(@"User ID='ad-6920';Password='P@ssword01';Initial Catalog=DbSSIS;Server=10.192.1.150;Encrypt=false;Trusted_Connection=False");
                options.UseSqlServer(provider.GetRequiredService<IOptionsSnapshot<ConnectionStringOptions>>().Value.DefaultConnection);
            });

            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IExternalVendorRepository, ExternalVendorRepository>();

            services.AddHttpClient<JsonPlaceHolderHttpClientService>(option => {
                option.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
            });

            return services;
        }
    }
}
