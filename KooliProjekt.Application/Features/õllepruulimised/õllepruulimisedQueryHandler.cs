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
    public class õllepruulimisedQueryHandler : IRequestHandler<õllepruulimisedQuery, OperationResult<IList<õllepruulimine>>>
    {
        private readonly ApplicationDbContext _dbContext;
        public õllepruulimisedQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<IList<õllepruulimine>>> Handle(õllepruulimisedQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<IList<õllepruulimine>>();
            result.Value = await _dbContext
                .ToÕllepruulimine
                .OrderBy(list => list.kasutajanimi)
                .ToListAsync();

            return result;
        }
    }
}
