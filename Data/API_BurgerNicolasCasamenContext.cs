using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API_Burger.NicolasCasamen.Data.Models;

namespace API_Burger.NicolasCasamen.Data
{
    public class API_BurgerNicolasCasamenContext : DbContext
    {
        public API_BurgerNicolasCasamenContext (DbContextOptions<API_BurgerNicolasCasamenContext> options)
            : base(options)
        {
        }

        public DbSet<API_Burger.NicolasCasamen.Data.Models.Burger> Burger { get; set; } = default!;
    }
}
