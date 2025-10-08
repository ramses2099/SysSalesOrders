using MediatR;
using SysSalesOrders.Domain.Entities;
using SysSalesOrders.Domain.Interfaces;

namespace SysSalesOrders.Application.Commands
{
    public record AddCustomerCommand(Customer customer) : IRequest<Customer>;
    public class AddCustomerCommandHandler : IRequestHandler<AddCustomerCommand, Customer>
    {
        private readonly ICustomerRepository customerRepository;

        public AddCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public async Task<Customer> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {
            return await customerRepository.AddCustomer(request.customer);
        }
    }
}
