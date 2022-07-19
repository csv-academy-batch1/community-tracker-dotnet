using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Repository.RepositoryDTO;

namespace CommunityTracker.Repository.Commands
{
    public partial class CommunityRepositoryCommands : ICommunityRepositoryCommands
    {
        public async Task UpdateCommunityRepository(Community communityData)
        {
            var community = this._communityDbContext.community.FirstOrDefault(x => x.CommunityId == communityData.CommunityId);
            if (community != null)
            {
                community.CommunityName = communityData.CommunityName;
                community.CommunityMgrid = communityData.CommunityMgrid;
                community.CommunityDesc = communityData.CommunityDesc;
                community.IsActive = communityData.IsActive;
            }
            await _communityDbContext.SaveChangesAsync();
        }
    }
}