using Domain.Entities;

namespace Application.DTOs.NotificationDtos;
public class NotificationDto
{
    public int Id { get; set; }
    public Review Review { get; set; } = null!;
    public int ReviewId { get; set; }

    public static implicit operator NotificationDto(Notification notification)
    {
        return new NotificationDto()
        {
            Id = notification.Id,
            Review = notification.Review,
            ReviewId = notification.ReviewId
        };
    }
}
