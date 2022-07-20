using CommunityTracker.Repository.RepositoryDTO;
using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServicesDTO;

namespace CommunityTracker.Service.Commands
{
    public partial class CommunityServiceCommands : ICommunityServiceCommands
    {
        public async Task<CommunityResponseDTO> UpdateCommunity(CommunityDTO communityDTO)
        {
            var communityUpdate = new CommunityResponseDTO();

            var communities = await _communityRepositoryQuery.GetAllCommunities();

            bool communityNameExists = communities.Any(x => x.CommunityName.ToLower() == communityDTO.CommunityName.ToLower());

            bool communityIdExists = communities.Any(x => x.CommunityId == null);

            if (communityNameExists || communityIdExists)
            {
                return null;
            }

            //var communityIdFilter = communities.First(x => x.CommunityId == communityDTO.CommunityId);

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