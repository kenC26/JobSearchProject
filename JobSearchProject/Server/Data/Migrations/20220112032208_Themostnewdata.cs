using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearchProject.Server.Data.Migrations
{
    public partial class Themostnewdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
