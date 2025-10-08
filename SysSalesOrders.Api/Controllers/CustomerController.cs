using MediatR;
using Microsoft.AspNetCore.Mvc;
using SysSalesOrders.Application.Commands;
using SysSalesOrders.Domain.Entities;

namespace SysSalesOrders.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ISender _sender;

        public CustomerController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost("")]
        public async Task<IActionResult> AddCustomer([FromBody] Customer customer)
        {
            var result = await _sender.Send(new AddCustomerCommand(customer));

            return Ok(result);
        }

    }
}
