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

            await _communityRepositoryCommands.UpdateCommunity(new Community()
            {
                CommunityId = community.CommunityId,
                CommunityName = community.CommunityName,
                CommunityMgrid = community.CommunityMgrid,
                CommunityDesc = community.CommunityDesc
            });

            coms = await MapAddCommunityResponse(community);
            //var manager = await _communityRepositoryQuery.GetAllManagers();
            //var updateCommunity = new CommunityUpdateResponseDTO();
            //updateCommunity.communityid = community.CommunityId;
            //updateCommunity.communityname = community.CommunityName;
            //updateCommunity.communitymgrid = community.CommunityMgrid;
            //updateCommunity.communitymanagername = manager.Where(x => x.CommunityAdminAndManagerId == community.CommunityMgrid).Select(x => x.CommunityAdminAndManagerName).FirstOrDefault();
            //updateCommunity.communitydesc = community.CommunityDesc;
            //await _communityRepositoryCommands.UpdateCommunity(community);
            return coms;
        }
    }
}