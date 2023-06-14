using Microsoft.EntityFrameworkCore;
using WebAPI1.Entities;

namespace WebAPI1.DataAccessLayer
{
    public class DataContext : DbContext
    {
        //Set tables for our DB
        public DbSet<Restaurant> Restaurants { get; set; } = default!;
        public DbSet<Table> Tables { get; set; } = default!;
        public DbSet<Reservation> Reservations { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = ENDAUTOJL9TSPHK\\SQLEXPRESS; Database = Restaurant; Trusted_Connection =True");
        }

    }
}
