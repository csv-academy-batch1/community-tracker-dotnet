using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Repository.RepositoryDTO;
using Microsoft.EntityFrameworkCore;

namespace CommunityTracker.Repository.Query
{
    public partial class CommunityRepositoryQuery : ICommunityRepositoryQuery
    {
        private IQueryable<CommunityManagers> GetManagers()
        {
            return _communityDbContext.communityadminandmanager.AsQueryable();
        }

        public async Task<List<CommunityManagers>> GetAllManagers()
        {
            return await GetManagers().ToListAsync();
        }

        public async Task<CommunityManagers> GetCommunityManagersById(int id)
        {
            return await GetManagers().Where(x => x.CommunityAdminAndManagerId == id).FirstOrDefaultAsync();
        }
    }
}
