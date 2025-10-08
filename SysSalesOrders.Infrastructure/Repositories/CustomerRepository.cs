using Microsoft.EntityFrameworkCore;
using SysSalesOrders.Domain.Entities;
using SysSalesOrders.Infrastructure.Data;
using SysSalesOrders.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SysSalesOrders.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _db;

        public CustomerRepository(AppDbContext db)
        {
            this._db = db;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await this._db.Customers.ToListAsync();
        }

        public async Task<Customer?> GetCustomerById(int CustId)
        {
            return await this._db.Customers.FirstOrDefaultAsync(x => x.CustId == CustId);
        }

        public async Task<Customer> AddCustomer(Customer customer)
        {
            this._db.Customers.Add(customer);
            await this._db.SaveChangesAsync();
            return customer;
        }

        public async Task<Customer> UpdateCustomer(int CustId, Customer customer)
        {
            var cust = await this._db.Customers.FirstOrDefaultAsync(c => c.CustId == CustId);

            if (cust != null)
            {
                cust.FirstName = customer.FirstName;
                cust.LastName = customer.LastName;
                cust.Email = customer.Email;
                cust.PhoneNumber = customer.PhoneNumber;
                await this._db.SaveChangesAsync();
            }

            return customer;
        }


        public async Task<bool> DeleteCustomer(int CustId)
        {
            var cust = await this._db.Customers.FirstOrDefaultAsync(c => c.CustId == CustId);

            if (cust != null)
            {
                this._db.Customers.Remove(cust);
                return await this._db.SaveChangesAsync() > 0;
            }
            return false;
        }

    }
}
