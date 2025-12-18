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

namespace KooliProjekt.Application.Features.kasutajad
{
    public class SaveKasutajadCommandHandler : IRequestHandler<SaveKasutajadCommand, OperationResult>
    {
        private readonly ApplicationDbContext _dbContext;

        public SaveKasutajadCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult> Handle(SaveKasutajadCommand request, CancellationToken cancellationToken)
        {
            var result = new OperationResult();

            var list = new kasutaja();
            if(request.Id == 0)
            {
                await _dbContext.ToKasutaja.AddAsync(list);
            }
            else
            {
                list = await _dbContext.ToKasutaja.FindAsync(request.Id);
                //_dbContext.ToDoLists.Update(list);
            }

            list.Id = request.Id;
            list.Kasutajanimi = request.Kasutajanimi;
            list.Parool = request.Parool;


            await _dbContext.SaveChangesAsync();

            return result;
        }
    }
}
