using System.Collections.Generic;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;

namespace KooliProjekt.Application.Features.kasutajad
{
    public class õllepruulimisedQuery : IRequest<OperationResult<IList<õllepruulimine>>>
    {
    }
}
