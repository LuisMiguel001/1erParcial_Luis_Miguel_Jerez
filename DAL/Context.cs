using _1erParcial_Luis_Miguel_Jerez.Models;
using Microsoft.EntityFrameworkCore;

namespace _1erParcial_Luis_Miguel_Jerez.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> Options)
            :base(Options) { }

        public DbSet<Ingresos> Ingresos { get; set; } 
    }
}
