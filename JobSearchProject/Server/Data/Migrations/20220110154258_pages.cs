using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearchProject.Server.Data.Migrations
{
    public partial class pages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "job_salary",
                table: "job_infos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Contact",
                table: "Company_Infos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "applicant_salary",
                table: "applicant_Infos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<string>(
                name: "applicant_Contact",
                table: "applicant_Infos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                columns: new[] { "Contact", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2022, 1, 10, 23, 42, 58, 115, DateTimeKind.Local).AddTicks(2626), new DateTime(2022, 1, 10, 23, 42, 58, 115, DateTimeKind.Local).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Contact", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2022, 1, 10, 23, 42, 58, 115, DateTimeKind.Local).AddTicks(9876), new DateTime(2022, 1, 10, 23, 42, 58, 115, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Contact", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2022, 1, 10, 23, 42, 58, 115, DateTimeKind.Local).AddTicks(9881), new DateTime(2022, 1, 10, 23, 42, 58, 115, DateTimeKind.Local).AddTicks(9882) });

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
                columns: new[] { "DateCreated", "DateUpdated", "job_salary" },
                values: new object[] { new DateTime(2022, 1, 10, 23, 42, 58, 117, DateTimeKind.Local).AddTicks(3435), new DateTime(2022, 1, 10, 23, 42, 58, 117, DateTimeKind.Local).AddTicks(3439), "0.00" });

            migrationBuilder.UpdateData(
                table: "job_infos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "job_salary" },
                values: new object[] { new DateTime(2022, 1, 10, 23, 42, 58, 117, DateTimeKind.Local).AddTicks(3442), new DateTime(2022, 1, 10, 23, 42, 58, 117, DateTimeKind.Local).AddTicks(3443), "0.00" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "job_salary",
                table: "job_infos",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Contact",
                table: "Company_Infos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "applicant_salary",
                table: "applicant_Infos",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "applicant_Contact",
                table: "applicant_Infos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "b3c56482-dcf9-4143-862a-842069ebbf67");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "59db5682-6b0d-410a-b78f-ece975a2687e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4407628f-61c0-4bad-afe6-e6037dd71d8b", "AQAAAAEAACcQAAAAEKspevDVzf3mBzv5vg5CAYnasa5v88MPlxnXFlINB7WqAR2sSbE0i85JxNqiJTDE7w==", "1a7f5cd4-1f7a-4249-8cc3-68535e22a2c5" });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Contact", "DateCreated", "DateUpdated" },
                values: new object[] { 0, new DateTime(2022, 1, 10, 16, 16, 31, 593, DateTimeKind.Local).AddTicks(3120), new DateTime(2022, 1, 10, 16, 16, 31, 595, DateTimeKind.Local).AddTicks(7563) });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Contact", "DateCreated", "DateUpdated" },
                values: new object[] { 0, new DateTime(2022, 1, 10, 16, 16, 31, 596, DateTimeKind.Local).AddTicks(372), new DateTime(2022, 1, 10, 16, 16, 31, 596, DateTimeKind.Local).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Contact", "DateCreated", "DateUpdated" },
                values: new object[] { 0, new DateTime(2022, 1, 10, 16, 16, 31, 596, DateTimeKind.Local).AddTicks(389), new DateTime(2022, 1, 10, 16, 16, 31, 596, DateTimeKind.Local).AddTicks(391) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 16, 31, 599, DateTimeKind.Local).AddTicks(6290), new DateTime(2022, 1, 10, 16, 16, 31, 599, DateTimeKind.Local).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 16, 31, 599, DateTimeKind.Local).AddTicks(6312), new DateTime(2022, 1, 10, 16, 16, 31, 599, DateTimeKind.Local).AddTicks(6314) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 16, 31, 599, DateTimeKind.Local).AddTicks(6317), new DateTime(2022, 1, 10, 16, 16, 31, 599, DateTimeKind.Local).AddTicks(6319) });

            migrationBuilder.UpdateData(
                table: "job_infos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "job_salary" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 16, 31, 600, DateTimeKind.Local).AddTicks(5407), new DateTime(2022, 1, 10, 16, 16, 31, 600, DateTimeKind.Local).AddTicks(5422), 0.0 });

            migrationBuilder.UpdateData(
                table: "job_infos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "job_salary" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 16, 31, 600, DateTimeKind.Local).AddTicks(5429), new DateTime(2022, 1, 10, 16, 16, 31, 600, DateTimeKind.Local).AddTicks(5431), 0.0 });

            migrationBuilder.UpdateData(
                table: "job_locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 16, 31, 598, DateTimeKind.Local).AddTicks(8642), new DateTime(2022, 1, 10, 16, 16, 31, 598, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "job_locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 16, 31, 598, DateTimeKind.Local).AddTicks(8680), new DateTime(2022, 1, 10, 16, 16, 31, 598, DateTimeKind.Local).AddTicks(8682) });
        }
    }
}
