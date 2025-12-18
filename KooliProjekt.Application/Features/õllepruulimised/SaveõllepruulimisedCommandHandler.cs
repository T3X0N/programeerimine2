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

namespace KooliProjekt.Application.Features.õllepruulimised
{
    public class SaveõllepruulimisedCommandHandler : IRequestHandler<SaveõllepruulimisedCommand, OperationResult>
    {
        private readonly õllepruulimine1Repository _õllepruulimineRepository;

        public SaveõllepruulimisedCommandHandler(õllepruulimine1Repository õllepruulimineRepository)
        {
            _õllepruulimineRepository = õllepruulimineRepository;
        }

        public async Task<OperationResult> Handle(SaveõllepruulimisedCommand request, CancellationToken cancellationToken)
        {
            var result = new OperationResult();

            var list = new õllepruulimine();
            if (request.Id != 0)
            {
                list = await _õllepruulimineRepository.GetByIdAsync(request.Id);
            }

            list.Id = request.Id;
            list.partiikood = request.partiikood;
            list.partiikuupäev = request.partiikuupäev;
            list.kirjeldus = request.kirjeldus;
            list.koostisosad = request.koostisosad;
            list.logi = request.logi;
            list.maitsemislogi = request.maitsemislogi;
            list.kokkuvõtte = request.kokkuvõtte;


            await _õllepruulimineRepository.SaveAsync(list);

            return result;
        }
    }
}
