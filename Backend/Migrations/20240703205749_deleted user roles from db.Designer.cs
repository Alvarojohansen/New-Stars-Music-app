﻿// <auto-generated />
using System;
using Merchanmusic.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Merchanmusic.Migrations
{
    [DbContext(typeof(MerchContext))]
    [Migration("20240703205749_deleted user roles from db")]
    partial class deleteduserrolesfromdb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Merchanmusic.Data.Entities.CreditCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("CreditCards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Number = "1234567891234567",
                            UserId = "default-identifier-3845746332"
                        });
                });

            modelBuilder.Entity("Merchanmusic.Data.Entities.Products.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ArtistOrBand")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("DATETIME(0)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImageLink")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("DATETIME(0)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("DECIMAL(7,2)");

                    b.Property<int>("Sales")
                        .HasColumnType("int");

                    b.Property<string>("SellerId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("State")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SellerId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            ArtistOrBand = "ACDC",
                            Category = "T-shirt",
                            Code = "1022",
                            CreationDate = new DateTime(2024, 7, 3, 17, 57, 48, 940, DateTimeKind.Local).AddTicks(3265),
                            Description = "Remera ACDC algodón",
                            ImageLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Semi_dry_suit_-_2604.png/256px-Semi_dry_suit_-_2604.png?20180603115529",
                            LastModifiedDate = new DateTime(2024, 7, 3, 17, 57, 48, 940, DateTimeKind.Local).AddTicks(3279),
                            Name = "Remera ACDC",
                            Price = 12500.71m,
                            Sales = 237,
                            SellerId = "default-identifier-7771829382",
                            State = true,
                            Stock = 19
                        },
                        new
                        {
                            Id = 4,
                            ArtistOrBand = "Mozart",
                            Category = "T-shirt",
                            Code = "18az4",
                            CreationDate = new DateTime(2024, 7, 3, 17, 57, 48, 940, DateTimeKind.Local).AddTicks(3285),
                            Description = "Remera Mozart algodón",
                            ImageLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Semi_dry_suit_-_2604.png/256px-Semi_dry_suit_-_2604.png?20180603115529",
                            LastModifiedDate = new DateTime(2024, 7, 3, 17, 57, 48, 940, DateTimeKind.Local).AddTicks(3285),
                            Name = "Remera Mozart",
                            Price = 23763.34m,
                            Sales = 129,
                            SellerId = "default-identifier-7771829382",
                            State = true,
                            Stock = 24
                        },
                        new
                        {
                            Id = 5,
                            ArtistOrBand = "Beethoven",
                            Category = "T-shirt",
                            Code = "17zz89",
                            CreationDate = new DateTime(2024, 7, 3, 17, 57, 48, 940, DateTimeKind.Local).AddTicks(3288),
                            Description = "Remera Beethoven algodón",
                            ImageLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Semi_dry_suit_-_2604.png/256px-Semi_dry_suit_-_2604.png?20180603115529",
                            LastModifiedDate = new DateTime(2024, 7, 3, 17, 57, 48, 940, DateTimeKind.Local).AddTicks(3288),
                            Name = "Remera Beethoven",
                            Price = 12500.99m,
                            Sales = 83,
                            SellerId = "default-identifier-7771829382",
                            State = true,
                            Stock = 10
                        },
                        new
                        {
                            Id = 7,
                            ArtistOrBand = "LOVG",
                            Category = "T-shirt",
                            Code = "ax34d",
                            CreationDate = new DateTime(2024, 7, 3, 17, 57, 48, 940, DateTimeKind.Local).AddTicks(3290),
                            Description = "Remera overside negra",
                            ImageLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Semi_dry_suit_-_2604.png/256px-Semi_dry_suit_-_2604.png?20180603115529",
                            LastModifiedDate = new DateTime(2024, 7, 3, 17, 57, 48, 940, DateTimeKind.Local).AddTicks(3291),
                            Name = "Remera LOVG",
                            Price = 13200.11m,
                            Sales = 421,
                            SellerId = "default-identifier-7771829382",
                            State = true,
                            Stock = 15
                        });
                });

            modelBuilder.Entity("Merchanmusic.Data.Entities.SaleOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("Completed")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("OrderCode")
                        .HasColumnType("char(36)");

                    b.Property<bool>("State")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("SaleOrders");
                });

            modelBuilder.Entity("Merchanmusic.Data.Entities.SaleOrderLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("QuantityOrdered")
                        .HasColumnType("int");

                    b.Property<int>("SaleOrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("SaleOrderId");

                    b.ToTable("SaleOrderLines");
                });

            modelBuilder.Entity("Merchanmusic.Data.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("Apartment")
                        .HasColumnType("longtext");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext");

                    b.Property<string>("PostalCode")
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("State")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("WaitingValidation")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Role").HasValue("User");
                });

            modelBuilder.Entity("Merchanmusic.Data.Entities.Admin", b =>
                {
                    b.HasBaseType("Merchanmusic.Data.Entities.User");

                    b.HasDiscriminator().HasValue("Admin");

                    b.HasData(
                        new
                        {
                            Id = "default-identifier-0012827345",
                            Email = "bdiaz@gmail.com",
                            State = true,
                            WaitingValidation = false
                        });
                });

            modelBuilder.Entity("Merchanmusic.Data.Entities.Client", b =>
                {
                    b.HasBaseType("Merchanmusic.Data.Entities.User");

                    b.HasDiscriminator().HasValue("Client");

                    b.HasData(
                        new
                        {
                            Id = "default-identifier-3845746332",
                            Address = "Rivadavia 111",
                            Apartment = "8A",
                            City = "Rosario",
                            Country = "Argentina",
                            Email = "leomattsantana@gmail.com",
                            Phone = "+5493416271920",
                            PostalCode = "S2000",
                            State = true,
                            WaitingValidation = false
                        },
                        new
                        {
                            Id = "default-identifier-945711463132",
                            Address = "J.b.justo 111",
                            City = "Rosario",
                            Country = "Argentina",
                            Email = "santi@gmail.com",
                            Phone = "+5493413457612",
                            PostalCode = "S2000",
                            State = true,
                            WaitingValidation = false
                        },
                        new
                        {
                            Id = "default-identifier-73619823",
                            Address = "San Martin 111",
                            Apartment = "7B",
                            City = "Rosario",
                            Country = "Argentina",
                            Email = "jgarcia@gmail.com",
                            Phone = "+5493415678119",
                            PostalCode = "S2000",
                            State = true,
                            WaitingValidation = false
                        });
                });

            modelBuilder.Entity("Merchanmusic.Data.Entities.Seller", b =>
                {
                    b.HasBaseType("Merchanmusic.Data.Entities.User");

                    b.Property<string>("BankAccountNumber")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("Seller");

                    b.HasData(
                        new
                        {
                            Id = "default-identifier-7771829382",
                            Address = "San Martin 111",
                            City = "Rosario",
                            Country = "Argentina",
                            Email = "katyperry@gmail.com",
                            Phone = "+5493416781203",
                            PostalCode = "S2000",
                            State = true,
                            WaitingValidation = false,
                            BankAccountNumber = "378364817263174"
                        });
                });

            modelBuilder.Entity("Merchanmusic.Data.Entities.CreditCard", b =>
                {
                    b.HasOne("Merchanmusic.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Merchanmusic.Data.Entities.Products.Product", b =>
                {
                    b.HasOne("Merchanmusic.Data.Entities.Seller", "Seller")
                        .WithMany("Products")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("Merchanmusic.Data.Entities.SaleOrder", b =>
                {
                    b.HasOne("Merchanmusic.Data.Entities.Client", "Client")
                        .WithMany("SaleOrders")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Merchanmusic.Data.Entities.SaleOrderLine", b =>
                {
                    b.HasOne("Merchanmusic.Data.Entities.Products.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Merchanmusic.Data.Entities.SaleOrder", "SaleOrder")
                        .WithMany("SaleOrderLines")
                        .HasForeignKey("SaleOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("SaleOrder");
                });

            modelBuilder.Entity("Merchanmusic.Data.Entities.SaleOrder", b =>
                {
                    b.Navigation("SaleOrderLines");
                });

            modelBuilder.Entity("Merchanmusic.Data.Entities.Client", b =>
                {
                    b.Navigation("SaleOrders");
                });

            modelBuilder.Entity("Merchanmusic.Data.Entities.Seller", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
