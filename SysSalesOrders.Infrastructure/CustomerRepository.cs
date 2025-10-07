using Microsoft.EntityFrameworkCore;
using SysSalesOrders.Application.Contracts;
using SysSalesOrders.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SysSalesOrders.Infrastructure
{
    public class CustomerRepository : IRepository<Customer>
    {

        protected readonly SalesOrderDbContext _db;

        public CustomerRepository(SalesOrderDbContext db)
        {
            _db = db;
        }

        public async Task AddAsync(Customer entity)
        {
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _db.Set<Customer>().Remove(entity);
                await _db.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Customer>> FindAsync(Expression<Func<Customer, bool>> predicate)
        {
            return await _db.Set<Customer>().Where(predicate).ToListAsync();
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _db.Set<Customer>().ToListAsync();
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            var rs = await _db.Set<Customer>().FindAsync(id);
            return rs;
        }

        public async Task UpdateAsync(Customer entity)
        {
            _db.Set<Customer>().Update(entity);
            await _db.SaveChangesAsync();
        }
    }
}
