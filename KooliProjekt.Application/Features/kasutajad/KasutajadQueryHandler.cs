using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Infrastructure.Paging;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.kasutajad
{
    public class KasutajadQueryHandler : IRequestHandler<KasutajadQuery, OperationResult<PagedResult<kasutaja>>>
    {
        private readonly ApplicationDbContext _dbContext;
        public KasutajadQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<PagedResult<kasutaja>>> Handle(KasutajadQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<PagedResult<kasutaja>>();
            result.Value = await _dbContext
                .ToKasutaja
                .OrderBy(list => list.kasutajanimi)
                .GetPagedAsync(request.Page, request.PageSize);
            return result;
        }
    }
}
