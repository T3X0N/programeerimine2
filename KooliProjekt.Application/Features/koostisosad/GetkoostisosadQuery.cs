using KooliProjekt.Application.Infrastructure.Results;
using MediatR;

namespace KooliProjekt.Application.Features.koostisosad
{
    public class GetkoostisosadQuery : IRequest<OperationResult<object>>
    {
        public int Id { get; set; }
    }
}
