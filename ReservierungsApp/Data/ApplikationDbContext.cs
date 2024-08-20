using Microsoft.EntityFrameworkCore;
using ReservierungsApp.Models;

namespace ReservierungsApp.Data
{
    public class ApplikationDbContext : DbContext
    {
        public DbSet<Reservierungen> Reservierungens { get; set; }
        public ApplikationDbContext(DbContextOptions<ApplikationDbContext> option)
        {
            
        }
    }
}
