using CommunityTracker.Repository.RepositoryDTO;
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

                //TODO: create separate method
                //Update with migz

                var communities = await _communityRepositoryQuery.GetAllCommunities();
                var managers = await _communityRepositoryQuery.GetAllManagers();

                //checks if community is existing
                bool communityExists = communities.Any(x => x.CommunityName.ToLower() == communityDTO.CommunityName.ToLower());

                //checks if managerId is existing
                bool managerIdExists = managers.Any(x => x.CommunityAdminAndManagerId == communityDTO.CommunityMgrid);

                if (communityExists || !managerIdExists)
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