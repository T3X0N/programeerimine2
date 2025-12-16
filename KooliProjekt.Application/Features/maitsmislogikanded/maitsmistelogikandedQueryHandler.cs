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
    public class maitsmistelogikandedQueryHandler : IRequestHandler<maitsmistelogikandedQuery, OperationResult<IList<maitsmistelogikande>>>
    {
        private readonly ApplicationDbContext _dbContext;
        public maitsmistelogikandedQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<IList<maitsmistelogikande>>> Handle(maitsmistelogikandedQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<IList<maitsmistelogikande>>();
            result.Value = await _dbContext
                .ToMaitsmistelogikande
                .OrderBy(list => list.kasutajanimi)
                .ToListAsync();

            return result;
        }
    }
}
