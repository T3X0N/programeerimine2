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
        [Route("List")]
        public async Task<IActionResult> List([FromQuery] õllesortidQuery query)
        {
            var response = await _mediator.Send(query);

            return Result(response);
        }

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetõllesortidQuery { Id = id };
            var response = await _mediator.Send(query);

            return Result(response);
        }

        [HttpPost]
        [Route("Save")]
        public async Task<IActionResult> Save(SaveõllesortidCommand command)
        {
            var response = await _mediator.Send(command);

            return Result(response);
        }


        // 14.11.2025
        // Delete meetod listi kustutamiseks
        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete(DeleteõllesortidCommand command)
        {
            var response = await _mediator.Send(command);

            return Result(response);
        }
    }
}
