using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManagementSystem.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GymEquipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Availability = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    LastMaintenanceDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GymEquipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MembershipPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LockerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MembershipStatus = table.Column<bool>(type: "bit", nullable: true),
                    MembershipPlanId = table.Column<int>(type: "int", nullable: true),
                    MembershipStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MembershipEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContractStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContractEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_MembershipPlans_MembershipPlanId",
                        column: x => x.MembershipPlanId,
                        principalTable: "MembershipPlans",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AttendanceRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HasLeft = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CheckInDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CheckOutDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttendanceRecords_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lockers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LockerNumber = table.Column<int>(type: "int", nullable: false),
                    LockerAvailability = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lockers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lockers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "GymEquipment",
                columns: new[] { "Id", "Description", "LastMaintenanceDate", "Name" },
                values: new object[,]
                {
                    { 1, "A weight training equipment used for squats.", new DateTime(2024, 3, 28, 12, 4, 57, 482, DateTimeKind.Utc).AddTicks(6124), "Squat Rack" },
                    { 2, "A piece of weight training equipment used for various exercises including bench presses.", new DateTime(2024, 3, 28, 12, 4, 57, 482, DateTimeKind.Utc).AddTicks(6128), "Weight Bench" },
                    { 3, "A machine used for the lat pulldown exercise targeting the upper back muscles.", new DateTime(2024, 3, 28, 12, 4, 57, 482, DateTimeKind.Utc).AddTicks(6130), "Lat Pulldown Machine" },
                    { 4, "A machine used for the chest press exercise targeting the chest muscles.", new DateTime(2024, 3, 28, 12, 4, 57, 482, DateTimeKind.Utc).AddTicks(6131), "Chest Press Machine" },
                    { 5, "A machine used for the chest fly exercise targeting the chest muscles.", new DateTime(2024, 3, 28, 12, 4, 57, 482, DateTimeKind.Utc).AddTicks(6132), "Chest Fly Machine" },
                    { 6, "A machine used for the shoulder press exercise targeting the shoulder muscles.", new DateTime(2024, 3, 28, 12, 4, 57, 482, DateTimeKind.Utc).AddTicks(6135), "Shoulder Press Machine" },
                    { 7, "A machine used for the cable row exercise targeting the back muscles.", new DateTime(2024, 3, 28, 12, 4, 57, 482, DateTimeKind.Utc).AddTicks(6136), "Cable Row Machine" },
                    { 8, "A bench designed for performing biceps curls.", new DateTime(2024, 3, 28, 12, 4, 57, 482, DateTimeKind.Utc).AddTicks(6137), "Biceps Curl Bench" },
                    { 9, "A machine used for the leg press exercise targeting the leg muscles.", new DateTime(2024, 3, 28, 12, 4, 57, 482, DateTimeKind.Utc).AddTicks(6138), "Leg Press Machine" },
                    { 10, "A versatile machine with cable pulleys for various exercises.", new DateTime(2024, 3, 28, 12, 4, 57, 482, DateTimeKind.Utc).AddTicks(6140), "Cable Tower" },
                    { 11, "A weight training machine with a barbell fixed within steel rails.", new DateTime(2024, 3, 28, 12, 4, 57, 482, DateTimeKind.Utc).AddTicks(6141), "Smith Machine" }
                });

            migrationBuilder.InsertData(
                table: "Lockers",
                columns: new[] { "Id", "LockerAvailability", "LockerNumber", "UserId" },
                values: new object[,]
                {
                    { new Guid("0d9581fb-6de9-42fa-8632-6dbdceaeb916"), 0, 22, null },
                    { new Guid("0e2aba38-a993-464b-9f6b-fcdf59d649e6"), 0, 1, null },
                    { new Guid("118e72af-8a19-4a6f-bf17-c18cc09d9114"), 0, 3, null },
                    { new Guid("1fa1265d-223d-4dcc-aeb4-2f94c66ae5d4"), 0, 12, null },
                    { new Guid("22da0990-d35d-481d-b32b-b1397af6ac57"), 0, 2, null },
                    { new Guid("32df3d53-881b-4ded-b3c6-c3baba7bca1d"), 0, 19, null },
                    { new Guid("335cc97f-054e-46c7-ac85-239d7b2889df"), 0, 24, null },
                    { new Guid("3e5c998a-1d8a-4191-adbb-9335b90c5cf4"), 0, 37, null },
                    { new Guid("3fbdccbf-5747-4b8f-80a5-f3ed0eeb3ab8"), 0, 28, null },
                    { new Guid("427a7268-640f-4b24-a120-682b58008f74"), 0, 38, null },
                    { new Guid("4be838a8-e559-4050-9a24-2d6712a9149e"), 0, 13, null },
                    { new Guid("4f994114-f0a4-4e3e-9ac1-fabef34b7bf6"), 0, 14, null },
                    { new Guid("5588f614-3eea-462b-8d24-b56d22af45aa"), 0, 39, null },
                    { new Guid("5917736c-d05d-413c-8cc3-da55f5424f9b"), 0, 32, null },
                    { new Guid("5a01d164-2af5-4861-bf2b-bc98467074d7"), 0, 17, null },
                    { new Guid("5f56f3dd-0134-4c0d-905e-f61fb753fd52"), 0, 11, null },
                    { new Guid("69cb8afc-db1a-4a06-a466-ece0d322f46a"), 0, 6, null },
                    { new Guid("6a0f75af-966c-4a9f-9967-fcd456a9c92b"), 0, 25, null },
                    { new Guid("6b1080e8-97a4-473e-adf2-f608b2086637"), 0, 27, null },
                    { new Guid("79613d68-41ef-42d3-9ef3-8bd8ee8bb49c"), 0, 4, null },
                    { new Guid("80f0dae3-8233-49b9-b070-d12638c0dd14"), 0, 36, null },
                    { new Guid("8421b763-75cb-44d7-8fad-9cf523d827a3"), 0, 33, null },
                    { new Guid("855099a3-8fd5-4166-9a52-fcbcfca0be4a"), 0, 23, null },
                    { new Guid("9ceb936b-6004-42c4-8738-24a54b60860d"), 0, 30, null },
                    { new Guid("a09f640d-504b-444f-a983-f6ae15e7b74e"), 0, 34, null },
                    { new Guid("a4c07b9d-28be-46be-9841-eef36fb9310f"), 0, 35, null },
                    { new Guid("a97a0d7b-79f6-4203-a633-afcedcab9af6"), 0, 20, null },
                    { new Guid("aebe531c-0591-4bb5-b85d-333821fd9d2e"), 0, 8, null },
                    { new Guid("b8b34bb0-bb67-443f-a00a-2cb74c9afdaf"), 0, 5, null },
                    { new Guid("c4c0ff77-bf3c-4591-85a6-3920049ab459"), 0, 15, null },
                    { new Guid("c62cf7dc-3b86-4c92-a689-1ffa5c474f55"), 0, 10, null }
                });

            migrationBuilder.InsertData(
                table: "Lockers",
                columns: new[] { "Id", "LockerAvailability", "LockerNumber", "UserId" },
                values: new object[,]
                {
                    { new Guid("d48d1115-e956-495c-9ebe-7921cdcb9673"), 0, 21, null },
                    { new Guid("dae8e753-67ba-43c6-8f9b-5db85f877b8f"), 0, 29, null },
                    { new Guid("db9ae16c-902f-43dd-9f9f-a7a18f129e77"), 0, 16, null },
                    { new Guid("e2b090a9-537a-491b-bc9f-b7db7bc3738f"), 0, 31, null },
                    { new Guid("e3ffb138-86fc-437d-9ef4-63cd4ebc6d5b"), 0, 18, null },
                    { new Guid("e50c7566-3c13-421d-a694-edef512ef678"), 0, 9, null },
                    { new Guid("e96ea939-5e7f-4034-b54b-1023e7600ec7"), 0, 7, null },
                    { new Guid("f84931e2-db55-45f2-9b40-52558e6e1cf3"), 0, 26, null },
                    { new Guid("fb9ab0ab-2299-4aee-8c6f-9c7a72bb7661"), 0, 40, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_LockerId",
                table: "AspNetUsers",
                column: "LockerId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_MembershipPlanId",
                table: "AspNetUsers",
                column: "MembershipPlanId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceRecords_UserId",
                table: "AttendanceRecords",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Lockers_UserId",
                table: "Lockers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Lockers_LockerId",
                table: "AspNetUsers",
                column: "LockerId",
                principalTable: "Lockers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lockers_AspNetUsers_UserId",
                table: "Lockers");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AttendanceRecords");

            migrationBuilder.DropTable(
                name: "GymEquipment");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Lockers");

            migrationBuilder.DropTable(
                name: "MembershipPlans");
        }
    }
}
