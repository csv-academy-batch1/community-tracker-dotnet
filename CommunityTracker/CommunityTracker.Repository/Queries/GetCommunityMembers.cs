using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Repository.RepositoryDTO;
using Microsoft.EntityFrameworkCore;

namespace CommunityTracker.Repository.Queries
{
    public partial class CommunityRepositoryQueries : ICommunityRepositoryQueries
    {
        public async Task<List<CommunityMembers>> GetAllMembers()
        {
            return await _communityDbContext.people.ToListAsync();
        }

    }
}
