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

    public record DeleteCustomerCommand(int CustId) : IRequest<bool>;

    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand, bool>
    {

        private readonly ICustomerRepository _customerRepository;
        public DeleteCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            this._customerRepository = customerRepository;
        }

        public async Task<bool> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            return await this._customerRepository.DeleteCustomer(request.CustId);
        }
    }
}
