using System.Threading.Tasks;
using KooliProjekt.Application.Features.õllesortid;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KooliProjekt.WebAPI.Controllers
{
    public class ÕllesortController : ApiControllerBase
    {
        private readonly IMediator _mediator;

        public ÕllesortController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> List([FromQuery] õllesortidQuery query)
        {
            var response = await _mediator.Send(query);

            return Result(response);
        }
    }
}
