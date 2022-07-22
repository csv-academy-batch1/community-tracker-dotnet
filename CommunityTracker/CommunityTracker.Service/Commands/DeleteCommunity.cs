using CommunityTracker.Repository.RepositoryDTO;
using CommunityTracker.Service.Helper;
using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServicesDTO;

namespace CommunityTracker.Service.Commands
{
    public partial class CommunityServiceCommands : ICommunityServiceCommands
    {
        /// <summary>Deletes the community.</summary>
        /// <param name="request">The request.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public async Task<CommunityResponseDTO> DeleteCommunity(CommunityDTO request)
        { 
            var community = new CommunityResponseDTO();
            var serverErrorMsg = "Server Error";

            try
            {
                var communityDataExists = await DataValidations.CommunityIdStatusValidation(_communityRepositoryQuery, request);
              
                if (communityDataExists == null)
                {
                    return null;
                }

                var response = await _communityRepositoryCommands.DeleteCommunity(new Community()
                {
                    CommunityId = request.CommunityId,
                    IsActive = request.IsActive
                });
                
                var getCommunityData = await _communityRepositoryQuery.GetCommunityById(request.CommunityId);
                community.CommunityId = getCommunityData.CommunityId;
                community.isActive = getCommunityData.IsActive;

                if (response.ResultMessage == serverErrorMsg)
                {
                    community.ResultMessage = serverErrorMsg;
                    return community;
                }
                community.ResultMessage = "Success";

            }
            catch (Exception)
            {
                community.ResultMessage = serverErrorMsg;
            }
            
            return community;
        }
    }
}
