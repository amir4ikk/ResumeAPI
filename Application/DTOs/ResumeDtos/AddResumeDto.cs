using Domain.Entities;

namespace Application.DTOs.ResumeDtos;
public class AddResumeDto
{
    public string Name { get; set; } = string.Empty;
    public string Contact { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public int WorkingExperience { get; set; }
    public string Education { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ProgrammingLanguages { get; set; } = string.Empty;
    public string Languages { get; set; } = string.Empty;
    public int UserId { get; set; }
    public string FilePath { get; set; } = string.Empty;
    public int ReviewId { get; set; }

    public static implicit operator Resume(AddResumeDto dto)
    {
        return new Resume
        {
            Name = dto.Name,
            Contact = dto.Contact,
            Location = dto.Location,
            WorkingExperience = dto.WorkingExperience,
            Education = dto.Education,
            Description = dto.Description,
            ProgrammingLanguages = dto.ProgrammingLanguages,
            Languages = dto.Languages,
            UserId = dto.UserId,
            FilePath = dto.FilePath,
        };
    }
}
