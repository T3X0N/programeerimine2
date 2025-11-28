using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Data
{
    internal class õllepruulimine
    {
        public int Id { get; set; }
        public int partiikood { get; set; }
        public string partiikuupäev {  get; set; }
        public string kirjeldus { get; set; }
        public List<string> koostisosad {  get; set; }
        public List<string> logi {  get; set; }
        public List<string> maitsemislogi {  get; set; }
        public string kokkuvõtte {  get; set; }
    }
}
