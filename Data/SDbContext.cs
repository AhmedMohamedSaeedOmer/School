using School.Models;
using Microsoft.EntityFrameworkCore;
namespace School.Data
{
    public class SDbContext : DbContext

    {
        public SDbContext(DbContextOptions options) : base(options) { }
        

        public DbSet<Schoool>schoools { get; set; }

        public DbSet<Subject> subjects { get; set; }

        public DbSet<Teacher> teachers { get; set; }

        public DbSet<Student>students { get; set; }

        public DbSet<StudentSubject> studentSubjects { get; set; }

        public DbSet<TeacherSubject> teacherSubjects { get; set; }

        protected override void OnModelCreating(ModelBuilder Builder)
        {
                   Builder.Entity<Schoool>().HasData(
                   new Schoool()
                   {
                       Id = 1,
                       Name = "Mut Language School",
                       Location = "New vally",
                       Type = "language "
                   },

                   new Schoool()
                   {
                       Id = 2,
                       Name = "EL-Kawthar",
                       Location = "Assuit",
                       Type = "language "
                   },
                   new Schoool()
                   {
                       Id = 3,
                       Name = "Futur",
                       Location = "Assuit",
                       Type = "International "
                   }
                    );
            Builder.Entity<Teacher>().HasData(
                    new Teacher()
                    {
                        Id = 1,
                        Name = "Ahmed Mohamed Saeed Omer",
                        age = 23,
                        salary = 20000000,
                    },
                    new Teacher()
                    {
                        Id = 2,
                        Name = "Ahmed Mohamed Omer",
                        age = 24,
                        salary = 50000000,
                    },
                     new Teacher()
                     {
                         Id = 3,
                         Name = " Mohamed Saeed Omer",
                         age = 24,
                         salary = 80000000,
                     }

                );
            Builder.Entity<Student>().HasData(
                    new Student()
                    {
                        Id= 1,
                        age = 23,
                        Name="hamza mohamed saeed ",
                        phone ="01234567989",
                    },
                    new Student()
                    {
                        Id = 2,
                        age = 24,
                        Name = "mohamed saeed ",
                        phone = "01234567989",
                    }



                );


        }
       
    }
}
