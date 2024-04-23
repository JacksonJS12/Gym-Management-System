using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManagementSystem.Data.Migrations
{
    public partial class TemporaryRemoveFirstAndLastName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("0199ca6c-38f8-4be0-a883-81d70bf77f26"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("1418dc25-996c-48fe-8d54-db94b8abc38f"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("1dc98aa4-d574-4107-b5a5-302bc3b8c530"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("1fc555df-b2ef-4ebf-9b06-92adbd81f301"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("20c35eb3-68d8-4f43-a3a0-a9656fb16a07"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("22b364a3-6c98-4826-87b9-675ed6c01ef0"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("2ba317e4-d72c-4bf4-9bb9-145aeaf37ae9"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("30fe4de7-9c8d-4a26-9a1f-5c39156a8293"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("38d4de23-00c8-4293-a546-76f9e685435a"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("3b7012ac-04fe-47b7-aa0a-4cb369a6f578"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("3ed793fd-ef0d-4363-bece-6568440054a5"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("3f48c364-a5bf-4570-b8c7-e1fdd6aa4bf9"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("423a19ec-d918-4392-bc08-71374e4ec8d2"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("4f8e976f-0343-45d6-808c-86bff11af2d6"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("64d0ae47-3497-4a11-a287-9b41b4a49022"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("79280c26-f828-4b27-b4b2-f1402e234f8b"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("7e370b63-6fce-4b82-8fe8-f72801d3b449"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("84ef312a-efd8-43f5-9ee0-ce66fab19e79"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("8744fe21-0802-407c-b22c-1ac7afeda078"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("880ed20f-ce84-4540-90a1-a6c8a69ca044"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("8afc3296-6698-490e-9517-9f858f1ed76c"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("9ca4bf01-e20f-42a3-b74d-84eacbdee95c"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("a1f72f93-4292-421c-ab84-9f2366289925"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("aa57663a-d319-48b3-a183-b3d6a66eef27"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("aad58612-fd80-4bb6-bbf0-d068ce12f320"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("ba1b5d6c-2119-422f-974d-65de252e35fd"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("c1a044e6-ffc7-48c6-9708-6ef1c66add55"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("c728e1f2-0a50-451a-bc97-d596293ae16f"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("c89f9de0-8c76-450c-bac5-41aa060e4ef1"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("c91a4fa5-6fb7-40c9-9479-b0381ff7b091"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("ce7e3e57-51c9-4f00-afab-ed98782b754d"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("ceea4242-21c2-47cd-836a-0e7ad9420353"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("cf0b0a4e-77c0-4cfc-a711-6542a2c68212"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("cf737824-5cda-41ae-a70b-88f83699cdb1"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("d3fe4d86-292a-448e-902e-2caab8419a44"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("dee3fb9b-bddc-49d9-a5e9-ae6396e8d94e"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("e5277c56-7440-416c-916a-36deb32ea909"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("f27d4e03-f7ce-4d7d-afc2-4e4859463745"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("f5c73b22-72bd-4e16-88b4-e155bd121b3c"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("fab050f0-661a-4371-9358-653b610ff38c"));

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 12, 20, 2, 197, DateTimeKind.Utc).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 12, 20, 2, 197, DateTimeKind.Utc).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 12, 20, 2, 197, DateTimeKind.Utc).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 12, 20, 2, 197, DateTimeKind.Utc).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 12, 20, 2, 197, DateTimeKind.Utc).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 12, 20, 2, 197, DateTimeKind.Utc).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 12, 20, 2, 197, DateTimeKind.Utc).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 12, 20, 2, 197, DateTimeKind.Utc).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 12, 20, 2, 197, DateTimeKind.Utc).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 12, 20, 2, 197, DateTimeKind.Utc).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 12, 20, 2, 197, DateTimeKind.Utc).AddTicks(3032));

            migrationBuilder.InsertData(
                table: "Lockers",
                columns: new[] { "Id", "LockerAvailability", "LockerNumber" },
                values: new object[,]
                {
                    { new Guid("00d70c8e-dff1-4534-a13f-7dc2c5c35145"), 0, 15 },
                    { new Guid("039f420a-a18e-4fcd-b989-5e69c5db0eb0"), 0, 21 },
                    { new Guid("0cdeb6f6-9f51-4753-97a9-9c3dc64524f7"), 0, 28 },
                    { new Guid("101924c1-d772-4664-84c4-726783909fcd"), 0, 6 },
                    { new Guid("19d3dac8-fbd0-4075-bda5-3db6f25e5ac8"), 0, 16 },
                    { new Guid("1ca9dbc0-958d-4c35-9e1b-bef616397e8c"), 0, 33 },
                    { new Guid("23896955-e18e-4d39-aec8-3aac72abf78c"), 0, 18 },
                    { new Guid("2791a8aa-bece-4947-91b3-0095e12e397a"), 0, 40 },
                    { new Guid("288d55b7-6d30-4f8c-a56b-3beb8189495d"), 0, 22 },
                    { new Guid("29748b78-c868-41af-8270-977420ea4b71"), 0, 7 },
                    { new Guid("38f5ca68-e832-4f69-98a9-505932b3b6d2"), 0, 31 },
                    { new Guid("3e947dfb-3ecd-4a9c-9c55-c5f182354a34"), 0, 19 },
                    { new Guid("3f4f7e24-3210-42c9-9c9f-a5b1c7a8f9ca"), 0, 5 },
                    { new Guid("464a6204-4b09-435e-a02e-7d4fc6b551a3"), 0, 9 },
                    { new Guid("4703821a-769b-4136-ba7f-47c533a12384"), 0, 29 },
                    { new Guid("54585905-4be0-49d2-8fbd-f4e46a0e99dd"), 0, 26 },
                    { new Guid("58f190bb-fe65-46ba-843c-429e96f26dfc"), 0, 20 },
                    { new Guid("59bb83db-ea74-40a9-bd2f-6e8dfcd1ffc5"), 0, 34 },
                    { new Guid("5a738d80-efcd-4df4-a6c4-2b0c1421951d"), 0, 27 },
                    { new Guid("60b6cc6b-33cc-4f9c-8964-03a2b962273d"), 0, 1 },
                    { new Guid("63abd27b-4ebc-4593-9134-534d666499db"), 0, 24 },
                    { new Guid("6a11b806-59e1-48c2-80db-e1bbd79b15d3"), 0, 11 },
                    { new Guid("6dd443cd-f86a-49fa-aac6-22fac46c6a76"), 0, 10 },
                    { new Guid("7573edc1-e5ab-48e7-bb21-a7aa5d3d8f13"), 0, 37 },
                    { new Guid("79555c8c-9bf7-4030-9c53-65a77c1b834b"), 0, 38 },
                    { new Guid("8c0d91ee-7b74-40f4-a4bc-4e83a06d0fff"), 0, 2 },
                    { new Guid("926af221-3713-4ca3-a24c-4683cdd67ee8"), 0, 14 },
                    { new Guid("9c1dcab8-0d8e-4843-ad0e-738145c6d25b"), 0, 36 },
                    { new Guid("a3f199d2-6cee-4d8a-aa64-93df0767e793"), 0, 4 },
                    { new Guid("a727c60c-ef8b-4d3d-9df7-81e6ce1cae03"), 0, 17 },
                    { new Guid("a91a30fa-8555-454c-962b-531fa51ae005"), 0, 23 }
                });

            migrationBuilder.InsertData(
                table: "Lockers",
                columns: new[] { "Id", "LockerAvailability", "LockerNumber" },
                values: new object[,]
                {
                    { new Guid("b0268371-fd6f-49a2-9961-b22409c9a7a1"), 0, 32 },
                    { new Guid("bdefd8a2-e281-42aa-ace7-da7a781d7669"), 0, 30 },
                    { new Guid("bf213a83-383e-4ecd-a8db-d504d1d0facd"), 0, 3 },
                    { new Guid("c7994d33-da68-44be-98df-2050acd582ee"), 0, 39 },
                    { new Guid("ce6fe867-05dd-46dd-9eda-9a776e3f372c"), 0, 35 },
                    { new Guid("d9b49f77-bb71-4fd9-aee8-19629ed2643a"), 0, 12 },
                    { new Guid("e9d0f70d-2c3c-4a74-93b8-9ec3849dd529"), 0, 25 },
                    { new Guid("eaf83d06-cc0d-4b0f-9b13-865af20910d8"), 0, 13 },
                    { new Guid("f7a1112c-665b-4524-979e-cb9ec6f17d90"), 0, 8 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("00d70c8e-dff1-4534-a13f-7dc2c5c35145"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("039f420a-a18e-4fcd-b989-5e69c5db0eb0"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("0cdeb6f6-9f51-4753-97a9-9c3dc64524f7"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("101924c1-d772-4664-84c4-726783909fcd"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("19d3dac8-fbd0-4075-bda5-3db6f25e5ac8"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("1ca9dbc0-958d-4c35-9e1b-bef616397e8c"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("23896955-e18e-4d39-aec8-3aac72abf78c"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("2791a8aa-bece-4947-91b3-0095e12e397a"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("288d55b7-6d30-4f8c-a56b-3beb8189495d"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("29748b78-c868-41af-8270-977420ea4b71"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("38f5ca68-e832-4f69-98a9-505932b3b6d2"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("3e947dfb-3ecd-4a9c-9c55-c5f182354a34"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("3f4f7e24-3210-42c9-9c9f-a5b1c7a8f9ca"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("464a6204-4b09-435e-a02e-7d4fc6b551a3"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("4703821a-769b-4136-ba7f-47c533a12384"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("54585905-4be0-49d2-8fbd-f4e46a0e99dd"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("58f190bb-fe65-46ba-843c-429e96f26dfc"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("59bb83db-ea74-40a9-bd2f-6e8dfcd1ffc5"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("5a738d80-efcd-4df4-a6c4-2b0c1421951d"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("60b6cc6b-33cc-4f9c-8964-03a2b962273d"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("63abd27b-4ebc-4593-9134-534d666499db"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("6a11b806-59e1-48c2-80db-e1bbd79b15d3"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("6dd443cd-f86a-49fa-aac6-22fac46c6a76"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("7573edc1-e5ab-48e7-bb21-a7aa5d3d8f13"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("79555c8c-9bf7-4030-9c53-65a77c1b834b"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("8c0d91ee-7b74-40f4-a4bc-4e83a06d0fff"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("926af221-3713-4ca3-a24c-4683cdd67ee8"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("9c1dcab8-0d8e-4843-ad0e-738145c6d25b"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("a3f199d2-6cee-4d8a-aa64-93df0767e793"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("a727c60c-ef8b-4d3d-9df7-81e6ce1cae03"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("a91a30fa-8555-454c-962b-531fa51ae005"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("b0268371-fd6f-49a2-9961-b22409c9a7a1"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("bdefd8a2-e281-42aa-ace7-da7a781d7669"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("bf213a83-383e-4ecd-a8db-d504d1d0facd"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("c7994d33-da68-44be-98df-2050acd582ee"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("ce6fe867-05dd-46dd-9eda-9a776e3f372c"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("d9b49f77-bb71-4fd9-aee8-19629ed2643a"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("e9d0f70d-2c3c-4a74-93b8-9ec3849dd529"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("eaf83d06-cc0d-4b0f-9b13-865af20910d8"));

            migrationBuilder.DeleteData(
                table: "Lockers",
                keyColumn: "Id",
                keyValue: new Guid("f7a1112c-665b-4524-979e-cb9ec6f17d90"));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "FirstNameTest");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "LastNameTest");

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 39, 28, 997, DateTimeKind.Utc).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 39, 28, 997, DateTimeKind.Utc).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 39, 28, 997, DateTimeKind.Utc).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 39, 28, 997, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 39, 28, 997, DateTimeKind.Utc).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 39, 28, 997, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 39, 28, 997, DateTimeKind.Utc).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 39, 28, 997, DateTimeKind.Utc).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 39, 28, 997, DateTimeKind.Utc).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 39, 28, 997, DateTimeKind.Utc).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "GymEquipment",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastMaintenanceDate",
                value: new DateTime(2024, 4, 23, 0, 39, 28, 997, DateTimeKind.Utc).AddTicks(5046));

            migrationBuilder.InsertData(
                table: "Lockers",
                columns: new[] { "Id", "LockerAvailability", "LockerNumber" },
                values: new object[,]
                {
                    { new Guid("0199ca6c-38f8-4be0-a883-81d70bf77f26"), 0, 3 },
                    { new Guid("1418dc25-996c-48fe-8d54-db94b8abc38f"), 0, 40 },
                    { new Guid("1dc98aa4-d574-4107-b5a5-302bc3b8c530"), 0, 5 },
                    { new Guid("1fc555df-b2ef-4ebf-9b06-92adbd81f301"), 0, 10 },
                    { new Guid("20c35eb3-68d8-4f43-a3a0-a9656fb16a07"), 0, 14 },
                    { new Guid("22b364a3-6c98-4826-87b9-675ed6c01ef0"), 0, 4 },
                    { new Guid("2ba317e4-d72c-4bf4-9bb9-145aeaf37ae9"), 0, 39 },
                    { new Guid("30fe4de7-9c8d-4a26-9a1f-5c39156a8293"), 0, 38 },
                    { new Guid("38d4de23-00c8-4293-a546-76f9e685435a"), 0, 24 },
                    { new Guid("3b7012ac-04fe-47b7-aa0a-4cb369a6f578"), 0, 2 },
                    { new Guid("3ed793fd-ef0d-4363-bece-6568440054a5"), 0, 27 },
                    { new Guid("3f48c364-a5bf-4570-b8c7-e1fdd6aa4bf9"), 0, 36 },
                    { new Guid("423a19ec-d918-4392-bc08-71374e4ec8d2"), 0, 7 },
                    { new Guid("4f8e976f-0343-45d6-808c-86bff11af2d6"), 0, 23 },
                    { new Guid("64d0ae47-3497-4a11-a287-9b41b4a49022"), 0, 37 },
                    { new Guid("79280c26-f828-4b27-b4b2-f1402e234f8b"), 0, 8 },
                    { new Guid("7e370b63-6fce-4b82-8fe8-f72801d3b449"), 0, 6 },
                    { new Guid("84ef312a-efd8-43f5-9ee0-ce66fab19e79"), 0, 17 },
                    { new Guid("8744fe21-0802-407c-b22c-1ac7afeda078"), 0, 28 },
                    { new Guid("880ed20f-ce84-4540-90a1-a6c8a69ca044"), 0, 25 },
                    { new Guid("8afc3296-6698-490e-9517-9f858f1ed76c"), 0, 26 },
                    { new Guid("9ca4bf01-e20f-42a3-b74d-84eacbdee95c"), 0, 34 },
                    { new Guid("a1f72f93-4292-421c-ab84-9f2366289925"), 0, 12 },
                    { new Guid("aa57663a-d319-48b3-a183-b3d6a66eef27"), 0, 29 },
                    { new Guid("aad58612-fd80-4bb6-bbf0-d068ce12f320"), 0, 18 },
                    { new Guid("ba1b5d6c-2119-422f-974d-65de252e35fd"), 0, 33 },
                    { new Guid("c1a044e6-ffc7-48c6-9708-6ef1c66add55"), 0, 21 },
                    { new Guid("c728e1f2-0a50-451a-bc97-d596293ae16f"), 0, 35 },
                    { new Guid("c89f9de0-8c76-450c-bac5-41aa060e4ef1"), 0, 31 },
                    { new Guid("c91a4fa5-6fb7-40c9-9479-b0381ff7b091"), 0, 11 },
                    { new Guid("ce7e3e57-51c9-4f00-afab-ed98782b754d"), 0, 19 }
                });

            migrationBuilder.InsertData(
                table: "Lockers",
                columns: new[] { "Id", "LockerAvailability", "LockerNumber" },
                values: new object[,]
                {
                    { new Guid("ceea4242-21c2-47cd-836a-0e7ad9420353"), 0, 16 },
                    { new Guid("cf0b0a4e-77c0-4cfc-a711-6542a2c68212"), 0, 9 },
                    { new Guid("cf737824-5cda-41ae-a70b-88f83699cdb1"), 0, 1 },
                    { new Guid("d3fe4d86-292a-448e-902e-2caab8419a44"), 0, 13 },
                    { new Guid("dee3fb9b-bddc-49d9-a5e9-ae6396e8d94e"), 0, 15 },
                    { new Guid("e5277c56-7440-416c-916a-36deb32ea909"), 0, 30 },
                    { new Guid("f27d4e03-f7ce-4d7d-afc2-4e4859463745"), 0, 20 },
                    { new Guid("f5c73b22-72bd-4e16-88b4-e155bd121b3c"), 0, 32 },
                    { new Guid("fab050f0-661a-4371-9358-653b610ff38c"), 0, 22 }
                });
        }
    }
}
