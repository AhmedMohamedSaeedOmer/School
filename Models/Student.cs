using System.ComponentModel.DataAnnotations.Schema;

namespace School.Models
{
    public class Student
    {
        [key]
        public int Id { get; set; }

        public string? Name { get; set; }
        public int age { get; set; }
        public string? phone { get; set; }

        public Schoool? schoool { get; set; }
        [ForeignKey(nameof(school_id))]

        public int school_id { get; set; }

        
    }
}
