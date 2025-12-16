using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<kasutaja> ToKasutaja { get; set; }
        public DbSet<koostisosa> ToKoostisosa { get; set; }
        public DbSet<logikande> ToLogiKande { get; set; }
        public DbSet<maitsmistelogikande> ToMaitsmistelogikande { get; set; }
        public DbSet<õllepruulimine> ToÕllepruulimine { get; set; }
        public DbSet<õllesort> ToÕllesort { get; set; }

    }
}

