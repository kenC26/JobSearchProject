using IdentityServer4.EntityFramework.Options;
using JobSearchProject.Server.Models;
using JobSearchProject.Shared.Domain;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchProject.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<job_info> job_infos { get; set; }
        public DbSet<job_Category> job_Categories{ get; set; }
        public DbSet<job_location> job_locations { get; set; }
        public DbSet<Company_info> Company_Infos { get; set; }

        public DbSet<applicant_info> applicant_Infos { get; set; }
        public DbSet<ApplicantDetail> ApplicantDetails{ get; set; }
    }
}
