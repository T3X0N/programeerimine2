using KooliProjekt.Application.Infrastructure.Results;
using MediatR;

namespace KooliProjekt.Application.Features.maitsmislogikanded
{
    /// <summary>
    /// 14.11.2025
    /// Listi kustutamise command
    /// </summary>
    public class DeletemaitsmislogikandedCommand : IRequest<OperationResult>
    {
        public int Id { get; set; }
    }
}
