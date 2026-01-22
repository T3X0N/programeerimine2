using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using KooliProjekt.Application.Dto;

namespace KooliProjekt.Application.Features.logikanded
{
    public class GetlogikandedQuery : IRequest<OperationResult<logikandeDto>>
    {
        public int Id { get; set; }
    }
}
