using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearchProject.Server.Migrations
{
    public partial class newestdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "32ed3036-cc2c-4a51-8201-b5e455fedc7a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "2aed6023-536e-417b-85c0-2a6c34b75a14");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ed11bb8-28bb-41ff-a5e7-aa847d6ad11d", "AQAAAAEAACcQAAAAEF8C/UiUmrl1ag0znJnlqzGcOUpGa+1C9Fkoy3DNoatum4INxOsID6Qpgrla16Zv5A==", "eaca7070-c8d1-45ce-ad1d-eaa6282e3731" });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 21, 42, 22, 446, DateTimeKind.Local).AddTicks(2313), new DateTime(2022, 2, 6, 21, 42, 22, 448, DateTimeKind.Local).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 21, 42, 22, 449, DateTimeKind.Local).AddTicks(105), new DateTime(2022, 2, 6, 21, 42, 22, 449, DateTimeKind.Local).AddTicks(114) });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 21, 42, 22, 449, DateTimeKind.Local).AddTicks(119), new DateTime(2022, 2, 6, 21, 42, 22, 449, DateTimeKind.Local).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 21, 42, 22, 451, DateTimeKind.Local).AddTicks(7908), new DateTime(2022, 2, 6, 21, 42, 22, 451, DateTimeKind.Local).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 21, 42, 22, 451, DateTimeKind.Local).AddTicks(7926), new DateTime(2022, 2, 6, 21, 42, 22, 451, DateTimeKind.Local).AddTicks(7928) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 21, 42, 22, 451, DateTimeKind.Local).AddTicks(7931), new DateTime(2022, 2, 6, 21, 42, 22, 451, DateTimeKind.Local).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "job_infos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 21, 42, 22, 452, DateTimeKind.Local).AddTicks(5014), new DateTime(2022, 2, 6, 21, 42, 22, 452, DateTimeKind.Local).AddTicks(5024) });

            migrationBuilder.UpdateData(
                table: "job_infos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 21, 42, 22, 452, DateTimeKind.Local).AddTicks(5031), new DateTime(2022, 2, 6, 21, 42, 22, 452, DateTimeKind.Local).AddTicks(5033) });

            migrationBuilder.UpdateData(
                table: "job_locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 21, 42, 22, 451, DateTimeKind.Local).AddTicks(2233), new DateTime(2022, 2, 6, 21, 42, 22, 451, DateTimeKind.Local).AddTicks(2256) });

            migrationBuilder.UpdateData(
                table: "job_locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 6, 21, 42, 22, 451, DateTimeKind.Local).AddTicks(2262), new DateTime(2022, 2, 6, 21, 42, 22, 451, DateTimeKind.Local).AddTicks(2265) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
