using KooliProjekt.Application.Infrastructure.Results;
using KooliProjekt.Application.Dto;
using MediatR;

namespace KooliProjekt.Application.Features.kasutajad
{
    public class GetkasutajadQuery : IRequest<OperationResult<kasutajaDto>>
    {
        public int Id { get; set; }
    }
}
