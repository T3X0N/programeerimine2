using KooliProjekt.Application.Behaviors;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Application.Features.õllesortid
{
    public class SaveõllesortidCommand : IRequest<OperationResult>, ITransactional
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(16)]
        public string kasutajanimi { get; set; }
        [Required]
        [StringLength(16)]
        public string kirjeldus { get; set; }
        [Required]
        [StringLength(16)]

        public List<string> õllepruuliminejaproovipartiid { get; set; }
    }
}
