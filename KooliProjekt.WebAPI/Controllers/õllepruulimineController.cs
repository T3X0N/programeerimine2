using KooliProjekt.Application.Features.õllepruulimised;
using KooliProjekt.Application.Features.õllesortid;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        [Route("List")]
        public async Task<IActionResult> List([FromQuery] õllepruulimisedQuery query)
        {
            var response = await _mediator.Send(query);

            return Result(response);
        }

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetõllepruulimisedQuery { Id = id };
            var response = await _mediator.Send(query);

            return Result(response);
        }

        [HttpPost]
        [Route("Save")]
        public async Task<IActionResult> Save(SaveõllepruulimisedCommand command)
        {
            var response = await _mediator.Send(command);

            return Result(response);
        }


        // 14.11.2025
        // Delete meetod listi kustutamiseks
        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete(DeleteõllepruulimisedCommand command)
        {
            var response = await _mediator.Send(command);

            return Result(response);
        }
    }
}
