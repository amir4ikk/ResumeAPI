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

    public static implicit operator Resume(AddResumeDto resume)
    {
        return new Resume
        {
            Name = resume.Name,
            Contact = resume.Contact,
            Location = resume.Location,
            WorkingExperience = resume.WorkingExperience,
            Education = resume.Education,
            Description = resume.Description,
            ProgrammingLanguages = resume.ProgrammingLanguages,
            Languages = resume.Languages,
            FilePath = resume.FilePath,
            UserId = resume.UserId
        };
    }
}
