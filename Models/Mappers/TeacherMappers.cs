using School.Models.Dtos;

namespace School.Models.Mappers
{
    public static class TeacherMappers
    {
        public static TeacherDto ToTeacherDto(this TeacherDto Teacher)
        {
            return new TeacherDto
            {
                Id = Teacher.Id,
                Name = Teacher.Name,
                age = Teacher.age,
                salary = Teacher.salary,
                

            };
        }
    }
}
