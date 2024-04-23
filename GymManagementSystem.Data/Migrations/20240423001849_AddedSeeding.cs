using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManagementSystem.Data.Migrations
{
    public partial class AddedSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                WITH CTE AS (
                    SELECT *,
                           ROW_NUMBER() OVER (PARTITION BY LockerNumber ORDER BY (SELECT NULL)) AS RowNumber
                    FROM Lockers
                )
                DELETE FROM CTE WHERE RowNumber > 1;
            ");
            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("0891db7f-141a-4664-a608-134f93782f41"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("0a524c60-6d05-4e15-a000-ba5627f53688"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("0c4b72e9-05fd-4e37-8f5f-7790fe3df3ad"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("19c4f11e-2079-4fb1-b613-7821f462e3cd"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("26917a9f-423a-4f7e-9cdb-892d057b0210"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("2b310054-cf8e-45d2-b6bf-2dd34a294318"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("2e76e4d1-2b93-46c0-96c6-5c21c726041e"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("2f1de22e-33ff-44e8-9d6f-676de1e22751"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("39f464e7-3e04-4575-82cc-35e61190f7dd"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("3aa981e6-5d66-4447-881e-c12d758f3cc6"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("3c9a3d99-f060-44da-abb6-89a8e0f19d4a"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("41e83387-a649-449d-b687-95ad825c6085"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("4380a55d-1831-48d0-b7b5-f015b35050c0"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("45e835fe-6b5f-408c-a02c-40e794e62cf3"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("4d078924-d049-418d-b2db-fc0f2ae8c946"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("5713fe2b-b790-4448-a680-7a2c5ee800b3"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("5ab3a632-d141-4d93-a255-9ba6c532a55b"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("6c653950-abab-4ed7-a982-3989919f3b93"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("725d501e-3f01-4a68-aa3e-f145c1f72b48"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("7ea21d68-4e27-48f1-93b8-c7577d88f404"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("80a13368-92e9-4ed9-8a85-c529e48957cd"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("8d108f0e-c5a0-4df6-af90-70fc3cd5f05f"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("9e81d2fc-bb11-4274-a84f-397d678ddfe1"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("9ef554c0-f195-4620-a5ae-7fea68146ef7"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("a389c9cb-0de8-4747-a3b3-98cecaafd0e4"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("a916c50e-6c3a-440e-80ef-25f78cb6ab07"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("bb44e588-2131-4de1-b146-2bc456896de9"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("bcce03a8-cd45-481c-864f-1a315468a4d5"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("d453d22f-c733-4059-ac10-37f990af34fd"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("d57f8c5a-4600-4e57-80b2-77591f058273"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("d933c8b3-d926-4962-9bc7-61c8af65ef42"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("d9be7e9f-71c0-40ba-8d63-072a75f69ae0"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("da68f24d-62f2-4451-8d6f-b7afea36aa5d"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("dc2c0bc8-46b1-42ff-ad9c-7cc13a76422f"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("e18051cb-ec8d-4a40-bf62-9703f057620d"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("eda9026b-2413-456c-aa00-dd8f1eb860fe"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("f7264519-71a9-45f4-8116-0f8e339c13ca"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("fa96f69d-bef6-4cf2-8afc-010c5a5cf6f8"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("fb205fe7-38ee-495b-a454-69aa667f9f58"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("fe6fba44-d61a-4d00-9b03-d5782287efeb"));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 18, 49, 212, DateTimeKind.Utc).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 18, 49, 212, DateTimeKind.Utc).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 18, 49, 212, DateTimeKind.Utc).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 18, 49, 212, DateTimeKind.Utc).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 18, 49, 212, DateTimeKind.Utc).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 18, 49, 212, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 18, 49, 212, DateTimeKind.Utc).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 18, 49, 212, DateTimeKind.Utc).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 18, 49, 212, DateTimeKind.Utc).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 18, 49, 212, DateTimeKind.Utc).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 18, 49, 212, DateTimeKind.Utc).AddTicks(3625));

            migrationBuilder.InsertData(
                table: "Lockers",
                columns: new[] { "Id", "LockerAvailability", "LockerNumber" },
                values: new object[,]
                {
                    { new Guid("0968d739-9c3d-46b1-bd8c-2470444d8950"), 0, 1 },
                    { new Guid("0c053f06-5b61-4bba-bb97-4485cc4b975c"), 0, 3 },
                    { new Guid("1b081b43-1e67-4e13-aaf2-4238a816c5e2"), 0, 18 },
                    { new Guid("1b637f53-d552-4a0b-8e50-27ccf21bc146"), 0, 31 },
                    { new Guid("28207c26-f473-4b48-8cda-c2d77ae2a9f1"), 0, 40 },
                    { new Guid("2a7702ed-56fa-44c4-84eb-f39a81fe1e09"), 0, 23 },
                    { new Guid("33bbe74a-52cc-4847-a92b-37df8efa0cd7"), 0, 17 },
                    { new Guid("345e6338-17d5-47b3-acc0-8e7ac557d384"), 0, 33 },
                    { new Guid("41323e67-84ca-406d-9c1b-97890ceaf087"), 0, 29 },
                    { new Guid("49d835f7-2613-48af-b592-5805300ca61b"), 0, 35 },
                    { new Guid("51261585-d557-44b4-ad8b-0edb2d3a468a"), 0, 22 },
                    { new Guid("5f8cfce4-13f9-4972-86b5-198042e53ee7"), 0, 38 },
                    { new Guid("618ab511-1ab5-4e10-a1f1-7643f187b253"), 0, 14 },
                    { new Guid("64799168-f3f4-430a-9e90-418f18be92d2"), 0, 25 },
                    { new Guid("66b6fb81-0cfa-40f3-94d4-48e2e786f515"), 0, 30 },
                    { new Guid("730f08a6-d253-4f47-9589-734e9deebbce"), 0, 24 },
                    { new Guid("76915a22-1f30-4896-a45c-fbb4c1ced425"), 0, 13 },
                    { new Guid("779b87cd-a54b-44ec-94dd-1d7897b141b7"), 0, 27 },
                    { new Guid("7e865010-b199-436e-92fb-0cd26401eef7"), 0, 19 },
                    { new Guid("80b957be-fa27-441c-8013-0768fe3e8392"), 0, 10 },
                    { new Guid("87d02bd3-cf1e-4341-90d6-ba9ec3a8ca4d"), 0, 28 },
                    { new Guid("8c96ce82-d1f1-41bf-a16c-aefff92de011"), 0, 5 },
                    { new Guid("8d2dc698-d895-4659-918b-c3b2997c9e03"), 0, 36 },
                    { new Guid("8d705de6-1aa7-43f1-b5a7-37302f412cb6"), 0, 4 },
                    { new Guid("9a18e20d-920e-4583-a58c-90510823e8bc"), 0, 8 },
                    { new Guid("ae12195d-32a5-448d-bf35-17a5c63dbfc3"), 0, 39 },
                    { new Guid("b137ebf1-33a8-4779-8739-eb9563c8c3a8"), 0, 21 },
                    { new Guid("b626d899-c684-47d0-9fda-f90cd012a7af"), 0, 9 },
                    { new Guid("b684b7fc-077b-43d1-ba38-90ea7bc9dc2c"), 0, 37 },
                    { new Guid("b7c42c16-80c5-4f18-8b72-1d0ad25edcb2"), 0, 11 },
                    { new Guid("c68b7406-df1e-491e-8932-440773c3aa81"), 0, 26 }
                });

            migrationBuilder.InsertData(
                table: "Lockers",
                columns: new[] { "Id", "LockerAvailability", "LockerNumber" },
                values: new object[,]
                {
                    { new Guid("c7a59375-0a4f-4120-99d2-8d007f7bf758"), 0, 16 },
                    { new Guid("d554ab9d-25df-4579-a4ad-8e7c133a314c"), 0, 2 },
                    { new Guid("d754a7e8-39f1-429e-9784-55e24a66d56c"), 0, 6 },
                    { new Guid("da7b5918-4587-40b7-82a9-0efdb3105a94"), 0, 7 },
                    { new Guid("debc5540-7773-4e16-9683-a51c50e98a16"), 0, 32 },
                    { new Guid("e5f18ef4-11c1-4bca-bc0e-68c7895107e8"), 0, 15 },
                    { new Guid("eb97ffad-eaf8-4f5a-bbb0-015702082463"), 0, 34 },
                    { new Guid("ec48d862-c1f3-41bb-8c0e-aec520e3c72e"), 0, 12 },
                    { new Guid("f251df7e-8d7c-455a-9013-9810be984882"), 0, 20 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("0968d739-9c3d-46b1-bd8c-2470444d8950"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("0c053f06-5b61-4bba-bb97-4485cc4b975c"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("1b081b43-1e67-4e13-aaf2-4238a816c5e2"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("1b637f53-d552-4a0b-8e50-27ccf21bc146"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("28207c26-f473-4b48-8cda-c2d77ae2a9f1"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("2a7702ed-56fa-44c4-84eb-f39a81fe1e09"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("33bbe74a-52cc-4847-a92b-37df8efa0cd7"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("345e6338-17d5-47b3-acc0-8e7ac557d384"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("41323e67-84ca-406d-9c1b-97890ceaf087"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("49d835f7-2613-48af-b592-5805300ca61b"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("51261585-d557-44b4-ad8b-0edb2d3a468a"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("5f8cfce4-13f9-4972-86b5-198042e53ee7"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("618ab511-1ab5-4e10-a1f1-7643f187b253"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("64799168-f3f4-430a-9e90-418f18be92d2"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("66b6fb81-0cfa-40f3-94d4-48e2e786f515"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("730f08a6-d253-4f47-9589-734e9deebbce"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("76915a22-1f30-4896-a45c-fbb4c1ced425"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("779b87cd-a54b-44ec-94dd-1d7897b141b7"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("7e865010-b199-436e-92fb-0cd26401eef7"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("80b957be-fa27-441c-8013-0768fe3e8392"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("87d02bd3-cf1e-4341-90d6-ba9ec3a8ca4d"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("8c96ce82-d1f1-41bf-a16c-aefff92de011"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("8d2dc698-d895-4659-918b-c3b2997c9e03"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("8d705de6-1aa7-43f1-b5a7-37302f412cb6"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("9a18e20d-920e-4583-a58c-90510823e8bc"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("ae12195d-32a5-448d-bf35-17a5c63dbfc3"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("b137ebf1-33a8-4779-8739-eb9563c8c3a8"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("b626d899-c684-47d0-9fda-f90cd012a7af"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("b684b7fc-077b-43d1-ba38-90ea7bc9dc2c"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("b7c42c16-80c5-4f18-8b72-1d0ad25edcb2"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("c68b7406-df1e-491e-8932-440773c3aa81"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("c7a59375-0a4f-4120-99d2-8d007f7bf758"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("d554ab9d-25df-4579-a4ad-8e7c133a314c"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("d754a7e8-39f1-429e-9784-55e24a66d56c"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("da7b5918-4587-40b7-82a9-0efdb3105a94"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("debc5540-7773-4e16-9683-a51c50e98a16"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("e5f18ef4-11c1-4bca-bc0e-68c7895107e8"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("eb97ffad-eaf8-4f5a-bbb0-015702082463"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("ec48d862-c1f3-41bb-8c0e-aec520e3c72e"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("f251df7e-8d7c-455a-9013-9810be984882"));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 11, 34, 118, DateTimeKind.Utc).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 11, 34, 118, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 11, 34, 118, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 11, 34, 118, DateTimeKind.Utc).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 11, 34, 118, DateTimeKind.Utc).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 11, 34, 118, DateTimeKind.Utc).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 11, 34, 118, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 11, 34, 118, DateTimeKind.Utc).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 11, 34, 118, DateTimeKind.Utc).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 11, 34, 118, DateTimeKind.Utc).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 11, 34, 118, DateTimeKind.Utc).AddTicks(8426));

            migrationBuilder.InsertData(
                table: "Lockers",
                columns: new[] { "Id", "LockerAvailability", "LockerNumber" },
                values: new object[,]
                {
                    { new Guid("0891db7f-141a-4664-a608-134f93782f41"), 0, 7 },
                    { new Guid("0a524c60-6d05-4e15-a000-ba5627f53688"), 0, 4 },
                    { new Guid("0c4b72e9-05fd-4e37-8f5f-7790fe3df3ad"), 0, 35 },
                    { new Guid("19c4f11e-2079-4fb1-b613-7821f462e3cd"), 0, 26 },
                    { new Guid("26917a9f-423a-4f7e-9cdb-892d057b0210"), 0, 1 },
                    { new Guid("2b310054-cf8e-45d2-b6bf-2dd34a294318"), 0, 5 },
                    { new Guid("2e76e4d1-2b93-46c0-96c6-5c21c726041e"), 0, 32 },
                    { new Guid("2f1de22e-33ff-44e8-9d6f-676de1e22751"), 0, 17 },
                    { new Guid("39f464e7-3e04-4575-82cc-35e61190f7dd"), 0, 30 },
                    { new Guid("3aa981e6-5d66-4447-881e-c12d758f3cc6"), 0, 2 },
                    { new Guid("3c9a3d99-f060-44da-abb6-89a8e0f19d4a"), 0, 12 },
                    { new Guid("41e83387-a649-449d-b687-95ad825c6085"), 0, 9 },
                    { new Guid("4380a55d-1831-48d0-b7b5-f015b35050c0"), 0, 18 },
                    { new Guid("45e835fe-6b5f-408c-a02c-40e794e62cf3"), 0, 33 },
                    { new Guid("4d078924-d049-418d-b2db-fc0f2ae8c946"), 0, 19 },
                    { new Guid("5713fe2b-b790-4448-a680-7a2c5ee800b3"), 0, 6 },
                    { new Guid("5ab3a632-d141-4d93-a255-9ba6c532a55b"), 0, 22 },
                    { new Guid("6c653950-abab-4ed7-a982-3989919f3b93"), 0, 34 },
                    { new Guid("725d501e-3f01-4a68-aa3e-f145c1f72b48"), 0, 36 },
                    { new Guid("7ea21d68-4e27-48f1-93b8-c7577d88f404"), 0, 11 },
                    { new Guid("80a13368-92e9-4ed9-8a85-c529e48957cd"), 0, 40 },
                    { new Guid("8d108f0e-c5a0-4df6-af90-70fc3cd5f05f"), 0, 14 },
                    { new Guid("9e81d2fc-bb11-4274-a84f-397d678ddfe1"), 0, 10 },
                    { new Guid("9ef554c0-f195-4620-a5ae-7fea68146ef7"), 0, 24 },
                    { new Guid("a389c9cb-0de8-4747-a3b3-98cecaafd0e4"), 0, 38 },
                    { new Guid("a916c50e-6c3a-440e-80ef-25f78cb6ab07"), 0, 28 },
                    { new Guid("bb44e588-2131-4de1-b146-2bc456896de9"), 0, 29 },
                    { new Guid("bcce03a8-cd45-481c-864f-1a315468a4d5"), 0, 25 },
                    { new Guid("d453d22f-c733-4059-ac10-37f990af34fd"), 0, 16 },
                    { new Guid("d57f8c5a-4600-4e57-80b2-77591f058273"), 0, 31 },
                    { new Guid("d933c8b3-d926-4962-9bc7-61c8af65ef42"), 0, 3 }
                });

            migrationBuilder.InsertData(
                table: "Lockers",
                columns: new[] { "Id", "LockerAvailability", "LockerNumber" },
                values: new object[,]
                {
                    { new Guid("d9be7e9f-71c0-40ba-8d63-072a75f69ae0"), 0, 37 },
                    { new Guid("da68f24d-62f2-4451-8d6f-b7afea36aa5d"), 0, 15 },
                    { new Guid("dc2c0bc8-46b1-42ff-ad9c-7cc13a76422f"), 0, 13 },
                    { new Guid("e18051cb-ec8d-4a40-bf62-9703f057620d"), 0, 27 },
                    { new Guid("eda9026b-2413-456c-aa00-dd8f1eb860fe"), 0, 23 },
                    { new Guid("f7264519-71a9-45f4-8116-0f8e339c13ca"), 0, 8 },
                    { new Guid("fa96f69d-bef6-4cf2-8afc-010c5a5cf6f8"), 0, 21 },
                    { new Guid("fb205fe7-38ee-495b-a454-69aa667f9f58"), 0, 20 },
                    { new Guid("fe6fba44-d61a-4d00-9b03-d5782287efeb"), 0, 39 }
                });
        }

    }
}
