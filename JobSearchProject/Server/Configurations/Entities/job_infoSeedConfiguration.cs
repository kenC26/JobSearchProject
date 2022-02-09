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

            

        }
    }
}
