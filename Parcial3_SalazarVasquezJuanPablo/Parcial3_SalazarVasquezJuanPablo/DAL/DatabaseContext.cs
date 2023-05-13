using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace Parcial3_SalazarVasquezJuanPablo.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        //public DbSet<Nombre_de_la_tabla> Countries { get; set; }
    }
}
