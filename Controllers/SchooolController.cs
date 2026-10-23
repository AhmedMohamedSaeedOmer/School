using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.Data;
using School.Models;

namespace School.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchooolController : ControllerBase
    {
        private readonly SDbContext _context;

        public SchooolController(SDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetAllSchoool")]
        public async Task<IActionResult> GetAllSchoool()
        {
            List<Schoool> Schoools = await _context.schoools.ToListAsync();
            return Ok(Schoools);
        }



        [HttpGet("{id}")]
        public IActionResult GetSchooolById(int id)
        {
            Schoool Schoools = _context.schoools.Where(s => s.Id == id).First();

            return Ok(Schoools);
        }
        [HttpPost]
        public IActionResult AddNewSchoool(Schoool schoool)
        {
            _context.schoools.Add(schoool);
            _context.SaveChanges();
            return Created();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSchoool(int id, Schoool newschoool)
        {

            _context.schoools.Update(newschoool);
            await _context.SaveChangesAsync();
            return Ok(newschoool);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSchooolById(int id)
        {

            Schoool schoool = await _context.schoools.FindAsync(id);
            if (schoool == null)
            {
                return BadRequest($"Not Found Schoool With Id = {id}");
            }

            await _context.SaveChangesAsync();
            return Ok(schoool);
        }
    }
}
