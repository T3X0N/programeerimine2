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

namespace KooliProjekt.Application.Features.logikanded
{
    public class logikandedQueryHandler : IRequestHandler<logikandedQuery, OperationResult<PagedResult<logikande>>>
    {
        private readonly ApplicationDbContext _dbContext;
        public logikandedQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<PagedResult<logikande>>> Handle(logikandedQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<PagedResult<logikande>>();
            result.Value = await _dbContext
                .ToLogiKande
                .OrderBy(list => list.kasutajanimi)
                .GetPagedAsync(request.Page, request.PageSize);

            return result;
        }
    }
}
