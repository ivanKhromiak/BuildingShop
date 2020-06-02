﻿// <auto-generated />
using System;
using BuildingShop.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BuildingShop.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BuildingShop.Domain.DomainObjects.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ручні інструменти"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Електротовари"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Ліхтарі"
                        });
                });

            modelBuilder.Entity("BuildingShop.Domain.DomainObjects.Delivery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Deliveries");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            Amount = 30,
                            Date = new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 3
                        });
                });

            modelBuilder.Entity("BuildingShop.Domain.DomainObjects.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AverageSalesPerDay")
                        .HasColumnType("decimal(12, 4)");

                    b.Property<int>("DaysWithoutProduct")
                        .HasColumnType("int");

                    b.Property<int>("EndAmount")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FinalNumber")
                        .HasColumnType("int");

                    b.Property<int>("MinSalePerDay")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StarDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StartingAmount")
                        .HasColumnType("int");

                    b.Property<int>("TotalIncome")
                        .HasColumnType("int");

                    b.Property<int>("TotalOutcome")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BuildingShop.Domain.DomainObjects.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(12, 2)");

                    b.Property<string>("Сharacteristics")
                        .HasColumnType("nvarchar(4000)")
                        .HasMaxLength(4000);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 20,
                            CategoryId = 1,
                            Name = "Молоток",
                            Price = 50m,
                            Сharacteristics = "{\"Вага\":\"50 грам\",\"Матеріал\":\"Метал\",\"Призначення\":\"Слюсарний\"}"
                        },
                        new
                        {
                            Id = 2,
                            Amount = 40,
                            CategoryId = 2,
                            Name = "Діодна лампа",
                            Price = 25.99m,
                            Сharacteristics = "{\"Потужність\":\"10 Ватт\",\"Довжина\":\"40 см\",\"Цоколь\":\"E27\"}"
                        },
                        new
                        {
                            Id = 3,
                            Amount = 28,
                            CategoryId = 3,
                            Name = "Ліхтар BRAVIS LL-92",
                            Price = 119m,
                            Сharacteristics = "{\"Потужність\":\"3 Вт\",\"Кількість світлодіодів\":\"1\",\"Яскравість\":\"240 люмен\",\"Матеріал\":\"Сплав алюмінію\"}"
                        });
                });

            modelBuilder.Entity("BuildingShop.Domain.DomainObjects.ProductAmountTracker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductAmountTrackers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 25,
                            Date = new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 3
                        },
                        new
                        {
                            Id = 2,
                            Amount = 15,
                            Date = new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 3
                        },
                        new
                        {
                            Id = 3,
                            Amount = 9,
                            Date = new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 3
                        },
                        new
                        {
                            Id = 4,
                            Amount = 5,
                            Date = new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 3
                        },
                        new
                        {
                            Id = 5,
                            Amount = 0,
                            Date = new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 3
                        },
                        new
                        {
                            Id = 6,
                            Amount = 30,
                            Date = new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 3
                        },
                        new
                        {
                            Id = 7,
                            Amount = 28,
                            Date = new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 3
                        });
                });

            modelBuilder.Entity("BuildingShop.Domain.DomainObjects.Purchase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Purchases");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            Amount = 6,
                            Date = new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 3
                        },
                        new
                        {
                            Id = 101,
                            Amount = 4,
                            Date = new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 3
                        },
                        new
                        {
                            Id = 102,
                            Amount = 5,
                            Date = new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 3
                        },
                        new
                        {
                            Id = 103,
                            Amount = 2,
                            Date = new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 3
                        });
                });

            modelBuilder.Entity("BuildingShop.Domain.DomainObjects.ShopCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ShopCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ShopCartItems");
                });

            modelBuilder.Entity("BuildingShop.Domain.DomainObjects.Delivery", b =>
                {
                    b.HasOne("BuildingShop.Domain.DomainObjects.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BuildingShop.Domain.DomainObjects.Order", b =>
                {
                    b.HasOne("BuildingShop.Domain.DomainObjects.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BuildingShop.Domain.DomainObjects.Product", b =>
                {
                    b.HasOne("BuildingShop.Domain.DomainObjects.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BuildingShop.Domain.DomainObjects.ProductAmountTracker", b =>
                {
                    b.HasOne("BuildingShop.Domain.DomainObjects.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BuildingShop.Domain.DomainObjects.Purchase", b =>
                {
                    b.HasOne("BuildingShop.Domain.DomainObjects.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BuildingShop.Domain.DomainObjects.ShopCartItem", b =>
                {
                    b.HasOne("BuildingShop.Domain.DomainObjects.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
