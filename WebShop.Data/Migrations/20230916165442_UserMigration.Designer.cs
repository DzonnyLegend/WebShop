﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebShop.Data;

#nullable disable

namespace WebShop.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230916165442_UserMigration")]
    partial class UserMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = "fc1f27d7-7045-48ec-9dff-b66a9f3de573",
                            Name = "Member",
                            NormalizedName = "MEMBER"
                        },
                        new
                        {
                            Id = "eda9e78d-4abc-456e-a723-c163ef481ff2",
                            Name = "Seller",
                            NormalizedName = "SELLER"
                        },
                        new
                        {
                            Id = "d8313682-023a-49e6-8c2c-9a6b74a46f5f",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("WebShop.Data.Model.Basket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BuyerId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("WebShop.Data.Model.BasketItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BasketId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BasketId");

                    b.HasIndex("ProductId");

                    b.ToTable("BasketItems");
                });

            modelBuilder.Entity("WebShop.Data.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Angular",
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Angular Speedster Board 2000",
                            PictureUrl = "/images/products/sb-ang1.png",
                            Price = 20000L,
                            QuantityInStock = 100,
                            Type = "Boards"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Angular",
                            Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                            Name = "Green Angular Board 3000",
                            PictureUrl = "/images/products/sb-ang2.png",
                            Price = 15000L,
                            QuantityInStock = 100,
                            Type = "Boards"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "NetCore",
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            Name = "Core Board Speed Rush 3",
                            PictureUrl = "/images/products/sb-core1.png",
                            Price = 18000L,
                            QuantityInStock = 100,
                            Type = "Boards"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "NetCore",
                            Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                            Name = "Net Core Super Board",
                            PictureUrl = "/images/products/sb-core2.png",
                            Price = 30000L,
                            QuantityInStock = 100,
                            Type = "Boards"
                        },
                        new
                        {
                            Id = 5,
                            Brand = "React",
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "React Board Super Whizzy Fast",
                            PictureUrl = "/images/products/sb-react1.png",
                            Price = 25000L,
                            QuantityInStock = 100,
                            Type = "Boards"
                        },
                        new
                        {
                            Id = 6,
                            Brand = "TypeScript",
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Typescript Entry Board",
                            PictureUrl = "/images/products/sb-ts1.png",
                            Price = 12000L,
                            QuantityInStock = 100,
                            Type = "Boards"
                        },
                        new
                        {
                            Id = 7,
                            Brand = "NetCore",
                            Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Core Blue Hat",
                            PictureUrl = "/images/products/hat-core1.png",
                            Price = 1000L,
                            QuantityInStock = 100,
                            Type = "Hats"
                        },
                        new
                        {
                            Id = 8,
                            Brand = "React",
                            Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Green React Woolen Hat",
                            PictureUrl = "/images/products/hat-react1.png",
                            Price = 8000L,
                            QuantityInStock = 100,
                            Type = "Hats"
                        },
                        new
                        {
                            Id = 9,
                            Brand = "React",
                            Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Purple React Woolen Hat",
                            PictureUrl = "/images/products/hat-react2.png",
                            Price = 1500L,
                            QuantityInStock = 100,
                            Type = "Hats"
                        },
                        new
                        {
                            Id = 10,
                            Brand = "VS Code",
                            Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Blue Code Gloves",
                            PictureUrl = "/images/products/glove-code1.png",
                            Price = 1800L,
                            QuantityInStock = 100,
                            Type = "Gloves"
                        },
                        new
                        {
                            Id = 11,
                            Brand = "VS Code",
                            Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Green Code Gloves",
                            PictureUrl = "/images/products/glove-code2.png",
                            Price = 1500L,
                            QuantityInStock = 100,
                            Type = "Gloves"
                        },
                        new
                        {
                            Id = 12,
                            Brand = "React",
                            Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Purple React Gloves",
                            PictureUrl = "/images/products/glove-react1.png",
                            Price = 1600L,
                            QuantityInStock = 100,
                            Type = "Gloves"
                        },
                        new
                        {
                            Id = 13,
                            Brand = "React",
                            Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Green React Gloves",
                            PictureUrl = "/images/products/glove-react2.png",
                            Price = 1400L,
                            QuantityInStock = 100,
                            Type = "Gloves"
                        },
                        new
                        {
                            Id = 14,
                            Brand = "Redis",
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            Name = "Redis Red Boots",
                            PictureUrl = "/images/products/boot-redis1.png",
                            Price = 25000L,
                            QuantityInStock = 100,
                            Type = "Boots"
                        },
                        new
                        {
                            Id = 15,
                            Brand = "NetCore",
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Core Red Boots",
                            PictureUrl = "/images/products/boot-core2.png",
                            Price = 18999L,
                            QuantityInStock = 100,
                            Type = "Boots"
                        },
                        new
                        {
                            Id = 16,
                            Brand = "NetCore",
                            Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                            Name = "Core Purple Boots",
                            PictureUrl = "/images/products/boot-core1.png",
                            Price = 19999L,
                            QuantityInStock = 100,
                            Type = "Boots"
                        },
                        new
                        {
                            Id = 17,
                            Brand = "Angular",
                            Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                            Name = "Angular Purple Boots",
                            PictureUrl = "/images/products/boot-ang2.png",
                            Price = 15000L,
                            QuantityInStock = 100,
                            Type = "Boots"
                        },
                        new
                        {
                            Id = 18,
                            Brand = "Angular",
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            Name = "Angular Blue Boots",
                            PictureUrl = "/images/products/boot-ang1.png",
                            Price = 18000L,
                            QuantityInStock = 100,
                            Type = "Boots"
                        });
                });

            modelBuilder.Entity("WebShop.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WebShop.Model.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebShop.Data.Model.BasketItem", b =>
                {
                    b.HasOne("WebShop.Data.Model.Basket", "Basket")
                        .WithMany("Items")
                        .HasForeignKey("BasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebShop.Data.Model.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Basket");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebShop.Data.Model.Basket", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
