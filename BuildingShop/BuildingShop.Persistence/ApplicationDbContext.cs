using BuildingShop.Domain.DomainObjects;
using BuildingShop.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BuildingShop.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductAmountTracker> ProductAmountTrackers { get; set; }

        public DbSet<ShopCartItem> ShopCartItems { get; set; }

        public DbSet<Purchase> Purchases { get; set; }

        public DbSet<Delivery> Deliveries { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            builder.SeedData();
        }
    }
}
