using CommunityTracker.Repository.RepositoryDTO;
using CommunityTracker.Service.ServicesDTO;
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
        /// <summary>
        /// Adds the community service.
        /// </summary>
        /// <param name="communityDTO">The community dto.</param>
        /// <returns></returns>
        public async Task<CommunityResponseDTO> AddCommunityService(CommunityDTO communityDTO)
        {
            try
            {
                var community = new CommunityResponseDTO();

                var communities = await _communityRepositoryQuery.GetAllCommunities();
                
                //checks if community is existing
                bool communityExists = communities.Any(x => x.CommunityName.ToLower() == communityDTO.CommunityName.ToLower());
                             
                if (communityExists)
                {
                    return null;
                }

                await _communityRepositoryCommands.AddCommunityRepository(new Community()
                {
                    CommunityName = communityDTO.CommunityName,
                    CommunityDesc = communityDTO.CommunityDesc,
                    CommunityMgrid = communityDTO.CommunityMgrid,
                });

                community = await MapAddCommunityResponse(communityDTO);
             
                return community;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Maps the add community response.
        /// </summary>
        /// <param name="communityDTO">The community dto.</param>
        /// <returns></returns>
        private async Task<CommunityResponseDTO> MapAddCommunityResponse(CommunityDTO communityDTO)
        {
            var community = await _communityRepositoryQuery.GetCommunitiesWithManagerName(communityDTO.CommunityMgrid, communityDTO.CommunityName);
            
            var result = new CommunityResponseDTO()
            {
                CommunityId = community.CommunityId,
                CommunityName = community.CommunityName,
                CommunityManagerName = community.CommunityAdminAndManagerName,
                CommunityDesc = community.CommunityDesc
            };

            return result;
        }
    }
}