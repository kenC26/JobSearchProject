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
    public class job_infosController : ControllerBase
    {


        private readonly IUnitOfWork _unitOfWork;

        public job_infosController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        //private readonly ApplicationDbContext _context;

        //public job_infosController(ApplicationDbContext context)
        //{
           // _context = context;
       // }

        // GET: api/job_infos
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<job_info>>> Getjob_infos()
        public async Task<IActionResult> Getjob_infos()
        {
            var job_infos = await _unitOfWork.job_infos.GetAll();
            return Ok(job_infos);
            //return await _context.job_infos.ToListAsync();
        }

        // GET: api/job_infos/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<job_info>> Getjob_info(int id)
        public async Task<IActionResult> Getjob_info(int id)
        {
            //var job_info = await _context.job_infos.FindAsync(id);
            var job_info = await _unitOfWork.job_infos.Get(q => q.Id == id);
            if (job_info == null)
            {
                return NotFound();
            }

            //return job_info;
            return Ok(job_info);
        }

        // PUT: api/job_infos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putjob_info(int id, job_info job_info)
        {
            if (id != job_info.Id)
            {
                return BadRequest();
            }

            //_context.Entry(job_info).State = EntityState.Modified;
            _unitOfWork.job_infos.Update(job_info);
            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await job_infoExists(id))
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

        // POST: api/job_infos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<job_info>> Postjob_info(job_info job_info)
        {
            //_context.job_infos.Add(job_info);
            //await _context.SaveChangesAsync();
            await _unitOfWork.job_infos.Insert(job_info);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("Getjob_info", new { id = job_info.Id }, job_info);
        }

        // DELETE: api/job_infos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletejob_info(int id)
        {
            //var job_info = await _context.job_infos.FindAsync(id);
            var job_info = await _unitOfWork.job_infos.Get(q => q.Id == id);
            if (job_info == null)
            {
                return NotFound();
            }

            //_context.job_infos.Remove(job_info);
            //await _context.SaveChangesAsync();
            await _unitOfWork.job_infos.Delete(id);
            await _unitOfWork.Save(HttpContext);


            return NoContent();
        }

        //private bool job_infoExists(int id)
        private async Task<bool> job_infoExists(int id)
        {
            var job_info = await _unitOfWork.job_infos.Get(q => q.Id == id);
            return job_info != null;
            //return _context.job_infos.Any(e => e.Id == id);
        }
    }
}
