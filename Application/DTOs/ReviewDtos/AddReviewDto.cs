using Domain.Entities;

namespace Application.DTOs.ReviewDtos;
public class AddReviewDto
{
    public int NeedWorkingExperience { get; set; }
    public string NeedEducation { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string NeedProgrammingLanguages { get; set; } = string.Empty;
    public string NeedLanguages { get; set; } = string.Empty;
    public bool IsSerching { get; set; }
    public int UserId { get; set; }

    public static implicit operator Review(AddReviewDto dto)
    {
        return new Review
        {
            Description = dto.Description,
            NeedLanguages = dto.NeedLanguages,
            NeedProgrammingLanguages = dto.NeedProgrammingLanguages,
            NeedWorkingExperience = dto.NeedWorkingExperience,
            NeedEducation = dto.NeedEducation,
            IsSerching = dto.IsSerching,
            UserId = dto.UserId,
        };
    }
}
