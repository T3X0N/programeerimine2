using KooliProjekt.Application.Infrastructure.Results;
using MediatR;

namespace KooliProjekt.Application.Features.logikanded
{
    public class GetlogikandedQuery : IRequest<OperationResult<object>>
    {
        public int Id { get; set; }
    }
}
