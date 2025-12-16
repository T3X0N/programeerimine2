using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Data
{
   public class koostisosa
    {
        public int Id { get; set; }

        public string Nimetus { get; set; }
        public string ühik { get; set; }

        public float ühikuhind { get; set; }
        public float kogus { get; set; }

        public float summa {get; set;}


    }
}