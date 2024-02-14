using MediatR;

namespace Twitter.Clone.Settings.Features.Notification.GetSettingById
{
    public class UserNotificationsQuery : IRequest<UserNotificationsResponse>
    {
        public Guid UserId { get; set; }
    }
}
