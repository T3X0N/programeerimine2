using KooliProjekt.Application.Data;
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

namespace KooliProjekt.Application.Features.ToDoLists
{
    public class SavelogikandedCommandHandler : IRequestHandler<SavelogikandedCommand, OperationResult>
    {
        private readonly ApplicationDbContext _dbContext;

        public SavelogikandedCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult> Handle(SavelogikandedCommand request, CancellationToken cancellationToken)
        {
            var result = new OperationResult();

            var list = new logikande();
            if(request.Id == 0)
            {
                await _dbContext.ToLogiKande.AddAsync(list);
            }
            else
            {
                list = await _dbContext.ToLogiKande.FindAsync(request.Id);
                //_dbContext.ToDoLists.Update(list);
            }

            list.Id = request.Id;
            list.kuupäev = request.kuupäev;

            await _dbContext.SaveChangesAsync();

            return result;
        }
    }
}
