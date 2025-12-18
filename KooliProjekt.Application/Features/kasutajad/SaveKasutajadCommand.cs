using KooliProjekt.Application.Behaviors;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Application.Features.kasutajad
{
    public class SaveKasutajadCommand : IRequest<OperationResult>, ITransactional
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(16)]
        public string Kasutajanimi { get; set; }
        [Required]
        [StringLength(16)]
        public string Parool { get; set; }
    }
}
