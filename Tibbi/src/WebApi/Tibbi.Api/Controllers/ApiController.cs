using Application.Features.Commands.CreateRegistration;
using Application.Features.Queries.GetAllRegistration;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Tibbi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly IMediator mediator;

        public ApiController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllRegistrationsQuery();

            return Ok(await mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult>Post(CreateRegistrationCommand command)
        {
            return Ok(await mediator.Send(command));
        }

    }
}
