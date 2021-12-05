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
    public class applicant_infosController : ControllerBase
    {


        private readonly IUnitOfWork _unitOfWork;

        public applicant_infosController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        //private readonly ApplicationDbContext _context;

        //public applicant_infosController(ApplicationDbContext context)
        //{
           // _context = context;
       // }

        // GET: api/applicant_infos
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<applicant_info>>> Getapplicant_infos()
        public async Task<IActionResult> Getapplicant_infos()
        {
            var applicant_infos = await _unitOfWork.applicant_infos.GetAll();
            return Ok(applicant_infos);
            //return await _context.applicant_infos.ToListAsync();
        }

        // GET: api/applicant_infos/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<applicant_info>> Getapplicant_info(int id)
        public async Task<IActionResult> Getapplicant_info(int id)
        {
            //var applicant_info = await _context.applicant_infos.FindAsync(id);
            var applicant_info = await _unitOfWork.applicant_infos.Get(q => q.Id == id);
            if (applicant_info == null)
            {
                return NotFound();
            }

            //return applicant_info;
            return Ok(applicant_info);
        }

        // PUT: api/applicant_infos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putapplicant_info(int id, applicant_info applicant_info)
        {
            if (id != applicant_info.Id)
            {
                return BadRequest();
            }

            //_context.Entry(applicant_info).State = EntityState.Modified;
            _unitOfWork.applicant_infos.Update(applicant_info);
            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await applicant_infoExists(id))
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

        // POST: api/applicant_infos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<applicant_info>> Postapplicant_info(applicant_info applicant_info)
        {
            //_context.applicant_infos.Add(applicant_info);
            //await _context.SaveChangesAsync();
            await _unitOfWork.applicant_infos.Insert(applicant_info);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("Getapplicant_info", new { id = applicant_info.Id }, applicant_info);
        }

        // DELETE: api/applicant_infos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteapplicant_info(int id)
        {
            //var applicant_info = await _context.applicant_infos.FindAsync(id);
            var applicant_info = await _unitOfWork.applicant_infos.Get(q => q.Id == id);
            if (applicant_info == null)
            {
                return NotFound();
            }

            //_context.applicant_infos.Remove(applicant_info);
            //await _context.SaveChangesAsync();
            await _unitOfWork.applicant_infos.Delete(id);
            await _unitOfWork.Save(HttpContext);


            return NoContent();
        }

        //private bool applicant_infoExists(int id)
        private async Task<bool> applicant_infoExists(int id)
        {
            var applicant_info = await _unitOfWork.applicant_infos.Get(q => q.Id == id);
            return applicant_info != null;
            //return _context.applicant_infos.Any(e => e.Id == id);
        }
    }
}
