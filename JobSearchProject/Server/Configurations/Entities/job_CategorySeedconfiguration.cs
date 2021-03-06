using JobSearchProject.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchProject.Server.Configurations.Entities
{
    public class job_CategorySeedConfiguration : IEntityTypeConfiguration<job_Category>
    {
        public void Configure(EntityTypeBuilder<job_Category> builder)
        {

            builder.HasData(
                new job_Category
                {
                    Id = 1,
                    category = "Engineering",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new job_Category
                {
                    Id = 2,
                    category = "Business",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new job_Category
                {
                    Id = 3,
                    category = "Healthcare",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                
            );

        }
    }
}
