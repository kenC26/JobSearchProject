using JobSearchProject.Server.Data;
using JobSearchProject.Server.IRepository;
using JobSearchProject.Server.Models;
using JobSearchProject.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JobSearchProject.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<job_info> _job_infos;
        private IGenericRepository<job_location> _job_locations;
        private IGenericRepository<job_Category> _job_Categorys;
        private IGenericRepository<Company_info> _Company_infos;
        private IGenericRepository<applicant_info> _applicant_infos;
        private IGenericRepository<ApplicantDetail> _ApplicantDetails;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<job_info> job_infos
            => _job_infos ??= new GenericRepository<job_info>(_context);
        public IGenericRepository<job_location> job_locations
            => _job_locations ??= new GenericRepository<job_location>(_context);
        public IGenericRepository<job_Category> job_Categorys
            => _job_Categorys ??= new GenericRepository<job_Category>(_context);
        public IGenericRepository<ApplicantDetail> ApplicantDetails
            => _ApplicantDetails ??= new GenericRepository<ApplicantDetail>(_context);
        public IGenericRepository<Company_info> Company_infos
            => _Company_infos ??= new GenericRepository<Company_info>(_context);
        public IGenericRepository<applicant_info> applicant_infos
            => _applicant_infos ??= new GenericRepository<applicant_info>(_context);


        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}