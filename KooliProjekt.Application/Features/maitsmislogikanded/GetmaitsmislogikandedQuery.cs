using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using KooliProjekt.Application.Dto;

namespace KooliProjekt.Application.Features.maitsmislogikanded
{
    public class GetmaitsmislogikandedQuery : IRequest<OperationResult<maitsmistelogikandeDto>>
    {
        public int Id { get; set; }
    }
}
