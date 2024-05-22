using Domain.Entities;

namespace Application.DTOs.NotificationDtos;
public class UpdateNotificationDto
{
    public int Id { get; set; }
    public Review Review { get; set; } = null!;
    public int ReviewId { get; set; }

    public static implicit operator Notification(UpdateNotificationDto dto)
    {
        return new Notification()
        {
            Id = dto.Id,
            Review = dto.Review,
            ReviewId = dto.ReviewId,
        };
    }
}
