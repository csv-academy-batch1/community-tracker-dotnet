using CommunityTracker.Repository.Entities;
using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServicesDTO;

namespace CommunityTracker.Service.Command
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
        public async Task<CommunityUpdateResponseDTO> UpdateCommunityService(Community community)
        {
            var coms = new CommunityUpdateResponseDTO();
            coms.communityid = community.CommunityId;
            coms.communityname = community.CommunityName;
            coms.communitymanagername = community.CommunityName;
            coms.communitydesc = community.CommunityDesc;
            await _communityRepositoryCommands.UpdateCommunityRepository(community);
            return coms;
        }
    }
}