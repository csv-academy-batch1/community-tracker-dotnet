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
            try
            {
                var community = new CommunityResponseDTO();

                var validation = await DataValidations.RequestValidation(_communityRepositoryQuery, communityDTO);

                if (validation == null)
                {
                    return null;
                }

                await _communityRepositoryCommands.AddCommunity(new Community()
                {
                    CommunityName = communityDTO.CommunityName,
                    CommunityDesc = communityDTO.CommunityDesc,
                    CommunityMgrid = communityDTO.CommunityMgrid,
                });

                community = await MapCommunityResponse(communityDTO);

                return community;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}