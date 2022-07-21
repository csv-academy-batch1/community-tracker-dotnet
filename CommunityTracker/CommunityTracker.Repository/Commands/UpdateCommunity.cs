using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Repository.RepositoryDTO;

namespace CommunityTracker.Repository.Commands
{
    public partial class CommunityRepositoryCommands : ICommunityRepositoryCommands
    {
        public async Task UpdateCommunity(Community communityData)
        {
            var communityUpdate = _communityDbContext.community.FirstOrDefault(x => x.CommunityId == communityData.CommunityId);
            if (communityUpdate != null)
            {
                communityUpdate.CommunityName = communityData.CommunityName;
                communityUpdate.CommunityMgrid = communityData.CommunityMgrid;
                communityUpdate.CommunityDesc = communityData.CommunityDesc;
                await SaveChangesAsync();
            }
        }
    }
}