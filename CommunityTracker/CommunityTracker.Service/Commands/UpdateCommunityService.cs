using CommunityTracker.Repository.RepositoryDTO;
using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServicesDTO;

namespace CommunityTracker.Service.Commands
{
    public partial class CommunityServiceCommands : ICommunityServiceCommands
    {
        public void UpdateCommunityService(CommunityDTO communityDTO)
        {
            var updateCommunity = new Community();
            updateCommunity.CommunityId = communityDTO.CommunityId;
            updateCommunity.CommunityName = communityDTO.CommunityName;
            updateCommunity.CommunityMgrid = communityDTO.CommunityMgrid;
            updateCommunity.CommunityDesc = communityDTO.CommunityDesc;

            _communityRepositoryCommands.UpdateCommunityRepository(updateCommunity);
        }
    }
}