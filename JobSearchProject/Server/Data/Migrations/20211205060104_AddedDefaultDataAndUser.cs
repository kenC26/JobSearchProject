using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearchProject.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "job_salary",
                table: "job_infos",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "22dc13e2-c447-46f1-9bd0-e5ccb4adf50c", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "38bee0e9-5c91-40b2-8f3a-b9951b9e577d", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "79b391df-bc2b-43fe-9c35-aacff0e62712", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEEG6RKd68T8L1ciwvZaTKZRbhH1fqFK5VNrqsZtP7B5DA119iaQXde+vzd9VLRhCkQ==", null, false, "4acf5224-53ce-456e-8b9b-7de9d89c766e", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Company_Infos",
                columns: new[] { "Id", "Address", "Contact", "CreatedBy", "DateCreated", "DateUpdated", "Mission", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Tam str 88", 0, "System", new DateTime(2021, 12, 5, 14, 1, 4, 69, DateTimeKind.Local).AddTicks(3604), new DateTime(2021, 12, 5, 14, 1, 4, 70, DateTimeKind.Local).AddTicks(379), "To give you a job", "ABC Company", "System" },
                    { 2, "Tam str 58", 0, "System", new DateTime(2021, 12, 5, 14, 1, 4, 70, DateTimeKind.Local).AddTicks(843), new DateTime(2021, 12, 5, 14, 1, 4, 70, DateTimeKind.Local).AddTicks(846), "To advance the world to a robotic age", "ABC Company", "System" }
                });

            migrationBuilder.InsertData(
                table: "job_Categories",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy", "category" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 12, 5, 14, 1, 4, 71, DateTimeKind.Local).AddTicks(1475), new DateTime(2021, 12, 5, 14, 1, 4, 71, DateTimeKind.Local).AddTicks(1479), "System", "3 Series" },
                    { 2, "System", new DateTime(2021, 12, 5, 14, 1, 4, 71, DateTimeKind.Local).AddTicks(1510), new DateTime(2021, 12, 5, 14, 1, 4, 71, DateTimeKind.Local).AddTicks(1511), "System", "X5" },
                    { 3, "System", new DateTime(2021, 12, 5, 14, 1, 4, 71, DateTimeKind.Local).AddTicks(1512), new DateTime(2021, 12, 5, 14, 1, 4, 71, DateTimeKind.Local).AddTicks(1513), "System", "Prius" },
                    { 4, "System", new DateTime(2021, 12, 5, 14, 1, 4, 71, DateTimeKind.Local).AddTicks(1514), new DateTime(2021, 12, 5, 14, 1, 4, 71, DateTimeKind.Local).AddTicks(1515), "System", "Rav4" }
                });

            migrationBuilder.InsertData(
                table: "job_infos",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy", "company_infoId", "job_CategoryId", "job_description", "job_locationId", "job_salary", "job_title", "no_of_vacancy", "type" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 12, 5, 14, 1, 4, 71, DateTimeKind.Local).AddTicks(4305), new DateTime(2021, 12, 5, 14, 1, 4, 71, DateTimeKind.Local).AddTicks(4309), "System", null, null, "", null, 0.0, "", 0, "" },
                    { 2, "System", new DateTime(2021, 12, 5, 14, 1, 4, 71, DateTimeKind.Local).AddTicks(4311), new DateTime(2021, 12, 5, 14, 1, 4, 71, DateTimeKind.Local).AddTicks(4312), "System", null, null, "", null, 0.0, "", 0, "" }
                });

            migrationBuilder.InsertData(
                table: "job_locations",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy", "location_Name" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 12, 5, 14, 1, 4, 70, DateTimeKind.Local).AddTicks(9137), new DateTime(2021, 12, 5, 14, 1, 4, 70, DateTimeKind.Local).AddTicks(9143), "System", "" },
                    { 2, "System", new DateTime(2021, 12, 5, 14, 1, 4, 70, DateTimeKind.Local).AddTicks(9146), new DateTime(2021, 12, 5, 14, 1, 4, 70, DateTimeKind.Local).AddTicks(9147), "System", "" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Company_Infos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "job_Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "job_infos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "job_infos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "job_locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "job_locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.AlterColumn<float>(
                name: "job_salary",
                table: "job_infos",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
