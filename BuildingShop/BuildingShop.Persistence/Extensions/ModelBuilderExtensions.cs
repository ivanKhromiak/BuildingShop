using BuildingShop.Domain.DomainObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.Text;
using BuildingShop.Domain;

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
