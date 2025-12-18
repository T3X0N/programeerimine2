using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.koostisosad
{
    public class GetkoostisosadQueryHandler : IRequestHandler<GetkoostisosadQuery, OperationResult<object>>
    {
        private readonly koostisosa1Repository _koostisosaRepository;

        public GetkoostisosadQueryHandler(koostisosa1Repository koostisosaRepository)
        {
            _koostisosaRepository = koostisosaRepository;
        }

        public async Task<OperationResult<object>> Handle(GetkoostisosadQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<object>();
            var list = await _koostisosaRepository.GetByIdAsync(request.Id);

            result.Value = new // Anonymous object
            {
                Id = list.Id,
                Nimetus = list.Nimetus,
                ühik = list.ühik,
                ühikuhind = list.ühikuhind,
                kogus = list.kogus,
                summa = list.summa

            };
            return result;
        }
    }
}
