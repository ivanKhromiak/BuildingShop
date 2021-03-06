﻿// <auto-generated />
using BuildingShop.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BuildingShop.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200526161027_AddСharacteristics")]
    partial class AddСharacteristics
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Name = "Ручні інструменту"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Електротовари"
                        });
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
                        });
                });

            modelBuilder.Entity("BuildingShop.Domain.DomainObjects.Product", b =>
                {
                    b.HasOne("BuildingShop.Domain.DomainObjects.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
