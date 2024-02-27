using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using Twitter.Clone.Settings.Infrastructure;

namespace Twitter.Clone.Settings.Features.BlockedList.GetBlockedUsersByUserId
{
    public class GetIsBlockedByUserIdsQueryHandler : IRequestHandler<GetIsBlockedByUserIdsQuery, bool>
    {
        private readonly SettingsDbContext _dbContext;

        public GetIsBlockedByUserIdsQueryHandler(SettingsDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<bool> Handle(GetIsBlockedByUserIdsQuery request, CancellationToken cancellationToken)
        {
            foreach (var item in request.UserIds)
            {
                int count =  _dbContext.BlockedUsers.TakeWhile(x => x.UserId == item && request.UserIds.Contains( x.BlockedUserId)).Count();
                if (count > 1) return false;
            }
            return true;
        }
    }
}
