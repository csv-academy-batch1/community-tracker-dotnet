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

            var validation = await ResponseValidation(communityDTO);

            if (validation == null)
            {
                return validation;
            }

            await _communityRepositoryCommands.UpdateCommunity(new Community()
            {
                CommunityId = communityDTO.CommunityId,
                CommunityName = communityDTO.CommunityName,
                CommunityMgrid = communityDTO.CommunityMgrid,
                CommunityDesc = communityDTO.CommunityDesc
            });

            communityUpdate = await MapAddCommunityResponse(communityDTO);

            return communityUpdate;
        }
    }
}