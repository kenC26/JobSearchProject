using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearchProject.Server.Data.Migrations
{
    public partial class ApplicationTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "applicant_Infos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    applicant_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    applicant_Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    applicant_Contact = table.Column<int>(type: "int", nullable: false),
                    applicant_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    applicant_qualification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    applicant_salary = table.Column<float>(type: "real", nullable: false),
                    applicant_username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    applicant_password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_applicant_Infos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Company_Infos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company_Infos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "job_Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_job_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "job_locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    location_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_job_locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "job_infos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    job_CategoryId = table.Column<int>(type: "int", nullable: true),
                    job_locationId = table.Column<int>(type: "int", nullable: true),
                    company_infoId = table.Column<int>(type: "int", nullable: true),
                    job_title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    job_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    job_salary = table.Column<float>(type: "real", nullable: false),
                    no_of_vacancy = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_job_infos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_job_infos_Company_Infos_company_infoId",
                        column: x => x.company_infoId,
                        principalTable: "Company_Infos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_job_infos_job_Categories_job_CategoryId",
                        column: x => x.job_CategoryId,
                        principalTable: "job_Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_job_infos_job_locations_job_locationId",
                        column: x => x.job_locationId,
                        principalTable: "job_locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ApplicantDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeUpload = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicantId = table.Column<int>(type: "int", nullable: false),
                    Applicant_infoId = table.Column<int>(type: "int", nullable: true),
                    JobId = table.Column<int>(type: "int", nullable: false),
                    Job_infoId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicantDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicantDetails_applicant_Infos_Applicant_infoId",
                        column: x => x.Applicant_infoId,
                        principalTable: "applicant_Infos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ApplicantDetails_job_infos_Job_infoId",
                        column: x => x.Job_infoId,
                        principalTable: "job_infos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicantDetails_Applicant_infoId",
                table: "ApplicantDetails",
                column: "Applicant_infoId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicantDetails_Job_infoId",
                table: "ApplicantDetails",
                column: "Job_infoId");

            migrationBuilder.CreateIndex(
                name: "IX_job_infos_company_infoId",
                table: "job_infos",
                column: "company_infoId");

            migrationBuilder.CreateIndex(
                name: "IX_job_infos_job_CategoryId",
                table: "job_infos",
                column: "job_CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_job_infos_job_locationId",
                table: "job_infos",
                column: "job_locationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicantDetails");

            migrationBuilder.DropTable(
                name: "applicant_Infos");

            migrationBuilder.DropTable(
                name: "job_infos");

            migrationBuilder.DropTable(
                name: "Company_Infos");

            migrationBuilder.DropTable(
                name: "job_Categories");

            migrationBuilder.DropTable(
                name: "job_locations");
        }
    }
}
