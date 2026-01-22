using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.õllepruulimised;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Dto;

namespace KooliProjekt.Application.Features.õllepruulimised
{
    public class GetõllepruulimisedQueryHandler : IRequestHandler<GetõllepruulimisedQuery, OperationResult<õllepruulimineDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetõllepruulimisedQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<õllepruulimineDto>> Handle(GetõllepruulimisedQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<õllepruulimineDto>();

            result.Value = await _dbContext
                .ToÕllepruulimine
                .Where(list => list.Id == request.Id)
                .Select(list => new õllepruulimineDto
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
