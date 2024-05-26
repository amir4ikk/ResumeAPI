using Domain.Entities;

namespace Application.DTOs.ResumeDtos;
public class ResumeDto : AddResumeDto
{
    public int Id { get; set; }
    public User User { get; set; } = null!;

    public static implicit operator ResumeDto(Resume resume)
    {
        return new ResumeDto()
        {
            Id = resume.Id,
            Name = resume.Name,
            Contact = resume.Contact,
            Location = resume.Location,
            WorkingExperience = resume.WorkingExperience,
            Education = resume.Education,
            Description = resume.Description,
            ProgrammingLanguages = resume.ProgrammingLanguages,
            Languages = resume.Languages,
            UserId = resume.UserId,
            FilePath = resume.FilePath,
        };
    }
}
