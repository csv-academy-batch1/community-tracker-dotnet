using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Repository.RepositoryDTO;


namespace CommunityTracker.Repository.Commands
{
    public partial class CommunityRepositoryCommands : ICommunityRepositoryCommands
    {
        public async Task DeleteCommunity(Community communityData)
        {
            var communityDelete = _communityDbContext.community.FirstOrDefault(x => x.CommunityId == communityData.CommunityId);
            //var status = communityData.IsActive;
            //status = false;
            if (communityDelete != null)
            {
                communityData.CommunityId = communityDelete.CommunityId;
                communityData.IsActive = false;
                await SaveChangesAsync();
            }
        }
    }
}
