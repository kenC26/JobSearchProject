using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearchProject.Server.Data.Migrations
{
    public partial class newdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "2c641c43-585e-474b-9fb7-cd880d8e9008");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "09654a3c-37f7-461d-8ea1-fc6c3fb236ea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0c4a1f5-f75d-49a6-8dea-ab0094d97b69", "AQAAAAEAACcQAAAAEGIIttDtqBAnLnMd6FoCpsP1r3WHOBbzjqoaXZFsgiMqadmrb8tD5DqMmp5kdugURg==", "35c734b5-1ab1-49c0-a4a6-4f0809d41272" });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 16, 4, 43, 149, DateTimeKind.Local).AddTicks(4444), new DateTime(2022, 1, 24, 16, 4, 43, 150, DateTimeKind.Local).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 16, 4, 43, 150, DateTimeKind.Local).AddTicks(7612), new DateTime(2022, 1, 24, 16, 4, 43, 150, DateTimeKind.Local).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 16, 4, 43, 150, DateTimeKind.Local).AddTicks(7619), new DateTime(2022, 1, 24, 16, 4, 43, 150, DateTimeKind.Local).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 16, 4, 43, 152, DateTimeKind.Local).AddTicks(4683), new DateTime(2022, 1, 24, 16, 4, 43, 152, DateTimeKind.Local).AddTicks(4689) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 16, 4, 43, 152, DateTimeKind.Local).AddTicks(4692), new DateTime(2022, 1, 24, 16, 4, 43, 152, DateTimeKind.Local).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 16, 4, 43, 152, DateTimeKind.Local).AddTicks(4694), new DateTime(2022, 1, 24, 16, 4, 43, 152, DateTimeKind.Local).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "job_infos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 16, 4, 43, 152, DateTimeKind.Local).AddTicks(8888), new DateTime(2022, 1, 24, 16, 4, 43, 152, DateTimeKind.Local).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "job_infos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 16, 4, 43, 152, DateTimeKind.Local).AddTicks(8898), new DateTime(2022, 1, 24, 16, 4, 43, 152, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "job_locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 16, 4, 43, 152, DateTimeKind.Local).AddTicks(1337), new DateTime(2022, 1, 24, 16, 4, 43, 152, DateTimeKind.Local).AddTicks(1345) });

            migrationBuilder.UpdateData(
                table: "job_locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 16, 4, 43, 152, DateTimeKind.Local).AddTicks(1349), new DateTime(2022, 1, 24, 16, 4, 43, 152, DateTimeKind.Local).AddTicks(1350) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "18075746-4abb-4055-b93d-6739fc5fb553");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "4bb0dc18-2dd8-41c2-9dbe-c2c593f2476e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cea1013f-e5b7-4110-8873-04d285828656", "AQAAAAEAACcQAAAAELGGlz1XKKY56UNbiCW35gGR8rgIhSO313YyUJW1KpzuuZGOL7huzu9lswg21j5XVg==", "cba2e0c2-16c5-4ce5-9704-4768ac19ea09" });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 23, 42, 58, 115, DateTimeKind.Local).AddTicks(2626), new DateTime(2022, 1, 10, 23, 42, 58, 115, DateTimeKind.Local).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 23, 42, 58, 115, DateTimeKind.Local).AddTicks(9876), new DateTime(2022, 1, 10, 23, 42, 58, 115, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 23, 42, 58, 115, DateTimeKind.Local).AddTicks(9881), new DateTime(2022, 1, 10, 23, 42, 58, 115, DateTimeKind.Local).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 23, 42, 58, 117, DateTimeKind.Local).AddTicks(763), new DateTime(2022, 1, 10, 23, 42, 58, 117, DateTimeKind.Local).AddTicks(768) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 23, 42, 58, 117, DateTimeKind.Local).AddTicks(770), new DateTime(2022, 1, 10, 23, 42, 58, 117, DateTimeKind.Local).AddTicks(771) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 23, 42, 58, 117, DateTimeKind.Local).AddTicks(799), new DateTime(2022, 1, 10, 23, 42, 58, 117, DateTimeKind.Local).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "job_infos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 23, 42, 58, 117, DateTimeKind.Local).AddTicks(3435), new DateTime(2022, 1, 10, 23, 42, 58, 117, DateTimeKind.Local).AddTicks(3439) });

            migrationBuilder.UpdateData(
                table: "job_infos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 23, 42, 58, 117, DateTimeKind.Local).AddTicks(3442), new DateTime(2022, 1, 10, 23, 42, 58, 117, DateTimeKind.Local).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "job_locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 23, 42, 58, 116, DateTimeKind.Local).AddTicks(8434), new DateTime(2022, 1, 10, 23, 42, 58, 116, DateTimeKind.Local).AddTicks(8444) });

            migrationBuilder.UpdateData(
                table: "job_locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 23, 42, 58, 116, DateTimeKind.Local).AddTicks(8446), new DateTime(2022, 1, 10, 23, 42, 58, 116, DateTimeKind.Local).AddTicks(8447) });
        }
    }
}
