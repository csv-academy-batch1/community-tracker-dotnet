using CommunityTracker.Repository.Entities;
using CommunityTracker.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CommunityTracker.Repository.Command
{
    public partial class CommunityRepositoryCommands : ICommunityRepositoryCommands
    {
        public async Task<List<Community>> GetAllCommunities()
        {
            return await _communityDbContext.community.ToListAsync();
        }
    }
}
