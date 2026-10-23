using School.Data;
using School.Models;
using School.Models.Dtos;
using School.Models.Mappers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace School.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly SDbContext _context;

        public TeacherController(SDbContext context)
        {
            _context = context;
        }
        
        [HttpGet("GetAllTeacher")]
        public async Task<IActionResult> GetAllTeacher()
        {
            List<Teacher> teachers = await _context.teachers.ToListAsync();
            return Ok(teachers);
        }

        

        [HttpGet("{id}")]
        public IActionResult GetTeacherById(int id)
        {
            Teacher Teachers = _context.teachers.Where(s => s.Id == id).First();

            return Ok(Teachers);
        }
        [HttpPost]
        public IActionResult AddNewTeacher(Teacher teacher)
        {
            _context.teachers.Add(teacher);
            _context.SaveChanges();
            return Created();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTeacher(int id, Teacher newteacher)
        {
            
            _context.teachers.Update(newteacher);
            await _context.SaveChangesAsync();
            return Ok(newteacher);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeacherById(int id)
        {
            
            Teacher teacher = await _context.teachers.FindAsync(id);
            if (teacher == null)
            {
                return BadRequest($"Not Found Teacher With Id = {id}");
            }
            
            await _context.SaveChangesAsync();
            return Ok(teacher);
        }
    }
}

