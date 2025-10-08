using SysSalesOrders.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSalesOrders.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<Customer?> GetCustomerById(int CustId);
        Task<Customer> AddCustomer(Customer customer);
        Task<Customer> UpdateCustomer(int CustId, Customer customer);
        Task<bool> DeleteCustomer(int CustId);
    }
}
