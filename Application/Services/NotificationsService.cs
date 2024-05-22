using Application.DTOs.NotificationDtos;
using Application.DTOs.UserDtos;
using Application.Interfaces;
using Infastructure.Interfaces;

namespace Application.Services;
public class NotificationsService(IUnitOfWork unitOfWork) : INotificationsService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<List<NotificationDto>> GetAllWorkingReviewsAsync()
    {
        var users = await _unitOfWork.Notifications.GetAllWorkingReviewsAsync();
        return users.Select(x => (NotificationDto)x).ToList();
    }
}
