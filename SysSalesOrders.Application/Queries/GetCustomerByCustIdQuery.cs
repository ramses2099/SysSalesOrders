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
    public record GetCustomerByCustIdQuery(int CustId) : IRequest<Customer>;

    public class GetCustomerByCustIdQueryHandler: IRequestHandler<GetCustomerByCustIdQuery, Customer>
    {

        private readonly ICustomerRepository _customerRepository;
        public GetCustomerByCustIdQueryHandler(ICustomerRepository customerRepository)
        {
            this._customerRepository = customerRepository;
        }

        public async Task<Customer> Handle(GetCustomerByCustIdQuery request, CancellationToken cancellationToken)
        {
            var result = await this._customerRepository.GetCustomerById(request.CustId);
            return result;
        }
    }
}
