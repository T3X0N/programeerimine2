using System.Threading.Tasks;
using KooliProjekt.Application.Features.logikanded;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KooliProjekt.WebAPI.Controllers
{
    public class logikandedController : ApiControllerBase
    {
        private readonly IMediator _mediator;

        public logikandedController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> List([FromQuery] logikandedQuery query)
        {
            var response = await _mediator.Send(query);

            return Result(response);
        }
    }
}
