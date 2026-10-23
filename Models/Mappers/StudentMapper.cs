using School.Models.Dtos;

namespace School.Models.Mappers
{
    public static class StudentMapper
    {


        public static StudentDto ToStudentDto(this StudentDto Student)
        {
            return new StudentDto
            {
                Id = Student.Id,
                Name = Student.Name,
                age = Student.age,
                phone = Student.phone,


            };
        }

    }
}

