using Microsoft.EntityFrameworkCore;
using CustomersApi.Models;

namespace CustomersApi.Data
{
    public class ApiDbContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LCANOASUS\LCANOASUS;Integrated Security=True;Connect Timeout=30;Database=PVMCustomerApi;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
        }
    }
}
