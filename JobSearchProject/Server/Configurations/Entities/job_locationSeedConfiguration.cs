using JobSearchProject.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchProject.Server.Configurations.Entities
{
    public class job_locationSeedConfiguration : IEntityTypeConfiguration<job_location>
    {
        public void Configure(EntityTypeBuilder<job_location> builder)
        {

            builder.HasData(
                new job_location
                {
                    Id = 1,
                    location_Name = "",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new job_location
                {
                    Id = 2,
                    location_Name = "",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );

        }
    }
}
