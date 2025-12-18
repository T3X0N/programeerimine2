using KooliProjekt.Application.Features.koostisosad;
using KooliProjekt.Application.Features.õllesortid;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        [Route("List")]
        public async Task<IActionResult> List([FromQuery] koostisosadQuery query)
        {
            var response = await _mediator.Send(query);

            return Result(response);
        }

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetkoostisosadQuery { Id = id };
            var response = await _mediator.Send(query);

            return Result(response);
        }

        [HttpPost]
        [Route("Save")]
        public async Task<IActionResult> Save(SavekoostisosadCommand command)
        {
            var response = await _mediator.Send(command);

            return Result(response);
        }


        // 14.11.2025
        // Delete meetod listi kustutamiseks
        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete(DeletekoostisosadCommand command)
        {
            var response = await _mediator.Send(command);

            return Result(response);
        }
    }
}
