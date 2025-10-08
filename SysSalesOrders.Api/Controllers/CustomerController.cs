using MediatR;
using Microsoft.AspNetCore.Mvc;
using SysSalesOrders.Application.Commands;
using SysSalesOrders.Application.Queries;
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


        [HttpGet("")]
        public async Task<IActionResult> GetallCustomer()
        {
            var result = await _sender.Send(new GetAllCustomersQuery());

            return Ok(result);
        }

        [HttpGet("{custid}")]
        public async Task<IActionResult> GetCustomerById([FromRoute] int custid)
        {
            var result = await _sender.Send(new GetCustomerByCustIdQuery(custid));

            return Ok(result);
        }

        [HttpPut("{custid}")]
        public async Task<IActionResult> UpdateCustomer([FromRoute] int custid, [FromBody] Customer customer)
        {
            var result = await _sender.Send(new UpdateCustomerCommand(custid, customer));

            return Ok(result);
        }

        [HttpDelete("{custid}")]
        public async Task<IActionResult> DeleteCustomer([FromRoute] int custid)
        {
            var result = await _sender.Send(new DeleteCustomerCommand(custid));

            return Ok(result);
        }


    }
}
