using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.õllepruulimised;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.õllepruulimised
{
    public class GetõllepruulimisedQueryHandler : IRequestHandler<GetõllepruulimisedQuery, OperationResult<object>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetõllepruulimisedQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<object>> Handle(GetõllepruulimisedQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<object>();

            result.Value = await _dbContext
                .ToÕllepruulimine
                .Where(list => list.Id == request.Id)
                .Select(list => new
                {
                    Id = list.Id,
                    partiikood = list.partiikood,
                    partiikuupäev = list.partiikuupäev,
                    kirjeldus = list.kirjeldus,
                    koostisosad = list.koostisosad,
                    logi = list.logi,
                    maitsemislogi = list.maitsemislogi,
                    kokkuvõtte = list.kokkuvõtte

                })
                .FirstOrDefaultAsync();

            return result;
        }
    }
}
