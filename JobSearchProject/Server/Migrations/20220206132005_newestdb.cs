using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearchProject.Server.Migrations
{
    public partial class newestdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "c0f56f11-57b7-408e-b1c4-c2cc2c2e107f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "83233170-99d6-445e-8741-02f5a20705fc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "192ed735-50aa-4363-87e2-d87cd00facef", "AQAAAAEAACcQAAAAEImLO3n+O+nThemMCBm9kzoFWxUW2bq8Pr6WO3yIkLjnE5onRcjIsozG/qJSQdnYQQ==", "e0cfc07f-cfbc-4140-becc-120e5955532e" });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 21, 20, 3, 645, DateTimeKind.Local).AddTicks(8680), new DateTime(2022, 2, 6, 21, 20, 3, 648, DateTimeKind.Local).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 21, 20, 3, 648, DateTimeKind.Local).AddTicks(9163), new DateTime(2022, 2, 6, 21, 20, 3, 648, DateTimeKind.Local).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 21, 20, 3, 648, DateTimeKind.Local).AddTicks(9256), new DateTime(2022, 2, 6, 21, 20, 3, 648, DateTimeKind.Local).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 21, 20, 3, 651, DateTimeKind.Local).AddTicks(4013), new DateTime(2022, 2, 6, 21, 20, 3, 651, DateTimeKind.Local).AddTicks(4023) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 21, 20, 3, 651, DateTimeKind.Local).AddTicks(4028), new DateTime(2022, 2, 6, 21, 20, 3, 651, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 21, 20, 3, 651, DateTimeKind.Local).AddTicks(4032), new DateTime(2022, 2, 6, 21, 20, 3, 651, DateTimeKind.Local).AddTicks(4033) });

            migrationBuilder.UpdateData(
                table: "job_infos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 21, 20, 3, 652, DateTimeKind.Local).AddTicks(550), new DateTime(2022, 2, 6, 21, 20, 3, 652, DateTimeKind.Local).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "job_infos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 21, 20, 3, 652, DateTimeKind.Local).AddTicks(565), new DateTime(2022, 2, 6, 21, 20, 3, 652, DateTimeKind.Local).AddTicks(566) });

            migrationBuilder.UpdateData(
                table: "job_locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 21, 20, 3, 650, DateTimeKind.Local).AddTicks(8986), new DateTime(2022, 2, 6, 21, 20, 3, 650, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "job_locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 21, 20, 3, 650, DateTimeKind.Local).AddTicks(9008), new DateTime(2022, 2, 6, 21, 20, 3, 650, DateTimeKind.Local).AddTicks(9009) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "7695c43f-87b8-476e-984a-6f9a843b0606");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "51439a39-cf76-42a4-96c8-d47a0ba7cd83");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "066dec3e-f888-4553-9a0b-fbbcaad5c37d", "AQAAAAEAACcQAAAAENNo3V8Chg3Wyx9ADCipAd0tZT+K/lonujtKfkniuFzVYUbiJlOLcHnucMdwkT5knA==", "a3423c6d-73bc-4030-9e02-e461d5d80d03" });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 6, 19, 14, 299, DateTimeKind.Local).AddTicks(9148), new DateTime(2022, 2, 6, 6, 19, 14, 300, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 6, 19, 14, 300, DateTimeKind.Local).AddTicks(6347), new DateTime(2022, 2, 6, 6, 19, 14, 300, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 6, 19, 14, 300, DateTimeKind.Local).AddTicks(6352), new DateTime(2022, 2, 6, 6, 19, 14, 300, DateTimeKind.Local).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 6, 19, 14, 301, DateTimeKind.Local).AddTicks(7106), new DateTime(2022, 2, 6, 6, 19, 14, 301, DateTimeKind.Local).AddTicks(7116) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 6, 19, 14, 301, DateTimeKind.Local).AddTicks(7118), new DateTime(2022, 2, 6, 6, 19, 14, 301, DateTimeKind.Local).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 6, 19, 14, 301, DateTimeKind.Local).AddTicks(7120), new DateTime(2022, 2, 6, 6, 19, 14, 301, DateTimeKind.Local).AddTicks(7121) });

            migrationBuilder.UpdateData(
                table: "job_infos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 6, 19, 14, 301, DateTimeKind.Local).AddTicks(9806), new DateTime(2022, 2, 6, 6, 19, 14, 301, DateTimeKind.Local).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "job_infos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 6, 19, 14, 301, DateTimeKind.Local).AddTicks(9813), new DateTime(2022, 2, 6, 6, 19, 14, 301, DateTimeKind.Local).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "job_locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 6, 19, 14, 301, DateTimeKind.Local).AddTicks(5050), new DateTime(2022, 2, 6, 6, 19, 14, 301, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "job_locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 6, 19, 14, 301, DateTimeKind.Local).AddTicks(5060), new DateTime(2022, 2, 6, 6, 19, 14, 301, DateTimeKind.Local).AddTicks(5061) });
        }
    }
}
