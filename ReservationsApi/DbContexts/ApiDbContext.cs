using Microsoft.EntityFrameworkCore;
using ReservationsApi.Models;

namespace ReservationsApi.DbContext
{
    public class ApiDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Reservation> Reservations { get; set; }    

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LCANOASUS\LCANOASUS;Integrated Security=True;Connect Timeout=30;Database=PVMReservationApi;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
        }
    }
}
