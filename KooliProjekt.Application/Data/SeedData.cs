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
                var list = new kasutaja { Id = i,Kasutajanimi = "kasutaja" + (i + 1) };
                _dbContext.ToKasutaja.Add(list);

                var list1 = new kasutaja { Id = i, Parool = "kasutaja" + (i + 1) };
                _dbContext.ToKasutaja.Add(list1);



                var list2 = new koostisosa { Id = i, Nimetus = "koostisosa" + (i + 1) };
                _dbContext.ToKoostisosa.Add(list2);

                var list3 = new koostisosa { Id = i, ühik = "koostisosa" + (i + 1) };
                _dbContext.ToKoostisosa.Add(list3);

                var list4 = new koostisosa { Id = i, ühikuhind = "koostisosa" + (i + 1) };
                _dbContext.ToKoostisosa.Add(list4);

                var list5 = new koostisosa { Id = i, kogus = "koostisosa" + (i + 1) };
                _dbContext.ToKoostisosa.Add(list5);

                var list6 = new koostisosa { Id = i, summa = "koostisosa" + (i + 1) };
                _dbContext.ToKoostisosa.Add(list6);



                var list7 = new logikande { Id = i, kuupäev = "logikande" + (i + 1) };
                _dbContext.ToLogiKande.Add(list7);

                var list8 = new logikande { Id = i, kirjeldus = "logikande" + (i + 1) };
                _dbContext.ToLogiKande.Add(list8);

                var list9 = new logikande { Id = i, kasutajanimi = "logikande" + (i + 1) };
                _dbContext.ToLogiKande.Add(list9);



                var list10 = new maitsmistelogikande { Id = i, kuupäev = "maitsmistelogikande" + (i + 1) };
                _dbContext.ToMaitsmistelogikande.Add(list10);

                var list11 = new maitsmistelogikande { Id = i, kasutajanimi = "maitsmistelogikande" + (i + 1) };
                _dbContext.ToMaitsmistelogikande.Add(list11);

                var list12 = new maitsmistelogikande { Id = i, hinne = "maitsmistelogikande" + (i + 1) };
                _dbContext.ToMaitsmistelogikande.Add(list12);

                var list13 = new maitsmistelogikande { Id = i, selgitus = "maitsmistelogikande" + (i + 1) };
                _dbContext.ToMaitsmistelogikande.Add(list13);



                var list14 = new õllepruulimine { Id = i, partiikood = "õllepruulimine" + (i + 1) };
                _dbContext.ToÕllepruulimine.Add(list14);

                var list15 = new õllepruulimine { Id = i, partiikuupäev = "õllepruulimine" + (i + 1) };
                _dbContext.ToÕllepruulimine.Add(list15);

                var list16 = new õllepruulimine { Id = i, kirjeldus = "õllepruulimine" + (i + 1) };
                _dbContext.ToÕllepruulimine.Add(list16);

                var list17 = new õllepruulimine { Id = i, kokkuvõtte = "õllepruulimine" + (i + 1) };
                _dbContext.ToÕllepruulimine.Add(list17);



                var list18 = new õllesort { Id = i, kasutajanimi = "õllesort" + (i + 1) };
                _dbContext.ToÕllesort.Add(list18);

                var list19 = new õllesort { Id = i, kirjeldus = "õllesort" + (i + 1) };
                _dbContext.ToÕllesort.Add(list19);

                var list20 = new õllesort { Id = i, õllepruuliminejaproovipartiid = "õllesort" + (i + 1) };
                _dbContext.ToÕllesort.Add(list20);























































            }

            _dbContext.SaveChanges();
        }
    }
}
