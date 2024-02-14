using MediatR;

namespace Twitter.Clone.Settings.Features.BlockedList.GetBlockedPagesByUserId
{
    public class GetBlockedPagesByUserIdQuery : IRequest<IEnumerable<GetBlockedPagesByUserIdResponse>>
    {
        public Guid UserId { get; set; }
    }
}
