using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Repository.RepositoryDTO;
using Microsoft.EntityFrameworkCore;

namespace CommunityTracker.Repository.Queries
{
    public partial class CommunityRepositoryQueries : ICommunityRepositoryQueries
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

        /// <summary>
        /// Gets the name of communities with manager name.
        /// </summary>
        /// <param name="managerId">The manager identifier.</param>
        /// <param name="communityName">Name of the community.</param>
        /// <returns></returns>
        public async Task<CommunityDetails> GetCommunitiesWithManagerName(int? managerId, string communityName)
        {
            if (managerId == null && communityName == null)
            {
                return null;
            }

            var data = await (from c in _communityDbContext.community
                              join cm in _communityDbContext.communityadminandmanager
                              on c.CommunityMgrid equals cm.CommunityAdminAndManagerId
                              where c.CommunityMgrid == managerId && c.CommunityName.ToLower() == communityName.ToLower()
                              select new CommunityDetails
                              {
                                  CommunityId = c.CommunityId,
                                  CommunityName = c.CommunityName,
                                  CommunityDesc = c.CommunityDesc,
                                  CommunityMgrid = c.CommunityMgrid,
                                  CommunityAdminAndManagerName = cm.CommunityAdminAndManagerName
                              }).FirstOrDefaultAsync();

            return data;
        }
    }
}