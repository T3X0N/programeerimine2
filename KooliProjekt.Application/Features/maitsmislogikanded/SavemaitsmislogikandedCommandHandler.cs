using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
using KooliProjekt.Application.Features.maitsmislogikanded;
using KooliProjekt.Application.Infrastructure.Paging;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace KooliProjekt.Application.Features.maitsmistelogikanded
{
   

        public class SavemaitsmislogikandedCommandHandler : IRequestHandler<SavemaitsmislogikandedCommand, OperationResult>
        {
            private readonly maitsmistelogikande1Repository _maitsmistelogikandeRepository;

            public SavemaitsmislogikandedCommandHandler(maitsmistelogikande1Repository maitsmistelogikandeRepository)
            {
                _maitsmistelogikandeRepository = maitsmistelogikandeRepository;
            }

            public async Task<OperationResult> Handle(SavemaitsmislogikandedCommand request, CancellationToken cancellationToken)
            {
                var result = new OperationResult();

                var list = new maitsmistelogikande();
                if (request.Id != 0)
                {
                list = await _maitsmistelogikandeRepository.GetByIdAsync(request.Id);
            }

            list.Id = request.Id;
            list.kuupäev = request.kuupäev;
            list.kasutajanimi = request.kasutajanimi;
            list.hinne = request.hinne;
            list.selgitus = request.selgitus;


            await _maitsmistelogikandeRepository.SaveAsync(list);

            return result;
        }
    }
}
