using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Twitter.Clone.Settings.Features.Notification;
using Twitter.Clone.Settings.Features.BlockedList;

namespace Twitter.Clone.Settings.Infrastructure.Configuration;


public class BlockedUserConfiguration : IEntityTypeConfiguration<BlockedUser>, IEntityConfiguration
{
    public void Configure(EntityTypeBuilder<BlockedUser> builder)
    {
        builder.HasKey(x => x.id);
        builder.Property(x => x.id).ValueGeneratedOnAdd();

        builder.HasIndex(x => x.UserId);
        builder.Property(x => x.UserId).ValueGeneratedNever();

    }
}
