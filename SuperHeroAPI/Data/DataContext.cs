using Microsoft.EntityFrameworkCore;

namespace SuperHeroAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        // Because we use ...migration and we wanna see a representation of our super heroes in the database.
         
        public DbSet<SuperHero> SuperHeroes { get; set; } // in plural, "SuperHeroes" will be the name of our table.
    }
}
