using a.Core.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("findAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<Employee>> GetAll()
        {
            return await _mediator.Send(new Application.Queries.GetAllEmployeeQuery());
        }

    }
}
