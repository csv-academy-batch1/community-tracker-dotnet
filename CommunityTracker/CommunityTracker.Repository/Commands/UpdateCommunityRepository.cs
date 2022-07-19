using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Repository.RepositoryDTO;

namespace CommunityTracker.Repository.Commands
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="CommunityTracker.Repository.Interfaces.ICommunityRepositoryCommands" />
    public partial class CommunityRepositoryCommands : ICommunityRepositoryCommands
    {
        /// <summary>
        /// Updates the community repository.
        /// </summary>
        /// <param name="communityData">The community data.</param>
        public async Task UpdateCommunityRepository(Community communityData)
        {
            var community = _communityDbContext.community.FirstOrDefault(x => x.CommunityId == communityData.CommunityId);
            community.CommunityName = communityData.CommunityName;
            community.CommunityMgrid = communityData.CommunityMgrid;
            community.CommunityDesc = communityData.CommunityDesc;
            community.IsActive = communityData.IsActive;
            await _communityDbContext.SaveChangesAsync();
        }
    }
}