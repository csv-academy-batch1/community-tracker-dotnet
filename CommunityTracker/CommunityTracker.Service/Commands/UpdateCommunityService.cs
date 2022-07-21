using CommunityTracker.Repository.RepositoryDTO;
using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServicesDTO;

namespace CommunityTracker.Service.Commands
{
    public partial class CommunityServiceCommands : ICommunityServiceCommands
    {
        public async Task<CommunityResponseDTO> UpdateCommunity(CommunityDTO community)
        {

            var communityResponseDTO = new CommunityResponseDTO();
            var getCommunities = await _communityRepositoryQuery.GetAllCommunities();

            bool duplicatedComName = getCommunities.Any(x => x.CommunityName.ToLower() == community.CommunityName.ToLower());

            if (duplicatedComName)
            {
                return null;
            }

            await _communityRepositoryCommands.UpdateCommunity(new Community()

            {
                CommunityId = community.CommunityId,
                CommunityName = community.CommunityName,
                CommunityMgrid = community.CommunityMgrid,
                CommunityDesc = community.CommunityDesc
            });

            communityResponseDTO = await MapAddCommunityResponse(community);
            return communityResponseDTO;
        }
    }
}