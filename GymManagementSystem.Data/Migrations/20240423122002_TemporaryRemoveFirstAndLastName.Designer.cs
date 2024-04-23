﻿// <auto-generated />
using System;
using GymManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GymManagementSystem.Data.Migrations
{
    [DbContext(typeof(GymManagementDbContext))]
    [Migration("20240423122002_TemporaryRemoveFirstAndLastName")]
    partial class TemporaryRemoveFirstAndLastName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GymManagementSystem.Data.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("GymManagementSystem.Data.Models.AttendanceRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CheckInDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CheckOutDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("HasLeft")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AttendanceRecords");
                });

            modelBuilder.Entity("GymManagementSystem.Data.Models.GymEquipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Availability")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("LastMaintenanceDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("GymEquipment");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Availability = 0,
                            Description = "A weight training equipment used for squats.",
                            LastMaintenanceDate = new DateTime(2024, 4, 23, 12, 20, 2, 197, DateTimeKind.Utc).AddTicks(3005),
                            Name = "Squat Rack"
                        },
                        new
                        {
                            Id = 2,
                            Availability = 0,
                            Description = "A piece of weight training equipment used for various exercises including bench presses.",
                            LastMaintenanceDate = new DateTime(2024, 4, 23, 12, 20, 2, 197, DateTimeKind.Utc).AddTicks(3013),
                            Name = "Weight Bench"
                        },
                        new
                        {
                            Id = 3,
                            Availability = 0,
                            Description = "A machine used for the lat pulldown exercise targeting the upper back muscles.",
                            LastMaintenanceDate = new DateTime(2024, 4, 23, 12, 20, 2, 197, DateTimeKind.Utc).AddTicks(3015),
                            Name = "Lat Pulldown Machine"
                        },
                        new
                        {
                            Id = 4,
                            Availability = 0,
                            Description = "A machine used for the chest press exercise targeting the chest muscles.",
                            LastMaintenanceDate = new DateTime(2024, 4, 23, 12, 20, 2, 197, DateTimeKind.Utc).AddTicks(3017),
                            Name = "Chest Press Machine"
                        },
                        new
                        {
                            Id = 5,
                            Availability = 0,
                            Description = "A machine used for the chest fly exercise targeting the chest muscles.",
                            LastMaintenanceDate = new DateTime(2024, 4, 23, 12, 20, 2, 197, DateTimeKind.Utc).AddTicks(3019),
                            Name = "Chest Fly Machine"
                        },
                        new
                        {
                            Id = 6,
                            Availability = 0,
                            Description = "A machine used for the shoulder press exercise targeting the shoulder muscles.",
                            LastMaintenanceDate = new DateTime(2024, 4, 23, 12, 20, 2, 197, DateTimeKind.Utc).AddTicks(3023),
                            Name = "Shoulder Press Machine"
                        },
                        new
                        {
                            Id = 7,
                            Availability = 0,
                            Description = "A machine used for the cable row exercise targeting the back muscles.",
                            LastMaintenanceDate = new DateTime(2024, 4, 23, 12, 20, 2, 197, DateTimeKind.Utc).AddTicks(3025),
                            Name = "Cable Row Machine"
                        },
                        new
                        {
                            Id = 8,
                            Availability = 0,
                            Description = "A bench designed for performing biceps curls.",
                            LastMaintenanceDate = new DateTime(2024, 4, 23, 12, 20, 2, 197, DateTimeKind.Utc).AddTicks(3026),
                            Name = "Biceps Curl Bench"
                        },
                        new
                        {
                            Id = 9,
                            Availability = 0,
                            Description = "A machine used for the leg press exercise targeting the leg muscles.",
                            LastMaintenanceDate = new DateTime(2024, 4, 23, 12, 20, 2, 197, DateTimeKind.Utc).AddTicks(3028),
                            Name = "Leg Press Machine"
                        },
                        new
                        {
                            Id = 10,
                            Availability = 0,
                            Description = "A versatile machine with cable pulleys for various exercises.",
                            LastMaintenanceDate = new DateTime(2024, 4, 23, 12, 20, 2, 197, DateTimeKind.Utc).AddTicks(3030),
                            Name = "Cable Tower"
                        },
                        new
                        {
                            Id = 11,
                            Availability = 0,
                            Description = "A weight training machine with a barbell fixed within steel rails.",
                            LastMaintenanceDate = new DateTime(2024, 4, 23, 12, 20, 2, 197, DateTimeKind.Utc).AddTicks(3032),
                            Name = "Smith Machine"
                        });
                });

            modelBuilder.Entity("GymManagementSystem.Data.Models.GymMember", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("GymEquipmentId")
                        .HasColumnType("int");

                    b.Property<Guid?>("LockerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("MembershipEndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MembershipPlanId")
                        .HasColumnType("int");

                    b.Property<DateTime>("MembershipStartDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("MembershipStatus")
                        .HasColumnType("bit");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("GymEquipmentId");

                    b.HasIndex("LockerId");

                    b.HasIndex("MembershipPlanId");

                    b.HasIndex("UserId");

                    b.ToTable("GymMembers");
                });

            modelBuilder.Entity("GymManagementSystem.Data.Models.Locker", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("LockerAvailability")
                        .HasColumnType("int");

                    b.Property<int>("LockerNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Lockers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("60b6cc6b-33cc-4f9c-8964-03a2b962273d"),
                            LockerAvailability = 0,
                            LockerNumber = 1
                        },
                        new
                        {
                            Id = new Guid("8c0d91ee-7b74-40f4-a4bc-4e83a06d0fff"),
                            LockerAvailability = 0,
                            LockerNumber = 2
                        },
                        new
                        {
                            Id = new Guid("bf213a83-383e-4ecd-a8db-d504d1d0facd"),
                            LockerAvailability = 0,
                            LockerNumber = 3
                        },
                        new
                        {
                            Id = new Guid("a3f199d2-6cee-4d8a-aa64-93df0767e793"),
                            LockerAvailability = 0,
                            LockerNumber = 4
                        },
                        new
                        {
                            Id = new Guid("3f4f7e24-3210-42c9-9c9f-a5b1c7a8f9ca"),
                            LockerAvailability = 0,
                            LockerNumber = 5
                        },
                        new
                        {
                            Id = new Guid("101924c1-d772-4664-84c4-726783909fcd"),
                            LockerAvailability = 0,
                            LockerNumber = 6
                        },
                        new
                        {
                            Id = new Guid("29748b78-c868-41af-8270-977420ea4b71"),
                            LockerAvailability = 0,
                            LockerNumber = 7
                        },
                        new
                        {
                            Id = new Guid("f7a1112c-665b-4524-979e-cb9ec6f17d90"),
                            LockerAvailability = 0,
                            LockerNumber = 8
                        },
                        new
                        {
                            Id = new Guid("464a6204-4b09-435e-a02e-7d4fc6b551a3"),
                            LockerAvailability = 0,
                            LockerNumber = 9
                        },
                        new
                        {
                            Id = new Guid("6dd443cd-f86a-49fa-aac6-22fac46c6a76"),
                            LockerAvailability = 0,
                            LockerNumber = 10
                        },
                        new
                        {
                            Id = new Guid("6a11b806-59e1-48c2-80db-e1bbd79b15d3"),
                            LockerAvailability = 0,
                            LockerNumber = 11
                        },
                        new
                        {
                            Id = new Guid("d9b49f77-bb71-4fd9-aee8-19629ed2643a"),
                            LockerAvailability = 0,
                            LockerNumber = 12
                        },
                        new
                        {
                            Id = new Guid("eaf83d06-cc0d-4b0f-9b13-865af20910d8"),
                            LockerAvailability = 0,
                            LockerNumber = 13
                        },
                        new
                        {
                            Id = new Guid("926af221-3713-4ca3-a24c-4683cdd67ee8"),
                            LockerAvailability = 0,
                            LockerNumber = 14
                        },
                        new
                        {
                            Id = new Guid("00d70c8e-dff1-4534-a13f-7dc2c5c35145"),
                            LockerAvailability = 0,
                            LockerNumber = 15
                        },
                        new
                        {
                            Id = new Guid("19d3dac8-fbd0-4075-bda5-3db6f25e5ac8"),
                            LockerAvailability = 0,
                            LockerNumber = 16
                        },
                        new
                        {
                            Id = new Guid("a727c60c-ef8b-4d3d-9df7-81e6ce1cae03"),
                            LockerAvailability = 0,
                            LockerNumber = 17
                        },
                        new
                        {
                            Id = new Guid("23896955-e18e-4d39-aec8-3aac72abf78c"),
                            LockerAvailability = 0,
                            LockerNumber = 18
                        },
                        new
                        {
                            Id = new Guid("3e947dfb-3ecd-4a9c-9c55-c5f182354a34"),
                            LockerAvailability = 0,
                            LockerNumber = 19
                        },
                        new
                        {
                            Id = new Guid("58f190bb-fe65-46ba-843c-429e96f26dfc"),
                            LockerAvailability = 0,
                            LockerNumber = 20
                        },
                        new
                        {
                            Id = new Guid("039f420a-a18e-4fcd-b989-5e69c5db0eb0"),
                            LockerAvailability = 0,
                            LockerNumber = 21
                        },
                        new
                        {
                            Id = new Guid("288d55b7-6d30-4f8c-a56b-3beb8189495d"),
                            LockerAvailability = 0,
                            LockerNumber = 22
                        },
                        new
                        {
                            Id = new Guid("a91a30fa-8555-454c-962b-531fa51ae005"),
                            LockerAvailability = 0,
                            LockerNumber = 23
                        },
                        new
                        {
                            Id = new Guid("63abd27b-4ebc-4593-9134-534d666499db"),
                            LockerAvailability = 0,
                            LockerNumber = 24
                        },
                        new
                        {
                            Id = new Guid("e9d0f70d-2c3c-4a74-93b8-9ec3849dd529"),
                            LockerAvailability = 0,
                            LockerNumber = 25
                        },
                        new
                        {
                            Id = new Guid("54585905-4be0-49d2-8fbd-f4e46a0e99dd"),
                            LockerAvailability = 0,
                            LockerNumber = 26
                        },
                        new
                        {
                            Id = new Guid("5a738d80-efcd-4df4-a6c4-2b0c1421951d"),
                            LockerAvailability = 0,
                            LockerNumber = 27
                        },
                        new
                        {
                            Id = new Guid("0cdeb6f6-9f51-4753-97a9-9c3dc64524f7"),
                            LockerAvailability = 0,
                            LockerNumber = 28
                        },
                        new
                        {
                            Id = new Guid("4703821a-769b-4136-ba7f-47c533a12384"),
                            LockerAvailability = 0,
                            LockerNumber = 29
                        },
                        new
                        {
                            Id = new Guid("bdefd8a2-e281-42aa-ace7-da7a781d7669"),
                            LockerAvailability = 0,
                            LockerNumber = 30
                        },
                        new
                        {
                            Id = new Guid("38f5ca68-e832-4f69-98a9-505932b3b6d2"),
                            LockerAvailability = 0,
                            LockerNumber = 31
                        },
                        new
                        {
                            Id = new Guid("b0268371-fd6f-49a2-9961-b22409c9a7a1"),
                            LockerAvailability = 0,
                            LockerNumber = 32
                        },
                        new
                        {
                            Id = new Guid("1ca9dbc0-958d-4c35-9e1b-bef616397e8c"),
                            LockerAvailability = 0,
                            LockerNumber = 33
                        },
                        new
                        {
                            Id = new Guid("59bb83db-ea74-40a9-bd2f-6e8dfcd1ffc5"),
                            LockerAvailability = 0,
                            LockerNumber = 34
                        },
                        new
                        {
                            Id = new Guid("ce6fe867-05dd-46dd-9eda-9a776e3f372c"),
                            LockerAvailability = 0,
                            LockerNumber = 35
                        },
                        new
                        {
                            Id = new Guid("9c1dcab8-0d8e-4843-ad0e-738145c6d25b"),
                            LockerAvailability = 0,
                            LockerNumber = 36
                        },
                        new
                        {
                            Id = new Guid("7573edc1-e5ab-48e7-bb21-a7aa5d3d8f13"),
                            LockerAvailability = 0,
                            LockerNumber = 37
                        },
                        new
                        {
                            Id = new Guid("79555c8c-9bf7-4030-9c53-65a77c1b834b"),
                            LockerAvailability = 0,
                            LockerNumber = 38
                        },
                        new
                        {
                            Id = new Guid("c7994d33-da68-44be-98df-2050acd582ee"),
                            LockerAvailability = 0,
                            LockerNumber = 39
                        },
                        new
                        {
                            Id = new Guid("2791a8aa-bece-4947-91b3-0095e12e397a"),
                            LockerAvailability = 0,
                            LockerNumber = 40
                        });
                });

            modelBuilder.Entity("GymManagementSystem.Data.Models.MembershipPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("MembershipPlans");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "One workout only.",
                            Name = "Pay-as-You-Go",
                            Price = 10m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Standard Monthly Membership. You can go to the gym anytime trough the month you paid for.",
                            Name = "Standard Monthly Membership",
                            Price = 60m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Student Monthly Membership. You can go to the gym anytime trough the month you paid for. You're using a 30% discount off the price",
                            Name = "Student Monthly Membership",
                            Price = 42m
                        });
                });

            modelBuilder.Entity("GymManagementSystem.Data.Models.StaffMember", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ContractEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ContractStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(17)
                        .HasColumnType("nvarchar(17)");

                    b.Property<decimal>("Salary")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("StaffMembers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("GymManagementSystem.Data.Models.AttendanceRecord", b =>
                {
                    b.HasOne("GymManagementSystem.Data.Models.GymMember", "User")
                        .WithMany("AttendanceRecords")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("GymManagementSystem.Data.Models.GymMember", b =>
                {
                    b.HasOne("GymManagementSystem.Data.Models.GymEquipment", "UsedGymEquipment")
                        .WithMany()
                        .HasForeignKey("GymEquipmentId");

                    b.HasOne("GymManagementSystem.Data.Models.Locker", "Locker")
                        .WithMany()
                        .HasForeignKey("LockerId");

                    b.HasOne("GymManagementSystem.Data.Models.MembershipPlan", "MembershipPlan")
                        .WithMany()
                        .HasForeignKey("MembershipPlanId");

                    b.HasOne("GymManagementSystem.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Locker");

                    b.Navigation("MembershipPlan");

                    b.Navigation("UsedGymEquipment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GymManagementSystem.Data.Models.StaffMember", b =>
                {
                    b.HasOne("GymManagementSystem.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("GymManagementSystem.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("GymManagementSystem.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GymManagementSystem.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("GymManagementSystem.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GymManagementSystem.Data.Models.GymMember", b =>
                {
                    b.Navigation("AttendanceRecords");
                });
#pragma warning restore 612, 618
        }
    }
}