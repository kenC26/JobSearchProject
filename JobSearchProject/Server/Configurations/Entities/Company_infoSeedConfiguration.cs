using JobSearchProject.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchProject.Server.Configurations.Entities
{
    public class Company_infoSeedConfiguration : IEntityTypeConfiguration<Company_info>
    {
        public void Configure(EntityTypeBuilder<Company_info> builder)
        {

            builder.HasData(
                new Company_info
                {
                    Id = 1,
                    Name = "ABC Company",
                    Address = "Tam str 88",
                    Mission = "To give you a job",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Company_info
                {
                    Id = 2,
                    Name = "ABC Company",
                    Address = "Tam str 58",
                    Mission = "To advance the world to a robotic age",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );

        }
    }
}
