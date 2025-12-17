using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.õllesortid;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.õllesortid
{
    public class GetõllesortidQueryHandler : IRequestHandler<GetõllesortidQuery, OperationResult<object>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetõllesortidQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<object>> Handle(GetõllesortidQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<object>();

            result.Value = await _dbContext
                .ToÕllesort

                .Where(list => list.Id == request.Id)
                .Select(list => new
                {
                    Id = list.Id,
                    kasutajanimi = list.kasutajanimi,
                    kirjeldus = list.kirjeldus,
                    õllepruuliminejaproovipartiid = list.õllepruuliminejaproovipartiid

                })
                .FirstOrDefaultAsync();

            return result;
        }
    }
}
