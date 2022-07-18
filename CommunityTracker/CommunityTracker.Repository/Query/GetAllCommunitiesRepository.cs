using CommunityTracker.Repository.Entities;
using CommunityTracker.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CommunityTracker.Repository.Query
{
    public partial class CommunityRepositoryQuery : ICommunityRepositoryQuery
    {
        public async Task<List<Community>> GetAllCommunities()
        {
            return await _communityDbContext.community.ToListAsync();
        }
    }
}
