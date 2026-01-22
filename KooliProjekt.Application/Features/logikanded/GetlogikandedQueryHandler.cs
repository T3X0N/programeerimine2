using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using KooliProjekt.Application.Dto;

namespace KooliProjekt.Application.Features.logikanded
{
    public class GetlogikandedQueryHandler : IRequestHandler<GetlogikandedQuery, OperationResult<logikandeDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetlogikandedQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<logikandeDto>> Handle(GetlogikandedQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<logikandeDto>();

            result.Value = await _dbContext
                .ToLogiKande
                .Where(list => list.Id == request.Id)
                .Select(list => new logikandeDto
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
