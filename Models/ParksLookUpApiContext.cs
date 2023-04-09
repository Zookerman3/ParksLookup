using Microsoft.EntityFrameworkCore;

namespace ParksLookupApi.Models
{
    public class ParksLookupApiContext : DbContext
    {
        public DbSet<Park> Parks { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }


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

            builder.Entity<Review>()
              .HasData(
          new Review { ReviewId = 1, ParkId = 1, Title = "Yellowstone Review", Description = "Words Would go here", Rating = 1 },
          new Review { ReviewId = 2, ParkId = 2, Title = "Grand Canyon Review", Description = "Words Would go here", Rating = 2 },
          new Review { ReviewId = 3, ParkId = 3, Title = "Glaciers Review", Description = "Words Would go here", Rating = 3 },
          new Review { ReviewId = 4, ParkId = 4, Title = "Zion Review", Description = "Words Would go here", Rating = 4 },
          new Review { ReviewId = 5, ParkId = 5, Title = "Denali Review", Description = "Words Would go here", Rating = 5 }
  );

            builder.Entity<User>()
                    .HasKey(u => u.UserId);
            builder.Entity<User>()
                        .HasData(
                    new User { UserId = "admin", Name = "JoeMama", Password = "password" });
        }
    }
}