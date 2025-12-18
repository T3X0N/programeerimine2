using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Data
{
    public class õllesort : Entity
    {
        [Required]
        [StringLength(16)]
        public string kasutajanimi { get; set; }
        [Required]
        [StringLength(16)]
        public string kirjeldus { get; set; }
        [Required]
        [StringLength(32)]

        public List<string> õllepruuliminejaproovipartiid { get; set; }
    }
}
