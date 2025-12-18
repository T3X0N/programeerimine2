using KooliProjekt.Application.Behaviors;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Application.Features.õllepruulimised
{
    public class SaveõllepruulimisedCommand : IRequest<OperationResult>, ITransactional
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int partiikood { get; set; }
        [Required]
        [StringLength(16)]
        public string partiikuupäev { get; set; }
        [Required]
        [StringLength(16)]
        public string kirjeldus { get; set; }
        [Required]
        [StringLength(16)]
        public List<string> koostisosad { get; set; }
        [Required]
        [StringLength(16)]
        public List<string> logi { get; set; }
        [Required]
        [StringLength(16)]
        public List<string> maitsemislogi { get; set; }
        [Required]
        [StringLength(16)]
        public string kokkuvõtte { get; set; }
    }
}
