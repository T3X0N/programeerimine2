using KooliProjekt.Application.Infrastructure.Results;
using MediatR;

namespace KooliProjekt.Application.Features.õllepruulimised
{
    public class GetõllepruulimisedQuery : IRequest<OperationResult<object>>
    {
        public int Id { get; set; }
    }
}
