using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Data
{
   public class koostisosa : Entity
    {
      
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

        public float summa {get; set;}


    }
}