using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Repository.RepositoryDTO;
using Microsoft.EntityFrameworkCore;

namespace CommunityTracker.Repository.Query
{
    public partial class CommunityRepositoryQuery : ICommunityRepositoryQuery
    {
        public async Task<List<CommunityManagers>> GetAllCommunityManagers()
        {
            return await _communityDbContext.communityadminandmanager.ToListAsync();
        }
    }
}
