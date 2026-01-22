using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using KooliProjekt.Application.Dto;

namespace KooliProjekt.Application.Features.koostisosad
{
    public class GetkoostisosadQuery : IRequest<OperationResult<koostisosaDto>>
    {
        public int Id { get; set; }
    }
}
