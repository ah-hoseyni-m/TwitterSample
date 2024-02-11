using Microsoft.EntityFrameworkCore;
using System;
using Twitter.Clone.Settings.Features.BlockedList;
using Twitter.Clone.Settings.Features.Notification;

namespace Twitter.Clone.Settings.Infrastructure;

public class SettingsDbContext :DbContext
{
    public SettingsDbContext(DbContextOptions<SettingsDbContext> options) : base(options)
    {
    }

    #region DbSet Section
    public DbSet<EmailNotificationSetting> EmailNotificationSetting { get; set; }
    public DbSet<PushNotificationSetting> PushNotificationSetting { get; set; }
    public DbSet<SmsNotificationSetting> SmsNotificationSetting { get; set; }
    public DbSet<BlockedPage> BlockedPages { get; set; }
    public DbSet<BlockedUser> BlockedUsers { get; set; }



    #endregion
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        ///Assembly All Entity Configuration///
        builder.ApplyConfigurationsFromAssembly(typeof(IEntityConfiguration).Assembly);

    }

}
