using CommunityTracker.Repository.RepositoryDTO;
using CommunityTracker.Service.Helper;
using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServicesDTO;

namespace CommunityTracker.Service.Commands
{
    public partial class CommunityServiceCommands : ICommunityServiceCommands
    {
        /// <summary>Updates the community.</summary>
        /// <param name="communityDTO">The community dto.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public async Task<CommunityResponseDTO> UpdateCommunity(CommunityDTO communityDTO)
        {
            var communityUpdate = new CommunityResponseDTO();
            var serverErrorMsg = "Server Error";
            var communities = await _communityRepositoryQuery.GetAllCommunities();
            bool activeStatus = communities.Where(x => x.CommunityId == communityDTO.CommunityId).Select(x => x.IsActive).FirstOrDefault();
            try
            {
                var validation = await DataValidations.RequestValidation(_communityRepositoryQuery, communityDTO);

                if (validation == null || activeStatus == false)
                {
                    return null;
                };

                var response = await _communityRepositoryCommands.UpdateCommunity(new Community()
                {
                    CommunityId = communityDTO.CommunityId,
                    CommunityName = communityDTO.CommunityName,
                    CommunityMgrid = communityDTO.CommunityMgrid,
                    CommunityDesc = communityDTO.CommunityDesc
                });

                if (response.ResultMessage == serverErrorMsg)
                {
                    communityUpdate.ResultMessage = serverErrorMsg;
                    return communityUpdate;
                }

                communityUpdate = await MapCommunityResponse(communityDTO);
                communityUpdate.ResultMessage = "Success";
            }
            catch (Exception)
            {
                communityUpdate.ResultMessage = serverErrorMsg;
            }
            return communityUpdate;
        }
    }
}