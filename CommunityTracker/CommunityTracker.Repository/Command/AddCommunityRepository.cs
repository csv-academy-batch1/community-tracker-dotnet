using CommunityTracker.Repository.Entities;
using CommunityTracker.Repository.Interfaces;

namespace CommunityTracker.Repository.Command
{
    public partial class CommunityRepositoryCommands : ICommunityRepositoryCommands
    {
        public async Task AddCommunityRepository(Community communityData)
        {
            await _communityDbContext.AddAsync(communityData);
            await _communityDbContext.SaveChangesAsync();
        }
    }
}