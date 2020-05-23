using BuildingShop.Domain.DomainObjects;
using BuildingShop.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;

namespace BuildingShop.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.SeedData();
        }
    }
}
