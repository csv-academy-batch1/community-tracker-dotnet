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
        public async Task UpdateCommunity(Community communityData)
        {
            var community = _communityDbContext.community.FirstOrDefault(x => x.CommunityId == communityData.CommunityId);

            if (community != null)
            {
                community.CommunityName = communityData.CommunityName;
                community.CommunityMgrid = communityData.CommunityMgrid;
                community.CommunityDesc = communityData.CommunityDesc;
            }

            await SaveChangesAsync();
        }
    }
}