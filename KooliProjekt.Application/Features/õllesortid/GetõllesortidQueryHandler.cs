using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
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
        private readonly õllesort1Repository _õllesortRepository;

        public GetõllesortidQueryHandler(õllesort1Repository õllesortRepository)
        {
            _õllesortRepository = õllesortRepository;
        }

        public async Task<OperationResult<object>> Handle(GetõllesortidQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<object>();
            var list = await _õllesortRepository.GetByIdAsync(request.Id);

            result.Value = new // Anonymous object

                {
                    Id = list.Id,
                    kasutajanimi = list.kasutajanimi,
                    kirjeldus = list.kirjeldus,
                    õllepruuliminejaproovipartiid = list.õllepruuliminejaproovipartiid

                };

            return result;
        }
    }
}
