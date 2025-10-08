using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SysSalesOrders.Domain.Entities;

namespace SysSalesOrders.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        #region METHODS

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(@"User ID='ad-6920';Password='P@ssword01';Initial Catalog=DbSSIS;Server=10.192.1.150;Encrypt=false;Trusted_Connection=False");
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Address>(a =>
            {
                a.Property<int>("AddId");
                a.HasKey("AddId");
            });

            modelBuilder.Entity<Customer>(a =>
            {
                a.Property<int>("CustId");
                a.HasKey("CustId");
            });

            modelBuilder.Entity<PaymentMethod>(a =>
            {
                a.Property<int>("PaymMethId");
                a.HasKey("PaymMethId");
            });

            modelBuilder.Entity<Product>(a =>
            {
                a.Property<int>("ProdId");
                a.HasKey("ProdId");
            });

            modelBuilder.Entity<SalesOrder>(a =>
            {
                a.Property<int>("SaleOrderId");
                a.HasKey("SaleOrderId");
            });

            modelBuilder.Entity<SalesOrderDetail>(a =>
            {
                a.Property<int>("SaleOrderDetailId");
                a.HasKey("SaleOrderDetailId");
            });

            base.OnModelCreating(modelBuilder);
        }

        #endregion

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
