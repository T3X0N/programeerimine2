using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using KooliProjekt.Application.Dto;

namespace KooliProjekt.Application.Features.maitsmislogikanded
{
    public class GetmaitsmislogikandedQueryHandler : IRequestHandler<GetmaitsmislogikandedQuery, OperationResult<maitsmistelogikandeDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetmaitsmislogikandedQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<maitsmistelogikandeDto>> Handle(GetmaitsmislogikandedQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<maitsmistelogikandeDto>();

            result.Value = await _dbContext
                .ToMaitsmistelogikande
                .Where(list => list.Id == request.Id)
                .Select(list => new maitsmistelogikandeDto
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
