using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.kasutajad
{
    public class kasutajadQueryHandler : IRequestHandler<GetkasutajadQuery, OperationResult<object>>
    {
        private readonly ApplicationDbContext _dbContext;

        public kasutajadQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<object>> Handle(GetkasutajadQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<object>();

            result.Value = await _dbContext
                .ToKasutaja
                .Where(list => list.Id == request.Id)
                .Select(list => new
                {
                    Id = list.Id,
                    Kasutajanimi = list.Kasutajanimi,
                    Parool = list.Parool,

                })
                .FirstOrDefaultAsync();

            return result;
        }
    }
}
