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
    public class koostisosadQueryHandler : IRequestHandler<koostisosadQuery, OperationResult<IList<koostisosa>>>
    {
        private readonly ApplicationDbContext _dbContext;
        public koostisosadQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<IList<koostisosa>>> Handle(koostisosadQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<IList<kasutaja>>();
            result.Value = await _dbContext
                .ToKasutaja
                .OrderBy(list => list.kasutajanimi)
                .ToListAsync();

            return result;
        }
    }
}
