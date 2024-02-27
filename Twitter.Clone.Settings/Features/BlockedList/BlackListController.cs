using MediatR;
using Microsoft.AspNetCore.Mvc;
using Twitter.Clone.Settings.Features.BlockedList.GetBlockedPagesByUserId;
using Twitter.Clone.Settings.Features.BlockedList.GetBlockedUsersByUserId;
using Twitter.Clone.Settings.Features.Notification.GetSettingById;

namespace Twitter.Clone.Settings.Features.BlockedList
{
    [ApiController]
    [Route("Settings/{UserId}/")]
    public class BlackListController : ControllerBase
    {
        private readonly IMediator mediator;
        public BlackListController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpGet("Blocked-Pages")]
        public async Task<IEnumerable<GetBlockedPagesByUserIdResponse>> GetPages(Guid UserId)
        {
            GetBlockedPagesByUserIdQuery getBlockedPagesByUserIdQuery = new();
            getBlockedPagesByUserIdQuery.UserId = UserId;
            var Result = await mediator.Send(getBlockedPagesByUserIdQuery);
            return Result;
        }
        [HttpGet("Blocked-Users")]
        public async Task<IEnumerable<GetBlockedUsersByUserIdResponse>> GetUsers(Guid UserId)
        {
            GetBlockedUsersByUserIdQuery getBlockedUsersByUserIdQuery = new();
            getBlockedUsersByUserIdQuery.UserId = UserId;
            var Result = await mediator.Send(getBlockedUsersByUserIdQuery);
            return Result;
        }
        [HttpGet("Blocked-Users")]
        public async Task<bool> GetIsBlocked(List< Guid> UserIds)
        {
            GetIsBlockedByUserIdsQuery getIsBlockedByUserIdsQuery = new();
            getIsBlockedByUserIdsQuery.UserIds = UserIds;
            var Result = await mediator.Send(getIsBlockedByUserIdsQuery);
            return Result;
        }
    }
}
