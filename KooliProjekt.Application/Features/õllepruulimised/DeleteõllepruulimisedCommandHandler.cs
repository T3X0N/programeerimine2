using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.õllepruulimised
{
    /// <summary>
    /// 14.11.2025
    /// Listi kustutamise commandi handler. 
    /// Handle meetodis toimub tegelik kustutamine
    /// Muutuja request tuleb sisse brauserist
    /// </summary>
    public class DeleteõllepruulimisedCommandHandler : IRequestHandler<DeleteõllepruulimisedCommand, OperationResult>
    {
        private readonly ApplicationDbContext _dbContext;

        public DeleteõllepruulimisedCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult> Handle(DeleteõllepruulimisedCommand request, CancellationToken cancellationToken)
        {
            var result = new OperationResult();

            await _dbContext
                .ToÕllepruulimine
                .Where(t => t.Id == request.Id)
                .ExecuteDeleteAsync();

            return result;
        }
    }
}
