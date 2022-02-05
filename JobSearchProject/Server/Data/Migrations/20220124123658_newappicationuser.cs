using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearchProject.Server.Data.Migrations
{
    public partial class newappicationuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "salary");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "AspNetUsers",
                newName: "qualification");

            migrationBuilder.AddColumn<DateTime>(
                name: "DOB",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "d586be85-74e9-4b02-9eb0-240bf50d1743");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "114ab65e-9c1b-486c-b2c8-1d7efc2c1587");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "Name", "PasswordHash", "SecurityStamp", "qualification", "salary" },
                values: new object[] { "e35ba751-901d-47af-80ec-d6b151122786", "AdminUser", "AQAAAAEAACcQAAAAELb9MNnNU93tjamx5ldEAbKojqlFnLiYWaENtOfp2E5ec0tZYpkqcp14p6LcCve1tA==", "f4be2db2-5d1b-405f-9240-dc8fc1912319", null, null });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 20, 36, 57, 666, DateTimeKind.Local).AddTicks(9739), new DateTime(2022, 1, 24, 20, 36, 57, 667, DateTimeKind.Local).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 20, 36, 57, 667, DateTimeKind.Local).AddTicks(8443), new DateTime(2022, 1, 24, 20, 36, 57, 667, DateTimeKind.Local).AddTicks(8446) });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 20, 36, 57, 667, DateTimeKind.Local).AddTicks(8448), new DateTime(2022, 1, 24, 20, 36, 57, 667, DateTimeKind.Local).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 20, 36, 57, 668, DateTimeKind.Local).AddTicks(9011), new DateTime(2022, 1, 24, 20, 36, 57, 668, DateTimeKind.Local).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 20, 36, 57, 668, DateTimeKind.Local).AddTicks(9017), new DateTime(2022, 1, 24, 20, 36, 57, 668, DateTimeKind.Local).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 20, 36, 57, 668, DateTimeKind.Local).AddTicks(9019), new DateTime(2022, 1, 24, 20, 36, 57, 668, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "job_infos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 20, 36, 57, 669, DateTimeKind.Local).AddTicks(1638), new DateTime(2022, 1, 24, 20, 36, 57, 669, DateTimeKind.Local).AddTicks(1643) });

            migrationBuilder.UpdateData(
                table: "job_infos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 20, 36, 57, 669, DateTimeKind.Local).AddTicks(1645), new DateTime(2022, 1, 24, 20, 36, 57, 669, DateTimeKind.Local).AddTicks(1646) });

            migrationBuilder.UpdateData(
                table: "job_locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 20, 36, 57, 668, DateTimeKind.Local).AddTicks(6963), new DateTime(2022, 1, 24, 20, 36, 57, 668, DateTimeKind.Local).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "job_locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 20, 36, 57, 668, DateTimeKind.Local).AddTicks(6975), new DateTime(2022, 1, 24, 20, 36, 57, 668, DateTimeKind.Local).AddTicks(6976) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DOB",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "salary",
                table: "AspNetUsers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "qualification",
                table: "AspNetUsers",
                newName: "FirstName");

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
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0c4a1f5-f75d-49a6-8dea-ab0094d97b69", "Admin", "User", "AQAAAAEAACcQAAAAEGIIttDtqBAnLnMd6FoCpsP1r3WHOBbzjqoaXZFsgiMqadmrb8tD5DqMmp5kdugURg==", "35c734b5-1ab1-49c0-a4a6-4f0809d41272" });

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
    }
}
