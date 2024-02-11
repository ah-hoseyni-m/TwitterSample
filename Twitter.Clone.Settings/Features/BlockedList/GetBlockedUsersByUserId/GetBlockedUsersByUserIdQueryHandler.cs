using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using Twitter.Clone.Settings.Infrastructure;

namespace Twitter.Clone.Settings.Features.BlockedList.GetBlockedUsersByUserId
{
    public class GetBlockedUsersByUserIdQueryHandler : IRequestHandler<GetBlockedUsersByUserIdQuery, IEnumerable<GetBlockedUsersByUserIdResponse>>
    {
        private readonly SettingsDbContext _dbContext;

        public GetBlockedUsersByUserIdQueryHandler(SettingsDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<IEnumerable<GetBlockedUsersByUserIdResponse>> Handle(GetBlockedUsersByUserIdQuery request, CancellationToken cancellationToken)
        {
            GetBlockedUsersByUserIdResponse response = new();
            var BlockedList = await _dbContext.BlockedUsers.Where(x => x.UserId == request.UserId).Select(b => new GetBlockedUsersByUserIdResponse
            {
                BlockedUserId = b.BlockedUserId

            }).ToListAsync();


            return BlockedList;
        }
    }
}
