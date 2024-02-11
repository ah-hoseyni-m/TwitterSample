using MediatR;

namespace Twitter.Clone.Settings.Features.BlockedList.GetBlockedUsersByUserId
{
    public class GetBlockedUsersByUserIdQuery : IRequest<IEnumerable<GetBlockedUsersByUserIdResponse>>
    {
        public int UserId { get; set; }
    }
}
