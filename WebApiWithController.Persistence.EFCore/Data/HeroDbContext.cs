using Microsoft.EntityFrameworkCore;
using WebApiWithController.Persistence.EFCore.Models;

namespace WebApiWithController.Persistence.EFCore.Data;

public class HeroDbContext : DbContext
{
    public HeroDbContext(DbContextOptions<HeroDbContext> options) : base(options)
    {
    }

    public DbSet<Hero> Heroes { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Hero>().HasData(
            new Hero { Id = 1, Name = "Steve Rogers", SuperHeroName = "Captain America", Team = "Avengers" },
            new Hero { Id = 2, Name = "Tony Stark", SuperHeroName = "", Team = "Avengers" },
            new Hero { Id = 3, Name = "Bruce Banner", SuperHeroName = "Hulk", Team = "Avengers" },
            new Hero { Id = 4, Name = "Thor Odinson", SuperHeroName = "Thor", Team = "Avengers" },
            new Hero { Id = 5, Name = "Natasha Romanoff", SuperHeroName = "Black Widow", Team = "Avengers" },
            new Hero { Id = 6, Name = "Clint Barton", SuperHeroName = "Hawkeye", Team = "Avengers" },
            new Hero { Id = 7, Name = "Wanda Maximoff", SuperHeroName = "Scarlet Witch", Team = "Avengers" },
            new Hero { Id = 8, Name = "Vision", SuperHeroName = "", Team = "Avengers" },
            new Hero { Id = 9, Name = "James Rhodes", SuperHeroName = "War Machine", Team = "Avengers" },
            new Hero { Id = 10, Name = "Sam Wilson", SuperHeroName = "Falcon", Team = "Avengers" },
            new Hero { Id = 11, Name = "Clark Kent", SuperHeroName = "Superman", Team = "Justice League" },
            new Hero { Id = 12, Name = "Bruce Wayne", SuperHeroName = "Batman", Team = "Justice League" }
        );
    }
}