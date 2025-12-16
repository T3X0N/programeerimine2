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
    public class logikandedQueryHandler : IRequestHandler<logikandedQuery, OperationResult<IList<logikande>>>
    {
        private readonly ApplicationDbContext _dbContext;
        public logikandedQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<IList<logikande>>> Handle(logikandedQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<IList<logikande>>();
            result.Value = await _dbContext
                .ToLogiKande
                .OrderBy(list => list.kasutajanimi)
                .ToListAsync();

            return result;
        }
    }
}
