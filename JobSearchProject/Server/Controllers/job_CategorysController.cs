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
    public class job_CategorysController : ControllerBase
    {


        private readonly IUnitOfWork _unitOfWork;

        public job_CategorysController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        //private readonly ApplicationDbContext _context;

        //public job_CategorysController(ApplicationDbContext context)
        //{
           // _context = context;
       // }

        // GET: api/job_Categorys
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<job_Category>>> Getjob_Categorys()
        public async Task<IActionResult> Getjob_Categorys()
        {
            var job_Categorys = await _unitOfWork.job_Categorys.GetAll();
            return Ok(job_Categorys);
            //return await _context.job_Categorys.ToListAsync();
        }

        // GET: api/job_Categorys/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<job_Category>> Getjob_Category(int id)
        public async Task<IActionResult> Getjob_Category(int id)
        {
            //var job_Category = await _context.job_Categorys.FindAsync(id);
            var job_Category = await _unitOfWork.job_Categorys.Get(q => q.Id == id);
            if (job_Category == null)
            {
                return NotFound();
            }

            //return job_Category;
            return Ok(job_Category);
        }

        // PUT: api/job_Categorys/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putjob_Category(int id, job_Category job_Category)
        {
            if (id != job_Category.Id)
            {
                return BadRequest();
            }

            //_context.Entry(job_Category).State = EntityState.Modified;
            _unitOfWork.job_Categorys.Update(job_Category);
            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await job_CategoryExists(id))
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

        // POST: api/job_Categorys
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<job_Category>> Postjob_Category(job_Category job_Category)
        {
            //_context.job_Categorys.Add(job_Category);
            //await _context.SaveChangesAsync();
            await _unitOfWork.job_Categorys.Insert(job_Category);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("Getjob_Category", new { id = job_Category.Id }, job_Category);
        }

        // DELETE: api/job_Categorys/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletejob_Category(int id)
        {
            //var job_Category = await _context.job_Categorys.FindAsync(id);
            var job_Category = await _unitOfWork.job_Categorys.Get(q => q.Id == id);
            if (job_Category == null)
            {
                return NotFound();
            }

            //_context.job_Categorys.Remove(job_Category);
            //await _context.SaveChangesAsync();
            await _unitOfWork.job_Categorys.Delete(id);
            await _unitOfWork.Save(HttpContext);


            return NoContent();
        }

        //private bool job_CategoryExists(int id)
        private async Task<bool> job_CategoryExists(int id)
        {
            var job_Category = await _unitOfWork.job_Categorys.Get(q => q.Id == id);
            return job_Category != null;
            //return _context.job_Categorys.Any(e => e.Id == id);
        }
    }
}
