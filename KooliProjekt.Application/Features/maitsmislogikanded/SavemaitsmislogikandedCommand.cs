using KooliProjekt.Application.Behaviors;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;

namespace KooliProjekt.Application.Features.maitsmislogikanded
{
    public class SavemaitsmislogikandedCommand : IRequest<OperationResult>, ITransactional
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
