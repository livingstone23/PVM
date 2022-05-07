using Microsoft.EntityFrameworkCore;
using VehiclesApi.Models;

namespace VehiclesApi.DbContexts
{
    public class ApiDbContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LCANOASUS\LCANOASUS;Integrated Security=True;Connect Timeout=30;Database=PVMVehicleApi;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
        }
    }
}
