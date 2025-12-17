using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.maitsmislogikanded
{
    public class GetmaitsmislogikandedQueryHandler : IRequestHandler<GetmaitsmislogikandedQuery, OperationResult<object>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetmaitsmislogikandedQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<object>> Handle(GetmaitsmislogikandedQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<object>();

            result.Value = await _dbContext
                .ToMaitsmistelogikande
                .Where(list => list.Id == request.Id)
                .Select(list => new
                {
                    Id = list.Id,
                    kuupäev = list.kuupäev,
                    kasutajanimi = list.kasutajanimi,
                    hinne = list.hinne,
                    selgitus = list.selgitus


                })
                .FirstOrDefaultAsync();

            return result;
        }
    }
}
