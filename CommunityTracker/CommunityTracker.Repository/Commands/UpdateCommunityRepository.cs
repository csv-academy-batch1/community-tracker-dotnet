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
        /// <summary>Updates the community repository.</summary>
        /// <param name="communityData">The community data.</param>
        public async Task UpdateCommunityRepository(Community communityData)
        {
            var communities = _communityDbContext.community.FirstOrDefault(c => c.CommunityId == communityData.CommunityId);

            if (communities != null)
            {
                communities.CommunityId = communityData.CommunityId;
                communities.CommunityName = communityData.CommunityName;
                communities.CommunityMgrid = communityData.CommunityMgrid;
                communities.CommunityDesc = communityData.CommunityDesc;
            }

            await _communityDbContext.SaveChangesAsync();
        }
    }
}