using CommunityTracker.Repository.RepositoryDTO;
using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServicesDTO;

namespace CommunityTracker.Service.Commands
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="CommunityTracker.Service.Interfaces.ICommunityServiceCommands" />
    public partial class CommunityServiceCommands : ICommunityServiceCommands
    {
        public async Task<CommunityResponseDTO> UpdateCommunity(CommunityDTO communityDTO)
        {
            var communityUpdate = new CommunityResponseDTO();

            var communities = await _communityRepositoryQuery.GetAllCommunities();
            var managers = await _communityRepositoryQuery.GetAllManagers();

            //checks if community is existing
            bool communityExists = communities.Any(x => x.CommunityName.ToLower() == communityDTO.CommunityName.ToLower());

            if (communityExists)
            {
                return null;
            }

            //checks if managerId is existing
            bool managerIdExists = managers.Any(x => x.CommunityAdminAndManagerId == communityDTO.CommunityMgrid);

            if (!managerIdExists)
            {
                return null;
            }

            await _communityRepositoryCommands.UpdateCommunity(new Community()
            {
                CommunityId = communityDTO.CommunityId,
                CommunityName = communityDTO.CommunityName,
                CommunityMgrid = communityDTO.CommunityMgrid,
                CommunityDesc = communityDTO.CommunityDesc
            });

            communityUpdate = await MapCommunityResponse(communityDTO);

            return communityUpdate;
        }
    }
}