using CommunityTracker.Repository.RepositoryDTO;
using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServicesDTO;

namespace CommunityTracker.Service.Commands
{
    public partial class CommunityServiceCommands : ICommunityServiceCommands
    {
        public async Task<CommunityUpdateDTO> UpdateCommunityService(Community community)
        {
            var managers = await _communityRepositoryQuery.GetAllManagers();

            var communities = await _communityRepositoryQuery.GetAllCommunities();

            //checks if community is existing
            bool communityExists = communities.Any(x => x.CommunityName.ToLower() == community.CommunityName.ToLower());

            if (communityExists)
            {
                return null;
            }

            var updateCommunity = new CommunityUpdateDTO();
            updateCommunity.CommunityId = community.CommunityId;
            updateCommunity.CommunityName = community.CommunityName;
            updateCommunity.CommunityManager = managers.Where(x => x.CommunityAdminAndManagerId == community.CommunityMgrid).Select(x => x.CommunityAdminAndManagerName).FirstOrDefault();
            updateCommunity.CommunityDesc = community.CommunityDesc;
            updateCommunity.IsActive = community.IsActive;
            
            _communityRepositoryCommands.UpdateCommunityRepository(community);

            return updateCommunity;
        }
    }
}