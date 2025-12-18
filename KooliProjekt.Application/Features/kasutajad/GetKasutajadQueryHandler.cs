using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.kasutajad
{
    public class GetkasutajadQueryHandler : IRequestHandler<GetkasutajadQuery, OperationResult<object>>
    {
        private readonly Kasutaja1Repository _KasutajaRepository;

        public GetkasutajadQueryHandler(Kasutaja1Repository KasutajaRepository)
        {
            _KasutajaRepository = KasutajaRepository;
        }

        public async Task<OperationResult<object>> Handle(GetkasutajadQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<object>();
            var list = await _KasutajaRepository.GetByIdAsync(request.Id);

            result.Value = new
            {
                Id = list.Id,
                Kasutajanimi = list.Kasutajanimi,
                Parool = list.Parool
            };



            return result;
        }
    }
}
