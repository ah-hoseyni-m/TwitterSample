using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Twitter.Clone.Settings.Features.Notification;


namespace Twitter.Clone.Settings.Infrastructure.Configuration;

public class EmailNotificationSettingConfiguration : IEntityTypeConfiguration<EmailNotificationSetting>, IEntityConfiguration
{
    public void Configure(EntityTypeBuilder<EmailNotificationSetting> builder)
    {
        builder.HasKey(x => x.UserId);
        builder.Property(x => x.UserId).ValueGeneratedNever();

    }
}
