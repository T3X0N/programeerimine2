using KooliProjekt.Application.Data;
using KooliProjekt.Application.Infrastructure.Paging;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using System.Collections.Generic;

namespace KooliProjekt.Application.Features.kasutajad
{
    public class KasutajadQuery : IRequest<OperationResult<PagedResult<kasutaja>>>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
