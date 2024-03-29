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
    [Migration("20240328215127_UpdateTables")]
    partial class UpdateTables
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

                    b.HasKey("Id");

                    b.ToTable("GymEquipment");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Availability = 0,
                            Description = "A weight training equipment used for squats.",
                            LastMaintenanceDate = new DateTime(2024, 3, 28, 21, 51, 26, 906, DateTimeKind.Utc).AddTicks(1507),
                            Name = "Squat Rack"
                        },
                        new
                        {
                            Id = 2,
                            Availability = 0,
                            Description = "A piece of weight training equipment used for various exercises including bench presses.",
                            LastMaintenanceDate = new DateTime(2024, 3, 28, 21, 51, 26, 906, DateTimeKind.Utc).AddTicks(1511),
                            Name = "Weight Bench"
                        },
                        new
                        {
                            Id = 3,
                            Availability = 0,
                            Description = "A machine used for the lat pulldown exercise targeting the upper back muscles.",
                            LastMaintenanceDate = new DateTime(2024, 3, 28, 21, 51, 26, 906, DateTimeKind.Utc).AddTicks(1512),
                            Name = "Lat Pulldown Machine"
                        },
                        new
                        {
                            Id = 4,
                            Availability = 0,
                            Description = "A machine used for the chest press exercise targeting the chest muscles.",
                            LastMaintenanceDate = new DateTime(2024, 3, 28, 21, 51, 26, 906, DateTimeKind.Utc).AddTicks(1513),
                            Name = "Chest Press Machine"
                        },
                        new
                        {
                            Id = 5,
                            Availability = 0,
                            Description = "A machine used for the chest fly exercise targeting the chest muscles.",
                            LastMaintenanceDate = new DateTime(2024, 3, 28, 21, 51, 26, 906, DateTimeKind.Utc).AddTicks(1514),
                            Name = "Chest Fly Machine"
                        },
                        new
                        {
                            Id = 6,
                            Availability = 0,
                            Description = "A machine used for the shoulder press exercise targeting the shoulder muscles.",
                            LastMaintenanceDate = new DateTime(2024, 3, 28, 21, 51, 26, 906, DateTimeKind.Utc).AddTicks(1516),
                            Name = "Shoulder Press Machine"
                        },
                        new
                        {
                            Id = 7,
                            Availability = 0,
                            Description = "A machine used for the cable row exercise targeting the back muscles.",
                            LastMaintenanceDate = new DateTime(2024, 3, 28, 21, 51, 26, 906, DateTimeKind.Utc).AddTicks(1517),
                            Name = "Cable Row Machine"
                        },
                        new
                        {
                            Id = 8,
                            Availability = 0,
                            Description = "A bench designed for performing biceps curls.",
                            LastMaintenanceDate = new DateTime(2024, 3, 28, 21, 51, 26, 906, DateTimeKind.Utc).AddTicks(1518),
                            Name = "Biceps Curl Bench"
                        },
                        new
                        {
                            Id = 9,
                            Availability = 0,
                            Description = "A machine used for the leg press exercise targeting the leg muscles.",
                            LastMaintenanceDate = new DateTime(2024, 3, 28, 21, 51, 26, 906, DateTimeKind.Utc).AddTicks(1519),
                            Name = "Leg Press Machine"
                        },
                        new
                        {
                            Id = 10,
                            Availability = 0,
                            Description = "A versatile machine with cable pulleys for various exercises.",
                            LastMaintenanceDate = new DateTime(2024, 3, 28, 21, 51, 26, 906, DateTimeKind.Utc).AddTicks(1521),
                            Name = "Cable Tower"
                        },
                        new
                        {
                            Id = 11,
                            Availability = 0,
                            Description = "A weight training machine with a barbell fixed within steel rails.",
                            LastMaintenanceDate = new DateTime(2024, 3, 28, 21, 51, 26, 906, DateTimeKind.Utc).AddTicks(1522),
                            Name = "Smith Machine"
                        });
                });

            modelBuilder.Entity("GymManagementSystem.Data.Models.GymMember", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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
                            Id = new Guid("992c1c7c-4fc2-4024-ae30-a560439e94db"),
                            LockerAvailability = 0,
                            LockerNumber = 1
                        },
                        new
                        {
                            Id = new Guid("76a2a7a8-672e-4914-bffe-d52d3a9ed30f"),
                            LockerAvailability = 0,
                            LockerNumber = 2
                        },
                        new
                        {
                            Id = new Guid("0208f1d4-f23d-4cc0-8cdb-4f99341a8ea0"),
                            LockerAvailability = 0,
                            LockerNumber = 3
                        },
                        new
                        {
                            Id = new Guid("cebf0ceb-234b-4ec7-ac8d-4d2be0d250ee"),
                            LockerAvailability = 0,
                            LockerNumber = 4
                        },
                        new
                        {
                            Id = new Guid("80e89163-f3da-4570-a711-dca045f31512"),
                            LockerAvailability = 0,
                            LockerNumber = 5
                        },
                        new
                        {
                            Id = new Guid("362185d6-6f79-4915-8cc7-bb438cc5b304"),
                            LockerAvailability = 0,
                            LockerNumber = 6
                        },
                        new
                        {
                            Id = new Guid("88383e7e-4acb-47c5-9fcf-32a09f63b53f"),
                            LockerAvailability = 0,
                            LockerNumber = 7
                        },
                        new
                        {
                            Id = new Guid("dd7b9fad-ac0e-43a1-a8cb-0f7231eb2e6a"),
                            LockerAvailability = 0,
                            LockerNumber = 8
                        },
                        new
                        {
                            Id = new Guid("50a58c8e-8498-4c59-bf6d-6f61ddadc3d0"),
                            LockerAvailability = 0,
                            LockerNumber = 9
                        },
                        new
                        {
                            Id = new Guid("cc802ebd-6d1b-4974-8c77-7f248114ac87"),
                            LockerAvailability = 0,
                            LockerNumber = 10
                        },
                        new
                        {
                            Id = new Guid("cccc9a71-fa97-473a-9bc2-a78069200a1f"),
                            LockerAvailability = 0,
                            LockerNumber = 11
                        },
                        new
                        {
                            Id = new Guid("890b7d4d-77a7-4ba4-850f-439174091df4"),
                            LockerAvailability = 0,
                            LockerNumber = 12
                        },
                        new
                        {
                            Id = new Guid("d39ae9a9-75a4-4ebb-b598-76c8fba5c849"),
                            LockerAvailability = 0,
                            LockerNumber = 13
                        },
                        new
                        {
                            Id = new Guid("c91c3439-a33d-4f5f-a670-34f63b56a34c"),
                            LockerAvailability = 0,
                            LockerNumber = 14
                        },
                        new
                        {
                            Id = new Guid("436fdc0c-b3f1-4e37-bd2f-51727802cde9"),
                            LockerAvailability = 0,
                            LockerNumber = 15
                        },
                        new
                        {
                            Id = new Guid("df892d0d-0168-4324-b786-741999085855"),
                            LockerAvailability = 0,
                            LockerNumber = 16
                        },
                        new
                        {
                            Id = new Guid("a78c0431-c988-4ea3-af9e-844cfc59610c"),
                            LockerAvailability = 0,
                            LockerNumber = 17
                        },
                        new
                        {
                            Id = new Guid("9540fe5f-829c-4a58-9577-50d3897ece96"),
                            LockerAvailability = 0,
                            LockerNumber = 18
                        },
                        new
                        {
                            Id = new Guid("9a1293f7-a094-48d0-a7a7-dc9f03f0a855"),
                            LockerAvailability = 0,
                            LockerNumber = 19
                        },
                        new
                        {
                            Id = new Guid("cfc89abc-382b-4dd8-a9a0-f4d6582a43a6"),
                            LockerAvailability = 0,
                            LockerNumber = 20
                        },
                        new
                        {
                            Id = new Guid("5fb05bed-26c7-42d5-9996-46bbb5172240"),
                            LockerAvailability = 0,
                            LockerNumber = 21
                        },
                        new
                        {
                            Id = new Guid("56005975-3403-4a57-82f4-6fdba9a6638c"),
                            LockerAvailability = 0,
                            LockerNumber = 22
                        },
                        new
                        {
                            Id = new Guid("61356f65-0175-4dd4-bb14-65fb0edb853c"),
                            LockerAvailability = 0,
                            LockerNumber = 23
                        },
                        new
                        {
                            Id = new Guid("7b52ce62-349b-4b10-bda9-5ce83fe85c53"),
                            LockerAvailability = 0,
                            LockerNumber = 24
                        },
                        new
                        {
                            Id = new Guid("48deb5d8-63cd-4ef2-92d9-4525ee20490b"),
                            LockerAvailability = 0,
                            LockerNumber = 25
                        },
                        new
                        {
                            Id = new Guid("f8b285ac-bbbf-49e9-b92e-10cbc89ec4f6"),
                            LockerAvailability = 0,
                            LockerNumber = 26
                        },
                        new
                        {
                            Id = new Guid("0b1f9577-3581-4780-9ecd-b0b7cc435b1d"),
                            LockerAvailability = 0,
                            LockerNumber = 27
                        },
                        new
                        {
                            Id = new Guid("4dd634e9-5a53-4e75-bad3-d135b5fdfe18"),
                            LockerAvailability = 0,
                            LockerNumber = 28
                        },
                        new
                        {
                            Id = new Guid("d95cf5cd-8209-4363-ae7b-50ee6ee52037"),
                            LockerAvailability = 0,
                            LockerNumber = 29
                        },
                        new
                        {
                            Id = new Guid("e4c57e18-583c-465b-8718-fdf516f1e1a8"),
                            LockerAvailability = 0,
                            LockerNumber = 30
                        },
                        new
                        {
                            Id = new Guid("9a5e1f52-8c39-4343-a451-4de38417b7d5"),
                            LockerAvailability = 0,
                            LockerNumber = 31
                        },
                        new
                        {
                            Id = new Guid("5cfbd55d-8312-4870-ba47-50027b14f09f"),
                            LockerAvailability = 0,
                            LockerNumber = 32
                        },
                        new
                        {
                            Id = new Guid("95c5ed87-771e-4e56-b5cb-c75096dc1eac"),
                            LockerAvailability = 0,
                            LockerNumber = 33
                        },
                        new
                        {
                            Id = new Guid("3c999c5d-dea3-455e-9339-7a6e5b223305"),
                            LockerAvailability = 0,
                            LockerNumber = 34
                        },
                        new
                        {
                            Id = new Guid("3b6b255e-6369-4ae1-8561-08d6290e582c"),
                            LockerAvailability = 0,
                            LockerNumber = 35
                        },
                        new
                        {
                            Id = new Guid("9851975e-7243-4801-997e-d8c5aaf2cb98"),
                            LockerAvailability = 0,
                            LockerNumber = 36
                        },
                        new
                        {
                            Id = new Guid("c21cce6d-9149-46f3-af8b-57eefad88884"),
                            LockerAvailability = 0,
                            LockerNumber = 37
                        },
                        new
                        {
                            Id = new Guid("0da77b49-e8b1-4d7a-9796-b6cf6a39f2de"),
                            LockerAvailability = 0,
                            LockerNumber = 38
                        },
                        new
                        {
                            Id = new Guid("d3c0ee36-0f16-43b2-a055-2346ca93194b"),
                            LockerAvailability = 0,
                            LockerNumber = 39
                        },
                        new
                        {
                            Id = new Guid("835263a5-3b33-4794-aea7-60081c07db88"),
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
