using MediatR;
using SysSalesOrders.Domain.Entities;
using SysSalesOrders.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSalesOrders.Application.Commands
{
    public record UpdateCustomerCommand(int CustId, Customer Customer) : IRequest<Customer>;

    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, Customer>
    {
        private readonly ICustomerRepository _customerRepository;
        public UpdateCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            this._customerRepository = customerRepository;
        }

        public async Task<Customer> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            return await this._customerRepository.UpdateCustomer(request.CustId, request.Customer);
        }
    }
}
