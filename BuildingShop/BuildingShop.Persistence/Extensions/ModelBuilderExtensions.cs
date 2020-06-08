using BuildingShop.Domain;
using BuildingShop.Domain.DomainObjects;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace BuildingShop.Persistence.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Сухі суміші" },
                new Category() { Id = 2, Name = "Грунтовки" },
                new Category() { Id = 3, Name = "Фарби" },
                new Category() { Id = 4, Name = "Блоки будівельні"}
                );

            builder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Name = "Цемент IFCEM ПЦ II/БК-400 25 кг",
                    Amount = 40,
                    Image = "https://cdn.27.ua/799/7b/62/1276770_2.jpeg",
                    CategoryId = 1,
                    Price = 76.20m,
                    Сharacteristics = new Dictionary<string, string>()
                    {
                        ["Бренд"] = "IFCEM",
                        ["Вага"] = "25 кг",
                        ["Тип"] = "шлакопортландцемент",
                        ["Марка"] = "М-400",
                        ["Країна-виробник"] = "Україна"
                    }
                },
                new Product()
                {
                    Id = 2,
                    Name = "Цемент Dyckerhoff ПЦ II/А-Ш 500 25 кг",
                    Amount = 50,
                    Image = "https://cdn.27.ua/799/fd/48/326984_1.jpeg",
                    CategoryId = 1,
                    Price = 85m,
                    Сharacteristics = new Dictionary<string, string>()
                    {
                        ["Бренд"] = "Dyckerhoff",
                        ["Вага"] = "25 кг",
                        ["Тип"] = "портландцемент",
                        ["Марка"] = "М-500",
                        ["Країна-виробник"] = "Україна"
                    }
                },
                new Product()
                {
                    Id = 3,
                    Name = "Цемент ПЦII/БК 400 25 кг",
                    Amount = 35,
                    Image = "https://cdn.27.ua/799/fd/3b/326971_2.jpeg",
                    CategoryId = 1,
                    Price = 71m,
                    Сharacteristics = new Dictionary<string, string>()
                    {
                        ["Вага"] = "25 кг",
                        ["Тип"] = "портландцемент",
                        ["Марка"] = "М-400",
                        ["Країна-виробник"] = "Україна"
                    }
                },
                new Product()
                {
                    Id = 4,
                    Name = "Цемент білий OYAK 25 кг",
                    Amount = 33,
                    Image = "https://cdn.27.ua/799/b8/f0/1292528_2.jpeg",
                    CategoryId = 1,
                    Price = 215m,
                    Сharacteristics = new Dictionary<string, string>()
                    {
                        ["Бренд"] = "OYAK",
                        ["Вага"] = "25 кг",
                        ["Тип"] = "білий",
                        ["Марка"] = "М-600",
                        ["Країна-виробник"] = "Туреччина"
                    }
                },
                new Product()
                {
                    Id = 5,
                    Name = "Ґрунт Farbex 1:4 глибокого проникнення SuperBase 1 л",
                    Amount = 23,
                    Image = "https://cdn.27.ua/799/65/c4/550340_1.jpeg",
                    CategoryId = 2,
                    Price = 53.64m,
                    Сharacteristics = new Dictionary<string, string>()
                    {
                        ["Бренд"] = "Farbex",
                        ["Країна-виробник"] = "Україна"
                    }
                },
                new Product()
                {
                    Id = 6,
                    Name = "Ґрунтовка фунгіцидна TR-25 bio 1 л",
                    Amount = 46,
                    Image = "https://cdn.27.ua/799/47/bb/411579_4.jpeg",
                    CategoryId = 2,
                    Price = 50.28m,
                    Сharacteristics = new Dictionary<string, string>()
                    {
                        ["Бренд"] = "Triora",
                        ["Тип"] = "фунгіцидна",
                        ["Колір"] = "прозорий",
                        ["Основа"] = "акрилова",
                        ["Країна-виробник"] = "Україна"
                    }
                },
                new Product()
                {
                    Id = 7,
                    Name = "Ґрунтовка глибокопроникна Farbex силіконова 2 л",
                    Amount = 21,
                    Image = "https://cdn.27.ua/799/2c/dd/1125597_1.jpeg",
                    CategoryId = 2,
                    Price = 99.60m,
                    Сharacteristics = new Dictionary<string, string>()
                    {
                        ["Бренд"] = "Farbex",
                        ["Призначення"] = "для внутрішніх робіт",
                        ["Основа"] = "силікон",
                        ["Колір"] = "прозорий",
                        ["Країна-виробник"] = "Україна"
                    }
                },
                new Product()
                {
                    Id = 8,
                    Name = "Ґрунтовка водовідштовхувальна Eskaro Aquastop Facade концентрат 1:10 1 л",
                    Amount = 20,
                    Image = "https://cdn.27.ua/799/cb/ce/314318_1.jpeg",
                    CategoryId = 2,
                    Price = 183.20m,
                    Сharacteristics = new Dictionary<string, string>()
                    {
                        ["Бренд"] = "Eskaro",
                        ["Основа"] = "акрилова",
                        ["Тип"] = "водовідштовхувальна",
                        ["Колір"] = "білий",
                        ["Країна-виробник"] = "Україна"
                    }
                },
                new Product()
                {
                    Id = 9,
                    Name = "Фарба Dufa Wandfarbe D1a білий 10 л 14 кг",
                    Amount = 30,
                    Image = "https://cdn.27.ua/799/4c/32/543794_3.jpeg",
                    CategoryId = 3,
                    Price = 305.50m,
                    Сharacteristics = new Dictionary<string, string>()
                    {
                        ["Бренд"] = "Dufa",
                        ["Призначення"] = "штукатурка, ДСП, ДВП, МДФ, цегла, шпалери, гіпсокартон",
                        ["Тип"] = "акрилова, водоемульсійна",
                        ["Відтінок"] = "білий",
                        ["Країна-виробник"] = "Україна"
                    }
                },
                new Product()
                {
                    Id = 10,
                    Name = "Фарба Sniezka Ultra Biel білий 10 л 14 кг",
                    Amount = 32,
                    Image = "https://cdn.27.ua/799/68/49/26697_3.jpeg",
                    CategoryId = 3,
                    Price = 262.70m,
                    Сharacteristics = new Dictionary<string, string>()
                    {
                        ["Бренд"] = "Sniezka",
                        ["Призначення"] = "для стін, для стелі",
                        ["Тип"] = "акрилова, водоемульсійна",
                        ["Відтінок"] = "білий",
                        ["Країна-виробник"] = "Україна"
                    }
                },
                new Product()
                {
                    Id = 11,
                    Name = "Фарба Dufa Mattlatex D100 білий 10 л 14 кг",
                    Amount = 50,
                    Image = "https://cdn.27.ua/799/f8/0c/522252_3.jpeg",
                    CategoryId = 3,
                    Price = 617.60m,
                    Сharacteristics = new Dictionary<string, string>()
                    {
                        ["Бренд"] = "Dufa",
                        ["Призначення"] = "для стін, для стелі",
                        ["Тип"] = "латексна, водоемульсійна",
                        ["Відтінок"] = "білий",
                        ["Країна-виробник"] = "Україна"
                    }
                },
                new Product()
                {
                    Id = 12,
                    Name = "Фарба Triora TR-33 matt білий 10 л",
                    Amount = 60,
                    Image = "https://cdn.27.ua/799/47/9b/411547_4.jpeg",
                    CategoryId = 3,
                    Price = 910.50m,
                    Сharacteristics = new Dictionary<string, string>()
                    {
                        ["Бренд"] = "Triora",
                        ["Призначення"] = "для стін, для стелі",
                        ["Тип"] = "латексна, водоемульсійна",
                        ["Відтінок"] = "білий",
                        ["Країна-виробник"] = "Україна"
                    }
                },
                new Product()
                {
                    Id = 13,
                    Name = "Газобетонний блок BauGut 600x200x300 мм D-500",
                    Amount = 52,
                    Image = "https://cdn.27.ua/799/d6/34/1168948_2.jpeg",
                    CategoryId = 4,
                    Price = 61.30m,
                    Сharacteristics = new Dictionary<string, string>()
                    {
                        ["Бренд"] = "BauGut",
                        ["Призначення"] = "стіновий",
                        ["Марка міцності"] = "D-500",
                        ["Морозостійкість"] = "F-35",
                        ["Країна-виробник"] = "Україна"
                    }
                },
                new Product()
                {
                    Id = 14,
                    Name = "Блок бетонний Фратеко 500х200х200 мм",
                    Amount = 100,
                    Image = "https://cdn.27.ua/799/7c/c7/31943_2.jpeg",
                    CategoryId = 4,
                    Price = 25.50m,
                    Сharacteristics = new Dictionary<string, string>()
                    {
                        ["Бренд"] = "Фратеко",
                        ["Водопоглинання"] = "9%",
                        ["Пустотність"] = "30%",
                        ["Морозостійкість"] = "50",
                        ["Країна-виробник"] = "Україна"
                    }
                },
                new Product()
                {
                    Id = 15,
                    Name = "Блок бетонний М-50",
                    Amount = 115,
                    Image = "https://cdn.27.ua/799/87/d3/1279955_2.jpeg",
                    CategoryId = 4,
                    Price = 30m,
                    Сharacteristics = new Dictionary<string, string>()
                    {
                        ["Вид"] = "блок бетонний",
                        ["Призначення"] = "стіновий",
                        ["Торцева грань"] = "гладка",
                        ["Країна виробник"] = "Україна",
                        ["Вага"] = "11,5 кг"
                    }
                },
                new Product()
                {
                    Id = 16,
                    Name = "Блок керамічний ЗБК 45",
                    Amount = 75,
                    Image = "https://cdn.27.ua/799/87/f4/1279988_2.jpeg",
                    CategoryId = 4,
                    Price = 48m,
                    Сharacteristics = new Dictionary<string, string>()
                    {
                        ["Бренд"] = "3БК",
                        ["Призначення"] = "стіновий",
                        ["Вид"] = "блок керамічний 35",
                        ["Торцева грань"] = "паз-гребінь",
                        ["Країна-виробник"] = "Україна"
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
                new Delivery() { Id = 100, ProductId = 3, Date = new DateTime(2020, 5, 9), Amount = 30 }
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
