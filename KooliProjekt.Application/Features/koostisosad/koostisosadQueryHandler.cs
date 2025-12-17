using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.kasutajad;
using KooliProjekt.Application.Infrastructure.Paging;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.koostisosad
{
    public class koostisosadQueryHandler : IRequestHandler<koostisosadQuery, OperationResult<PagedResult<koostisosa>>>
    {
        private readonly ApplicationDbContext _dbContext;
        public koostisosadQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<PagedResult<koostisosa>>> Handle(koostisosadQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<PagedResult<koostisosa>>();
            result.Value = await _dbContext
                .ToKoostisosa
                .OrderBy(item => item.Nimetus)
                .GetPagedAsync(request.Page, request.PageSize);

            return result;
        }
    }
}
