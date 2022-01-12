using JobSearchProject.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchProject.Server.Configurations.Entities
{
    public class job_infoSeedConfiguration : IEntityTypeConfiguration<job_info>
    {
        public void Configure(EntityTypeBuilder<job_info> builder)
        {

            builder.HasData(
                new job_info
                {
                    Id = 1,
                    job_title = "",
                    job_description = "",
                    job_salary = "0.00",
                    no_of_vacancy = 0,
                    type = "",
                    //job_Category = job_Category.category,
                    //job_location = job_CategorySeedConfiguration,
                    //company_info = job_CategorySeedConfiguration,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new job_info
                {
                    Id = 2,
                    job_title = "",
                    job_description = "",
                    job_salary = "0.00",
                    no_of_vacancy = 0,
                    type = "",
                    //job_Category = "",
                    //job_location = "",
                    //company_info = "",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );

        }
    }
}
