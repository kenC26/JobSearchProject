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
    public class ApplicantDetailsController : ControllerBase
    {


        private readonly IUnitOfWork _unitOfWork;

        public ApplicantDetailsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        //private readonly ApplicationDbContext _context;

        //public ApplicantDetailsController(ApplicationDbContext context)
        //{
           // _context = context;
       // }

        // GET: api/ApplicantDetails
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<ApplicantDetail>>> GetApplicantDetails()
        public async Task<IActionResult> GetApplicantDetails()
        {
            var ApplicantDetails = await _unitOfWork.ApplicantDetails.GetAll(includes: q => q.Include(x =>x.Job_info));
            return Ok(ApplicantDetails);
            //return await _context.ApplicantDetails.ToListAsync();
        }

        // GET: api/ApplicantDetails/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<ApplicantDetail>> GetApplicantDetail(int id)
        public async Task<IActionResult> GetApplicantDetail(int id)
        {
            //var ApplicantDetail = await _context.ApplicantDetails.FindAsync(id);
            var ApplicantDetail = await _unitOfWork.ApplicantDetails.Get(q => q.Id == id);
            if (ApplicantDetail == null)
            {
                return NotFound();
            }

            //return ApplicantDetail;
            return Ok(ApplicantDetail);
        }

        // PUT: api/ApplicantDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApplicantDetail(int id, ApplicantDetail ApplicantDetail)
        {
            if (id != ApplicantDetail.Id)
            {
                return BadRequest();
            }

            //_context.Entry(ApplicantDetail).State = EntityState.Modified;
            _unitOfWork.ApplicantDetails.Update(ApplicantDetail);
            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ApplicantDetailExists(id))
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

        // POST: api/ApplicantDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ApplicantDetail>> PostApplicantDetail(ApplicantDetail ApplicantDetail)
        {
            //_context.ApplicantDetails.Add(ApplicantDetail);
            //await _context.SaveChangesAsync();
            await _unitOfWork.ApplicantDetails.Insert(ApplicantDetail);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetApplicantDetail", new { id = ApplicantDetail.Id }, ApplicantDetail);
        }

        // DELETE: api/ApplicantDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApplicantDetail(int id)
        {
            //var ApplicantDetail = await _context.ApplicantDetails.FindAsync(id);
            var ApplicantDetail = await _unitOfWork.ApplicantDetails.Get(q => q.Id == id);
            if (ApplicantDetail == null)
            {
                return NotFound();
            }

            //_context.ApplicantDetails.Remove(ApplicantDetail);
            //await _context.SaveChangesAsync();
            await _unitOfWork.ApplicantDetails.Delete(id);
            await _unitOfWork.Save(HttpContext);


            return NoContent();
        }

        //private bool ApplicantDetailExists(int id)
        private async Task<bool> ApplicantDetailExists(int id)
        {
            var ApplicantDetail = await _unitOfWork.ApplicantDetails.Get(q => q.Id == id);
            return ApplicantDetail != null;
            //return _context.ApplicantDetails.Any(e => e.Id == id);
        }
    }
}
