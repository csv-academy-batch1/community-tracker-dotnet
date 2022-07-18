using CommunityTracker.Repository.Entities;
using CommunityTracker.Service.DTO;
using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServicesDTO;

namespace CommunityTracker.Service.Command
{
    public partial class CommunityServiceCommands : ICommunityServiceCommands
    {
        public void UpdateCommunityService(CommunityDTO communityDTO)
        {
            var updateCommunity = new Community();
            updateCommunity.CommunityId = communityDTO.communityid;
            updateCommunity.CommunityName = communityDTO.communityname;
            updateCommunity.CommunityDesc = communityDTO.communitydesc;
            updateCommunity.CommunityMgrid = communityDTO.communitymgrid;
            this._communityRepositoryCommands.UpdateCommunityRepository(updateCommunity);
        }
    }
}