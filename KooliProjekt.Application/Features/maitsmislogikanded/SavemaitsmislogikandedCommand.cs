using KooliProjekt.Application.Behaviors;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Application.Features.maitsmislogikanded
{
    public class SavemaitsmislogikandedCommand : IRequest<OperationResult>, ITransactional
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(16)]

        public string kuupäev { get; set; }
        [Required]
        [StringLength(16)]
        public string kasutajanimi { get; set; }
        [Required]
        public float hinne { get; set; }
        [Required]
        [StringLength(16)]
        public string selgitus { get; set; }
    }
}
