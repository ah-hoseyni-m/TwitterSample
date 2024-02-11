using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using Twitter.Clone.Settings.Infrastructure;

namespace Twitter.Clone.Settings.Features.BlockedList.GetBlockedPagesByUserId
{
    public class GetBlockedPagesByUserIdQueryHandler : IRequestHandler<GetBlockedPagesByUserIdQuery, IEnumerable< GetBlockedPagesByUserIdResponse>>
    {
        private readonly SettingsDbContext _dbContext;

        public GetBlockedPagesByUserIdQueryHandler(SettingsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<GetBlockedPagesByUserIdResponse>> Handle(GetBlockedPagesByUserIdQuery request, CancellationToken cancellationToken)
        {
            GetBlockedPagesByUserIdResponse response = new();
            var BlockedList = await _dbContext.BlockedPages.Where(x => x.UserId == request.UserId).Select(b => new  GetBlockedPagesByUserIdResponse
            {
                BlockedPageId = b.BlockedPageId
                
            }).ToListAsync();
            

            return BlockedList;
        }
    }
}
