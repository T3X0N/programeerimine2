using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
using KooliProjekt.Application.Features.õllepruulimised;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.õllepruulimised
{
    public class GetõllepruulimisedQueryHandler : IRequestHandler<GetõllepruulimisedQuery, OperationResult<object>>
    {
        private readonly õllepruulimine1Repository _õllepruulimineRepository;

        public GetõllepruulimisedQueryHandler(õllepruulimine1Repository õllepruulimineRepository)
        {
            _õllepruulimineRepository = õllepruulimineRepository;
        }

        public async Task<OperationResult<object>> Handle(GetõllepruulimisedQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<object>();
            var list = await _õllepruulimineRepository.GetByIdAsync(request.Id);

            result.Value = new // Anonymous object


            {
                Id = list.Id,
                partiikood = list.partiikood,
                partiikuupäev = list.partiikuupäev,
                kirjeldus = list.kirjeldus,
                koostisosad = list.koostisosad,
                logi = list.logi,
                maitsemislogi = list.maitsemislogi,
                kokkuvõtte = list.kokkuvõtte

            };

            return result;
        }
    }
}
