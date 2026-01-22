using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Dto
{
    public class logikandeDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(16)]
        public string kuupäev { get; set; }
        [Required]
        [StringLength(16)]
        public string kirjeldus { get; set; }
        [Required]
        [StringLength(16)]
        public string kasutajanimi { get; set; }
    }
}
