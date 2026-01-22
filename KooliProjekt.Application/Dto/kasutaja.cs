using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Dto
{
   public class kasutajaDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(16)]
        public  string Kasutajanimi { get; set; }
        [Required]
        [StringLength(16)]
        public string Parool {  get; set; }
    }
}
