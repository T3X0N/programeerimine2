using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Data
{
    /// <summary>
    /// 14.11.2025
    /// Testandmete generaator
    /// 
    /// Testandmed genereeritakse ainult siis kui mõni oluline 
    /// tabel on tühi.
    /// </summary>
    public class SeedData
    {
        private readonly ApplicationDbContext _dbContext;

        public SeedData(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Genereerib andmed
        /// </summary>
        public void Generate()
        {
            if (_dbContext.ToKasutaja.Any() && _dbContext.ToKoostisosa.Any() && _dbContext.ToLogiKande.Any() && _dbContext.ToMaitsmistelogikande.Any()
                && _dbContext.ToÕllepruulimine.Any() && _dbContext.ToÕllesort.Any())
            {
                return;
            }

            for(var i = 0; i < 10; i++)
            {
                var list = new kasutaja { Id = i,Kasutajanimi = "kasutaja" + (i + 1), Parool = "kasutaja" + (i + 1) };
                _dbContext.ToKasutaja.Add(list);

           


                var list2 = new koostisosa { Id = i, Nimetus = "koostisosa" + (i + 1), ühik = "koostisosa" + (i + 1), ühikuhind = (i + 1), kogus = (i + 1), summa = (i + 1) };
                _dbContext.ToKoostisosa.Add(list2);

        


                var list7 = new logikande { Id = i, kuupäev = "logikande" + (i + 1), kirjeldus = "logikande" + (i + 1), kasutajanimi = "logikande" + (i + 1) };
                _dbContext.ToLogiKande.Add(list7);



                var list10 = new maitsmistelogikande { Id = i, kuupäev = "maitsmistelogikande" + (i + 1), kasutajanimi = "maitsmistelogikande" + (i + 1), hinne = (i + 1), selgitus = "maitsmistelogikande" + (i + 1) };
                _dbContext.ToMaitsmistelogikande.Add(list10);




                var list14 = new õllepruulimine { Id = i, partiikood = (i + 1), partiikuupäev = "õllepruulimine" + (i + 1), kirjeldus = "õllepruulimine" + (i + 1), kokkuvõtte = "õllepruulimine" + (i + 1) };
                _dbContext.ToÕllepruulimine.Add(list14);




                var list18 = new õllesort { Id = i, kasutajanimi = "õllesort" + (i + 1), kirjeldus = "õllesort" + (i + 1), õllepruuliminejaproovipartiid = ["mango"] };
                _dbContext.ToÕllesort.Add(list18);
            }

            _dbContext.SaveChanges();
        }
    }
}
