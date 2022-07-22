using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Repository.RepositoryDTO;
using Microsoft.EntityFrameworkCore;

namespace CommunityTracker.Repository.Queries
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="CommunityTracker.Repository.Interfaces.ICommunityRepositoryMembers" />
    public partial class CommunityMembersRepository : ICommunityRepositoryMembers
    {
        /// <summary>
        /// Gets all members.
        /// </summary>
        /// <returns></returns>
        public async Task<List<CommunityMembers>> GetAllMembers()
        {
            return await _communityDbContext.people.ToListAsync();
        }

    }
}
