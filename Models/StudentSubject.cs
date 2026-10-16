using Microsoft.EntityFrameworkCore;

namespace School.Models
{
    [PrimaryKey(nameof(StudentId), nameof(SubjectId))]
    public class StudentSubject
    {
        public int StudentId { get; set; }
        public Student? Student { get; set; } 

        public int SubjectId { get; set; }
        public Subject? Subject { get; set; } 
    }
}
