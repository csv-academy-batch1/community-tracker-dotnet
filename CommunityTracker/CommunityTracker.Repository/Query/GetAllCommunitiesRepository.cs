using CommunityTracker.Repository.Entities;
using CommunityTracker.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CommunityTracker.Repository.Query
{
    public partial class CommunityRepositoryQuery : ICommunityRepositoryQuery
    {
        /// <summary>
        /// Gets all communities.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Community>> GetAllCommunities()
        {
            return await _communityDbContext.community.ToListAsync();
        }

        /// <summary>
        /// Gets the community by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<Community> GetCommunityById(int id)
        {
            return await _communityDbContext.community.Where(x => x.CommunityId == id).FirstOrDefaultAsync();
        }
    }
}