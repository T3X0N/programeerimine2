using System.Threading.Tasks;
using KooliProjekt.Application.Features.koostisosad;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KooliProjekt.WebAPI.Controllers
{
    public class koostisosadController : ApiControllerBase
    {
        private readonly IMediator _mediator;

        public koostisosadController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> List([FromQuery] koostisosadQuery query)
        {
            var response = await _mediator.Send(query);

            return Result(response);
        }
    }
}
