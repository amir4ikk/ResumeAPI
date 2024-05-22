using Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ResumeAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NotificationsController(INotificationsService notificationsService) : ControllerBase
{
    private readonly INotificationsService _notificationsService = notificationsService;

    [Authorize]
    public async Task<IActionResult> GetAllAsync()
    {
        return Ok(await _notificationsService.GetAllWorkingReviewsAsync());
    }
}
