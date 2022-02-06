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
using Microsoft.AspNetCore.Authorization;

namespace JobSearchProject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Company_infosController : ControllerBase
    {


        private readonly IUnitOfWork _unitOfWork;

        public Company_infosController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        //private readonly ApplicationDbContext _context;

        //public Company_infosController(ApplicationDbContext context)
        //{
           // _context = context;
       // }

        // GET: api/Company_infos
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Company_info>>> GetCompany_infos()
        public async Task<IActionResult> GetCompany_infos()
        {
            var Company_infos = await _unitOfWork.Company_infos.GetAll();
            return Ok(Company_infos);
            //return await _context.Company_infos.ToListAsync();
        }

        // GET: api/Company_infos/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Company_info>> GetCompany_info(int id)
        public async Task<IActionResult> GetCompany_info(int id)
        {
            //var Company_info = await _context.Company_infos.FindAsync(id);
            var Company_info = await _unitOfWork.Company_infos.Get(q => q.Id == id);
            if (Company_info == null)
            {
                return NotFound();
            }

            //return Company_info;
            return Ok(Company_info);
        }

        // PUT: api/Company_infos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize(Roles = "Administrator,Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompany_info(int id, Company_info Company_info)
        {
            if (id != Company_info.Id)
            {
                return BadRequest();
            }

            //_context.Entry(Company_info).State = EntityState.Modified;
            _unitOfWork.Company_infos.Update(Company_info);
            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await Company_infoExists(id))
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

        // POST: api/Company_infos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize(Roles = "Administrator,Admin")]
        [HttpPost]
        public async Task<ActionResult<Company_info>> PostCompany_info(Company_info Company_info)
        {
            //_context.Company_infos.Add(Company_info);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Company_infos.Insert(Company_info);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCompany_info", new { id = Company_info.Id }, Company_info);
        }

        // DELETE: api/Company_infos/5
        [Authorize(Roles = "Administrator,Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompany_info(int id)
        {
            //var Company_info = await _context.Company_infos.FindAsync(id);
            var Company_info = await _unitOfWork.Company_infos.Get(q => q.Id == id);
            if (Company_info == null)
            {
                return NotFound();
            }

            //_context.Company_infos.Remove(Company_info);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Company_infos.Delete(id);
            await _unitOfWork.Save(HttpContext);


            return NoContent();
        }

        //private bool Company_infoExists(int id)
        private async Task<bool> Company_infoExists(int id)
        {
            var Company_info = await _unitOfWork.Company_infos.Get(q => q.Id == id);
            return Company_info != null;
            //return _context.Company_infos.Any(e => e.Id == id);
        }
    }
}
