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
    [Migration("20240328215707_UpdateGymEquipment")]
    partial class UpdateGymEquipment
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
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

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasDefaultValue("FirstNameTest");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasDefaultValue("LastNameTest");

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

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("GymEquipment");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Availability = 0,
                            Description = "A weight training equipment used for squats.",
                            LastMaintenanceDate = new DateTime(2024, 3, 28, 21, 57, 7, 2, DateTimeKind.Utc).AddTicks(1616),
                            Name = "Squat Rack"
                        },
                        new
                        {
                            Id = 2,
                            Availability = 0,
                            Description = "A piece of weight training equipment used for various exercises including bench presses.",
                            LastMaintenanceDate = new DateTime(2024, 3, 28, 21, 57, 7, 2, DateTimeKind.Utc).AddTicks(1940),
                            Name = "Weight Bench"
                        },
                        new
                        {
                            Id = 3,
                            Availability = 0,
                            Description = "A machine used for the lat pulldown exercise targeting the upper back muscles.",
                            LastMaintenanceDate = new DateTime(2024, 3, 28, 21, 57, 7, 2, DateTimeKind.Utc).AddTicks(1942),
                            Name = "Lat Pulldown Machine"
                        },
                        new
                        {
                            Id = 4,
                            Availability = 0,
                            Description = "A machine used for the chest press exercise targeting the chest muscles.",
                            LastMaintenanceDate = new DateTime(2024, 3, 28, 21, 57, 7, 2, DateTimeKind.Utc).AddTicks(1943),
                            Name = "Chest Press Machine"
                        },
                        new
                        {
                            Id = 5,
                            Availability = 0,
                            Description = "A machine used for the chest fly exercise targeting the chest muscles.",
                            LastMaintenanceDate = new DateTime(2024, 3, 28, 21, 57, 7, 2, DateTimeKind.Utc).AddTicks(1944),
                            Name = "Chest Fly Machine"
                        },
                        new
                        {
                            Id = 6,
                            Availability = 0,
                            Description = "A machine used for the shoulder press exercise targeting the shoulder muscles.",
                            LastMaintenanceDate = new DateTime(2024, 3, 28, 21, 57, 7, 2, DateTimeKind.Utc).AddTicks(1947),
                            Name = "Shoulder Press Machine"
                        },
                        new
                        {
                            Id = 7,
                            Availability = 0,
                            Description = "A machine used for the cable row exercise targeting the back muscles.",
                            LastMaintenanceDate = new DateTime(2024, 3, 28, 21, 57, 7, 2, DateTimeKind.Utc).AddTicks(1949),
                            Name = "Cable Row Machine"
                        },
                        new
                        {
                            Id = 8,
                            Availability = 0,
                            Description = "A bench designed for performing biceps curls.",
                            LastMaintenanceDate = new DateTime(2024, 3, 28, 21, 57, 7, 2, DateTimeKind.Utc).AddTicks(1950),
                            Name = "Biceps Curl Bench"
                        },
                        new
                        {
                            Id = 9,
                            Availability = 0,
                            Description = "A machine used for the leg press exercise targeting the leg muscles.",
                            LastMaintenanceDate = new DateTime(2024, 3, 28, 21, 57, 7, 2, DateTimeKind.Utc).AddTicks(1951),
                            Name = "Leg Press Machine"
                        },
                        new
                        {
                            Id = 10,
                            Availability = 0,
                            Description = "A versatile machine with cable pulleys for various exercises.",
                            LastMaintenanceDate = new DateTime(2024, 3, 28, 21, 57, 7, 2, DateTimeKind.Utc).AddTicks(1953),
                            Name = "Cable Tower"
                        },
                        new
                        {
                            Id = 11,
                            Availability = 0,
                            Description = "A weight training machine with a barbell fixed within steel rails.",
                            LastMaintenanceDate = new DateTime(2024, 3, 28, 21, 57, 7, 2, DateTimeKind.Utc).AddTicks(1955),
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

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Lockers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("30dfa639-7464-4fa0-935d-60ae0b1c4f77"),
                            LockerAvailability = 0,
                            LockerNumber = 1
                        },
                        new
                        {
                            Id = new Guid("a463c15b-dddd-406b-9ca2-43f3ca1abd20"),
                            LockerAvailability = 0,
                            LockerNumber = 2
                        },
                        new
                        {
                            Id = new Guid("06a8fec5-794e-400f-87b5-780904ab5b48"),
                            LockerAvailability = 0,
                            LockerNumber = 3
                        },
                        new
                        {
                            Id = new Guid("a11a5095-8cf8-492b-b349-b40a9ab7592d"),
                            LockerAvailability = 0,
                            LockerNumber = 4
                        },
                        new
                        {
                            Id = new Guid("db591475-8d55-4e7e-99a7-c1a57956059f"),
                            LockerAvailability = 0,
                            LockerNumber = 5
                        },
                        new
                        {
                            Id = new Guid("b4924cb3-f8d4-4acb-b225-2159564365ff"),
                            LockerAvailability = 0,
                            LockerNumber = 6
                        },
                        new
                        {
                            Id = new Guid("bd3e7541-e54c-4acc-aa23-7c227fc0e445"),
                            LockerAvailability = 0,
                            LockerNumber = 7
                        },
                        new
                        {
                            Id = new Guid("04ec43ae-bae5-46bd-9a8a-93d577fafb85"),
                            LockerAvailability = 0,
                            LockerNumber = 8
                        },
                        new
                        {
                            Id = new Guid("06777d4a-2614-454f-ab27-1417d77e336e"),
                            LockerAvailability = 0,
                            LockerNumber = 9
                        },
                        new
                        {
                            Id = new Guid("8b4744f3-487d-4403-82c7-d22a98cdadf1"),
                            LockerAvailability = 0,
                            LockerNumber = 10
                        },
                        new
                        {
                            Id = new Guid("0093ee95-c7ad-413f-8ccb-6a949a9125fe"),
                            LockerAvailability = 0,
                            LockerNumber = 11
                        },
                        new
                        {
                            Id = new Guid("256cdf66-2257-4b28-85bb-ccd2f08e93e4"),
                            LockerAvailability = 0,
                            LockerNumber = 12
                        },
                        new
                        {
                            Id = new Guid("c05d06d9-477a-47de-ac84-6ccdcb4b29f9"),
                            LockerAvailability = 0,
                            LockerNumber = 13
                        },
                        new
                        {
                            Id = new Guid("3d180a71-0ee5-4c1e-a01a-9f9eb2e7121a"),
                            LockerAvailability = 0,
                            LockerNumber = 14
                        },
                        new
                        {
                            Id = new Guid("8a4503da-c633-4a38-a41d-dfa02df17323"),
                            LockerAvailability = 0,
                            LockerNumber = 15
                        },
                        new
                        {
                            Id = new Guid("b1f948ff-ef00-49e7-b0f9-5bf7c30ce112"),
                            LockerAvailability = 0,
                            LockerNumber = 16
                        },
                        new
                        {
                            Id = new Guid("47c4545b-c557-4568-a55f-79417aa342ed"),
                            LockerAvailability = 0,
                            LockerNumber = 17
                        },
                        new
                        {
                            Id = new Guid("24d42bbd-87f1-40db-958b-446ba0e8e8b6"),
                            LockerAvailability = 0,
                            LockerNumber = 18
                        },
                        new
                        {
                            Id = new Guid("c7e2245f-c9f9-45e3-bf84-d9d4aceb80c9"),
                            LockerAvailability = 0,
                            LockerNumber = 19
                        },
                        new
                        {
                            Id = new Guid("a2d1bd3e-5ef2-4772-b829-c0e793167619"),
                            LockerAvailability = 0,
                            LockerNumber = 20
                        },
                        new
                        {
                            Id = new Guid("ace5893a-fa2f-4b94-835f-21268b30abf7"),
                            LockerAvailability = 0,
                            LockerNumber = 21
                        },
                        new
                        {
                            Id = new Guid("be44225b-0f5d-4a69-8f1d-ffe7a1833388"),
                            LockerAvailability = 0,
                            LockerNumber = 22
                        },
                        new
                        {
                            Id = new Guid("9c5fe74d-1536-4b68-8a71-7ec0f63e85f9"),
                            LockerAvailability = 0,
                            LockerNumber = 23
                        },
                        new
                        {
                            Id = new Guid("5bfceefd-1102-43b6-bee9-9175a079c4c2"),
                            LockerAvailability = 0,
                            LockerNumber = 24
                        },
                        new
                        {
                            Id = new Guid("373869a4-9897-4941-b149-fe14952594d8"),
                            LockerAvailability = 0,
                            LockerNumber = 25
                        },
                        new
                        {
                            Id = new Guid("3952eb84-8690-4a7a-b7df-5c69961c899e"),
                            LockerAvailability = 0,
                            LockerNumber = 26
                        },
                        new
                        {
                            Id = new Guid("e69243fc-59a3-4cc8-97f7-49adaa7dc345"),
                            LockerAvailability = 0,
                            LockerNumber = 27
                        },
                        new
                        {
                            Id = new Guid("b9c06459-350c-4b76-9341-bb88956a5ba6"),
                            LockerAvailability = 0,
                            LockerNumber = 28
                        },
                        new
                        {
                            Id = new Guid("e3e7eb3e-e42c-4692-a90a-22691a91b47e"),
                            LockerAvailability = 0,
                            LockerNumber = 29
                        },
                        new
                        {
                            Id = new Guid("491b80cd-09e8-4abe-a27e-38c1a654b115"),
                            LockerAvailability = 0,
                            LockerNumber = 30
                        },
                        new
                        {
                            Id = new Guid("f03eb15e-cb7f-4244-8251-c4b5ecd288ce"),
                            LockerAvailability = 0,
                            LockerNumber = 31
                        },
                        new
                        {
                            Id = new Guid("9b344aca-693d-4131-88ce-29f6b6a7d2e6"),
                            LockerAvailability = 0,
                            LockerNumber = 32
                        },
                        new
                        {
                            Id = new Guid("6f2e71f4-f98e-42f6-839c-9b4debfd4a1f"),
                            LockerAvailability = 0,
                            LockerNumber = 33
                        },
                        new
                        {
                            Id = new Guid("b9636f69-f3e7-42f6-a60a-187799bd983f"),
                            LockerAvailability = 0,
                            LockerNumber = 34
                        },
                        new
                        {
                            Id = new Guid("0b974ad2-284b-4ebe-a05c-38beae64c739"),
                            LockerAvailability = 0,
                            LockerNumber = 35
                        },
                        new
                        {
                            Id = new Guid("1c863666-2a37-4b6b-842a-541d098895c1"),
                            LockerAvailability = 0,
                            LockerNumber = 36
                        },
                        new
                        {
                            Id = new Guid("5deca21d-0e31-43d3-9c7e-d1b04d4871a0"),
                            LockerAvailability = 0,
                            LockerNumber = 37
                        },
                        new
                        {
                            Id = new Guid("71f0d266-65eb-420b-a2db-8acb3182f5e9"),
                            LockerAvailability = 0,
                            LockerNumber = 38
                        },
                        new
                        {
                            Id = new Guid("801eeaf3-ede0-4ae1-abc0-2e4c811d4475"),
                            LockerAvailability = 0,
                            LockerNumber = 39
                        },
                        new
                        {
                            Id = new Guid("04f143fc-0c08-4dde-ab84-6b325d2cb374"),
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

            modelBuilder.Entity("GymManagementSystem.Data.Models.GymEquipment", b =>
                {
                    b.HasOne("GymManagementSystem.Data.Models.GymMember", "GymMember")
                        .WithOne()
                        .HasForeignKey("GymManagementSystem.Data.Models.GymEquipment", "UserId");

                    b.Navigation("GymMember");
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

            modelBuilder.Entity("GymManagementSystem.Data.Models.Locker", b =>
                {
                    b.HasOne("GymManagementSystem.Data.Models.GymMember", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

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
