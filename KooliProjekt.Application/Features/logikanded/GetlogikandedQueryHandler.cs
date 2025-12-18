using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.logikanded
{
    public class GetlogikandedQueryHandler : IRequestHandler<GetlogikandedQuery, OperationResult<object>>
    {
        private readonly logikande1Repository _logikandeRepository;

        public GetlogikandedQueryHandler(logikande1Repository logikandeRepository)
        {
            _logikandeRepository = logikandeRepository;
        }

        public async Task<OperationResult<object>> Handle(GetlogikandedQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<object>();
            var list = await _logikandeRepository.GetByIdAsync(request.Id);

            result.Value = new // Anonymous object
            {

                Id = list.Id,
                kuupäev = list.kuupäev,
                kirjeldus = list.kirjeldus,
                kasutajanimi = list.kasutajanimi,
            };

            return result;
        }
    }
}
