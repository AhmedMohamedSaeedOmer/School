using School.Models.Dtos;

namespace School.Models.Mappers
{
    public static class SchooolMapper
    {
        public static SchooolDto ToSchooolDto(this SchooolDto Schoool)
        {
            return new SchooolDto
            {
                Id = Schoool.Id,
                Name = Schoool.Name,
                Type = Schoool.Type,
                Location = Schoool.Location,


            };
        }
    }
}
