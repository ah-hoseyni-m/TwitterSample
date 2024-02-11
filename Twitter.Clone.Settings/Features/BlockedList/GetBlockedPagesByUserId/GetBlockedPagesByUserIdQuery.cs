using MediatR;

namespace Twitter.Clone.Settings.Features.BlockedList.GetBlockedPagesByUserId
{
    public class GetBlockedPagesByUserIdQuery : IRequest<IEnumerable<GetBlockedPagesByUserIdResponse>>
    {
        public int UserId { get; set; }
    }
}
