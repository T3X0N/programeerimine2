using System.Threading.Tasks;
using KooliProjekt.Application.Features.õllepruulimised;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KooliProjekt.WebAPI.Controllers
{
    public class õllepruulimineController : ApiControllerBase
    {
        private readonly IMediator _mediator;

        public õllepruulimineController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> List([FromQuery] õllepruulimisedQuery query)
        {
            var response = await _mediator.Send(query);

            return Result(response);
        }
    }
}
