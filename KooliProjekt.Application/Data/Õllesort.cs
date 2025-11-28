using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Data
{
    internal class Ollesort
    {
        public int Id { get; set; }
        public string nimi { get; set; }
        public string kirjeldus { get; set; }

        public List<string> õllepruuliminejaproovipartiid { get; set; }
    }
}
