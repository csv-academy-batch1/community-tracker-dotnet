using CommunityTracker.Repository.RepositoryDTO;
using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServicesDTO;

namespace CommunityTracker.Service.Commands
{
    public partial class CommunityServiceCommands : ICommunityServiceCommands
    {
        public async Task<CommunityUpdateDTO> UpdateCommunityService(Community communityDTO)
        {
            var managers = await _communityRepositoryQuery.GetAllManagers();

            var communities = await _communityRepositoryQuery.GetAllCommunities();

            //checks if community is existing
            bool communityExists = communities.Any(x => x.CommunityName.ToLower() == communityDTO.CommunityName.ToLower());

            if (communityExists)
            {
                return null;
            }

            var updateCommunity = new CommunityUpdateDTO();
            updateCommunity.CommunityId = communityDTO.CommunityId;
            updateCommunity.CommunityName = communityDTO.CommunityName;
            updateCommunity.CommunityManager = managers.Where(x => x.CommunityAdminAndManagerId == communityDTO.CommunityMgrid).Select(x => x.CommunityAdminAndManagerName).FirstOrDefault();
            updateCommunity.CommunityDesc = communityDTO.CommunityDesc;
            
            _communityRepositoryCommands.UpdateCommunityRepository(communityDTO);

            return updateCommunity;
        }
    }
}