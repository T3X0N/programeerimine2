using System.Threading.Tasks;
using KooliProjekt.Application.Features.maitsmistelogikanded;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KooliProjekt.WebAPI.Controllers
{
    public class maitsmislogikandedController : ApiControllerBase
    {
        private readonly IMediator _mediator;

        public maitsmislogikandedController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> List([FromQuery] maitsmistelogikandedQuery query)
        {
            var response = await _mediator.Send(query);

            return Result(response);
        }
    }
}
