using Microsoft.EntityFrameworkCore;
using Parcial3_SalazarVasquezJuanPablo.DAL.Entities;

namespace Parcial3_SalazarVasquezJuanPablo.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Service> Services { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleDetail> VehicleDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Service>().HasIndex(v => v.Name).IsUnique();
        }
    }
}
