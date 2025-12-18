using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
using KooliProjekt.Application.Infrastructure.Paging;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace KooliProjekt.Application.Features.kasutajad
{
    public class SaveKasutajadCommandHandler : IRequestHandler<SaveKasutajadCommand, OperationResult>
    {
        private readonly Kasutaja1Repository _KasutajaRepository;

        public SaveKasutajadCommandHandler(Kasutaja1Repository KasutajaRepository)
        {
            _KasutajaRepository = KasutajaRepository;
        }

        public async Task<OperationResult> Handle(SaveKasutajadCommand request, CancellationToken cancellationToken)
        {
            var result = new OperationResult();

            var list = new kasutaja();
            if(request.Id == 0)
            {
                list = await _KasutajaRepository.GetByIdAsync(request.Id);
            }
          

            list.Id = request.Id;
            list.Kasutajanimi = request.Kasutajanimi;
            list.Parool = request.Parool;


            await _KasutajaRepository.SaveAsync(list);

            return result;
        }
    }
}
