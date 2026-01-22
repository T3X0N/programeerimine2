using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using KooliProjekt.Application.Dto;

namespace KooliProjekt.Application.Features.koostisosad
{
    public class GetkoostisosadQueryHandler : IRequestHandler<GetkoostisosadQuery, OperationResult<koostisosaDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetkoostisosadQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<koostisosaDto>> Handle(GetkoostisosadQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<koostisosaDto>();

            result.Value = await _dbContext
                .ToKoostisosa
                .Where(list => list.Id == request.Id)
                .Select(list => new koostisosaDto
                {
                    Id = list.Id,
                    Nimetus = list.Nimetus,
                    ühik = list.ühik,
                    ühikuhind = list.ühikuhind,
                    kogus = list.kogus,
                    summa = list.summa

                })
                .FirstOrDefaultAsync();

            return result;
        }
    }
}
