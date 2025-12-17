using KooliProjekt.Application.Data;
using KooliProjekt.Application.Infrastructure.Paging;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using System.Collections.Generic;

namespace KooliProjekt.Application.Features.koostisosad
{
    public class koostisosadQuery : IRequest<OperationResult<PagedResult<koostisosa>>>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
