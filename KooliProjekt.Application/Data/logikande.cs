using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Data
{
    public class logikande
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
