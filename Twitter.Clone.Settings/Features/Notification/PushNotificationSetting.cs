namespace Twitter.Clone.Settings.Features.Notification
{
    public class PushNotificationSetting : NotificationSetting
    {
        public bool Mention { get; set; }
        public bool DirectMessage { get; set; }
        public bool Following { get; set; }
    }
}
