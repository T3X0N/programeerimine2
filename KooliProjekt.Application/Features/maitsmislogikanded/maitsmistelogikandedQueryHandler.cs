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

namespace KooliProjekt.Application.Features.maitsmistelogikanded
{
    public class maitsmistelogikandedQueryHandler : IRequestHandler<maitsmistelogikandedQuery, OperationResult<PagedResult<maitsmistelogikande>>>
    {
        private readonly ApplicationDbContext _dbContext;
        public maitsmistelogikandedQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<PagedResult<maitsmistelogikande>>> Handle(maitsmistelogikandedQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<PagedResult<maitsmistelogikande>>();
            result.Value = await _dbContext
                .ToMaitsmistelogikande
                .OrderBy(list => list.kasutajanimi)
                .GetPagedAsync(request.Page, request.PageSize);

            return result;
        }
    }
}
