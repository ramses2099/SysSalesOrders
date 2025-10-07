using Microsoft.EntityFrameworkCore;
using SysSalesOrders.Domain;

namespace SysSalesOrders.Infrastructure
{
    public class SalesOrderDbContext : DbContext
    {
        public SalesOrderDbContext()
        {

        }

        public SalesOrderDbContext(DbContextOptions<SalesOrderDbContext> options) : base(options) { }

        #region DBSET

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<SalesOrder> SalesOrders { get; set; }
        public DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }


        #endregion
    }
}
