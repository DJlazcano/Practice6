﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Practice5_DataAccess.Data;

#nullable disable

namespace Practice5_DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-rc.1.24451.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Practice5_Model.Models.Inventory", b =>
                {
                    b.Property<int>("Inventory_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Inventory_Id"));

                    b.Property<int>("Product_Id")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Inventory_Id");

                    b.HasIndex("Product_Id")
                        .IsUnique();

                    b.ToTable("Inventories");

                    b.HasData(
                        new
                        {
                            Inventory_Id = 1,
                            Product_Id = 1,
                            Stock = 100
                        },
                        new
                        {
                            Inventory_Id = 2,
                            Product_Id = 2,
                            Stock = 200
                        },
                        new
                        {
                            Inventory_Id = 3,
                            Product_Id = 3,
                            Stock = 30
                        },
                        new
                        {
                            Inventory_Id = 4,
                            Product_Id = 4,
                            Stock = 234
                        },
                        new
                        {
                            Inventory_Id = 5,
                            Product_Id = 5,
                            Stock = 531
                        },
                        new
                        {
                            Inventory_Id = 6,
                            Product_Id = 6,
                            Stock = 345
                        },
                        new
                        {
                            Inventory_Id = 7,
                            Product_Id = 7,
                            Stock = 322
                        },
                        new
                        {
                            Inventory_Id = 8,
                            Product_Id = 8,
                            Stock = 345
                        },
                        new
                        {
                            Inventory_Id = 9,
                            Product_Id = 9,
                            Stock = 232
                        });
                });

            modelBuilder.Entity("Practice5_Model.Models.Product", b =>
                {
                    b.Property<int>("Product_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Product_Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("int");

                    b.HasKey("Product_Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Product_Id = 1,
                            Description = "They are small but sweet",
                            Price = 15.0,
                            ProductName = "Lemon",
                            QuantityInStock = 100
                        },
                        new
                        {
                            Product_Id = 2,
                            Description = "Large and no seed",
                            Price = 32.5,
                            ProductName = "Mango",
                            QuantityInStock = 50
                        },
                        new
                        {
                            Product_Id = 3,
                            Description = "Some came damaged",
                            Price = 85.5,
                            ProductName = "Avocado",
                            QuantityInStock = 230
                        },
                        new
                        {
                            Product_Id = 4,
                            Description = "Very sweet and juicy",
                            Price = 12.4,
                            ProductName = "Orange",
                            QuantityInStock = 400
                        },
                        new
                        {
                            Product_Id = 5,
                            Description = "Not very good batch",
                            Price = 50.5,
                            ProductName = "Pineapple",
                            QuantityInStock = 20
                        },
                        new
                        {
                            Product_Id = 6,
                            Description = "Colorful and sweet",
                            Price = 25.699999999999999,
                            ProductName = "Cherry",
                            QuantityInStock = 600
                        },
                        new
                        {
                            Product_Id = 7,
                            Description = "Not many",
                            Price = 70.5,
                            ProductName = "Pomegranate",
                            QuantityInStock = 8
                        },
                        new
                        {
                            Product_Id = 8,
                            Description = "Very sweet and plenty of them",
                            Price = 36.299999999999997,
                            ProductName = "Blueberry",
                            QuantityInStock = 200
                        },
                        new
                        {
                            Product_Id = 9,
                            Description = "Large and no seed, also very sweet",
                            Price = 29.300000000000001,
                            ProductName = "Cantaloupe",
                            QuantityInStock = 36
                        },
                        new
                        {
                            Product_Id = 10,
                            Description = "Large and Full of water",
                            Price = 43.5,
                            ProductName = "Coconut",
                            QuantityInStock = 136
                        });
                });

            modelBuilder.Entity("Practice5_Model.Models.Purchase", b =>
                {
                    b.Property<int>("Purchase_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Purchase_Id"));

                    b.Property<int>("Product_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("PurchasePrice")
                        .HasColumnType("float");

                    b.Property<int>("QuantityPurchased")
                        .HasColumnType("int");

                    b.Property<double>("TotalCost")
                        .HasColumnType("float");

                    b.HasKey("Purchase_Id");

                    b.HasIndex("Product_Id");

                    b.ToTable("Purchases");

                    b.HasData(
                        new
                        {
                            Purchase_Id = 1,
                            Product_Id = 1,
                            PurchaseDate = new DateTime(2024, 9, 1, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            PurchasePrice = 10.699999999999999,
                            QuantityPurchased = 100,
                            TotalCost = 107.0
                        },
                        new
                        {
                            Purchase_Id = 2,
                            Product_Id = 3,
                            PurchaseDate = new DateTime(2024, 9, 17, 7, 14, 0, 0, DateTimeKind.Unspecified),
                            PurchasePrice = 40.5,
                            QuantityPurchased = 50,
                            TotalCost = 2025.0
                        },
                        new
                        {
                            Purchase_Id = 3,
                            Product_Id = 2,
                            PurchaseDate = new DateTime(2024, 9, 15, 5, 14, 0, 0, DateTimeKind.Unspecified),
                            PurchasePrice = 15.300000000000001,
                            QuantityPurchased = 50,
                            TotalCost = 765.0
                        },
                        new
                        {
                            Purchase_Id = 4,
                            Product_Id = 4,
                            PurchaseDate = new DateTime(2024, 9, 25, 10, 14, 0, 0, DateTimeKind.Unspecified),
                            PurchasePrice = 6.5,
                            QuantityPurchased = 200,
                            TotalCost = 1300.0
                        },
                        new
                        {
                            Purchase_Id = 5,
                            Product_Id = 5,
                            PurchaseDate = new DateTime(2024, 9, 1, 5, 25, 0, 0, DateTimeKind.Unspecified),
                            PurchasePrice = 25.0,
                            QuantityPurchased = 10,
                            TotalCost = 250.0
                        },
                        new
                        {
                            Purchase_Id = 6,
                            Product_Id = 6,
                            PurchaseDate = new DateTime(2024, 9, 30, 18, 56, 0, 0, DateTimeKind.Unspecified),
                            PurchasePrice = 12.699999999999999,
                            QuantityPurchased = 500,
                            TotalCost = 6350.0
                        },
                        new
                        {
                            Purchase_Id = 7,
                            Product_Id = 7,
                            PurchaseDate = new DateTime(2024, 9, 13, 8, 45, 0, 0, DateTimeKind.Unspecified),
                            PurchasePrice = 60.899999999999999,
                            QuantityPurchased = 8,
                            TotalCost = 487.89999999999998
                        },
                        new
                        {
                            Purchase_Id = 8,
                            Product_Id = 3,
                            PurchaseDate = new DateTime(2024, 9, 17, 7, 14, 0, 0, DateTimeKind.Unspecified),
                            PurchasePrice = 48.5,
                            QuantityPurchased = 200,
                            TotalCost = 9700.0
                        },
                        new
                        {
                            Purchase_Id = 9,
                            Product_Id = 1,
                            PurchaseDate = new DateTime(2024, 9, 6, 8, 36, 0, 0, DateTimeKind.Unspecified),
                            PurchasePrice = 27.199999999999999,
                            QuantityPurchased = 100,
                            TotalCost = 272.0
                        },
                        new
                        {
                            Purchase_Id = 10,
                            Product_Id = 8,
                            PurchaseDate = new DateTime(2024, 9, 30, 8, 56, 0, 0, DateTimeKind.Unspecified),
                            PurchasePrice = 24.399999999999999,
                            QuantityPurchased = 200,
                            TotalCost = 4880.0
                        });
                });

            modelBuilder.Entity("Practice5_Model.Models.Sale", b =>
                {
                    b.Property<int>("Sale_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Sale_Id"));

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Product_Id")
                        .HasColumnType("int");

                    b.Property<double>("QuantitySold")
                        .HasColumnType("float");

                    b.Property<DateTime>("SaleDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("SalePrice")
                        .HasColumnType("float");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.HasKey("Sale_Id");

                    b.HasIndex("Product_Id");

                    b.ToTable("Sales");

                    b.HasData(
                        new
                        {
                            Sale_Id = 1,
                            CustomerName = "John Smith",
                            Product_Id = 1,
                            QuantitySold = 20.0,
                            SaleDate = new DateTime(2024, 9, 16, 8, 23, 0, 0, DateTimeKind.Unspecified),
                            SalePrice = 15.0,
                            TotalAmount = 300.0
                        },
                        new
                        {
                            Sale_Id = 2,
                            CustomerName = "Juan Manuel",
                            Product_Id = 5,
                            QuantitySold = 2.0,
                            SaleDate = new DateTime(2024, 9, 20, 16, 23, 0, 0, DateTimeKind.Unspecified),
                            SalePrice = 50.5,
                            TotalAmount = 101.0
                        },
                        new
                        {
                            Sale_Id = 3,
                            CustomerName = "Dany Michel",
                            Product_Id = 10,
                            QuantitySold = 10.0,
                            SaleDate = new DateTime(2024, 9, 5, 9, 23, 0, 0, DateTimeKind.Unspecified),
                            SalePrice = 43.5,
                            TotalAmount = 435.0
                        },
                        new
                        {
                            Sale_Id = 4,
                            CustomerName = "Sofia",
                            Product_Id = 7,
                            QuantitySold = 1.0,
                            SaleDate = new DateTime(2024, 9, 5, 17, 23, 0, 0, DateTimeKind.Unspecified),
                            SalePrice = 70.5,
                            TotalAmount = 70.5
                        },
                        new
                        {
                            Sale_Id = 5,
                            CustomerName = "Lily",
                            Product_Id = 6,
                            QuantitySold = 40.0,
                            SaleDate = new DateTime(2024, 9, 10, 11, 11, 0, 0, DateTimeKind.Unspecified),
                            SalePrice = 25.699999999999999,
                            TotalAmount = 1028.0
                        },
                        new
                        {
                            Sale_Id = 6,
                            CustomerName = "Zac",
                            Product_Id = 6,
                            QuantitySold = 50.0,
                            SaleDate = new DateTime(2024, 9, 12, 18, 23, 0, 0, DateTimeKind.Unspecified),
                            SalePrice = 25.699999999999999,
                            TotalAmount = 1285.0
                        },
                        new
                        {
                            Sale_Id = 7,
                            CustomerName = "Jhonny",
                            Product_Id = 6,
                            QuantitySold = 20.0,
                            SaleDate = new DateTime(2024, 9, 15, 10, 23, 0, 0, DateTimeKind.Unspecified),
                            SalePrice = 25.699999999999999,
                            TotalAmount = 514.0
                        },
                        new
                        {
                            Sale_Id = 8,
                            CustomerName = "Harold",
                            Product_Id = 9,
                            QuantitySold = 62.0,
                            SaleDate = new DateTime(2024, 9, 23, 21, 34, 0, 0, DateTimeKind.Unspecified),
                            SalePrice = 36.299999999999997,
                            TotalAmount = 2250.5999999999999
                        },
                        new
                        {
                            Sale_Id = 9,
                            CustomerName = "Sebastian",
                            Product_Id = 4,
                            QuantitySold = 82.0,
                            SaleDate = new DateTime(2024, 9, 15, 20, 23, 0, 0, DateTimeKind.Unspecified),
                            SalePrice = 12.4,
                            TotalAmount = 1016.8
                        },
                        new
                        {
                            Sale_Id = 10,
                            CustomerName = "Alonso",
                            Product_Id = 4,
                            QuantitySold = 2.0,
                            SaleDate = new DateTime(2024, 9, 17, 7, 14, 0, 0, DateTimeKind.Unspecified),
                            SalePrice = 12.4,
                            TotalAmount = 24.800000000000001
                        });
                });

            modelBuilder.Entity("Practice5_Model.Models.Inventory", b =>
                {
                    b.HasOne("Practice5_Model.Models.Product", "Product")
                        .WithOne("Inventory")
                        .HasForeignKey("Practice5_Model.Models.Inventory", "Product_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Practice5_Model.Models.Purchase", b =>
                {
                    b.HasOne("Practice5_Model.Models.Product", "Product")
                        .WithMany("Purchases")
                        .HasForeignKey("Product_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Practice5_Model.Models.Sale", b =>
                {
                    b.HasOne("Practice5_Model.Models.Product", "Product")
                        .WithMany("Sales")
                        .HasForeignKey("Product_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Practice5_Model.Models.Product", b =>
                {
                    b.Navigation("Inventory")
                        .IsRequired();

                    b.Navigation("Purchases");

                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}
