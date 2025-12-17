using KooliProjekt.Application.Infrastructure.Results;
using MediatR;

namespace KooliProjekt.Application.Features.õllesortid
{
    public class GetõllesortidQuery : IRequest<OperationResult<object>>
    {
        public int Id { get; set; }
    }
}
