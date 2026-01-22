using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.õllesortid;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Dto;

namespace KooliProjekt.Application.Features.õllesortid
{
    public class GetõllesortidQueryHandler : IRequestHandler<GetõllesortidQuery, OperationResult<õllesortDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetõllesortidQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<õllesortDto>> Handle(GetõllesortidQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<õllesortDto>();

            result.Value = await _dbContext
                .ToÕllesort

                .Where(list => list.Id == request.Id)
                .Select(list => new õllesortDto
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
