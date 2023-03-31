using Microsoft.EntityFrameworkCore;

namespace ParksLookupApi.Models
{
    public class ParksLookupApiContext : DbContext
    {
        public DbSet<Park> Parks { get; set; }

        public ParksLookupApiContext(DbContextOptions<ParksLookupApiContext> options) : base(options)
        {
        }

         protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Park>()
                    .HasData(
                new Park { ParkId = 1, Name = "Yellowstone", State = "Wyoming" },
                new Park { ParkId = 2, Name = "Grand Canyon", State = "Arizona" },
                new Park { ParkId = 3, Name = "Glacier", State = "Montana" },
                new Park { ParkId = 4, Name = "Zion", State = "Utah" },
                new Park { ParkId = 5, Name = "Denali", State = "Alaska" }
                );
        }
    }
}