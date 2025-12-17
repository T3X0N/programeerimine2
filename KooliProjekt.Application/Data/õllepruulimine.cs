using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Data
{
    public class õllepruulimine
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int partiikood { get; set; }
        [Required]
        [StringLength(16)]
        public string partiikuupäev {  get; set; }
        [Required]
        [StringLength(16)]
        public string kirjeldus { get; set; }
        [Required]
        [StringLength(16)]
        public List<string> koostisosad {  get; set; }
        [Required]
        [StringLength(16)]
        public List<string> logi {  get; set; }
        [Required]
        [StringLength(16)]
        public List<string> maitsemislogi {  get; set; }
        [Required]
        [StringLength(16)]
        public string kokkuvõtte {  get; set; }
    }
}
