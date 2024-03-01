using MediatR;

namespace Twitter.Clone.Settings.Features.BlockedList.GetBlockedUsersByUserId;

public class GetBlockedUsersByUserIdQuery : IRequest<IEnumerable<GetBlockedUsersByUserIdResponse>>
{
    public Guid UserId { get; set; }
}

public class GetBlockedUsersByUserIdResponse
{
    public Guid BlockedUserId { get; set; }

}
