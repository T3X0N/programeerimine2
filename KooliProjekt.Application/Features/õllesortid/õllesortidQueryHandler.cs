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
    public class õllesortidQueryHandler : IRequestHandler<õllesortidQuery, OperationResult<IList<õllesort>>>
    {
        private readonly ApplicationDbContext _dbContext;
        public õllesortidQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<IList<õllesort>>> Handle(õllesortidQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<IList<õllesort>>();
            result.Value = await _dbContext
                .ToÕllesort
                .OrderBy(list => list.kasutajanimi)
                .ToListAsync();

            return result;
        }
    }
}
