﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WardrobeT.Data;

namespace WardrobeT.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Wardrobe.Data.TypeOfWear", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("CanBeUsedAlone")
                        .HasColumnType("bit");

                    b.Property<int>("Cover")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Official")
                        .HasColumnType("bit");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypesOfWears");

                    b.HasData(
                        new
                        {
                            Id = "2aa524c7-782b-45be-b8ea-a9169c333d20",
                            CanBeUsedAlone = false,
                            Cover = 0,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = false,
                            Type = "Tracksuit top"
                        },
                        new
                        {
                            Id = "1940ce19-ded8-4406-8036-165114bc4a48",
                            CanBeUsedAlone = false,
                            Cover = 2,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = false,
                            Type = "Tracksuit bottoms"
                        },
                        new
                        {
                            Id = "f9c677cd-0d1d-4a17-a15c-060fd31b1733",
                            CanBeUsedAlone = true,
                            Cover = 2,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = true,
                            Type = "Official dress"
                        },
                        new
                        {
                            Id = "3308e49c-3cd2-4c7b-b108-63234fe67671",
                            CanBeUsedAlone = true,
                            Cover = 2,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = false,
                            Type = "Dress"
                        },
                        new
                        {
                            Id = "519464ba-f9f1-4f93-8c5f-fe80e25d8c2f",
                            CanBeUsedAlone = false,
                            Cover = 0,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = true,
                            Type = "Official jacket"
                        },
                        new
                        {
                            Id = "93fd55df-f153-48e5-b32c-cb4c9a90cd31",
                            CanBeUsedAlone = false,
                            Cover = 0,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = false,
                            Type = "Jacket"
                        },
                        new
                        {
                            Id = "1a41d1f9-95bd-4c36-825a-de72d40aac8e",
                            CanBeUsedAlone = false,
                            Cover = 0,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = true,
                            Type = "Official knit Shirt"
                        },
                        new
                        {
                            Id = "faea699d-3464-4803-94e0-247eac7ac9c8",
                            CanBeUsedAlone = false,
                            Cover = 0,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = false,
                            Type = "Knit Shirt"
                        },
                        new
                        {
                            Id = "0cc13490-e096-444c-b479-c2429b0017dd",
                            CanBeUsedAlone = false,
                            Cover = 0,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = true,
                            Type = "Official sirt"
                        },
                        new
                        {
                            Id = "831a121c-6a40-48e3-bb76-5ea2e6dc6f0d",
                            CanBeUsedAlone = false,
                            Cover = 0,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = false,
                            Type = "Shirt"
                        },
                        new
                        {
                            Id = "5846370e-ab1e-4fd5-ab94-580097ddd83b",
                            CanBeUsedAlone = true,
                            Cover = 0,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = true,
                            Type = "Suit"
                        },
                        new
                        {
                            Id = "ec6a9f1d-c075-4814-bb1b-8455f57e6861",
                            CanBeUsedAlone = false,
                            Cover = 0,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = true,
                            Type = "Official blouse"
                        },
                        new
                        {
                            Id = "0301b32a-3b2c-438c-806c-d81f5172d74f",
                            CanBeUsedAlone = false,
                            Cover = 0,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = false,
                            Type = "Blouse"
                        },
                        new
                        {
                            Id = "881a7f9e-6e40-4a82-87fa-99c8d9e68a84",
                            CanBeUsedAlone = false,
                            Cover = 2,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = false,
                            Type = "Sport Shirt"
                        },
                        new
                        {
                            Id = "98388473-2d1a-42d3-a7d4-9cf7652d4c27",
                            CanBeUsedAlone = false,
                            Cover = 2,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = true,
                            Type = "Official skirt"
                        },
                        new
                        {
                            Id = "c629865e-c8eb-4d15-ad54-2357f3cf388b",
                            CanBeUsedAlone = false,
                            Cover = 2,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = false,
                            Type = "Skirt"
                        },
                        new
                        {
                            Id = "320fe846-abbc-4c72-8ba5-1fe90ca39e27",
                            CanBeUsedAlone = false,
                            Cover = 0,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = true,
                            Type = "Official blazer"
                        },
                        new
                        {
                            Id = "f69fd264-d10f-4f69-b467-4fa50efedeb1",
                            CanBeUsedAlone = false,
                            Cover = 0,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = false,
                            Type = "Blazer"
                        },
                        new
                        {
                            Id = "18b0ae6c-3db7-4827-a13a-d2f0812d40f9",
                            CanBeUsedAlone = false,
                            Cover = 2,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = true,
                            Type = "Official jeans"
                        },
                        new
                        {
                            Id = "44e33f50-2f20-4fb4-b952-0e2b57bde732",
                            CanBeUsedAlone = false,
                            Cover = 2,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = false,
                            Type = "Jeans"
                        },
                        new
                        {
                            Id = "0786ca92-8280-4df8-8d4a-1b71724a1c93",
                            CanBeUsedAlone = false,
                            Cover = 0,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = true,
                            Type = "Official tunic"
                        },
                        new
                        {
                            Id = "c018474b-568d-4fc7-8e90-ac3b4e32adcc",
                            CanBeUsedAlone = false,
                            Cover = 0,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = false,
                            Type = "Tunic"
                        },
                        new
                        {
                            Id = "06a80586-586f-47b4-ba99-1badc289a72e",
                            CanBeUsedAlone = false,
                            Cover = 0,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = true,
                            Type = "Official vest"
                        },
                        new
                        {
                            Id = "6f2424bd-01f0-4702-866f-76e479ec06b8",
                            CanBeUsedAlone = false,
                            Cover = 0,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = false,
                            Type = "Vest"
                        },
                        new
                        {
                            Id = "171f13d4-71f8-44dd-bdef-f8332feb35e7",
                            CanBeUsedAlone = false,
                            Cover = 2,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = true,
                            Type = "Official short"
                        },
                        new
                        {
                            Id = "7217fef8-7ff5-4b42-99fa-d48834e45dc3",
                            CanBeUsedAlone = false,
                            Cover = 2,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = false,
                            Type = "Short"
                        },
                        new
                        {
                            Id = "7fcb73fa-cc54-40c9-804c-d0057774574f",
                            CanBeUsedAlone = false,
                            Cover = 0,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = true,
                            Type = "Coat"
                        },
                        new
                        {
                            Id = "56b6c51e-f07e-4cb8-a420-54abf7c454ef",
                            CanBeUsedAlone = false,
                            Cover = 2,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = true,
                            Type = "Official slacks"
                        },
                        new
                        {
                            Id = "f006c4fd-568a-4027-8610-7275fa119094",
                            CanBeUsedAlone = false,
                            Cover = 2,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = false,
                            Type = "Slacks"
                        },
                        new
                        {
                            Id = "b71133d2-b2e2-4d2e-be73-131e73c1e9e1",
                            CanBeUsedAlone = false,
                            Cover = 2,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = false,
                            Type = "Leggins"
                        },
                        new
                        {
                            Id = "b911507e-d071-451d-876f-fd921a3728ea",
                            CanBeUsedAlone = false,
                            Cover = 0,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = true,
                            Type = "Official turtleneck"
                        },
                        new
                        {
                            Id = "ff309a88-cc7c-4f4c-9899-040a616d96ea",
                            CanBeUsedAlone = false,
                            Cover = 0,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = false,
                            Type = "Turtleneck"
                        },
                        new
                        {
                            Id = "3b28e153-ccfa-4165-9426-ee974e22c20a",
                            CanBeUsedAlone = false,
                            Cover = 1,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = true,
                            Type = "Official T-Shirt"
                        },
                        new
                        {
                            Id = "c5034047-62b6-4a81-b517-da8df1fd4334",
                            CanBeUsedAlone = false,
                            Cover = 1,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Official = false,
                            Type = "T-Shirt"
                        });
                });

            modelBuilder.Entity("WardrobeT.Data.Models.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("WardrobeT.Data.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("WardrobeT.Data.Models.Followers", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("FollowedId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("FollowedId");

                    b.HasIndex("UserId");

                    b.ToTable("Followers");
                });

            modelBuilder.Entity("WardrobeT.Data.Models.Outfit", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BottomId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("MiddleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("TopId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("BottomId");

                    b.HasIndex("MiddleId");

                    b.HasIndex("TopId");

                    b.ToTable("Outfits");
                });

            modelBuilder.Entity("WardrobeT.Data.Models.OutfitPost", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("OutfitId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("OutfitId");

                    b.ToTable("OutfitPosts");
                });

            modelBuilder.Entity("WardrobeT.Data.Models.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("WardrobeT.Data.Models.Wear", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Color")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Season")
                        .HasColumnType("int");

                    b.Property<string>("TypeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("TypeId");

                    b.ToTable("Wears");
                });

            modelBuilder.Entity("WardrobeT.Services.Data.WearPost", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("WearId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("WearId");

                    b.ToTable("WearPosts");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("WardrobeT.Data.Models.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("WardrobeT.Data.Models.ApplicationUser", null)
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WardrobeT.Data.Models.ApplicationUser", null)
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("WardrobeT.Data.Models.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WardrobeT.Data.Models.ApplicationUser", null)
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("WardrobeT.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("WardrobeT.Data.Models.Followers", b =>
                {
                    b.HasOne("WardrobeT.Data.Models.ApplicationUser", "Followed")
                        .WithMany()
                        .HasForeignKey("FollowedId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WardrobeT.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("WardrobeT.Data.Models.Outfit", b =>
                {
                    b.HasOne("WardrobeT.Data.Models.Wear", "Bottom")
                        .WithMany()
                        .HasForeignKey("BottomId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WardrobeT.Data.Models.Wear", "Middle")
                        .WithMany()
                        .HasForeignKey("MiddleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WardrobeT.Data.Models.Wear", "Top")
                        .WithMany()
                        .HasForeignKey("TopId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("WardrobeT.Data.Models.OutfitPost", b =>
                {
                    b.HasOne("WardrobeT.Data.Models.Outfit", "Outfit")
                        .WithMany()
                        .HasForeignKey("OutfitId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("WardrobeT.Data.Models.Wear", b =>
                {
                    b.HasOne("WardrobeT.Data.Models.ApplicationUser", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Wardrobe.Data.TypeOfWear", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("WardrobeT.Services.Data.WearPost", b =>
                {
                    b.HasOne("WardrobeT.Data.Models.Wear", "Wear")
                        .WithMany()
                        .HasForeignKey("WearId");
                });
#pragma warning restore 612, 618
        }
    }
}
