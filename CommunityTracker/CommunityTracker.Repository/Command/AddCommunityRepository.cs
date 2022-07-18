using CommunityTracker.Repository.Entities;
using CommunityTracker.Repository.Interfaces;

namespace CommunityTracker.Repository.Command
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="CommunityTracker.Repository.Interfaces.ICommunityRepositoryCommands" />
    public partial class CommunityRepositoryCommands : ICommunityRepositoryCommands
    {
        /// <summary>
        /// Adds the community repository.
        /// </summary>
        /// <param name="communityData">The community data.</param>
        public async Task AddCommunityRepository(Community communityData)
        {
            await _communityDbContext.AddAsync(communityData);
            await _communityDbContext.SaveChangesAsync();
        }
    }
}