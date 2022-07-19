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
        public async Task<CommunityUpdateResponseDTO> UpdateCommunityService(Community communities)
        {
            var allcommunities = await _communityRepositoryQuery.GetAllCommunities();

            //checks if community is existing
            bool communityExists = allcommunities.Any(x => x.CommunityName.ToLower() == communities.CommunityName.ToLower());

            if (communityExists)
            {
                return null;
            }
            var manager = await _communityRepositoryQuery.GetAllManagers();
            var community = new CommunityUpdateResponseDTO();
            community.communityid = communities.CommunityId;
            community.communityname = communities.CommunityName;
            community.communitymanagername = manager.Where(x => x.CommunityAdminAndManagerId == communities.CommunityMgrid).Select(x => x.CommunityAdminAndManagerName).FirstOrDefault();
            community.communitydesc = communities.CommunityDesc;
            await _communityRepositoryCommands.UpdateCommunityRepository(communities);
            return community;
        }
    }
}