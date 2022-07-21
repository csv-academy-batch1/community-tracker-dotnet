using CommunityTracker.Repository.RepositoryDTO;
using CommunityTracker.Service.Helper;
using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServicesDTO;

namespace CommunityTracker.Service.Commands
{
    /// <summary>
    /// CommunityServiceCommands
    /// </summary>
    /// <seealso cref="CommunityTracker.Service.Interfaces.ICommunityServiceCommands" />
    public partial class CommunityServiceCommands : ICommunityServiceCommands
    {
        /// <summary>
        /// Add community service.
        /// </summary>
        /// <param name="communityDTO">The community dto.</param>
        /// <returns></returns>
        public async Task<CommunityResponseDTO> AddCommunity(CommunityDTO communityDTO)
        {
            var community = new CommunityResponseDTO();
            var serverErrorMsg = "Server Error";
            try
            {
                var validation = await DataValidations.RequestValidation(_communityRepositoryQuery, communityDTO);

                if (validation == null)
                {
                    return null;
                };

                var response = await _communityRepositoryCommands.AddCommunity(new Community()
                {
                    CommunityName = communityDTO.CommunityName,
                    CommunityDesc = communityDTO.CommunityDesc,
                    CommunityMgrid = communityDTO.CommunityMgrid,
                });

                if (response.ResultMessage == serverErrorMsg)
                {
                    community.ResultMessage = serverErrorMsg;
                    return community;
                }

                community = await MapAddCommunityResponse(communityDTO);
                community.ResultMessage = "Success";
            }
            catch (Exception)
            {
                community.ResultMessage = serverErrorMsg;
            }

            return community;
        }

        /// <summary>
        /// Maps the community to response.
        /// </summary>
        /// <param name="communityDTO">The community dto.</param>
        /// <returns></returns>
        private async Task<CommunityResponseDTO> MapAddCommunityResponse(CommunityDTO communityDTO)
        {
            var community = await _communityRepositoryQuery.GetCommunitiesWithManagerName(communityDTO.CommunityMgrid, communityDTO.CommunityName);

            if (community == null)
            {
                return null;
            }

            var result = new CommunityResponseDTO()
            {
                CommunityId = community.CommunityId,
                CommunityName = community.CommunityName,
                CommunityManagerName = community.CommunityAdminAndManagerName,
                CommunityDesc = community.CommunityDesc,
                isActive = community.isActive
            };

            return result;
        }
    }
}