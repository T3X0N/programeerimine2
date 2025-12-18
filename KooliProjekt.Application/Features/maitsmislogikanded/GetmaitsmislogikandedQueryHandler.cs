using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.maitsmislogikanded
{
    public class GetmaitsmislogikandedQueryHandler : IRequestHandler<GetmaitsmislogikandedQuery, OperationResult<object>>
    {
        private readonly maitsmistelogikande1Repository _maitsmislogikandeRepository;

        public GetmaitsmislogikandedQueryHandler(maitsmistelogikande1Repository maitsmislogikandeRepository)
        {
            _maitsmislogikandeRepository = maitsmislogikandeRepository;
        }

        public async Task<OperationResult<object>> Handle(GetmaitsmislogikandedQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<object>();
            var list = await _maitsmislogikandeRepository.GetByIdAsync(request.Id);

            result.Value = new // Anonymous object
            {
                Id = list.Id,
                kuupäev = list.kuupäev,
                kasutajanimi = list.kasutajanimi,
                hinne = list.hinne,
                selgitus = list.selgitus


            };
          

            return result;
        }
    }
}
