using BuildingShop.Domain.DomainObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingShop.Persistence.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Instruments"},
                new Category() { Id = 2, Name = "Light bulbs" }
                );

            builder.Entity<Product>().HasData(
                new Product() { Id = 1, Name = "Hammer", Amount = 20, CategoryId = 1, Price = 50m },
                new Product() { Id = 2, Name = "Diode lamp", Amount = 40, CategoryId = 2, Price = 25.99m }
                );
        }
    }
}
