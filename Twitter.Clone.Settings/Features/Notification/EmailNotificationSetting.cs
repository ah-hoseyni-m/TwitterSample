namespace Twitter.Clone.Settings.Features.Notification
{
    public class EmailNotificationSetting : NotificationSetting
    {
        public bool Mention { get; set; }
        public bool DirectMessage { get; set; }
        public bool Following { get; set; }
    }
}
