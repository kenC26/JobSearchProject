using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JobSearchProject.Server.Data;
using JobSearchProject.Shared.Domain;
using JobSearchProject.Server.IRepository;

namespace JobSearchProject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class job_locationsController : ControllerBase
    {


        private readonly IUnitOfWork _unitOfWork;

        public job_locationsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        //private readonly ApplicationDbContext _context;

        //public job_locationsController(ApplicationDbContext context)
        //{
           // _context = context;
       // }

        // GET: api/job_locations
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<job_location>>> Getjob_locations()
        public async Task<IActionResult> Getjob_locations()
        {
            var job_locations = await _unitOfWork.job_locations.GetAll();
            return Ok(job_locations);
            //return await _context.job_locations.ToListAsync();
        }

        // GET: api/job_locations/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<job_location>> Getjob_location(int id)
        public async Task<IActionResult> Getjob_location(int id)
        {
            //var job_location = await _context.job_locations.FindAsync(id);
            var job_location = await _unitOfWork.job_locations.Get(q => q.Id == id);
            if (job_location == null)
            {
                return NotFound();
            }

            //return job_location;
            return Ok(job_location);
        }

        // PUT: api/job_locations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putjob_location(int id, job_location job_location)
        {
            if (id != job_location.Id)
            {
                return BadRequest();
            }

            //_context.Entry(job_location).State = EntityState.Modified;
            _unitOfWork.job_locations.Update(job_location);
            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await job_locationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/job_locations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<job_location>> Postjob_location(job_location job_location)
        {
            //_context.job_locations.Add(job_location);
            //await _context.SaveChangesAsync();
            await _unitOfWork.job_locations.Insert(job_location);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("Getjob_location", new { id = job_location.Id }, job_location);
        }

        // DELETE: api/job_locations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletejob_location(int id)
        {
            //var job_location = await _context.job_locations.FindAsync(id);
            var job_location = await _unitOfWork.job_locations.Get(q => q.Id == id);
            if (job_location == null)
            {
                return NotFound();
            }

            //_context.job_locations.Remove(job_location);
            //await _context.SaveChangesAsync();
            await _unitOfWork.job_locations.Delete(id);
            await _unitOfWork.Save(HttpContext);


            return NoContent();
        }

        //private bool job_locationExists(int id)
        private async Task<bool> job_locationExists(int id)
        {
            var job_location = await _unitOfWork.job_locations.Get(q => q.Id == id);
            return job_location != null;
            //return _context.job_locations.Any(e => e.Id == id);
        }
    }
}
