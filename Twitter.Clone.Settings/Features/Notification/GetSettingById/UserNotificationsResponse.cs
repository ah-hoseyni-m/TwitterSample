namespace Twitter.Clone.Settings.Features.Notification.GetSettingById;

public class UserNotificationsResponse
{
    public UserNotificationsResponse()
    {
        Email = new UserNotificationsEmailDto();
        Push = new UserNotificationsPushDto();
        Sms = new UserNotificationsSmsDto();
    }

    public UserNotificationsEmailDto Email { get; set; }
    public UserNotificationsPushDto Push { get; set; }
    public UserNotificationsSmsDto Sms { get; set; }
}

public class UserNotificationsEmailDto
{
    public bool IsActive { get; set; }
    public bool Mention { get; set; }
    public bool DirectMessage { get; set; }
    public bool Following { get; set; }
}
public class UserNotificationsPushDto
{
    public bool IsActive { get; set; }
    public bool Mention { get; set; }
    public bool DirectMessage { get; set; }
    public bool Following { get; set; }
}
public class UserNotificationsSmsDto
{
    public bool IsActive { get; set; }
    public bool PasswordChange { get; set; }
}

