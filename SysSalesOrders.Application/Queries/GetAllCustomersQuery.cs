using MediatR;
using SysSalesOrders.Domain.Entities;
using SysSalesOrders.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSalesOrders.Application.Queries
{

    public record GetAllCustomersQuery() : IRequest<IEnumerable<Customer>>;

    public class GetAllCustomersQueryHandler : IRequestHandler<GetAllCustomersQuery, IEnumerable<Customer>>
    {
        private readonly ICustomerRepository _customerRepository;
        public GetAllCustomersQueryHandler(ICustomerRepository customerRepository)
        {
            this._customerRepository = customerRepository;
        }

        public async Task<IEnumerable<Customer>> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
        {
            return await this._customerRepository.GetAllCustomers();
        }
    }
}
