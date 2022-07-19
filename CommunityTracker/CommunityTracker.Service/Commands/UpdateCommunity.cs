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
        /// <summary>
        /// Updates the community service.
        /// </summary>
        /// <param name="community">The community.</param>
        /// <returns></returns>
        public async Task<CommunityResponseDTO> UpdateCommunity(CommunityDTO community)
        {
            var coms = new CommunityResponseDTO();
            var communities = await _communityRepositoryQuery.GetAllCommunities();

            //checks if community is existing
            bool communityExists = communities.Any(x => x.CommunityName.ToLower() == community.CommunityName.ToLower());

            if (communityExists)
            {
                return null;
            }
            //communities.FirstOrDefault(x => x.CommunityId == community.CommunityId);
            await _communityRepositoryCommands.UpdateCommunity(new Community()
            {
                CommunityId = community.CommunityId,
                CommunityName = community.CommunityName,
                CommunityMgrid = community.CommunityMgrid,
                CommunityDesc = community.CommunityDesc
            });

            coms = await MapAddCommunityResponse(community);
            return coms;
        }
    }
}