using MediatR;
using System;
using Twitter.Clone.Settings.Infrastructure;

namespace Twitter.Clone.Settings.Features.Notification.GetSettingById
{
    public class UserNotificationsQueryHandler :IRequestHandler<UserNotificationsQuery, UserNotificationsResponse>
    {
        private readonly SettingsDbContext _dbContext;

        public UserNotificationsQueryHandler(SettingsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<UserNotificationsResponse> Handle(UserNotificationsQuery request, CancellationToken cancellationToken)
        {
            UserNotificationsResponse userNotificationsOutPut = new();
            var sms = _dbContext.SmsNotificationSetting.Where(x => x.UserId == request.UserId).FirstOrDefault();
            var Email = _dbContext.EmailNotificationSetting.Where(x => x.UserId == request.UserId).FirstOrDefault();
            var Push = _dbContext.PushNotificationSetting.Where(x => x.UserId == request.UserId).FirstOrDefault();


            userNotificationsOutPut.Sms.IsActive = sms.IsActive;
            userNotificationsOutPut.Sms.PasswordChange = sms.PasswordChange;
            userNotificationsOutPut.Email.IsActive = Email.IsActive;
            userNotificationsOutPut.Email.Mention = Email.Mention;
            userNotificationsOutPut.Email.DirectMessage = Email.DirectMessage;
            userNotificationsOutPut.Email.Following = Email.Following;
            userNotificationsOutPut.Push.IsActive = Push.IsActive;
            userNotificationsOutPut.Push.Mention = Push.Mention;
            userNotificationsOutPut.Push.DirectMessage = Push.DirectMessage;
            userNotificationsOutPut.Push.Following = Push.Following;


            return Task.FromResult(userNotificationsOutPut);
        }
    }
}
