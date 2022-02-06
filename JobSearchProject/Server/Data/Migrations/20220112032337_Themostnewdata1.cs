using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearchProject.Server.Data.Migrations
{
    public partial class Themostnewdata1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "1c626135-6630-453c-906a-8e1604230ea2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "d235c57e-c4f4-4b16-a1b3-75cf18f3f62d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dee7ca4d-bee8-40d6-83f4-5ed9989ec4b5", "AQAAAAEAACcQAAAAEFDV2ZD9WByO0/nW7kj1hUbhxI3v3vKjOO5zLL47icWPmzCtuvsDRSBDjiVOdsi5lg==", "5d875ca9-0cb9-4d9c-bec4-962cb1b8f6ce" });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 11, 23, 36, 136, DateTimeKind.Local).AddTicks(8714), new DateTime(2022, 1, 12, 11, 23, 36, 139, DateTimeKind.Local).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 11, 23, 36, 139, DateTimeKind.Local).AddTicks(9114), new DateTime(2022, 1, 12, 11, 23, 36, 139, DateTimeKind.Local).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 11, 23, 36, 139, DateTimeKind.Local).AddTicks(9134), new DateTime(2022, 1, 12, 11, 23, 36, 139, DateTimeKind.Local).AddTicks(9136) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 11, 23, 36, 144, DateTimeKind.Local).AddTicks(3233), new DateTime(2022, 1, 12, 11, 23, 36, 144, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 11, 23, 36, 144, DateTimeKind.Local).AddTicks(3264), new DateTime(2022, 1, 12, 11, 23, 36, 144, DateTimeKind.Local).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 11, 23, 36, 144, DateTimeKind.Local).AddTicks(3270), new DateTime(2022, 1, 12, 11, 23, 36, 144, DateTimeKind.Local).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "job_infos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 11, 23, 36, 145, DateTimeKind.Local).AddTicks(5022), new DateTime(2022, 1, 12, 11, 23, 36, 145, DateTimeKind.Local).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "job_infos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 11, 23, 36, 145, DateTimeKind.Local).AddTicks(5050), new DateTime(2022, 1, 12, 11, 23, 36, 145, DateTimeKind.Local).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "job_locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 11, 23, 36, 143, DateTimeKind.Local).AddTicks(1252), new DateTime(2022, 1, 12, 11, 23, 36, 143, DateTimeKind.Local).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "job_locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 11, 23, 36, 143, DateTimeKind.Local).AddTicks(1306), new DateTime(2022, 1, 12, 11, 23, 36, 143, DateTimeKind.Local).AddTicks(1310) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "657b853a-c570-4cfb-a569-b09c63187aa5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "ec8e5e2a-219c-4bc1-980d-fe2b94cb8d2e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3c1e470-2951-4705-bc9f-8a6472775d75", "AQAAAAEAACcQAAAAEN1q3EC3ErnDPZHEM5vcjVr+S4oY4nD980Vmj+ihWWw0+PdiYdwS0Gk/ni687zk4Eg==", "5a4f269f-54b3-435f-879b-e3091ebe04db" });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 11, 22, 7, 526, DateTimeKind.Local).AddTicks(3341), new DateTime(2022, 1, 12, 11, 22, 7, 528, DateTimeKind.Local).AddTicks(5029) });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 11, 22, 7, 528, DateTimeKind.Local).AddTicks(7208), new DateTime(2022, 1, 12, 11, 22, 7, 528, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 11, 22, 7, 528, DateTimeKind.Local).AddTicks(7222), new DateTime(2022, 1, 12, 11, 22, 7, 528, DateTimeKind.Local).AddTicks(7224) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 11, 22, 7, 531, DateTimeKind.Local).AddTicks(9243), new DateTime(2022, 1, 12, 11, 22, 7, 531, DateTimeKind.Local).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 11, 22, 7, 531, DateTimeKind.Local).AddTicks(9267), new DateTime(2022, 1, 12, 11, 22, 7, 531, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 11, 22, 7, 531, DateTimeKind.Local).AddTicks(9274), new DateTime(2022, 1, 12, 11, 22, 7, 531, DateTimeKind.Local).AddTicks(9277) });

            migrationBuilder.UpdateData(
                table: "job_infos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 11, 22, 7, 532, DateTimeKind.Local).AddTicks(9679), new DateTime(2022, 1, 12, 11, 22, 7, 532, DateTimeKind.Local).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "job_infos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 11, 22, 7, 532, DateTimeKind.Local).AddTicks(9705), new DateTime(2022, 1, 12, 11, 22, 7, 532, DateTimeKind.Local).AddTicks(9708) });

            migrationBuilder.UpdateData(
                table: "job_locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 11, 22, 7, 531, DateTimeKind.Local).AddTicks(1528), new DateTime(2022, 1, 12, 11, 22, 7, 531, DateTimeKind.Local).AddTicks(1556) });

            migrationBuilder.UpdateData(
                table: "job_locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 11, 22, 7, 531, DateTimeKind.Local).AddTicks(1564), new DateTime(2022, 1, 12, 11, 22, 7, 531, DateTimeKind.Local).AddTicks(1566) });
        }
    }
}
