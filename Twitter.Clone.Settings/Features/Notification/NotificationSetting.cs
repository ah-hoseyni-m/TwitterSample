namespace Twitter.Clone.Settings.Features.Notification;

public abstract class NotificationSetting
{
    public Guid UserId { get; set; }
    public bool IsActive { get; set; }
}
