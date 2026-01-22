using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using KooliProjekt.Application.Dto;

namespace KooliProjekt.Application.Features.õllesortid
{
    public class GetõllesortidQuery : IRequest<OperationResult<õllesortDto>>
    {
        public int Id { get; set; }
    }
}
