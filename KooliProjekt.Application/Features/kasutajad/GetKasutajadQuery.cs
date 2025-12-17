using KooliProjekt.Application.Infrastructure.Results;
using MediatR;

namespace KooliProjekt.Application.Features.kasutajad
{
    public class GetkasutajadQuery : IRequest<OperationResult<object>>
    {
        public int Id { get; set; }
    }
}
