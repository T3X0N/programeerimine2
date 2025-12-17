using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.logikanded
{
    public class GetlogikandedQueryHandler : IRequestHandler<GetlogikandedQuery, OperationResult<object>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetlogikandedQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<object>> Handle(GetlogikandedQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<object>();

            result.Value = await _dbContext
                .ToLogiKande
                .Where(list => list.Id == request.Id)
                .Select(list => new
                {
                    Id = list.Id,
                    kuupäev = list.kuupäev,
                    kirjeldus = list.kirjeldus,
                    kasutajanimi = list.kasutajanimi,

                })
                .FirstOrDefaultAsync();

            return result;
        }
    }
}
