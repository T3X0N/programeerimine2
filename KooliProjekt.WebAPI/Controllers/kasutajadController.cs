using KooliProjekt.Application.Features.kasutajad;
using KooliProjekt.Application.Features.õllesortid;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KooliProjekt.WebAPI.Controllers
{
    public class kasutajadController : ApiControllerBase
    {
        private readonly IMediator _mediator;

        public kasutajadController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        [Route("List")]
        public async Task<IActionResult> List([FromQuery] KasutajadQuery query)
        {
            var response = await _mediator.Send(query);

            return Result(response);
        }

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetkasutajadQuery { Id = id };
            var response = await _mediator.Send(query);

            return Result(response);
        }

        [HttpPost]
        [Route("Save")]
        public async Task<IActionResult> Save(SaveKasutajadCommand command)
        {
            var response = await _mediator.Send(command);

            return Result(response);
        }


        // 14.11.2025
        // Delete meetod listi kustutamiseks
        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete(DeleteKasutajadCommand command)
        {
            var response = await _mediator.Send(command);

            return Result(response);
        }
    }
}
