using JobSearchProject.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchProject.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<ApplicantDetail> ApplicantDetails { get; }
        IGenericRepository<applicant_info> applicant_infos { get; }
        IGenericRepository<Company_info> Company_infos { get; }
        IGenericRepository<job_info> job_infos { get; }
        IGenericRepository<job_location> job_locations { get; }
        IGenericRepository<job_Category> job_Categorys { get; }
    }
}