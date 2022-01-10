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
                    Name = "OCBC",
                    Address = "North Bridge Road",
                    Mission = "provides innovative financial services that meet their needs",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Company_info
                {
                    Id = 2,
                    Name = "TECHTIMIA ENGINEERING PTE LTD",
                    Address = "1 TAMPINES NORTH DRIVE",
                    Mission = "Provide Our Clients with Valued Added Services and Solutions",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Company_info
                {
                    Id = 3,
                    Name = "kHOO TECH PUAT",
                    Address = "90 Yishun Central",
                    Mission = "Provide good quality, affordable and hassle-free healthcare ",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );

        }
    }
}
