using MediatR;
using SysSalesOrders.Domain.Interfaces;
using SysSalesOrders.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSalesOrders.Application.Queries
{

    public record GetTodoDataQuery() : IRequest<Todo>;

    public class GetTodoDataQueryHandler : IRequestHandler<GetTodoDataQuery, Todo>
    {
        private readonly IExternalVendorRepository _externalVendorRepository;

        public GetTodoDataQueryHandler(IExternalVendorRepository externalVendorRepository)
        {
            this._externalVendorRepository = externalVendorRepository;
        }

        public async Task<Todo> Handle(GetTodoDataQuery request, CancellationToken cancellationToken)
        {
            return await _externalVendorRepository.GetTodo();
        }
    }
}
