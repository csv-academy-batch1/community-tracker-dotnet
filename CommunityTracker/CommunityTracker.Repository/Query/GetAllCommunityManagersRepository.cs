using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Repository.RepositoryDTO;
using Microsoft.EntityFrameworkCore;

namespace CommunityTracker.Repository.Query
{
    public partial class CommunityRepositoryQuery : ICommunityRepositoryQuery
    {
        public async Task<List<CommunityManagers>> GetAllManagers()
        {
            return await _communityDbContext.communityadminandmanager.ToListAsync();
        }

        public async Task<CommunityManagers> GetCommunityManagersById(int id)
        {
            return await _communityDbContext.communityadminandmanager.Where(x => x.CommunityAdminAndManagerId == id).FirstOrDefaultAsync();
        }
    }
}
