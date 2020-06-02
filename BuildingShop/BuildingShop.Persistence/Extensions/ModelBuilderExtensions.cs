using BuildingShop.Domain.DomainObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using BuildingShop.Domain;

namespace BuildingShop.Persistence.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Ручні інструменти"},
                new Category() { Id = 2, Name = "Електротовари" },
                new Category() { Id = 3, Name = "Ліхтарі"}
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
                },
                new Product()
                {
                    Id = 3,
                    Name = "Ліхтар BRAVIS LL-92",
                    Amount = 28,
                    CategoryId = 3,
                    Price = 119m,
                    Сharacteristics = new Dictionary<string, string>()
                    {
                        ["Потужність"] = "3 Вт",
                        ["Кількість світлодіодів"] = "1",
                        ["Яскравість"] = "240 люмен",
                        ["Матеріал"] = "Сплав алюмінію"
                    }
                }
            );

            builder.Entity<ProductAmountTracker>().HasData(
                new ProductAmountTracker() { Id = 1, ProductId = 3, Date = new DateTime(2020, 5, 1), Amount = 25 },
                new ProductAmountTracker() { Id = 2, ProductId = 3, Date = new DateTime(2020, 5, 3), Amount = 15 },
                new ProductAmountTracker() { Id = 3, ProductId = 3, Date = new DateTime(2020, 5, 4), Amount = 9 },
                new ProductAmountTracker() { Id = 4, ProductId = 3, Date = new DateTime(2020, 5, 5), Amount = 5 },
                new ProductAmountTracker() { Id = 5, ProductId = 3, Date = new DateTime(2020, 5, 6), Amount = 0 },
                new ProductAmountTracker() { Id = 6, ProductId = 3, Date = new DateTime(2020, 5, 9), Amount = 30 },
                new ProductAmountTracker() { Id = 7, ProductId = 3, Date = new DateTime(2020, 5, 10), Amount = 28 }
            );

            builder.Entity<Delivery>().HasData(
                new Delivery() { Id = 100, ProductId = 3, Date = new DateTime(2020, 5, 9), Amount = 30}
            );

            builder.Entity<Purchase>().HasData(
                new Purchase() { Id = 100, ProductId = 3, Date = new DateTime(2020, 5, 4), Amount = 6 },
                new Purchase() { Id = 101, ProductId = 3, Date = new DateTime(2020, 5, 5), Amount = 4 },
                new Purchase() { Id = 102, ProductId = 3, Date = new DateTime(2020, 5, 6), Amount = 5 },
                new Purchase() { Id = 103, ProductId = 3, Date = new DateTime(2020, 5, 10), Amount = 2 }
            );
        }

        public static void SeedUserData(this ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "6206a4f1-7ca1-4928-89b4-5d2112074e56",
                    Name = "Manager",
                    NormalizedName = "Manager".ToUpper()
                }
            );

            var hasher = new PasswordHasher<User>();
            builder.Entity<User>().HasData(
                new User()
                {
                    Id = "1",
                    UserName = "Ivan",
                    NormalizedUserName = "Ivan".ToUpper(),
                    Email = "ivan@gmail.com",
                    NormalizedEmail = "ivan@nonce.fake".ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Ivan"),
                    SecurityStamp = string.Empty
                }
            );

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "6206a4f1-7ca1-4928-89b4-5d2112074e56",
                    UserId = "1"
                }
            );
        }
    }
}
