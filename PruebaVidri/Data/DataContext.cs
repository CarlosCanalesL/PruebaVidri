using Microsoft.EntityFrameworkCore;
using PruebaVidri.Entities;

namespace PruebaVidri.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Hero>().HasData(
                new Hero { HeroId = 1, name="Batman", Alias="The Dark Knight" },
                new Hero { HeroId = 2, name = "Spider-man", Alias = "Friendly Neighbor" },
                new Hero { HeroId = 3, name = "Flash", Alias = "The Fastest Man" },
                new Hero { HeroId = 4, name = "Green Lantern", Alias = "" },
                new Hero { HeroId = 5, name = "Thor", Alias = "God of Thunder" },
                new Hero { HeroId = 6, name = "Captain America", Alias = "The First Avenger" }
            );
            

        modelBuilder.Entity<Power>().HasData(
                new Power { Id = 1, Name ="Detective Skills", Description ="Exceptional deduction",HeroId = 1},
                new Power { Id = 2, Name = "Martials Arts", Description = "Hand-to-hand combat", HeroId = 1 },
                new Power { Id = 3, Name = "Spider Sense", Description = "Alerts to danger", HeroId = 2 },
                new Power { Id = 4, Name = "Web-Shooting", Description = "Spins spider webs", HeroId = 2 }
            );


        }
        public DbSet<Hero> Hero { get; set; }
        public DbSet<Power> Power { get; set; }
    }
}
