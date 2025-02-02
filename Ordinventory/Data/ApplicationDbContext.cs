using Microsoft.EntityFrameworkCore;
using Ordinventory.Models;

namespace Ordinventory.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Beverages", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Condiments", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Confections", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Dairy Products", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Grains/Cereals", DisplayOrder = 5 },
                new Category { Id = 6, Name = "Meat/Poultry", DisplayOrder = 6 },
                new Category { Id = 7, Name = "Produce", DisplayOrder = 7 },
                new Category { Id = 8, Name = "Seafood", DisplayOrder = 8 }
            );
        }
    }
}