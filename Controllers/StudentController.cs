using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.Data;
using School.Models;

namespace School.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly SDbContext _context;

        public StudentController(SDbContext context)
        {
            _context = context;
        }
        
        [HttpGet("GetAllStudent")]
        public async Task<IActionResult> GetAllStudent()
        {
            List<Student> Students = await _context.students.ToListAsync();
            return Ok(Students);
        }



        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            Student Students = _context.students.Where(s => s.Id == id).First();

            return Ok(Students);
        }
        [HttpPost]
        public IActionResult AddNewStudent(Student student)
        {
            _context.students.Add(student);
            _context.SaveChanges();
            return Created();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStudent(int id, Student newstudent)
        {

            _context.students.Update(newstudent);
            await _context.SaveChangesAsync();
            return Ok(newstudent);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudentById(int id)
        {

            Student student = await _context.students.FindAsync(id);
            if (student == null)
            {
                return BadRequest($"Not Found Student With Id = {id}");
            }

            await _context.SaveChangesAsync();
            return Ok(student);
        }
    }
}
