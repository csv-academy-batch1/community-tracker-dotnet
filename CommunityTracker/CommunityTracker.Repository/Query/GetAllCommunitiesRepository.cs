using CommunityTracker.Repository.Entities;
using CommunityTracker.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CommunityTracker.Repository.Query
{
    public partial class CommunityRepositoryQuery : ICommunityRepositoryQuery
    {
        private IQueryable<Community> GetCommunities()
        {
            return  _communityDbContext.community.AsQueryable();
        }

        public async Task<List<Community>> GetAllCommunities()
        {
            return await GetCommunities().ToListAsync();
        }

        public async Task<Community> GetCommunityById(int id)
        {
            return await GetCommunities().Where(x => x.CommunityId == id).FirstOrDefaultAsync();
        }

    }
}
