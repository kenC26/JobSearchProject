using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearchProject.Server.Data.Migrations
{
    public partial class NewDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "2b6c17eb-311d-4dc0-b8c4-75637340c9b7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "48bf8593-258e-4264-98c3-1e7da4fb14a1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1218b220-28f8-4825-8240-caa64b554572", "AQAAAAEAACcQAAAAECwDR6OpkWhodbjkpfUUf9t689cZI82VWd7RZZF0RlIifOBoVeAa7Ys9gDp7mAdxuw==", "fbb14467-6067-409b-9917-dddaf1a440e6" });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 11, 45, 40, 292, DateTimeKind.Local).AddTicks(2132), new DateTime(2022, 1, 5, 11, 45, 40, 295, DateTimeKind.Local).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 11, 45, 40, 295, DateTimeKind.Local).AddTicks(7276), new DateTime(2022, 1, 5, 11, 45, 40, 295, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 11, 45, 40, 298, DateTimeKind.Local).AddTicks(7562), new DateTime(2022, 1, 5, 11, 45, 40, 298, DateTimeKind.Local).AddTicks(7574) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 11, 45, 40, 298, DateTimeKind.Local).AddTicks(7580), new DateTime(2022, 1, 5, 11, 45, 40, 298, DateTimeKind.Local).AddTicks(7582) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 11, 45, 40, 298, DateTimeKind.Local).AddTicks(7585), new DateTime(2022, 1, 5, 11, 45, 40, 298, DateTimeKind.Local).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 11, 45, 40, 298, DateTimeKind.Local).AddTicks(7590), new DateTime(2022, 1, 5, 11, 45, 40, 298, DateTimeKind.Local).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "job_infos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 11, 45, 40, 299, DateTimeKind.Local).AddTicks(6177), new DateTime(2022, 1, 5, 11, 45, 40, 299, DateTimeKind.Local).AddTicks(6191) });

            migrationBuilder.UpdateData(
                table: "job_infos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 11, 45, 40, 299, DateTimeKind.Local).AddTicks(6200), new DateTime(2022, 1, 5, 11, 45, 40, 299, DateTimeKind.Local).AddTicks(6202) });

            migrationBuilder.UpdateData(
                table: "job_locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 11, 45, 40, 298, DateTimeKind.Local).AddTicks(793), new DateTime(2022, 1, 5, 11, 45, 40, 298, DateTimeKind.Local).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "job_locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 11, 45, 40, 298, DateTimeKind.Local).AddTicks(827), new DateTime(2022, 1, 5, 11, 45, 40, 298, DateTimeKind.Local).AddTicks(829) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "22dc13e2-c447-46f1-9bd0-e5ccb4adf50c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "38bee0e9-5c91-40b2-8f3a-b9951b9e577d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79b391df-bc2b-43fe-9c35-aacff0e62712", "AQAAAAEAACcQAAAAEEG6RKd68T8L1ciwvZaTKZRbhH1fqFK5VNrqsZtP7B5DA119iaQXde+vzd9VLRhCkQ==", "4acf5224-53ce-456e-8b9b-7de9d89c766e" });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 5, 14, 1, 4, 69, DateTimeKind.Local).AddTicks(3604), new DateTime(2021, 12, 5, 14, 1, 4, 70, DateTimeKind.Local).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 5, 14, 1, 4, 70, DateTimeKind.Local).AddTicks(843), new DateTime(2021, 12, 5, 14, 1, 4, 70, DateTimeKind.Local).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 5, 14, 1, 4, 71, DateTimeKind.Local).AddTicks(1475), new DateTime(2021, 12, 5, 14, 1, 4, 71, DateTimeKind.Local).AddTicks(1479) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 5, 14, 1, 4, 71, DateTimeKind.Local).AddTicks(1510), new DateTime(2021, 12, 5, 14, 1, 4, 71, DateTimeKind.Local).AddTicks(1511) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 5, 14, 1, 4, 71, DateTimeKind.Local).AddTicks(1512), new DateTime(2021, 12, 5, 14, 1, 4, 71, DateTimeKind.Local).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 5, 14, 1, 4, 71, DateTimeKind.Local).AddTicks(1514), new DateTime(2021, 12, 5, 14, 1, 4, 71, DateTimeKind.Local).AddTicks(1515) });

            migrationBuilder.UpdateData(
                table: "job_infos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 5, 14, 1, 4, 71, DateTimeKind.Local).AddTicks(4305), new DateTime(2021, 12, 5, 14, 1, 4, 71, DateTimeKind.Local).AddTicks(4309) });

            migrationBuilder.UpdateData(
                table: "job_infos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 5, 14, 1, 4, 71, DateTimeKind.Local).AddTicks(4311), new DateTime(2021, 12, 5, 14, 1, 4, 71, DateTimeKind.Local).AddTicks(4312) });

            migrationBuilder.UpdateData(
                table: "job_locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 5, 14, 1, 4, 70, DateTimeKind.Local).AddTicks(9137), new DateTime(2021, 12, 5, 14, 1, 4, 70, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "job_locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 5, 14, 1, 4, 70, DateTimeKind.Local).AddTicks(9146), new DateTime(2021, 12, 5, 14, 1, 4, 70, DateTimeKind.Local).AddTicks(9147) });
        }
    }
}
