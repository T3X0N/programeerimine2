using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.logikanded
{
    public class GetToDoListQueryHandler : IRequestHandler<GetToDoListQuery, OperationResult<object>>
    {
        private readonly Repository _toDoListRepository;

        public GetToDoListQueryHandler(IToDoListRepository toDoListRepository)
        {
            _toDoListRepository = toDoListRepository;
        }

        public async Task<OperationResult<object>> Handle(GetToDoListQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<object>();
            var list = await _toDoListRepository.GetByIdAsync(request.Id);

            result.Value = new // Anonymous object
            {

                Id = list.Id,
                kuupäev = list.kuupäev,        
                kirjeldus = list.kirjeldus,
                kasutajanimi = list.kasutajanimi,
            };

            return result;
        }
    }
}
