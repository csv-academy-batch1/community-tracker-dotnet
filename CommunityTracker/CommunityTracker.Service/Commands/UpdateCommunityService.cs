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
        /// <summary>Updates the community service.</summary>
        /// <param name="communityDTO">The community dto.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public async Task<CommunityResponseDTO> UpdateCommunityService(CommunityDTO communityDTO)
        {
            var community = new CommunityResponseDTO();

            var communities = await _communityRepositoryQuery.GetAllCommunities();

            //checks if community is existing
            bool communityExists = communities.Any(x => x.CommunityName.ToLower() == communityDTO.CommunityName.ToLower());

            if (communityExists)
            {
                return null;
            }

            await _communityRepositoryCommands.UpdateCommunityRepository(new Community()
            {
                CommunityId = communityDTO.CommunityId,
                CommunityName = communityDTO.CommunityName,
                CommunityDesc = communityDTO.CommunityDesc,
                CommunityMgrid = communityDTO.CommunityMgrid,
            });

            community = await MapAddCommunityResponse(communityDTO);

            return community;
        }
    }
}