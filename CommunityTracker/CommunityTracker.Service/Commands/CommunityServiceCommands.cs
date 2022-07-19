using CommunityTracker.Repository.Interfaces;
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
      
        private readonly ICommunityRepositoryCommands _communityRepositoryCommands;
        private readonly ICommunityRepositoryQueries _communityRepositoryQuery;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommunityServiceCommands"/> class.
        /// </summary>
        /// <param name="communityRepositoryCommands">The community repository commands.</param>
        /// <param name="communityRepositoryQuery">The community repository query.</param>
        public CommunityServiceCommands(ICommunityRepositoryCommands communityRepositoryCommands,
            ICommunityRepositoryQueries communityRepositoryQuery)
        {
            _communityRepositoryCommands = communityRepositoryCommands;
            _communityRepositoryQuery = communityRepositoryQuery;
        }

        /// <summary>
        /// Maps the community to response.
        /// </summary>
        /// <param name="communityDTO">The community dto.</param>
        /// <returns></returns>
        private async Task<CommunityResponseDTO> MapCommunityResponse(CommunityDTO communityDTO)
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
                CommunityDesc = community.CommunityDesc
            };

            return result;
        }
    }
}