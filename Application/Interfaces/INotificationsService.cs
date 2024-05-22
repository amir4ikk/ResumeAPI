using Application.DTOs.NotificationDtos;

namespace Application.Interfaces;
public interface INotificationsService
{
    Task<List<NotificationDto>> GetAllWorkingReviewsAsync();
}
