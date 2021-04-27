using Microsoft.EntityFrameworkCore;
using practica02.Models;

namespace practica02.Data
{
    public class PresentacionContext: DbContext
    {
        public DbSet<Presentacion> Pokemones { get; set; }

         public DbSet<Presentacion> Pokemones2 { get; set; }
            public DbSet<Presentacion> Pokemones3{ get; set; }

        public PresentacionContext(DbContextOptions dco) : base(dco) {

        }
    }
    }