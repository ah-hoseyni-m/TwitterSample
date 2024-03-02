using MediatR;

namespace Twitter.Clone.Settings.Features.BlockedList.GetBlockedUsersByUserId;

public class GetIsBlockedByUserIdsQuery : IRequest<bool>
{
    public List<Guid> UserIds { get; set; }
}

public class GetIsBlockedByUserIdsResponse
{
    public Guid BlockedUserId { get; set; }
}

