using KooliProjekt.Application.Data;
using KooliProjekt.Application.Infrastructure.Paging;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using System.Collections.Generic;

namespace KooliProjekt.Application.Features.õllepruulimised
{
    public class õllepruulimisedQuery : IRequest<OperationResult<PagedResult<õllepruulimine>>>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
