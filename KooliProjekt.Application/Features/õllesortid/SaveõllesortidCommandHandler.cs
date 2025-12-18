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

namespace KooliProjekt.Application.Features.õllesortid
{
    public class SaveõllesortidCommandHandler : IRequestHandler<SaveõllesortidCommand, OperationResult>
    {
        private readonly ApplicationDbContext _dbContext;

        public SaveõllesortidCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult> Handle(SaveõllesortidCommand request, CancellationToken cancellationToken)
        {
            var result = new OperationResult();

            var list = new õllesort();
            if(request.Id == 0)
            {
                await _dbContext.ToÕllesort.AddAsync(list);
            }
            else
            {
                list = await _dbContext.ToÕllesort.FindAsync(request.Id);
                //_dbContext.ToDoLists.Update(list);
            }

            list.Id = request.Id;
            list.kasutajanimi = request.kasutajanimi;
            list.kirjeldus = request.kirjeldus;
            list.õllepruuliminejaproovipartiid = request.õllepruuliminejaproovipartiid;

            await _dbContext.SaveChangesAsync();

            return result;
        }
    }
}
