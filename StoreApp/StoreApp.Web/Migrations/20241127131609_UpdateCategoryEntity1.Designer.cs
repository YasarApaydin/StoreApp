﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreApp.Data.Concreate;

#nullable disable

namespace StoreApp.Web.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    [Migration("20241127131609_UpdateCategoryEntity1")]
    partial class UpdateCategoryEntity1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("StoreApp.Data.Concreate.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Url")
                        .IsUnique();

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Telefon",
                            Url = "telefon"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bilgisayar",
                            Url = "Bilgisayar"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Beyaz Eşya",
                            Url = "beyaz-esya"
                        });
                });

            modelBuilder.Entity("StoreApp.Data.Concreate.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "normal telefon",
                            Name = "Samsung Electra 2022",
                            Price = 30000m
                        },
                        new
                        {
                            Id = 2,
                            Description = "normal telefon",
                            Name = "Samsung S53 ",
                            Price = 10000m
                        },
                        new
                        {
                            Id = 3,
                            Description = "normal telefon",
                            Name = "Samsung A52",
                            Price = 15000m
                        },
                        new
                        {
                            Id = 4,
                            Description = "normal telefon",
                            Name = "Samsung Galaxy M20",
                            Price = 5000m
                        },
                        new
                        {
                            Id = 5,
                            Description = "normal bilgisayar",
                            Name = "Monster",
                            Price = 70000m
                        },
                        new
                        {
                            Id = 6,
                            Description = "normal bilgisayar",
                            Name = "Lenovo",
                            Price = 60000m
                        },
                        new
                        {
                            Id = 7,
                            Description = "normal telefon",
                            Name = "IPhome A10",
                            Price = 120000m
                        },
                        new
                        {
                            Id = 8,
                            Description = "normal telefon",
                            Name = "IPhome S20",
                            Price = 14000m
                        },
                        new
                        {
                            Id = 9,
                            Description = "güzel telefon",
                            Name = "IPhome S21",
                            Price = 14000m
                        },
                        new
                        {
                            Id = 10,
                            Description = "orta telefon",
                            Name = "IPhome S22",
                            Price = 14000m
                        },
                        new
                        {
                            Id = 11,
                            Description = "muhteşem telefon",
                            Name = "IPhome S23",
                            Price = 14000m
                        },
                        new
                        {
                            Id = 12,
                            Description = "orta makine",
                            Name = "Camaşır Makinası",
                            Price = 30000m
                        });
                });

            modelBuilder.Entity("StoreApp.Data.Concreate.ProductCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoryId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCategory");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 2
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 3
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 4
                        },
                        new
                        {
                            CategoryId = 2,
                            ProductId = 5
                        },
                        new
                        {
                            CategoryId = 2,
                            ProductId = 6
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 7
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 8
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 9
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 10
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 11
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 12
                        });
                });

            modelBuilder.Entity("StoreApp.Data.Concreate.ProductCategory", b =>
                {
                    b.HasOne("StoreApp.Data.Concreate.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StoreApp.Data.Concreate.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}