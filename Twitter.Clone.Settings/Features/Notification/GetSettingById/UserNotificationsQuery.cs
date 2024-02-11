using MediatR;

namespace Twitter.Clone.Settings.Features.Notification.GetSettingById
{
    public class UserNotificationsQuery : IRequest<UserNotificationsResponse>
    {
        public int UserId { get; set; }
    }
}
