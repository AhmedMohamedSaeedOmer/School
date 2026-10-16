using System.ComponentModel.DataAnnotations.Schema;

namespace School.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int age { get; set; }
        [Column(TypeName = ("decimal (18,2)"))]
        public decimal salary { get; set; }

        public Schoool? schoool { get; set; }
        [ForeignKey(nameof(school_id))]
        public int school_id { get; set; }
    }
}
