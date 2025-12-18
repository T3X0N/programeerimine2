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

namespace KooliProjekt.Application.Features.koostisosad
{
    public class SavekoostisosadCommandHandler : IRequestHandler<SavekoostisosadCommand, OperationResult>
    {
        private readonly koostisosa1Repository _koostisosaRepository;

        public SavekoostisosadCommandHandler(koostisosa1Repository koostisosaRepository)
        {
            _koostisosaRepository = koostisosaRepository;
        }

        public async Task<OperationResult> Handle(SavekoostisosadCommand request, CancellationToken cancellationToken)
        {
            var result = new OperationResult();

            var list = new koostisosa();
            if (request.Id != 0)
            {

                list.Id = request.Id;
            list.Nimetus = request.Nimetus;
            list.ühik = request.ühik;
            list.ühikuhind = request.ühikuhind;
            list.kogus = request.kogus;
            list.summa = request.summa;

            }
            await _koostisosaRepository.SaveAsync(list);

            return result;
        }
    }
}
