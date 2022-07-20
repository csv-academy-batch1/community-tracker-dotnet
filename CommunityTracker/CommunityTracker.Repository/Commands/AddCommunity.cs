using CommunityTracker.Repository.RepositoryDTO;
using CommunityTracker.Repository.Interfaces;

namespace CommunityTracker.Repository.Commands
{
    /// <summary>
    /// CommunityRepositoryCommands
    /// </summary>
    /// <seealso cref="CommunityTracker.Repository.Interfaces.ICommunityRepositoryCommands" />
    public partial class CommunityRepositoryCommands : ICommunityRepositoryCommands
    {
        /// <summary>
        /// Adds the community to the database.
        /// </summary>
        /// <param name="communityData">The community data.</param>
        public async Task AddCommunity(Community communityData)
        {
            try
            {
                await _communityDbContext.AddAsync(communityData);
                await SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}