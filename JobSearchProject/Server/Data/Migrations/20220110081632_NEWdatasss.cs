using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearchProject.Server.Data.Migrations
{
    public partial class NEWdatasss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 4);

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
                columns: new[] { "Address", "DateCreated", "DateUpdated", "Mission", "Name" },
                values: new object[] { "North Bridge Road", new DateTime(2022, 1, 10, 16, 16, 31, 593, DateTimeKind.Local).AddTicks(3120), new DateTime(2022, 1, 10, 16, 16, 31, 595, DateTimeKind.Local).AddTicks(7563), "provides innovative financial services that meet their needs", "OCBC" });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "DateCreated", "DateUpdated", "Mission", "Name" },
                values: new object[] { "1 TAMPINES NORTH DRIVE", new DateTime(2022, 1, 10, 16, 16, 31, 596, DateTimeKind.Local).AddTicks(372), new DateTime(2022, 1, 10, 16, 16, 31, 596, DateTimeKind.Local).AddTicks(385), "Provide Our Clients with Valued Added Services and Solutions", "TECHTIMIA ENGINEERING PTE LTD" });

            migrationBuilder.InsertData(
                table: "Company_Infos",
                columns: new[] { "Id", "Address", "Contact", "CreatedBy", "DateCreated", "DateUpdated", "Mission", "Name", "UpdatedBy" },
                values: new object[] { 3, "90 Yishun Central", 0, "System", new DateTime(2022, 1, 10, 16, 16, 31, 596, DateTimeKind.Local).AddTicks(389), new DateTime(2022, 1, 10, 16, 16, 31, 596, DateTimeKind.Local).AddTicks(391), "Provide good quality, affordable and hassle-free healthcare ", "kHOO TECH PUAT", "System" });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "category" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 16, 31, 599, DateTimeKind.Local).AddTicks(6290), new DateTime(2022, 1, 10, 16, 16, 31, 599, DateTimeKind.Local).AddTicks(6305), "Engineering" });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "category" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 16, 31, 599, DateTimeKind.Local).AddTicks(6312), new DateTime(2022, 1, 10, 16, 16, 31, 599, DateTimeKind.Local).AddTicks(6314), "Business" });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "category" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 16, 31, 599, DateTimeKind.Local).AddTicks(6317), new DateTime(2022, 1, 10, 16, 16, 31, 599, DateTimeKind.Local).AddTicks(6319), "Healthcare" });

            migrationBuilder.UpdateData(
                table: "job_infos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 16, 31, 600, DateTimeKind.Local).AddTicks(5407), new DateTime(2022, 1, 10, 16, 16, 31, 600, DateTimeKind.Local).AddTicks(5422) });

            migrationBuilder.UpdateData(
                table: "job_infos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 16, 31, 600, DateTimeKind.Local).AddTicks(5429), new DateTime(2022, 1, 10, 16, 16, 31, 600, DateTimeKind.Local).AddTicks(5431) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 3);

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
                columns: new[] { "Address", "DateCreated", "DateUpdated", "Mission", "Name" },
                values: new object[] { "Tam str 88", new DateTime(2022, 1, 5, 11, 45, 40, 292, DateTimeKind.Local).AddTicks(2132), new DateTime(2022, 1, 5, 11, 45, 40, 295, DateTimeKind.Local).AddTicks(4838), "To give you a job", "ABC Company" });

            migrationBuilder.UpdateData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "DateCreated", "DateUpdated", "Mission", "Name" },
                values: new object[] { "Tam str 58", new DateTime(2022, 1, 5, 11, 45, 40, 295, DateTimeKind.Local).AddTicks(7276), new DateTime(2022, 1, 5, 11, 45, 40, 295, DateTimeKind.Local).AddTicks(7290), "To advance the world to a robotic age", "ABC Company" });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "category" },
                values: new object[] { new DateTime(2022, 1, 5, 11, 45, 40, 298, DateTimeKind.Local).AddTicks(7562), new DateTime(2022, 1, 5, 11, 45, 40, 298, DateTimeKind.Local).AddTicks(7574), "3 Series" });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "category" },
                values: new object[] { new DateTime(2022, 1, 5, 11, 45, 40, 298, DateTimeKind.Local).AddTicks(7580), new DateTime(2022, 1, 5, 11, 45, 40, 298, DateTimeKind.Local).AddTicks(7582), "X5" });

            migrationBuilder.UpdateData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "category" },
                values: new object[] { new DateTime(2022, 1, 5, 11, 45, 40, 298, DateTimeKind.Local).AddTicks(7585), new DateTime(2022, 1, 5, 11, 45, 40, 298, DateTimeKind.Local).AddTicks(7587), "Prius" });

            migrationBuilder.InsertData(
                table: "job_Categories",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy", "category" },
                values: new object[] { 4, "System", new DateTime(2022, 1, 5, 11, 45, 40, 298, DateTimeKind.Local).AddTicks(7590), new DateTime(2022, 1, 5, 11, 45, 40, 298, DateTimeKind.Local).AddTicks(7592), "System", "Rav4" });

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
    }
}
