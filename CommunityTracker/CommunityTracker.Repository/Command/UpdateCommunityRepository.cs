using CommunityTracker.Repository.Entities;
using CommunityTracker.Repository.Interfaces;
namespace CommunityTracker.Repository.Command
{
    public partial class CommunityRepositoryCommands : ICommunityRepositoryCommands
    {
        public void UpdateCommunityRepository(Community communityData)
        {
            //var community = this._communityDbContext.community.First(x => x.CommunityId == communityData.CommunityId);
            //if (community != null)
            //{
            //    community.CommunityName = communityData.CommunityName;
            //    community.CommunityMgrid = communityData.CommunityMgrid;
            //    community.CommunityDesc = communityData.CommunityDesc;
            //    community.IsActive = communityData.IsActive;
            //}
            _communityDbContext.Update(communityData);
            _communityDbContext.SaveChanges();
        }
    }
}