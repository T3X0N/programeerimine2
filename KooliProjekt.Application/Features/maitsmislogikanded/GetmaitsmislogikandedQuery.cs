using KooliProjekt.Application.Infrastructure.Results;
using MediatR;

namespace KooliProjekt.Application.Features.maitsmislogikanded
{
    public class GetmaitsmislogikandedQuery : IRequest<OperationResult<object>>
    {
        public int Id { get; set; }
    }
}
