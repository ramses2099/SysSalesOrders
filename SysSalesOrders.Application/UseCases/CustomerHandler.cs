using SysSalesOrders.Application.Contracts;
using SysSalesOrders.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSalesOrders.Application.UseCases
{
    #region DTOs

    public sealed record CustomerDTO(int CustNumber, string FirstName, string LastName, string PhoneNumber, string Email, DateTime CreatedAt);
    public sealed record CreateCustomerCommad(string FirstName, string LastName, string PhoneNumber, string Email, DateTime CreatedAt);
    public sealed record UpdateCustomerCommad(int CustNumber, string FirstName, string LastName, string PhoneNumber, string Email, DateTime CreatedAt);
    public sealed record DeleteCustomerCommad(int CustNumber);
    public sealed record ResponseDTO(string Message);


    #endregion

    public class CustomerHandler
    {
        private readonly IRepository<Customer> _repository;

        public CustomerHandler(IRepository<Customer> repository)
        {
            this._repository = repository;
        }

        public async Task<CustomerDTO> AddHandler(CreateCustomerCommad commad)
        {
            var cust = new Customer() { FirstName = commad.FirstName, LastName = commad.LastName, PhoneNumber = commad.PhoneNumber, Email = commad.Email, CreatedAt = DateTime.Now };
            await _repository.AddAsync(cust);
            return new CustomerDTO(cust.CustId, commad.FirstName, commad.LastName, commad.PhoneNumber, commad.Email, cust.CreatedAt);
        }
        public async Task<CustomerDTO> UpdateHandler(UpdateCustomerCommad commad)
        {
            var cust = new Customer() { CustId = commad.CustNumber, FirstName = commad.FirstName, LastName = commad.LastName, PhoneNumber = commad.PhoneNumber, Email = commad.Email, CreatedAt = DateTime.Now };
            await _repository.UpdateAsync(cust);
            return new CustomerDTO(cust.CustId, commad.FirstName, commad.LastName, commad.PhoneNumber, commad.Email, cust.CreatedAt);
        }

        public async Task<ResponseDTO> DeleteHandler(DeleteCustomerCommad commad)
        {
            var custId = commad.CustNumber;
            await _repository.DeleteAsync(custId);
            return new ResponseDTO(String.Format("Customer number was delete successfully {0}", custId));
        }
    }
}
