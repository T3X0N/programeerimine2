using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Infrastructure.Paging;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace KooliProjekt.Application.Features.maitsmislogikanded
{
    public class SavemaitsmislogikandedCommandHandler : IRequestHandler<SavemaitsmislogikandedCommand, OperationResult>
    {
        private readonly ApplicationDbContext _dbContext;

        public SavemaitsmislogikandedCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult> Handle(SavemaitsmislogikandedCommand request, CancellationToken cancellationToken)
        {
            var result = new OperationResult();

            var list = new maitsmistelogikande();
            if(request.Id == 0)
            {
                await _dbContext.ToMaitsmistelogikande.AddAsync(list);
            }
            else
            {
                list = await _dbContext.ToMaitsmistelogikande.FindAsync(request.Id);
                //_dbContext.ToDoLists.Update(list);
            }

            list.Id = request.Id;
            list.kuupäev = request.kuupäev;
            list.kasutajanimi = request.kasutajanimi;
            list.hinne = request.hinne;
            list.selgitus = request.selgitus;


            await _dbContext.SaveChangesAsync();

            return result;
        }
    }
}
