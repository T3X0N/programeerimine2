using KooliProjekt.Application.Data;
using KooliProjekt.Application.Data.Repositories;
using KooliProjekt.Application.Features.logikanded;
using KooliProjekt.Application.Infrastructure.Paging;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.logikanded
{


        public class SavelogikandedCommandHandler : IRequestHandler<SavelogikandedCommand, OperationResult>
        {
            private readonly logikande1Repository _logikandeRepository;

            public SavelogikandedCommandHandler(logikande1Repository logikandeRepository)
            {
                _logikandeRepository = logikandeRepository;
            }

            public async Task<OperationResult> Handle(SavelogikandedCommand request, CancellationToken cancellationToken)
            {
                var result = new OperationResult();

                var list = new logikande();
                if (request.Id != 0)
                {
                list = await _logikandeRepository.GetByIdAsync(request.Id);
            }

            list.Id = request.Id;
            list.kuupäev = request.kuupäev;
            list.kirjeldus = request.kirjeldus;
            list.kasutajanimi = request.kasutajanimi;

            await _logikandeRepository.SaveAsync(list);

            return result;
        }
        }
    }




