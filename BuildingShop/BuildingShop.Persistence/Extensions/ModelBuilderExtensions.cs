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
                new Category() { Id = 1, Name = "Ручні інструменту"},
                new Category() { Id = 2, Name = "Електротовари" }
                );

            builder.Entity<Product>().HasData(
                new Product() { 
                    Id = 1, 
                    Name = "Молоток", 
                    Amount = 20, 
                    CategoryId = 1, 
                    Price = 50m,
                    Сharacteristics = new Dictionary<string, string>() 
                    {
                        ["Вага"] = "50 грам",
                        ["Матеріал"] = "Метал",
                        ["Призначення"] = "Слюсарний"
                    }
                },
                new Product() { 
                    Id = 2, 
                    Name = "Діодна лампа", 
                    Amount = 40, 
                    CategoryId = 2, 
                    Price = 25.99m,
                    Сharacteristics = new Dictionary<string, string>()
                    {
                        ["Потужність"] = "10 Ватт",
                        ["Довжина"] = "40 см",
                        ["Цоколь"] = "E27"
                    }
                }
                );
        }
    }
}
