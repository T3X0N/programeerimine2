using KooliProjekt.Application.Behaviors;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Application.Features.koostisosad
{
    public class SavekoostisosadCommand : IRequest<OperationResult>, ITransactional
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(16)]
        public string Nimetus { get; set; }
        [Required]
        [StringLength(16)]
        public string ühik { get; set; }
        [Required]

        public float ühikuhind { get; set; }
        [Required]
        public float kogus { get; set; }
        [Required]

        public float summa { get; set; }
    }
}
