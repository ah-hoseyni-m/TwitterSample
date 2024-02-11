using MediatR;
using Microsoft.AspNetCore.Mvc;
using Twitter.Clone.Settings.Features.BlockedList.GetBlockedPagesByUserId;
using Twitter.Clone.Settings.Features.Notification.GetSettingById;

namespace Twitter.Clone.Settings.Features.Notification;

[ApiController]
[Route("Settings/{UserId}/[controller]")]
public class NotificationController : ControllerBase
{
    private readonly IMediator mediator;
    public NotificationController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpGet()]
    public async Task<UserNotificationsResponse> Index(int UserId)
    {
        UserNotificationsQuery userNotificationsInput = new();
        userNotificationsInput.UserId = UserId;
        var Result = await mediator.Send(userNotificationsInput);
        return Result;
    }
}
