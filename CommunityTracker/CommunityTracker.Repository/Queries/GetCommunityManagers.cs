using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Repository.RepositoryDTO;
using Microsoft.EntityFrameworkCore;

namespace CommunityTracker.Repository.Queries
{
    public partial class CommunityRepositoryQuery : ICommunityRepositoryQuery
    {
        /// <summary>Gets all managers.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        public async Task<List<CommunityManagers>> GetAllManagers()
        {
            return await _communityDbContext.communityadminandmanager.ToListAsync();
        }

        /// <summary>Gets the community managers by identifier.</summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public async Task<CommunityManagers> GetCommunityManagersById(int id)
        {
            return await _communityDbContext.communityadminandmanager.Where(x => x.CommunityAdminAndManagerId == id).FirstOrDefaultAsync();
        }
    }
}