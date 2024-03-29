using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManagementSystem.Data.Migrations
{
    public partial class UpdateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Lockers_LockerId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_MembershipPlans_MembershipPlanId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendanceRecords_AspNetUsers_UserId",
                table: "AttendanceRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_Lockers_AspNetUsers_UserId",
                table: "Lockers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_LockerId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_MembershipPlanId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("0290304e-a997-4afa-b58f-9c740f85d853"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("058bab11-a8b9-4d89-b5b8-a5304736bd2b"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("09d9def9-9b03-4a08-8596-56916a6e52b9"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("0df32034-4715-4ebc-b1e1-0006d2ac8c12"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("12a84579-87aa-4d71-be86-9c8f928c72d3"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("13d7a001-0342-4512-8b05-8cab47af4789"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("141478b9-6d9a-47ef-9e73-cc5d13d36f77"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("15b28570-f7df-4b73-886a-fd3a5d91b47a"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("200377f2-5e0e-408b-8d6d-7855198ea566"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("2c9e99dc-814a-473b-8278-96abd469baaa"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("378d833d-b297-4440-8e46-41f62bf67f92"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("47fa8608-1905-45c6-adec-81c8d6bf82a0"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("51185d16-c0d0-4d75-82d2-c7500e0761d6"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("562ccd4f-d6b9-4930-825d-ef7934514257"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("584f10c6-5e0c-43ce-9639-b86dbf4ae07b"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("850baba5-4986-428d-b64b-15c59f4d36db"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("8b4c163b-26a2-47b2-8b5f-5824ebc997e5"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("9519b93c-ac90-47b0-8146-5157564fe669"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("99c3d180-5789-43dc-a2f4-5a6b92ff1166"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("b32dd821-5612-4f44-90ef-7da4089f49d7"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("b735e9f2-decb-4718-8b83-b11a555b6622"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("beba2d85-0108-448d-8b0f-ca7794c8af84"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("bec0ab6d-fdc9-49bc-bee5-b16dec305103"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("bf24b703-3a35-4b3a-b0ac-7604f2ebe1ff"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("bf9f8efe-a54f-49f8-b5c3-1a17263b572f"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("c261d42c-56b7-4423-9597-ec2f2251fe4d"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("c6978dc8-9344-494f-9a55-87096bd25764"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("c71b53b9-9de4-419d-a721-a75e4eada89c"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("c8b14c89-54f8-4b0c-8be6-fe1c9c85ea95"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("ca7cb33e-2700-4b73-88e5-2672a1b773a7"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("cef4acc9-0607-4954-9b3f-b073afd3901b"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("cf72ab2f-b202-42e0-9f8e-b740a5e1d6ef"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("d84190cc-6621-4918-8d36-e4f4fe8dbf83"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("d98d1c61-1fbb-4140-8413-103f45a6b35a"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("e1b9a76c-dd51-4453-9e4c-8a99274b4a3b"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("e5314789-3f38-430a-a3ad-b7e14e635b7c"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("fad12282-808f-4ab2-978e-d9756c3b4af5"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("fafeb225-b139-4849-83ce-5b5a41864773"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("fd5b50c9-8ece-4dfb-a610-4a23d6ff4c57"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("fe40ee1d-5ec4-4425-a2b3-940b2338183f"));

            migrationBuilder.DropColumn(
                name: "ContractEndDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ContractStartDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LockerId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MembershipEndDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MembershipPlanId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MembershipStartDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MembershipStatus",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(17)",
                oldMaxLength: 17);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "LastNameTest",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "FirstNameTest",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.CreateTable(
                name: "GymMembers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LockerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MembershipStatus = table.Column<bool>(type: "bit", nullable: false),
                    MembershipPlanId = table.Column<int>(type: "int", nullable: true),
                    MembershipStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MembershipEndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GymMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GymMembers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GymMembers_Lockers_LockerId",
                        column: x => x.LockerId,
                        principalTable: "Lockers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GymMembers_MembershipPlans_MembershipPlanId",
                        column: x => x.MembershipPlanId,
                        principalTable: "MembershipPlans",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StaffMembers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContractStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContractEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffMembers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 3, 28, 21, 51, 26, 906, DateTimeKind.Utc).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 3, 28, 21, 51, 26, 906, DateTimeKind.Utc).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 3, 28, 21, 51, 26, 906, DateTimeKind.Utc).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 3, 28, 21, 51, 26, 906, DateTimeKind.Utc).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 3, 28, 21, 51, 26, 906, DateTimeKind.Utc).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 3, 28, 21, 51, 26, 906, DateTimeKind.Utc).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 3, 28, 21, 51, 26, 906, DateTimeKind.Utc).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 3, 28, 21, 51, 26, 906, DateTimeKind.Utc).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 3, 28, 21, 51, 26, 906, DateTimeKind.Utc).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 3, 28, 21, 51, 26, 906, DateTimeKind.Utc).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 3, 28, 21, 51, 26, 906, DateTimeKind.Utc).AddTicks(1522));

            migrationBuilder.InsertData(
                table: "Lockers",
                columns: new[] { "Id", "LockerAvailability", "LockerNumber", "UserId" },
                values: new object[,]
                {
                    { new Guid("0208f1d4-f23d-4cc0-8cdb-4f99341a8ea0"), 0, 3, null },
                    { new Guid("0b1f9577-3581-4780-9ecd-b0b7cc435b1d"), 0, 27, null },
                    { new Guid("0da77b49-e8b1-4d7a-9796-b6cf6a39f2de"), 0, 38, null },
                    { new Guid("362185d6-6f79-4915-8cc7-bb438cc5b304"), 0, 6, null },
                    { new Guid("3b6b255e-6369-4ae1-8561-08d6290e582c"), 0, 35, null },
                    { new Guid("3c999c5d-dea3-455e-9339-7a6e5b223305"), 0, 34, null },
                    { new Guid("436fdc0c-b3f1-4e37-bd2f-51727802cde9"), 0, 15, null },
                    { new Guid("48deb5d8-63cd-4ef2-92d9-4525ee20490b"), 0, 25, null },
                    { new Guid("4dd634e9-5a53-4e75-bad3-d135b5fdfe18"), 0, 28, null },
                    { new Guid("50a58c8e-8498-4c59-bf6d-6f61ddadc3d0"), 0, 9, null },
                    { new Guid("56005975-3403-4a57-82f4-6fdba9a6638c"), 0, 22, null },
                    { new Guid("5cfbd55d-8312-4870-ba47-50027b14f09f"), 0, 32, null },
                    { new Guid("5fb05bed-26c7-42d5-9996-46bbb5172240"), 0, 21, null },
                    { new Guid("61356f65-0175-4dd4-bb14-65fb0edb853c"), 0, 23, null },
                    { new Guid("76a2a7a8-672e-4914-bffe-d52d3a9ed30f"), 0, 2, null },
                    { new Guid("7b52ce62-349b-4b10-bda9-5ce83fe85c53"), 0, 24, null },
                    { new Guid("80e89163-f3da-4570-a711-dca045f31512"), 0, 5, null },
                    { new Guid("835263a5-3b33-4794-aea7-60081c07db88"), 0, 40, null },
                    { new Guid("88383e7e-4acb-47c5-9fcf-32a09f63b53f"), 0, 7, null },
                    { new Guid("890b7d4d-77a7-4ba4-850f-439174091df4"), 0, 12, null },
                    { new Guid("9540fe5f-829c-4a58-9577-50d3897ece96"), 0, 18, null },
                    { new Guid("95c5ed87-771e-4e56-b5cb-c75096dc1eac"), 0, 33, null },
                    { new Guid("9851975e-7243-4801-997e-d8c5aaf2cb98"), 0, 36, null },
                    { new Guid("992c1c7c-4fc2-4024-ae30-a560439e94db"), 0, 1, null },
                    { new Guid("9a1293f7-a094-48d0-a7a7-dc9f03f0a855"), 0, 19, null },
                    { new Guid("9a5e1f52-8c39-4343-a451-4de38417b7d5"), 0, 31, null },
                    { new Guid("a78c0431-c988-4ea3-af9e-844cfc59610c"), 0, 17, null },
                    { new Guid("c21cce6d-9149-46f3-af8b-57eefad88884"), 0, 37, null },
                    { new Guid("c91c3439-a33d-4f5f-a670-34f63b56a34c"), 0, 14, null },
                    { new Guid("cc802ebd-6d1b-4974-8c77-7f248114ac87"), 0, 10, null },
                    { new Guid("cccc9a71-fa97-473a-9bc2-a78069200a1f"), 0, 11, null }
                });

            migrationBuilder.InsertData(
                table: "Lockers",
                columns: new[] { "Id", "LockerAvailability", "LockerNumber", "UserId" },
                values: new object[,]
                {
                    { new Guid("cebf0ceb-234b-4ec7-ac8d-4d2be0d250ee"), 0, 4, null },
                    { new Guid("cfc89abc-382b-4dd8-a9a0-f4d6582a43a6"), 0, 20, null },
                    { new Guid("d39ae9a9-75a4-4ebb-b598-76c8fba5c849"), 0, 13, null },
                    { new Guid("d3c0ee36-0f16-43b2-a055-2346ca93194b"), 0, 39, null },
                    { new Guid("d95cf5cd-8209-4363-ae7b-50ee6ee52037"), 0, 29, null },
                    { new Guid("dd7b9fad-ac0e-43a1-a8cb-0f7231eb2e6a"), 0, 8, null },
                    { new Guid("df892d0d-0168-4324-b786-741999085855"), 0, 16, null },
                    { new Guid("e4c57e18-583c-465b-8718-fdf516f1e1a8"), 0, 30, null },
                    { new Guid("f8b285ac-bbbf-49e9-b92e-10cbc89ec4f6"), 0, 26, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GymMembers_LockerId",
                table: "GymMembers",
                column: "LockerId");

            migrationBuilder.CreateIndex(
                name: "IX_GymMembers_MembershipPlanId",
                table: "GymMembers",
                column: "MembershipPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_GymMembers_UserId",
                table: "GymMembers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffMembers_UserId",
                table: "StaffMembers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceRecords_GymMembers_UserId",
                table: "AttendanceRecords",
                column: "UserId",
                principalTable: "GymMembers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lockers_GymMembers_UserId",
                table: "Lockers",
                column: "UserId",
                principalTable: "GymMembers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendanceRecords_GymMembers_UserId",
                table: "AttendanceRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_Lockers_GymMembers_UserId",
                table: "Lockers");

            migrationBuilder.DropTable(
                name: "GymMembers");

            migrationBuilder.DropTable(
                name: "StaffMembers");

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("0208f1d4-f23d-4cc0-8cdb-4f99341a8ea0"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("0b1f9577-3581-4780-9ecd-b0b7cc435b1d"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("0da77b49-e8b1-4d7a-9796-b6cf6a39f2de"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("362185d6-6f79-4915-8cc7-bb438cc5b304"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("3b6b255e-6369-4ae1-8561-08d6290e582c"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("3c999c5d-dea3-455e-9339-7a6e5b223305"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("436fdc0c-b3f1-4e37-bd2f-51727802cde9"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("48deb5d8-63cd-4ef2-92d9-4525ee20490b"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("4dd634e9-5a53-4e75-bad3-d135b5fdfe18"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("50a58c8e-8498-4c59-bf6d-6f61ddadc3d0"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("56005975-3403-4a57-82f4-6fdba9a6638c"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("5cfbd55d-8312-4870-ba47-50027b14f09f"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("5fb05bed-26c7-42d5-9996-46bbb5172240"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("61356f65-0175-4dd4-bb14-65fb0edb853c"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("76a2a7a8-672e-4914-bffe-d52d3a9ed30f"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("7b52ce62-349b-4b10-bda9-5ce83fe85c53"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("80e89163-f3da-4570-a711-dca045f31512"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("835263a5-3b33-4794-aea7-60081c07db88"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("88383e7e-4acb-47c5-9fcf-32a09f63b53f"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("890b7d4d-77a7-4ba4-850f-439174091df4"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("9540fe5f-829c-4a58-9577-50d3897ece96"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("95c5ed87-771e-4e56-b5cb-c75096dc1eac"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("9851975e-7243-4801-997e-d8c5aaf2cb98"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("992c1c7c-4fc2-4024-ae30-a560439e94db"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("9a1293f7-a094-48d0-a7a7-dc9f03f0a855"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("9a5e1f52-8c39-4343-a451-4de38417b7d5"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("a78c0431-c988-4ea3-af9e-844cfc59610c"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("c21cce6d-9149-46f3-af8b-57eefad88884"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("c91c3439-a33d-4f5f-a670-34f63b56a34c"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("cc802ebd-6d1b-4974-8c77-7f248114ac87"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("cccc9a71-fa97-473a-9bc2-a78069200a1f"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("cebf0ceb-234b-4ec7-ac8d-4d2be0d250ee"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("cfc89abc-382b-4dd8-a9a0-f4d6582a43a6"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("d39ae9a9-75a4-4ebb-b598-76c8fba5c849"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("d3c0ee36-0f16-43b2-a055-2346ca93194b"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("d95cf5cd-8209-4363-ae7b-50ee6ee52037"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("dd7b9fad-ac0e-43a1-a8cb-0f7231eb2e6a"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("df892d0d-0168-4324-b786-741999085855"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("e4c57e18-583c-465b-8718-fdf516f1e1a8"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("f8b285ac-bbbf-49e9-b92e-10cbc89ec4f6"));

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "nvarchar(17)",
                maxLength: 17,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldDefaultValue: "LastNameTest");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldDefaultValue: "FirstNameTest");

            migrationBuilder.AddColumn<DateTime>(
                name: "ContractEndDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ContractStartDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "LockerId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "MembershipEndDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MembershipPlanId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "MembershipStartDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MembershipStatus",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Salary",
                table: "AspNetUsers",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 3, 28, 13, 8, 43, 870, DateTimeKind.Utc).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 3, 28, 13, 8, 43, 870, DateTimeKind.Utc).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 3, 28, 13, 8, 43, 870, DateTimeKind.Utc).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 3, 28, 13, 8, 43, 870, DateTimeKind.Utc).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 3, 28, 13, 8, 43, 870, DateTimeKind.Utc).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 3, 28, 13, 8, 43, 870, DateTimeKind.Utc).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 3, 28, 13, 8, 43, 870, DateTimeKind.Utc).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 3, 28, 13, 8, 43, 870, DateTimeKind.Utc).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 3, 28, 13, 8, 43, 870, DateTimeKind.Utc).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 3, 28, 13, 8, 43, 870, DateTimeKind.Utc).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 3, 28, 13, 8, 43, 870, DateTimeKind.Utc).AddTicks(6458));

            migrationBuilder.InsertData(
                table: "Lockers",
                columns: new[] { "Id", "LockerAvailability", "LockerNumber", "UserId" },
                values: new object[,]
                {
                    { new Guid("0290304e-a997-4afa-b58f-9c740f85d853"), 0, 18, null },
                    { new Guid("058bab11-a8b9-4d89-b5b8-a5304736bd2b"), 0, 8, null },
                    { new Guid("09d9def9-9b03-4a08-8596-56916a6e52b9"), 0, 19, null },
                    { new Guid("0df32034-4715-4ebc-b1e1-0006d2ac8c12"), 0, 21, null },
                    { new Guid("12a84579-87aa-4d71-be86-9c8f928c72d3"), 0, 10, null },
                    { new Guid("13d7a001-0342-4512-8b05-8cab47af4789"), 0, 12, null },
                    { new Guid("141478b9-6d9a-47ef-9e73-cc5d13d36f77"), 0, 28, null },
                    { new Guid("15b28570-f7df-4b73-886a-fd3a5d91b47a"), 0, 3, null },
                    { new Guid("200377f2-5e0e-408b-8d6d-7855198ea566"), 0, 9, null },
                    { new Guid("2c9e99dc-814a-473b-8278-96abd469baaa"), 0, 14, null },
                    { new Guid("378d833d-b297-4440-8e46-41f62bf67f92"), 0, 27, null },
                    { new Guid("47fa8608-1905-45c6-adec-81c8d6bf82a0"), 0, 15, null },
                    { new Guid("51185d16-c0d0-4d75-82d2-c7500e0761d6"), 0, 29, null },
                    { new Guid("562ccd4f-d6b9-4930-825d-ef7934514257"), 0, 4, null },
                    { new Guid("584f10c6-5e0c-43ce-9639-b86dbf4ae07b"), 0, 2, null },
                    { new Guid("850baba5-4986-428d-b64b-15c59f4d36db"), 0, 30, null },
                    { new Guid("8b4c163b-26a2-47b2-8b5f-5824ebc997e5"), 0, 32, null },
                    { new Guid("9519b93c-ac90-47b0-8146-5157564fe669"), 0, 35, null },
                    { new Guid("99c3d180-5789-43dc-a2f4-5a6b92ff1166"), 0, 40, null },
                    { new Guid("b32dd821-5612-4f44-90ef-7da4089f49d7"), 0, 36, null },
                    { new Guid("b735e9f2-decb-4718-8b83-b11a555b6622"), 0, 22, null },
                    { new Guid("beba2d85-0108-448d-8b0f-ca7794c8af84"), 0, 26, null },
                    { new Guid("bec0ab6d-fdc9-49bc-bee5-b16dec305103"), 0, 23, null },
                    { new Guid("bf24b703-3a35-4b3a-b0ac-7604f2ebe1ff"), 0, 17, null },
                    { new Guid("bf9f8efe-a54f-49f8-b5c3-1a17263b572f"), 0, 6, null },
                    { new Guid("c261d42c-56b7-4423-9597-ec2f2251fe4d"), 0, 7, null },
                    { new Guid("c6978dc8-9344-494f-9a55-87096bd25764"), 0, 31, null },
                    { new Guid("c71b53b9-9de4-419d-a721-a75e4eada89c"), 0, 16, null },
                    { new Guid("c8b14c89-54f8-4b0c-8be6-fe1c9c85ea95"), 0, 20, null },
                    { new Guid("ca7cb33e-2700-4b73-88e5-2672a1b773a7"), 0, 13, null },
                    { new Guid("cef4acc9-0607-4954-9b3f-b073afd3901b"), 0, 38, null }
                });

            migrationBuilder.InsertData(
                table: "Lockers",
                columns: new[] { "Id", "LockerAvailability", "LockerNumber", "UserId" },
                values: new object[,]
                {
                    { new Guid("cf72ab2f-b202-42e0-9f8e-b740a5e1d6ef"), 0, 34, null },
                    { new Guid("d84190cc-6621-4918-8d36-e4f4fe8dbf83"), 0, 1, null },
                    { new Guid("d98d1c61-1fbb-4140-8413-103f45a6b35a"), 0, 25, null },
                    { new Guid("e1b9a76c-dd51-4453-9e4c-8a99274b4a3b"), 0, 37, null },
                    { new Guid("e5314789-3f38-430a-a3ad-b7e14e635b7c"), 0, 24, null },
                    { new Guid("fad12282-808f-4ab2-978e-d9756c3b4af5"), 0, 39, null },
                    { new Guid("fafeb225-b139-4849-83ce-5b5a41864773"), 0, 33, null },
                    { new Guid("fd5b50c9-8ece-4dfb-a610-4a23d6ff4c57"), 0, 11, null },
                    { new Guid("fe40ee1d-5ec4-4425-a2b3-940b2338183f"), 0, 5, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_LockerId",
                table: "AspNetUsers",
                column: "LockerId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_MembershipPlanId",
                table: "AspNetUsers",
                column: "MembershipPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Lockers_LockerId",
                table: "AspNetUsers",
                column: "LockerId",
                principalTable: "Lockers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_MembershipPlans_MembershipPlanId",
                table: "AspNetUsers",
                column: "MembershipPlanId",
                principalTable: "MembershipPlans",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceRecords_AspNetUsers_UserId",
                table: "AttendanceRecords",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lockers_AspNetUsers_UserId",
                table: "Lockers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
