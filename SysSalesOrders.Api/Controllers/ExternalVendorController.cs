using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SysSalesOrders.Application.Queries;

namespace SysSalesOrders.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalVendorController : ControllerBase
    {

        private readonly ISender _sender;

        public ExternalVendorController(ISender sender)
        {
            _sender = sender;
        }


        [HttpGet("")]
        public async Task<IActionResult> GetTodo()
        {
            var result = await _sender.Send(new GetTodoDataQuery());

            return Ok(result);
        }


    }
}
