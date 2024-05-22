using Domain.Entities;

namespace Application.DTOs.ReviewDtos;
public class ReviewDto : AddReviewDto
{
    public int Id { get; set; }
    public User User { get; set; } = null!;

    public static implicit operator ReviewDto(Review review)
    {
        return new ReviewDto()
        {
            Id = review.Id,
            Description = review.Description,
            NeedLanguages = review.NeedLanguages,
            NeedProgrammingLanguages = review.NeedProgrammingLanguages,
            NeedWorkingExperience = review.NeedWorkingExperience,
            NeedEducation = review.NeedEducation,
            IsSerching = review.IsSerching,
            UserId = review.UserId,
        };
    }
}
