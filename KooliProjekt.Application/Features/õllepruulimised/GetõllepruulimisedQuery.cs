using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using KooliProjekt.Application.Dto;

namespace KooliProjekt.Application.Features.õllepruulimised
{
    public class GetõllepruulimisedQuery : IRequest<OperationResult<õllepruulimineDto>>
    {
        public int Id { get; set; }
    }
}
