using Microsoft.EntityFrameworkCore;

namespace School.Models
{
    [PrimaryKey(nameof(TeacherId), nameof(SubjectId))]
    public class TeacherSubject
    {
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; } 

        public int SubjectId { get; set; }
        public Subject? Subject { get; set; } 
    }
}
